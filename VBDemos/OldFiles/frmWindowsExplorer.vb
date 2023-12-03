Public Class frmWindowsExplorer

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        TreeView1.SelectedImageIndex = TreeView1.SelectedNode.Index
    End Sub
End Class