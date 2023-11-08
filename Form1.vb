Public Class Form1
    Dim firstnumber, secondnumber, total As Double


    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        firstnumber = Val(txtfname.Text)
        secondnumber = Val(txtsnum.Text)

        If rdoAddition.Checked = True Then
            total = firstnumber + secondnumber
        ElseIf rdoSubtract.Checked = True Then
            total = firstnumber - secondnumber
        ElseIf rdoMultiplication.Checked = True Then
            total = firstnumber * secondnumber
        ElseIf rdoDivision.Checked = True Then
            total = firstnumber / secondnumber
        End If

        lblTotal.Text = Format(total, "0.00")

    End Sub
End Class
