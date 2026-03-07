Public Class NoDepChange
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TrainBoard.NoDepMsg.Text = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TrainBoard.NoDepMsg.Text = TextBox1.Text
        StopIDChange.Show()
        Me.Close()
    End Sub
End Class