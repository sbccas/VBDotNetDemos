Public Class frmInputBoxDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = ""
        str = InputBox("Please Enter Your Name", "WINTER SYBCA", "PARTH", 600, 600)
        str += InputBox("Please Enter Your City", , "SURAT", , )
        MsgBox(" STUDENT DETAILS  " & str)




        'Dim str2 As String = ""
        'For i As Integer = 50 To 0 Step -2
        '    str2 += i & vbNewLine
        'Next
        'MessageBox.Show("TESTING : " & str2, "MSG DEMO", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)



        'With Button1
        '    .Text = "EXAMPLES DONE"
        '    .Size = New Size(200, 200)
        '    .ForeColor = Color.Cyan
        '    .BackColor = Color.LightSkyBlue
        '    .Enabled = False
        '    .Focus()
        'End With

    End Sub

    Private Sub btnForloop_Click(sender As Object, e As EventArgs) Handles btnForloop.Click
        For i As Integer = 1 To 10
            MsgBox("HELLO " + i.ToString)
        Next
    End Sub
End Class