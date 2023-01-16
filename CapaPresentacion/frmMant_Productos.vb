Imports CapaEntidad
Imports CapaNegocios
Public Class FrmMant_Productos
    ReadOnly _categoriaLN As New CategoriaLN
    ReadOnly _medidaLN As New MedidaLN
    ReadOnly _helpers As New Helpers
    ReadOnly _productoLN As New ProductoLN
    Dim productoActualizar As Producto
    Private Sub LLenarDatos()
        txtNombreProducto.Text = "Jabon Sapolio"
        txtDescripcionProducto.Text = "Detergente verde 1L Sapolio"
        txtPrecioBaseProducto.Text = "10"
        cboCategoriaProducto.SelectedIndex = 2
        cboMedidaProducto.SelectedIndex = 4
        txtCantidadReposicionKardex.Text = "20"
        txtStockMinRepoKardex.Text = "10"

    End Sub

    Private Sub CargarProductos(productos As List(Of Producto))

        DGVProductos.DataSource = productos
        DGVProductos.Columns.Clear()

        Dim CodigoProductoColumn As New DataGridViewTextBoxColumn With {
            .HeaderText = "Codigo",
            .DataPropertyName = "CodigoProducto",
            .Name = "CodigoProducto",
            .DisplayIndex = 1
        }
        Dim NombreProductoColumn As New DataGridViewTextBoxColumn With {
            .HeaderText = "Nombre",
            .DataPropertyName = "NombreProducto",
            .Name = "NombreProducto",
            .DisplayIndex = 2
        }

        ' cargar medidas en combo
        Dim medidaColumn As New DataGridViewComboBoxColumn With {
            .DataSource = _medidaLN.ListarMedidas(),
            .ValueMember = "IdMedida",
            .DisplayMember = "Unidad",
            .DataPropertyName = "IdMedida",
            .HeaderText = "Medida",
            .DisplayIndex = 2
        }


        ' cargar categorias en combo
        Dim categoriaColumn As New DataGridViewComboBoxColumn With {
            .DataSource = _categoriaLN.ListarCategorias(),
            .ValueMember = "IdCategoria",
            .DisplayMember = "Descripcion",
            .DataPropertyName = "IdCategoria",
            .HeaderText = "Categoria",
            .DisplayIndex = 3
        }

        Dim DescripcionProductoColumn As New DataGridViewTextBoxColumn With {
           .HeaderText = "Descripcion",
           .DataPropertyName = "DescripcionProducto",
           .Name = "DescripcionProducto",
           .DisplayIndex = 4
        }
        Dim PrecioProductoColumn As New DataGridViewTextBoxColumn With {
            .HeaderText = "Precio",
            .DataPropertyName = "PrecioBase",
            .Name = "PrecioBase",
            .DisplayIndex = 5
        }
        DGVProductos.Columns.AddRange(CodigoProductoColumn, NombreProductoColumn, medidaColumn, categoriaColumn, DescripcionProductoColumn, PrecioProductoColumn)



    End Sub
    Private Sub CargarCategorias()
        Dim categorias As List(Of Categoria) = _categoriaLN.ListarCategorias()
        For Each categoria As Categoria In categorias
            cboCategoriaProducto.Items.Add(New KeyValuePair(Of Integer, String)(categoria.IdCategoria, categoria.Descripcion))
        Next
        cboCategoriaProducto.ValueMember = "Key"
        cboCategoriaProducto.DisplayMember = "Value"
    End Sub
    Private Sub CargarMedidas()
        Dim medidas As List(Of Medida) = _medidaLN.ListarMedidas()
        For Each medida As Medida In medidas
            cboMedidaProducto.Items.Add(New KeyValuePair(Of Integer, String)(medida.IdMedida, medida.Unidad))
        Next
        cboMedidaProducto.ValueMember = "Key"
        cboMedidaProducto.DisplayMember = "Value"
    End Sub
    Private Sub FrmMant_Productos(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarMedidas()
        CargarProductos(_productoLN.ObtenerProductos())
        LLenarDatos()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If (_helpers.ValidarPanel(PanInfoProducto) = False) Then Return
        Try
            Dim producto As New Producto With {
            .NombreProducto = txtNombreProducto.Text,
            .DescripcionProducto = txtDescripcionProducto.Text,
            .IdCategoria = DirectCast(cboCategoriaProducto.SelectedItem, KeyValuePair(Of Integer, String)).Key,
            .IdMedida = DirectCast(cboMedidaProducto.SelectedItem, KeyValuePair(Of Integer, String)).Key,
            .PrecioBase = CInt(txtPrecioBaseProducto.Text)
            }
            Dim kardex As New Kardex With {
            .CantidadReposicion = txtCantidadReposicionKardex.Text,
            .StockMinRepo = txtStockMinRepoKardex.Text
            }
            _productoLN.AgregarProducto(producto, kardex)
            CargarProductos(_productoLN.ObtenerProductos())
            _helpers.SeleccionarUltimaFila(DGVProductos)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        _helpers.LimpiarPanel(PanInfoProducto)
    End Sub

    Private Sub txtQNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles txtQNombreProducto.TextChanged
        Dim list As List(Of Producto) = _productoLN.FiltrarProductosPorNombre(txtQNombreProducto.Text)
        CargarProductos(list)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un producto")
            Return
        End If
        Dim selectedRow As DataGridViewRow = DGVProductos.SelectedRows(0)
        Dim codigoProducto As Integer = selectedRow.Cells("CodigoProducto").Value
        Console.WriteLine(codigoProducto)
        Try
            Dim confirm As DialogResult = _helpers.MessageConfirm("¿Seguro que quiere eliminar el producto seleccionado?")
            If confirm = DialogResult.Yes Then
                _productoLN.EliminarProducto(codigoProducto)
                CargarProductos(_productoLN.ObtenerProductos())
                MessageBox.Show("Producto eliminado exitosamente")
            End If
            _productoLN.EliminarProducto(codigoProducto)
        CargarProductos(_productoLN.ObtenerProductos())
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al eliminar el producto")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If DGVProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila para actualizar")
            Return
        End If
        _productoLN.ActualizarProducto(productoActualizar)
        'Actualizar el DataGridView
        DGVProductos.DataSource = _productoLN.ObtenerProductos()
    End Sub

    Private Sub DGVProductos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProductos.CellEndEdit

        productoActualizar = New Producto With {
            .CodigoProducto = DGVProductos.Rows(e.RowIndex).Cells("CodigoProducto").Value,
            .NombreProducto = DGVProductos.Rows(e.RowIndex).Cells("NombreProducto").Value,
            .DescripcionProducto = DGVProductos.Rows(e.RowIndex).Cells("DescripcionProducto").Value,
            .PrecioBase = DGVProductos.Rows(e.RowIndex).Cells("PrecioBase").Value,
            .IdCategoria = DGVProductos.Rows(e.RowIndex).Cells("IdCategoria").Value,
            .IdMedida = DGVProductos.Rows(e.RowIndex).Cells("IdMedida").Value
        }
    End Sub

    Private Sub FrmMant_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
