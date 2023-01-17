Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Movimientos
    Public xDoc As Documento
    Dim responsable As Responsable
    ReadOnly _productoLN As New ProductoLN
    Private Sub PRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarMovimientos()
        mostrarDatos()
        CargarIDsProductos()
        lblNumDoc.Text = xDoc.NumDocumento

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
    Private Sub CargarIdsProductos()
        Dim productos As List(Of Producto) = _productoLN.ObtenerProductos()
        For Each producto As Producto In productos
            cboCodigosProductos.Items.Add(New KeyValuePair(Of Integer, String)(producto.CodigoProducto, producto.NombreProducto))
        Next
        cboCodigosProductos.ValueMember = "Key"
        cboCodigosProductos.DisplayMember = "Value"
    End Sub
    Private Sub mostrarDatos()
        responsable = ResponsableLN.BuscarCodigo(xDoc.CodigoResponsable)
        lblNombre.Text = responsable.Nombre
        lblDNI.Text = responsable.NumDNI
        lblResponsable.Text = responsable.CodigoResponsable
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
        DGVMovimientos.Columns("PrecioDocumento").DisplayIndex = 2
        DGVMovimientos.Columns("StockAnterior").DisplayIndex = 3
        DGVMovimientos.Columns("CantidadSalida").DisplayIndex = 4
        DGVMovimientos.Columns("CantidadEntrada").DisplayIndex = 5
        DGVMovimientos.Columns("StockActual").DisplayIndex = 6
        DGVMovimientos.Columns("IdTipoMov").Visible = False
        DGVMovimientos.Columns("StockAnterior").Visible = False
        DGVMovimientos.Columns("StockActual").Visible = False
        DGVMovimientos.Columns("NumItem").Visible = False
        DGVMovimientos.Columns("NumHoja").HeaderText = False

        ' cargar categorias en combo
        Dim productosColumn As New DataGridViewComboBoxColumn With {
            .DataSource = _productoLN.ObtenerProductos(),
            .ValueMember = "CodigoProducto",
            .DisplayMember = "NombreProducto",
            .DataPropertyName = "CodigoProducto",
            .HeaderText = "Producto",
            .Name = "CodigoProducto"
        }
        DGVMovimientos.Columns.Add(productosColumn)

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

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

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
        dCodigoProducto = DirectCast(cboCodigosProductos.SelectedItem, KeyValuePair(Of Integer, String)).Key
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
        cboCodigosProductos.SelectedIndex = -1
        txtPrecio.Text = ""
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class