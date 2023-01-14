Imports CapaEntidad
Imports CapaAccesoDatos
Public Class ProveedorLN
    Public Shared Function ListarProveedores() As List(Of Proveedor)
        Dim objAD As New ProveedorAD
        Return objAD.ListarProveedores()
    End Function
End Class
