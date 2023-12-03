Public Class frmListboxDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.MultiColumn = False Then
            ListBox1.MultiColumn = True
        Else
            ListBox1.MultiColumn = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.SelectionMode = SelectionMode.None
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.SelectionMode = SelectionMode.One
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.SelectionMode = SelectionMode.MultiExtended
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MsgBox(ListBox1.SelectedItem)
        MsgBox("TOTAL ITEMS IN LISTBOX ARE : " & ListBox1.Items.Count)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'MsgBox("ITEM NAME IS : " & ListBox1.SelectedItem & vbNewLine & "ITEM INDEX IS : " & ListBox1.SelectedIndex)



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim i As Integer = 0
        Dim str As String = "YOUR SELECTED ITEMS NAMES ARTE : "
        For i = 0 To ListBox1.SelectedItems.Count - 1
            str += ListBox1.SelectedItems.Item(i).ToString
            str += vbNewLine
        Next
        MsgBox(str)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim str As String = InputBox("PLEASE ENTER NAME")
        If ListBox1.Items.Contains(str) Then
            'do nothing
            MsgBox(str & " Exists:")
        Else
            ListBox1.Items.Add(str)
        End If

        






    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("PLEASE SELECT YOUR ITEM")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            
        End If


    End Sub

    Private Sub btnRemoveAt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAt.Click
        If ListBox1.Items.Count < 6 Then
            'do nothing
        Else
            ListBox1.Items.RemoveAt(5)
        End If


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
        ListBox1.BackColor = Color.Cyan
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        'Dim inde As Integer = ListBox1.SelectedIndex


        ListBox1.Items.Insert(ListBox1.SelectedIndex, InputBox("PLEASE ENTER NANE :"))



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'If ListBox1.GetSelected(0) Then
        '    ListBox1.SetSelected(0, False)
        'Else
        '    ListBox1.SetSelected(0, True)
        'End If

        Dim i As Integer = 0
        For i = 0 To ListBox1.Items.Count - 1
            'ListBox1.SetSelected(i, True)
            If ListBox1.Items.Item(i) = "SYBCA" Then
                ListBox1.SetSelected(i, True)

            End If


        Next



        'ListBox1.GetSelected(

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MsgBox("YOUR SELECTED INDEX IS : " & ListBox1.SelectedIndex)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim i As Integer = 0

        Dim myindex As Integer = 0
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.GetSelected(i) Then
                myindex = i
            Else
                'myindex = -1
            End If
            
        Next
        If myindex <> -1 Then
            MsgBox("SYBCA IS LOCATED AT INDEX NO " & myindex)
        Else
            MsgBox("SYBCA IS NOT PRESENT")


        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ListBox1.ForeColor = Color.Aqua
        Dim i As Integer = 0
        For i = 0 To ListBox1.Items.Count - 1
            ListBox1.SetSelected(i, False)
        Next

        ListBox1.SetSelected(4, True)

        If ListBox1.GetSelected(3) Then
            MsgBox("YOU ARE LUCKY WINNER")
        Else
            MsgBox("BETTER LUCK NEXT TIME")
        End If

    End Sub
End Class