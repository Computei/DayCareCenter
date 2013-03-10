Public Class Parent
    Public Property Id As Integer
    Public Property Name As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property Birth As DateTime
End Class

Public Class ParentClass
    Private _parent As IParentsEntitie

    Sub New(ByVal parent As IParentsEntitie)
        _parent = parent
    End Sub

    Public Sub CreateParent(ByVal parent As Parent)
        _parent.Add(parent)
    End Sub

    Public Sub DeleteParent(ByVal parent As Parent)
        _parent.Delete(parent)
    End Sub

    Public Sub UpdateParent(ByVal parent As Parent)
        _parent.Update(parent.Id)
    End Sub

    Public Function ListAllParents() As IEnumerable(Of Parent)
        Return _parent.ListParents()
    End Function

    Public Function FindParent(ByVal Id As Integer) As Parent
        Return _parent.FindParent(Id)
    End Function
End Class
