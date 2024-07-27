<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotepad2021
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotepad2021))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTEDFONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Lexend Deca", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(738, 365)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(738, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.OpenDemoToolStripMenuItem, Me.SELECTEDFONTToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'OpenDemoToolStripMenuItem
        '
        Me.OpenDemoToolStripMenuItem.Name = "OpenDemoToolStripMenuItem"
        Me.OpenDemoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenDemoToolStripMenuItem.Text = "open demo"
        '
        'SELECTEDFONTToolStripMenuItem
        '
        Me.SELECTEDFONTToolStripMenuItem.Name = "SELECTEDFONTToolStripMenuItem"
        Me.SELECTEDFONTToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SELECTEDFONTToolStripMenuItem.Text = "SELECTED FONT"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.txt"
        Me.OpenFileDialog1.FileName = "sybca"
        Me.OpenFileDialog1.Filter = "Text Files Only |*.txt"
        Me.OpenFileDialog1.InitialDirectory = "E:\"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.ShowReadOnly = True
        Me.OpenFileDialog1.Title = "SUTEX BCA"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowApply = True
        Me.FontDialog1.ShowColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.Yellow
        Me.ColorDialog1.FullOpen = True
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'frmNotepad2021
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 389)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmNotepad2021"
        Me.Text = "frmNotepad2021"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenDemoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELECTEDFONTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
