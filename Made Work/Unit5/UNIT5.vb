Public Class frmCallCalc

    Private Sub frmCallCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblBillToPay.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsed.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End


    End Sub

    Private Sub btnWeekDay_Click(sender As Object, e As EventArgs) Handles btnWeekDay.Click

        Const VAT_Amount_To_Add = 0.35
        Const VAT_FITHTEEN = 15
        Const VAT_TwnetyPercent = 0.2
        Dim TopUpAmount As Decimal
        Dim NoOfMins As Double
        '****************** Collect the input ******************
        TopUpAmount = Val(txtUsed.Text)
        '****************** Process the data *******************
        NoOfMins = (TopUpAmount * VAT_Amount_To_Add) + (VAT_FITHTEEN) + (TopUpAmount * VAT_TwnetyPercent)
        '***************** Display the output ******************
        txtPay.Text = Format(NoOfMins, "###0.00")


    End Sub

 



    Private Sub lblAmount_Click(sender As Object, e As EventArgs) Handles lblUnits.Click

    End Sub
End Class
