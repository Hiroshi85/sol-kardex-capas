Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Movimientos
    Public xDoc As Documento
    Private Sub PRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarMovimientos()

        lblNumDoc.Text = xDoc.NumDocumento
        If xDoc.IdProveedor = 0 Then
            lblProveedor.Text = "-"
        Else
            lblProveedor.Text = xDoc.IdProveedor
        End If
        lblResponsable.Text = xDoc.CodigoResponsable
        lblFecha.Text = xDoc.Fecha
        If xDoc.IdTipoDoc = 1 Then
            lblDocumento.Text = "Factura"
        ElseIf xDoc.IdTipoDoc = 2 Then
            lblDocumento.Text = "Boleta"
        Else
            lblDocumento.Text = "Guia de Remision"
        End If

    End Sub

    Public Sub mostrarMovimientos()
        Dim lista As List(Of Movimiento)
        Dim subTotal As Double
        lista = MovimientoLN.ListarMovimientos(xDoc.NumDocumento)
        DGVMovimientos.AllowUserToOrderColumns = True
        DGVMovimientos.MultiSelect = False
        DGVMovimientos.DataSource = lista
        DGVMovimientos.Columns("NumDocumento").DisplayIndex = 0
        DGVMovimientos.Columns("CodigoProducto").DisplayIndex = 1
        DGVMovimientos.Columns("NumItem").DisplayIndex = 2
        DGVMovimientos.Columns("NumHoja").DisplayIndex = 3
        DGVMovimientos.Columns("PrecioDocumento").DisplayIndex = 4
        DGVMovimientos.Columns("StockAnterior").DisplayIndex = 5
        DGVMovimientos.Columns("CantidadSalida").DisplayIndex = 6
        DGVMovimientos.Columns("CantidadEntrada").DisplayIndex = 7
        DGVMovimientos.Columns("StockActual").DisplayIndex = 8
        DGVMovimientos.Columns("IdTipoMov").Visible = False
        DGVMovimientos.Columns("StockAnterior").Visible = False
        DGVMovimientos.Columns("StockActual").Visible = False
        If (xDoc.IdTipoDoc = 3) Then
            DGVMovimientos.Columns("CantidadSalida").Visible = False
        Else
            DGVMovimientos.Columns("CantidadEntrada").Visible = False
        End If

        '' Obtener SubTotal, IGV y Total
        subTotal = MovimientoLN.CalcularSubTotal(xDoc.NumDocumento, 1)
        txtSubTotal.Text = "S/. " + Convert.ToString(subTotal)
        txtIGV.Text = "S/. " + Convert.ToString(0.18 * subTotal)
        txtTotal.Text = "S/. " + Convert.ToString(1.18 * subTotal)
    End Sub
    Public Sub cargar(obj As Documento)
        xDoc = obj
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblNumDoc.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dCantidad As Double
        Dim dCodigoProducto As Integer
        Dim dPrecioDocumento As Double
        dCantidad = txtCantidad.Text
        dCodigoProducto = txtCodigo.Text
        dPrecioDocumento = txtPrecio.Text

        If (xDoc.IdTipoDoc = 3) Then
            Dim xMovimiento As New Movimiento With {
                .NumDocumento = xDoc.NumDocumento,
                .CodigoProducto = dCodigoProducto,
                .CantidadEntrada = dCantidad,
                .PrecioDocumento = dPrecioDocumento
            }
            MovimientoLN.InsertarMovEntrada(xMovimiento)
        Else
            Dim xMovimiento As New Movimiento With {
                .NumDocumento = xDoc.NumDocumento,
                .CodigoProducto = dCodigoProducto,
                .CantidadSalida = dCantidad,
                .PrecioDocumento = dPrecioDocumento
            }
            MovimientoLN.InsertarMovSalida(xMovimiento)
        End If
        limpiar()
        mostrarMovimientos()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtCantidad.Text = ""
        txtCodigo.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class