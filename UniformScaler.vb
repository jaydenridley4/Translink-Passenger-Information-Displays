Public Class UniformScaler
    Private ReadOnly _form As Form
    Private ReadOnly _items As New List(Of Item)
    Private _ownedFonts As New List(Of Font)

    Public ReadOnly Property BaseClientSize As Size
    Public Property Scale As Single = 1.0F
    Public Event ScaleChanged()

    Private Class Item
        Public Ctl As Control
        Public Bounds As Rectangle
        Public IsLabel As Boolean
        Public FontName As String
        Public FontPt As Single
        Public Style As FontStyle
        Public CharSet As Byte
    End Class

    Public Sub New(form As Form)
        _form = form
        BaseClientSize = form.ClientSize
        Capture(form)
        AddHandler form.Resize, AddressOf OnResize
    End Sub

    Private Sub Capture(parent As Control)
        For Each c As Control In parent.Controls
            c.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            Dim it As New Item With {.Ctl = c, .Bounds = c.Bounds, .IsLabel = TypeOf c Is Label}
            If it.IsLabel Then
                it.FontName = c.Font.Name
                it.FontPt = c.Font.SizeInPoints
                it.Style = c.Font.Style
                it.CharSet = c.Font.GdiCharSet
            End If
            _items.Add(it)
            If Not TypeOf c Is FlowLayoutPanel Then Capture(c)
        Next
    End Sub

    Private Shared Function R(v As Double) As Integer
        Return CInt(Math.Round(v, MidpointRounding.AwayFromZero))
    End Function

    Public Function Px(designPx As Integer) As Integer
        Return R(designPx * Scale)
    End Function

    Private Sub OnResize(sender As Object, e As EventArgs)
        If _form.WindowState = FormWindowState.Minimized Then Return
        Dim cw = _form.ClientSize.Width, ch = _form.ClientSize.Height
        If cw <= 0 OrElse ch <= 0 Then Return

        Scale = Math.Min(cw / CSng(BaseClientSize.Width), ch / CSng(BaseClientSize.Height))
        Dim offX = R((cw - BaseClientSize.Width * Scale) / 2)
        Dim offY = R((ch - BaseClientSize.Height * Scale) / 2)

        Dim newFonts As New Dictionary(Of String, Font)
        _form.SuspendLayout()
        For Each it In _items
            Dim top = it.Ctl.Parent Is _form
            Dim ox = If(top, offX, 0), oy = If(top, offY, 0)

            Dim l = R(it.Bounds.Left * Scale) + ox
            Dim t = R(it.Bounds.Top * Scale) + oy
            Dim rt = R(it.Bounds.Right * Scale) + ox
            Dim b = R(it.Bounds.Bottom * Scale) + oy
            If it.Bounds.Width > 0 AndAlso rt <= l Then rt = l + 1
            If it.Bounds.Height > 0 AndAlso b <= t Then b = t + 1
            it.Ctl.Bounds = Rectangle.FromLTRB(l, t, rt, b)

            If it.IsLabel Then
                Dim key = it.FontName & "|" & it.FontPt & "|" & CInt(it.Style)
                Dim f As Font = Nothing
                If Not newFonts.TryGetValue(key, f) Then
                    f = New Font(it.FontName, it.FontPt * Scale, it.Style, GraphicsUnit.Point, it.CharSet)
                    newFonts(key) = f
                End If
                it.Ctl.Font = f
            End If
        Next
        _form.ResumeLayout(True)

        For Each old In _ownedFonts : old.Dispose() : Next
        _ownedFonts = newFonts.Values.ToList()

        RaiseEvent ScaleChanged()
    End Sub
End Class