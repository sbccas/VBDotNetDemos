Public Class UCViewCode

    Private Sub ViewCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCodeToolStripMenuItem.Click
        For Each frm In Application.OpenForms
            MessageBox.Show(frm.Name)
        Next
    End Sub
End Class
