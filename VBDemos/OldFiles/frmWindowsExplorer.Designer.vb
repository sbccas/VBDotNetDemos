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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SY1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SY2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C Drive", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("D Drive")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("E Drive")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("F Drive")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("H Drive")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MY PC", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWindowsExplorer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ilLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ilSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 34)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 324)
        Me.Panel2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ilLarge
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "Node6"
        TreeNode1.Text = "SY1"
        TreeNode2.ImageIndex = 3
        TreeNode2.Name = "Node7"
        TreeNode2.Text = "SY2"
        TreeNode3.ImageIndex = 1
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "C Drive"
        TreeNode4.ImageIndex = 4
        TreeNode4.Name = "Node2"
        TreeNode4.Text = "D Drive"
        TreeNode5.ImageIndex = 5
        TreeNode5.Name = "Node3"
        TreeNode5.Text = "E Drive"
        TreeNode6.ImageIndex = 7
        TreeNode6.Name = "Node4"
        TreeNode6.Text = "F Drive"
        TreeNode7.Name = "Node5"
        TreeNode7.Text = "H Drive"
        TreeNode8.Name = "Node0"
        TreeNode8.Text = "MY PC"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(190, 324)
        Me.TreeView1.TabIndex = 1
        '
        'ilLarge
        '
        Me.ilLarge.ImageStream = CType(resources.GetObject("ilLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLarge.Images.SetKeyName(0, "Chrysanthemum - Copy.jpg")
        Me.ilLarge.Images.SetKeyName(1, "Desert.jpg")
        Me.ilLarge.Images.SetKeyName(2, "Koala.jpg")
        Me.ilLarge.Images.SetKeyName(3, "Penguins.jpg")
        Me.ilLarge.Images.SetKeyName(4, "Jellyfish.jpg")
        Me.ilLarge.Images.SetKeyName(5, "Tulips.jpg")
        Me.ilLarge.Images.SetKeyName(6, "Hydrangeas.jpg")
        Me.ilLarge.Images.SetKeyName(7, "Lighthouse.jpg")
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.ListView1)
        Me.Panel3.Location = New System.Drawing.Point(196, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(560, 324)
        Me.Panel3.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(560, 324)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 370)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(756, 21)
        Me.Panel4.TabIndex = 1
        '
        'ilSmall
        '
        Me.ilSmall.ImageStream = CType(resources.GetObject("ilSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSmall.Images.SetKeyName(0, "Chrysanthemum - Copy.jpg")
        Me.ilSmall.Images.SetKeyName(1, "Chrysanthemum.jpg")
        Me.ilSmall.Images.SetKeyName(2, "Desert.jpg")
        Me.ilSmall.Images.SetKeyName(3, "Koala.jpg")
        Me.ilSmall.Images.SetKeyName(4, "Penguins.jpg")
        Me.ilSmall.Images.SetKeyName(5, "Jellyfish.jpg")
        Me.ilSmall.Images.SetKeyName(6, "Tulips.jpg")
        Me.ilSmall.Images.SetKeyName(7, "Hydrangeas.jpg")
        Me.ilSmall.Images.SetKeyName(8, "Lighthouse.jpg")
        '
        'frmWindowsExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 391)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmWindowsExplorer"
        Me.Text = "frmWindowsExplorer"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ilLarge As System.Windows.Forms.ImageList
    Friend WithEvents ilSmall As System.Windows.Forms.ImageList
End Class
