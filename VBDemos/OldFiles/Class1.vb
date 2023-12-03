Imports System.Data
Imports System.Data.SqlClient
Public Class Class1

    Dim cn As New SqlConnection("Data Source=X73\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
    'field
    'element
    Dim i As Integer = 55
    Private j As Integer = 110
    'field
    Dim strname As String
    Public Property tyre As String
        Get
            Return strname
        End Get
        Set(ByVal value As String)
            strname = value
        End Set
    End Property
    Public WriteOnly Property sybca1
        Set(ByVal value)

        End Set
    End Property
    Public ReadOnly Property sybca2
        Get
            Return "HELLO"
        End Get
    End Property


    Public Function getrecords(ByVal qstr As String) As DataTable
        Dim dt As New DataTable

        Dim cmd As New SqlCommand(qstr, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(dt)
        Return dt
    End Function

    Public Function executerecords(ByVal qstr1 As String) As Integer
        Dim cmd As New SqlCommand(qstr1, cn)
        Dim i As Integer = 0
        cn.Open()
        i = cmd.ExecuteNonQuery
        cn.Close()
        Return i
    End Function

    Public Function jay(ByVal a As Integer) As Integer
        Return a
    End Function
    Public Function jay(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function
    Public Function jay(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return a + b + c
    End Function
    ' MustOverride Sub dhaval(ByVal a As Integer)
    'MustOverride Sub hiren()

End Class


