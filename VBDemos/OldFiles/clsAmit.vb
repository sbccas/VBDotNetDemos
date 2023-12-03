Public Class clsAmit
    Implements Isutex, IList, ICollection


    Public Property canteenstar As Integer Implements Isutex.canteenstar
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property class1 As String Implements Isutex.class1
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Sub discipline() Implements Isutex.discipline

    End Sub

    Public Property material As Boolean Implements Isutex.material
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property sports As Boolean Implements Isutex.sports
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Sub CopyTo(ByVal array As System.Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo

    End Sub

    Public ReadOnly Property Count As Integer Implements System.Collections.ICollection.Count
        Get

        End Get
    End Property

    Public ReadOnly Property IsSynchronized As Boolean Implements System.Collections.ICollection.IsSynchronized
        Get

        End Get
    End Property

    Public ReadOnly Property SyncRoot As Object Implements System.Collections.ICollection.SyncRoot
        Get

        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator

    End Function

    Public Function Add(ByVal value As Object) As Integer Implements System.Collections.IList.Add

    End Function

    Public Sub Clear() Implements System.Collections.IList.Clear

    End Sub

    Public Function Contains(ByVal value As Object) As Boolean Implements System.Collections.IList.Contains

    End Function

    Public Function IndexOf(ByVal value As Object) As Integer Implements System.Collections.IList.IndexOf

    End Function

    Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements System.Collections.IList.Insert

    End Sub

    Public ReadOnly Property IsFixedSize As Boolean Implements System.Collections.IList.IsFixedSize
        Get

        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements System.Collections.IList.IsReadOnly
        Get

        End Get
    End Property

    Default Public Property Item(ByVal index As Integer) As Object Implements System.Collections.IList.Item
        Get

        End Get
        Set(ByVal value As Object)

        End Set
    End Property

    Public Sub Remove(ByVal value As Object) Implements System.Collections.IList.Remove

    End Sub

    Public Sub RemoveAt(ByVal index As Integer) Implements System.Collections.IList.RemoveAt

    End Sub
End Class
