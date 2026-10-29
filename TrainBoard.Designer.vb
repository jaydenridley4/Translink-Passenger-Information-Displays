<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrainBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainBoard))
        BoardClock = New Label()
        BoardTitle = New Label()
        Timer1 = New Timer(components)
        Label3 = New Label()
        E1_Countdown = New Label()
        E1_Platform = New Label()
        E1_NGR_1 = New PictureBox()
        E1_3Car = New PictureBox()
        E1_Exp = New Label()
        E1_NGR_2 = New Label()
        E1_Service = New Label()
        E1_Time = New Label()
        Entry1 = New Panel()
        E1_Airport = New Label()
        Entry2 = New Panel()
        E2_Airport = New Label()
        E2_Time = New Label()
        E2_Service = New Label()
        E2_NGR_2 = New Label()
        E2_Exp = New Label()
        E2_3Car = New PictureBox()
        E2_NGR_1 = New PictureBox()
        E2_Platform = New Label()
        E2_Countdown = New Label()
        Entry3 = New Panel()
        E3_Airport = New Label()
        E3_Time = New Label()
        E3_Service = New Label()
        E3_NGR_2 = New Label()
        E3_Exp = New Label()
        E3_3Car = New PictureBox()
        E3_NGR_1 = New PictureBox()
        E3_Platform = New Label()
        E3_Countdown = New Label()
        ServiceStops = New Panel()
        AirtrainLogo = New PictureBox()
        Panel2 = New Panel()
        StopListCdn = New Label()
        StopListLabel = New Label()
        StopList10 = New FlowLayoutPanel()
        TEMPLATEStopsAt = New Label()
        Entry4 = New Panel()
        E4_Airport = New Label()
        E4_Time = New Label()
        E4_Service = New Label()
        E4_NGR_2 = New Label()
        E4_Exp = New Label()
        E4_3Car = New PictureBox()
        E4_NGR_1 = New PictureBox()
        E4_Platform = New Label()
        E4_Countdown = New Label()
        Entry5 = New Panel()
        E5_Airport = New Label()
        E5_Time = New Label()
        E5_Service = New Label()
        E5_NGR_2 = New Label()
        E5_Exp = New Label()
        E5_3Car = New PictureBox()
        E5_NGR_1 = New PictureBox()
        E5_Platform = New Label()
        E5_Countdown = New Label()
        Entry6 = New Panel()
        E6_Airport = New Label()
        E6_Time = New Label()
        E6_Service = New Label()
        E6_NGR_2 = New Label()
        E6_Exp = New Label()
        E6_3Car = New PictureBox()
        E6_NGR_1 = New PictureBox()
        E6_Platform = New Label()
        E6_Countdown = New Label()
        RefreshTimer = New Timer(components)
        TickerTimer = New Timer(components)
        TickerPanel = New Panel()
        DisplayPanel = New Panel()
        HeaderDeparts = New Label()
        HeaderPlatform = New Label()
        NoDepMsg = New Label()
        DepartsTitle = New Label()
        CType(E1_NGR_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(E1_3Car, ComponentModel.ISupportInitialize).BeginInit()
        Entry1.SuspendLayout()
        Entry2.SuspendLayout()
        CType(E2_3Car, ComponentModel.ISupportInitialize).BeginInit()
        CType(E2_NGR_1, ComponentModel.ISupportInitialize).BeginInit()
        Entry3.SuspendLayout()
        CType(E3_3Car, ComponentModel.ISupportInitialize).BeginInit()
        CType(E3_NGR_1, ComponentModel.ISupportInitialize).BeginInit()
        ServiceStops.SuspendLayout()
        CType(AirtrainLogo, ComponentModel.ISupportInitialize).BeginInit()
        StopList10.SuspendLayout()
        Entry4.SuspendLayout()
        CType(E4_3Car, ComponentModel.ISupportInitialize).BeginInit()
        CType(E4_NGR_1, ComponentModel.ISupportInitialize).BeginInit()
        Entry5.SuspendLayout()
        CType(E5_3Car, ComponentModel.ISupportInitialize).BeginInit()
        CType(E5_NGR_1, ComponentModel.ISupportInitialize).BeginInit()
        Entry6.SuspendLayout()
        CType(E6_3Car, ComponentModel.ISupportInitialize).BeginInit()
        CType(E6_NGR_1, ComponentModel.ISupportInitialize).BeginInit()
        DisplayPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BoardClock
        ' 
        BoardClock.AutoSize = True
        BoardClock.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoardClock.ForeColor = Color.FromArgb(CByte(248), CByte(247), CByte(53))
        BoardClock.Location = New Point(-3, 0)
        BoardClock.Name = "BoardClock"
        BoardClock.Size = New Size(84, 24)
        BoardClock.TabIndex = 0
        BoardClock.Text = "9:54:52"
        ' 
        ' BoardTitle
        ' 
        BoardTitle.Anchor = AnchorStyles.Top
        BoardTitle.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoardTitle.ForeColor = Color.White
        BoardTitle.Location = New Point(138, 0)
        BoardTitle.Name = "BoardTitle"
        BoardTitle.Size = New Size(700, 25)
        BoardTitle.TabIndex = 1
        BoardTitle.Text = "Next (1-6) Trains North"
        BoardTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(600, 32)
        Label3.TabIndex = 12
        Label3.Text = "Service"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E1_Countdown
        ' 
        E1_Countdown.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_Countdown.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E1_Countdown.ForeColor = Color.White
        E1_Countdown.Location = New Point(757, 0)
        E1_Countdown.Name = "E1_Countdown"
        E1_Countdown.Size = New Size(203, 60)
        E1_Countdown.TabIndex = 7
        E1_Countdown.Text = "1 min"
        E1_Countdown.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' E1_Platform
        ' 
        E1_Platform.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_Platform.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E1_Platform.ForeColor = Color.White
        E1_Platform.Location = New Point(694, 0)
        E1_Platform.Name = "E1_Platform"
        E1_Platform.Size = New Size(69, 60)
        E1_Platform.TabIndex = 6
        E1_Platform.Text = "3"
        E1_Platform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E1_NGR_1
        ' 
        E1_NGR_1.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_NGR_1.Image = CType(resources.GetObject("E1_NGR_1.Image"), Image)
        E1_NGR_1.Location = New Point(762, 3)
        E1_NGR_1.Name = "E1_NGR_1"
        E1_NGR_1.Size = New Size(34, 40)
        E1_NGR_1.SizeMode = PictureBoxSizeMode.Zoom
        E1_NGR_1.TabIndex = 9
        E1_NGR_1.TabStop = False
        E1_NGR_1.Visible = False
        ' 
        ' E1_3Car
        ' 
        E1_3Car.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_3Car.Image = CType(resources.GetObject("E1_3Car.Image"), Image)
        E1_3Car.Location = New Point(757, 0)
        E1_3Car.Name = "E1_3Car"
        E1_3Car.Size = New Size(44, 60)
        E1_3Car.SizeMode = PictureBoxSizeMode.Zoom
        E1_3Car.TabIndex = 10
        E1_3Car.TabStop = False
        E1_3Car.Visible = False
        ' 
        ' E1_Exp
        ' 
        E1_Exp.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_Exp.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E1_Exp.ForeColor = Color.White
        E1_Exp.Location = New Point(566, 0)
        E1_Exp.Name = "E1_Exp"
        E1_Exp.Size = New Size(128, 60)
        E1_Exp.TabIndex = 8
        E1_Exp.Text = "Exp"
        E1_Exp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E1_NGR_2
        ' 
        E1_NGR_2.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_NGR_2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E1_NGR_2.ForeColor = Color.White
        E1_NGR_2.Location = New Point(762, 40)
        E1_NGR_2.Name = "E1_NGR_2"
        E1_NGR_2.Size = New Size(34, 15)
        E1_NGR_2.TabIndex = 11
        E1_NGR_2.Text = "NGR"
        E1_NGR_2.TextAlign = ContentAlignment.MiddleCenter
        E1_NGR_2.Visible = False
        ' 
        ' E1_Service
        ' 
        E1_Service.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_Service.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E1_Service.ForeColor = Color.White
        E1_Service.Location = New Point(116, 0)
        E1_Service.Name = "E1_Service"
        E1_Service.Size = New Size(450, 60)
        E1_Service.TabIndex = 5
        E1_Service.Text = "Ferny Grove"
        E1_Service.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E1_Time
        ' 
        E1_Time.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_Time.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E1_Time.ForeColor = Color.White
        E1_Time.Location = New Point(0, 0)
        E1_Time.Name = "E1_Time"
        E1_Time.Size = New Size(116, 60)
        E1_Time.TabIndex = 4
        E1_Time.Text = "9:56"
        E1_Time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Entry1
        ' 
        Entry1.Controls.Add(E1_Airport)
        Entry1.Controls.Add(E1_Time)
        Entry1.Controls.Add(E1_Service)
        Entry1.Controls.Add(E1_NGR_2)
        Entry1.Controls.Add(E1_Exp)
        Entry1.Controls.Add(E1_3Car)
        Entry1.Controls.Add(E1_NGR_1)
        Entry1.Controls.Add(E1_Platform)
        Entry1.Controls.Add(E1_Countdown)
        Entry1.Location = New Point(0, 35)
        Entry1.Name = "Entry1"
        Entry1.Size = New Size(960, 60)
        Entry1.TabIndex = 13
        Entry1.Visible = False
        ' 
        ' E1_Airport
        ' 
        E1_Airport.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E1_Airport.Font = New Font("Segoe UI Symbol", 34.75F, FontStyle.Bold)
        E1_Airport.ForeColor = Color.White
        E1_Airport.Location = New Point(250, -3)
        E1_Airport.Name = "E1_Airport"
        E1_Airport.Size = New Size(65, 60)
        E1_Airport.TabIndex = 12
        E1_Airport.Text = "✈"
        E1_Airport.TextAlign = ContentAlignment.MiddleLeft
        E1_Airport.Visible = False
        ' 
        ' Entry2
        ' 
        Entry2.Controls.Add(E2_Airport)
        Entry2.Controls.Add(E2_Time)
        Entry2.Controls.Add(E2_Service)
        Entry2.Controls.Add(E2_NGR_2)
        Entry2.Controls.Add(E2_Exp)
        Entry2.Controls.Add(E2_3Car)
        Entry2.Controls.Add(E2_NGR_1)
        Entry2.Controls.Add(E2_Platform)
        Entry2.Controls.Add(E2_Countdown)
        Entry2.Location = New Point(0, 102)
        Entry2.Name = "Entry2"
        Entry2.Size = New Size(960, 60)
        Entry2.TabIndex = 14
        Entry2.Visible = False
        ' 
        ' E2_Airport
        ' 
        E2_Airport.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_Airport.Font = New Font("Segoe UI Symbol", 34.75F, FontStyle.Bold)
        E2_Airport.ForeColor = Color.White
        E2_Airport.Location = New Point(250, -3)
        E2_Airport.Name = "E2_Airport"
        E2_Airport.Size = New Size(65, 60)
        E2_Airport.TabIndex = 13
        E2_Airport.Text = "✈"
        E2_Airport.TextAlign = ContentAlignment.MiddleLeft
        E2_Airport.Visible = False
        ' 
        ' E2_Time
        ' 
        E2_Time.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_Time.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E2_Time.ForeColor = Color.White
        E2_Time.Location = New Point(0, 0)
        E2_Time.Name = "E2_Time"
        E2_Time.Size = New Size(116, 60)
        E2_Time.TabIndex = 4
        E2_Time.Text = "9:56"
        E2_Time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E2_Service
        ' 
        E2_Service.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_Service.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E2_Service.ForeColor = Color.White
        E2_Service.Location = New Point(116, 0)
        E2_Service.Name = "E2_Service"
        E2_Service.Size = New Size(450, 60)
        E2_Service.TabIndex = 5
        E2_Service.Text = "Ferny Grove"
        E2_Service.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E2_NGR_2
        ' 
        E2_NGR_2.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_NGR_2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E2_NGR_2.ForeColor = Color.White
        E2_NGR_2.Location = New Point(762, 40)
        E2_NGR_2.Name = "E2_NGR_2"
        E2_NGR_2.Size = New Size(34, 15)
        E2_NGR_2.TabIndex = 11
        E2_NGR_2.Text = "NGR"
        E2_NGR_2.TextAlign = ContentAlignment.MiddleCenter
        E2_NGR_2.Visible = False
        ' 
        ' E2_Exp
        ' 
        E2_Exp.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_Exp.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E2_Exp.ForeColor = Color.White
        E2_Exp.Location = New Point(566, 0)
        E2_Exp.Name = "E2_Exp"
        E2_Exp.Size = New Size(128, 60)
        E2_Exp.TabIndex = 8
        E2_Exp.Text = "Exp"
        E2_Exp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E2_3Car
        ' 
        E2_3Car.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_3Car.Image = CType(resources.GetObject("E2_3Car.Image"), Image)
        E2_3Car.Location = New Point(757, 0)
        E2_3Car.Name = "E2_3Car"
        E2_3Car.Size = New Size(44, 60)
        E2_3Car.SizeMode = PictureBoxSizeMode.Zoom
        E2_3Car.TabIndex = 10
        E2_3Car.TabStop = False
        E2_3Car.Visible = False
        ' 
        ' E2_NGR_1
        ' 
        E2_NGR_1.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_NGR_1.Image = CType(resources.GetObject("E2_NGR_1.Image"), Image)
        E2_NGR_1.Location = New Point(762, 3)
        E2_NGR_1.Name = "E2_NGR_1"
        E2_NGR_1.Size = New Size(34, 40)
        E2_NGR_1.SizeMode = PictureBoxSizeMode.Zoom
        E2_NGR_1.TabIndex = 9
        E2_NGR_1.TabStop = False
        E2_NGR_1.Visible = False
        ' 
        ' E2_Platform
        ' 
        E2_Platform.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_Platform.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E2_Platform.ForeColor = Color.White
        E2_Platform.Location = New Point(694, 0)
        E2_Platform.Name = "E2_Platform"
        E2_Platform.Size = New Size(69, 60)
        E2_Platform.TabIndex = 6
        E2_Platform.Text = "3"
        E2_Platform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E2_Countdown
        ' 
        E2_Countdown.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E2_Countdown.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E2_Countdown.ForeColor = Color.White
        E2_Countdown.Location = New Point(757, 0)
        E2_Countdown.Name = "E2_Countdown"
        E2_Countdown.Size = New Size(203, 60)
        E2_Countdown.TabIndex = 7
        E2_Countdown.Text = "1 min"
        E2_Countdown.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Entry3
        ' 
        Entry3.Controls.Add(E3_Airport)
        Entry3.Controls.Add(E3_Time)
        Entry3.Controls.Add(E3_Service)
        Entry3.Controls.Add(E3_NGR_2)
        Entry3.Controls.Add(E3_Exp)
        Entry3.Controls.Add(E3_3Car)
        Entry3.Controls.Add(E3_NGR_1)
        Entry3.Controls.Add(E3_Platform)
        Entry3.Controls.Add(E3_Countdown)
        Entry3.Location = New Point(0, 169)
        Entry3.Name = "Entry3"
        Entry3.Size = New Size(960, 60)
        Entry3.TabIndex = 15
        Entry3.Visible = False
        ' 
        ' E3_Airport
        ' 
        E3_Airport.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_Airport.Font = New Font("Segoe UI Symbol", 34.75F, FontStyle.Bold)
        E3_Airport.ForeColor = Color.White
        E3_Airport.Location = New Point(250, -3)
        E3_Airport.Name = "E3_Airport"
        E3_Airport.Size = New Size(65, 60)
        E3_Airport.TabIndex = 14
        E3_Airport.Text = "✈"
        E3_Airport.TextAlign = ContentAlignment.MiddleLeft
        E3_Airport.Visible = False
        ' 
        ' E3_Time
        ' 
        E3_Time.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_Time.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E3_Time.ForeColor = Color.White
        E3_Time.Location = New Point(0, 0)
        E3_Time.Name = "E3_Time"
        E3_Time.Size = New Size(116, 60)
        E3_Time.TabIndex = 4
        E3_Time.Text = "9:56"
        E3_Time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E3_Service
        ' 
        E3_Service.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_Service.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E3_Service.ForeColor = Color.White
        E3_Service.Location = New Point(116, 0)
        E3_Service.Name = "E3_Service"
        E3_Service.Size = New Size(450, 60)
        E3_Service.TabIndex = 5
        E3_Service.Text = "Ferny Grove"
        E3_Service.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E3_NGR_2
        ' 
        E3_NGR_2.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_NGR_2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E3_NGR_2.ForeColor = Color.White
        E3_NGR_2.Location = New Point(762, 41)
        E3_NGR_2.Name = "E3_NGR_2"
        E3_NGR_2.Size = New Size(34, 15)
        E3_NGR_2.TabIndex = 11
        E3_NGR_2.Text = "NGR"
        E3_NGR_2.TextAlign = ContentAlignment.MiddleCenter
        E3_NGR_2.Visible = False
        ' 
        ' E3_Exp
        ' 
        E3_Exp.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_Exp.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E3_Exp.ForeColor = Color.White
        E3_Exp.Location = New Point(566, 0)
        E3_Exp.Name = "E3_Exp"
        E3_Exp.Size = New Size(128, 60)
        E3_Exp.TabIndex = 8
        E3_Exp.Text = "Exp"
        E3_Exp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E3_3Car
        ' 
        E3_3Car.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_3Car.Image = CType(resources.GetObject("E3_3Car.Image"), Image)
        E3_3Car.Location = New Point(757, 0)
        E3_3Car.Name = "E3_3Car"
        E3_3Car.Size = New Size(44, 60)
        E3_3Car.SizeMode = PictureBoxSizeMode.Zoom
        E3_3Car.TabIndex = 10
        E3_3Car.TabStop = False
        E3_3Car.Visible = False
        ' 
        ' E3_NGR_1
        ' 
        E3_NGR_1.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_NGR_1.Image = CType(resources.GetObject("E3_NGR_1.Image"), Image)
        E3_NGR_1.Location = New Point(762, 4)
        E3_NGR_1.Name = "E3_NGR_1"
        E3_NGR_1.Size = New Size(34, 40)
        E3_NGR_1.SizeMode = PictureBoxSizeMode.Zoom
        E3_NGR_1.TabIndex = 9
        E3_NGR_1.TabStop = False
        E3_NGR_1.Visible = False
        ' 
        ' E3_Platform
        ' 
        E3_Platform.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_Platform.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E3_Platform.ForeColor = Color.White
        E3_Platform.Location = New Point(694, 0)
        E3_Platform.Name = "E3_Platform"
        E3_Platform.Size = New Size(69, 60)
        E3_Platform.TabIndex = 6
        E3_Platform.Text = "3"
        E3_Platform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E3_Countdown
        ' 
        E3_Countdown.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E3_Countdown.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E3_Countdown.ForeColor = Color.White
        E3_Countdown.Location = New Point(757, 0)
        E3_Countdown.Name = "E3_Countdown"
        E3_Countdown.Size = New Size(203, 60)
        E3_Countdown.TabIndex = 7
        E3_Countdown.Text = "1 min"
        E3_Countdown.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ServiceStops
        ' 
        ServiceStops.BackColor = Color.FromArgb(CByte(98), CByte(83), CByte(24))
        ServiceStops.Controls.Add(AirtrainLogo)
        ServiceStops.Controls.Add(Panel2)
        ServiceStops.Controls.Add(StopListCdn)
        ServiceStops.Controls.Add(StopListLabel)
        ServiceStops.Controls.Add(StopList10)
        ServiceStops.Location = New Point(0, 23)
        ServiceStops.Name = "ServiceStops"
        ServiceStops.Size = New Size(960, 517)
        ServiceStops.TabIndex = 22
        ServiceStops.Visible = False
        ' 
        ' AirtrainLogo
        ' 
        AirtrainLogo.BackColor = Color.FromArgb(CByte(98), CByte(83), CByte(24))
        AirtrainLogo.Image = My.Resources.Resources.AirtrainLogo
        AirtrainLogo.Location = New Point(330, 400)
        AirtrainLogo.Name = "AirtrainLogo"
        AirtrainLogo.Size = New Size(300, 100)
        AirtrainLogo.SizeMode = PictureBoxSizeMode.Zoom
        AirtrainLogo.TabIndex = 94
        AirtrainLogo.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(0, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(960, 2)
        Panel2.TabIndex = 26
        ' 
        ' StopListCdn
        ' 
        StopListCdn.Anchor = AnchorStyles.Top
        StopListCdn.Font = New Font("Arial", 20.75F, FontStyle.Bold)
        StopListCdn.ForeColor = Color.White
        StopListCdn.Location = New Point(480, 0)
        StopListCdn.Name = "StopListCdn"
        StopListCdn.Size = New Size(480, 34)
        StopListCdn.TabIndex = 25
        StopListCdn.Text = "2 min"
        StopListCdn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' StopListLabel
        ' 
        StopListLabel.Anchor = AnchorStyles.Top
        StopListLabel.Font = New Font("Arial", 20.75F, FontStyle.Bold)
        StopListLabel.ForeColor = Color.White
        StopListLabel.Location = New Point(0, 0)
        StopListLabel.Name = "StopListLabel"
        StopListLabel.Size = New Size(480, 34)
        StopListLabel.TabIndex = 24
        StopListLabel.Text = "10:38 to City && Airport"
        StopListLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' StopList10
        ' 
        StopList10.Controls.Add(TEMPLATEStopsAt)
        StopList10.FlowDirection = FlowDirection.TopDown
        StopList10.Location = New Point(30, 51)
        StopList10.Name = "StopList10"
        StopList10.Size = New Size(920, 345)
        StopList10.TabIndex = 27
        ' 
        ' TEMPLATEStopsAt
        ' 
        TEMPLATEStopsAt.Anchor = AnchorStyles.Top
        TEMPLATEStopsAt.Font = New Font("Arial", 36.75F, FontStyle.Bold)
        TEMPLATEStopsAt.ForeColor = Color.White
        TEMPLATEStopsAt.Location = New Point(3, 0)
        TEMPLATEStopsAt.Name = "TEMPLATEStopsAt"
        TEMPLATEStopsAt.Size = New Size(600, 64)
        TEMPLATEStopsAt.TabIndex = 93
        TEMPLATEStopsAt.Text = "Eagle Farm"
        TEMPLATEStopsAt.TextAlign = ContentAlignment.MiddleLeft
        TEMPLATEStopsAt.Visible = False
        ' 
        ' Entry4
        ' 
        Entry4.Controls.Add(E4_Airport)
        Entry4.Controls.Add(E4_Time)
        Entry4.Controls.Add(E4_Service)
        Entry4.Controls.Add(E4_NGR_2)
        Entry4.Controls.Add(E4_Exp)
        Entry4.Controls.Add(E4_3Car)
        Entry4.Controls.Add(E4_NGR_1)
        Entry4.Controls.Add(E4_Platform)
        Entry4.Controls.Add(E4_Countdown)
        Entry4.Location = New Point(0, 236)
        Entry4.Name = "Entry4"
        Entry4.Size = New Size(960, 60)
        Entry4.TabIndex = 16
        Entry4.Visible = False
        ' 
        ' E4_Airport
        ' 
        E4_Airport.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_Airport.Font = New Font("Segoe UI Symbol", 34.75F, FontStyle.Bold)
        E4_Airport.ForeColor = Color.White
        E4_Airport.Location = New Point(250, -3)
        E4_Airport.Name = "E4_Airport"
        E4_Airport.Size = New Size(65, 60)
        E4_Airport.TabIndex = 15
        E4_Airport.Text = "✈"
        E4_Airport.TextAlign = ContentAlignment.MiddleLeft
        E4_Airport.Visible = False
        ' 
        ' E4_Time
        ' 
        E4_Time.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_Time.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E4_Time.ForeColor = Color.White
        E4_Time.Location = New Point(0, 0)
        E4_Time.Name = "E4_Time"
        E4_Time.Size = New Size(116, 60)
        E4_Time.TabIndex = 4
        E4_Time.Text = "9:56"
        E4_Time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E4_Service
        ' 
        E4_Service.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_Service.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E4_Service.ForeColor = Color.White
        E4_Service.Location = New Point(116, 0)
        E4_Service.Name = "E4_Service"
        E4_Service.Size = New Size(450, 60)
        E4_Service.TabIndex = 5
        E4_Service.Text = "Ferny Grove"
        E4_Service.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E4_NGR_2
        ' 
        E4_NGR_2.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_NGR_2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E4_NGR_2.ForeColor = Color.White
        E4_NGR_2.Location = New Point(762, 40)
        E4_NGR_2.Name = "E4_NGR_2"
        E4_NGR_2.Size = New Size(34, 15)
        E4_NGR_2.TabIndex = 11
        E4_NGR_2.Text = "NGR"
        E4_NGR_2.TextAlign = ContentAlignment.MiddleCenter
        E4_NGR_2.Visible = False
        ' 
        ' E4_Exp
        ' 
        E4_Exp.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_Exp.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E4_Exp.ForeColor = Color.White
        E4_Exp.Location = New Point(566, 0)
        E4_Exp.Name = "E4_Exp"
        E4_Exp.Size = New Size(128, 60)
        E4_Exp.TabIndex = 8
        E4_Exp.Text = "Exp"
        E4_Exp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E4_3Car
        ' 
        E4_3Car.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_3Car.Image = CType(resources.GetObject("E4_3Car.Image"), Image)
        E4_3Car.Location = New Point(757, 0)
        E4_3Car.Name = "E4_3Car"
        E4_3Car.Size = New Size(44, 60)
        E4_3Car.SizeMode = PictureBoxSizeMode.Zoom
        E4_3Car.TabIndex = 10
        E4_3Car.TabStop = False
        E4_3Car.Visible = False
        ' 
        ' E4_NGR_1
        ' 
        E4_NGR_1.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_NGR_1.Image = CType(resources.GetObject("E4_NGR_1.Image"), Image)
        E4_NGR_1.Location = New Point(762, 3)
        E4_NGR_1.Name = "E4_NGR_1"
        E4_NGR_1.Size = New Size(34, 40)
        E4_NGR_1.SizeMode = PictureBoxSizeMode.Zoom
        E4_NGR_1.TabIndex = 9
        E4_NGR_1.TabStop = False
        E4_NGR_1.Visible = False
        ' 
        ' E4_Platform
        ' 
        E4_Platform.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_Platform.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E4_Platform.ForeColor = Color.White
        E4_Platform.Location = New Point(694, 0)
        E4_Platform.Name = "E4_Platform"
        E4_Platform.Size = New Size(69, 60)
        E4_Platform.TabIndex = 6
        E4_Platform.Text = "3"
        E4_Platform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E4_Countdown
        ' 
        E4_Countdown.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E4_Countdown.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E4_Countdown.ForeColor = Color.White
        E4_Countdown.Location = New Point(757, 0)
        E4_Countdown.Name = "E4_Countdown"
        E4_Countdown.Size = New Size(203, 60)
        E4_Countdown.TabIndex = 7
        E4_Countdown.Text = "1 min"
        E4_Countdown.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Entry5
        ' 
        Entry5.Controls.Add(E5_Airport)
        Entry5.Controls.Add(E5_Time)
        Entry5.Controls.Add(E5_Service)
        Entry5.Controls.Add(E5_NGR_2)
        Entry5.Controls.Add(E5_Exp)
        Entry5.Controls.Add(E5_3Car)
        Entry5.Controls.Add(E5_NGR_1)
        Entry5.Controls.Add(E5_Platform)
        Entry5.Controls.Add(E5_Countdown)
        Entry5.Location = New Point(0, 303)
        Entry5.Name = "Entry5"
        Entry5.Size = New Size(960, 60)
        Entry5.TabIndex = 17
        Entry5.Visible = False
        ' 
        ' E5_Airport
        ' 
        E5_Airport.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_Airport.Font = New Font("Segoe UI Symbol", 34.75F, FontStyle.Bold)
        E5_Airport.ForeColor = Color.White
        E5_Airport.Location = New Point(250, -3)
        E5_Airport.Name = "E5_Airport"
        E5_Airport.Size = New Size(65, 60)
        E5_Airport.TabIndex = 16
        E5_Airport.Text = "✈"
        E5_Airport.TextAlign = ContentAlignment.MiddleLeft
        E5_Airport.Visible = False
        ' 
        ' E5_Time
        ' 
        E5_Time.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_Time.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E5_Time.ForeColor = Color.White
        E5_Time.Location = New Point(0, 0)
        E5_Time.Name = "E5_Time"
        E5_Time.Size = New Size(116, 60)
        E5_Time.TabIndex = 4
        E5_Time.Text = "9:56"
        E5_Time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E5_Service
        ' 
        E5_Service.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_Service.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E5_Service.ForeColor = Color.White
        E5_Service.Location = New Point(116, 0)
        E5_Service.Name = "E5_Service"
        E5_Service.Size = New Size(450, 60)
        E5_Service.TabIndex = 5
        E5_Service.Text = "Ferny Grove"
        E5_Service.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E5_NGR_2
        ' 
        E5_NGR_2.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_NGR_2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E5_NGR_2.ForeColor = Color.White
        E5_NGR_2.Location = New Point(762, 40)
        E5_NGR_2.Name = "E5_NGR_2"
        E5_NGR_2.Size = New Size(34, 15)
        E5_NGR_2.TabIndex = 11
        E5_NGR_2.Text = "NGR"
        E5_NGR_2.TextAlign = ContentAlignment.MiddleCenter
        E5_NGR_2.Visible = False
        ' 
        ' E5_Exp
        ' 
        E5_Exp.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_Exp.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E5_Exp.ForeColor = Color.White
        E5_Exp.Location = New Point(566, 0)
        E5_Exp.Name = "E5_Exp"
        E5_Exp.Size = New Size(128, 60)
        E5_Exp.TabIndex = 8
        E5_Exp.Text = "Exp"
        E5_Exp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E5_3Car
        ' 
        E5_3Car.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_3Car.Image = CType(resources.GetObject("E5_3Car.Image"), Image)
        E5_3Car.Location = New Point(757, 0)
        E5_3Car.Name = "E5_3Car"
        E5_3Car.Size = New Size(44, 60)
        E5_3Car.SizeMode = PictureBoxSizeMode.Zoom
        E5_3Car.TabIndex = 10
        E5_3Car.TabStop = False
        E5_3Car.Visible = False
        ' 
        ' E5_NGR_1
        ' 
        E5_NGR_1.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_NGR_1.Image = CType(resources.GetObject("E5_NGR_1.Image"), Image)
        E5_NGR_1.Location = New Point(762, 3)
        E5_NGR_1.Name = "E5_NGR_1"
        E5_NGR_1.Size = New Size(34, 40)
        E5_NGR_1.SizeMode = PictureBoxSizeMode.Zoom
        E5_NGR_1.TabIndex = 9
        E5_NGR_1.TabStop = False
        E5_NGR_1.Visible = False
        ' 
        ' E5_Platform
        ' 
        E5_Platform.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_Platform.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E5_Platform.ForeColor = Color.White
        E5_Platform.Location = New Point(694, 0)
        E5_Platform.Name = "E5_Platform"
        E5_Platform.Size = New Size(69, 60)
        E5_Platform.TabIndex = 6
        E5_Platform.Text = "3"
        E5_Platform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E5_Countdown
        ' 
        E5_Countdown.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E5_Countdown.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E5_Countdown.ForeColor = Color.White
        E5_Countdown.Location = New Point(757, 0)
        E5_Countdown.Name = "E5_Countdown"
        E5_Countdown.Size = New Size(203, 60)
        E5_Countdown.TabIndex = 7
        E5_Countdown.Text = "1 min"
        E5_Countdown.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Entry6
        ' 
        Entry6.Controls.Add(E6_Airport)
        Entry6.Controls.Add(E6_Time)
        Entry6.Controls.Add(E6_Service)
        Entry6.Controls.Add(E6_NGR_2)
        Entry6.Controls.Add(E6_Exp)
        Entry6.Controls.Add(E6_3Car)
        Entry6.Controls.Add(E6_NGR_1)
        Entry6.Controls.Add(E6_Platform)
        Entry6.Controls.Add(E6_Countdown)
        Entry6.Location = New Point(0, 370)
        Entry6.Name = "Entry6"
        Entry6.Size = New Size(960, 60)
        Entry6.TabIndex = 18
        Entry6.Visible = False
        ' 
        ' E6_Airport
        ' 
        E6_Airport.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_Airport.Font = New Font("Segoe UI Symbol", 34.75F, FontStyle.Bold)
        E6_Airport.ForeColor = Color.White
        E6_Airport.Location = New Point(250, -3)
        E6_Airport.Name = "E6_Airport"
        E6_Airport.Size = New Size(65, 60)
        E6_Airport.TabIndex = 17
        E6_Airport.Text = "✈"
        E6_Airport.TextAlign = ContentAlignment.MiddleLeft
        E6_Airport.Visible = False
        ' 
        ' E6_Time
        ' 
        E6_Time.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_Time.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E6_Time.ForeColor = Color.White
        E6_Time.Location = New Point(0, 0)
        E6_Time.Name = "E6_Time"
        E6_Time.Size = New Size(116, 60)
        E6_Time.TabIndex = 4
        E6_Time.Text = "9:56"
        E6_Time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E6_Service
        ' 
        E6_Service.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_Service.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E6_Service.ForeColor = Color.White
        E6_Service.Location = New Point(116, 0)
        E6_Service.Name = "E6_Service"
        E6_Service.Size = New Size(450, 60)
        E6_Service.TabIndex = 5
        E6_Service.Text = "Ferny Grove"
        E6_Service.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' E6_NGR_2
        ' 
        E6_NGR_2.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_NGR_2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E6_NGR_2.ForeColor = Color.White
        E6_NGR_2.Location = New Point(762, 40)
        E6_NGR_2.Name = "E6_NGR_2"
        E6_NGR_2.Size = New Size(34, 15)
        E6_NGR_2.TabIndex = 11
        E6_NGR_2.Text = "NGR"
        E6_NGR_2.TextAlign = ContentAlignment.MiddleCenter
        E6_NGR_2.Visible = False
        ' 
        ' E6_Exp
        ' 
        E6_Exp.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_Exp.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E6_Exp.ForeColor = Color.White
        E6_Exp.Location = New Point(566, 0)
        E6_Exp.Name = "E6_Exp"
        E6_Exp.Size = New Size(128, 60)
        E6_Exp.TabIndex = 8
        E6_Exp.Text = "Exp"
        E6_Exp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E6_3Car
        ' 
        E6_3Car.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_3Car.Image = CType(resources.GetObject("E6_3Car.Image"), Image)
        E6_3Car.Location = New Point(757, 0)
        E6_3Car.Name = "E6_3Car"
        E6_3Car.Size = New Size(44, 60)
        E6_3Car.SizeMode = PictureBoxSizeMode.Zoom
        E6_3Car.TabIndex = 10
        E6_3Car.TabStop = False
        E6_3Car.Visible = False
        ' 
        ' E6_NGR_1
        ' 
        E6_NGR_1.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_NGR_1.Image = CType(resources.GetObject("E6_NGR_1.Image"), Image)
        E6_NGR_1.Location = New Point(762, 3)
        E6_NGR_1.Name = "E6_NGR_1"
        E6_NGR_1.Size = New Size(34, 40)
        E6_NGR_1.SizeMode = PictureBoxSizeMode.Zoom
        E6_NGR_1.TabIndex = 9
        E6_NGR_1.TabStop = False
        E6_NGR_1.Visible = False
        ' 
        ' E6_Platform
        ' 
        E6_Platform.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_Platform.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E6_Platform.ForeColor = Color.White
        E6_Platform.Location = New Point(694, 0)
        E6_Platform.Name = "E6_Platform"
        E6_Platform.Size = New Size(69, 60)
        E6_Platform.TabIndex = 6
        E6_Platform.Text = "3"
        E6_Platform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' E6_Countdown
        ' 
        E6_Countdown.BackColor = Color.FromArgb(CByte(138), CByte(0), CByte(0))
        E6_Countdown.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        E6_Countdown.ForeColor = Color.White
        E6_Countdown.Location = New Point(757, 0)
        E6_Countdown.Name = "E6_Countdown"
        E6_Countdown.Size = New Size(203, 60)
        E6_Countdown.TabIndex = 7
        E6_Countdown.Text = "1 min"
        E6_Countdown.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' RefreshTimer
        ' 
        RefreshTimer.Interval = 5000
        ' 
        ' TickerTimer
        ' 
        TickerTimer.Enabled = True
        TickerTimer.Interval = 33
        ' 
        ' TickerPanel
        ' 
        TickerPanel.Location = New Point(0, 444)
        TickerPanel.Name = "TickerPanel"
        TickerPanel.Size = New Size(960, 31)
        TickerPanel.TabIndex = 19
        ' 
        ' DisplayPanel
        ' 
        DisplayPanel.Controls.Add(HeaderDeparts)
        DisplayPanel.Controls.Add(HeaderPlatform)
        DisplayPanel.Controls.Add(Label3)
        DisplayPanel.Controls.Add(TickerPanel)
        DisplayPanel.Controls.Add(Entry1)
        DisplayPanel.Controls.Add(Entry6)
        DisplayPanel.Controls.Add(Entry2)
        DisplayPanel.Controls.Add(Entry5)
        DisplayPanel.Controls.Add(Entry3)
        DisplayPanel.Controls.Add(Entry4)
        DisplayPanel.Location = New Point(0, 65)
        DisplayPanel.Name = "DisplayPanel"
        DisplayPanel.Size = New Size(960, 475)
        DisplayPanel.TabIndex = 20
        ' 
        ' HeaderDeparts
        ' 
        HeaderDeparts.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeaderDeparts.ForeColor = Color.White
        HeaderDeparts.Location = New Point(800, 0)
        HeaderDeparts.Name = "HeaderDeparts"
        HeaderDeparts.Size = New Size(160, 32)
        HeaderDeparts.TabIndex = 21
        HeaderDeparts.Text = "Departs"
        HeaderDeparts.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' HeaderPlatform
        ' 
        HeaderPlatform.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeaderPlatform.ForeColor = Color.White
        HeaderPlatform.Location = New Point(664, 0)
        HeaderPlatform.Name = "HeaderPlatform"
        HeaderPlatform.Size = New Size(129, 32)
        HeaderPlatform.TabIndex = 20
        HeaderPlatform.Text = "Platform"
        HeaderPlatform.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NoDepMsg
        ' 
        NoDepMsg.Anchor = AnchorStyles.Top
        NoDepMsg.Font = New Font("Arial", 52.25F, FontStyle.Bold)
        NoDepMsg.ForeColor = Color.White
        NoDepMsg.Location = New Point(0, 30)
        NoDepMsg.Name = "NoDepMsg"
        NoDepMsg.Size = New Size(960, 480)
        NoDepMsg.TabIndex = 21
        NoDepMsg.Text = "There are no trains departing from platform 2 within the next 4 hours"
        NoDepMsg.TextAlign = ContentAlignment.MiddleCenter
        NoDepMsg.Visible = False
        ' 
        ' DepartsTitle
        ' 
        DepartsTitle.Anchor = AnchorStyles.Top
        DepartsTitle.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DepartsTitle.ForeColor = Color.White
        DepartsTitle.Location = New Point(844, 0)
        DepartsTitle.Name = "DepartsTitle"
        DepartsTitle.Size = New Size(116, 25)
        DepartsTitle.TabIndex = 23
        DepartsTitle.Text = "Departs"
        DepartsTitle.TextAlign = ContentAlignment.MiddleRight
        DepartsTitle.Visible = False
        ' 
        ' TrainBoard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(960, 540)
        Controls.Add(DepartsTitle)
        Controls.Add(ServiceStops)
        Controls.Add(NoDepMsg)
        Controls.Add(DisplayPanel)
        Controls.Add(BoardTitle)
        Controls.Add(BoardClock)
        Name = "TrainBoard"
        Text = "Queensland Rail Departure Board - Next (1-6) Trains North"
        CType(E1_NGR_1, ComponentModel.ISupportInitialize).EndInit()
        CType(E1_3Car, ComponentModel.ISupportInitialize).EndInit()
        Entry1.ResumeLayout(False)
        Entry2.ResumeLayout(False)
        CType(E2_3Car, ComponentModel.ISupportInitialize).EndInit()
        CType(E2_NGR_1, ComponentModel.ISupportInitialize).EndInit()
        Entry3.ResumeLayout(False)
        CType(E3_3Car, ComponentModel.ISupportInitialize).EndInit()
        CType(E3_NGR_1, ComponentModel.ISupportInitialize).EndInit()
        ServiceStops.ResumeLayout(False)
        CType(AirtrainLogo, ComponentModel.ISupportInitialize).EndInit()
        StopList10.ResumeLayout(False)
        Entry4.ResumeLayout(False)
        CType(E4_3Car, ComponentModel.ISupportInitialize).EndInit()
        CType(E4_NGR_1, ComponentModel.ISupportInitialize).EndInit()
        Entry5.ResumeLayout(False)
        CType(E5_3Car, ComponentModel.ISupportInitialize).EndInit()
        CType(E5_NGR_1, ComponentModel.ISupportInitialize).EndInit()
        Entry6.ResumeLayout(False)
        CType(E6_3Car, ComponentModel.ISupportInitialize).EndInit()
        CType(E6_NGR_1, ComponentModel.ISupportInitialize).EndInit()
        DisplayPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BoardClock As Label
    Friend WithEvents BoardTitle As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StopListLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents E1_Countdown As Label
    Friend WithEvents E1_Platform As Label
    Friend WithEvents E1_NGR_1 As PictureBox
    Friend WithEvents E1_3Car As PictureBox
    Friend WithEvents E1_Exp As Label
    Friend WithEvents E1_NGR_2 As Label
    Friend WithEvents E1_Service As Label
    Friend WithEvents E1_Time As Label
    Friend WithEvents Entry1 As Panel
    Friend WithEvents Entry2 As Panel
    Friend WithEvents E2_Time As Label
    Friend WithEvents E2_Service As Label
    Friend WithEvents E2_NGR_2 As Label
    Friend WithEvents E2_Exp As Label
    Friend WithEvents E2_3Car As PictureBox
    Friend WithEvents E2_NGR_1 As PictureBox
    Friend WithEvents E2_Platform As Label
    Friend WithEvents E2_Countdown As Label
    Friend WithEvents Entry3 As Panel
    Friend WithEvents E3_Time As Label
    Friend WithEvents E3_Service As Label
    Friend WithEvents E3_NGR_2 As Label
    Friend WithEvents E3_Exp As Label
    Friend WithEvents E3_3Car As PictureBox
    Friend WithEvents E3_NGR_1 As PictureBox
    Friend WithEvents E3_Platform As Label
    Friend WithEvents E3_Countdown As Label
    Friend WithEvents Entry4 As Panel
    Friend WithEvents E4_Time As Label
    Friend WithEvents E4_Service As Label
    Friend WithEvents E4_NGR_2 As Label
    Friend WithEvents E4_Exp As Label
    Friend WithEvents E4_3Car As PictureBox
    Friend WithEvents E4_NGR_1 As PictureBox
    Friend WithEvents E4_Platform As Label
    Friend WithEvents E4_Countdown As Label
    Friend WithEvents Entry5 As Panel
    Friend WithEvents E5_Time As Label
    Friend WithEvents E5_Service As Label
    Friend WithEvents E5_NGR_2 As Label
    Friend WithEvents E5_Exp As Label
    Friend WithEvents E5_3Car As PictureBox
    Friend WithEvents E5_NGR_1 As PictureBox
    Friend WithEvents E5_Platform As Label
    Friend WithEvents E5_Countdown As Label
    Friend WithEvents Entry6 As Panel
    Friend WithEvents E6_Time As Label
    Friend WithEvents E6_Service As Label
    Friend WithEvents E6_NGR_2 As Label
    Friend WithEvents E6_Exp As Label
    Friend WithEvents E6_3Car As PictureBox
    Friend WithEvents E6_NGR_1 As PictureBox
    Friend WithEvents E6_Platform As Label
    Friend WithEvents E6_Countdown As Label
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents TickerTimer As Timer
    Friend WithEvents TickerPanel As Panel
    Friend WithEvents DisplayPanel As Panel
    Friend WithEvents NoDepMsg As Label
    Friend WithEvents ServiceStops As Panel
    Friend WithEvents DepartsTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StopListCdn As Label
    Friend WithEvents StopList10 As FlowLayoutPanel
    Friend WithEvents E1_Airport As Label
    Friend WithEvents E2_Airport As Label
    Friend WithEvents E3_Airport As Label
    Friend WithEvents E4_Airport As Label
    Friend WithEvents E5_Airport As Label
    Friend WithEvents E6_Airport As Label
    Friend WithEvents TEMPLATEStopsAt As Label
    Friend WithEvents AirtrainLogo As PictureBox
    Friend WithEvents HeaderPlatform As Label
    Friend WithEvents HeaderDeparts As Label

End Class
