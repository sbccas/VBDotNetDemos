Public Class frmComboBoxDemo

    Private Sub frmComboBoxDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "HELLO I AM COMBOBOX-2 and I HAVE " & ComboBox2.Items.Count & " ITEMS IN ME....!!"

        Label1.Text = ComboBox1.Name
        Label2.Text = ComboBox2.Name
        Label3.Text = ComboBox3.Name

        Label1.Text += " STYLE : " & ComboBox1.DropDownStyle.ToString
        Label2.Text += " STYLE : " & ComboBox2.DropDownStyle.ToString
        Label3.Text += " STYLE : " & ComboBox3.DropDownStyle.ToString

        ' Me.Text = "COMBOBOX 2 COUNT : " & ComboBox2.Items.Count

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = InputBox("PLEASE ENTER YOUR NAME")
        ComboBox1.Items.Insert(0, str)
        ComboBox2.Items.Insert(0, str)
        ComboBox3.Items.Insert(0, str)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex = 0 Then
            ComboBox1.Items.Clear()
        ElseIf ComboBox4.SelectedIndex = 1 Then
            ComboBox2.Items.Clear()
        Else
            ComboBox3.Items.Clear()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label2.Text = "YOU  SELECTED : " & ComboBox2.SelectedItem.ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub frmComboBoxDemo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Me.BackColor = Color.Cornsilk
    End Sub

    Private Sub frmComboBoxDemo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = Color.LightYellow
    End Sub


End Class