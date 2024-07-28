Public Class frmErrorHelpNotifyDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "sutex" Then
            MsgBox("INPUT OK")
        Else
            ErrorProvider1.SetError(TextBox1, "PLEASE ENTER SUTEX")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        HelpProvider1.SetHelpString(TextBox1, "THIS IS MY NEW HELP")
        HelpProvider1.SetShowHelp(TextBox1, True)
        'HelpProvider1.SetHelpNavigator(TextBox1, HelpNavigator.Index)

        'HelpProvider1.SetShowHelp(TextBox2, True)
        'HelpProvider1.SetShowHelp(Button2, True)





    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NotifyIcon1.ShowBalloonTip(100000, "BANSI KHAGRAM", "BANSI KHAGRAM", System.Windows.Forms.ToolTipIcon.Error)

    End Sub

    Private Sub frmErrorHelpNotifyDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpProvider1.SetShowHelp(TextBox1, True)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 10
        End If

    End Sub

    Private Sub frmErrorHelpNotifyDemo_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        NotifyIcon1.ShowBalloonTip(100000, "VB.NET DEMOS", "Demo of NotifyIcon", System.Windows.Forms.ToolTipIcon.Error)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Stop()
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        Timer1.Start()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        Timer1.Stop()
    End Sub

    Private Sub KEVALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KEVALToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class