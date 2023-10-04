Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLeftFunction_Click(sender As Object, e As EventArgs) Handles btnLeftFunction.Click
        Dim phrase As String, n As Integer
        phrase = txtEnterAPhrase.Text
        n = InputBox("How many Characters from the Left? ")
        txtSelectedFunctionResult.Text = Microsoft.VisualBasic.Left(phrase, n)
    End Sub

    Private Sub btnRightFunction_Click(sender As Object, e As EventArgs) Handles btnRightFunction.Click
        Dim phrase As String, n As Integer
        phrase = txtEnterAPhrase.Text
        n = InputBox("How many Characters from the Right? ")
        txtSelectedFunctionResult.Text = Microsoft.VisualBasic.Right(phrase, n)
    End Sub

    Private Sub btnMidFunction_Click(sender As Object, e As EventArgs) Handles btnMidFunction.Click
        Dim phrase As String, from As Integer, toWhich As Integer
        phrase = txtEnterAPhrase.Text
        from = InputBox("From which Character number?")
        toWhich = InputBox("To which character number?")
        txtSelectedFunctionResult.Text = Mid(phrase, from, toWhich)
    End Sub
End Class
