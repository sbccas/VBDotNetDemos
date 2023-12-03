Public Class frmExceptionDemo
    Dim i As Integer = 0
    Private j As Integer = 0
    Dim str() = {"sutex", "bca"}


    Private Sub btnErrObject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErrObject.Click
        MsgBox(str.Length)
        ReDim Preserve str(10)
        MsgBox(str.Length)
        Dim i As Integer = 0

        For i = 1 To 512
            On Error GoTo sybca1
            Err.Raise(i)
        Next


sybca1:
        RichTextBox1.Text &= " No : " & Err.Number & " "

        RichTextBox1.Text &= "ERROR TYPE : " & Err.Description & vbNewLine

        'RichTextBox1.Text &= " YOUR ERROR IS SOURCE : " & Err.Source & " "
        'RichTextBox1.Text &= " YOUR ERROR IS ERL : " & Err.Erl & vbNewLine

        Err.Clear()
        Resume Next







    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'hello this is sample code for error
            '1
            '2
            '3
            Button1.Text = "sybca2"

            MsgBox(Button1.Text)
            Dim i As Integer = 0
            Dim j As Double
            i = 11
            j = i / 0



        Catch ex As System.IO.IOException
            MsgBox("UNABLE TO READ OR WRITE ")
        Catch When Err.Number = 11
            MsgBox("MATHS IS POOR")
        Catch ex As System.OutOfMemoryException
            MsgBox("PLEASE CLOSE OTHER APPLICATIONS ")
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox("THIS IS COMMON FOR SYBCA DIV 2. DONT WORRY ")
        Catch ex As Exception
            MsgBox("CALL 108 ")

        Finally

        End Try
    End Sub

    Private Sub btnThrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrow.Click
        Try
            Throw New ApplicationException("SYBCA CALSS IS ????")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnmyObj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmyObj.Click
        Dim myclassobj As New Class1

        myclassobj.tyre = "RICKSHAW"
        MsgBox(myclassobj.tyre)

        myclassobj.sybca1 = "123"

        Dim i As Integer = myclassobj.sybca2




    End Sub

    Private Sub btnErr2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErr2.Click
        Try
            Err.Raise(11)


        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("error number : " & Err.Number & " ERR DESCP : " & Err.Description & " EROR SOURCE : " & Err.Source & " ERROR LINE NUMBER " & Err.Erl)
        End Try
        
    End Sub

    Private Sub frmExceptionDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Visible = True
        DataGridView1.Enabled = True
        Dim str As String = "select * from " & ComboBox1.SelectedItem & ""
        Dim myclassobj As New Class1
        DataGridView1.DataSource = myclassobj.getrecords(str)
        Button1.TabIndex = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '  Dim myobj As New clsNilesh
        '  myobj.nileshall = "STRING"
        '  MsgBox(m6yobj.nileshall)

        ' MsgBox(myobj.jay)
    End Sub
End Class