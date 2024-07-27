Imports System.Math

Public Class frmInbuiltFunctions
    Structure bcacollege
        Dim strstucount As Integer
        Dim noofyears As Integer
        Dim classroom As Integer
    End Structure

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String = InputBox("please enter searching data")
        Dim str1 As String = InputBox("what to search")
        MsgBox(InStr(str, str1))
        Dim STR2232 As String = "sutex bank college of computer applications and science"
    End Sub

    Private Sub btnTypeName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTypeName.Click
        Dim dt As New RadioButton
        MsgBox(TypeName(dt))
    End Sub

    Private Sub btnTypeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTypeCheck.Click
        Dim obj As String = "dxcvxvxcvx"
        If IsNumeric(obj) Then
            MsgBox("I AM NUMBER")
        Else
            MsgBox("I AM NOT NUMBER")
        End If
    End Sub

    Private Sub btnConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversion.Click
        Dim str As String = "111"
        Dim i As Integer = 0
        Dim j As Integer = Convert.ToInt32(str)
        If IsNumeric(j) Then
            MsgBox("I AM NUMBER")
        Else
            MsgBox("I AM NOT NUMBER")
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim str(2) As String
        str(0) = "SUTEX"
        str(1) = " BANK"
        str(2) = " COLLEGE"

        Dim i As Integer = 0
        
        ReDim Preserve str(9)
        str(3) = " OF COMPUTER"

        For i = 0 To str.Length - 1
            MsgBox("ELEEMNT NO  " & i & " VALUE IT HOLDS " & str(i))
        Next
        MsgBox(str.GetUpperBound(0))
        MsgBox(str.GetLowerBound(0))
        MsgBox(str.GetLength(0))


        'MULTIDIMENSTINAL ARRAY
        Dim matrix1(2, 5) As String
        matrix1(0, 0) = "SUTEX"
        matrix1(0, 1) = "SUTEX"
        matrix1(0, 2) = "SUTEX"
        matrix1(1, 0) = "SUTEX"

        MsgBox(matrix1.GetLength(1))
        matrix1.GetUpperBound(0)



    End Sub

   

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = InputBox("PLEASE ENTER YOUR NAME ")
        Dim strsearch As String = InputBox("ENTER YOUR SEARCH STRING")
        'SEARCH A
        'MsgBox(InStr(str, "A"))
        Dim str1(19) As String
        str1 = Split(str, strsearch)
        Dim i As Integer = 0
        For i = 0 To str1.Length - 1
            MsgBox(str1(i))
        Next
        ReDim Preserve str1(100)
        MsgBox("NO OF OCCURENCE OF " & strsearch & " is " & str1.Length - 1)

        MsgBox("ARRAT STR1 " & str1.GetUpperBound(0))

        Dim armat(2, 2) As String
        MsgBox("ARMAT DIMENSION " & armat.GetUpperBound(1))


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox(Abs(-100))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox(Now)
        'FIND YOUR AGE IN NO. OF DAYS
        MsgBox(Now.ToUniversalTime)
        MsgBox(Now.ToString("dd-MMM-yyyy hh:mm:ss"))

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim str As String = "SUTEX"
        ' MsgBox("OUTPUT : " & CInt(str) + 11)

        Dim dec1 As Decimal = 11.1111
        Dim str1 As String = ""
        'MsgBox(dec1)
        'str = CType(dec1, String)
        MsgBox(IsNumeric(str))

        MsgBox("I AM OF TYPE " & TypeName(CType(dec1, String)))


    End Sub

    Private Sub btnCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollection.Click
        Dim clsybca3 As New Collection
        clsybca3.Add("SUTEX BANK COLLEGE ", "SBCCAS")
        clsybca3.Add("MCA COLLEGE ", "MCA")
        clsybca3.Add("MBA COLLEGE ", "MBA")
        clsybca3.Add("BCOM COLLEGE ", "BCOM")



        MsgBox(clsybca3.Item("SBCCAS"))
        MsgBox("TOTAL ITEMS IN COLLECTION ARE " & clsybca3.Count)
        Dim cou As Integer = 1
        For Each obj As String In clsybca3

            MsgBox("I AM ITEM NO : " & clsybca3.ToString & " NAME :   " & obj)
            cou += 1
        Next

        MsgBox("I AM FOUND " & clsybca3.Contains("SUTEX"))
        


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim sbccas As bcacollege
        sbccas.strstucount = 700
        sbccas.noofyears = 3
        sbccas.classroom = 20

        MsgBox(sbccas.classroom)
    End Sub

  
    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        MsgBox(Asc(InputBox("ENTER A CHARACTER")))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))
        MsgBox("ASC(A) is  : " & Asc("A"))

    End Sub

    Private Sub frmInbuiltFunctions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As String = "False"


        Dim swichflag As Boolean

        swichflag = Convert.ToBoolean(i)

        If swichflag = True Then
            MsgBox("FAN IS ON")
        Else
            MsgBox("FAN IS OFF")
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim str As String = InputBox("PLEASE ENTER YOUR DATE OF BIRTH IN MM/DD/YYYY")
        If IsDate(str) = True Then
            MsgBox("DATE IS CORRECT")
        Else
            MsgBox("DATE IS INCORRECT")
        End If


    End Sub
End Class
