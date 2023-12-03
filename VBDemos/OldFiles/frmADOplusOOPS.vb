Public Class frmADOplusOOPS

    Private Sub frmADOplusOOPS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myobj As New clsADO2017
        DataGridView1.DataSource = myobj.displayrecords("select * from hitlist")

    End Sub
End Class