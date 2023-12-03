Public MustInherit Class clsVivek

    'for SEALED Class Use NOtINHERITABLE KEYWORD
    'for ABSRACT CLASS USE MUSTINHERIT
    'elements or fields
    Dim i As Integer
    Dim strname As String
    Dim strclass As String

    Public Function study() As String
        Return "I am Student"
    End Function
    Public Function study(ByVal str As String) As String
        Return "I am  " & str
    End Function
    Public Function study(ByVal str As String, ByVal result As Integer) As String
        Return "I am " & str & "Of Age :" & result
    End Function
    'WHEN U USE MUSTINHERIT THEN COMPULSORY USE MuSTOVERRIDE
    Public MustOverride Sub Akshay()
    Public MustOverride Sub Manoj()
    Public Function bca() As String
        Return "I AM PARENT"
    End Function
End Class
