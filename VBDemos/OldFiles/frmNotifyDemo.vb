Public Class frmNotifyDemo

    
    Private Sub frmNotifyDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.ShowBalloonTip(2000)
        Me.Hide()
    End Sub
End Class