Imports System.Data.SqlClient
Imports System.Data
Public Class frmDataEntry1
    Dim cn As New SqlConnection("Data Source=X73\SQLEXPRESS;Initial Catalog=DEMOS.MDF;Persist Security Info=True;User ID=SYBCA3;Password=sybca3;Connect Timeout=60")
    Dim maxno As Integer
    Dim ds As DataSet
    
    Private Sub frmDataEntry1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshgrid1("Desc")

        UcDemo1.Timer1.Start()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim strquery As String = "insert into hitlist values(" & txtRollNo.Text & ",'" & txtName.Text & "', '" & txtMobile.Text & "','" & txtEmail.Text & "','" & cmbCOurse.SelectedIndex + 1 & "','" & cmbCity.Text & "')"
        'MsgBox(strquery)
        Dim cmd As New SqlCommand(strquery, cn)
        Dim i As Integer = 0
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        i = cmd.ExecuteNonQuery()
        cn.Close()
        If i > 0 Then
            MsgBox(i & " Record Insert Successful")
        Else
            MsgBox("Insert Not Successful")
        End If

    End Sub

    Public Sub refreshgrid1(ByVal sortord As String)
        Try
            Dim strquery As String = "select * from hitlist Order By sid " & sortord
            Dim cmd As New SqlCommand(strquery, cn)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "hitlist")
            DataGridView1.DataSource = ds.Tables(0)
            Me.Text = "MS SQL Student Management System (" & ds.Tables(0).Rows.Count & ")"
            maxno = ds.Tables(0).Rows.Count

            'code for only fill combobox
            Dim strquery1 As String = "select * from course_master"
            Dim cmd1 As New SqlCommand(strquery1, cn)
            Dim da1 As New SqlDataAdapter(cmd1)
            da1.Fill(ds, "course_master")
            ComboBox1.DataSource = ds.Tables("course_master")
            ComboBox1.DisplayMember = "cname"
            ComboBox1.ValueMember = "cid"

        Catch ex As Exception

        End Try
        


    End Sub

    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        refreshgrid1("Asc")
    End Sub

    Private Sub btnDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesc.Click
        refreshgrid1("Desc")
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim strquery As String = "update hitlist set sname='" & txtName.Text.Trim & "',smobile='" & txtMobile.Text.Trim & "',semail='" & txtEmail.Text.Trim & "',scourse=" & cmbCOurse.SelectedIndex + 1 & ",scity='" & cmbCity.SelectedItem.ToString.Trim & "' where sid=" & txtRollNo.Text & ""
        Dim cmd As New SqlCommand(strquery, cn)
        MsgBox(strquery)
        Dim i As Integer = 0
        cn.Open()
        i = cmd.ExecuteNonQuery
        cn.Close()
        If i > 0 Then
            MsgBox("Updated " & i & " Records")
        Else
            MsgBox("Failed to Update")
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim myobj As New clsADOOperation
        DataGridView1.DataSource = myobj.showrecords("select * from hitlist")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnFrilterGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrilterGrid.Click

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

    End Sub

    Private Sub btnRollNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollNo.Click

    End Sub
End Class