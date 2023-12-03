Public Class frmInputBoxDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = ""
        str = InputBox("Please Enter Your Name", "SYBCA DIV 3", "KARAN", 400, 400)
        str += InputBox("PLease Enter Your City", , "SURAT", , )
        'MsgBox(" DETAILS  " & str)
        Dim str2 As String = ""
        For i As Integer = 50 To 0 Step -2
            str2 += i & vbNewLine
        Next
        MessageBox.Show("TESTING : " & str2, "MSG DEMO", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        

        With Button1
            .Text = "EXAMPLES DONE"
            .Size = New Size(200, 200)
            .ForeColor = Color.Cyan
            .BackColor = Color.LightSkyBlue
            .Enabled = False
            .Focus()
        End With

    End Sub
End Class