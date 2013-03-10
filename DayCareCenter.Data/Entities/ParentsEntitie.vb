Imports DayCareCenter.Domain

Public Class ParentsEntitie
    Implements IParentsEntitie

    Private db As ParentContext

    Sub New()
        db = New ParentContext
    End Sub

    Public Sub Add(ByVal _parent As Parent) Implements IParentsEntitie.Add
        db.Parents.Add(_parent)
        db.SaveChanges()
    End Sub

    Public Sub Delete(ByVal _parent As Parent) Implements IParentsEntitie.Delete
        db.Parents.Remove(_parent)
        db.SaveChanges()
    End Sub

    Public Sub Update(ByVal Id As Integer) Implements IParentsEntitie.Update
        db.Parents.Find(Id)
    End Sub

    Public Function ListParents() As IEnumerable(Of Parent) Implements IParentsEntitie.ListParents
        Return Nothing
    End Function

    Public Function FindParent(ByVal Id As Integer) As Parent Implements IParentsEntitie.FindParent
        Return Nothing
    End Function
End Class