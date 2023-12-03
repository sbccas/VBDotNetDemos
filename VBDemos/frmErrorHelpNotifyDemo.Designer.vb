<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorHelpNotifyDemo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErrorHelpNotifyDemo))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KEVALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = ""
        '
        'Button3
        '
        Me.HelpProvider1.SetHelpKeyword(Me.Button3, "Sample Help TExt")
        Me.Button3.Location = New System.Drawing.Point(260, 63)
        Me.Button3.Name = "Button3"
        Me.HelpProvider1.SetShowHelp(Me.Button3, True)
        Me.Button3.Size = New System.Drawing.Size(75, 46)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Notify Icon"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.HelpProvider1.SetShowHelp(Me.TextBox1, False)
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBox1, "demo of help tooltip")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.NotifyIcon1.BalloonTipText = "I AM SYBCA2"
        Me.NotifyIcon1.BalloonTipTitle = "HIITLiST"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Error Provider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(179, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Help Provider"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(98, 138)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(394, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 4
        Me.ToolTip2.SetToolTip(Me.ProgressBar1, "I AM PROGRESS BAR")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(98, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Start"
        Me.ToolTip2.SetToolTip(Me.Button4, "pRESS TO sTRAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(179, 167)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Stop"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "demo of text for tooltip"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(404, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TextBox2, "demo of help tooltip")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem, Me.StopToolStripMenuItem, Me.KEVALToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 70)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'KEVALToolStripMenuItem
        '
        Me.KEVALToolStripMenuItem.Name = "KEVALToolStripMenuItem"
        Me.KEVALToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.KEVALToolStripMenuItem.Text = "KEVAL"
        '
        'frmErrorHelpNotifyDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 293)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.HelpButton = True
        Me.Name = "frmErrorHelpNotifyDemo"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "frmErrorHelpNotifyDemo"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KEVALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
