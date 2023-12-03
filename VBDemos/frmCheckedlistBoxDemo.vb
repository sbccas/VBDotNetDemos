Option Explicit On
'Option Strict On
'Option Compare Binary
Option Infer Off
Public Class frmCheckedListBoxDemo
    Dim sybca2 As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            uncheckall()
        Else
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
        End If

    End Sub
    Sub uncheckall()
        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next

    End Sub




    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        CheckedListBox1.Items.Add(InputBox("ENTER NAME", "ADD"))
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
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

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(i, True)

        Next
    End Sub

    Private Sub btnUncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUncheckAll.Click
        uncheckall()
    End Sub

    Private Sub btnGetCheckedItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCheckedItems.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim devar As Decimal = 111.23456
        'Dim invar As Integer = devar
        'MsgBox(invar)
        'Dim str1, str2 As String
        'str1 = "SUTEX"
        'str2 = "sutex"

        'If str1 = str2 Then
        '    MsgBox("BOTH ARE SAME")
        'Else
        '    MsgBox("BOTH ARE ENEMIES")
        'End If

        ''option infere
        'Dim bca1 = New ListBox
        'Me.Controls.Add(bca1)

        Dim i As Integer
        Dim str As String = "NAME OF ALL CONTROLS " & vbNewLine
        For i = 0 To Me.Controls.Count - 1
            str &= Me.Controls.Item(i).Name & vbNewLine
        Next
        MsgBox(str)
        Dim btnobj As New Button
        btnobj.Text = "btnVIral"
        Me.Controls.Add(btnobj)

    End Sub

    Private Sub frmCheckedListBoxDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'total controls on this form
        Me.Text = "SUTEXBCA : TOTAL CONTROLS : " & Me.Controls.Count





    End Sub
End Class