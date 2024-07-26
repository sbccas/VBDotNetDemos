Public Class frmListBoxDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '        ListBox1.Items.Clear()
        ListBox1.Items.Add("SYBCA3")
        ListBox1.Items.Insert(0, "SUTEX")
        ListBox1.Items.Remove("12")
        ListBox1.Items.RemoveAt(5)
        Label1.Text = "ITEMS = " & ListBox1.Items.Count & vbNewLine
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        Label1.Text &= "SELECTION MODE = " & ListBox1.SelectionMode
        Label1.Text &= "ITEM AT LOCATION 10 is " & ListBox1.Items.Item(9).ToString
    End Sub

    
    Private Sub btnSelMode0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelMode0.Click
        ListBox1.SelectionMode = SelectionMode.None
    End Sub

    Private Sub btnSelMode1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelMode1.Click
        ListBox1.SelectionMode = SelectionMode.One
    End Sub

    Private Sub btnSelMod2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelMod2.Click
        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub btnSelMode3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelMode3.Click
        ListBox1.SelectionMode = SelectionMode.MultiExtended
    End Sub

    Private Sub frmListBoxDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ListBox1.SelectionMode = SelectionMode.None Then
            btnSelMode0.BackColor = Color.Green
            Me.Text = "DEMO OF LISTBOX : [" & ListBox1.Items.Count & "]"
        End If
    End Sub

  
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        If ListBox1.SelectedIndex <> -1 Then
            MsgBox("YOUR SELECTED ITEM IS : " & ListBox1.SelectedItem.ToString & " and IT IS LOCATED AT : " & ListBox1.SelectedIndex + 1)
        Else
            MsgBox("NOTHING IS SELECTED. PLEASE SELECT AN ITEM")
        End If







    End Sub

    Private Sub btnSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelAll.Click
        Dim flag As Boolean = False
        If flag = False Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, True)

            Next
            flag = True
        Else
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, False)

            Next
            flag = False
        End If

    End Sub

    

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click



        'listbox items ----->>> name exists ----->>> new item add    
        ' ----->>> if exists warn user
        Dim strname As String = ""
        strname = InputBox("ENTER YOUR NAME")
        If ListBox1.Items.Contains(strname) = True Then
            MsgBox("YOUR ITEM ALREADY EXISTS")
        Else
            ListBox1.Items.Add(strname)
            Me.Text = "total items in listbox = " & ListBox1.Items.Count
        End If


        'Dim str As String = InputBox("Please type the Item Name :", "Add ITEM", , , )
        'If str <> "" And Not str.Contains(" ") And Not ListBox1.Items.Contains(str) Then
        '    ListBox1.Items.Add(str)
        '    Me.Text = "DEMO OF LISTBOX : [" & ListBox1.Items.Count & "]"
        'Else
        '    MsgBox("EMPTY ITEM NOT POSSIBLE TO ADD")
        'End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'listbox remove selected item (single)
        'ListBox1.Items.Remove(ListBox1.SelectedItem)
        'remove listbox multiple selected items
        Dim i As Integer = 0
        For i = 0 To ListBox1.SelectedItems.Count - 1
            'MsgBox(ListBox1.SelectedItems.Item(i).ToString)
            ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0).ToString)
        Next

        'If ListBox1.SelectedItems.Count > 1 Then
        '    For i As Integer = 0 To ListBox1.SelectedItems.Count - 1
        '        ListBox1.Items.Remove(ListBox1.SelectedItems.Item(i).ToString)
        '    Next
        'ElseIf ListBox1.SelectedItems.Count = 1 Then
        '    ListBox1.Items.Remove(ListBox1.SelectedItem)
        'Else
        '    MsgBox("Please Select item to Remove")
        'End If



    End Sub

    Private Sub btnInvSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvSel.Click
        If ListBox1.SelectionMode = SelectionMode.MultiExtended Or ListBox1.SelectionMode = SelectionMode.MultiSimple Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                If ListBox1.GetSelected(i) Then
                    ListBox1.SetSelected(i, False)
                Else
                    ListBox1.SetSelected(i, True)
                End If

            Next
            
        ElseIf ListBox1.SelectionMode = SelectionMode.One Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(i, True)
            Next
        Else
            MsgBox("SELCTION NOT POSSIBLE BECAUSE" & vbNewLine & " SELECTION MODE IS NONE")
        End If

        ''demo for delete invert selection
        'For i As Integer = 0 To ListBox1.SelectedItems.Count - 1
        '    ListBox1.Items.Remove(ListBox1.SelectedItems.Item(i).ToString)
        'Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListBox1.SelectedIndex = -1

    End Sub

    Private Sub btnAdd500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd500.Click
        For i As Integer = 0 To 499
            ListBox1.Items.Add("Item No : " & i)
        Next
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        'ListBox1.Items.Insert(ListBox1.SelectedIndex, InputBox("PleAse Enter YOur Item ", "Insert Item"))

        Dim i As Integer = InputBox("PLEASE ENTER INDEX TO INSERT ITEM")
        Dim stri As String = InputBox("PLEASE ENTER THE ITEM NAME")
        ListBox1.Items.Insert(i, stri)



    End Sub

    Private Sub btnRemoveAt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAt.Click
        'ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.Items.RemoveAt(InputBox("Please Enter Index to Remove", "RemoveAt"))
    End Sub

    
  
  
    Private Sub btnGetIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetIndex.Click
        Me.Text = "Selected Index : " & ListBox1.SelectedIndex
    End Sub

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim STR As String = InputBox("CHECK IF EXISTS")
        If ListBox1.Items.Contains(STR) Then
            MsgBox("FOUND YOUR ITEM")
        Else
            ListBox1.Items.Add(STR)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Me.Text = "ListBox Control Demo : [ Total = " & ListBox1.Items.Count & " Items ] "
        Label1.Text = ListBox1.SelectedItem


    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim strsearch As String = InputBox("PLEASE TELL YOUR ITEM NAME TO SEARCH")
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items.Item(i).ToString = strsearch Then
                ListBox1.SetSelected(i, True)
            Else
                ListBox1.SetSelected(i, False)
            End If
        Next
        If ListBox1.SelectedItems.Count > 0 Then
            MsgBox("FOUND YOUR ITEM")
        Else
            MsgBox("YOUR ITEM NOT AVAILABLE")
        End If





    End Sub

   
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = InputBox("ENTER NAME TO FIND IN LISTBOX")

        If ListBox1.Items.Contains(str) Then
            MsgBox("FOUND YOUR ITEM")
        Else
            MsgBox("YOUR ITEM IS NOT HERE ")
        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnGetSelectedCount.Click
        'LIST BOX ALL ITEM COUNT 
        MsgBox("TOTAL ITEMS : " + ListBox1.Items.Count.ToString)
        'LIST BOX SELECTED ITEM COUNT
        MsgBox("TOTAL SELECTED ITEMS : " + ListBox1.SelectedItems.Count.ToString)
    End Sub

    Private Sub btnFind2_Click(sender As Object, e As EventArgs) Handles btnFind2.Click
        'FIND AN ITEM IN THE LISTBOX
        Dim str As String = ""
        str = InputBox("PLEASE TELL ME NAME OF YOUTR ITEM ")
        Dim flag As Boolean = False
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items.Item(i).ToString = str Then
                MsgBox("ITEM FOUND AT INDEX " + i.ToString)
                flag = True
            End If
        Next
        If flag = False Then
            MsgBox("ITEM NOT FOUND")
        End If


    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click

        If ListBox1.SelectedItems.Count > 0 Then
            ListBox1.SelectedItem.ToString()
        Else
            MsgBox("PLEASE SELECT ANY ITEM")
        End If

    End Sub


End Class