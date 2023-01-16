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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NudHoja = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMinimo = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtActual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.NumItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NudKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMovDeKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudHoja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NudKardex
        '
        Me.NudKardex.Location = New System.Drawing.Point(160, 32)
        Me.NudKardex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudKardex.Name = "NudKardex"
        Me.NudKardex.Size = New System.Drawing.Size(120, 22)
        Me.NudKardex.TabIndex = 0
        Me.NudKardex.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DGVMovDeKardex
        '
        Me.DGVMovDeKardex.AllowUserToAddRows = False
        Me.DGVMovDeKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovDeKardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumItem, Me.NumDocumento, Me.IdTipoMov, Me.PrecioDocumento, Me.StockActual, Me.CantidadEntrada, Me.CantidadSalida, Me.StockFinal})
        Me.DGVMovDeKardex.Location = New System.Drawing.Point(105, 211)
        Me.DGVMovDeKardex.Name = "DGVMovDeKardex"
        Me.DGVMovDeKardex.RowTemplate.Height = 24
        Me.DGVMovDeKardex.Size = New System.Drawing.Size(1126, 263)
        Me.DGVMovDeKardex.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo Producto:"
        '
        'NudHoja
        '
        Me.NudHoja.Location = New System.Drawing.Point(363, 32)
        Me.NudHoja.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudHoja.Name = "NudHoja"
        Me.NudHoja.Size = New System.Drawing.Size(120, 22)
        Me.NudHoja.TabIndex = 3
        Me.NudHoja.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hoja:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(503, 23)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(164, 39)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stock Mínimo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock Actual"
        '
        'TxtMinimo
        '
        Me.TxtMinimo.Location = New System.Drawing.Point(137, 90)
        Me.TxtMinimo.Name = "TxtMinimo"
        Me.TxtMinimo.Size = New System.Drawing.Size(100, 22)
        Me.TxtMinimo.TabIndex = 9
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(457, 90)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(271, 22)
        Me.DtpFecha.TabIndex = 10
        Me.DtpFecha.Visible = False
        '
        'TxtActual
        '
        Me.TxtActual.Location = New System.Drawing.Point(137, 134)
        Me.TxtActual.Name = "TxtActual"
        Me.TxtActual.ReadOnly = True
        Me.TxtActual.Size = New System.Drawing.Size(100, 22)
        Me.TxtActual.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de Apertura"
        Me.Label5.Visible = False
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(243, 139)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(13, 17)
        Me.LblEstado.TabIndex = 12
        Me.LblEstado.Text = "-"
        '
        'NumItem
        '
        Me.NumItem.HeaderText = "N°"
        Me.NumItem.Name = "NumItem"
        Me.NumItem.ReadOnly = True
        '
        'NumDocumento
        '
        Me.NumDocumento.HeaderText = "Documento"
        Me.NumDocumento.Name = "NumDocumento"
        Me.NumDocumento.ReadOnly = True
        '
        'IdTipoMov
        '
        Me.IdTipoMov.HeaderText = "Movimiento"
        Me.IdTipoMov.Name = "IdTipoMov"
        Me.IdTipoMov.ReadOnly = True
        '
        'PrecioDocumento
        '
        Me.PrecioDocumento.HeaderText = "Precio"
        Me.PrecioDocumento.Name = "PrecioDocumento"
        Me.PrecioDocumento.ReadOnly = True
        '
        'StockActual
        '
        Me.StockActual.HeaderText = "Stock Actual"
        Me.StockActual.Name = "StockActual"
        Me.StockActual.ReadOnly = True
        '
        'CantidadEntrada
        '
        Me.CantidadEntrada.HeaderText = "Entrada"
        Me.CantidadEntrada.Name = "CantidadEntrada"
        Me.CantidadEntrada.ReadOnly = True
        '
        'CantidadSalida
        '
        Me.CantidadSalida.HeaderText = "Salida"
        Me.CantidadSalida.Name = "CantidadSalida"
        Me.CantidadSalida.ReadOnly = True
        '
        'StockFinal
        '
        Me.StockFinal.HeaderText = "Stock Final"
        Me.StockFinal.Name = "StockFinal"
        Me.StockFinal.ReadOnly = True
        '
        'frmKardex_Movs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 539)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.TxtActual)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.TxtMinimo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
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
    Friend WithEvents TxtMinimo As TextBox
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
End Class
