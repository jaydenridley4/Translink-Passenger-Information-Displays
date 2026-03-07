<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TramBoard
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
        Dep1_Destination = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Dep1_Destination
        ' 
        Dep1_Destination.Font = New Font("Arial", 27.2F)
        Dep1_Destination.ForeColor = Color.White
        Dep1_Destination.Location = New Point(0, 0)
        Dep1_Destination.Name = "Dep1_Destination"
        Dep1_Destination.Size = New Size(609, 50)
        Dep1_Destination.TabIndex = 0
        Dep1_Destination.Text = "🚊Broadbeach South"
        Dep1_Destination.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 27.2F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 50)
        Label1.TabIndex = 1
        Label1.Text = "🚊Broadbeach South"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 27.2F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(609, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 50)
        Label2.TabIndex = 2
        Label2.Text = "1 min"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 27.2F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(609, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 50)
        Label3.TabIndex = 3
        Label3.Text = "12 min"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial", 27.2F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(0, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(809, 50)
        Label4.TabIndex = 4
        Label4.Text = "6:37:54 pm"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 27.2F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(0, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(809, 50)
        Label5.TabIndex = 5
        Label5.Text = "NO TICKET? Expect a fine"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 27.2F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(0, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(809, 50)
        Label6.TabIndex = 6
        Label6.Text = "If you don't have a ticket the fine is $333"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TramBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(809, 250)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Dep1_Destination)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "TramBoard"
        Text = "Translink G:link Departure Board - Cavill Avenue station, platform 2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Dep1_Destination As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
