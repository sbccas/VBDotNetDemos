Imports System.Data
Imports System.Data.SqlClient
Public Class clsADOOperation
    Dim cn As New SqlConnection("Data Source=X73\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
    Dim maxno As Integer
    Dim ds As DataSet

    Public Function showrecords(ByVal strquery As String) As DataTable
        Try
            Dim cmd As New SqlCommand(strquery, cn)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception

        End Try
    End Function

    Public Function dataoperations(ByVal strquery As String) As Integer
        Try
            Dim cmd As New SqlCommand(strquery, cn)
            Dim i As Integer = 0
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            i = cmd.ExecuteNonQuery()
            cn.Close()
            Return i
        Catch ex As Exception
        End Try
    End Function

    Function getnewid(ByVal strquery As String) As Integer
        Try
            Dim cmd As New SqlCommand(strquery, cn)
            Dim i As Integer = 0
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            i = cmd.ExecuteScalar
            cn.Close()
            Return i
        Catch ex As Exception
        End Try
    End Function

    

End Class
