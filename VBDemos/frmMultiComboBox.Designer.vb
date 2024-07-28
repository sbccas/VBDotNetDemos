<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiComboBox
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HitlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DemosDataSet3 = New VBDemos.DemosDataSet3()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HitlistTableAdapter = New VBDemos.DemosDataSet3TableAdapters.hitlistTableAdapter()
        CType(Me.HitlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DemosDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.HitlistBindingSource
        Me.ComboBox1.DisplayMember = "semail"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(53, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "scity"
        '
        'HitlistBindingSource
        '
        Me.HitlistBindingSource.DataMember = "hitlist"
        Me.HitlistBindingSource.DataSource = Me.DemosDataSet3
        '
        'DemosDataSet3
        '
        Me.DemosDataSet3.DataSetName = "DemosDataSet3"
        Me.DemosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.HitlistBindingSource
        Me.ComboBox2.DisplayMember = "smobile"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(53, 96)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.ValueMember = "sid"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 2
        '
        'HitlistTableAdapter
        '
        Me.HitlistTableAdapter.ClearBeforeFill = True
        '
        'frmMultiComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmMultiComboBox"
        Me.Text = "frmMultiComboBox"
        CType(Me.HitlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DemosDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DemosDataSet3 As VBDemos.DemosDataSet3
    Friend WithEvents HitlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HitlistTableAdapter As VBDemos.DemosDataSet3TableAdapters.hitlistTableAdapter
End Class
