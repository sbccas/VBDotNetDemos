Public Class clsSYBCA3
    Dim i As Integer = 1
    Dim istr As String = ""
    Dim idate As Date
    Dim fancount As String = "ONE FAN"
    Sub New()
        door = 4
        fancount = "FIVE FANS"
    End Sub
    Sub New(ByVal pdoor As Integer, ByVal pfancount As String)
        door = pdoor
        fancount = pfancount
    End Sub

    Public Property door As Integer
        Get
            Return i
        End Get
        Set(ByVal value As Integer)
            i = value
        End Set
    End Property

    Public ReadOnly Property roomno As String
        Get
            Return "ROOM NO 26"
        End Get
    End Property

    Public WriteOnly Property course As String
        Set(ByVal value As String)
            istr = value
        End Set
    End Property

    Public Property fans As String
        Get
            Return fancount
        End Get
        Set(ByVal value As String)
            fancount = value
        End Set
    End Property

    Public Sub greetings()
        Dim dt As DateTime = System.DateTime.Now
        Dim strgreet As String = ""
        If dt.Hour > 6 And dt.Hour <= 12 Then
            strgreet = " GOOD MORNING"
        ElseIf dt.Hour > 12 And dt.Hour <= 18 Then
            strgreet = " GOOD AFTERNOON"
        Else
            strgreet = " GOOD NIGHT"
        End If

        MsgBox(strgreet)
    End Sub
    Public Sub greetings(ByVal stname As String)
        Dim dt As DateTime = System.DateTime.Now
        Dim strgreet As String = ""
        If dt.Hour > 6 And dt.Hour <= 12 Then
            strgreet = " GOOD MORNING"
        ElseIf dt.Hour > 12 And dt.Hour <= 18 Then
            strgreet = " GOOD AFTERNOON"
        Else
            strgreet = " GOOD NIGHT"
        End If
        stname = stname + strgreet
        MsgBox(stname)
    End Sub
    Public Sub greetings(ByVal stname As String, ByVal ctime As DateTime)

        Dim strgreet As String = ""
        If ctime.Hour > 6 And ctime.Hour <= 12 Then
            strgreet = " GOOD MORNING"
        ElseIf ctime.Hour > 12 And ctime.Hour <= 18 Then
            strgreet = " GOOD AFTERNOON"
        Else
            strgreet = " GOOD NIGHT"
        End If
        stname = stname + strgreet
        MsgBox(stname)
    End Sub
    Public Function statuspara(ByVal stname As String) As String
        Dim dt As DateTime = System.DateTime.Now
        Dim strgreet As String = ""
        If dt.Hour > 6 And dt.Hour <= 12 Then
            strgreet = "GOOD MORNING"
        ElseIf dt.Hour > 12 And dt.Hour <= 18 Then
            strgreet = "GOOD AFTERNOON"
        Else
            strgreet = "GOOD NIGHT"
        End If
        Return stname & " " & strgreet
    End Function


    Public Function status() As String
        Dim dt As DateTime = System.DateTime.Now
        Dim strgreet As String = ""
        If dt.Hour > 6 And dt.Hour <= 12 Then
            strgreet = "GOOD MORNING"
        ElseIf dt.Hour > 12 And dt.Hour <= 18 Then
            strgreet = "GOOD AFTERNOON"
        Else
            strgreet = "GOOD NIGHT"
        End If
        Return strgreet
    End Function




End Class
