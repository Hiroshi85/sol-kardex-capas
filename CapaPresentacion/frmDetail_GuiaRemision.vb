Imports CapaNegocios
Imports CapaEntidad
Public Class frmDetail_GuiaRemision
    Dim xDoc As Documento
    Dim proveedor As New Proveedor
    Private Sub frmDetail_GuiaRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        mostrarMovimientos()
    End Sub
    Private Sub mostrarDatos()
        Proveedor = ProveedorLN.BuscarID(xDoc.IdProveedor)
        lblCorreo.Text = Proveedor.Correo
        lblProveedor.Text = Proveedor.Proveedor
        lblDescripcion.Text = Proveedor.Descripcion
        lblTelefono.Text = Proveedor.Telefono
        lblRUC.Text = Proveedor.RUC
        lblNumDoc.Text = xDoc.NumDocumento
        lblDireccion.Text = Proveedor.Direccion
        lblFecha.Text = xDoc.Fecha
    End Sub
    Private Sub mostrarMovimientos()
        Dim lista As List(Of Movimiento)
        lista = MovimientoLN.ListarMovimientos(xDoc.NumDocumento)
        DGVMovimientos.DataSource = lista
        columnsOrder()
    End Sub
    Private Sub columnsOrder()
        DGVMovimientos.Columns("NumDocumento").DisplayIndex = 0
        DGVMovimientos.Columns("CodigoProducto").DisplayIndex = 1
        DGVMovimientos.Columns("NumItem").DisplayIndex = 2
        DGVMovimientos.Columns("NumHoja").DisplayIndex = 3
        DGVMovimientos.Columns("PrecioDocumento").DisplayIndex = 4
        'DGVMovimientos.Columns("StockAnterior").DisplayIndex = 5
        'DGVMovimientos.Columns("CantidadSalida").DisplayIndex = 6
        DGVMovimientos.Columns("CantidadEntrada").DisplayIndex = 5
        'DGVMovimientos.Columns("StockActual").DisplayIndex = 7
        DGVMovimientos.Columns("IdTipoMov").Visible = False
        DGVMovimientos.Columns("StockAnterior").Visible = False
        DGVMovimientos.Columns("StockActual").Visible = False
        DGVMovimientos.Columns("CantidadSalida").Visible = False
        DGVMovimientos.Columns("CantidadSalida").Visible = False
        DGVMovimientos.Columns("NumDocumento").Visible = False
    End Sub
    Public Sub cargar(obj As Documento)
        xDoc = obj
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dCantidad As Double
        Dim dCodigoProducto As Integer
        Dim dPrecioDocumento As Double
        dCantidad = txtCantidad.Text
        dCodigoProducto = txtCodigo.Text
        dPrecioDocumento = txtPrecio.Text


        Dim xMovimiento As New Movimiento With {
            .NumDocumento = xDoc.NumDocumento,
            .CodigoProducto = dCodigoProducto,
            .CantidadEntrada = dCantidad,
            .PrecioDocumento = dPrecioDocumento
         }
        limpiar()
        MovimientoLN.InsertarMovEntrada(xMovimiento)
        mostrarMovimientos()
        MessageInformation("Movimiento añadido")
    End Sub
    Private Sub MessageInformation(mensaje As String)
        MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtCantidad.Text = ""
        txtCodigo.Text = ""
        txtPrecio.Text = ""
    End Sub
End Class