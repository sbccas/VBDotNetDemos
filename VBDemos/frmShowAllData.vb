Public Class frmShowAllData

    Private Sub frmShowAllData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamDataSet.tblEmployeeInfo' table. You can move, or remove it, as needed.
        Me.TblEmployeeInfoTableAdapter.Fill(Me.ExamDataSet.tblEmployeeInfo)

    End Sub
End Class