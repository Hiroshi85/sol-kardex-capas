<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMant_Movimientos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVMovimientos = New System.Windows.Forms.DataGridView()
        Me.NumItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumDoc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.Label()
        Me.txtIGV = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVMovimientos
        '
        Me.DGVMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumItem, Me.CodigoProducto, Me.NumHoja, Me.PrecioDocumento, Me.StockAnterior, Me.CantidadSalida, Me.CantidadEntrada, Me.StockActual})
        Me.DGVMovimientos.Location = New System.Drawing.Point(35, 376)
        Me.DGVMovimientos.Name = "DGVMovimientos"
        Me.DGVMovimientos.RowHeadersWidth = 51
        Me.DGVMovimientos.RowTemplate.Height = 24
        Me.DGVMovimientos.Size = New System.Drawing.Size(1025, 258)
        Me.DGVMovimientos.TabIndex = 30
        '
        'NumItem
        '
        Me.NumItem.DataPropertyName = "NumItem"
        Me.NumItem.HeaderText = "NumItem"
        Me.NumItem.MinimumWidth = 6
        Me.NumItem.Name = "NumItem"
        '
        'CodigoProducto
        '
        Me.CodigoProducto.DataPropertyName = "CodigoProducto"
        Me.CodigoProducto.HeaderText = "CodigoProducto"
        Me.CodigoProducto.MinimumWidth = 6
        Me.CodigoProducto.Name = "CodigoProducto"
        '
        'NumHoja
        '
        Me.NumHoja.DataPropertyName = "NumHoja"
        Me.NumHoja.HeaderText = "NumHoja"
        Me.NumHoja.MinimumWidth = 6
        Me.NumHoja.Name = "NumHoja"
        '
        'PrecioDocumento
        '
        Me.PrecioDocumento.DataPropertyName = "PrecioDocumento"
        Me.PrecioDocumento.HeaderText = "PrecioDocumento"
        Me.PrecioDocumento.MinimumWidth = 6
        Me.PrecioDocumento.Name = "PrecioDocumento"
        '
        'StockAnterior
        '
        Me.StockAnterior.DataPropertyName = "StockAnterior"
        Me.StockAnterior.HeaderText = "StockAnterior"
        Me.StockAnterior.MinimumWidth = 6
        Me.StockAnterior.Name = "StockAnterior"
        '
        'CantidadSalida
        '
        Me.CantidadSalida.DataPropertyName = "CantidadSalida"
        Me.CantidadSalida.HeaderText = "CantidadSalida"
        Me.CantidadSalida.MinimumWidth = 6
        Me.CantidadSalida.Name = "CantidadSalida"
        '
        'CantidadEntrada
        '
        Me.CantidadEntrada.DataPropertyName = "CantidadEntrada"
        Me.CantidadEntrada.HeaderText = "CantidadEntrada"
        Me.CantidadEntrada.MinimumWidth = 6
        Me.CantidadEntrada.Name = "CantidadEntrada"
        '
        'StockActual
        '
        Me.StockActual.DataPropertyName = "StockActual"
        Me.StockActual.HeaderText = "StockActual"
        Me.StockActual.MinimumWidth = 6
        Me.StockActual.Name = "StockActual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 32)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "DOCUMENTO NUM "
        '
        'lblNumDoc
        '
        Me.lblNumDoc.AutoSize = True
        Me.lblNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDoc.Location = New System.Drawing.Point(589, 27)
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.Size = New System.Drawing.Size(0, 32)
        Me.lblNumDoc.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(688, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 29)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "FECHA EMISION:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CODIGO RESPONSABLE:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(926, 203)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 24)
        Me.lblFecha.TabIndex = 39
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.Location = New System.Drawing.Point(93, 64)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(0, 36)
        Me.lblDocumento.TabIndex = 40
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.Location = New System.Drawing.Point(315, 103)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(0, 24)
        Me.lblResponsable.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(35, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 107)
        Me.Panel1.TabIndex = 42
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(193, 65)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(179, 22)
        Me.txtPrecio.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Precio Documento:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(572, 24)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(179, 22)
        Me.txtCantidad.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "(Entrada o Salida)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Cantidad"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(193, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtCodigo.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Codigo Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "MOVIMIENTO:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(881, 244)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 42)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.Text = "Agregar Movimiento"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(879, 303)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(130, 42)
        Me.btnLimpiar.TabIndex = 45
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(720, 648)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(152, 30)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "     SUB TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(730, 682)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(5)
        Me.Label12.Size = New System.Drawing.Size(164, 30)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "    I.G.V (18%)    "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(730, 716)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(162, 30)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "        TOTAL      "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoSize = True
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(901, 655)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(0, 18)
        Me.txtSubTotal.TabIndex = 49
        Me.txtSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIGV
        '
        Me.txtIGV.AutoSize = True
        Me.txtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.Location = New System.Drawing.Point(903, 689)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(0, 18)
        Me.txtIGV.TabIndex = 50
        Me.txtIGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(905, 723)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(0, 18)
        Me.txtTotal.TabIndex = 51
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblDocumento)
        Me.Panel2.Location = New System.Drawing.Point(693, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 118)
        Me.Panel2.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 36)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "R.U.C 1023301258596"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "NOMBRE: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(435, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 24)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "DNI:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(155, 142)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(109, 24)
        Me.lblNombre.TabIndex = 55
        Me.lblNombre.Text = "<Nombre>"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(506, 142)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(68, 24)
        Me.lblDNI.TabIndex = 56
        Me.lblDNI.Text = "<DNI>"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(207, 678)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(130, 42)
        Me.btnImprimir.TabIndex = 59
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(35, 678)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 42)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmMant_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 763)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIGV)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblResponsable)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNumDoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVMovimientos)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMant_Movimientos"
        Me.Text = "PRUEBA"
        CType(Me.DGVMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMovimientos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumDoc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblResponsable As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents NumItem As DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents NumHoja As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDocumento As DataGridViewTextBoxColumn
    Friend WithEvents StockAnterior As DataGridViewTextBoxColumn
    Friend WithEvents CantidadSalida As DataGridViewTextBoxColumn
    Friend WithEvents CantidadEntrada As DataGridViewTextBoxColumn
    Friend WithEvents StockActual As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSubTotal As Label
    Friend WithEvents txtIGV As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnGuardar As Button
End Class
