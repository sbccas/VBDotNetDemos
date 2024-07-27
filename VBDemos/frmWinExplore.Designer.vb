<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinExplore
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
        Me.components = New System.ComponentModel.Container()
        Me.lvFiles = New System.Windows.Forms.ListView()
        Me.cmClipboardOp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.iIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.trvFolders = New System.Windows.Forms.TreeView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboView = New System.Windows.Forms.ComboBox()
        Me.cmClipboardOp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvFiles
        '
        Me.lvFiles.ContextMenuStrip = Me.cmClipboardOp
        Me.lvFiles.Location = New System.Drawing.Point(290, 28)
        Me.lvFiles.Name = "lvFiles"
        Me.lvFiles.Size = New System.Drawing.Size(421, 254)
        Me.lvFiles.SmallImageList = Me.iIconList
        Me.lvFiles.TabIndex = 4
        Me.lvFiles.UseCompatibleStateImageBehavior = False
        '
        'cmClipboardOp
        '
        Me.cmClipboardOp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.cmClipboardOp.Name = "cmClipboardOp"
        Me.cmClipboardOp.Size = New System.Drawing.Size(113, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'iIconList
        '
        Me.iIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iIconList.ImageSize = New System.Drawing.Size(16, 16)
        Me.iIconList.TransparentColor = System.Drawing.Color.Transparent
        '
        'trvFolders
        '
        Me.trvFolders.ContextMenuStrip = Me.cmClipboardOp
        Me.trvFolders.Location = New System.Drawing.Point(12, 28)
        Me.trvFolders.Name = "trvFolders"
        Me.trvFolders.Size = New System.Drawing.Size(235, 254)
        Me.trvFolders.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(636, 290)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboView
        '
        Me.cboView.FormattingEnabled = True
        Me.cboView.Items.AddRange(New Object() {"Large Icon", "Details", "Small Icon", "List", "Tile"})
        Me.cboView.Location = New System.Drawing.Point(290, 292)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(121, 21)
        Me.cboView.TabIndex = 7
        '
        'frmWinExplore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 325)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboView)
        Me.Controls.Add(Me.lvFiles)
        Me.Controls.Add(Me.trvFolders)
        Me.Name = "frmWinExplore"
        Me.Text = "VB Windows Explorer"
        Me.cmClipboardOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvFiles As System.Windows.Forms.ListView
    Friend WithEvents trvFolders As System.Windows.Forms.TreeView
    Friend WithEvents iIconList As System.Windows.Forms.ImageList
    Friend WithEvents cmClipboardOp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cboView As System.Windows.Forms.ComboBox

End Class
