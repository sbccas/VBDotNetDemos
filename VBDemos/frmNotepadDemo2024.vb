Public Class frmNotepadDemo2024
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub COPYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PASTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub REDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REDOToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        'SAVE FILE WITH NEW NAME



    End Sub

    Private Sub SAVEASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEASToolStripMenuItem.Click

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)

        End If

    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        With OpenFileDialog1
            .Filter = "SUTEX TEXT FILE | *.txt"
            If .ShowDialog() = DialogResult.OK Then
                RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                Me.Text = .FileName
            End If
        End With





    End Sub

    Private Sub SelectionOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectionOnlyToolStripMenuItem.Click
        ColorDialog1.ShowDialog()

        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub SelectiomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectiomToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
            RichTextBox1.SelectionColor = FontDialog1.Color
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.ZoomFactor = 5
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        RichTextBox1.ZoomFactor = 10
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 1
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

        ToolStripStatusLabel1.Text = "Character : " + RichTextBox1.TextLength.ToString
    End Sub

    Private Sub AllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem1.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        End If

    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub CebnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CebnterToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        If RichTextBox1.TextLength > 0 Or Me.Text = "UNTITLED" Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                RichTextBox1.Text = ""
                Me.Text = ""
            End If

        End If
    End Sub

    Private Sub frmNotepadDemo2024_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "UNTITLED"
        RichTextBox1.Text = ""
    End Sub

    Private Sub PRINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub
End Class