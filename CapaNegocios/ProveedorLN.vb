Imports CapaEntidad
Imports CapaAccesoDatos
Public Class ProveedorLN
    Public Shared Function ListarProveedores() As List(Of Proveedor)
        Dim objAD As New ProveedorAD
        Return objAD.ListarProveedores()
    End Function
    Public Shared Sub Insertar(obj As Proveedor)
        Dim objAD As New ProveedorAD
        objAD.Insertar(obj)
    End Sub
    Public Shared Sub Actualizar(obj As Proveedor)
        Dim objAD As New ProveedorAD
        objAD.Actualizar(obj)
    End Sub
    Public Shared Sub Eliminar(obj As Integer)
        Dim objAD As New ProveedorAD
        objAD.Eliminar(obj)
    End Sub
    Public Shared Function Buscar(obj As String) As List(Of Proveedor)
        Dim objAD As New ProveedorAD
        Return objAD.Buscar(obj)
    End Function

    Public Shared Function BuscarID(obj As Integer) As Proveedor
        Dim objAD As New ProveedorAD
        Return objAD.BuscarID(obj)
    End Function
End Class
