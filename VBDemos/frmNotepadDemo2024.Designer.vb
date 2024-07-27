<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotepadDemo2024
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PASTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORMATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectiomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CebnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZOOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text Files | *.txt"
        Me.OpenFileDialog1.Title = "FILE KHOLO"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.txt"
        Me.SaveFileDialog1.Filter = "Text Files | *.txt"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.SAVEASToolStripMenuItem, Me.PRINTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(68, 34)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(315, 40)
        Me.NEWToolStripMenuItem.Text = "NEW"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(315, 40)
        Me.OPENToolStripMenuItem.Text = "OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(315, 40)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'SAVEASToolStripMenuItem
        '
        Me.SAVEASToolStripMenuItem.Name = "SAVEASToolStripMenuItem"
        Me.SAVEASToolStripMenuItem.Size = New System.Drawing.Size(315, 40)
        Me.SAVEASToolStripMenuItem.Text = "SAVE AS"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(315, 40)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUTToolStripMenuItem, Me.COPYToolStripMenuItem, Me.PASTEToolStripMenuItem, Me.UNDOToolStripMenuItem, Me.REDOToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(74, 34)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.CUTToolStripMenuItem.Text = "CUT"
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.COPYToolStripMenuItem.Text = "COPY"
        '
        'PASTEToolStripMenuItem
        '
        Me.PASTEToolStripMenuItem.Name = "PASTEToolStripMenuItem"
        Me.PASTEToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.PASTEToolStripMenuItem.Text = "PASTE"
        '
        'UNDOToolStripMenuItem
        '
        Me.UNDOToolStripMenuItem.Name = "UNDOToolStripMenuItem"
        Me.UNDOToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.UNDOToolStripMenuItem.Text = "UNDO"
        '
        'REDOToolStripMenuItem
        '
        Me.REDOToolStripMenuItem.Name = "REDOToolStripMenuItem"
        Me.REDOToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.REDOToolStripMenuItem.Text = "REDO"
        '
        'FORMATToolStripMenuItem
        '
        Me.FORMATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COLORToolStripMenuItem, Me.FONTToolStripMenuItem, Me.AlignmentToolStripMenuItem})
        Me.FORMATToolStripMenuItem.Name = "FORMATToolStripMenuItem"
        Me.FORMATToolStripMenuItem.Size = New System.Drawing.Size(112, 34)
        Me.FORMATToolStripMenuItem.Text = "FORMAT"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectionOnlyToolStripMenuItem, Me.AllToolStripMenuItem})
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(227, 40)
        Me.COLORToolStripMenuItem.Text = "COLOR"
        '
        'SelectionOnlyToolStripMenuItem
        '
        Me.SelectionOnlyToolStripMenuItem.Name = "SelectionOnlyToolStripMenuItem"
        Me.SelectionOnlyToolStripMenuItem.Size = New System.Drawing.Size(264, 40)
        Me.SelectionOnlyToolStripMenuItem.Text = "Selection Only"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(264, 40)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectiomToolStripMenuItem, Me.AllToolStripMenuItem1})
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(227, 40)
        Me.FONTToolStripMenuItem.Text = "FONT"
        '
        'SelectiomToolStripMenuItem
        '
        Me.SelectiomToolStripMenuItem.Name = "SelectiomToolStripMenuItem"
        Me.SelectiomToolStripMenuItem.Size = New System.Drawing.Size(221, 40)
        Me.SelectiomToolStripMenuItem.Text = "Selectiom"
        '
        'AllToolStripMenuItem1
        '
        Me.AllToolStripMenuItem1.Name = "AllToolStripMenuItem1"
        Me.AllToolStripMenuItem1.Size = New System.Drawing.Size(221, 40)
        Me.AllToolStripMenuItem1.Text = "All"
        '
        'AlignmentToolStripMenuItem
        '
        Me.AlignmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftToolStripMenuItem, Me.RightToolStripMenuItem, Me.CebnterToolStripMenuItem})
        Me.AlignmentToolStripMenuItem.Name = "AlignmentToolStripMenuItem"
        Me.AlignmentToolStripMenuItem.Size = New System.Drawing.Size(227, 40)
        Me.AlignmentToolStripMenuItem.Text = "Alignment"
        '
        'LeftToolStripMenuItem
        '
        Me.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        Me.LeftToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.LeftToolStripMenuItem.Text = "Left"
        '
        'RightToolStripMenuItem
        '
        Me.RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        Me.RightToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.RightToolStripMenuItem.Text = "Right"
        '
        'CebnterToolStripMenuItem
        '
        Me.CebnterToolStripMenuItem.Name = "CebnterToolStripMenuItem"
        Me.CebnterToolStripMenuItem.Size = New System.Drawing.Size(192, 40)
        Me.CebnterToolStripMenuItem.Text = "Center"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZOOMToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(75, 34)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ZOOMToolStripMenuItem
        '
        Me.ZOOMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.NormalToolStripMenuItem})
        Me.ZOOMToolStripMenuItem.Name = "ZOOMToolStripMenuItem"
        Me.ZOOMToolStripMenuItem.Size = New System.Drawing.Size(194, 40)
        Me.ZOOMToolStripMenuItem.Text = "ZOOM"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(241, 40)
        Me.ToolStripMenuItem2.Text = "5"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(241, 40)
        Me.ToolStripMenuItem3.Text = "10"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(241, 40)
        Me.NormalToolStripMenuItem.Text = "Normal (1X)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.FORMATToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 42)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 42)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1924, 684)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "HELLO ALL FROM SYBCA DIV 4" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "WE ARE HERE TO LEARN VB.NET" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox1.ZoomFactor = 5.0!
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(208, 30)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 687)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 26, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1924, 39)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowColor = True
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(315, 40)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmNotepadDemo2024
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 726)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmNotepadDemo2024"
        Me.Text = "UNTITLE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PASTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UNDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORMATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectionOnlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectiomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlignmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CebnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZOOMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
