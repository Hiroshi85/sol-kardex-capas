Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Proveedores
    Dim xDescripcion As String
    Private Sub frmMant_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProveedores()
    End Sub
    Private Sub listarProveedores()
        Dim lista As List(Of Proveedor)
        lista = ProveedorLN.ListarProveedores
        DGVProveedores.AllowUserToOrderColumns = True
        DGVProveedores.MultiSelect = False
        DGVProveedores.DataSource = lista
    End Sub

    Private Sub DGVProveedores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedores.CellEndEdit
        xDescripcion = CStr(DGVProveedores.Rows(e.RowIndex).Cells("Descripcion").Value)
    End Sub

    'Reutilizables
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
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim texto As String = txtBuscar.Text
        Dim lista As List(Of Proveedor)
        lista = ProveedorLN.Buscar(texto)
        DGVProveedores.DataSource = lista
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim descripcion As String = txtDescripcion.Text
        If descripcion <> "" Then
            Dim xProveedor As New Proveedor With {
                .Descripcion = descripcion
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
            .Descripcion = xDescripcion
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
                Dim descripcion As String = CStr(DGVProveedores.Rows(i).Cells("Descripcion").Value)
                'DGVResponsables.Rows.RemoveAt(i)
                ResponsableLN.Eliminar(descripcion)
                listarProveedores()
                MessageInformation("Proveedor eliminado del registro")
            End If
        Else
            MessageInformation("Seleccione una fila a eliminar")
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub
End Class