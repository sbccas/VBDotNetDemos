Public Class frmPersonalDetails

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'Code for Displaying Personal Details
        Dim str As String = "Your Personal Details are: " & vbNewLine
        str += "Name : "
        str += txtName.Text & vbNewLine & "You are From : "
        str += txtCity.Text & vbNewLine
        If rbMale.Checked Then
            str += "You are " & rbMale.Text
            PictureBox1.ImageLocation = "http://192.168.10.73/images/male.jpg"

        Else
            str += "You are " & rbFemale.Text
            PictureBox1.ImageLocation = "http://192.168.10.73/images/female.png"
        End If
        str += "Your Hobbies are as Follows : " & vbNewLine
        'Code for Hobbies

        If chkbReading.Checked Then
            str += chkbReading.Text & vbNewLine
        End If


        If chkbMovies.Checked Then
            str += chkbMovies.Text & vbNewLine
        End If

        If chkbChess.Checked Then
            str += chkbChess.Text & vbNewLine
        End If

        If chkbChatting.Checked Then
            str += chkbChatting.Text & vbNewLine
        End If


        


        MsgBox(str)


    End Sub

  
    Private Sub rbMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMale.CheckedChanged
        If rbMale.Checked Then

            PictureBox1.ImageLocation = "http://192.168.10.73/images/male.jpg"

        Else

            PictureBox1.ImageLocation = "http://192.168.10.73/images/female.png"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://192.168.10.73/CodeViewer.aspx?pageID=frmPersonalDetails.vb")
    End Sub
End Class