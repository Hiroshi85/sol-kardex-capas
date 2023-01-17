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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblNumDoc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.NumItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVMovimientos
        '
        Me.DGVMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumItem, Me.CodigoProducto, Me.NumHoja, Me.PrecioDocumento, Me.StockAnterior, Me.CantidadSalida, Me.CantidadEntrada, Me.StockActual})
        Me.DGVMovimientos.Location = New System.Drawing.Point(35, 363)
        Me.DGVMovimientos.Name = "DGVMovimientos"
        Me.DGVMovimientos.RowHeadersWidth = 51
        Me.DGVMovimientos.RowTemplate.Height = 24
        Me.DGVMovimientos.Size = New System.Drawing.Size(1025, 258)
        Me.DGVMovimientos.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 32)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "DOCUMENTO NUM "
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(311, 146)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(0, 24)
        Me.lblProveedor.TabIndex = 33
        '
        'lblNumDoc
        '
        Me.lblNumDoc.AutoSize = True
        Me.lblNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDoc.Location = New System.Drawing.Point(602, 34)
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.Size = New System.Drawing.Size(0, 32)
        Me.lblNumDoc.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 29)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "FECHA EMISION:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 29)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ID PROVEEDOR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(560, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 29)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "TIPO DOCUMENTO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(564, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CODIGO RESPONSABLE:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(315, 101)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 24)
        Me.lblFecha.TabIndex = 39
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.Location = New System.Drawing.Point(877, 101)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(0, 24)
        Me.lblDocumento.TabIndex = 40
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.Location = New System.Drawing.Point(875, 142)
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
        Me.Panel1.Location = New System.Drawing.Point(35, 231)
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
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "MOVIMIENTO:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(881, 231)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 42)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.Text = "Agregar Movimiento"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(879, 290)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(130, 42)
        Me.btnLimpiar.TabIndex = 45
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
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
        'frmMant_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 687)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblResponsable)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNumDoc)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVMovimientos)
        Me.Name = "frmMant_Movimientos"
        Me.Text = "PRUEBA"
        CType(Me.DGVMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMovimientos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblNumDoc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
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
End Class
