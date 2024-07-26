Public Class frmControlCounter

    Public Function hello(ByVal strname As String, Optional ByVal strcity As String = "ABC", Optional ByVal strmob As String = "987897897") As String
        Return "HELLO FROM :" & strname & " and I am From : " & strcity
    End Function

    'Create a function for Simple Interest
    Public Function simpleinterest(ByVal p As Double, ByVal r As Double, ByVal n As Double) As Double
        Dim si As Double
        si = (p * r * n) / 100
        Return si
    End Function

    Private Sub frmControlCounter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim sum As Integer = 0
        Dim str As String = "TOTAL CONTROL AND THEIR NAMES" & vbNewLine
        For i = 0 To Me.Controls.Count - 1
            sum += 1
            str += "COntrol ID : " & i & "Control Name : " & Me.Controls.Item(i).Name & vbNewLine
        Next
        MsgBox("TOTAL CONTROL ARE " & sum & vbNewLine & str)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Use InputBox

        'Button1.Text = "SUTEX BANK COLLEGE OF COMPUTER APPLICATIONS AND SCIENCE"
        'Button1.ForeColor = Color.Aqua
        'Button1.BackColor = Color.White
        'Button1.Size = New Size(100, 100)
        'Button1.Enabled = False
        With Button1
            .Text = "SUTEX BANK COLLEGE OF COMPUTER APPLICATIONS AND SCIENCE"
            .ForeColor = Color.Aqua
            .BackColor = Color.White
            .Size = New Size(100, 100)
            .Enabled = False
            '.Visible = False
        End With

        'Button1.Text = InputBox("Please Enter the Title for Button")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(hello("Pinal"))
        MsgBox(hello("Nikul", "BHAVNAGAR"))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p, r, n As Double
        p = InputBox("ENTER PRINCIPAL AMOUNT")
        r = InputBox("ENTER RATE OF INTEREST")
        n = InputBox("ENTER NUMBER OF YEARS")
        MsgBox("YOUR SIMPLE INTEREST IS : " & simpleinterest(p, r, n))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class