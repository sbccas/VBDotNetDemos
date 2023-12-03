Imports System.Data
Imports System.Data.OleDb
Public Class adoinsertdemoForm1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'PROCESS
        'CONNECTION ---CONNECTION STRING
        'QUERY === >  INSERT ON STUDENT_MASTER
        'COMMAND  CONNECTION
        'METHOD ---> EXCECUTE NON QUERY 
        'OPERATION SUCCESSFUL OR UNSUCCESSFUL
        'RESULT PRINT
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\studinfo.mdb")
        Dim insertquery As String = "insert into student_master values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox2.Text & "' );"
        Dim cmd As New OleDbCommand()
        cn.Open()
        cmd.CommandText = insertquery
        cmd.Connection = cn
        Dim counter As Integer = 0
        counter = cmd.ExecuteNonQuery()
        cn.Close()
        If counter > 0 Then
            MsgBox(counter & " RECORD INSERTED")
        Else
            MsgBox("RECORD NOT INSERTED")
        End If
        gridrefresh()

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'PROCESS
        'CONNECTION ---CONNECTION STRING
        'QUERY === >  UPDATE ON STUDENT_MASTER
        'COMMAND  CONNECTION
        'METHOD ---> EXCECUTE NON QUERY 
        'OPERATION SUCCESSFUL OR UNSUCCESSFUL
        'RESULT PRINT
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\studinfo.mdb")
        Dim updatequery As String = "update student_master set sname= '" & TextBox2.Text & "', smobile= '" & TextBox2.Text & "', semail= '" & TextBox2.Text & "', scourse= '" & TextBox2.Text & "', scity= '" & TextBox2.Text & "' where sid=" & TextBox1.Text & ";"
        Dim cmd As New OleDbCommand()
        cn.Open()
        cmd.CommandText = updatequery
        cmd.Connection = cn
        Dim counter As Integer = 0
        counter = cmd.ExecuteNonQuery()
        cn.Close()
        If counter > 0 Then
            MsgBox(counter & " RECORD UPDATED")
        Else
            MsgBox("UPDATE ERROR ")
        End If
        gridrefresh()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'PROCESS
        'CONNECTION ---CONNECTION STRING
        'QUERY === >  DELETE ON STUDENT_MASTER
        'COMMAND  CONNECTION
        'METHOD ---> EXCECUTE NON QUERY 
        'OPERATION SUCCESSFUL OR UNSUCCESSFUL
        'RESULT PRINT
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\studinfo.mdb")
        Dim deletequery As String = "delete from student_master where sid= " & TextBox1.Text & ";"
        Dim cmd As New OleDbCommand()
        cn.Open()
        cmd.CommandText = deletequery
        cmd.Connection = cn
        Dim counter As Integer = 0
        counter = cmd.ExecuteNonQuery()
        cn.Close()
        If counter > 0 Then
            MsgBox(counter & " RECORD DELETED")
        Else
            MsgBox("DELETE ERROR ")
        End If
        gridrefresh()
    End Sub

    Private Sub adoinsertdemoForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridrefresh()
    End Sub

    Public Sub gridrefresh()
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