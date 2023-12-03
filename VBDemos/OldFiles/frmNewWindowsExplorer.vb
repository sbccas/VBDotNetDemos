Imports System.IO


Public Class frmNewWindowsExplorer

    Private Sub frmNewWindowsExplorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()
        Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
        Dim rootDir As String = String.Empty
        'Now loop thru each drive and populate the treeview
        For i As Integer = 0 To drives.Count - 1
            rootDir = drives(i).Name
            'Add this drive as a root node
            TreeView1.Nodes.Add(rootDir)
            'Populate this root node
            PopulateTreeView(rootDir, TreeView1.Nodes(i))
        Next
    End Sub
    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        Dim folder As String = String.Empty
        Try
            Dim folders() As String = IO.Directory.GetDirectories(dir)
            If folders.Length <> 0 Then
                Dim childNode As TreeNode = Nothing
                For Each folder In folders
                    childNode = New TreeNode(folder)
                    parentNode.Nodes.Add(childNode)
                    PopulateTreeView(folder, childNode)
                Next
            End If
        Catch ex As UnauthorizedAccessException
            parentNode.Nodes.Add(folder & ": Access Denied")
        End Try
    End Sub

End Class