Public Class StopIDChange
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rawInput = TextBox1.Text
        Dim stopIdList = rawInput.Split({","}, StringSplitOptions.RemoveEmptyEntries) _
                                  .Select(Function(s) s.Trim()) _
                                  .Where(Function(s) s.All(AddressOf Char.IsDigit)) _
                                  .ToArray()


        If stopIdList.Length = 0 Then
            MessageBox.Show("Please enter at least one valid stop ID.")
            Return
        End If

        CType(Application.OpenForms("TrainBoard"), TrainBoard).CustomStopIds = stopIdList

        Me.Hide()
    End Sub
End Class