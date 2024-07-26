Public Class frmOpenFileDialogFileNamesDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = ""
        OpenFileDialog1.ShowDialog()
        'For i As Integer = 0 To OpenFileDialog1.FileNames.Length - 1
        ListBox1.Items.AddRange(OpenFileDialog1.FileNames)
        'Next



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim str As String = ""
        OpenFileDialog2.ShowDialog()
        'For i As Integer = 0 To OpenFileDialog1.FileNames.Length - 1
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(OpenFileDialog2.SafeFileNames)

    End Sub
End Class