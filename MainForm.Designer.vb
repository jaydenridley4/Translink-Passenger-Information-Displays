<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Btn_Train_Plat = New Button()
        Label3 = New Label()
        Btn_Tram_Plat = New Button()
        Btn_Tram_Onboard = New Button()
        Label4 = New Label()
        Btn_Bus_LED = New Button()
        Btn_Bus_LCD = New Button()
        Btn_Bus_Eink = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 34)
        Label1.TabIndex = 0
        Label1.Text = "Select a board"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(12, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(372, 25)
        Label2.TabIndex = 1
        Label2.Text = "Train"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Btn_Train_Plat
        ' 
        Btn_Train_Plat.Location = New Point(12, 63)
        Btn_Train_Plat.Name = "Btn_Train_Plat"
        Btn_Train_Plat.Size = New Size(75, 23)
        Btn_Train_Plat.TabIndex = 2
        Btn_Train_Plat.Text = "Platform/s"
        Btn_Train_Plat.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 13F)
        Label3.Location = New Point(12, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(372, 25)
        Label3.TabIndex = 3
        Label3.Text = "Tram"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Btn_Tram_Plat
        ' 
        Btn_Tram_Plat.Location = New Point(12, 117)
        Btn_Tram_Plat.Name = "Btn_Tram_Plat"
        Btn_Tram_Plat.Size = New Size(75, 23)
        Btn_Tram_Plat.TabIndex = 4
        Btn_Tram_Plat.Text = "Platform/s"
        Btn_Tram_Plat.UseVisualStyleBackColor = True
        ' 
        ' Btn_Tram_Onboard
        ' 
        Btn_Tram_Onboard.Location = New Point(93, 117)
        Btn_Tram_Onboard.Name = "Btn_Tram_Onboard"
        Btn_Tram_Onboard.Size = New Size(75, 23)
        Btn_Tram_Onboard.TabIndex = 5
        Btn_Tram_Onboard.Text = "Onboard"
        Btn_Tram_Onboard.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 13F)
        Label4.Location = New Point(12, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(372, 25)
        Label4.TabIndex = 6
        Label4.Text = "Bus"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Btn_Bus_LED
        ' 
        Btn_Bus_LED.Location = New Point(12, 171)
        Btn_Bus_LED.Name = "Btn_Bus_LED"
        Btn_Bus_LED.Size = New Size(75, 23)
        Btn_Bus_LED.TabIndex = 7
        Btn_Bus_LED.Text = "LED"
        Btn_Bus_LED.UseVisualStyleBackColor = True
        ' 
        ' Btn_Bus_LCD
        ' 
        Btn_Bus_LCD.Location = New Point(93, 171)
        Btn_Bus_LCD.Name = "Btn_Bus_LCD"
        Btn_Bus_LCD.Size = New Size(75, 23)
        Btn_Bus_LCD.TabIndex = 8
        Btn_Bus_LCD.Text = "LCD"
        Btn_Bus_LCD.UseVisualStyleBackColor = True
        ' 
        ' Btn_Bus_Eink
        ' 
        Btn_Bus_Eink.Location = New Point(174, 171)
        Btn_Bus_Eink.Name = "Btn_Bus_Eink"
        Btn_Bus_Eink.Size = New Size(75, 23)
        Btn_Bus_Eink.TabIndex = 9
        Btn_Bus_Eink.Text = "E-ink"
        Btn_Bus_Eink.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 202)
        Controls.Add(Btn_Bus_Eink)
        Controls.Add(Btn_Bus_LCD)
        Controls.Add(Btn_Bus_LED)
        Controls.Add(Label4)
        Controls.Add(Btn_Tram_Onboard)
        Controls.Add(Btn_Tram_Plat)
        Controls.Add(Label3)
        Controls.Add(Btn_Train_Plat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MainForm"
        Text = "Translink Departure Board"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Train_Plat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Tram_Plat As Button
    Friend WithEvents Btn_Tram_Onboard As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Bus_LED As Button
    Friend WithEvents Btn_Bus_LCD As Button
    Friend WithEvents Btn_Bus_Eink As Button
End Class
