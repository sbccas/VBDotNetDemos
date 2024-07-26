Public Class frmNavigatorDemo4SYBCA2

    Private Sub frmNavigatorDemo4SYBCA2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CertificateDataDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.CertificateDataDataSet.student)
        'TODO: This line of code loads data into the 'CertificateDataDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.CertificateDataDataSet.student)

    End Sub
End Class