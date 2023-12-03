Imports System.Data
Imports System.Data.OracleClient

Public Class frmOracleConnectionDemo
    Dim flag As Boolean = True
    

    Private Sub frmOracleConnectionDemo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If flag Then
        '    Label2.BackColor = Color.Green
        '    flag = False
        'Else
        '    Label2.BackColor = Color.Red
        '    flag = True
        'End If
    End Sub

    Private Sub frmOracleConnectionDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New OracleConnection("gfhghgh")
        If cn.State = ConnectionState.Open Then
            Label2.BackColor = Color.Green
        Else
            Label2.BackColor = Color.Red

        End If

    End Sub
End Class