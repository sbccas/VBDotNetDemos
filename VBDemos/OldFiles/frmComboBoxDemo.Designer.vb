<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComboBoxDemo
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Last Name", "ADMIN", "the phone", "Akabari", "italiya", "Gajera", "parmar", "sdfsds", "boghara", "boghara", "Ambaliya", "dholariya", "Dhirubhai", "Bharati", "Jagidiya", "Prajapati", "meghani", "bansal", "prajapati", "savaj", "balar", "dhami", "italiya", "Variya", "bhuvani", "patel", "Jani", "Makwana", "Tarsariya", "Tank", "jaisukhbhai", "Talaviya", "donga", "ardesana", "kaklottar", "Chakrani", "chauhan", "kachariya", "jadav", "maheta", "Paghdal", "kothariya", "kasodariya", "Devani", "sisara", "bharatbhai", "Chaudhari", "chudasama", "Bambhaniya ", "rajput", "gandhi", "Desai", "modi", "Kalathiya", "mangukiya", "italiya", "mangukiya", "gothadiya", "mathukiya", "kukadiya", "khunt", "Makwana", "katva", "gondliya", "jasoliya", "Kargar", "khuman", "thummar", "vaghasiya", "khunt", "italiya", "Chopada", "Bambhaniya", "dhameliya", "Bhuva", "tank", "khunt", "paliwal", "zanzmera", "khunt", "Sakariya", "rangpariya", "Nasit", "shankar", "dhameliya", "Mavawala", "sapariya", "nakarani", "savaliya", "Narola", "kanpariya", "sakariya", "golakiya", "vaddoriya", "Variya", "Vaghela", "PATEL", "patel", "swain", "KORAT", "solanki", "kukadiya", "narola", "pipaliya", "sarvaiya", "bhadani", "Gajera", "dobariya", "Dobariya", "dobariya", "aalagiya", "vaghasiya", "Gohil", "Goswami", "gajera", "kevadiya", "Khatra", "tejani", "talaviya", "Tarsariya", "Tailor", "singh", "Tanti", "limbasiya", "vanara", "miyani", "Vekariya", "pansuriya", "Solanki", "togadiya", "shukla", "baldha"})
        Me.ComboBox1.Location = New System.Drawing.Point(289, 71)
        Me.ComboBox1.MaxDropDownItems = 4
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(406, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Last Name", "ADMIN", "the phone", "Akabari", "italiya", "Gajera", "parmar", "sdfsds", "boghara", "boghara", "Ambaliya", "dholariya", "Dhirubhai", "Bharati", "Jagidiya", "Prajapati", "meghani", "bansal", "prajapati", "savaj", "balar", "dhami", "italiya", "Variya", "bhuvani", "patel", "Jani", "Makwana", "Tarsariya", "Tank", "jaisukhbhai", "Talaviya", "donga", "ardesana", "kaklottar", "Chakrani", "chauhan", "kachariya", "jadav", "maheta", "Paghdal", "kothariya", "kasodariya", "Devani", "sisara", "bharatbhai", "Chaudhari", "chudasama", "Bambhaniya ", "rajput", "gandhi", "Desai", "modi", "Kalathiya", "mangukiya", "italiya", "mangukiya", "gothadiya", "mathukiya", "kukadiya", "khunt", "Makwana", "katva", "gondliya", "jasoliya", "Kargar", "khuman", "thummar", "vaghasiya", "khunt", "italiya", "Chopada", "Bambhaniya", "dhameliya", "Bhuva", "tank", "khunt", "paliwal", "zanzmera", "khunt", "Sakariya", "rangpariya", "Nasit", "shankar", "dhameliya", "Mavawala", "sapariya", "nakarani", "savaliya", "Narola", "kanpariya", "sakariya", "golakiya", "vaddoriya", "Variya", "Vaghela", "PATEL", "patel", "swain", "KORAT", "solanki", "kukadiya", "narola", "pipaliya", "sarvaiya", "bhadani", "Gajera", "dobariya", "Dobariya", "dobariya", "aalagiya", "vaghasiya", "Gohil", "Goswami", "gajera", "kevadiya", "Khatra", "tejani", "talaviya", "Tarsariya", "Tailor", "singh", "Tanti", "limbasiya", "vanara", "miyani", "Vekariya", "pansuriya", "Solanki", "togadiya", "shukla", "baldha"})
        Me.ComboBox2.Location = New System.Drawing.Point(35, 71)
        Me.ComboBox2.MaxDropDownItems = 4
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 150)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Last Name", "ADMIN", "the phone", "Akabari", "italiya", "Gajera", "parmar", "sdfsds", "boghara", "boghara", "Ambaliya", "dholariya", "Dhirubhai", "Bharati", "Jagidiya", "Prajapati", "meghani", "bansal", "prajapati", "savaj", "balar", "dhami", "italiya", "Variya", "bhuvani", "patel", "Jani", "Makwana", "Tarsariya", "Tank", "jaisukhbhai", "Talaviya", "donga", "ardesana", "kaklottar", "Chakrani", "chauhan", "kachariya", "jadav", "maheta", "Paghdal", "kothariya", "kasodariya", "Devani", "sisara", "bharatbhai", "Chaudhari", "chudasama", "Bambhaniya ", "rajput", "gandhi", "Desai", "modi", "Kalathiya", "mangukiya", "italiya", "mangukiya", "gothadiya", "mathukiya", "kukadiya", "khunt", "Makwana", "katva", "gondliya", "jasoliya", "Kargar", "khuman", "thummar", "vaghasiya", "khunt", "italiya", "Chopada", "Bambhaniya", "dhameliya", "Bhuva", "tank", "khunt", "paliwal", "zanzmera", "khunt", "Sakariya", "rangpariya", "Nasit", "shankar", "dhameliya", "Mavawala", "sapariya", "nakarani", "savaliya", "Narola", "kanpariya", "sakariya", "golakiya", "vaddoriya", "Variya", "Vaghela", "PATEL", "patel", "swain", "KORAT", "solanki", "kukadiya", "narola", "pipaliya", "sarvaiya", "bhadani", "Gajera", "dobariya", "Dobariya", "dobariya", "aalagiya", "vaghasiya", "Gohil", "Goswami", "gajera", "kevadiya", "Khatra", "tejani", "talaviya", "Tarsariya", "Tailor", "singh", "Tanti", "limbasiya", "vanara", "miyani", "Vekariya", "pansuriya", "Solanki", "togadiya", "shukla", "baldha"})
        Me.ComboBox3.Location = New System.Drawing.Point(162, 71)
        Me.ComboBox3.MaxDropDownItems = 4
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'frmComboBoxDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 306)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmComboBoxDemo"
        Me.Text = "frmComboBoxDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
End Class
