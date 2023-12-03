<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewWindowsExplorer
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewWindowsExplorer))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageListLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(845, 439)
        Me.SplitContainer1.SplitterDistance = 281
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageListSmall
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 7
        TreeNode1.Name = "Node7"
        TreeNode1.Text = "Node7"
        TreeNode2.Name = "Node13"
        TreeNode2.Text = "Node13"
        TreeNode3.Name = "Node14"
        TreeNode3.Text = "Node14"
        TreeNode4.Name = "Node15"
        TreeNode4.Text = "Node15"
        TreeNode5.ImageIndex = 8
        TreeNode5.Name = "Node8"
        TreeNode5.Text = "Node8"
        TreeNode6.Name = "Node9"
        TreeNode6.Text = "Node9"
        TreeNode7.Name = "Node10"
        TreeNode7.Text = "Node10"
        TreeNode8.Name = "Node11"
        TreeNode8.Text = "Node11"
        TreeNode9.Name = "Node12"
        TreeNode9.Text = "Node12"
        TreeNode10.ImageIndex = 0
        TreeNode10.Name = "Node0"
        TreeNode10.Text = "Node0"
        TreeNode11.ImageIndex = 1
        TreeNode11.Name = "Node1"
        TreeNode11.Text = "Node1"
        TreeNode12.ImageIndex = 2
        TreeNode12.Name = "Node2"
        TreeNode12.Text = "Node2"
        TreeNode13.ImageIndex = 3
        TreeNode13.Name = "Node3"
        TreeNode13.Text = "Node3"
        TreeNode14.Name = "Node4"
        TreeNode14.Text = "Node4"
        TreeNode15.Name = "Node5"
        TreeNode15.Text = "Node5"
        TreeNode16.Name = "Node6"
        TreeNode16.Text = "Node6"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(281, 439)
        Me.TreeView1.TabIndex = 0
        '
        'ImageListLarge
        '
        Me.ImageListLarge.ImageStream = CType(resources.GetObject("ImageListLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListLarge.Images.SetKeyName(0, "IMG_8359.JPG")
        Me.ImageListLarge.Images.SetKeyName(1, "IMG_8360.JPG")
        Me.ImageListLarge.Images.SetKeyName(2, "IMG_8361.JPG")
        Me.ImageListLarge.Images.SetKeyName(3, "IMG_8362.JPG")
        Me.ImageListLarge.Images.SetKeyName(4, "IMG_8363.JPG")
        Me.ImageListLarge.Images.SetKeyName(5, "IMG_8364.JPG")
        Me.ImageListLarge.Images.SetKeyName(6, "IMG_8365.JPG")
        Me.ImageListLarge.Images.SetKeyName(7, "IMG_8366.JPG")
        Me.ImageListLarge.Images.SetKeyName(8, "IMG_8367.JPG")
        Me.ImageListLarge.Images.SetKeyName(9, "IMG_8368.JPG")
        Me.ImageListLarge.Images.SetKeyName(10, "IMG_8369.JPG")
        '
        'ImageListSmall
        '
        Me.ImageListSmall.ImageStream = CType(resources.GetObject("ImageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListSmall.Images.SetKeyName(0, "IMG_8359.JPG")
        Me.ImageListSmall.Images.SetKeyName(1, "IMG_8360.JPG")
        Me.ImageListSmall.Images.SetKeyName(2, "IMG_8361.JPG")
        Me.ImageListSmall.Images.SetKeyName(3, "IMG_8362.JPG")
        Me.ImageListSmall.Images.SetKeyName(4, "IMG_8363.JPG")
        Me.ImageListSmall.Images.SetKeyName(5, "IMG_8364.JPG")
        Me.ImageListSmall.Images.SetKeyName(6, "IMG_8365.JPG")
        Me.ImageListSmall.Images.SetKeyName(7, "IMG_8366.JPG")
        Me.ImageListSmall.Images.SetKeyName(8, "IMG_8367.JPG")
        Me.ImageListSmall.Images.SetKeyName(9, "IMG_8368.JPG")
        Me.ImageListSmall.Images.SetKeyName(10, "IMG_8369.JPG")
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(560, 439)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmNewWindowsExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 439)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmNewWindowsExplorer"
        Me.Text = "frmNewWindowsExplorer"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents ImageListLarge As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
