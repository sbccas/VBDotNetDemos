<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sampleadoform
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudinfoDataSet = New VBDemos.studinfoDataSet()
        Me.StudentmasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_masterTableAdapter = New VBDemos.studinfoDataSetTableAdapters.student_masterTableAdapter()
        Me.SidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudinfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentmasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.SmobileDataGridViewTextBoxColumn, Me.SemailDataGridViewTextBoxColumn, Me.ScourseDataGridViewTextBoxColumn, Me.ScityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentmasterBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'StudinfoDataSet
        '
        Me.StudinfoDataSet.DataSetName = "studinfoDataSet"
        Me.StudinfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentmasterBindingSource
        '
        Me.StudentmasterBindingSource.DataMember = "student_master"
        Me.StudentmasterBindingSource.DataSource = Me.StudinfoDataSet
        '
        'Student_masterTableAdapter
        '
        Me.Student_masterTableAdapter.ClearBeforeFill = True
        '
        'SidDataGridViewTextBoxColumn
        '
        Me.SidDataGridViewTextBoxColumn.DataPropertyName = "sid"
        Me.SidDataGridViewTextBoxColumn.HeaderText = "sid"
        Me.SidDataGridViewTextBoxColumn.Name = "SidDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "sname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'SmobileDataGridViewTextBoxColumn
        '
        Me.SmobileDataGridViewTextBoxColumn.DataPropertyName = "smobile"
        Me.SmobileDataGridViewTextBoxColumn.HeaderText = "smobile"
        Me.SmobileDataGridViewTextBoxColumn.Name = "SmobileDataGridViewTextBoxColumn"
        '
        'SemailDataGridViewTextBoxColumn
        '
        Me.SemailDataGridViewTextBoxColumn.DataPropertyName = "semail"
        Me.SemailDataGridViewTextBoxColumn.HeaderText = "semail"
        Me.SemailDataGridViewTextBoxColumn.Name = "SemailDataGridViewTextBoxColumn"
        '
        'ScourseDataGridViewTextBoxColumn
        '
        Me.ScourseDataGridViewTextBoxColumn.DataPropertyName = "scourse"
        Me.ScourseDataGridViewTextBoxColumn.HeaderText = "scourse"
        Me.ScourseDataGridViewTextBoxColumn.Name = "ScourseDataGridViewTextBoxColumn"
        '
        'ScityDataGridViewTextBoxColumn
        '
        Me.ScityDataGridViewTextBoxColumn.DataPropertyName = "scity"
        Me.ScityDataGridViewTextBoxColumn.HeaderText = "scity"
        Me.ScityDataGridViewTextBoxColumn.Name = "ScityDataGridViewTextBoxColumn"
        '
        'sampleadoform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 273)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "sampleadoform"
        Me.Text = "sampleadoform"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudinfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentmasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StudinfoDataSet As VBDemos.studinfoDataSet
    Friend WithEvents StudentmasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_masterTableAdapter As VBDemos.studinfoDataSetTableAdapters.student_masterTableAdapter
    Friend WithEvents SidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmobileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
