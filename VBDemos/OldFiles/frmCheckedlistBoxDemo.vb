
Public Class frmCheckedListBoxDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckedListBox1.Items.Add(InputBox("ENTER NAME", "ADD"))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(i, True)

        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As Integer
        Dim str As String = "YOUR SELECTED ITEMS ARE (CHECKED) : " & vbNewLine
        Dim str1 As String = "YOUR NOT SELECTED ITEMS ARE (UNCHECKED) : " & vbNewLine
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) = True Then
                'MsgBox("you selected " & CheckedListBox1.Items.Item(i).ToString)
                'MsgBox("aND State is  " & CheckedListBox1.GetItemCheckState(i).ToString)
                str += CheckedListBox1.Items.Item(i) & vbNewLine

            Else
                'MsgBox("aND State is  " & CheckedListBox1.GetItemCheckState(i).ToString)
                str1 += CheckedListBox1.Items.Item(i) & vbNewLine
            End If
        Next

        str += "TOTAL SELECTED ITEMS ARE : " & CheckedListBox1.CheckedItems.Count & vbNewLine
        str1 += "TOTAL DESELECTED ITEMS ARE : " & CheckedListBox1.Items.Count - CheckedListBox1.CheckedItems.Count & vbNewLine
        MsgBox(str & vbNewLine & "===============================" & vbNewLine & str1 & "====================================" & vbNewLine & "TOTAL NO OF ITEMS IN CHECKEDLISTBOX ARE : " & CheckedListBox1.Items.Count)




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim str As String
        For i = 0 To CheckedListBox1.Items.Count - 1

            str = CheckedListBox1.Items.Item(i)

            If str.StartsWith(TextBox1.Text, StringComparison.CurrentCultureIgnoreCase) Then
                CheckedListBox1.SetItemChecked(i, True)
            Else
                CheckedListBox1.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'Dim i As Integer
        'Dim str As String
        'For i = 0 To CheckedListBox1.Items.Count - 1

        '    str = CheckedListBox1.Items.Item(i)
        '    If str.StartsWith(TextBox1.Text, StringComparison.CurrentCultureIgnoreCase) Then
        '        CheckedListBox1.SetItemChecked(i, True)
        '    Else
        '        CheckedListBox1.SetItemChecked(i, False)
        '    End If
        'Next
    End Sub

  
End Class