Imports System.Data
Imports System.Data.SqlClient

Public Class frmSQLMasterChild
    Private Sub frmSQLMasterChild_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection("Data Source=X73\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
        Dim cmd As New SqlCommand("select * from course_master", cn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "cname"
        ComboBox1.ValueMember = "cid"

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cn As New SqlConnection("Data Source=X73\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
        Dim cmd As New SqlCommand("select * from hitlist where scourse=" & ComboBox1.SelectedIndex + 1 & ";", cn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class