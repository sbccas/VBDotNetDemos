<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalDetails
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.chkbReading = New System.Windows.Forms.CheckBox()
        Me.chkbMovies = New System.Windows.Forms.CheckBox()
        Me.chkbChess = New System.Windows.Forms.CheckBox()
        Me.chkbChatting = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(70, 300)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(138, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(138, 65)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Gender"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(138, 114)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(54, 17)
        Me.rbMale.TabIndex = 6
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "MALE"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(211, 112)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(67, 17)
        Me.rbFemale.TabIndex = 7
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "FEMALE"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'chkbReading
        '
        Me.chkbReading.AutoSize = True
        Me.chkbReading.Location = New System.Drawing.Point(157, 161)
        Me.chkbReading.Name = "chkbReading"
        Me.chkbReading.Size = New System.Drawing.Size(66, 17)
        Me.chkbReading.TabIndex = 8
        Me.chkbReading.Text = "Reading"
        Me.chkbReading.UseVisualStyleBackColor = True
        '
        'chkbMovies
        '
        Me.chkbMovies.AutoSize = True
        Me.chkbMovies.Location = New System.Drawing.Point(244, 161)
        Me.chkbMovies.Name = "chkbMovies"
        Me.chkbMovies.Size = New System.Drawing.Size(109, 17)
        Me.chkbMovies.TabIndex = 9
        Me.chkbMovies.Text = "Watching Movies"
        Me.chkbMovies.UseVisualStyleBackColor = True
        '
        'chkbChess
        '
        Me.chkbChess.AutoSize = True
        Me.chkbChess.Location = New System.Drawing.Point(157, 184)
        Me.chkbChess.Name = "chkbChess"
        Me.chkbChess.Size = New System.Drawing.Size(55, 17)
        Me.chkbChess.TabIndex = 10
        Me.chkbChess.Text = "Chess"
        Me.chkbChess.UseVisualStyleBackColor = True
        '
        'chkbChatting
        '
        Me.chkbChatting.AutoSize = True
        Me.chkbChatting.Location = New System.Drawing.Point(244, 184)
        Me.chkbChatting.Name = "chkbChatting"
        Me.chkbChatting.Size = New System.Drawing.Size(65, 17)
        Me.chkbChatting.TabIndex = 11
        Me.chkbChatting.Text = "Chatting"
        Me.chkbChatting.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hobbies"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(387, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(415, 310)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 13)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View Code"
        '
        'frmPersonalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 335)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkbChatting)
        Me.Controls.Add(Me.chkbChess)
        Me.Controls.Add(Me.chkbMovies)
        Me.Controls.Add(Me.chkbReading)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "frmPersonalDetails"
        Me.Text = "frmPersonalDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents chkbReading As System.Windows.Forms.CheckBox
    Friend WithEvents chkbMovies As System.Windows.Forms.CheckBox
    Friend WithEvents chkbChess As System.Windows.Forms.CheckBox
    Friend WithEvents chkbChatting As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
