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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComboBoxDemo))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(24, 132)
        Me.ComboBox1.MaxDropDownItems = 4
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 142)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "HabiticaWunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica"})
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DropDownWidth = 50
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.Items.AddRange(New Object() {"Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Any.DO", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Google Keep", "Habitica", "Habitica", "Habitica", "Habitica", "Habitica", "Habitica", "Habitica", "Habitica", "Habitica", "Habitica", "HabiticaWunderlist", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "OmniFocus", "Things", "Things", "Things", "Things", "Things", "Things", "Things", "Things", "Things", "Things", "Things", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "TickTick", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "Todoist", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "ToodleDo", "Trello", "Trello", "Trello", "Trello", "Trello", "Trello", "Trello", "Trello", "Trello", "Trello", "Trello", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist", "Wunderlist"})
        Me.ComboBox2.Location = New System.Drawing.Point(194, 137)
        Me.ComboBox2.MaxDropDownItems = 2
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteCustomSource.AddRange(New String() {"Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "HabiticaWunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica"})
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IntegralHeight = False
        Me.ComboBox3.Items.AddRange(New Object() {"Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica", "Wunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "HabiticaWunderlist", "Todoist", "Trello", "ToodleDo", "Any.DO", "Things", "TickTick", "Google Keep", "OmniFocus", "Habitica"})
        Me.ComboBox3.Location = New System.Drawing.Point(374, 138)
        Me.ComboBox3.MaxDropDownItems = 7
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SYBCA3"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"COMBO 1", "COMBO2", "COMBO3"})
        Me.ComboBox4.Location = New System.Drawing.Point(275, 210)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBDemos.My.Resources.Resources.Apple
        Me.PictureBox1.Location = New System.Drawing.Point(212, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(194, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(431, 178)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(124, 118)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'frmComboBoxDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 308)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmComboBoxDemo"
        Me.Text = "frmComboBoxDemo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
