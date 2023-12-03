Option Strict Off
Public Class Form2


    'Declaration for Global Varibles
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Dim a As Double
        'Dim b As Integer
        'Dim c As Integer

        ''Dim c As Integer
        'a = Val(txtNo1.Text)
        'b = CInt(txtNo2.Text)
        'c = a / b
        'lblAns.Text = "YOUR ANS IS : " & c

        ''Dim myvar As Date
        ''myvar = #12/31/2016#

        'MsgBox("HELLO1", MsgBoxStyle.Exclamation, "MY CUSTOM MSG BOX")
        'MessageBox.Show("HELLO2", "SUTEX BCA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        txtNo1.Text = InputBox("PLEASE ENTER NO 1", "ADDITION", , , )
        txtNo2.Text = InputBox("PLEASE ENTER NO 2", "ADDITION", , , )
        lblAns.Text = Val(txtNo1.Text) + Val(txtNo2.Text)
    End Sub
End Class