Public Class sampleadoform

    Private Sub sampleadoform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudinfoDataSet.student_master' table. You can move, or remove it, as needed.
        Me.Student_masterTableAdapter.Fill(Me.StudinfoDataSet.student_master)

    End Sub
End Class