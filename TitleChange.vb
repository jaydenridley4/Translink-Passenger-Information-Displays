Public Class TitleChange
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TrainBoard.BoardTitle.Text = TextBox1.Text
        TrainBoard.Text = "Translink QR Departure Board - " & TextBox1.Text
        Me.Close()
    End Sub
End Class