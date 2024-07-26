Imports System.Data
Imports System.Data.SqlClient

Public Class clsADOOperationSYBCA4
    Dim cn As New SqlConnection("Data Source=X73\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
    Function fillgrid(ByVal strquery As String) As DataTable
        Dim cmd As New SqlCommand(strquery, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function

    Function dataoperations(ByVal srtquery As String) As Integer
        Dim i As Integer = 0
        Dim cmd As New SqlCommand(srtquery, cn)
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        i = cmd.ExecuteNonQuery()
        cn.Close()
        Return i
    End Function

    Function getnewrollno(ByVal strquery As String) As Integer
        Dim i As Integer = 0
        Dim cmd As New SqlCommand(strquery, cn)
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        i = cmd.ExecuteScalar
        cn.Close()
        Return i + 1
    End Function



End Class
