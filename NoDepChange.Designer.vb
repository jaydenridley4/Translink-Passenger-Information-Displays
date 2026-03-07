<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoDepChange
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "There are no trains departing from platform 2 within the next 4 hours"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 23)
        Button1.TabIndex = 1
        Button1.Text = "Set"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(189, 41)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 23)
        Button2.TabIndex = 2
        Button2.Text = "Stop IDs"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' NoDepChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 76)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "NoDepChange"
        Text = "Change no train message"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
