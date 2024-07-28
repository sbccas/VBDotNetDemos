<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWindowsExplorer
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
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ABC")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BCD")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C:", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sutex")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("D:", New System.Windows.Forms.TreeNode() {TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SYBCA3")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SYBCA4", 13, 11)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("E:", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15})
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Abc.txt", "1 TB", "TEXT FILE"}, 0)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"sutex.jpg", "2 MB", "GIF"}, 1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sybca3.mp3", "5 Mb", "GOOD CLASS", "SLEEPING MUCH"}, 2)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sybca4.mp4", "10MB"}, 4)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWindowsExplorer))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ilstSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.ilstlarge = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LargeIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HiToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 48)
        '
        'HiToolStripMenuItem
        '
        Me.HiToolStripMenuItem.Name = "HiToolStripMenuItem"
        Me.HiToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.HiToolStripMenuItem.Text = "Hi"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'TreeView1
        '
        Me.TreeView1.HotTracking = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(12, 31)
        Me.TreeView1.Name = "TreeView1"
        TreeNode9.ImageIndex = 2
        TreeNode9.Name = "Node1"
        TreeNode9.Text = "ABC"
        TreeNode10.ImageIndex = 2
        TreeNode10.Name = "Node2"
        TreeNode10.Text = "BCD"
        TreeNode11.ImageKey = "drive.ico"
        TreeNode11.Name = "Node0"
        TreeNode11.Text = "C:"
        TreeNode12.ContextMenuStrip = Me.ContextMenuStrip1
        TreeNode12.ImageKey = "IMG_0714.JPG"
        TreeNode12.Name = "Node4"
        TreeNode12.Text = "Sutex"
        TreeNode13.ImageIndex = 3
        TreeNode13.Name = "Node3"
        TreeNode13.Text = "D:"
        TreeNode14.Name = "Node1"
        TreeNode14.Text = "SYBCA3"
        TreeNode14.ToolTipText = "Demo of Tool Tip"
        TreeNode15.ImageIndex = 13
        TreeNode15.Name = "Node0"
        TreeNode15.SelectedImageIndex = 11
        TreeNode15.Text = "SYBCA4"
        TreeNode16.Name = "Node0"
        TreeNode16.Text = "E:"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode13, TreeNode16})
        Me.TreeView1.SelectedImageIndex = 19
        Me.TreeView1.Size = New System.Drawing.Size(163, 340)
        Me.TreeView1.TabIndex = 0
        '
        'ilstSmall
        '
        Me.ilstSmall.ImageStream = CType(resources.GetObject("ilstSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilstSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.ilstSmall.Images.SetKeyName(0, "docs.ico")
        Me.ilstSmall.Images.SetKeyName(1, "drive.ico")
        Me.ilstSmall.Images.SetKeyName(2, "folder-win10.ico")
        Me.ilstSmall.Images.SetKeyName(3, "folder-winseven.ico")
        Me.ilstSmall.Images.SetKeyName(4, "folder-winxp.ico")
        Me.ilstSmall.Images.SetKeyName(5, "gdoc.ico")
        Me.ilstSmall.Images.SetKeyName(6, "gdraw.ico")
        Me.ilstSmall.Images.SetKeyName(7, "gform.ico")
        Me.ilstSmall.Images.SetKeyName(8, "gjam.ico")
        Me.ilstSmall.Images.SetKeyName(9, "glink.ico")
        Me.ilstSmall.Images.SetKeyName(10, "gmap.ico")
        Me.ilstSmall.Images.SetKeyName(11, "gnote.ico")
        Me.ilstSmall.Images.SetKeyName(12, "gscript.ico")
        Me.ilstSmall.Images.SetKeyName(13, "gsheet.ico")
        Me.ilstSmall.Images.SetKeyName(14, "gsite.ico")
        Me.ilstSmall.Images.SetKeyName(15, "gslides.ico")
        Me.ilstSmall.Images.SetKeyName(16, "gtable.ico")
        Me.ilstSmall.Images.SetKeyName(17, "sharedfolder-win10.ico")
        Me.ilstSmall.Images.SetKeyName(18, "sharedfolder-winseven.ico")
        Me.ilstSmall.Images.SetKeyName(19, "sharedfolder-winxp.ico")
        '
        'ilstlarge
        '
        Me.ilstlarge.ImageStream = CType(resources.GetObject("ilstlarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilstlarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilstlarge.Images.SetKeyName(0, "docs.ico")
        Me.ilstlarge.Images.SetKeyName(1, "drive.ico")
        Me.ilstlarge.Images.SetKeyName(2, "folder-win10.ico")
        Me.ilstlarge.Images.SetKeyName(3, "folder-winseven.ico")
        Me.ilstlarge.Images.SetKeyName(4, "folder-winxp.ico")
        Me.ilstlarge.Images.SetKeyName(5, "gdoc.ico")
        Me.ilstlarge.Images.SetKeyName(6, "gdraw.ico")
        Me.ilstlarge.Images.SetKeyName(7, "gform.ico")
        Me.ilstlarge.Images.SetKeyName(8, "gjam.ico")
        Me.ilstlarge.Images.SetKeyName(9, "glink.ico")
        Me.ilstlarge.Images.SetKeyName(10, "gmap.ico")
        Me.ilstlarge.Images.SetKeyName(11, "gnote.ico")
        Me.ilstlarge.Images.SetKeyName(12, "gscript.ico")
        Me.ilstlarge.Images.SetKeyName(13, "gsheet.ico")
        Me.ilstlarge.Images.SetKeyName(14, "gsite.ico")
        Me.ilstlarge.Images.SetKeyName(15, "gslides.ico")
        Me.ilstlarge.Images.SetKeyName(16, "gtable.ico")
        Me.ilstlarge.Images.SetKeyName(17, "sharedfolder-win10.ico")
        Me.ilstlarge.Images.SetKeyName(18, "sharedfolder-winseven.ico")
        Me.ilstlarge.Images.SetKeyName(19, "sharedfolder-winxp.ico")
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip2
        ListViewGroup3.Header = "ListViewGroup"
        ListViewGroup3.Name = "Size Group"
        ListViewGroup4.Header = "ListViewGroup"
        ListViewGroup4.Name = "Name Group"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup3, ListViewGroup4})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView1.LargeImageList = Me.ilstlarge
        Me.ListView1.Location = New System.Drawing.Point(218, 31)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(407, 340)
        Me.ListView1.SmallImageList = Me.ilstSmall
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 125
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FILE TYPE"
        Me.ColumnHeader3.Width = 82
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeIconToolStripMenuItem, Me.SmallIconToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.TileToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(130, 114)
        '
        'LargeIconToolStripMenuItem
        '
        Me.LargeIconToolStripMenuItem.Name = "LargeIconToolStripMenuItem"
        Me.LargeIconToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LargeIconToolStripMenuItem.Text = "Large Icon"
        '
        'SmallIconToolStripMenuItem
        '
        Me.SmallIconToolStripMenuItem.Name = "SmallIconToolStripMenuItem"
        Me.SmallIconToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SmallIconToolStripMenuItem.Text = "Small Icon"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.TileToolStripMenuItem.Text = "Tile"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "_20180706_222052.jpg")
        Me.ImageList1.Images.SetKeyName(1, "_20180710_101544.JPG")
        Me.ImageList1.Images.SetKeyName(2, "‪+91 97261 43288‬ 20180706_100056.jpg")
        Me.ImageList1.Images.SetKeyName(3, "‪+91 99097 54537‬ 20180706_095215.jpg")
        Me.ImageList1.Images.SetKeyName(4, "001.jpg")
        Me.ImageList1.Images.SetKeyName(5, "36E0CA3C-5804-4369-9A60-9BADD8E1E551.jpeg")
        Me.ImageList1.Images.SetKeyName(6, "81E258DD-E75D-4BBB-825E-FFE010D2E173.jpeg")
        Me.ImageList1.Images.SetKeyName(7, "87BC5BC8-48E0-43AC-921E-47E99C364731.jpeg")
        Me.ImageList1.Images.SetKeyName(8, "00100sPORTRAIT_00100_BURST20180415175544284_COVER.jpg")
        Me.ImageList1.Images.SetKeyName(9, "00100sPORTRAIT_00100_BURST20180428111947051_COVER.jpg")
        Me.ImageList1.Images.SetKeyName(10, "494A10F5-F8B2-45E5-A213-68E30FB720E0.jpeg")
        Me.ImageList1.Images.SetKeyName(11, "2018-03-21-16-17-23-573-1.jpg")
        Me.ImageList1.Images.SetKeyName(12, "2018-04-20-19-18-30-773.jpg")
        Me.ImageList1.Images.SetKeyName(13, "7606f6e8b381cbd3959b60672ce4ec5f.jpg")
        Me.ImageList1.Images.SetKeyName(14, "18072DC0-747A-4644-BA63-EE8B784430A5.jpeg")
        Me.ImageList1.Images.SetKeyName(15, "1526506_1723224517901972_6690456568686204967_n.jpg")
        Me.ImageList1.Images.SetKeyName(16, "20180320_204019.jpg")
        Me.ImageList1.Images.SetKeyName(17, "20180604_121214.jpg")
        Me.ImageList1.Images.SetKeyName(18, "20180710_114039.jpg")
        Me.ImageList1.Images.SetKeyName(19, "20180816_110655.png")
        Me.ImageList1.Images.SetKeyName(20, "1531412537117189853992.jpg")
        Me.ImageList1.Images.SetKeyName(21, "BABED307-5D02-4CAD-94FF-7FE36E5F3975 - Copy.jpeg")
        Me.ImageList1.Images.SetKeyName(22, "BABED307-5D02-4CAD-94FF-7FE36E5F3975.jpg")
        Me.ImageList1.Images.SetKeyName(23, "BeautyPlus_20180522104720_save.jpg")
        Me.ImageList1.Images.SetKeyName(24, "BeautyPlus_20180815124325418_save.jpg")
        Me.ImageList1.Images.SetKeyName(25, "c55f886d-280a-4422-a799-aedd590b0771.jpg")
        Me.ImageList1.Images.SetKeyName(26, "C360_2017-08-07-20-34-39-154.jpg")
        Me.ImageList1.Images.SetKeyName(27, "D8D3E007-305E-4312-AD71-6A6B704689C1.jpeg")
        Me.ImageList1.Images.SetKeyName(28, "DFD4ECED-E8F3-4AED-8387-6EA8D9B07F28.jpeg")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(371, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATE MODIFIED"
        Me.ColumnHeader4.Width = 117
        '
        'frmWindowsExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 383)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWindowsExplorer"
        Me.Text = "Sutex Windows Explorer®"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ilstSmall As System.Windows.Forms.ImageList
    Friend WithEvents ilstlarge As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LargeIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
