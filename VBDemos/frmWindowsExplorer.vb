Public Class frmWindowsExplorer

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim a As Integer = 0
        MsgBox(TreeView1.SelectedNode.Text)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListView1.View = View.Details Then
            ListView1.View = View.LargeIcon
            Button1.Text = View.LargeIcon.ToString
        ElseIf ListView1.View = View.LargeIcon Then
            ListView1.View = View.List
            Button1.Text = View.List.ToString
        ElseIf ListView1.View = View.List Then
            ListView1.View = View.SmallIcon
            Button1.Text = View.SmallIcon.ToString
        ElseIf ListView1.View = View.SmallIcon Then
            ListView1.View = View.Tile
            Button1.Text = View.Tile.ToString
        Else
            ListView1.View = View.Details
            Button1.Text = View.Details.ToString

        End If
    End Sub

    Private Sub LargeIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconToolStripMenuItem.Click
        ListView1.View = View.LargeIcon



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TreeView1.Nodes.Add("RONAK")
    End Sub
End Class