﻿Imports CapaNegocios
Imports CapaEntidad
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmDetail_GuiaRemision
    Dim xDoc As Documento
    Dim proveedor As New Proveedor
    Private Sub frmDetail_GuiaRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        mostrarMovimientos()
    End Sub
    Private Sub mostrarDatos()
        proveedor = ProveedorLN.BuscarID(xDoc.IdProveedor)
        lblCorreo.Text = proveedor.Correo
        lblProveedor.Text = proveedor.Proveedor
        lblDescripcion.Text = proveedor.Descripcion
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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim pdfw As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("nuevo_pdf.pdf", FileMode.Create))
        doc.Open()
        doc.Add(New Paragraph("Este es un nuevo archivo PDF."))
        doc.Close()
    End Sub
End Class