Public Class frmNotepad2021

    
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)


    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)



    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        Else
            MsgBox("YOU PRESSED CANCEL BUTTON")
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub OpenDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDemoToolStripMenuItem.Click
        Dim frmPer As New frmPerDetails
        frmPer.ShowDialog()
    End Sub

    Private Sub SELECTEDFONTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SELECTEDFONTToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
        RichTextBox1.SelectionColor = FontDialog1.Color
    End Sub

    Private Sub frmNotepad2021_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "SYBCA3"
        RichTextBox1.Clear()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If Me.Text = "SYBCA" Or RichTextBox1.TextLength <> 0 Then
            If MessageBox.Show("DO YOU WANT TO SAVE YOUR FILE", "SYBCA NOTEPAD", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'save file process
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)

                End If

            Else
                'DOnt want to save file
                RichTextBox1.Clear()
            End If

        Else



        End If
    End Sub
End Class