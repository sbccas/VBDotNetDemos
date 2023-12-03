Public Class frmMaskedTextBox

    Private Sub MaskedTextBox3_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected
        MsgBox("WRONG INPUT")
        MaskedTextBox3.Text = " "
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        MsgBox("WRONG INPUT")
        MaskedTextBox1.Text = " "
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected
        MsgBox("WRONG INPUT")
        MaskedTextBox1.Text = " "
    End Sub
End Class