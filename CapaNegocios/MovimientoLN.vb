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
    Public Shared Function CalcularSubTotal(obj As Integer, x As Integer)
        Dim objAD As New MovimientosAD
        Dim lista As New List(Of Movimiento)
        Dim subTotal As New Double
        lista = objAD.ListarMovimientos(obj)
        For Each mov As Movimiento In lista
            If x = 1 Then
                subTotal += mov.CantidadSalida * mov.PrecioDocumento
            Else
                subTotal += mov.CantidadEntrada * mov.PrecioDocumento
            End If
        Next
        Return subTotal
    End Function
End Class
