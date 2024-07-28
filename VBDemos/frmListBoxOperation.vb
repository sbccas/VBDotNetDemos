Public Class frmListBoxOperation

    Private Sub btnSRSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSRSingle.Click
        'ListBox2.Items.Add(ListBox1.SelectedItem)
        'ListBox1.Items.Remove(ListBox1.SelectedItem)
        If ListBox1.SelectedIndex <> -1 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
            Else
                MsgBox("List Empty please Fill.....!")
            End If
        Else
            MsgBox("Please Select an Item...!")
        End If


    End Sub
    Private Sub btnSLSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSLSingle.Click
        If ListBox2.SelectedIndex <> -1 Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            If ListBox2.Items.Count > 0 Then
                ListBox2.SelectedIndex = 0
            Else
                MsgBox("List Empty please Fill.....!")
            End If
        Else
            MsgBox("Please Select an Item...!")
        End If
    End Sub

    Private Sub btnSelDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelDeselect.Click
        'MsgBox("SELECTED INDEX IS : " & ListBox1.SelectedIndex)

        If ListBox1.SelectedIndex <> -1 Then

            Dim i As Integer = 0
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, False)
            Next
            btnSelDeselect.Text = "SELECT ALL"

        Else
            Dim i As Integer = 0
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, True)
            Next
            btnSelDeselect.Text = "DESELECT ALL"
        End If

    End Sub

    Private Sub btnAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd1.Click
        Dim str As String = InputBox("PLEASE ENTER ANY NAME ", "LISTBOX ITEMS ADD")
        If ListBox1.Items.Contains(str) Then
            'do nothing
        Else
            ListBox1.Items.Add(str)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If InputBox("WHICH LISTBOX YOU WANT TO CLEAR", "CLEAR LIST") = "1" Then
            ListBox1.Items.Clear()
        Else
            ListBox2.Items.Clear()

        End If
    End Sub

   
    Private Sub btnAddArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArray.Click
        Dim str(9) As String
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

        
        ListBox2.Items.AddRange(str)
        'ListBox2.Items.CopyTo(str, 5)
        'Dim i As Integer = 0
        'Dim str1 As String = "NEW ARRAY DATA : "
        'For i = 0 To str.Length - 1
        '    str1 += str(i).ToString
        'Next
        'MsgBox(str1)
    End Sub

    Private Sub btnSRAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSRAll.Click
        ListBox2.Items.AddRange(ListBox1.Items)
        ListBox1.Items.Clear()


        'Dim i As Integer = 0
        'For i = 0 To ListBox1.Items.Count - 1
        '    ListBox2.Items.Add(ListBox1.Items.Item(i).ToString)
        '    ' ListBox1.Items.RemoveAt(0)

        'Next
        'ListBox1.Items.Clear()
    End Sub

    Private Sub btnSLAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSLAll.Click
        ListBox1.Items.AddRange(ListBox2.Items)
        ListBox2.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If InputBox("WHICH LISTBOX YOU WANT TO CLEAR", "CLEAR LIST") = "1" Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Else
            ListBox2.Items.Remove(ListBox2.SelectedItem)

        End If

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If InputBox("WHICH LISTBOX YOU WANT TO CLEAR", "CLEAR LIST") = "1" Then
            ListBox1.Items.Insert(InputBox("WHICH LOCATION DO YOU WANT TO INSERT", "INSERT BOX"), InputBox("WHICH ITEM DO YOU WANT TO INSERT", "INSERT ITEM BOX"))
        Else
            ListBox2.Items.Insert(InputBox("WHICH LOCATION DO YOU WANT TO INSERT", "INSERT BOX"), InputBox("WHICH ITEM DO YOU WANT TO INSERT", "INSERT ITEM BOX"))

        End If

    End Sub

    Private Sub btnRemoveAt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAt.Click

    End Sub
End Class