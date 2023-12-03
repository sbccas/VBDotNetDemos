Public Class frmExceptionHandlingDemo

    Private Sub btnonError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnonError.Click
        On Error GoTo ghare
        Dim i, j As Integer
        Dim k As Integer
        k = i / j
        MsgBox("HELLO FROM ANS   " & k)
ghare:
        MsgBox("I AM UNABLE TO SOLVE ERROR")
        Exit Sub
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Structured 
        'unstructured
        On Error GoTo SUTEX
        '.Raise(11)
        Err.Raise(11, "I AM SYBCA3", "GO AND LEARN DIVISION...):", , )

SUTEX:
        Dim estr As String = ""
        estr = "ERR NUMBER " & Err.Number & vbNewLine
        estr += "ERR DESC " & Err.Description & vbNewLine
        estr += "ERR SOURCE " & Err.Source & vbNewLine
        estr += "ERR ERL " & Err.Erl
        MsgBox(estr)
        Exit Sub





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim flag, a1, a2 As Integer
        On Error GoTo sybca3
        a1 = 12
        a2 = 0
        flag = 1
        RichTextBox1.Text = a1 Mod a2
        If flag = 0 Then
            RichTextBox1.Text = 0

        End If
        ' Exit Sub
sybca3:
        'tamaro code error handling unhandeled
        MsgBox("GOOD MORING ERROR AAVE CHE")
        MsgBox("ERROR NUMBER " & Err.Number & " ERR. DESC. " & Err.Description)
        flag = 0
        Resume Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For i = 1 To 512
            On Error GoTo sybca2
            Err.Raise(i)
        Next


sybca2:
        RichTextBox1.Text &= " No : " & Err.Number & " "
        RichTextBox1.Text &= "ERROR TYPE : " & Err.Description & " {" & Err.Source & "} " & vbNewLine
        Err.Clear()
        Resume Next

        'RichTextBox1.Text &= " YOUR ERROR IS SOURCE : " & Err.Source & " "
        'RichTextBox1.Text &= " YOUR ERROR IS ERL : " & Err.Erl & vbNewLine

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            'Err.Raise(12)
            Dim i, j, k As Integer
            i = 12
            j = 0
            k = i Mod j
            MsgBox("ANS IS : " & k)


        Catch ex As IO.IOException
            MsgBox("INPUT OUT ERROR CHE")
        Catch ex As OverflowException
            MsgBox("DATA OVERFLOW ERROR")
        Catch ex As System.StackOverflowException
        Catch ex As SqlClient.SqlException
            MsgBox("DATABASE PROBLEM")
        Catch When Err.Number = 11
            MsgBox("CAUGHT YOU " & Err.Description)

            '    MsgBox("KAI NUKSHAN NATHI THAYU")
        Catch ex As System.Exception
            'MsgBox(ex.Message.ToString)
            MsgBox(ex.ToString)

        Finally
            MsgBox("I AM IMMORTAL")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Throw New ApplicationException("I AM VERY POWERFUL ERROR")
        Catch ex As Exception
            MsgBox("SIXER " & ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            'Err.Raise(11, "I AM VBDEMO", "I AM STRONG ERROR ")
            Throw New ApplicationException("BRAND NEW TYPE NI ERROR Occured")
            'dsgfgfdgdfgfd
            'fgfdgfdgfdg'fdgfdg
            'dfghfdgdfgdfgd
            'Exit Try
        Catch When Err.Number = 11
            MsgBox("DIVIDE BY ZERO ERROR")
        Catch ex As System.IO.FileNotFoundException
            MsgBox("FILE NU NAME CHECK KARO")
        Catch ex As System.Data.DataException
            MsgBox("DATABASE NU NAME CHECK KARO")
        Catch ex As DivideByZeroException
            MsgBox("SCHOOL MA MATHS NATHI SIKHYA K SU?")
        Catch ex As System.ApplicationException
            MsgBox(ex.Message)
        Catch ex As System.Exception
            MsgBox("AB AAYA UNT PAHAD KE NICHE")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Throw New ApplicationException("VIRAL ERROR Occured")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsybca3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsybca3.Click
        Try
            'CODE GOES HERE
            MsgBox("HELLO FROM SYBCA 3 2020")
            Dim i, j As Integer
            i = 5
            j = i / 0
            MsgBox(j)
        Catch ex As Exception
            'ERROR CATCH  ----> DISPLAY
            MsgBox("IF YOU HAVE GAS PROBLEM TAKE ENO......!!!!")
        Finally
            MsgBox("I AM FINALLY")
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        On Error GoTo sutex
        Dim i, j As Integer

        i = 5
        j = i / 0

sutex:
        MsgBox("SOMETHING ERROR HAPPENED")

    End Sub
End Class