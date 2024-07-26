Public Class frmComponentsDemo
    Dim counter As Integer = 10
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "SUTEX" Then
        Else
            ErrorProvider1.SetError(TextBox1, "NAME SUTEX HOVU JOIE")
        End If
        ErrorProvider1.Clear()
        If TextBox2.Text = "SYBCADIV3" Then
        Else
            ErrorProvider1.SetError(TextBox2, "SYBCADIV 3 ONLY ALLOWED")
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Text = "HELLO" Then
            Label1.Text = "HOW ARE YOU"
        Else
            Label1.Text = "HELLO"
        End If
    End Sub
    Private Sub frmComponentsDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Timer1.Start()
        Timer2.Enabled = True
        Timer2.Interval = 1000
        Timer2.Start()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
        'If counter = 0 Then
        '    Timer2.Enabled = False
        '    MsgBox("TIME UP ")
        '    counter = 10
        '    Label1.Text = "TIME ELASPED : " & counter
        'Else
        '    Label1.Text = "TIME ELASPED : " & counter
        '    counter = counter - 1
        'End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Enabled = True
        Timer2.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        NotifyIcon1.Text = "SAMPLE TEXT"
        NotifyIcon1.ShowBalloonTip(10000, "THIS IS TITLE TEXT", "HELLO FROM SYBCA 3", System.Windows.Forms.ToolTipIcon.Warning)
    End Sub
End Class