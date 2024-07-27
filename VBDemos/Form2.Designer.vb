<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPrin = New System.Windows.Forms.TextBox()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. of Years"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rate of Interest"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Principal Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PROGRAM FOR SIMPLE INTEREST CALCULATION"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(130, 127)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(233, 20)
        Me.txtYear.TabIndex = 12
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(130, 153)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 27)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(130, 101)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(233, 20)
        Me.txtRate.TabIndex = 11
        '
        'txtPrin
        '
        Me.txtPrin.Location = New System.Drawing.Point(130, 75)
        Me.txtPrin.Name = "txtPrin"
        Me.txtPrin.Size = New System.Drawing.Size(233, 20)
        Me.txtPrin.TabIndex = 10
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(130, 186)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.ReadOnly = True
        Me.txtAns.Size = New System.Drawing.Size(233, 20)
        Me.txtAns.TabIndex = 10
        Me.txtAns.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 262)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.txtPrin)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtPrin As System.Windows.Forms.TextBox
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
End Class
