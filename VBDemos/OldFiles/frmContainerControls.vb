Public Class frmContainerControls
    Shared random As New Random()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox1.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim mybtn As New Button
        mybtn.Text = "A"
        mybtn.Name = "btna"
        TableLayoutPanel1.Controls.Add(mybtn)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://192.168.10.73/PhotoGallery/PicStore/Default/PhotoGallery%201/pics/Screenshot_2017-01-30_12.19.49.png")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://192.168.10.73/PhotoGallery/PicStore/Default/PhotoGallery%201/pics/Screenshot_2017-01-30_12.19.59.png")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://192.168.10.73/PhotoGallery/PicStore/Default/PhotoGallery%201/pics/Screenshot_2017-01-30_12.20.04.png")
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start("http://192.168.10.73/PhotoGallery/PicStore/Default/PhotoGallery%201/pics/Screenshot_2017-01-30_12.20.07.png")
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start("http://192.168.10.73/PhotoGallery/PicStore/Default/PhotoGallery%201/pics/Screenshot_2017-01-30_12.20.11.png")
    End Sub

    
    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Visible = False

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex -= 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabControl1.SelectedIndex += 1
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim mybtn As New Button
        mybtn.Text = "A"
        mybtn.Name = "btna"
        mybtn.Width = random.Next(5, 199)
        FlowLayoutPanel1.Controls.Add(mybtn)
    End Sub
End Class