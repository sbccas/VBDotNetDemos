<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVBDefaultsOptionStatements
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
        Me.btnOptionExplicit = New System.Windows.Forms.Button()
        Me.btnOPtStrict = New System.Windows.Forms.Button()
        Me.btnOptCompare = New System.Windows.Forms.Button()
        Me.btnOptInfere = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOptionExplicit
        '
        Me.btnOptionExplicit.Location = New System.Drawing.Point(47, 29)
        Me.btnOptionExplicit.Name = "btnOptionExplicit"
        Me.btnOptionExplicit.Size = New System.Drawing.Size(131, 23)
        Me.btnOptionExplicit.TabIndex = 0
        Me.btnOptionExplicit.Text = "Option Explict"
        Me.btnOptionExplicit.UseVisualStyleBackColor = True
        '
        'btnOPtStrict
        '
        Me.btnOPtStrict.Location = New System.Drawing.Point(47, 58)
        Me.btnOPtStrict.Name = "btnOPtStrict"
        Me.btnOPtStrict.Size = New System.Drawing.Size(131, 23)
        Me.btnOPtStrict.TabIndex = 1
        Me.btnOPtStrict.Text = "Option Strict"
        Me.btnOPtStrict.UseVisualStyleBackColor = True
        '
        'btnOptCompare
        '
        Me.btnOptCompare.Location = New System.Drawing.Point(47, 87)
        Me.btnOptCompare.Name = "btnOptCompare"
        Me.btnOptCompare.Size = New System.Drawing.Size(131, 23)
        Me.btnOptCompare.TabIndex = 2
        Me.btnOptCompare.Text = "Option Compare"
        Me.btnOptCompare.UseVisualStyleBackColor = True
        '
        'btnOptInfere
        '
        Me.btnOptInfere.Location = New System.Drawing.Point(47, 120)
        Me.btnOptInfere.Name = "btnOptInfere"
        Me.btnOptInfere.Size = New System.Drawing.Size(131, 23)
        Me.btnOptInfere.TabIndex = 3
        Me.btnOptInfere.Text = "Option Infer"
        Me.btnOptInfere.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "BOXING"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(47, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "UN BOXING"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmVBDefaultsOptionStatements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOptInfere)
        Me.Controls.Add(Me.btnOptCompare)
        Me.Controls.Add(Me.btnOPtStrict)
        Me.Controls.Add(Me.btnOptionExplicit)
        Me.Name = "frmVBDefaultsOptionStatements"
        Me.Text = "frmVBDefaultsOptionStatements"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOptionExplicit As System.Windows.Forms.Button
    Friend WithEvents btnOPtStrict As System.Windows.Forms.Button
    Friend WithEvents btnOptCompare As System.Windows.Forms.Button
    Friend WithEvents btnOptInfere As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
