<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBoxOperation
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
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemoveAt = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnAddArray = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnSelDeselect = New System.Windows.Forms.Button()
        Me.btnSLAll = New System.Windows.Forms.Button()
        Me.btnSLSingle = New System.Windows.Forms.Button()
        Me.btnSRAll = New System.Windows.Forms.Button()
        Me.btnSRSingle = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Yellow
        Me.btnInsert.Location = New System.Drawing.Point(167, 301)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 31
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Location = New System.Drawing.Point(86, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRemoveAt
        '
        Me.btnRemoveAt.BackColor = System.Drawing.Color.Yellow
        Me.btnRemoveAt.Location = New System.Drawing.Point(248, 272)
        Me.btnRemoveAt.Name = "btnRemoveAt"
        Me.btnRemoveAt.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAt.TabIndex = 29
        Me.btnRemoveAt.Text = "Remove At"
        Me.btnRemoveAt.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Yellow
        Me.btnRemove.Location = New System.Drawing.Point(167, 272)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 28
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd2
        '
        Me.btnAdd2.BackColor = System.Drawing.Color.Yellow
        Me.btnAdd2.Location = New System.Drawing.Point(86, 272)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd2.TabIndex = 27
        Me.btnAdd2.Text = "Add 2"
        Me.btnAdd2.UseVisualStyleBackColor = False
        '
        'btnAddArray
        '
        Me.btnAddArray.Location = New System.Drawing.Point(166, 244)
        Me.btnAddArray.Name = "btnAddArray"
        Me.btnAddArray.Size = New System.Drawing.Size(95, 23)
        Me.btnAddArray.TabIndex = 26
        Me.btnAddArray.Text = "Add Array"
        Me.btnAddArray.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.BackColor = System.Drawing.Color.Yellow
        Me.btnAdd1.Location = New System.Drawing.Point(85, 244)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1.TabIndex = 25
        Me.btnAdd1.Text = "Add 1"
        Me.btnAdd1.UseVisualStyleBackColor = False
        '
        'btnSelDeselect
        '
        Me.btnSelDeselect.BackColor = System.Drawing.Color.Yellow
        Me.btnSelDeselect.Location = New System.Drawing.Point(4, 244)
        Me.btnSelDeselect.Name = "btnSelDeselect"
        Me.btnSelDeselect.Size = New System.Drawing.Size(75, 73)
        Me.btnSelDeselect.TabIndex = 24
        Me.btnSelDeselect.Text = "Select / Deselect All"
        Me.btnSelDeselect.UseVisualStyleBackColor = False
        '
        'btnSLAll
        '
        Me.btnSLAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLAll.Location = New System.Drawing.Point(168, 131)
        Me.btnSLAll.Name = "btnSLAll"
        Me.btnSLAll.Size = New System.Drawing.Size(48, 23)
        Me.btnSLAll.TabIndex = 23
        Me.btnSLAll.Text = "<<"
        Me.btnSLAll.UseVisualStyleBackColor = True
        '
        'btnSLSingle
        '
        Me.btnSLSingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLSingle.Location = New System.Drawing.Point(168, 101)
        Me.btnSLSingle.Name = "btnSLSingle"
        Me.btnSLSingle.Size = New System.Drawing.Size(48, 23)
        Me.btnSLSingle.TabIndex = 22
        Me.btnSLSingle.Text = "<"
        Me.btnSLSingle.UseVisualStyleBackColor = True
        '
        'btnSRAll
        '
        Me.btnSRAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSRAll.Location = New System.Drawing.Point(168, 72)
        Me.btnSRAll.Name = "btnSRAll"
        Me.btnSRAll.Size = New System.Drawing.Size(48, 23)
        Me.btnSRAll.TabIndex = 21
        Me.btnSRAll.Text = ">>"
        Me.btnSRAll.UseVisualStyleBackColor = True
        '
        'btnSRSingle
        '
        Me.btnSRSingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSRSingle.Location = New System.Drawing.Point(168, 43)
        Me.btnSRSingle.Name = "btnSRSingle"
        Me.btnSRSingle.Size = New System.Drawing.Size(48, 23)
        Me.btnSRSingle.TabIndex = 20
        Me.btnSRSingle.Text = ">"
        Me.btnSRSingle.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(237, 7)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(121, 199)
        Me.ListBox2.TabIndex = 19
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H"})
        Me.ListBox1.Location = New System.Drawing.Point(17, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(122, 199)
        Me.ListBox1.TabIndex = 18
        '
        'frmListBoxOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 330)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemoveAt)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.btnAddArray)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.btnSelDeselect)
        Me.Controls.Add(Me.btnSLAll)
        Me.Controls.Add(Me.btnSLSingle)
        Me.Controls.Add(Me.btnSRAll)
        Me.Controls.Add(Me.btnSRSingle)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmListBoxOperation"
        Me.Text = "frmListBoxOperation"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAt As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd2 As System.Windows.Forms.Button
    Friend WithEvents btnAddArray As System.Windows.Forms.Button
    Friend WithEvents btnAdd1 As System.Windows.Forms.Button
    Friend WithEvents btnSelDeselect As System.Windows.Forms.Button
    Friend WithEvents btnSLAll As System.Windows.Forms.Button
    Friend WithEvents btnSLSingle As System.Windows.Forms.Button
    Friend WithEvents btnSRAll As System.Windows.Forms.Button
    Friend WithEvents btnSRSingle As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
