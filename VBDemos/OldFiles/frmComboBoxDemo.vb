Public Class frmComboBoxDemo

    

    'Dim i, n As Integer
    'Dim str() As String
    '    n = InputBox("PLEASE ENTER THE NUMBER  OF ITEMS TO ADD IN COMBOBOX")
    '    ReDim str(n - 1)

    '    For i = 0 To n - 1
    '        str(i) = InputBox("ENTER CITY NO " & i + 1, "ADD ITEMS TO COMBOBOX")
    '    Next
    '    ComboBox1.Items.AddRange(str)

    Private Sub frmComboBoxDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "TOTAL ITEMS IN COMBOBOX are " & ComboBox1.Items.Count
        ComboBox1.IntegralHeight = False
        ComboBox2.IntegralHeight = False
        ComboBox3.IntegralHeight = False
    End Sub
End Class