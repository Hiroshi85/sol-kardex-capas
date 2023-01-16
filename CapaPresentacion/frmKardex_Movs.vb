Imports CapaEntidad
Imports CapaNegocios
Public Class frmKardex_Movs

    Private Sub frmKardex_Movs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUltimaHoja()
        CargarKardex()
        CargarEstado()
    End Sub
    Private Sub CargarKardex()
        Dim Kard As Kardex
        Kard = KardexLN.GetKardex(NudKardex.Value)
        TxtMinimo.Text = Kard.StockMinRepo.ToString
        DtpFecha.Value = Kard.FechaApertura
        TxtActual.Text = KardexLN.GetStockActual(Kard.CodigoProducto)
    End Sub

    Private Sub ListarMovDeKardex()
        Dim lista As List(Of Movimiento)
        Dim CodProd As Integer
        Dim NHoja As Integer
        CodProd = Convert.ToInt32(NudKardex.Value)
        NHoja = Convert.ToInt32(NudHoja.Value)

        lista = KardexLN.ListarMovimientosKardex(CodProd, NHoja)
        DGVMovDeKardex.Rows.Clear()
        DGVMovDeKardex.AllowUserToOrderColumns = True
        DGVMovDeKardex.MultiSelect = False
        Dim Tipo As String
        Dim Entrada As String
        Dim Salida As String
        For Each item As Movimiento In lista
            Entrada = If(item.CantidadEntrada <> -1, item.CantidadEntrada.ToString, "-")
            Salida = If(item.CantidadSalida <> -1, item.CantidadSalida.ToString, "-")
            If (item.IdTipoMov = 1) Then
                Tipo = "Entrada"
            Else
                Tipo = "Salida"
            End If
            DGVMovDeKardex.Rows.Add(
                item.NumItem,
                item.NumDocumento,
                Tipo,
                item.StockActual,
                item.PrecioDocumento,
                Entrada,
                Salida,
                item.StockAnterior,
                item.PrecioDocumento
                )
        Next
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ListarMovDeKardex()
        CargarKardex()
        CargarEstado()
    End Sub

    Private Sub NudKardex_ValueChanged(sender As Object, e As EventArgs) Handles NudKardex.ValueChanged
        CargarUltimaHoja()
    End Sub

    Private Sub CargarUltimaHoja()
        Dim UltimaHoja = KardexLN.GetUltimaHojaKardex(Convert.ToInt32(NudKardex.Value))
        If (Not IsDBNull(UltimaHoja)) Then
            NudHoja.Value = 1
            NudHoja.Maximum = UltimaHoja
            NudHoja.Value = UltimaHoja
        Else
            NudHoja.Value = 1
            NudHoja.Maximum = 1
        End If
    End Sub

    Private Sub CargarEstado()
        Dim Estado As Integer
        Estado = KardexLN.GetEstado(NudKardex.Value)
        Select Case Estado
            Case 1
                LblEstado.Text = "NORMAL"
                LblEstado.ForeColor = Color.Green
            Case 2
                LblEstado.Text = "EN RIESGO"
                LblEstado.ForeColor = Color.Orange
            Case 3
                LblEstado.Text = "SIN STOCK!!!"
                LblEstado.ForeColor = Color.Red
        End Select
    End Sub
End Class