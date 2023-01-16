Imports CapaAccesoDatos
Imports CapaEntidad
Public Class MovimientoLN
    Public Shared Function ListarMovimientos(obj As Integer) As List(Of Movimiento)
        Dim objAD As New MovimientosAD
        Return objAD.ListarMovimientos(obj)
    End Function
    Public Shared Sub InsertarMovEntrada(obj As Movimiento)
        Dim objAD As New MovimientosAD
        objAD.InsertarMovEntrada(obj)
    End Sub
    Public Shared Sub InsertarMovSalida(obj As Movimiento)
        Dim objAD As New MovimientosAD
        objAD.InsertarMovSalida(obj)
    End Sub
End Class
