Imports System.Data
Imports System.Data.SqlClient

Public Class frmSearchDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
        Dim cmd As New SqlCommand()
        Dim dr As SqlDataReader
        cmd.Connection = cn
        Dim str As String
        If CheckBox1.Checked Then
            str = "select * from reg_details where emailid NOT like '%" & TextBox1.Text & "%'"
        Else
            str = "select * from reg_details where emailid like '%" & TextBox1.Text & "%'"
        End If
        ListBox1.Items.Clear()
        cmd.CommandText = str
        cn.Open()
        dr = cmd.ExecuteReader
        DataGridView1.Columns.Add("SNAME", "STUDENT NAME")
        While dr.Read
            ListBox1.Items.Add(dr.Item(3).ToString())


            DataGridView1.Rows.Add(dr.Item(3))

        End While
        cn.Close()

        

    End Sub
End Class
