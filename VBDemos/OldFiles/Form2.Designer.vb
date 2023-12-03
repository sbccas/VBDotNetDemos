<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo1 = New System.Windows.Forms.TextBox()
        Me.txtNo2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No 2:"
        '
        'txtNo1
        '
        Me.txtNo1.Location = New System.Drawing.Point(186, 32)
        Me.txtNo1.Name = "txtNo1"
        Me.txtNo1.Size = New System.Drawing.Size(100, 20)
        Me.txtNo1.TabIndex = 2
        '
        'txtNo2
        '
        Me.txtNo2.Location = New System.Drawing.Point(186, 74)
        Me.txtNo2.Name = "txtNo2"
        Me.txtNo2.Size = New System.Drawing.Size(100, 20)
        Me.txtNo2.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(186, 106)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(206, 143)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(66, 13)
        Me.lblAns.TabIndex = 5
        Me.lblAns.Text = "Your Ans IS:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 262)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNo2)
        Me.Controls.Add(Me.txtNo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNo2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblAns As System.Windows.Forms.Label
End Class
