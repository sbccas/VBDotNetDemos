Public Class frmNotepadDemo
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim myobj As New Form1
        'myobj.ShowDialog()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim myobj As New Form1
        'myobj.Show()
    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        ToolStripStatusLabel1.Text = "Characters :  " & RichTextBox1.TextLength
        ToolStripStatusLabel1.Text &= " Lines :  " & RichTextBox1.Lines.Length
    End Sub
    Private Sub DeselectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeselectAllToolStripMenuItem.Click
        RichTextBox1.DeselectAll()
    End Sub
    Private Sub InvertSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertSelectionToolStripMenuItem.Click
        RichTextBox1.SelectedText = RichTextBox1.Text - RichTextBox1.SelectedText
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Me.Text = OpenFileDialog1.FileName

        Else
            MsgBox("DONT WANT TO OPEN FILE")

        End If
    End Sub
    Private Sub SelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color

        End If
    End Sub
    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        End If
    End Sub
    Private Sub SelectedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub AllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If Me.Text = "New" Then
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                Me.Text = SaveFileDialog1.FileName
            Else
            End If
        Else
            RichTextBox1.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
            MsgBox("CHANGES ARE SAVED ")
        End If
    End Sub
    Private Sub frmNotepadDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim myobj As New Class1
        'Dim str As String = "select * from hitlist"
        'Dim i As Integer = 0
        'For i = 0 To myobj.getrecords(str).Rows.Count - 1
        '    ToolStripComboBox1.Items.Add(myobj.getrecords(str).Rows(i).Item(1).ToString())
        'Next
        Me.Text = "New"
        ' ToolStripStatusLabel1.Text = "Characters :  " & RichTextBox1.TextLength
        'ToolStripStatusLabel1.Text &= " Lines :  " & RichTextBox1.Lines.Length
        'MsgBox(RichTextBox1.TextLength.ToString())

        'RichTextBox1.Clear()
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If Me.Text = "New" Or RichTextBox1.TextLength <> 0 Then
            If MessageBox.Show("DO YOU WANT TO SAVE ", "Demos 2020-21", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    Me.Text = "New"
                    RichTextBox1.Clear()
                Else
                End If
            Else
                RichTextBox1.Clear()
            End If
        Else
            RichTextBox1.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
            RichTextBox1.Clear()
            Me.Text = "New"
        End If

       

    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Me.Text = SaveFileDialog1.FileName
        Else
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
        RichTextBox1.DeselectAll()
    End Sub
    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox1.DeselectAll()
    End Sub
    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
        RichTextBox1.DeselectAll()
    End Sub
    Private Sub BulletToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulletToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionBullet = True
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.ZoomFactor = 5
    End Sub
    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 1
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        RichTextBox1.ZoomFactor = 10
    End Sub
    Private Sub WrapTextToolStripMenuItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrapTextToolStripMenuItem.CheckedChanged
        If WrapTextToolStripMenuItem.Checked = True Then
            RichTextBox1.WordWrap = True
        Else
            RichTextBox1.WordWrap = False
        End If
    End Sub
    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
    End Sub

    Private Sub BUTTONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTONToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        MsgBox("I AM 345")
    End Sub

    Private Sub BACKCOLORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKCOLORToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub frmNotepadDemo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If MessageBox.Show("are YOU sURE", "eXIT", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

   
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        FontDialog1.ShowDialog()

        RichTextBox1.Font = FontDialog1.Font
        RichTextBox1.ForeColor = FontDialog1.Color
    End Sub

    Private Sub NewOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOpenToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)

    End Sub

    
End Class