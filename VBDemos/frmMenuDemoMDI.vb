Public Class frmMenuDemoMDI

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim obj As New frmMenuSDI
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim obj As New frmSearchDataReader
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("I AM ALL CAPS")
    End Sub

    Private Sub ShowAllDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllDataToolStripMenuItem.Click
        Dim frm As New frmShowAllData
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub COpyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COpyToolStripMenuItem.Click
        Dim frm As New frmShowSpecialData
        frm.MdiParent = Me
        frm.WindowState = FormStartPosition.WindowsDefaultLocation
        frm.Show()
    End Sub
End Class