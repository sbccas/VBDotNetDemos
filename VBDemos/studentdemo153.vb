Public Class studentdemo153

    Private Sub studentdemo153_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudinfoDataSet1.student_master' table. You can move, or remove it, as needed.
        Me.Student_masterTableAdapter.Fill(Me.StudinfoDataSet1.student_master)

    End Sub
End Class