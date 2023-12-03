<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExceptionDemo
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
        Me.btnErrObject = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnThrow = New System.Windows.Forms.Button()
        Me.btnmyObj = New System.Windows.Forms.Button()
        Me.btnErr2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnErrObject
        '
        Me.btnErrObject.Location = New System.Drawing.Point(41, 37)
        Me.btnErrObject.Name = "btnErrObject"
        Me.btnErrObject.Size = New System.Drawing.Size(75, 23)
        Me.btnErrObject.TabIndex = 0
        Me.btnErrObject.Text = "Err Raise"
        Me.btnErrObject.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 100)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(726, 266)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Structure Exe "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnThrow
        '
        Me.btnThrow.Location = New System.Drawing.Point(379, 32)
        Me.btnThrow.Name = "btnThrow"
        Me.btnThrow.Size = New System.Drawing.Size(133, 23)
        Me.btnThrow.TabIndex = 4
        Me.btnThrow.Text = "Throw Exec"
        Me.btnThrow.UseVisualStyleBackColor = True
        '
        'btnmyObj
        '
        Me.btnmyObj.Location = New System.Drawing.Point(518, 32)
        Me.btnmyObj.Name = "btnmyObj"
        Me.btnmyObj.Size = New System.Drawing.Size(133, 23)
        Me.btnmyObj.TabIndex = 5
        Me.btnmyObj.Text = "My Class Obj"
        Me.btnmyObj.UseVisualStyleBackColor = True
        '
        'btnErr2
        '
        Me.btnErr2.Location = New System.Drawing.Point(41, 66)
        Me.btnErr2.Name = "btnErr2"
        Me.btnErr2.Size = New System.Drawing.Size(75, 23)
        Me.btnErr2.TabIndex = 6
        Me.btnErr2.Text = "Err Raise2"
        Me.btnErr2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Get Records"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(60, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(613, 175)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.TabStop = False
        Me.DataGridView1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"hitlist", "dept", "studinfo", "employee", "product", "AttendanceMaster1", "subjectMaster"})
        Me.ComboBox1.Location = New System.Drawing.Point(205, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(379, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Nilesh Property"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmExceptionDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 366)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnErr2)
        Me.Controls.Add(Me.btnmyObj)
        Me.Controls.Add(Me.btnThrow)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnErrObject)
        Me.Name = "frmExceptionDemo"
        Me.Text = "frmExceptionDemo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnErrObject As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnThrow As System.Windows.Forms.Button
    Friend WithEvents btnmyObj As System.Windows.Forms.Button
    Friend WithEvents btnErr2 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
