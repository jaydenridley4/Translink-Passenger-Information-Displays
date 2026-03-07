<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TramOnboard
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
        NextStop1 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        NextStop1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Avenir Black", 30F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 61)
        Label1.TabIndex = 0
        Label1.Text = "This Stop"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Avenir Black", 40F, FontStyle.Bold)
        Label2.Location = New Point(272, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(624, 82)
        Label2.TabIndex = 1
        Label2.Text = "Surfers Paradise North"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NextStop1
        ' 
        NextStop1.BackColor = Color.Transparent
        NextStop1.Controls.Add(Label5)
        NextStop1.Controls.Add(PictureBox1)
        NextStop1.Controls.Add(Label4)
        NextStop1.Controls.Add(Label3)
        NextStop1.Location = New Point(0, 110)
        NextStop1.Name = "NextStop1"
        NextStop1.Size = New Size(896, 110)
        NextStop1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.Dot
        PictureBox1.Location = New Point(192, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Avenir Black", 26F, FontStyle.Bold)
        Label4.Location = New Point(72, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 53)
        Label4.TabIndex = 4
        Label4.Text = "min"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Avenir Black", 36F, FontStyle.Bold)
        Label3.Location = New Point(-7, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 75)
        Label3.TabIndex = 3
        Label3.Text = "39"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Avenir Black", 40F, FontStyle.Bold)
        Label5.Location = New Point(218, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(624, 75)
        Label5.TabIndex = 3
        Label5.Text = "Surfers Paradise North"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TramOnboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Background
        ClientSize = New Size(896, 576)
        Controls.Add(NextStop1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        MaximumSize = New Size(912, 615)
        MinimumSize = New Size(912, 615)
        Name = "TramOnboard"
        Text = "TramOnboard"
        NextStop1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NextStop1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
