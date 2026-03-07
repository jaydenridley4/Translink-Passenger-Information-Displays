Public Class MainForm
    Private Sub Btn_Train_Plat_Click(sender As Object, e As EventArgs) Handles Btn_Train_Plat.Click
        TrainBoard.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_Tram_Plat_Click(sender As Object, e As EventArgs) Handles Btn_Tram_Plat.Click
        TramBoard.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args() As String = Environment.GetCommandLineArgs()
        For i As Integer = 0 To args.Length - 1
            Select Case args(i).ToLower()
                Case "-trainboard"
                    TrainBoard.Show()
                    Me.BeginInvoke(Sub() Me.Hide()) ' runs right after form load finishes
            End Select
        Next
    End Sub

    Private Sub Btn_Tram_Onboard_Click(sender As Object, e As EventArgs) Handles Btn_Tram_Onboard.Click
        TramOnboard.Show()
        Me.Hide()
    End Sub
End Class