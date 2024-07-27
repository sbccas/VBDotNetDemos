Public Class frmPerDetails
    Public Sub clearalldata()
        txtName.Text = ""
        txtCity.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        chkbReading.Checked = False
        chkbChess.Checked = False
        chkbMovies.Checked = False
        chkbChatting.Checked = False

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chkbReading.Checked = True
        chkbReading.CheckState = CheckState.Checked
    End Sub
   
    Private Sub rbMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMale.CheckedChanged
        If rbMale.Checked = True Then
            PictureBox1.ImageLocation = "http://172.30.58.221/images/male.jpg"
        Else
            PictureBox1.ImageLocation = "http://172.30.58.221/images/female.png"
        End If

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        REM THIS IS MY DEMO OF FIRST 
        'Code for Displaying Personal Details
        Dim strperDetails As String = "PLEASE ENTER YOUR PER DETAILS:" & vbNewLine
        strperDetails += "NAME : "
        strperDetails += txtName.Text & vbNewLine
        strperDetails += "CITY : "
        strperDetails += txtCity.Text & vbNewLine
        'Decision Making Statement
        If rbMale.Checked = True Then
            strperDetails += "YOU ARE MALE" & vbNewLine
        End If
        If rbFemale.Checked = True Then
            strperDetails += "YOU ARE FEMALE" & vbNewLine
        End If

        'SELECTION HOBBIES

        strperDetails += "Your Hobbies are as Follows :" & vbNewLine
        If chkbReading.Checked Then
            strperDetails += chkbReading.Text
        End If
        If chkbMovies.Checked Then
            strperDetails += chkbMovies.Text
        End If
        If chkbChess.Checked Then
            strperDetails += chkbChess.Text
        End If
        If chkbChatting.Checked Then
            strperDetails += chkbChatting.Text
        End If

        MsgBox(strperDetails)

        'Dim str As String = "your personal details are: " & vbNewLine
        'str += "name : "
        'str += txtName.Text & vbNewLine & "you are from : "
        'str += txtCity.Text & vbNewLine
        'If rbMale.Checked = True Then
        '    str += " you are " & rbMale.Text
        'Else
        '    str += " you are " & rbFemale.Text
        'End If
        ''code for hobbies
        'str += vbNewLine & "your hobbies are as follows : " & vbNewLine
        'If chkbReading.Checked Then
        '    str += chkbReading.Text & vbNewLine
        'End If


        'If chkbMovies.Checked Then
        '    str += chkbMovies.Text & vbNewLine
        'End If

        'If chkbChess.Checked Then
        '    str += chkbChess.Text & vbNewLine
        'End If

        'If chkbChatting.Checked Then
        '    str += chkbChatting.Text & vbNewLine
        'End If

        'MsgBox(str)

        clearalldata()

    End Sub

    Private Sub rbFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFemale.CheckedChanged
        If rbMale.Checked = True Then
            PictureBox1.ImageLocation = "http://172.30.58.221/images/male.jpg"
        Else
            PictureBox1.ImageLocation = "http://172.30.58.221/images/female.png"
        End If

    End Sub

    

    Private Sub chkbMovies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbMovies.CheckedChanged

    End Sub

    

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim str As String = ""
        For i = 1 To 40 Step 1
            If i Mod 2 = 0 And i < 40 Then
                str += "HELLO I AM MSGBOX NO " & i & vbNewLine
            End If

        Next
        MsgBox(str)
    End Sub

   

    
    Private Sub btnCLearall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLearall.Click
        clearalldata()
    End Sub
End Class