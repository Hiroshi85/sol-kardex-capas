<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKardex_Movs
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
        Me.NudKardex = New System.Windows.Forms.NumericUpDown()
        Me.DGVMovDeKardex = New System.Windows.Forms.DataGridView()
        Me.NumItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NudHoja = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtActual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.BtnIr = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtUnidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFalta = New System.Windows.Forms.TextBox()
        Me.lblFalta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NudMinimo = New System.Windows.Forms.NumericUpDown()
        Me.NudRepo = New System.Windows.Forms.NumericUpDown()
        CType(Me.NudKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMovDeKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudHoja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NudMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NudKardex
        '
        Me.NudKardex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudKardex.Location = New System.Drawing.Point(219, 95)
        Me.NudKardex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudKardex.Name = "NudKardex"
        Me.NudKardex.Size = New System.Drawing.Size(120, 27)
        Me.NudKardex.TabIndex = 0
        Me.NudKardex.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DGVMovDeKardex
        '
        Me.DGVMovDeKardex.AllowUserToAddRows = False
        Me.DGVMovDeKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovDeKardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumItem, Me.NumDocumento, Me.IdTipoMov, Me.PrecioDocumento, Me.StockActual, Me.CantidadEntrada, Me.CantidadSalida, Me.StockFinal})
        Me.DGVMovDeKardex.Location = New System.Drawing.Point(26, 380)
        Me.DGVMovDeKardex.Name = "DGVMovDeKardex"
        Me.DGVMovDeKardex.RowHeadersWidth = 51
        Me.DGVMovDeKardex.RowTemplate.Height = 24
        Me.DGVMovDeKardex.Size = New System.Drawing.Size(1116, 361)
        Me.DGVMovDeKardex.TabIndex = 1
        '
        'NumItem
        '
        Me.NumItem.HeaderText = "N°"
        Me.NumItem.MinimumWidth = 6
        Me.NumItem.Name = "NumItem"
        Me.NumItem.ReadOnly = True
        Me.NumItem.Width = 125
        '
        'NumDocumento
        '
        Me.NumDocumento.HeaderText = "Documento"
        Me.NumDocumento.MinimumWidth = 6
        Me.NumDocumento.Name = "NumDocumento"
        Me.NumDocumento.ReadOnly = True
        Me.NumDocumento.Width = 125
        '
        'IdTipoMov
        '
        Me.IdTipoMov.HeaderText = "Movimiento"
        Me.IdTipoMov.MinimumWidth = 6
        Me.IdTipoMov.Name = "IdTipoMov"
        Me.IdTipoMov.ReadOnly = True
        Me.IdTipoMov.Width = 125
        '
        'PrecioDocumento
        '
        Me.PrecioDocumento.HeaderText = "Precio"
        Me.PrecioDocumento.MinimumWidth = 6
        Me.PrecioDocumento.Name = "PrecioDocumento"
        Me.PrecioDocumento.ReadOnly = True
        Me.PrecioDocumento.Width = 125
        '
        'StockActual
        '
        Me.StockActual.HeaderText = "Stock Actual"
        Me.StockActual.MinimumWidth = 6
        Me.StockActual.Name = "StockActual"
        Me.StockActual.ReadOnly = True
        Me.StockActual.Width = 125
        '
        'CantidadEntrada
        '
        Me.CantidadEntrada.HeaderText = "Entrada"
        Me.CantidadEntrada.MinimumWidth = 6
        Me.CantidadEntrada.Name = "CantidadEntrada"
        Me.CantidadEntrada.ReadOnly = True
        Me.CantidadEntrada.Width = 125
        '
        'CantidadSalida
        '
        Me.CantidadSalida.HeaderText = "Salida"
        Me.CantidadSalida.MinimumWidth = 6
        Me.CantidadSalida.Name = "CantidadSalida"
        Me.CantidadSalida.ReadOnly = True
        Me.CantidadSalida.Width = 125
        '
        'StockFinal
        '
        Me.StockFinal.HeaderText = "Stock Final"
        Me.StockFinal.MinimumWidth = 6
        Me.StockFinal.Name = "StockFinal"
        Me.StockFinal.ReadOnly = True
        Me.StockFinal.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo Producto:"
        '
        'NudHoja
        '
        Me.NudHoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudHoja.Location = New System.Drawing.Point(105, 327)
        Me.NudHoja.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudHoja.Name = "NudHoja"
        Me.NudHoja.Size = New System.Drawing.Size(120, 27)
        Me.NudHoja.TabIndex = 3
        Me.NudHoja.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hoja:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(354, 88)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(164, 39)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mínimo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Actual:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(871, 327)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(271, 22)
        Me.DtpFecha.TabIndex = 10
        Me.DtpFecha.Visible = False
        '
        'TxtActual
        '
        Me.TxtActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtActual.Location = New System.Drawing.Point(110, 21)
        Me.TxtActual.Name = "TxtActual"
        Me.TxtActual.ReadOnly = True
        Me.TxtActual.Size = New System.Drawing.Size(100, 27)
        Me.TxtActual.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(739, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de Apertura"
        Me.Label5.Visible = False
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(334, 21)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(16, 24)
        Me.LblEstado.TabIndex = 12
        Me.LblEstado.Text = "-"
        '
        'BtnIr
        '
        Me.BtnIr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIr.Location = New System.Drawing.Point(241, 327)
        Me.BtnIr.Name = "BtnIr"
        Me.BtnIr.Size = New System.Drawing.Size(79, 27)
        Me.BtnIr.TabIndex = 13
        Me.BtnIr.Text = "Ir"
        Me.BtnIr.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NudRepo)
        Me.Panel1.Controls.Add(Me.NudMinimo)
        Me.Panel1.Controls.Add(Me.BtnActualizar)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtUnidad)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtFalta)
        Me.Panel1.Controls.Add(Me.lblFalta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblEstado)
        Me.Panel1.Controls.Add(Me.TxtActual)
        Me.Panel1.Location = New System.Drawing.Point(674, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 183)
        Me.Panel1.TabIndex = 14
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(292, 121)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 43)
        Me.BtnActualizar.TabIndex = 20
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 24)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Reposicion:"
        '
        'TxtUnidad
        '
        Me.TxtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnidad.Location = New System.Drawing.Point(110, 105)
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.ReadOnly = True
        Me.TxtUnidad.Size = New System.Drawing.Size(130, 27)
        Me.TxtUnidad.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Unidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado:"
        '
        'TxtFalta
        '
        Me.TxtFalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFalta.Location = New System.Drawing.Point(316, 62)
        Me.TxtFalta.Name = "TxtFalta"
        Me.TxtFalta.ReadOnly = True
        Me.TxtFalta.Size = New System.Drawing.Size(100, 27)
        Me.TxtFalta.TabIndex = 14
        '
        'lblFalta
        '
        Me.lblFalta.AutoSize = True
        Me.lblFalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFalta.Location = New System.Drawing.Point(249, 63)
        Me.lblFalta.Name = "lblFalta"
        Me.lblFalta.Size = New System.Drawing.Size(55, 24)
        Me.lblFalta.TabIndex = 13
        Me.lblFalta.Text = "Falta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(670, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(235, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(796, 32)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "HOJA DE REGISTRO DE MOVIMIENTOS DE PRODUCTO"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtPrecio)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TxtCategoria)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtDesc)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(37, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(606, 112)
        Me.Panel2.TabIndex = 17
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(455, 68)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(134, 27)
        Me.TxtPrecio.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(312, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 24)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Precio base: S/"
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategoria.Location = New System.Drawing.Point(109, 68)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.ReadOnly = True
        Me.TxtCategoria.Size = New System.Drawing.Size(160, 27)
        Me.TxtCategoria.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 24)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Categoría:"
        '
        'TxtDesc
        '
        Me.TxtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(129, 9)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.ReadOnly = True
        Me.TxtDesc.Size = New System.Drawing.Size(461, 24)
        Me.TxtDesc.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Descripcion:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(128, 154)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(108, 24)
        Me.LblNombre.TabIndex = 18
        Me.LblNombre.Text = "Información"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombre: "
        '
        'NudMinimo
        '
        Me.NudMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMinimo.Location = New System.Drawing.Point(107, 62)
        Me.NudMinimo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudMinimo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMinimo.Name = "NudMinimo"
        Me.NudMinimo.Size = New System.Drawing.Size(120, 27)
        Me.NudMinimo.TabIndex = 21
        Me.NudMinimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudRepo
        '
        Me.NudRepo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudRepo.Location = New System.Drawing.Point(140, 144)
        Me.NudRepo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudRepo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudRepo.Name = "NudRepo"
        Me.NudRepo.Size = New System.Drawing.Size(100, 27)
        Me.NudRepo.TabIndex = 22
        Me.NudRepo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmKardex_Movs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1175, 810)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnIr)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NudHoja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVMovDeKardex)
        Me.Controls.Add(Me.NudKardex)
        Me.Name = "frmKardex_Movs"
        Me.Text = "Kardex de Movimientos"
        CType(Me.NudKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMovDeKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudHoja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NudMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudRepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NudKardex As NumericUpDown
    Friend WithEvents DGVMovDeKardex As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents NudHoja As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TxtActual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents NumItem As DataGridViewTextBoxColumn
    Friend WithEvents NumDocumento As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoMov As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDocumento As DataGridViewTextBoxColumn
    Friend WithEvents StockActual As DataGridViewTextBoxColumn
    Friend WithEvents CantidadEntrada As DataGridViewTextBoxColumn
    Friend WithEvents CantidadSalida As DataGridViewTextBoxColumn
    Friend WithEvents StockFinal As DataGridViewTextBoxColumn
    Friend WithEvents BtnIr As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtFalta As TextBox
    Friend WithEvents lblFalta As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtUnidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents NudMinimo As NumericUpDown
    Friend WithEvents NudRepo As NumericUpDown
End Class
