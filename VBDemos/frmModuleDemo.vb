Public Class frmModuleDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        modTest.display()
    End Sub

    Private Sub frmModuleDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcDemo1.Timer1.Start()
    End Sub
End Class