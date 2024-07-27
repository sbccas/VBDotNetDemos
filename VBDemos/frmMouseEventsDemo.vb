Public Class frmMouseEventsDemo
    Dim flag As Boolean = True
    Private Sub txtID_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.MouseEnter
        'code for handling mouse enter on ID textbox
        txtID.BackColor = Color.CornflowerBlue
        txtID.ForeColor = Color.White
    End Sub

   
    Private Sub frmMouseEventsDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.   
        Timer1.Start()
        Me.Text = "Mouse and Keyboard Events Demo (Hi-Tech)"
        Label5.Text = "AUTOMATIC TYPING DEMO : "
    End Sub

    Private Sub txtID_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.MouseLeave
        'code for handling mouse leave on ID textbox
        txtID.BackColor = Color.White
        txtID.ForeColor = Color.Blue
    End Sub

    Private Sub txtName_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.MouseEnter
        'code for handling mouse enter on Name textbox
        txtName.BackColor = Color.CornflowerBlue
        txtName.ForeColor = Color.White
    End Sub

    Private Sub txtName_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.MouseLeave
        'code for handling mouse leave on Name textbox
        txtName.BackColor = Color.White
        txtName.ForeColor = Color.Blue

    End Sub

    Private Sub txtAddress_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.MouseEnter
        'code for handling mouse enter on Address textbox
        txtAddress.BackColor = Color.CornflowerBlue
        txtAddress.ForeColor = Color.White
    End Sub

    Private Sub txtAddress_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.MouseLeave

        'code for handling mouse leave on Address textbox
        txtAddress.BackColor = Color.White
        txtAddress.ForeColor = Color.Blue

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Thank you " & txtName.Text & ", for your kind cooperation")
    End Sub

    Private Sub txtID_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
        If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
            MessageBox.Show("Enter numbers for your Customer ID")
            txtID.Text = ""
        Else
            MsgBox("YOU ENTERED " & txtID.Text)
        End If

        

    End Sub

    Private Sub txtAge_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAge.KeyUp
        If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
            MessageBox.Show("Enter numbers for age")
            txtAge.Text = " "
        End If
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtName.Focus()
        End If

    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        'ASCII ONLY FOR ALPHABETS and BACKSPACE
        If (e.KeyChar >= Chr(65) And e.KeyChar <= Chr(90)) Or (e.KeyChar >= Chr(97) And e.KeyChar <= Chr(122)) Or (e.KeyChar = Chr(8) Or (e.KeyChar = Chr(32))) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

  
    Private Sub frmMouseEventsDemo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'ListBox1.MultiColumn = True
        'ListBox1.Items.Add("A")
    End Sub

    Private Sub txtID_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.MouseHover
        'txtID.Text += "1"
    End Sub

    Private Sub frmMouseEventsDemo_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDoubleClick
        If flag Then
            Me.BackColor = Color.Blue
            flag = False
        Else
            Me.BackColor = Color.Orange
            flag = True
        End If

    End Sub

    Private Sub frmMouseEventsDemo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        If flag Then
            Me.BackColor = Color.Cyan
            flag = False
        Else
            Me.BackColor = Color.Red
            flag = True
        End If
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        End If
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            ' ProgressBar1.Value = 0

        Else
            ProgressBar1.Value += 10
            ListBox1.Items.Add("SYBCA DIV 3")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Focus()
        MsgBox(sender.ToString)
        'MsgBox(e.GetType)




    End Sub

    Private Sub Label2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        MsgBox("I AM STAYING")
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("I AM ENTERING")
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        'e.KeyCode = Keys.Space
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(8) Then
            e.Handled = True
            MsgBox("YOU PRESSESD BACK SPACE")
        Else
            e.Handled = False
        End If
    End Sub
End Class