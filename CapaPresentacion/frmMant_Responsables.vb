Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Responsables
    ReadOnly _helpers As New Helpers
    'Variables de edición de celda en el DataGridView
    Dim xNombre As String
    Dim xDNI As String
    Dim xFecha As Date
    Dim xCodigo As String

    Dim selResponsable As Responsable = Nothing


    Private Sub frmMant_Responsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarResponsables()
        If Me.Modal Then
            btnSeleccionar.Visible = True
        Else
            btnSeleccionar.Visible = False
        End If
    End Sub

    Private Sub listarResponsables()
        Dim lista As List(Of Responsable)
        lista = ResponsableLN.ListarResponsables
        DGVResponsables.AllowUserToOrderColumns = True
        DGVResponsables.MultiSelect = False
        DGVResponsables.DataSource = lista
        DGVResponsables.Columns("CodigoResponsable").ReadOnly = True
    End Sub

    Private Sub DGVResponsables_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVResponsables.CellEndEdit
        'Llenar datos de la columna a vars globales
        xCodigo = CStr(DGVResponsables.Rows(e.RowIndex).Cells("CodigoResponsable").Value)
        xDNI = CStr(DGVResponsables.Rows(e.RowIndex).Cells("NumDNI").Value)
        xNombre = CStr(DGVResponsables.Rows(e.RowIndex).Cells("Nombre").Value)
        xFecha = CDate(DGVResponsables.Rows(e.RowIndex).Cells("FechaNacimiento").Value)
    End Sub

    Private Sub DGVResponsables_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVResponsables.DataError
        _helpers.MessageError("Uno de los datos ingreados no es correcto, verifique e inténtelo nuevamente")
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
        _helpers.MessageInformation("Datos actualizados")
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
            _helpers.MessageInformation("Responsable registrado")
        Else
            _helpers.MessageError("Todos los campos son obligatorios")
        End If
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVResponsables.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = _helpers.MessageConfirm("¿Seguro que quiere eliminar el responsable seleccionado?")
            If confirm = DialogResult.Yes Then
                Dim i As Integer = DGVResponsables.SelectedRows(0).Index
                Dim CodigoResponsable As String = CStr(DGVResponsables.Rows(i).Cells("CodigoResponsable").Value)
                'DGVResponsables.Rows.RemoveAt(i)
                ResponsableLN.Eliminar(CodigoResponsable)
                listarResponsables()
                _helpers.MessageInformation("Responsable eliminado del registro")
            End If
        Else
            _helpers.MessageInformation("Seleccione una fila a eliminar")
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

    Public Function getSelResponsable() As Responsable
        Return selResponsable
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If DGVResponsables.SelectedRows.Count > 0 Then
            Dim i As Integer = DGVResponsables.SelectedRows(0).Index
            selResponsable = New Responsable With {
                .CodigoResponsable = CStr(DGVResponsables.Rows(i).Cells("CodigoResponsable").Value),
                .FechaNacimiento = CDate(DGVResponsables.Rows(i).Cells("FechaNacimiento").Value),
                .Nombre = CStr(DGVResponsables.Rows(i).Cells("Nombre").Value),
                .NumDNI = CStr(DGVResponsables.Rows(i).Cells("NumDNI").Value)
            }
            Me.Dispose()
        Else
            _helpers.MessageInformation("Seleccione una responsable")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class