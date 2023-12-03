Public Class clsNilesh
    'element
    'field
    Dim i As Integer
    Private j As Integer
    Dim strname As String = ""
    Dim a As Integer = 150
    'properties
    Public ReadOnly Property jay As Integer
        Get
            Return a
        End Get
    End Property
    Public WriteOnly Property nileshright
        Set(ByVal value)

        End Set
    End Property
    Public Property nileshall As String
        Set(ByVal value As String)
            strname = value
        End Set
        Get
            Return strname
        End Get
    End Property

    Function brijesh() As Integer
        Return 0
    End Function
    Function brijesh(ByVal a As Integer) As Integer
        Return a
    End Function
    Function brijesh(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    ' MustOverride Sub RAHUL_ADDITION()
    ' MustOverride Sub RAHUL_SUBTRACTION()

    ' MustOverride Function Pooja_Addition() As Integer


    Overridable Function allinone() As String
        Return "I am Parent"
    End Function

    Public Sub iamnotoverridable()

    End Sub
    'default constructor
    Sub New()
        i = 111
        j = 222
        a = 333
        strname = "sutex"
    End Sub
    Sub New(ByVal username As String, ByVal age As Integer)
        strname = username
        a = age
    End Sub
    Function display() As String

        If a > 18 Then
            Return "HELLO DEAR :" & strname & " YOU ARE OF AGE " & a & " .YOU CAN GET LICENCE TO ENTER"
        Else
            Return "HELLO DEAR :" & strname & " YOU ARE OF AGE " & a & " .YOU CANNOT ENTER"
        End If

    End Function
    Protected Overrides Sub Finalize()
        Beep()
        Beep()
    End Sub
End Class
