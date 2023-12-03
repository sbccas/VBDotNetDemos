Public Class frmOOPSDemonstration

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myobj As New Class1
        MsgBox(myobj.jay(10))
        MsgBox(myobj.jay(10, 410))
        MsgBox(myobj.jay(10, 410, 420))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Dim myobj As New clsNilesh
        ' MsgBox(myobj.brijesh())
        ' MsgBox(myobj.brijesh(120))
        ' MsgBox(myobj.brijesh(120, 300))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myobj As New clsYagnesh
        MsgBox(myobj.brijesh(120, 300))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myobj As New clsYagnesh
        MsgBox(myobj.brijesh(10, 20))


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim myobj As New clsNilesh
        'Dim myobj1 As New clsAmit
        ' MsgBox(myobj1.allinone())

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim myobj As New clsYagnesh
        MsgBox(myobj.display)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim i As Integer = InputBox("ENTER YOUR AGE", )
        Dim urname As String = InputBox("ENTER YOUR NAME", )
        Dim myobj As New clsNilesh(urname, i)
        MsgBox(myobj.display)


    End Sub
    Protected Overrides Sub Finalize()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim myobj As New clsNilesh

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim myobj As New clsAmit

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim myobj As New clsJay
        MsgBox(myobj.study())
        MsgBox(myobj.study("TESTER"))
        MsgBox(myobj.study("DEVELOPER", 26))

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Dim myobj As New clsVivek
        Dim myobj As New clsJay
        myobj.Manoj()
        myobj.Akshay()


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim myobj As New clsJay
        MsgBox(myobj.bca())
    End Sub
End Class