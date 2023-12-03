Public Class frmNavigationDemo

    Private Sub frmNavigationDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SybcaallDataSet.stud' table. You can move, or remove it, as needed.
        Me.StudTableAdapter.Fill(Me.SybcaallDataSet.stud)

    End Sub
End Class