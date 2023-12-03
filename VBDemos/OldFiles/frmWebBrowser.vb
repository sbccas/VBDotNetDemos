Public Class frmWebBrowser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub frmWebBrowser_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDoubleClick
        Panel1.Visible = True
        WebBrowser1.Navigate("www.google.com")
    End Sub
End Class