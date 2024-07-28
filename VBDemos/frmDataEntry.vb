Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class frmDataEntry
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
    Dim cn1 As OleDbConnection
    Dim ds1 As DataSet
    Dim maxno, inc As Integer
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Dim dbFile As String = "Z:\studinfo.mdb"
        If (File.Exists(dbFile)) Then
            cn1 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\studinfo.mdb")
        Else
            cn1 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\studinfo.mdb")
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Public Sub refreshgrid()
    '    Dim cmd As New SqlCommand("select * from hitlist order by id desc", cn)
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim ds As New DataSet
    '    da.Fill(ds)
    '    DataGridView1.DataSource = ds.Tables(0)
    'End Sub
    '   Public Sub clearall()
    '       txtRollNo.Text = ""
    '       txtName.Text = ""
    '       txtEmail.Text = ""
    '       txtMobile.Text = ""
    '       cmbCity.SelectedIndex = 0
    '       cmbCOurse.SelectedIndex = 0
    '   End Sub

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

        '    'Dim strinsertquery As String = "insert into hitlist values (" & txtRollNo.Text & ",'" & txtName.Text & "','" & txtEmail.Text & "','" & txtMobile.Text & "','" & cmbCity.SelectedItem & "','" & cmbCOurse.SelectedItem & "')"


        '    Dim str As String = "insert into hitlist values(" & txtRollNo.Text & ",'" & txtName.Text & "' ,'" & txtEmail.Text & "','" & txtMobile.Text & "','" & cmbCity.SelectedItem & "'," & cmbCOurse.SelectedIndex + 1 & ")"
        '    '' MsgBox(str)
        '    'Dim cmd As New SqlCommand(str, cn)
        '    'Dim i As Integer = 0
        '    'cn.Open()
        '    'i = cmd.ExecuteNonQuery()
        '    'cn.Close()
        '    'If i > 0 Then
        '    '    MsgBox("SUCCESSFUL " & i)
        '    'Else
        '    '    MsgBox("NOT SUCCESSFUL")
        '    'End If

        '    Dim myobj As New Class1
        '    Dim i As Integer = 0
        '    i = myobj.executerecords(str)
        '    If i > 0 Then
        '        MsgBox("INSERT SUCCESFUL")
        '    Else
        '        MsgBox("NOT SUCCESSFUL")
        '    End If


        '  refreshgrid()
        'End Sub

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

        'beginner code for insert



        'Dim strquery As String = "insert into student_master values(1,'SUTEX BCA', '9879879870','sbccas.amroli@gmail.com','BCA','SURAT')"
        Dim strquery As String = "insert into student_master values(" & txtRollNo.Text & ",'" & txtName.Text & "', '" & txtMobile.Text & "','" & txtEmail.Text & "','" & cmbCOurse.Text & "','" & cmbCity.Text & "')"
        'MsgBox(strquery)
        Dim cmd As New OleDbCommand(strquery, cn1)
        Dim i As Integer = 0
        If cn1.State = ConnectionState.Open Then
            cn1.Close()
        End If

        cn1.Open()
        i = cmd.ExecuteNonQuery()
        cn1.Close()
        If i > 0 Then
            MsgBox(i & " Record Insert Successful")
        Else
            MsgBox("Insert Not Successful")
        End If

        refreshgrid1("Desc", "BBA','BCA','BCOM")
        clearall()



    End Sub



    Private Sub btnRollNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollNo.Click
        clearall()
        'Dim CN As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=sybcaall;Integrated Security=True")
        'Dim CMD As New SqlCommand("SELECT MAX(id) from stud", CN)
        'Dim i As Integer = 0
        'CN.Open()
        'i = CMD.ExecuteScalar
        'CN.Close()
        'txtRollNo.Text = i + 1
        If cn1.State = ConnectionState.Open Then
            cn1.Close()
        End If

        Dim cmd1 As New OleDbCommand("select count(sid) from student_master", cn1)
        Dim countrec As Integer = 0
        cn1.Open()
        countrec = cmd1.ExecuteScalar()
        cn1.Close()
        Dim maxno As Integer = 0
        If countrec > 0 Then

            Dim cmd As New OleDbCommand("select MAX(sid) from student_master", cn1)

            cn1.Open()
            maxno = cmd.ExecuteScalar()
            cn1.Close()
            txtRollNo.Text = maxno + 1
        Else
            txtRollNo.Text = 1
        End If




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("i am first")
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        'Dim strquery As String = "insert into student_master values(1,'SUTEX BCA', '9879879870','sbccas.amroli@gmail.com','BCA','SURAT')"
        Dim strquery As String = "UPDATE student_master SET sname='" & txtName.Text & "',semail='" & txtEmail.Text & "',smobile = '" & txtMobile.Text & "',scity='" & cmbCity.SelectedItem & "',scourse='" & cmbCOurse.SelectedItem & "' WHERE sid=" & txtRollNo.Text & ""

        'Dim updatequery As String = ""

        'MsgBox(strquery)
        Dim cmd As New OleDbCommand(strquery, cn1)
        Dim i As Integer = 0
        If cn1.State = ConnectionState.Open Then
            cn1.Close()
        End If

        cn1.Open()
        i = cmd.ExecuteNonQuery()
        cn1.Close()
        If i > 0 Then
            MsgBox("Update Successful")
        Else
            MsgBox("Update Not Successful")
        End If
        refreshgrid1("Desc", "BBA','BCA','BCOM")
        clearall()

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        refreshgrid1("Asc", "BBA','BCA','BCOM")


    End Sub

    Public Sub refreshgrid1(ByVal sortord As String, Optional ByVal whereclausepara As String = "")

        Dim strquery As String = "select * from Student_master where scourse in ('" & whereclausepara & "')  Order By sid " & sortord
        Dim cmd As New OleDbCommand(strquery, cn1)
        Dim da As New OleDbDataAdapter(cmd)
        ds1 = New DataSet
        da.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        Me.Text = "Student Management System (" & ds1.Tables(0).Rows.Count & ")"
        maxno = ds1.Tables(0).Rows.Count
    End Sub




    Private Sub btnDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesc.Click
        refreshgrid1("Desc", "BBA','BCA','BCOM")
    End Sub

    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        refreshgrid1("Asc", "BBA','BCA','BCOM")
    End Sub

    Public Sub clearall()
        txtRollNo.Text = ""
        txtName.Text = ""
        txtEmail.Text = ""
        txtMobile.Text = ""
        cmbCity.SelectedIndex = 0
        cmbCOurse.SelectedIndex = 0

    End Sub

    Private Sub frmDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshgrid1("Desc", "BBA','BCA','BCOM")
        clearall()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim strquery As String = "delete from student_master where sid=" & txtRollNo.Text & ""
        Dim cmd As New OleDbCommand(strquery, cn1)
        Dim i As Integer = 0
        If cn1.State = ConnectionState.Open Then
            cn1.Close()
        End If
        cn1.Open()
        i = cmd.ExecuteNonQuery()
        cn1.Close()
        If i > 0 Then
            MsgBox(i & " Record(s) Deleted...!")
        Else
            MsgBox("Delete not Successful...!")
        End If

        refreshgrid1("Desc", "BBA','BCA','BCOM")
        clearall()

    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim data As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtRollNo.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        txtMobile.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        txtEmail.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
        cmbCOurse.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
        cmbCity.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
    End Sub
    Public Sub showrecord()

    End Sub

    Private Sub btnFrilterGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrilterGrid.Click
        Dim cmd As New OleDbCommand
        cmd.CommandText = "select * from student_master " &
                          "where sname like '" & txtName.Text & "%'"

        cmd.Connection = cn1
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MessageBox.Show("Are You Sure...!", "Exit Application", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub frmDataEntry_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are You Sure...!", "Exit Application", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then

        Else
            e.Cancel = True
        End If

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim ik As Integer = 1
        'For ik = 6 To 100
        '    Dim cn2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\studinfo.mdb")
        '    Dim strquery As String = "insert into student_master values(" & ik & ",'" & txtName.Text & "','" & txtMobile.Text & "','" & txtEmail.Text & "','" & cmbCOurse.SelectedText & "','" & cmbCity.SelectedText & "')"
        '    Dim cmd2 As New OleDbCommand(strquery, cn2)
        '    Dim counter As Integer = 0

        '    cn2.Open()
        '    counter = cmd2.ExecuteNonQuery()
        '    cn2.Close()

        '    If counter > 0 Then
        '        '    MsgBox("OPERATION SUCCESSFUL")
        '    Else
        '        '   MsgBox("OPERATION FAIL")
        '    End If


        'Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strquery As String = "select * from Student_master where sname like '" & txtName.Text & "%'"
        Dim cmd As New OleDbCommand(strquery, cn1)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        If inc < 0 Then
            MsgBox("Empty Dataset")
        Else
            inc = 0
            displayrec()
        End If
        displayrec()
    End Sub

    Public Sub displayrec()
        If ds1.Tables(0).Rows.Count > 0 Then
            With ds1.Tables(0).Rows(inc)
                txtRollNo.Text = .Item(0).ToString
                txtName.Text = .Item(1).ToString
                txtMobile.Text = .Item(2).ToString
                txtEmail.Text = .Item(3).ToString
                cmbCOurse.Text = .Item(4).ToString
                cmbCity.Text = .Item(5).ToString
            End With
        Else
            clearall()
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        If inc < 0 Then
            MsgBox("Empty Dataset")
        Else
            inc = maxno - 1
            displayrec()
        End If
        displayrec()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If inc = 0 Then
            MsgBox("First Record")
        Else
            inc = inc - 1
            displayrec()
        End If

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If inc = maxno - 1 Then
            MsgBox("Last Record")
        Else
            inc += 1
            displayrec()
        End If
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        refreshgrid1("Desc", ComboBox1.SelectedItem.ToString)
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Dim cmd As New SqlCommand()
        cmd.CommandText = "select sid,sname,semail,smobile from hitlist where sname like '" & txtName.Text & "%'"
        cmd.Connection = cn
        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read
            Dim dt = New DataTable()
            dt.Load(dr)
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        End While
        dr.NextResult()
        dr.Close()
        cn.Close()

        '       Dim ds As New DataSet
        '       da.Fill(ds, "studinfo")
        '       DataGridView1.DataSource = ds.Tables(0)
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class