Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class frmDataboundControlDemo
    ' Dim objname As New clsADOOperationSYBCA4
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
    Private Sub frmDataboundControlDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim strquery As String = "select * from Student_master"
        Dim cmd As New OleDbCommand(strquery, cn1)
        Dim da As New OleDbDataAdapter(cmd)
        ds1 = New DataSet
        da.Fill(ds1)
        ComboBox1.DataSource = ds1.Tables(0)
        ComboBox1.DisplayMember = "sname"
        ComboBox1.ValueMember = "smobile"
        ListBox1.DataSource = ds1.Tables(0)
        ListBox1.DisplayMember = "semail"
        ListBox1.ValueMember = "smobile"
        CheckedListBox1.DataSource = ds1.Tables(0)
        CheckedListBox1.DisplayMember = "scity"
        CheckedListBox1.ValueMember = "smobile"
    End Sub
    
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            MsgBox(ListBox1.SelectedValue.ToString)
        End If

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedIndex <> -1 Then
            MsgBox(CheckedListBox1.SelectedValue.ToString)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            MsgBox(ComboBox1.SelectedValue.ToString)
        End If
    End Sub

End Class