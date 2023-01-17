<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetail_GuiaRemision
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNumDoc = New System.Windows.Forms.Label()
        Me.lblRUC = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVMovimientos = New System.Windows.Forms.DataGridView()
        Me.NumDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 32)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "GUÍA DE REMISIÓN "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(737, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 22)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Fecha de Emisión: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 29)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Remitente:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblNumDoc)
        Me.Panel1.Controls.Add(Me.lblRUC)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(720, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 192)
        Me.Panel1.TabIndex = 38
        '
        'lblNumDoc
        '
        Me.lblNumDoc.AutoSize = True
        Me.lblNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDoc.Location = New System.Drawing.Point(150, 111)
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.Size = New System.Drawing.Size(115, 32)
        Me.lblNumDoc.TabIndex = 42
        Me.lblNumDoc.Text = "<<N°>>"
        '
        'lblRUC
        '
        Me.lblRUC.AutoSize = True
        Me.lblRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUC.Location = New System.Drawing.Point(151, 16)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Size = New System.Drawing.Size(127, 29)
        Me.lblRUC.TabIndex = 41
        Me.lblRUC.Text = "<<RUC>>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 32)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "N°"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 29)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "RUC"
        '
        'DGVMovimientos
        '
        Me.DGVMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumDocumento, Me.CodigoProducto, Me.NumItem, Me.NumHoja, Me.PrecioDocumento, Me.CantidadEntrada})
        Me.DGVMovimientos.Location = New System.Drawing.Point(38, 402)
        Me.DGVMovimientos.Name = "DGVMovimientos"
        Me.DGVMovimientos.RowHeadersWidth = 51
        Me.DGVMovimientos.RowTemplate.Height = 24
        Me.DGVMovimientos.Size = New System.Drawing.Size(1120, 226)
        Me.DGVMovimientos.TabIndex = 39
        '
        'NumDocumento
        '
        Me.NumDocumento.DataPropertyName = "NumDocumento"
        Me.NumDocumento.HeaderText = "N° Documento"
        Me.NumDocumento.MinimumWidth = 6
        Me.NumDocumento.Name = "NumDocumento"
        '
        'CodigoProducto
        '
        Me.CodigoProducto.DataPropertyName = "CodigoProducto"
        Me.CodigoProducto.HeaderText = "Código de Producto"
        Me.CodigoProducto.MinimumWidth = 6
        Me.CodigoProducto.Name = "CodigoProducto"
        '
        'NumItem
        '
        Me.NumItem.DataPropertyName = "NumItem"
        Me.NumItem.HeaderText = "Item"
        Me.NumItem.MinimumWidth = 6
        Me.NumItem.Name = "NumItem"
        '
        'NumHoja
        '
        Me.NumHoja.DataPropertyName = "NumHoja"
        Me.NumHoja.HeaderText = "N° Hoja"
        Me.NumHoja.MinimumWidth = 6
        Me.NumHoja.Name = "NumHoja"
        '
        'PrecioDocumento
        '
        Me.PrecioDocumento.DataPropertyName = "PrecioDocumento"
        Me.PrecioDocumento.HeaderText = "Precio en Documento"
        Me.PrecioDocumento.MinimumWidth = 6
        Me.PrecioDocumento.Name = "PrecioDocumento"
        '
        'CantidadEntrada
        '
        Me.CantidadEntrada.DataPropertyName = "CantidadEntrada"
        Me.CantidadEntrada.HeaderText = "Cantidad de entrada"
        Me.CantidadEntrada.MinimumWidth = 6
        Me.CantidadEntrada.Name = "CantidadEntrada"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(158, 19)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(137, 22)
        Me.lblProveedor.TabIndex = 43
        Me.lblProveedor.Text = "<<Proveedor>>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 29)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(363, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 29)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Teléfono:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(245, 29)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Correo electrónico: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 29)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Rubro:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(146, 57)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(148, 22)
        Me.lblDescripcion.TabIndex = 49
        Me.lblDescripcion.Text = "<<Descripcion>>"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(146, 96)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(137, 22)
        Me.lblDireccion.TabIndex = 50
        Me.lblDireccion.Text = "<<Proveedor>>"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(505, 96)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(124, 22)
        Me.lblTelefono.TabIndex = 51
        Me.lblTelefono.Text = "<<1234567>>"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblCorreo)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblTelefono)
        Me.Panel2.Controls.Add(Me.lblDireccion)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.lblProveedor)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(23, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(678, 192)
        Me.Panel2.TabIndex = 52
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(253, 136)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(137, 22)
        Me.lblCorreo.TabIndex = 52
        Me.lblCorreo.Text = "<<Proveedor>>"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(935, 236)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(106, 22)
        Me.lblFecha.TabIndex = 52
        Me.lblFecha.Text = "dd-MM-yyyy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "MOVIMIENTO:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtPrecio)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtCantidad)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(41, 278)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 107)
        Me.Panel3.TabIndex = 54
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(193, 65)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(179, 22)
        Me.txtPrecio.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 20)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Precio Documento:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(572, 24)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(179, 22)
        Me.txtCantidad.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(488, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "(Entrada)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(481, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Cantidad"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(193, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtCodigo.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 20)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Codigo Producto"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(904, 339)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(130, 42)
        Me.btnLimpiar.TabIndex = 56
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(906, 280)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 42)
        Me.btnAgregar.TabIndex = 55
        Me.btnAgregar.Text = "Agregar Movimiento"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(1028, 634)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 42)
        Me.btnGuardar.TabIndex = 57
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(38, 634)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(130, 42)
        Me.btnImprimir.TabIndex = 58
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmDetail_GuiaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 680)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.DGVMovimientos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmDetail_GuiaRemision"
        Me.Text = "frmDetail_GuiaRemision"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVMovimientos As DataGridView
    Friend WithEvents lblNumDoc As Label
    Friend WithEvents lblRUC As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents NumDocumento As DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents NumItem As DataGridViewTextBoxColumn
    Friend WithEvents NumHoja As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDocumento As DataGridViewTextBoxColumn
    Friend WithEvents CantidadEntrada As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
End Class
