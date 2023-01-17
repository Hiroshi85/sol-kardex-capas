Imports CapaEntidad
Imports CapaAccesoDatos
Public Class KardexLN
    Public Shared Function ListarMovimientosKardex(CodProd As Integer, NHoja As Integer) As List(Of Movimiento)
        Dim objMovKard As New KardexAD
        Return objMovKard.ListarMovimientosKardex(CodProd, NHoja)
    End Function

    Public Shared Function GetUltimaHojaKardex(CodProd As Integer) As Integer
        Dim objMovKard As New KardexAD
        Return objMovKard.GetUltimaHojaKardex(CodProd)
    End Function
    Public Shared Function GetKardex(CodProd As Integer) As Kardex
        Dim objMovKard As New KardexAD
        Return objMovKard.GetKardex(CodProd)
    End Function
    Public Shared Function GetStockActual(CodProd As Integer) As Double
        Dim objMovKard As New KardexAD
        Return objMovKard.GetStockActual(CodProd)
    End Function

    Public Shared Function GetEstado(CodProd As Integer) As Integer
        Dim objMovKard As New KardexAD
        Dim Kard As Kardex
        Dim Actual As Double
        Dim Estado As Integer
        Kard = objMovKard.GetKardex(CodProd)
        Actual = objMovKard.GetStockActual(CodProd)
        If (Actual <= 0) Then
            Estado = 3
        ElseIf (Actual < Kard.StockMinRepo) Then
            Estado = 2
        Else
            Estado = 1
        End If
        Return Estado
    End Function
    Public Shared Function ActualizarKardex(Kard As Kardex)
        Dim objMovKard As New KardexAD
        objMovKard.ActualizarKardex(Kard)
    End Function
End Class
