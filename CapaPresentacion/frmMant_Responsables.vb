﻿Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Responsables
    Dim xNombre As String
    Dim xDNI As String
    Dim xFecha As Date
    Dim xCodigo As String
    Private Sub frmMant_Responsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarResponsables()
    End Sub
    Private Sub listarResponsables()
        Dim lista As List(Of Responsable)
        lista = ResponsableLN.ListarResponsables
        DGVResponsables.AllowUserToOrderColumns = True
        DGVResponsables.MultiSelect = False
        DGVResponsables.DataSource = lista
        DGVResponsables.Columns("CodigoResponsable").ReadOnly = True
    End Sub

    Private Sub listarProveedores()
        Dim lista As List(Of Proveedor)
        lista = ProveedorLN.ListarProveedores
        'DGVProveedores.DataSource = lista
    End Sub

    Private Sub DGVResponsables_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVResponsables.CellEndEdit
        'Llenar datos de la columna a vars globales
        xCodigo = CStr(DGVResponsables.Rows(e.RowIndex).Cells("CodigoResponsable").Value)
        xDNI = CStr(DGVResponsables.Rows(e.RowIndex).Cells("NumDNI").Value)
        xNombre = CStr(DGVResponsables.Rows(e.RowIndex).Cells("Nombre").Value)
        xFecha = CDate(DGVResponsables.Rows(e.RowIndex).Cells("FechaNacimiento").Value)
    End Sub

    Private Sub DGVResponsables_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVResponsables.DataError
        MessageError("Uno de los datos ingreados no es correcto, verifique e inténtelo nuevamente")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim xResponsable As New Responsable With {
            .CodigoResponsable = xCodigo,
            .Nombre = xNombre,
            .FechaNacimiento = xFecha,
            .NumDNI = xDNI
        }
        ResponsableLN.Actualizar(xResponsable)
        listarResponsables()
        MessageInformation("Datos actualizados")
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim nombre As String = txtNombre.Text
        Dim dni As String = txtDNI.Text
        If nombre <> "" And dni <> "" Then
            Dim xResponsable As New Responsable With {
                .Nombre = txtNombre.Text,
                .FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"),
                .NumDNI = txtDNI.Text
            }
            ResponsableLN.Insertar(xResponsable)
            listarResponsables()
            Clear()
            MessageInformation("Responsable registrado")
        Else
            MessageError("Todos los campos son obligatorios")
        End If
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVResponsables.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = MessageConfirm("¿Seguro que quiere eliminar el responsable seleccionado?")
            If confirm = DialogResult.Yes Then
                Dim i As Integer = DGVResponsables.SelectedRows(0).Index
                Dim CodigoResponsable As String = CStr(DGVResponsables.Rows(i).Cells("CodigoResponsable").Value)
                'DGVResponsables.Rows.RemoveAt(i)
                ResponsableLN.Eliminar(CodigoResponsable)
                listarResponsables()
                MessageInformation("Responsable eliminado del registro")
            End If
        Else
            MessageInformation("Seleccione una fila a eliminar")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Clear()
    End Sub

    Private Sub Clear()
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtBuscarCodigoResp.Text = ""
        dtpFechaNacimiento.Value = Date.Now
    End Sub

    Private Sub txtBuscarCodigoResp_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCodigoResp.TextChanged
        Dim texto As String = txtBuscarCodigoResp.Text
        Dim lista As List(Of Responsable)
        lista = ResponsableLN.Buscar(texto)
        DGVResponsables.DataSource = lista
    End Sub
End Class