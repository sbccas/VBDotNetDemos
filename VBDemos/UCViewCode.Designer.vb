<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewCode
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
        Me.components = New System.ComponentModel.Container()
        Me.CMSViewCode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSViewCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMSViewCode
        '
        Me.CMSViewCode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCodeToolStripMenuItem})
        Me.CMSViewCode.Name = "CMSViewCode"
        Me.CMSViewCode.Size = New System.Drawing.Size(131, 26)
        '
        'ViewCodeToolStripMenuItem
        '
        Me.ViewCodeToolStripMenuItem.Name = "ViewCodeToolStripMenuItem"
        Me.ViewCodeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewCodeToolStripMenuItem.Text = "View Code"
        '
        'UCViewCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me.CMSViewCode
        Me.Name = "UCViewCode"
        Me.Size = New System.Drawing.Size(215, 148)
        Me.CMSViewCode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMSViewCode As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
