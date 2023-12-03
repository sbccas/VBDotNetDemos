Public Class Form1

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Dim i As Integer = 0
        Dim str As String = "NAME OF CONTROLS :" & vbNewLine
        For i = 0 To Me.Controls.Count - 1
            str += Me.Controls.Item(i).Name & vbNewLine
        Next

        MsgBox(str)
        Me.Controls.Item(9).Visible = False
    End Sub
End Class
