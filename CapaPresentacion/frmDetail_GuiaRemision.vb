Imports CapaNegocios
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
        Dim subTotal As Double
        lista = MovimientoLN.ListarMovimientos(xDoc.NumDocumento)
        DGVMovimientos.DataSource = lista
        columnsOrder()
        subTotal = MovimientoLN.CalcularSubTotal(xDoc.NumDocumento, 2)
        txtTotal.Text = "S/. " + Convert.ToString(subTotal)
    End Sub
    Private Sub columnsOrder()
        DGVMovimientos.Columns("NumDocumento").DisplayIndex = 0
        DGVMovimientos.Columns("CodigoProducto").DisplayIndex = 1
        DGVMovimientos.Columns("NumItem").Visible = False
        DGVMovimientos.Columns("NumHoja").Visible = False
        DGVMovimientos.Columns("PrecioDocumento").DisplayIndex = 2
        'DGVMovimientos.Columns("StockAnterior").DisplayIndex = 5
        'DGVMovimientos.Columns("CantidadSalida").DisplayIndex = 6
        DGVMovimientos.Columns("CantidadEntrada").DisplayIndex = 3
        'DGVMovimientos.Columns("StockActual").DisplayIndex = 7
        DGVMovimientos.Columns("IdTipoMov").Visible = False
        DGVMovimientos.Columns("StockAnterior").Visible = False
        DGVMovimientos.Columns("StockActual").Visible = False
        DGVMovimientos.Columns("CantidadSalida").Visible = False
        DGVMovimientos.Columns("CantidadSalida").Visible = False
        DGVMovimientos.Columns("NumDocumento").Visible = False
        DGVMovimientos.Columns("ImporteSalida").Visible = False


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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("nuevo_pdf.pdf", FileMode.Create))
        Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim FontB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
        Dim FontB12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
        Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
        CVacio.Border = 0
        pdfDoc.Open()
        Dim table1 As PdfPTable = New PdfPTable(4)
        Dim col1 As PdfPCell
        Dim col2 As PdfPCell
        Dim col3 As PdfPCell
        Dim col4 As PdfPCell
        Dim col5 As PdfPCell
        Dim col6 As PdfPCell
        Dim ILine As Integer
        Dim IFila As Integer
        table1.WidthPercentage = 95
        Dim widths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        table1.SetWidths(widths)
        'Dim imagenURL As String = "D:\logo.jpg"
        'Dim imagenBMP As iTextSharp.text.Image
        'imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        'imagenBMP.ScaleToFit(110.0F, 140.0F)
        'imagenBMP.SpacingBefore = 20.0F
        'imagenBMP.SpacingAfter = 10.0F
        'imagenBMP.SetAbsolutePosition(40, 700)
        'pdfDoc.Add(imagenBMP)

        'Remitente
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Remitente: " + proveedor.Proveedor, Font8))
        col2.Border = 0
        table1.AddCell(col2)

        'RUC
        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("RUC:" + proveedor.RUC, FontB12))
        col3.Border = 0
        table1.AddCell(col3)

        'Remitente
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Rubro: " + proveedor.Descripcion, Font8))
        col2.Border = 0
        table1.AddCell(col2)

        Dim doc As String
        doc = ""
        If (xDoc.IdTipoDoc = 1) Then
            doc = "FACTURA"
        End If
        If (xDoc.IdTipoDoc = 2) Then
            doc = "BOLETA"
        End If
        If (xDoc.IdTipoDoc = 3) Then
            doc = "GUÍA DE REMISIÓN"
        End If
        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase(doc, FontB12))
        col3.Border = 0
        table1.AddCell(col3)


        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Dirección: " + proveedor.Direccion + "      " + "Teléfono: " + proveedor.Telefono, Font8))
        col2.Border = 0
        table1.AddCell(col2)

        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("N°:     " + Convert.ToString(xDoc.NumDocumento), FontB12))
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Correo Electrónico: " + proveedor.Correo, Font8))
        col2.Border = 0
        table1.AddCell(col2)


        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("", FontB8))
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("", Font8))
        col2.Border = 0
        table1.AddCell(col2)

        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("Fecha de Emisión: " + xDoc.Fecha, FontB8))
        col3.Border = 0
        table1.AddCell(col3)
        pdfDoc.Add(table1)

        'CABECERA
        Dim table3 As PdfPTable = New PdfPTable(5)
        Dim widths3 As Single() = New Single() {3.0F, 2.0F, 2.0F, 2.0F, 1.0F}
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)
        col1 = New PdfPCell(New Phrase("Código de Producto", FontB8))
        col1.Border = 0
        table3.AddCell(col1)
        col1 = New PdfPCell(New Phrase("Precio en Documento", FontB8))
        col1.Border = 0
        table3.AddCell(col1)

        col1 = New PdfPCell(New Phrase("Cantidad de Entrada", FontB8))
        col1.Border = 0
        table3.AddCell(col1)
        col1 = New PdfPCell(New Phrase("Importe de Entrada", FontB8))
        col1.Border = 0
        table3.AddCell(col1)
        table3.AddCell(CVacio)
        pdfDoc.Add(table3)
        'Detalles
        Dim table4 As PdfPTable = New PdfPTable(5)
        Dim widths4 As Single() = New Single() {3.0F, 2.0F, 2.0F, 2.0F, 1.0F}
        table4.WidthPercentage = 95
        table4.SetWidths(widths4)

        Dim lista As List(Of Movimiento)
        Dim subTotal As Double
        lista = MovimientoLN.ListarMovimientos(xDoc.NumDocumento)
        subTotal = MovimientoLN.CalcularSubTotal(xDoc.NumDocumento, 2)
        For i = 0 To lista.Count() - 1

            col1 = New PdfPCell(New Phrase(lista.Item(i).CodigoProducto, Font8))
            col1.Border = 0
            table4.AddCell(col1)

            col1 = New PdfPCell(New Phrase(lista.Item(i).PrecioDocumento, Font8))
            col1.Border = 0
            table4.AddCell(col1)

            col1 = New PdfPCell(New Phrase(lista.Item(i).CantidadEntrada, Font8))
            col1.Border = 0
            table4.AddCell(col1)

            col1 = New PdfPCell(New Phrase(lista.Item(i).ImporteEntrada, Font8))
            col1.Border = 0
            table4.AddCell(col1)

            table4.AddCell(CVacio)
        Next
        pdfDoc.Add(table4)

        table3 = New PdfPTable(6)
        widths3 = New Single() {3.0F, 1.0F, 1.0F, 2.0F, 2.0F, 1.0F}
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)
        col1 = New PdfPCell(New Phrase("", FontB8))
        col1.Border = 0
        table3.AddCell(col1)
        col1 = New PdfPCell(New Phrase("", FontB8))
        col1.Border = 0
        table3.AddCell(col1)
        col1 = New PdfPCell(New Phrase("", FontB8))
        col1.Border = 0
        table3.AddCell(col1)
        col1 = New PdfPCell(New Phrase("", FontB12))
        col1.Border = 0
        table3.AddCell(col1)
        col1 = New PdfPCell(New Phrase("Total: " + Convert.ToString(subTotal), FontB12))
        col1.Border = 0
        col1.HorizontalAlignment = 2
        table3.AddCell(col1)
        table3.AddCell(CVacio)
        pdfDoc.Add(table3)
        pdfDoc.Close()
        Process.Start("nuevo_pdf.pdf")
    End Sub
End Class