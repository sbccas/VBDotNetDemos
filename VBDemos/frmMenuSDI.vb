Public Class frmMenuSDI

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("I AM CHILD MENU OPEN")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

   
    Private Sub frmMenuSDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Dim obj As New examsample
        DataGridView1.DataSource = obj.showdata("select * from tblEmployeeInfo")
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim obj As New examsample
        Dim i As Integer = 0

        i = obj.dataoperation("insert into tblEmployeeInfo values()")

        If i > 0 Then
            MsgBox("Insert Successful ")
        Else
            MsgBox("Error in Insert")
        End If
    End Sub
End Class