Imports DayCareCenter.Domain
Imports Microsoft.Practices.Unity

Public Interface IParentsListView
    Sub SetParentsName_LastName(ByVal name As String, ByVal lastname As String)
    Sub BindParentsList(ByVal parents As IEnumerable(Of ParentsDTOs))
End Interface

Public Class ParentsListPresenter
    ReadOnly view As IParentsListView

    Sub New(ByVal view As IParentsListView)
        Me.view = view
    End Sub

    Sub Init()
        Dim container As New UnityContainer

        Dim Parent = container.Resolve(Of ParentClass)()


    End Sub


End Class
