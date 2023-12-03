Public Class clsJay
    Inherits clsVivek



    Public Overrides Sub Akshay()
        MsgBox("I AM FRIEND OF MANOJ")
    End Sub

    Public Overrides Sub Manoj()
        MsgBox("I AM FRIEND OF AKSHAY")
    End Sub

    Public Overloads Function bca() As String
        Return "I AM CHILD"
    End Function
End Class
