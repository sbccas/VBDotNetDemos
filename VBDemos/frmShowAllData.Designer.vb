<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowAllData
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
        Me.ExamDataSet = New VBDemos.examDataSet()
        Me.TblEmployeeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeeInfoTableAdapter = New VBDemos.examDataSetTableAdapters.tblEmployeeInfoTableAdapter()
        Me.EmpNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpNoDataGridViewTextBoxColumn, Me.EmpNameDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.DOJDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblEmployeeInfoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(497, 232)
        Me.DataGridView1.TabIndex = 0
        '
        'ExamDataSet
        '
        Me.ExamDataSet.DataSetName = "examDataSet"
        Me.ExamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEmployeeInfoBindingSource
        '
        Me.TblEmployeeInfoBindingSource.DataMember = "tblEmployeeInfo"
        Me.TblEmployeeInfoBindingSource.DataSource = Me.ExamDataSet
        '
        'TblEmployeeInfoTableAdapter
        '
        Me.TblEmployeeInfoTableAdapter.ClearBeforeFill = True
        '
        'EmpNoDataGridViewTextBoxColumn
        '
        Me.EmpNoDataGridViewTextBoxColumn.DataPropertyName = "EmpNo"
        Me.EmpNoDataGridViewTextBoxColumn.HeaderText = "EmpNo"
        Me.EmpNoDataGridViewTextBoxColumn.Name = "EmpNoDataGridViewTextBoxColumn"
        '
        'EmpNameDataGridViewTextBoxColumn
        '
        Me.EmpNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName"
        Me.EmpNameDataGridViewTextBoxColumn.HeaderText = "EmpName"
        Me.EmpNameDataGridViewTextBoxColumn.Name = "EmpNameDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'DOJDataGridViewTextBoxColumn
        '
        Me.DOJDataGridViewTextBoxColumn.DataPropertyName = "DOJ"
        Me.DOJDataGridViewTextBoxColumn.HeaderText = "DOJ"
        Me.DOJDataGridViewTextBoxColumn.Name = "DOJDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'frmShowAllData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 232)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmShowAllData"
        Me.Text = "frmShowAllData"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ExamDataSet As VBDemos.examDataSet
    Friend WithEvents TblEmployeeInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeeInfoTableAdapter As VBDemos.examDataSetTableAdapters.tblEmployeeInfoTableAdapter
    Friend WithEvents EmpNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOJDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
