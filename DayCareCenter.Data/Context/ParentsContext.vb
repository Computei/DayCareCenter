Imports System.Data.Entity
Imports DayCareCenter.Domain

Public Class ParentContext : Inherits DbContext
    Public Property Parents As DbSet(Of Parent)

End Class
