Public Class frmMultiComboBox

    Private Sub frmMultiComboBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DemosDataSet3.hitlist' table. You can move, or remove it, as needed.
        Me.HitlistTableAdapter.Fill(Me.DemosDataSet3.hitlist)
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedValue
    End Sub
End Class