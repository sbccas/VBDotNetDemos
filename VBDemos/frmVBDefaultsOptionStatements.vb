'Option Explicit Off'
'Option Strict Off
Option Compare Text
Option Infer Off
Public Class frmVBDefaultsOptionStatements

    Private Sub btnOptionExplicit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptionExplicit.Click

        'a = 10.5
        'b = 20
        'MsgBox(a / b)
        'c = a / b
        'MsgBox(c)
        'sutex = "MY NAME IS SBCCAS"

    End Sub

    Private Sub btnOPtStrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOPtStrict.Click
        Dim d As Integer
        Dim v As Double
        v = 10.5
        d = 3
        Dim s As Double
        s = (v / d)
        MsgBox(s)
    End Sub

    Private Sub btnOptCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptCompare.Click

        Dim str1, str2 As String
        str1 = "Sutex"
        str2 = "SUTEX"

        If str1 = str2 Then
            MsgBox("BOTH R BROTHER n SISTER")
        Else
            MsgBox("BOTH R ENEMIES")
        End If


    End Sub

    Private Sub btnOptInfere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptInfere.Click
        Dim str = "SUTEX"
        Dim str1 = "BCA"

        MsgBox(str.GetType)
        MsgBox(str1.GetType)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'boxing
        Dim i As String = "sutex"
        Dim myobjname As Object
        myobjname = i
        MsgBox(myobjname)
        'unboxing
        Dim j As String
        j = myobjname

        MsgBox(j)

    End Sub
End Class