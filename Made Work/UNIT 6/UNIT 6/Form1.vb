Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Activate_Click(sender As Object, e As EventArgs) Handles Activate.Click
        ProgressBar1.PerformStep()
    End Sub
End Class
