Public Class clsSYBCA3Child
    Implements IList, IComparer, iSYBCA3, IButtonControl
    'Inherits clsSYBCA3
    'Public Sub finalexam()
    '    Dim i As String = "TESTING"
    '    Dim j, k As Integer
    '    j = 5
    '    k = 10
    '    i = i + (Val(j) + Val(k)).ToString
    '    MsgBox(i)
    'End Sub

    Dim flagcoonection As Boolean = False
    Dim global123 As Integer
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

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

    End Function

    Public Sub checkresult() Implements iSYBCA3.checkresult

    End Sub

    Public Sub giveexam() Implements iSYBCA3.giveexam

    End Sub

    Public Sub gotdegree() Implements iSYBCA3.gotdegree

    End Sub

    Public Sub gotocollege() Implements iSYBCA3.gotocollege

    End Sub

    Public Property DialogResult As System.Windows.Forms.DialogResult Implements System.Windows.Forms.IButtonControl.DialogResult
        Get

        End Get
        Set(ByVal value As System.Windows.Forms.DialogResult)

        End Set
    End Property

    Public Sub NotifyDefault(ByVal value As Boolean) Implements System.Windows.Forms.IButtonControl.NotifyDefault

    End Sub

    Public Sub PerformClick() Implements System.Windows.Forms.IButtonControl.PerformClick

    End Sub

    Public Function calculate() As Object Implements iSYBCA3.calculate
        Dim i, j, k As Integer

        Return i * j * k
    End Function

    Public Property checkconnection As Boolean Implements iSYBCA3.checkconnection
        Get
            Return flagcoonection
        End Get
        Set(ByVal value As Boolean)
            flagcoonection = value
        End Set
    End Property
End Class
