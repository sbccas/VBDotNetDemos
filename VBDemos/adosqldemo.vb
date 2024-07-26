Imports System.Data
Imports System.Data.SqlClient
Public Class adosqldemo
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=F:\HPP Personal\Dropbox\Study Material\ASP.NET\AllExamples\SYBCADIV1\VBDemos\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim pntr, maxno As Integer

    Private Sub adosqldemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'process
        gridrefresh()
        clearall()

    End Sub
    Sub clearall()
        txtsid.Text = ""
        txtsname.Text = ""
        txtsmob.Text = ""
        txtsemail.Text = ""
        txtcourse.Text = ""
        txtcity.Text = ""

    End Sub
    Public Sub gridrefresh()
        Dim selectquery As String = "select * from student;"
        Dim cmd As New SqlCommand(selectquery, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        maxno = ds.Tables(0).Rows.Count - 1
        If ds.Tables(0).Rows.Count > 0 Then
            pntr = 0
        Else
            MsgBox("EMPTY RECORDSET")
        End If

        DataGridView1.DataSource = ds.Tables(0)
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        pntr = 0
        display()
        gridrefresh()

    End Sub
    Sub display()
        'connection global
        Dim selectquery As String = "select * from student"
        Dim cmd As New SqlCommand(selectquery, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            txtsid.Text = ds.Tables(0).Rows(pntr).Item(0).ToString
            txtsname.Text = ds.Tables(0).Rows(pntr).Item(1).ToString
            txtsmob.Text = ds.Tables(0).Rows(pntr).Item(2).ToString
            txtsemail.Text = ds.Tables(0).Rows(pntr).Item(3).ToString
            txtcourse.Text = ds.Tables(0).Rows(pntr).Item(4).ToString
            txtcity.Text = ds.Tables(0).Rows(pntr).Item(5).ToString
        End If
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        'PROCESS
        'CONNECTION ---CONNECTION STRING
        'QUERY === >  INSERT ON STUDENT_MASTER
        'COMMAND  CONNECTION
        'METHOD ---> EXCECUTE NON QUERY 
        'OPERATION SUCCESSFUL OR UNSUCCESSFUL
        'RESULT PRINT

        Dim insertquery As String = "insert into student values(" & txtsid.Text & ", '" & txtsname.Text & "', '" & txtsmob.Text & "','" & txtsemail.Text & "','" & txtcourse.Text & "','" & txtcity.Text & "' );"
        Dim cmd As New SqlCommand()
        ' OPEN CONNECTION ----> OPEN  --->> ERROR 
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.CommandText = insertquery
        cmd.Connection = cn
        Dim counter As Integer = 0
        counter = cmd.ExecuteNonQuery()
        cn.Close()
        If counter > 0 Then
            MsgBox(counter & " RECORD INSERTED")
            clearall()
        Else
            MsgBox("RECORD NOT INSERTED")
        End If
        gridrefresh()


    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'PROCESS
        'CONNECTION ---CONNECTION STRING
        'QUERY === >  UPDATE ON STUDENT_MASTER
        'COMMAND  CONNECTION
        'METHOD ---> EXCECUTE NON QUERY 
        'OPERATION SUCCESSFUL OR UNSUCCESSFUL
        'RESULT PRINT

        Dim updatequery As String = "update student set sname='" & txtsname.Text & "',smobile='" & txtsmob.Text & "',semail='" & txtsemail.Text & "',scourse='" & txtcourse.Text & "',scity='" & txtcity.Text & "' where sid=" & txtsid.Text & ";"
        Dim cmd As New SqlCommand()
        ' OPEN CONNECTION ----> OPEN  --->> ERROR 
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.CommandText = updatequery
        cmd.Connection = cn
        Dim counter As Integer = 0
        counter = cmd.ExecuteNonQuery()
        cn.Close()
        If counter > 0 Then
            MsgBox(counter & " RECORD UPDATED")
            clearall()
        Else
            MsgBox("RECORD NOT UPDATED")
        End If
        gridrefresh()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'PROCESS
        'CONNECTION ---CONNECTION STRING
        'QUERY === >  DELETE ON STUDENT_MASTER WHERE CLAUSE
        'COMMAND  CONNECTION
        'METHOD ---> EXCECUTE NON QUERY 
        'OPERATION SUCCESSFUL OR UNSUCCESSFUL
        'RESULT PRINT

        Dim deletequery As String = "delete from student where sid=" & txtsid.Text & ";"
        Dim cmd As New SqlCommand()
        ' OPEN CONNECTION ----> OPEN  --->> ERROR 
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.CommandText = deletequery
        cmd.Connection = cn
        Dim counter As Integer = 0
        counter = cmd.ExecuteNonQuery()
        cn.Close()
        If counter > 0 Then
            MsgBox(counter & " RECORD DELETED")
            clearall()
        Else
            MsgBox("RECORD NOT DELETED")
        End If
        gridrefresh()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'cn oject declared global
        Dim searchquery As String = "select * from student where sname like '" & txtsname.Text & "%';"
        Dim cmd As New SqlCommand(searchquery, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader
        Dim cou As Integer = 1
        Label2.Text = ""
        If dr.HasRows Then
            While dr.Read
                Label2.Text += cou & " RECORD FOUND : " & dr.Item(1).ToString & " " & vbNewLine
                cou = cou + 1
            End While
        Else
            Label2.Text = "NO RECORDS MATCH"
        End If
        dr.Close()
        cn.Close()
    End Sub


    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        pntr = maxno
        display()

    End Sub


    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        pntr = 0
        display()


    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        If pntr > 0 Then
            pntr -= 1
            display()
        Else
            MsgBox("THIS IS FIRST RECORD")
        End If
    End Sub


    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If pntr < maxno Then
            pntr = pntr + 1
            display()
        Else
            MsgBox("THIS IS LAST RECORD")
        End If
    End Sub

    Private Sub btnGetnewID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetnewID.Click
        'EXECUTE SCALAR + AGGREGATE FUNCTION (AVG , MIN , MAX, SUM , COUNT)  
        Dim newidquery As String = "select max(sid) from student"
        Dim cmd As New SqlCommand(newidquery, cn)
        Dim ds As New DataSet
        Dim newid As Integer = 0
        cn.Open()
        newid = cmd.ExecuteScalar()
        cn.Close()
        newid = newid + 1

        clearall()
        txtsid.Text = newid
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        'cn oject declared global
        Dim searchquery As String = "select * from student where sname like '" & txtsname.Text & "%';"
        Dim cmd As New SqlCommand(searchquery, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        If dr.HasRows Then
            dt.Load(dr)
        End If
        dr.Close()
        cn.Close()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Or ComboBox1.SelectedIndex = 0 Then
        Else
            Dim searchquery As String = "select * from student where scourse='" & ComboBox1.SelectedItem & "';"
            Dim cmd As New SqlCommand(searchquery, cn)
            Dim dr As SqlDataReader
            cn.Open()
            dr = cmd.ExecuteReader
            Dim dt As New DataTable
            If dr.HasRows Then
                dt.Load(dr)
            End If
            dr.Close()
            cn.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub
End Class