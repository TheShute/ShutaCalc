Public Class frmCallCalc

    Private Sub frmCallCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblNoOfMins.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnWeekDay_Click(sender As Object, e As EventArgs) Handles btnWeekDay.Click

        Const Week_Day_Rate = 0.35
        Dim TopUpAmount As Decimal
        Dim NoOfMins As Double
        '****************** Collect the input ******************
        TopUpAmount = Val(txtAmount.Text)
        '****************** Process the data *******************
        NoOfMins = TopUpAmount / Week_Day_Rate
        '***************** Display the output ******************
        lblResult.Text = Format(NoOfMins, "###0.00")


    End Sub

 



    Private Sub lblAmount_Click(sender As Object, e As EventArgs) Handles lblAmount.Click

    End Sub
End Class
