﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBoxDemo
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
        Me.btnForloop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "InputBox Demo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnForloop
        '
        Me.btnForloop.Location = New System.Drawing.Point(25, 75)
        Me.btnForloop.Name = "btnForloop"
        Me.btnForloop.Size = New System.Drawing.Size(167, 23)
        Me.btnForloop.TabIndex = 1
        Me.btnForloop.Text = "FOR LOOP DEMO"
        Me.btnForloop.UseVisualStyleBackColor = True
        '
        'frmInputBoxDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 138)
        Me.Controls.Add(Me.btnForloop)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmInputBoxDemo"
        Me.Text = "frmInputBoxDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnForloop As Button
End Class
