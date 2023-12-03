<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnShowdate = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowdate
        '
        Me.btnShowdate.Location = New System.Drawing.Point(15, 3)
        Me.btnShowdate.Name = "btnShowdate"
        Me.btnShowdate.Size = New System.Drawing.Size(75, 23)
        Me.btnShowdate.TabIndex = 0
        Me.btnShowdate.Text = "Show Date"
        Me.btnShowdate.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(30, 43)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "------------"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnShowdate)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(116, 79)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowdate As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label

End Class
