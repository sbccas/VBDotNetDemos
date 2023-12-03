<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExceptionHandlingDemo
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
        Me.btnonError = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.UserControl11 = New VBDemos.UserControl1()
        Me.btnsybca3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnonError
        '
        Me.btnonError.Location = New System.Drawing.Point(12, 12)
        Me.btnonError.Name = "btnonError"
        Me.btnonError.Size = New System.Drawing.Size(75, 23)
        Me.btnonError.TabIndex = 0
        Me.btnonError.Text = "On Error"
        Me.btnonError.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ERR Object"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "RESUME NEXT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "GOTO ZERO      ( () )"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(26, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 62)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "TOTAL ERROR LIST"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(107, 119)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 62)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "STRUCTURED EXCEPTION "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(203, 14)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(524, 336)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(26, 187)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 62)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "CRICKET EXCEPTION"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 255)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(8, 284)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UserControl11.Location = New System.Drawing.Point(414, 146)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(116, 79)
        Me.UserControl11.TabIndex = 11
        '
        'btnsybca3
        '
        Me.btnsybca3.Location = New System.Drawing.Point(12, 327)
        Me.btnsybca3.Name = "btnsybca3"
        Me.btnsybca3.Size = New System.Drawing.Size(144, 23)
        Me.btnsybca3.TabIndex = 12
        Me.btnsybca3.Text = "SYBCA 3 2020"
        Me.btnsybca3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(93, 284)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 23)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Unstructured"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'frmExceptionHandlingDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 362)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.btnsybca3)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnonError)
        Me.Name = "frmExceptionHandlingDemo"
        Me.Text = "frmExceptionHandlingDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnonError As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents UserControl11 As VBDemos.UserControl1
    Friend WithEvents btnsybca3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
