Imports CapaEntidad
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
        If xResponsable.CodigoResponsable Then
            ResponsableLN.Actualizar(xResponsable)
            MessageInformation("Datos actualizados")
        Else
            MessageInformation("Código no encontrado")
        End If
        listarResponsables()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim xResponsable As New Responsable With {
            .Nombre = txtNombre.Text,
            .FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"),
            .NumDNI = txtDNI.Text
        }
        ResponsableLN.Insertar(xResponsable)
        MessageInformation("Responsable registrado")
        listarResponsables()
    End Sub

    Private Sub MessageInformation(mensaje As String)
        MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MessageError(mensaje As String)
        MessageBox.Show(mensaje, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtBuscarCodigoResp.Text = ""
        dtpFechaNacimiento.Value.ToString = ""
    End Sub


End Class