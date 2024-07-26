Public Class clsSYBCA4
    'Implements Isybca4, IList


    Dim i As Integer
    Dim istr As String
    Dim idate As Date
    Dim sname As String = "SHYAM"

    Protected business As String = "IMPORT EXPORT"

    Sub New()
        i = 10
        istr = "201718"
        idate = System.DateTime.Now
        spname = "HITESH"
    End Sub
    Sub New(ByVal stuname As String)
        i = 10
        istr = "201718"
        idate = System.DateTime.Now
        spname = stuname
    End Sub
    Public WriteOnly Property clsname As String
        Set(ByVal value As String)
            istr = value
        End Set
    End Property
    Public ReadOnly Property clsname1 As String
        Get
            Return "DARSHAN  ROLL 224"
        End Get
    End Property

    Public Property door() As Integer
        Get
            Return i
        End Get
        Set(ByVal value As Integer)
            i = value
        End Set
    End Property

    Public Property spname As String
        Get
            Return sname
        End Get
        Set(ByVal value As String)
            sname = value
        End Set
    End Property

    Public Sub greetings()
        Dim str As String = ""
        Dim dt As DateTime = System.DateTime.Now
        If dt.Hour >= 6 And dt.Hour <= 12 Then
            str = "GOOD MORNING "
        ElseIf dt.Hour > 12 And dt.Hour < 18 Then
            str = "GOOD AFTERNOON "
        Else
            str = "GOOD NIGHT "
        End If

        str += sname
        MsgBox(str)
    End Sub
    Public Sub greetings(ByVal stname As String)
        Dim str As String = ""
        Dim dt As DateTime = System.DateTime.Now
        If dt.Hour >= 6 And dt.Hour <= 12 Then
            str = "GOOD MORNING "
        ElseIf dt.Hour > 12 And dt.Hour < 18 Then
            str = "GOOD AFTERNOON "
        Else
            str = "GOOD NIGHT "
        End If

        stname += " " & str
        MsgBox(stname)
    End Sub


    Public Function upload() As String
        Return "SUCCESSFUL UPLOAD"
    End Function

    Public Function upload(ByVal hobby As String) As String
        Return "I HAVE NEW HOBBY OF " & hobby
    End Function

End Class
