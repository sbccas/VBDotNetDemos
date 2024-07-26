

Public Class frmShowSpecialData

    Private Sub frmShowSpecialData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As New examsample
        DataGridView1.DataSource = obj.showdata("select * from tblEmployeeInfo where Department='SALES' and Salary < 10000")
    End Sub
End Class