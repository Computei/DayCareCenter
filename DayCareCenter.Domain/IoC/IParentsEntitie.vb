Public Interface IParentsEntitie

    Sub Add(ByVal _parent As Parent)
    Sub Delete(ByVal _parent As Parent)
    Sub Update(ByVal Id As Integer)
    Function ListParents() As IEnumerable(Of Parent)
    Function FindParent(ByVal Id As Integer) As Parent
End Interface
