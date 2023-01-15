Imports CapaEntidad
Imports CapaAccesoDatos
Public Class ResponsableLN
    Public Shared Function ListarResponsables() As List(Of Responsable)
        Dim objAD As New ResponsableAD
        Return objAD.ListarResponsables()
    End Function
    Public Shared Sub Insertar(obj As Responsable)
        Dim objAD As New ResponsableAD
        objAD.Insertar(obj)
    End Sub
    Public Shared Sub Actualizar(obj As Responsable)
        Dim objAD As New ResponsableAD
        objAD.Actualizar(obj)
    End Sub
    Public Shared Sub Eliminar(obj As String)
        Dim objAD As New ResponsableAD
        objAD.Eliminar(obj)
    End Sub
    Public Shared Function Buscar(obj As String) As List(Of Responsable)
        Dim objAD As New ResponsableAD
        Return objAD.Buscar(obj)
    End Function
End Class
