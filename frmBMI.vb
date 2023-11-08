Public Class frmBMI
    Dim height, weight, totalbmi As Double
    Dim status As String

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Call cleartextboxes()
    End Sub

    Private Sub frmBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cleartextboxes()
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        height = Val(txtHeight.Text)
        weight = Val(txtWeight.Text)

        totalbmi = weight / (height * height)

        If totalbmi <= 18.4 Then
            status = "Underweight"
        ElseIf totalbmi >= 18.5 And totalbmi <= 24.9 Then
            status = "Normal"
        ElseIf totalbmi >= 24.5 And totalbmi <= 39.9 Then
            status = "Overweight"
        ElseIf totalbmi >= 40 Then
            status = "Obese"
        Else
            status = "Invalid BMI"
        End If

        lblBMI.Text = totalbmi
        lblStatus.Text = status
    End Sub

    Private Sub cleartextboxes()
        txtHeight.Clear()
        txtWeight.Clear()
        lblBMI.Text = ""
        lblStatus.Text = ""
    End Sub
End Class