Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Runtime.Intrinsics.Arm
Imports System.Xml
Imports Google.Protobuf
Imports TransitRealtime

Public Class TrainBoard
    Private StopIdToStation As Dictionary(Of String, String) = Nothing
    Private RouteDictionary As Dictionary(Of String, RouteInfo) = Nothing

    Dim ExpressZones As New Dictionary(Of String, List(Of String))
    Dim PreviousTitle As String
    Dim showNGR = False

    Private Sub LoadExpressZones(csvUrl)
        Try
            Using client As New WebClient()
                Dim csvText As String = client.DownloadString(csvUrl)
                Using reader As New StringReader(csvText)
                    Dim lines = csvText.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                    If lines.Length < 2 Then Exit Sub

                    ' First line = route IDs
                    Dim headers = lines(0).Split(","c)

                    ' Initialize lists
                    For Each h In headers
                        ExpressZones(h.Trim()) = New List(Of String)
                    Next

                    ' Go through each subsequent line (stations)
                    For i = 1 To lines.Length - 1
                        Dim parts = lines(i).Split(","c)
                        For j = 0 To Math.Min(headers.Length - 1, parts.Length - 1)
                            Dim route = headers(j).Trim()
                            Dim stopName = parts(j).Trim()
                            If Not String.IsNullOrEmpty(stopName) Then
                                ExpressZones(route).Add(stopName)
                            End If
                        Next
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load ExpressZones.csv: " & ex.Message)
        End Try
    End Sub

    Private Async Function InitializeMappingsAsync() As Task
        ' URLs for your hosted CSV files - change them if you wish (no guarantee I will remember to update mine lol)
        Dim stopCsvUrl = "https://jrid4.xyz/DepartureBoards/Train/StopIds.csv"
        Dim routeCsvUrl = "https://jrid4.xyz/DepartureBoards/Train/RouteExp.csv"
        Dim EZcsvUrl = "https://jrid4.xyz/DepartureBoards/Train/ExpressZones.csv"

        StopIdToStation = Await LoadStopIdMappingAsync(stopCsvUrl)
        RouteDictionary = Await LoadRouteMappingAsync(routeCsvUrl)
        LoadExpressZones(EZcsvUrl) ' I need to make this like the other two at some point
    End Function

    Dim ServStopVar1
    Dim ServStopVar2

    Private Sub ShowServiceStopsForDeparture(dep As DepartureData, trip As TransitRealtime.TripUpdate)
        If dep Is Nothing Then
            MessageBox.Show("ShowServiceStopsForDeparture called with Nothing for dep — check source data.")
            Exit Sub
        End If
        If trip Is Nothing Then
            MessageBox.Show("Trip data missing for some reason - cannot continue.")
            Exit Sub
        End If

        Try
            If trip Is Nothing OrElse trip.StopTimeUpdate Is Nothing OrElse trip.StopTimeUpdate.Count = 0 Then
                MessageBox.Show("Trip data missing.")
                Return
            End If

            ' Get route code prefix (e.g. BDVL, CABR, etc.)
            Dim routeKey As String = dep.RouteId
            If routeKey.Length > 4 Then routeKey = routeKey.Substring(0, 4)

            ' Find index of the current stop in stopTimeUpdate
            Dim currentIndex As Integer = -1
            For i = 0 To trip.StopTimeUpdate.Count - 1
                Dim stu = trip.StopTimeUpdate(i)
                Dim stuStopId As String = stu.StopId
                ' prefer assignedStopId if present
                If stu.StopTimeProperties IsNot Nothing AndAlso Not String.IsNullOrEmpty(stu.StopTimeProperties.AssignedStopId) Then
                    stuStopId = stu.StopTimeProperties.AssignedStopId
                End If

                If dep Is Nothing Then
                    MessageBox.Show("dep is Nothing — something went wrong with the data passed in.")
                    Exit Sub
                End If


                If stuStopId = dep.StopId Then
                    currentIndex = i
                    Exit For
                End If
            Next

            If currentIndex = -1 Then
                MessageBox.Show("Current stop not found in trip stop list.")
                Return
            End If

            ' Collect subsequent stops (strictly after the current one)
            Dim subsequentStops As New List(Of String)
            For j = currentIndex + 1 To trip.StopTimeUpdate.Count - 1
                Dim sstu = trip.StopTimeUpdate(j)
                Dim sStopId As String = sstu.StopId
                If sstu.StopTimeProperties IsNot Nothing AndAlso Not String.IsNullOrEmpty(sstu.StopTimeProperties.AssignedStopId) Then
                    sStopId = sstu.StopTimeProperties.AssignedStopId
                End If
                subsequentStops.Add(sStopId)
            Next

            ' Map to station names (use StopIdToStation; fallback to raw id if missing)
            Dim subsequentNames As New List(Of String)
            For Each sid In subsequentStops
                Dim name As String = sid
                If StopIdToStation IsNot Nothing AndAlso StopIdToStation.ContainsKey(sid) Then
                    name = StopIdToStation(sid).Split("|"c).First().Trim()
                End If
                subsequentNames.Add(name)
            Next

            Dim allLabels As New List(Of String)

            For Each nm In subsequentNames
                If nm = "Glass House Mountains" Then
                    allLabels.Add("Glasshouse MT") ' exception because its too long
                Else
                    allLabels.Add(nm) ' regular stop
                End If

                ' Add Express marker if applicable
                If ExpressZones.ContainsKey(routeKey) AndAlso
       ExpressZones(routeKey).Any(Function(s) String.Equals(s, nm, StringComparison.OrdinalIgnoreCase)) Then
                    allLabels.Add("    express")
                End If
            Next

            Dim total As Integer = allLabels.Count

            If StopList10 Is Nothing Then
                MessageBox.Show("StopList10 panel not found.")
                Return
            End If

            Dim hasAirport As Boolean = subsequentNames.Any(Function(nm) nm.IndexOf("Airport", StringComparison.OrdinalIgnoreCase) >= 0)

            ' Determine layout: rows, columns, label size and font
            Dim rows As Integer = 0
            Dim cols As Integer = 0
            Dim lblWidth As Integer = 400
            Dim lblHeight As Integer = 72
            Dim fontSize As Single = 39.75F

            If hasAirport Then
                If total > 24 Then
                    MessageBox.Show("Too many stops (>24) — not supported.")
                    Return
                ElseIf total >= 17 Then
                    rows = 8 : cols = 3 : lblWidth = 295 : lblHeight = 35 : fontSize = 20.25F
                ElseIf total >= 9 Then
                    rows = 6 : cols = 2 : lblWidth = 430 : lblHeight = 35 : fontSize = 20.25F
                ElseIf total >= 1 Then
                    rows = 5 : cols = 2 : lblWidth = 430 : lblHeight = 58 : fontSize = 34.2
                Else
                    MessageBox.Show("Stop count falls outside supported ranges.")
                    Return
                End If
            Else
                If total > 48 Then
                    MessageBox.Show("Too many stops (>48) — not supported.")
                    Return
                ElseIf total >= 37 Then
                    rows = 12 : cols = 4 : lblWidth = 223 : lblHeight = 30 : fontSize = 19.25F
                ElseIf total >= 31 Then
                    rows = 10 : cols = 4 : lblWidth = 223 : lblHeight = 38 : fontSize = 19.75F
                ElseIf total >= 28 Then
                    rows = 10 : cols = 3 : lblWidth = 295 : lblHeight = 38 : fontSize = 21.25F
                ElseIf total >= 25 Then
                    rows = 9 : cols = 3 : lblWidth = 295 : lblHeight = 41 : fontSize = 23.25F
                ElseIf total >= 17 Then
                    rows = 8 : cols = 3 : lblWidth = 297 : lblHeight = 46 : fontSize = 23.25F
                ElseIf total >= 15 Then
                    rows = 8 : cols = 2 : lblWidth = 400 : lblHeight = 48 : fontSize = 29.75F
                ElseIf total >= 13 Then
                    rows = 7 : cols = 2 : lblWidth = 420 : lblHeight = 57 : fontSize = 32.75F
                ElseIf total >= 7 Then
                    rows = 6 : cols = 2 : lblWidth = 430 : lblHeight = 62 : fontSize = 38.75F
                ElseIf total >= 1 Then
                    rows = 7 : cols = 1 : lblWidth = 600 : lblHeight = 64 : fontSize = 36.75F
                Else
                    MessageBox.Show("Stop count falls outside supported ranges.")
                    Return
                End If
            End If

            ' If any subsequent name contains "Airport", show Airtrain logo and adjust offsets
            If hasAirport Then
                AirtrainLogo.Visible = True
                _stopListDesignHeight = 345
            Else
                AirtrainLogo.Visible = False
                _stopListDesignHeight = 460
            End If

            ' Prepare ServiceStops background color from RouteDictionary using same logic as UpdateTrainPanels
            Dim prefixKey As String = dep.RouteId
            If Not String.IsNullOrEmpty(prefixKey) AndAlso prefixKey.Length >= 4 Then
                prefixKey = prefixKey.Substring(0, 4)
            Else
                prefixKey = prefixKey ' may be empty
            End If

            Dim colorHex As String = "#CCCCCC"
            If RouteDictionary IsNot Nothing AndAlso RouteDictionary.ContainsKey(prefixKey) Then
                colorHex = RouteDictionary(prefixKey).RouteColor
            End If

            ' Convert to Color and set ServiceStops.BackColor (ServiceStops expects Color)
            Try
                Dim routeColor = ColorTranslator.FromHtml(colorHex)
                ServiceStops.BackColor = routeColor
                AirtrainLogo.BackColor = routeColor
            Catch
                ServiceStops.BackColor = Color.Gray
            End Try

            StopListLabel.Text = E1_Time.Text & " to " & E1_Service.Text
            StopListCdn.Text = E1_Countdown.Text
            BoardTitle.Text = "Platform " & E1_Platform.Text

            ' --- Only rebuild stop list if the data actually changed ---
            Dim existingLabels = StopList10.Controls.OfType(Of Label)().Select(Function(l) l.Text).ToList()

            If Not existingLabels.SequenceEqual(allLabels) Then
                StopList10.SuspendLayout()

                StopList10.Controls.Clear()
                StopList10.FlowDirection = FlowDirection.TopDown
                StopList10.WrapContents = True
                StopList10.AutoScroll = True

                For Each lblText In allLabels
                    Dim lbl As New Label() With {
            .AutoSize = False,
            .ForeColor = Color.White,
            .TextAlign = ContentAlignment.MiddleLeft,
            .Text = lblText,
            .BackColor = Color.Transparent,
            .Padding = New Padding(0),
            .Tag = New StopLabelDesign With {.W = lblWidth, .H = lblHeight, .FontPt = fontSize}
        }
                    StopList10.Controls.Add(lbl)
                Next

                StopList10.ResumeLayout()
            End If

            ApplyStopListScale()

            ServiceStops.Visible = True
            DepartsTitle.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error building stop list: " & ex.Message)
        End Try
    End Sub

    Private Class StopLabelDesign
        Public W As Integer, H As Integer, FontPt As Single
    End Class
    Private _stopListDesignHeight As Integer = 460
    Private _stopFont As Font

    Private Sub ApplyStopListScale()
        If _scaler Is Nothing Then Return
        Dim s = _scaler.Scale
        StopList10.SuspendLayout()

        StopList10.Size = New Size(_scaler.Px(920), CInt(Math.Ceiling(_stopListDesignHeight * s)))
        Dim m = CInt(Math.Floor(3 * s))

        Dim newFont As Font = Nothing
        For Each lbl In StopList10.Controls.OfType(Of Label)()
            Dim d = TryCast(lbl.Tag, StopLabelDesign)
            If d Is Nothing Then Continue For
            If newFont Is Nothing Then newFont = New Font("Arial", d.FontPt * s, FontStyle.Bold, GraphicsUnit.Point)
            lbl.Size = New Size(CInt(Math.Floor(d.W * s)), CInt(Math.Floor(d.H * s)))
            lbl.Margin = New Padding(m)
            lbl.Font = newFont
        Next
        StopList10.ResumeLayout(True)

        If _stopFont IsNot Nothing Then _stopFont.Dispose()
        _stopFont = newFont
    End Sub

    ' Helper clone function for Label since Label.Clone() isn't built-in in WinForms
    Private Function CloneLabelTemplate(template As Label) As Label
        If template Is Nothing Then Return Nothing
        Dim l As New Label()
        l.AutoSize = False
        l.TextAlign = template.TextAlign
        l.Font = template.Font
        l.ForeColor = template.ForeColor
        l.BackColor = template.BackColor
        l.Padding = template.Padding
        l.Margin = template.Margin
        Return l
    End Function


    Private Async Function LoadStopIdMappingAsync(url As String) As Task(Of Dictionary(Of String, String))
        Dim dict As New Dictionary(Of String, String)
        Using client As New HttpClient()
            Dim data = Await client.GetStringAsync(url)
            Dim lines = data.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            For Each line In lines.Skip(1) ' skip header row
                Dim parts = line.Split(","c)
                If parts.Length >= 3 Then
                    Dim stopId = parts(0).Trim()
                    Dim station = parts(1).Trim()
                    Dim platform = parts(2).Trim()

                    ' store as "Central|3"
                    dict(stopId) = station & "|" & platform
                End If
            Next
        End Using
        Return dict
    End Function

    Private Async Function LoadRouteMappingAsync(url As String) As Task(Of Dictionary(Of String, RouteInfo))
        Dim dict As New Dictionary(Of String, RouteInfo)
        Using client As New HttpClient()
            Dim data = Await client.GetStringAsync(url)
            Dim lines = data.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            For Each line In lines.Skip(1)
                Dim parts = line.Split(","c)
                ' parts(0) = RouteId, parts(1) = RouteName, parts(2) = RouteColor, parts(3) = ExpressTrain
                dict(parts(0).Trim()) = New RouteInfo With {
                    .RouteName = parts(1).Trim(),
                    .RouteColor = parts(2).Trim(),
                    .ExpressTrain = If(parts.Length > 3, parts(3).Trim(), "")
                }
            Next
        End Using
        Return dict
    End Function

    Public Property CustomStopIds As String() =
        {"600016", "600020", "600024"}
    Private TripIdToLabel As New Dictionary(Of String, String)
    Private TickerText As String = "        For your comfort, Quiet Carriages 2nd and 2nd Last car of every train.           "
    Private ScrollOffset As Integer = 0
    Private ScrollSpeed As Integer = 2 ' pixels per tick

    Private _scaler As UniformScaler
    Private Async Sub MainBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 6
            Dim ngr = Controls.Find($"E{i}_NGR_2", True).FirstOrDefault()
            If ngr IsNot Nothing Then
                ngr.Left -= 4
                ngr.Width += 8
            End If
        Next
        _scaler = New UniformScaler(Me)
        AddHandler _scaler.ScaleChanged, AddressOf ApplyStopListScale
        Me.MinimumSize = Me.SizeFromClientSize(New Size(480, 270))

        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
        TickerPanel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic).SetValue(TickerPanel, True)

        Me.KeyPreview = True

        Dim args() As String = Environment.GetCommandLineArgs()
        Dim stopIds As String() = Nothing

        For i As Integer = 0 To args.Length - 1
            Select Case args(i).ToLower()
                Case "-stopid"
                    If i + 1 < args.Length Then
                        ' Split the comma-separated list into an array
                        stopIds = args(i + 1).Split(","c)

                        ' Assign it directly to CustomStopIds
                        If stopIds IsNot Nothing AndAlso stopIds.Length > 0 Then
                            CustomStopIds = stopIds
                        End If
                    End If

                Case "-fullscreen"
                    ' Set size
                    ' Me.MinimumSize = New Size(960, 540)
                    ' Me.MaximumSize = New Size(960, 540)
                    ' Remove border and maximize
                    Me.FormBorderStyle = FormBorderStyle.None
                    Me.WindowState = FormWindowState.Maximized

                Case "-boardtitle"
                    If i + 1 < args.Length Then
                        BoardTitle.Text = args(i + 1)
                    End If
                Case "-showngr"
                    showNGR = True
            End Select
        Next

        Await InitializeMappingsAsync()

        Timer1.Start()
        RefreshTimer.Start()
    End Sub

    Private Sub MainBoard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
        End
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check for Alt + F
        If e.Alt AndAlso e.KeyCode = Keys.F Then
            If Me.FormBorderStyle = FormBorderStyle.None Then
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = FormBorderStyle.Sizable
                Me.ClientSize = _scaler.BaseClientSize
            Else
                Me.FormBorderStyle = FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
            End If
            e.Handled = True
        End If
        ' Check for Alt + Q
        If e.Alt AndAlso e.KeyCode = Keys.Q Then
            If ServiceStops.Visible = True Then
                ServiceStops.Visible = False
                DepartsTitle.Visible = False
                BoardTitle.Text = PreviousTitle
            Else
                PreviousTitle = BoardTitle.Text
                ShowServiceStopsForDeparture(ServStopVar1, ServStopVar2)
            End If
            e.Handled = True
        End If
        ' Check for Alt + N
        If e.Alt AndAlso e.KeyCode = Keys.N Then
            If showNGR = True Then
                showNGR = False
            Else
                showNGR = True
            End If
            RefreshTimer_Tick(Nothing, EventArgs.Empty)
            e.Handled = True
        End If
        ' Check for Alt + R
        If e.Alt AndAlso e.KeyCode = Keys.R Then
            RefreshTimer_Tick(Nothing, EventArgs.Empty)
            e.Handled = True
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles BoardTitle.DoubleClick
        TitleChange.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.DoubleClick
        StopIDChange.Show()
    End Sub

    Private Sub NoDepMsg_Click(sender As Object, e As EventArgs) Handles NoDepMsg.DoubleClick
        NoDepChange.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BoardClock.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Async Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        Dim stopIds As String() = CustomStopIds
        Dim departures = Await GetDeparturesFromTranslink(stopIds)
        UpdateTrainPanels(departures)
    End Sub

    Private Async Function GetDeparturesFromTranslink(stopIds As IEnumerable(Of String)) As Task(Of List(Of DepartureData))
        Dim results As New List(Of DepartureData)

        If results.Count > 0 Then
            ServStopVar1 = results(0)
        End If

        Try
            Using client As New HttpClient()
                Dim data As Byte() = Await client.GetByteArrayAsync("https://gtfsrt.api.translink.com.au/api/realtime/SEQ/TripUpdates/Rail")

                Dim feed As New FeedMessage()

                Using stream As New MemoryStream(data)
                    feed.MergeFrom(stream)
                End Using

                TripIdToLabel.Clear()

                For Each entity In feed.Entity
                    If entity.TripUpdate IsNot Nothing Then
                        Dim trip = entity.TripUpdate
                        Dim routeId = trip.Trip.RouteId
                        Dim label As String
                        Dim tripId = trip.Trip.TripId
                        Dim FinalStop = trip.StopTimeUpdate(trip.StopTimeUpdate.Count - 1).StopId
                        label = If(trip.Trip.TripId.Length >= 4, trip.Trip.TripId(trip.Trip.TripId.Length - 4), "")
                        If Not String.IsNullOrEmpty(tripId) AndAlso Not String.IsNullOrEmpty(label) Then
                            TripIdToLabel(tripId) = label
                        End If

                        For Each StopUpdate In trip.StopTimeUpdate
                            If stopIds.Contains(StopUpdate.StopId) Then
                                Dim departureUnix = StopUpdate.Departure?.Time
                                If departureUnix.HasValue Then
                                    Dim departureTime = DateTimeOffset.FromUnixTimeSeconds(departureUnix.Value).ToLocalTime()

                                    If departureTime > DateTimeOffset.Now Then
                                        results.Add(New DepartureData With {
                            .DepartureTime = departureTime,
                            .RouteId = routeId,
                            .CutLabel = label,
                            .StopId = StopUpdate.StopId,
                            .TripId = tripId,
                            .FinalStop = FinalStop
                        })
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next

                ' --- Sort and cache the top train properly ---
                results = results.OrderBy(Function(d) d.DepartureTime).Take(6).ToList()

                If results.Count > 0 Then
                    ServStopVar1 = results(0)
                    ServStopVar2 = feed.Entity.
        FirstOrDefault(Function(e) e.TripUpdate IsNot Nothing AndAlso e.TripUpdate.Trip.TripId = results(0).TripId)?.TripUpdate
                End If


                results = results.OrderBy(Function(d) d.DepartureTime).Take(6).ToList()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching GTFS-RT data: " & ex.Message)
        End Try

        Return results
    End Function

    Private Sub UpdateTrainPanels(departures As List(Of DepartureData))
        For i = 0 To 5
            If i = 0 Then
                If (departures.Count = 0) Then
                    DisplayPanel.Visible = False
                    NoDepMsg.Visible = True
                    BoardTitle.Visible = False
                Else
                    DisplayPanel.Visible = True
                    NoDepMsg.Visible = False
                    BoardTitle.Visible = True
                End If
            End If

            Dim entryName = $"Entry{i + 1}"
            Dim entryPanel = Controls.Find(entryName, True).FirstOrDefault()

            If entryPanel IsNot Nothing AndAlso TypeOf entryPanel Is Panel Then
                Dim panel = CType(entryPanel, Panel)

                If i < departures.Count Then
                    Dim dep = departures(i)
                    Dim prefix = $"E{i + 1}_"

                    Dim prefixKey = dep.RouteId.Substring(0, 4)
                    'Dim routeName = If(RouteDictionary.ContainsKey(prefixKey), RouteDictionary(prefixKey).RouteName, dep.RouteId)

                    Dim Destination As String = "?"
                    If dep.FinalStop IsNot Nothing AndAlso StopIdToStation.ContainsKey(dep.FinalStop) Then
                        Destination = StopIdToStation(dep.FinalStop).Split("|"c).First()
                        If Destination.Contains("Airport") Then
                            Destination = "Airport"
                            SetVisible(prefix & "Airport", True)
                        ElseIf Destination.Contains("Varsity") Then
                            Destination = "Gold Coast"
                            SetVisible(prefix & "Airport", False)
                        ElseIf Destination.Contains("Kippa-Ring") Then
                            Destination = "Redcliffe"
                            SetVisible(prefix & "Airport", False)
                        ElseIf Destination.Contains("Bowen") Then
                            Destination = "City && Bowen Hills"
                            SetVisible(prefix & "Airport", False)
                        ElseIf Destination.Contains("Roma") Then
                            Destination = "City && Roma Street"
                            SetVisible(prefix & "Airport", False)
                        ElseIf Destination.Contains("Nambour") Then
                            Destination = "Caboolture / Nambour"
                            SetVisible(prefix & "Airport", False)
                        Else
                            SetVisible(prefix & "Airport", False)
                        End If
                    End If

                    SetLabelText(prefix & "Service", Destination)

                    Dim platform = If(StopIdToStation.ContainsKey(dep.StopId), StopIdToStation(dep.StopId).Split("|"c).Last(), "?")
                    SetLabelText(prefix & "Platform", platform)

                    ' this doesnt work for some reason
                    If dep.TripId.Contains("UNPLANNED") Then
                        SetLabelText(prefix & "Time", "Extra")
                    Else
                        SetLabelText(prefix & "Time", dep.DepartureTime.ToString("h:mm"))
                    End If

                    SetLabelText(prefix & "Time", dep.DepartureTime.ToString("h:mm"))
                    Dim minutesUntil = (dep.DepartureTime - DateTimeOffset.Now).TotalMinutes
                    If minutesUntil >= 61 Then
                        SetLabelText(prefix & "Countdown", dep.DepartureTime.ToString("h:mm"))
                    Else
                        SetLabelText(prefix & "Countdown", $"{minutesUntil:F0} min")
                    End If


                    SetLabelText(prefix & "Exp", RouteDictionary(prefixKey).ExpressTrain)

                    Dim isNGR = dep.CutLabel.StartsWith("D")
                    Dim is3Car = dep.CutLabel.StartsWith("J") OrElse dep.CutLabel.StartsWith("U")

                    If showNGR = True Then
                        SetVisible(prefix & "NGR_1", isNGR)
                        SetVisible(prefix & "NGR_2", isNGR)
                    Else
                        SetVisible(prefix & "NGR_1", False)
                        SetVisible(prefix & "NGR_2", False)
                    End If

                    SetVisible(prefix & "3Car", is3Car)

                    Dim colorHex = If(RouteDictionary.ContainsKey(prefixKey), RouteDictionary(prefixKey).RouteColor, "#CCCCCC")
                    Dim routeColor = ColorTranslator.FromHtml(colorHex)

                    If Destination.Contains("Bowen Hills") OrElse Destination.Contains("Fortitude Valley") OrElse Destination.Contains("Central") OrElse Destination.Contains("Roma Street") OrElse Destination.Contains("Northgate") Then
                        routeColor = ColorTranslator.FromHtml("#595959")
                    End If

                    For Each ctrl In panel.Controls
                        ctrl.BackColor = routeColor
                    Next

                    panel.Visible = True
                Else
                    panel.Visible = False
                End If
            End If
        Next

        ' new logic
        If departures IsNot Nothing AndAlso departures.Count > 0 Then
            ' Always use the top departure as the current focus
            Dim topDeparture = departures(0)
            Dim matchingTrip As TransitRealtime.TripUpdate = Nothing

            ' Find the trip data for the top departure (ServStopVar2 already holds one too)
            If ServStopVar2 IsNot Nothing AndAlso TypeOf ServStopVar2 Is TransitRealtime.TripUpdate Then
                Dim t = DirectCast(ServStopVar2, TransitRealtime.TripUpdate)
                If t.Trip.TripId = topDeparture.TripId Then
                    matchingTrip = t
                End If
            End If

            ' fallback look it up in the latest GTFS feed if needed
            If matchingTrip Is Nothing Then
                matchingTrip = Nothing
            End If

            ' If ServiceStops panel is visible, refresh its contents
            If ServiceStops.Visible Then
                ShowServiceStopsForDeparture(topDeparture, matchingTrip)
            End If

            ' Always update StopListCdn text with top departure’s countdown
            E1_Countdown.Text = If((topDeparture.DepartureTime - DateTimeOffset.Now).TotalMinutes >= 61,
        topDeparture.DepartureTime.ToString("h:mm"),
        $"{(topDeparture.DepartureTime - DateTimeOffset.Now).TotalMinutes:F0} min")

            StopListCdn.Text = E1_Countdown.Text
        End If


    End Sub

    Private Sub SetLabelText(name As String, text As String)
        Dim ctrl = Controls.Find(name, True).FirstOrDefault()
        If TypeOf ctrl Is Label Then
            CType(ctrl, Label).Text = text
        End If
    End Sub

    Private Sub SetVisible(name As String, visible As Boolean)
        Dim ctrl = Controls.Find(name, True).FirstOrDefault()
        If ctrl IsNot Nothing Then ctrl.Visible = visible
    End Sub

    Private Sub TickerPanel_Paint(sender As Object, e As PaintEventArgs) Handles TickerPanel.Paint
        Dim g = e.Graphics
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Dim s = If(_scaler Is Nothing, 1.0F, _scaler.Scale)
        g.ScaleTransform(s, s)

        Using font As New Font("Arial", 20, FontStyle.Bold), brush As New SolidBrush(Color.White)
            Dim textWidth = TextRenderer.MeasureText(TickerText, font).Width
            If ScrollOffset >= textWidth Then ScrollOffset = 0
            g.TranslateTransform(-ScrollOffset, 0)
            g.DrawString(TickerText, font, brush, 0, 0)
            g.DrawString(TickerText, font, brush, textWidth, 0)
        End Using
    End Sub

    Private Sub TickerTimer_Tick(sender As Object, e As EventArgs) Handles TickerTimer.Tick
        ScrollOffset += ScrollSpeed
        TickerPanel.Invalidate()
    End Sub

    Public Class DepartureData
        Public Property DepartureTime As DateTimeOffset
        Public Property RouteId As String
        Public Property CutLabel As String
        Public Property StopId As String
        Public Property TripId As String
        Public Property FinalStop As String
    End Class

    Public Class RouteInfo
        Public Property RouteName As String
        Public Property RouteColor As String
        Public Property ExpressTrain As String
    End Class
End Class
