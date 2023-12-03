Imports System.Data
Imports System.Data.SqlClient

Public Class clsADO2017

    Dim cn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Public Function displayrecords(ByVal qstr As String) As DataTable
        cmd = New SqlCommand(qstr)
        cmd.Connection = cn
        da.SelectCommand = cmd
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Class
