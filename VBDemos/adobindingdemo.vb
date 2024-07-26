Public Class adobindingdemo

    Private Sub adobindingdemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Database1DataSet1.student)

    End Sub
End Class