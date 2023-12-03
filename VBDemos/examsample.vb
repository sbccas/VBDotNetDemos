Imports System.Data
Imports System.Data.SqlClient

Public Class examsample

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=exam;Integrated Security=True")

    Function showdata(ByVal strquery As String) As DataTable
        Dim cmd As New SqlCommand(strquery, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function

    Function dataoperation(ByVal strquery As String) As Integer
        Dim i As Integer
        Dim cmd As New SqlCommand(strquery, cn)
        cn.Open()
        i = cmd.ExecuteNonQuery
        cn.Close()
        Return i

    End Function
End Class
