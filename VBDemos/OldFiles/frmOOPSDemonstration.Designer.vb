<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOOPSDemonstration
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Design Polymorphism"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Design Polymorphism 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(220, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 55)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Inheritance of Nilesh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(324, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 55)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Abstract Demo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(428, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 55)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Overridable"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 59)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Default Constructor Demo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(116, 89)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 59)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Parameterized Constructor Demo"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(220, 89)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 59)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Destructor"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(324, 89)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 59)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Interface Demo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 159)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SYBCA1"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(98, 55)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Inheritance of Vivek"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(110, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(98, 55)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "Abstract Demo"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(214, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(98, 55)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "Overriding"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'frmOOPSDemonstration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmOOPSDemonstration"
        Me.Text = "frmOOPSDemonstration"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
End Class
