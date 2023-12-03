Public Class frmListBoxPart2

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub btnSRSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSRSingle.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Else
            MsgBox("Please Select Any Item : ")
        End If



    End Sub

    Private Sub btnSRAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSRAll.Click
        ListBox2.Items.AddRange(ListBox1.Items)
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelDeselect.Click
        'MsgBox("SELECTED INDEX IS : " & ListBox1.SelectedIndex)

        If ListBox1.SelectedIndex <> -1 Then

            Dim i As Integer = 0
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, False)
            Next

        Else
            Dim i As Integer = 0
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, True)
            Next
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String = InputBox("PLEASE ENTER ANY NAME ", "LISTBOX ITEMS ADD")
        If ListBox1.Items.Contains(str) Then
            'do nothing
        Else
            ListBox1.Items.Add(str)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim str(10) As String
        str(0) = "SUTEX"
        str(1) = "SUTEX "
        str(2) = "SUTEX B"
        str(3) = "SUTEX BC"
        str(4) = "SUTEX BCA"
        str(5) = "SUTEX BCA "
        str(6) = "SUTEX BCA C"
        str(7) = "SUTEX BCA CO"
        str(8) = "SUTEX BCA COL"
        str(9) = "SUTEX BCA COLL"
        

        ListBox2.Items.CopyTo(str, 5)
        Dim i As Integer = 0
        Dim str1 As String = "NEW ARRAY DATA : "
        For i = 0 To str.Length
            str1 += str(i).ToString
        Next
        MsgBox(str1)
    End Sub

   
    Private Sub ListBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Control Then
            Dim i As Integer = 0
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, True)
            Next
        End If
    End Sub
End Class