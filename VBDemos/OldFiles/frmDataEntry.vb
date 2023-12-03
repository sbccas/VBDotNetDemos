Imports System.Data
Imports System.Data.SqlClient
Public Class frmDataEntry
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
    Public Sub refreshgrid()
        Dim cmd As New SqlCommand("select * from hitlist order by id desc", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    '   Public Sub clearall()
    '       txtRollNo.Text = ""
    '       txtName.Text = ""
    '       txtEmail.Text = ""
    '       txtMobile.Text = ""
    '       cmbCity.SelectedIndex = 0
    '       cmbCOurse.SelectedIndex = 0
    '   End Sub
    Private Sub frmDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshgrid()
    End Sub
    '   Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

    '       Dim cmd As New SqlCommand("select * from hitlist where id=" & txtRollNo.Text, cn)
    '       Dim da As New SqlDataAdapter(cmd)
    '       Dim ds As New DataSet
    '       da.Fill(ds)
    '       txtName.Text = ds.Tables(0).Rows(0).Item(1)
    '       txtMobile.Text = ds.Tables(0).Rows(0).Item(2)
    '       txtEmail.Text = ds.Tables(0).Rows(0).Item(3)
    '       cmbCity.SelectedItem = ds.Tables(0).Rows(0).Item(4)
    '       cmbCOurse.SelectedIndex = ds.Tables(0).Rows(0).Item(5)
    '   End Sub
    '   Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    '       'Dim strinsertquery As String = "insert into hitlist values (" & txtRollNo.Text & ",'" & txtName.Text & "','" & txtEmail.Text & "','" & txtMobile.Text & "','" & cmbCity.SelectedItem & "','" & cmbCOurse.SelectedItem & "')"
    '       Dim str As String = "delete from hitlist where id=" & txtRollNo.Text
    '       MsgBox(str)
    '       Dim cmd As New SqlCommand(str, cn)
    '       Dim i As Integer = 0
    '       cn.Open()
    '       i = cmd.ExecuteNonQuery()
    '       If i > 0 Then
    '           MsgBox("Deleted " & i & " Records")
    '       Else
    '           MsgBox("NOT SUCCESSFUL")
    '       End If
    '       refreshgrid()
    '   End Sub

    '   Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

    '       'Dim strinsertquery As String = "insert into hitlist values (" & txtRollNo.Text & ",'" & txtName.Text & "','" & txtEmail.Text & "','" & txtMobile.Text & "','" & cmbCity.SelectedItem & "','" & cmbCOurse.SelectedItem & "')"
    '       Dim str As String = "UPDATE hitlist SET name='" & txtName.Text & "',email='" & _
    'txtEmail.Text & "',mobile = '" & txtMobile.Text & "',city='" & cmbCity.SelectedItem & _
    '"',course=" & cmbCOurse.SelectedIndex & " WHERE id=" & txtRollNo.Text & ""
    '       MsgBox(str)
    '       Dim cmd As New SqlCommand(str, cn)
    '       Dim i As Integer = 0
    '       cn.Open()
    '       i = cmd.ExecuteNonQuery()
    '       If i > 0 Then
    '           MsgBox("Updated " & i & " Record", MsgBoxStyle.Information, "UPDATE")
    '       Else
    '           MsgBox("NOT SUCCESSFUL")
    '       End If
    '       refreshgrid()
    '   End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        'Dim strinsertquery As String = "insert into hitlist values (" & txtRollNo.Text & ",'" & txtName.Text & "','" & txtEmail.Text & "','" & txtMobile.Text & "','" & cmbCity.SelectedItem & "','" & cmbCOurse.SelectedItem & "')"


        Dim str As String = "insert into hitlist values(" & txtRollNo.Text & ",'" & txtName.Text & "' ,'" & txtEmail.Text & "','" & txtMobile.Text & "','" & cmbCity.SelectedItem & "'," & cmbCOurse.SelectedIndex + 1 & ")"
        '' MsgBox(str)
        'Dim cmd As New SqlCommand(str, cn)
        'Dim i As Integer = 0
        'cn.Open()
        'i = cmd.ExecuteNonQuery()
        'cn.Close()
        'If i > 0 Then
        '    MsgBox("SUCCESSFUL " & i)
        'Else
        '    MsgBox("NOT SUCCESSFUL")
        'End If

        Dim myobj As New Class1
        Dim i As Integer = 0
        i = myobj.executerecords(str)
        If i > 0 Then
            MsgBox("INSERT SUCCESFUL")
        Else
            MsgBox("NOT SUCCESSFUL")
        End If


        refreshgrid()
    End Sub

    '   Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click

    '       Dim cmd As New SqlCommand("select * from hitlist order by id Asc", cn)
    '       Dim da As New SqlDataAdapter(cmd)
    '       Dim ds As New DataSet
    '       da.Fill(ds, "studinfo")
    '       DataGridView1.DataSource = ds.Tables(0)
    '   End Sub

    '   Private Sub btnDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesc.Click

    '       Dim cmd As New SqlCommand("select * from hitlist order by id Desc", cn)
    '       Dim da As New SqlDataAdapter(cmd)
    '       Dim ds As New DataSet
    '       da.Fill(ds, "studinfo")
    '       DataGridView1.DataSource = ds.Tables(0)
    '   End Sub

    '   Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    '       Dim str As String = "Select * where course_id =" & ComboBox1.SelectedValue
    '   End Sub



    Private Sub btnRollNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollNo.Click
        Dim CN As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=sybcaall;Integrated Security=True")
        Dim CMD As New SqlCommand("SELECT MAX(id) from stud", CN)
        Dim i As Integer = 0
        CN.Open()
        i = CMD.ExecuteScalar
        CN.Close()
        txtRollNo.Text = i + 1




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("i am first")
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click


        Dim cmd As New SqlCommand()
        cmd.CommandText = "select id,name,email,mobile from hitlist where name like '" & txtName.Text & "%'"
        cmd.Connection = cn
        cn.Open()
        Dim dr As SqlDataReader

        dr = cmd.ExecuteReader()
        While dr.Read

        End While
        dr.Close()
        cn.Close()

        '       Dim ds As New DataSet
        '       da.Fill(ds, "studinfo")
        '       DataGridView1.DataSource = ds.Tables(0)
    End Sub


    Private Sub btnFrilterGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrilterGrid.Click
        Dim cmd As New SqlCommand()
        cmd.CommandText = "select id,name,email,mobile from hitlist " & _
                          "where name like '" & txtName.Text & "%'"
        cmd.Connection = cn
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class