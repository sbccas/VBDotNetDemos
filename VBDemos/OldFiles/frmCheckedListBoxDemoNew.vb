Public Class frmCheckedListBoxDemoNew

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim str As String = "YOUR SELECTED HOBBIES ARE : " & vbNewLine
        For i = 0 To chklstdemo.Items.Count - 1

            If chklstdemo.GetItemChecked(i) Then
                str += chklstdemo.Items.Item(i) & vbNewLine
            Else

            End If

        Next
        MsgBox(str)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String = "YOUR SELECTED ITEMS ARE " & vbNewLine

        Dim i As Integer = 0

        For i = 0 To chklstdemo.Items.Count - 1

            str &= chklstdemo.SelectedItems.Item(i) & vbNewLine
        Next
        MsgBox(str)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer = 0
        Dim str As String = "YOU HAVE NOT  SELECTED : " & vbNewLine

        For i = 0 To chklstdemo.Items.Count - 1
            If chklstdemo.GetItemChecked(i) Then
            Else
                str += chklstdemo.Items.Item(i) & vbNewLine
            End If
        Next
        MsgBox(str)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        chklstdemo.SetItemChecked(5, True)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox(chklstdemo.GetItemCheckState(4))
        chklstdemo.SetItemCheckState(5, CheckState.Checked)
    End Sub
End Class