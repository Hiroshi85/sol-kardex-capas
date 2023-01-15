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
        DGVMovDeKardex.AllowUserToOrderColumns = True
        DGVMovDeKardex.MultiSelect = False
        DGVMovDeKardex.DataSource = lista

        DGVMovDeKardex.Columns("NumItem").DisplayIndex = 0
        DGVMovDeKardex.Columns("NumDocumento").DisplayIndex = 1
        DGVMovDeKardex.Columns("IdTipoMov").DisplayIndex = 2
        DGVMovDeKardex.Columns("StockAnterior").DisplayIndex = 3
        DGVMovDeKardex.Columns("CantidadEntrada").DisplayIndex = 4
        DGVMovDeKardex.Columns("CantidadSalida").DisplayIndex = 5
        DGVMovDeKardex.Columns("StockActual").DisplayIndex = 6
        DGVMovDeKardex.Columns("PrecioDocumento").DisplayIndex = 7
        DGVMovDeKardex.Columns("NumHoja").Visible = False
        DGVMovDeKardex.Columns("CodigoProducto").Visible = False

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