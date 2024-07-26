

Public Class Form2

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim p, r, n As Double
        Dim str As String = "Sutex "
        Dim dt As Date = #12/31/2018#
        Dim abc As String = "hello"

        Const colname As String = "Sutex Bank College of Computer Applications & Science"

        p = 0
        r = 0
        n = 0
        p = txtPrin.Text
        r = txtRate.Text
        n = txtYear.Text
        txtAns.Text = (p * r * n) / 100

        Me.Text = colname

        
        

    End Sub
End Class