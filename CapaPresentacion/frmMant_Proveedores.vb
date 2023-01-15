Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Proveedores
    Dim xIdProveedor As Integer
    Dim xDescripcion As String
    Dim xTelefono As String
    Dim xCorreo As String
    Dim xDireccion As String
    Dim xProv As String
    Private Sub frmMant_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProveedores()
    End Sub
    Private Sub listarProveedores()
        Dim lista As List(Of Proveedor)
        lista = ProveedorLN.ListarProveedores
        DGVProveedores.AllowUserToOrderColumns = True
        DGVProveedores.MultiSelect = False

        DGVProveedores.DataSource = lista
        OrderDisplay()
    End Sub

    Private Sub DGVProveedores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedores.CellEndEdit
        xIdProveedor = CInt(DGVProveedores.Rows(e.RowIndex).Cells("IdProveedor").Value)
        xDescripcion = CStr(DGVProveedores.Rows(e.RowIndex).Cells("Descripcion").Value)
        xTelefono = CStr(DGVProveedores.Rows(e.RowIndex).Cells("Telefono").Value)
        xProv = CStr(DGVProveedores.Rows(e.RowIndex).Cells("Proveedor").Value)
        xCorreo = CStr(DGVProveedores.Rows(e.RowIndex).Cells("Correo").Value)
        xDireccion = CStr(DGVProveedores.Rows(e.RowIndex).Cells("Direccion").Value)
    End Sub

    'Reutilizables
    Private Sub OrderDisplay()
        DGVProveedores.Columns("IdProveedor").DisplayIndex = 0
        DGVProveedores.Columns("Proveedor").DisplayIndex = 1
        DGVProveedores.Columns("Descripcion").DisplayIndex = 2
        DGVProveedores.Columns("Correo").DisplayIndex = 3
        DGVProveedores.Columns("Direccion").DisplayIndex = 4
        DGVProveedores.Columns("Telefono").DisplayIndex = 5
    End Sub
    Private Sub MessageInformation(mensaje As String)
        MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MessageError(mensaje As String)
        MessageBox.Show(mensaje, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Function MessageConfirm(mensaje As String) As DialogResult
        Dim confirm As DialogResult = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo)
        Return confirm
    End Function
    Private Sub Clear()
        txtDescripcion.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
        txtProveedor.Text = ""
        txtTelefono.Text = ""
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim texto As String = txtBuscar.Text
        Dim lista As List(Of Proveedor)
        lista = ProveedorLN.Buscar(texto)
        DGVProveedores.DataSource = lista
        OrderDisplay()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim descripcion As String = txtDescripcion.Text
        Dim telefono As String = txtTelefono.Text
        Dim direccion As String = txtDireccion.Text
        Dim correo As String = txtCorreo.Text
        Dim proveedor As String = txtProveedor.Text
        If descripcion <> "" And telefono <> "" And direccion <> "" And correo <> "" And proveedor <> "" Then
            Dim xProveedor As New Proveedor With {
                .Descripcion = descripcion,
                .Telefono = telefono,
                .Direccion = direccion,
                .Correo = correo,
                .Proveedor = proveedor
            }
            ProveedorLN.Insertar(xProveedor)
            listarProveedores()
            Clear()
            MessageInformation("Proveedor registrado")
        Else
            MessageError("Todos los campos son obligatorios")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Clear()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim xProveedor As New Proveedor With {
            .IdProveedor = xIdProveedor,
            .Descripcion = xDescripcion,
            .Telefono = xTelefono,
            .Direccion = xDireccion,
            .Correo = xCorreo,
            .Proveedor = xProv
        }
        ProveedorLN.Actualizar(xProveedor)
        listarProveedores()
        MessageInformation("Datos actualizados")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVProveedores.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = MessageConfirm("¿Seguro que quiere eliminar el proveedor seleccionado?")
            If confirm = DialogResult.Yes Then
                Dim i As Integer = DGVProveedores.SelectedRows(0).Index
                Dim idProveedor As Integer = CInt(DGVProveedores.Rows(i).Cells("IdProveedor").Value)
                'DGVResponsables.Rows.RemoveAt(i)
                ProveedorLN.Eliminar(idProveedor)
                listarProveedores()
                MessageInformation("Proveedor eliminado del registro")
            End If
        Else
            MessageInformation("Seleccione una fila a eliminar")
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class