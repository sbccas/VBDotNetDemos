Public Class frmNavigationDemo

    Private Sub frmNavigationDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DemosDataSet.hitlist' table. You can move, or remove it, as needed.
        Me.HitlistTableAdapter.Fill(Me.DemosDataSet.hitlist)

    End Sub
End Class