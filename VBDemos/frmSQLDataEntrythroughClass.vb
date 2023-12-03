Public Class frmSQLDataEntrythroughClass

    Dim objname As New clsADOOperation
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim insertquery As String = "insert into hitlist values(" & txtRollNo.Text & ",'" & txtName.Text & "', '" & txtMobile.Text & "','" & txtEmail.Text & "','" & cmbCOurse.SelectedIndex + 1 & "','" & cmbCity.Text & "')"
        Dim i As Integer = 0

        i = objname.dataoperations(insertquery)

        If i > 0 Then
            MsgBox("INSERTED RECORDS " & i)
        Else
            MsgBox("ERROR IN INSERT OPERATION ")
        End If
        displayrecords("HOLIDAY")
    End Sub

    Private Sub frmSQLDataEntrythroughClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        displayrecords("ASC")
    End Sub

    Sub displayrecords(ByVal srtorder As String)
        If srtorder = "ASC" Then
            DataGridView1.DataSource = objname.showrecords("select * from hitlist Order By sid ASC")
        Else
            DataGridView1.DataSource = objname.showrecords("select * from hitlist Order By sid Desc")
        End If

        cmbCOurse.DataSource = objname.showrecords("select * from course_master")
        cmbCOurse.DisplayMember = "cname"
        cmbCOurse.ValueMember = "cid"
        Me.Text = "MS SQL Student Record Management (" & objname.showrecords("select * from hitlist").Rows.Count & ")"
    End Sub

    Private Sub btnRollNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollNo.Click
        txtRollNo.Text = objname.getnewid("select MAX(sid) from hitlist") + 1
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        DataGridView1.DataSource = objname.showrecords("select * from hitlist where sname like '" & txtName.Text & "%'")
    End Sub


    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        displaynavigation(0)
        

    End Sub
    Sub displaynavigation(ByVal recno As Integer)
        txtRollNo.Text = objname.showrecords("select * from hitlist").Rows(recno).Item(0).ToString()
        txtName.Text = objname.showrecords("select * from hitlist").Rows(recno).Item(1).ToString()
        txtMobile.Text = objname.showrecords("select * from hitlist").Rows(recno).Item(2).ToString()
        txtEmail.Text = objname.showrecords("select * from hitlist").Rows(recno).Item(3).ToString()
        cmbCOurse.SelectedIndex = objname.showrecords("select * from hitlist").Rows(recno).Item(4).ToString()
        cmbCity.SelectedItem = objname.showrecords("select * from hitlist").Rows(recno).Item(5).ToString()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        displaynavigation(objname.showrecords("select * from hitlist").Rows.Count - 1)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        displayrecords("ASC")
    End Sub

    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        displayrecords("ASC")
    End Sub

    Private Sub btnDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesc.Click
        displayrecords("NAMEIS KHAN")
    End Sub
End Class