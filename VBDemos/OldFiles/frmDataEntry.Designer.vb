<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataEntry
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataEntry))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnFrilterGrid = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnRollNo = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnDesc = New System.Windows.Forms.Button()
        Me.btnAsc = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.cmbCOurse = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UcNavigation1 = New VBDemos.ucNavigation()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFrilterGrid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFilter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcNavigation1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRollNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDesc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAsc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnShow)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtRollNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCity)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCOurse)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMobile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnInsert)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 545)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'btnFrilterGrid
        '
        Me.btnFrilterGrid.Location = New System.Drawing.Point(687, 138)
        Me.btnFrilterGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFrilterGrid.Name = "btnFrilterGrid"
        Me.btnFrilterGrid.Size = New System.Drawing.Size(111, 28)
        Me.btnFrilterGrid.TabIndex = 60
        Me.btnFrilterGrid.Text = "Filter Grid"
        Me.btnFrilterGrid.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(684, 174)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(111, 28)
        Me.btnFilter.TabIndex = 59
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnRollNo
        '
        Me.btnRollNo.Location = New System.Drawing.Point(23, 28)
        Me.btnRollNo.Name = "btnRollNo"
        Me.btnRollNo.Size = New System.Drawing.Size(75, 23)
        Me.btnRollNo.TabIndex = 57
        Me.btnRollNo.Text = "Roll No"
        Me.btnRollNo.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BBA", "BCA", "BCOM"})
        Me.ComboBox1.Location = New System.Drawing.Point(687, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(111, 24)
        Me.ComboBox1.TabIndex = 56
        '
        'btnDesc
        '
        Me.btnDesc.Location = New System.Drawing.Point(567, 27)
        Me.btnDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDesc.Name = "btnDesc"
        Me.btnDesc.Size = New System.Drawing.Size(111, 28)
        Me.btnDesc.TabIndex = 12
        Me.btnDesc.Text = "Descending"
        Me.btnDesc.UseVisualStyleBackColor = True
        '
        'btnAsc
        '
        Me.btnAsc.Location = New System.Drawing.Point(447, 27)
        Me.btnAsc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAsc.Name = "btnAsc"
        Me.btnAsc.Size = New System.Drawing.Size(111, 28)
        Me.btnAsc.TabIndex = 11
        Me.btnAsc.Text = "Ascending"
        Me.btnAsc.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(330, 29)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(111, 28)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtRollNo
        '
        Me.txtRollNo.Location = New System.Drawing.Point(111, 27)
        Me.txtRollNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(178, 24)
        Me.txtRollNo.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(801, 174)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 28)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(567, 174)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 28)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(444, 174)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 28)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "City"
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Items.AddRange(New Object() {"SELECT", "SURAT", "AHMEDABAD", "VADODRA", "MUMBAI" & Global.Microsoft.VisualBasic.ChrW(9), ""})
        Me.cmbCity.Location = New System.Drawing.Point(111, 185)
        Me.cmbCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(178, 24)
        Me.cmbCity.TabIndex = 5
        '
        'cmbCOurse
        '
        Me.cmbCOurse.FormattingEnabled = True
        Me.cmbCOurse.Items.AddRange(New Object() {"SELECT", "BCA", "BBA", "BCOM", ""})
        Me.cmbCOurse.Location = New System.Drawing.Point(111, 154)
        Me.cmbCOurse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCOurse.Name = "cmbCOurse"
        Me.cmbCOurse.Size = New System.Drawing.Size(178, 24)
        Me.cmbCOurse.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(111, 124)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(178, 24)
        Me.txtEmail.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(111, 55)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 24)
        Me.txtName.TabIndex = 1
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(111, 87)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(178, 24)
        Me.txtMobile.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Mobile No"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(324, 174)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(111, 28)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(947, 312)
        Me.DataGridView1.TabIndex = 47
        '
        'UcNavigation1
        '
        Me.UcNavigation1.Location = New System.Drawing.Point(341, 64)
        Me.UcNavigation1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcNavigation1.Name = "UcNavigation1"
        Me.UcNavigation1.Size = New System.Drawing.Size(602, 46)
        Me.UcNavigation1.TabIndex = 58
        '
        'frmDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 545)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDataEntry"
        Me.Text = "Student Record Management"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtRollNo As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCOurse As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnDesc As System.Windows.Forms.Button
    Friend WithEvents btnAsc As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnRollNo As System.Windows.Forms.Button
    Friend WithEvents UcNavigation1 As VBDemos.ucNavigation
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnFrilterGrid As System.Windows.Forms.Button
End Class
