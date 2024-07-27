Public Class ucDemo

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = System.DateTime.Now.ToString("hh:mm:ss")
        Beep()
    End Sub
End Class
