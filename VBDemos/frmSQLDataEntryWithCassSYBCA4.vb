
Public Class frmSQLDataEntryWithCassSYBCA4
    Dim objname As New clsADOOperationSYBCA4
    Dim recno As Integer = 0
    Private Sub frmSQLDataEntryWithCassSYBCA4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getrecordsingrid("ASC")



    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim i As Integer = objname.dataoperations("insert into hitlist " & _
        "values(" & txtRollNo.Text & ",'" & txtName.Text & "', '" & _
        txtMobile.Text & "','" & txtEmail.Text & "','" & cmbCOurse.SelectedIndex + 1 & "','" & _
        cmbCity.Text & "')")
        If i > 0 Then
            MsgBox("OPERATION SUCCESSFUL")
        Else
            MsgBox("OPERATION UN - SUCCESSFUL")
        End If
        getrecordsingrid("Desc")
    End Sub
    Sub getrecordsingrid(ByVal srshyam As String)
        DataGridView1.DataSource = objname.fillgrid("select * from hitlist Order By sid " & srshyam)

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        getrecordsingrid("ASC")
    End Sub

    Private Sub btnRollNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollNo.Click
        txtRollNo.Text = objname.getnewrollno("select MAX(sid) from hitlist")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        displayrecordintext(0)

    End Sub

    Sub displayrecordintext(ByVal recno As Integer)
        txtRollNo.Text = objname.fillgrid("select * from hitlist").Rows(recno).Item(0).ToString
        txtName.Text = objname.fillgrid("select * from hitlist").Rows(recno).Item(1).ToString
        txtMobile.Text = objname.fillgrid("select * from hitlist").Rows(recno).Item(2).ToString
        txtEmail.Text = objname.fillgrid("select * from hitlist").Rows(recno).Item(3).ToString
        cmbCOurse.SelectedIndex = objname.fillgrid("select * from hitlist").Rows(recno).Item(4).ToString
        cmbCity.SelectedItem = objname.fillgrid("select * from hitlist").Rows(recno).Item(5).ToString
        recno = recno
    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        recno = objname.fillgrid("select * from hitlist").Rows.Count
        displayrecordintext(recno - 1)
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If recno = 0 Then
            MsgBox("FIrst Record")
        Else
            recno -= 1
        End If
        displayrecordintext(recno)
    End Sub

    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        getrecordsingrid("Asc")
    End Sub

    Private Sub btnDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesc.Click
        getrecordsingrid("Desc")
    End Sub
End Class
