Imports System.Data
Imports System.Data.OleDb
Public Class adodemowithcode

    Private Sub adodemowithcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PROCESS
        '1.CONNECTION  
        '2.QUERY -->  SELECT
        '3.COMMAND  ---> executenonquery
        ' ------>  executescalar
        '  ------> executereader
        '4. OR DATAADAPTER
        '5. DATAGRIDVIEW
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\studinfo.mdb")
        Dim strquery As String = "select * from student_master"
        Dim cmd As New OleDbCommand(strquery, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)





       


    End Sub
End Class