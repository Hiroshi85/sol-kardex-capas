Imports CapaEntidad
Imports CapaNegocios
Public Class frmKardex_Movs

    Private Sub frmKardex_Movs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUltimaHoja()
        ListarMovDeKardex()
        CargarKardex()
    End Sub
    Private Sub CargarKardex()
        Dim Kard As Kardex
        Dim NumProductos As Integer
        Kard = KardexLN.GetKardex(NudKardex.Value)
        NumProductos = New ProductoLN().ObtenerProductos().Count
        NudKardex.Maximum = NumProductos
        TxtMinimo.Text = Kard.StockMinRepo.ToString
        TxtRepo.Text = Kard.CantidadReposicion.ToString
        DtpFecha.Value = Kard.FechaApertura
        TxtActual.Text = KardexLN.GetStockActual(Kard.CodigoProducto)
        CargarEstado()
        Dim Estado = KardexLN.GetEstado(NudKardex.Value)
        If (Estado <> 1) Then
            TxtFalta.Visible = True
            lblFalta.Visible = True
            TxtFalta.Text = Convert.ToDouble(TxtMinimo.Text) - Convert.ToDouble(TxtActual.Text)
        Else
            TxtFalta.Visible = False
            lblFalta.Visible = False
        End If
        LlenarDatosProd(Kard.CodigoProducto)
    End Sub

    Private Sub LlenarDatosProd(CodProd As Integer)
        Dim Prod As Producto
        Dim ProdLN = New ProductoLN
        Dim CateLN = New CategoriaLN
        Prod = ProdLN.ObtenerProductoPorId(CodProd)
        LblNombre.Text = Prod.NombreProducto
        TxtDesc.Text = Prod.DescripcionProducto
        TxtPrecio.Text = Prod.PrecioBase
        TxtUnidad.Text = New MedidaLN().GetMedida(Prod.IdMedida).Unidad
        TxtCategoria.Text = New CategoriaLN().GetCategoria(Prod.IdCategoria).Descripcion
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
        CargarUltimaHoja()
        ListarMovDeKardex()
        CargarKardex()

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
                LblEstado.Text = "EN RIESGO!"
                LblEstado.ForeColor = Color.OrangeRed
            Case 3
                LblEstado.Text = "SIN STOCK!!!"
                LblEstado.ForeColor = Color.Red
        End Select
    End Sub

    Private Sub BtnIr_Click(sender As Object, e As EventArgs) Handles BtnIr.Click
        ListarMovDeKardex()
    End Sub
End Class