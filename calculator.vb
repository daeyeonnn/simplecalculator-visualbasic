Public Class calculator
    Dim firstnum, secondnum, total As Double
    Dim operation As String

    Private Sub btEight_Click(sender As Object, e As EventArgs) Handles btEight.Click
        lblDisplay.Text = lblDisplay.Text & 8
    End Sub

    Private Sub btSeven_Click(sender As Object, e As EventArgs) Handles btSeven.Click
        lblDisplay.Text = lblDisplay.Text & 7
    End Sub

    Private Sub btSix_Click(sender As Object, e As EventArgs) Handles btSix.Click
        lblDisplay.Text = lblDisplay.Text & 6
    End Sub

    Private Sub btFive_Click(sender As Object, e As EventArgs) Handles btFive.Click
        lblDisplay.Text = lblDisplay.Text & 5
    End Sub

    Private Sub btFour_Click(sender As Object, e As EventArgs) Handles btFour.Click
        lblDisplay.Text = lblDisplay.Text & 4
    End Sub

    Private Sub btThree_Click(sender As Object, e As EventArgs) Handles btThree.Click
        lblDisplay.Text = lblDisplay.Text & 3
    End Sub

    Private Sub btTwo_Click(sender As Object, e As EventArgs) Handles btTwo.Click
        lblDisplay.Text = lblDisplay.Text & 2
    End Sub

    Private Sub btOne_Click(sender As Object, e As EventArgs) Handles btOne.Click
        lblDisplay.Text = lblDisplay.Text & 1
    End Sub

    Private Sub btPlus_Click(sender As Object, e As EventArgs) Handles btPlus.Click
        firstnum = Val(lblDisplay.Text)
        operation = "+"
        clear()


    End Sub

    Private Sub btMinus_Click(sender As Object, e As EventArgs) Handles btMinus.Click
        firstnum = Val(lblDisplay.Text)
        operation = "-"
        clear()
    End Sub

    Private Sub btMultiply_Click(sender As Object, e As EventArgs) Handles btMultiply.Click
        firstnum = Val(lblDisplay.Text)
        operation = "*"
        clear()
    End Sub

    Private Sub btDivide_Click(sender As Object, e As EventArgs) Handles btDivide.Click
        firstnum = Val(lblDisplay.Text)
        operation = "/"
        clear()
    End Sub

    Private Sub btEquals_Click(sender As Object, e As EventArgs) Handles btEquals.Click
        secondnum = Val(lblDisplay.Text)

        Select Case operation
            Case "+"
                total = firstnum + secondnum
            Case "-"
                total = firstnum - secondnum
            Case "*"
                total = firstnum * secondnum
            Case "/"
                total = firstnum / secondnum
        End Select
        lblDisplay.Text = total

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clear()
    End Sub

    Private Sub btNine_Click(sender As Object, e As EventArgs) Handles btNine.Click
        lblDisplay.Text = lblDisplay.Text & 9
    End Sub

    Private Sub btDot_Click(sender As Object, e As EventArgs) Handles btDot.Click
        lblDisplay.Text = lblDisplay.Text & "."
    End Sub

    Private Sub btZero_Click(sender As Object, e As EventArgs) Handles btZero.Click
        lblDisplay.Text = lblDisplay.Text & 0
    End Sub

    Private Sub clear()
        lblDisplay.Text = ""
    End Sub
End Class