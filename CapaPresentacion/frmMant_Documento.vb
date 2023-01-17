Imports CapaNegocios
Imports CapaEntidad
Public Class frmMant_Documento
    Dim xNumDocumento As Integer
    Dim xFecha As Date
    Dim xIdTipoDoc As Integer
    Dim xIdProveedor As Integer
    Dim xCodigoResponsable As String
    Private Sub frmMant_Documento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        llenarProveedores()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub ListarDocumentos()
        Dim lista As List(Of Documento)
        lista = DocumentoLN.ListarDocumentos
        DGVDocumentos.AllowUserToOrderColumns = True
        DGVDocumentos.MultiSelect = False

        DGVDocumentos.DataSource = lista
        DGVDocumentos.Columns("NumDocumento").DisplayIndex = 0
        DGVDocumentos.Columns("Fecha").DisplayIndex = 1
        DGVDocumentos.Columns("IdTipoDoc").DisplayIndex = 2
        DGVDocumentos.Columns("IdProveedor").DisplayIndex = 3
        DGVDocumentos.Columns("CodigoResponsable").DisplayIndex = 4

    End Sub

    Private Sub llenarProveedores()
        Dim lista As List(Of Proveedor)
        Dim tamaño As Integer
        lista = ProveedorLN.ListarProveedores
        tamaño = lista.Count
        For Each prov As Proveedor In lista
            cbProveedor.Items.Add(prov.IdProveedor)
        Next
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtIdResponsable.Text = ""
        cbProveedor.SelectedIndex = -1
        cbTipoDoc.SelectedIndex = -1
        dtpFechaEmision.Value = Date.Now
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim dFecha As Date
        Dim dIdTipoDoc As Integer
        Dim dIdProveedor As Integer
        Dim dCodigoR As String

        dFecha = dtpFechaEmision.Value
        If cbTipoDoc.SelectedIndex = 0 Then dIdTipoDoc = 1
        If cbTipoDoc.SelectedIndex = 1 Then dIdTipoDoc = 2
        If cbTipoDoc.SelectedIndex = 2 Then dIdTipoDoc = 3
        If (cbTipoDoc.SelectedIndex = 2) Then
            dIdProveedor = cbProveedor.SelectedItem
            dCodigoR = " "
        Else
            dIdProveedor = Nothing
            dCodigoR = txtIdResponsable.Text
        End If

        Dim xDocumento As New Documento With {
                .Fecha = dFecha,
                .IdTipoDoc = dIdTipoDoc,
                .IdProveedor = dIdProveedor,
                .CodigoResponsable = dCodigoR
            }
        DocumentoLN.AgregarDocumento(xDocumento)
        reset()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub reset()
        txtIdResponsable.Text = ""
        cbProveedor.SelectedIndex = -1
        cbTipoDoc.SelectedIndex = -1
        dtpFechaEmision.Value = Date.Now
        txtIdResponsable.Enabled = False
        cbProveedor.Enabled = False
        ListarDocumentos()
    End Sub

    Private Sub cbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDoc.SelectedIndexChanged
        If cbTipoDoc.SelectedIndex = 2 Then
            txtIdResponsable.Enabled = False
            cbProveedor.Enabled = True
        End If
        If cbTipoDoc.SelectedIndex = 0 Or cbTipoDoc.SelectedIndex = 1 Then
            txtIdResponsable.Enabled = True
            cbProveedor.Enabled = False
        End If
    End Sub

    Private Sub cbTipoDoc_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoDoc.SelectedValueChanged

    End Sub

    Private Sub DGVDocumentos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVDocumentos.CellFormatting
        If DGVDocumentos.Columns(e.ColumnIndex).Name = "IdProveedor" AndAlso e.Value = 0 Then
            e.Value = "-"
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub btndsal_Click(sender As Object, e As EventArgs) Handles btndsal.Click
        Dim lista As List(Of Documento)
        lista = DocumentoLN.ListarDocumentosSalida
        DGVDocumentos.AllowUserToOrderColumns = True
        DGVDocumentos.MultiSelect = False
        DGVDocumentos.DataSource = lista
        DGVDocumentos.Columns("NumDocumento").DisplayIndex = 0
        DGVDocumentos.Columns("Fecha").DisplayIndex = 1
        DGVDocumentos.Columns("IdTipoDoc").DisplayIndex = 2
        DGVDocumentos.Columns("IdProveedor").DisplayIndex = 3
        DGVDocumentos.Columns("CodigoResponsable").DisplayIndex = 4
    End Sub

    Private Sub btndent_Click(sender As Object, e As EventArgs) Handles btndent.Click
        Dim lista As List(Of Documento)
        lista = DocumentoLN.ListarDocumentosEntrada
        DGVDocumentos.AllowUserToOrderColumns = True
        DGVDocumentos.MultiSelect = False
        DGVDocumentos.DataSource = lista
        DGVDocumentos.Columns("NumDocumento").DisplayIndex = 0
        DGVDocumentos.Columns("Fecha").DisplayIndex = 1
        DGVDocumentos.Columns("IdTipoDoc").DisplayIndex = 2
        DGVDocumentos.Columns("IdProveedor").DisplayIndex = 3
        DGVDocumentos.Columns("CodigoResponsable").DisplayIndex = 4
    End Sub

    Private Sub btntodos_Click(sender As Object, e As EventArgs) Handles btntodos.Click
        ListarDocumentos()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dNumDoc As Integer
        Dim dFecha As Date
        Dim dIdTipoDoc As Integer
        Dim dIdProveedor As Integer
        Dim dCodigoR As String
        If DGVDocumentos.SelectedRows.Count > 0 Then
            dCodigoR = Convert.ToString(DGVDocumentos.SelectedRows(0).Cells(0).Value)
            dIdProveedor = Convert.ToString(DGVDocumentos.SelectedRows(0).Cells(1).Value)
            dIdTipoDoc = Convert.ToString(DGVDocumentos.SelectedRows(0).Cells(2).Value)
            dFecha = Convert.ToString(DGVDocumentos.SelectedRows(0).Cells(3).Value)
            dNumDoc = Convert.ToString(DGVDocumentos.SelectedRows(0).Cells(4).Value)

            Dim xDocumento As New Documento With {
                    .NumDocumento = dNumDoc,
                    .Fecha = dFecha,
                    .IdTipoDoc = dIdTipoDoc,
                    .IdProveedor = dIdProveedor,
                    .CodigoResponsable = dCodigoR
                }
            If dIdTipoDoc <> 3 Then
                Dim frm As New frmMant_Movimientos()
                frm.cargar(xDocumento)
                frm.Visible() = True
            Else
                Dim frm As New frmDetail_GuiaRemision()
                frm.cargar(xDocumento)
                frm.Visible = True
            End If
        Else

                MessageInformation("Seleccione un documento")
        End If
    End Sub

    Private Sub MessageInformation(mensaje As String)
        MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class