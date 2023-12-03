<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBoxPart2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnSRSingle = New System.Windows.Forms.Button()
        Me.btnSRAll = New System.Windows.Forms.Button()
        Me.btnSLSingle = New System.Windows.Forms.Button()
        Me.btnSLAll = New System.Windows.Forms.Button()
        Me.btnSelDeselect = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemoveAt = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H"})
        Me.ListBox1.Location = New System.Drawing.Point(25, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(122, 199)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(248, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(121, 199)
        Me.ListBox2.TabIndex = 2
        '
        'btnSRSingle
        '
        Me.btnSRSingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSRSingle.Location = New System.Drawing.Point(176, 48)
        Me.btnSRSingle.Name = "btnSRSingle"
        Me.btnSRSingle.Size = New System.Drawing.Size(48, 23)
        Me.btnSRSingle.TabIndex = 3
        Me.btnSRSingle.Text = ">"
        Me.btnSRSingle.UseVisualStyleBackColor = True
        '
        'btnSRAll
        '
        Me.btnSRAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSRAll.Location = New System.Drawing.Point(176, 77)
        Me.btnSRAll.Name = "btnSRAll"
        Me.btnSRAll.Size = New System.Drawing.Size(48, 23)
        Me.btnSRAll.TabIndex = 4
        Me.btnSRAll.Text = ">>"
        Me.btnSRAll.UseVisualStyleBackColor = True
        '
        'btnSLSingle
        '
        Me.btnSLSingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLSingle.Location = New System.Drawing.Point(176, 106)
        Me.btnSLSingle.Name = "btnSLSingle"
        Me.btnSLSingle.Size = New System.Drawing.Size(48, 23)
        Me.btnSLSingle.TabIndex = 5
        Me.btnSLSingle.Text = "<"
        Me.btnSLSingle.UseVisualStyleBackColor = True
        '
        'btnSLAll
        '
        Me.btnSLAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLAll.Location = New System.Drawing.Point(176, 136)
        Me.btnSLAll.Name = "btnSLAll"
        Me.btnSLAll.Size = New System.Drawing.Size(48, 23)
        Me.btnSLAll.TabIndex = 6
        Me.btnSLAll.Text = "<<"
        Me.btnSLAll.UseVisualStyleBackColor = True
        '
        'btnSelDeselect
        '
        Me.btnSelDeselect.Location = New System.Drawing.Point(12, 249)
        Me.btnSelDeselect.Name = "btnSelDeselect"
        Me.btnSelDeselect.Size = New System.Drawing.Size(75, 73)
        Me.btnSelDeselect.TabIndex = 7
        Me.btnSelDeselect.Text = "Select / Deselect All"
        Me.btnSelDeselect.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Add Array"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(175, 306)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 17
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(94, 306)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemoveAt
        '
        Me.btnRemoveAt.Location = New System.Drawing.Point(256, 277)
        Me.btnRemoveAt.Name = "btnRemoveAt"
        Me.btnRemoveAt.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAt.TabIndex = 15
        Me.btnRemoveAt.Text = "Remove At"
        Me.btnRemoveAt.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(175, 277)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(94, 277)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Add"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'frmListBoxPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 334)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemoveAt)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSelDeselect)
        Me.Controls.Add(Me.btnSLAll)
        Me.Controls.Add(Me.btnSLSingle)
        Me.Controls.Add(Me.btnSRAll)
        Me.Controls.Add(Me.btnSRSingle)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmListBoxPart2"
        Me.Text = "frmListBoxPart2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnSRSingle As System.Windows.Forms.Button
    Friend WithEvents btnSRAll As System.Windows.Forms.Button
    Friend WithEvents btnSLSingle As System.Windows.Forms.Button
    Friend WithEvents btnSLAll As System.Windows.Forms.Button
    Friend WithEvents btnSelDeselect As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAt As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
