Public Class UCLabelDemo
    Private mytextstring As String = ""
    Public Property mytext() As String
        Get
            Return mytextstring
        End Get
        Set(ByVal value As String)
            mytextstring = value
        End Set
    End Property


    Private Sub UCLabelDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Me.mytext
    End Sub
End Class
