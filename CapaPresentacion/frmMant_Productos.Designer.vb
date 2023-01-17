<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMant_Productos
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.lblResp = New System.Windows.Forms.Label()
        Me.PanInfoProducto = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantidadReposicionKardex = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStockMinRepoKardex = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboMedidaProducto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCategoriaProducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecioBaseProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtQNombreProducto = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanInfoProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(182, 562)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(142, 48)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'DGVProductos
        '
        Me.DGVProductos.AllowUserToOrderColumns = True
        Me.DGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Location = New System.Drawing.Point(40, 377)
        Me.DGVProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVProductos.MultiSelect = False
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.RowHeadersWidth = 51
        Me.DGVProductos.RowTemplate.Height = 24
        Me.DGVProductos.Size = New System.Drawing.Size(1033, 177)
        Me.DGVProductos.TabIndex = 0
        '
        'lblResp
        '
        Me.lblResp.AutoSize = True
        Me.lblResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResp.Location = New System.Drawing.Point(467, 26)
        Me.lblResp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Size = New System.Drawing.Size(109, 25)
        Me.lblResp.TabIndex = 0
        Me.lblResp.Text = "Productos"
        '
        'PanInfoProducto
        '
        Me.PanInfoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanInfoProducto.Controls.Add(Me.Label8)
        Me.PanInfoProducto.Controls.Add(Me.Panel1)
        Me.PanInfoProducto.Controls.Add(Me.cboMedidaProducto)
        Me.PanInfoProducto.Controls.Add(Me.Label7)
        Me.PanInfoProducto.Controls.Add(Me.cboCategoriaProducto)
        Me.PanInfoProducto.Controls.Add(Me.Label6)
        Me.PanInfoProducto.Controls.Add(Me.txtPrecioBaseProducto)
        Me.PanInfoProducto.Controls.Add(Me.Label4)
        Me.PanInfoProducto.Controls.Add(Me.Label3)
        Me.PanInfoProducto.Controls.Add(Me.Label2)
        Me.PanInfoProducto.Controls.Add(Me.txtNombreProducto)
        Me.PanInfoProducto.Controls.Add(Me.txtDescripcionProducto)
        Me.PanInfoProducto.Location = New System.Drawing.Point(44, 86)
        Me.PanInfoProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.PanInfoProducto.Name = "PanInfoProducto"
        Me.PanInfoProducto.Size = New System.Drawing.Size(877, 215)
        Me.PanInfoProducto.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(448, 100)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Kardex"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCantidadReposicionKardex)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtStockMinRepoKardex)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(437, 114)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 77)
        Me.Panel1.TabIndex = 14
        '
        'txtCantidadReposicionKardex
        '
        Me.txtCantidadReposicionKardex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadReposicionKardex.Location = New System.Drawing.Point(209, 42)
        Me.txtCantidadReposicionKardex.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadReposicionKardex.Name = "txtCantidadReposicionKardex"
        Me.txtCantidadReposicionKardex.Size = New System.Drawing.Size(172, 23)
        Me.txtCantidadReposicionKardex.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 38)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Cantidad de Repo"
        '
        'txtStockMinRepoKardex
        '
        Me.txtStockMinRepoKardex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStockMinRepoKardex.Location = New System.Drawing.Point(209, 14)
        Me.txtStockMinRepoKardex.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockMinRepoKardex.Name = "txtStockMinRepoKardex"
        Me.txtStockMinRepoKardex.Size = New System.Drawing.Size(172, 23)
        Me.txtStockMinRepoKardex.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 10)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Sotck Minimo"
        '
        'cboMedidaProducto
        '
        Me.cboMedidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMedidaProducto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedidaProducto.FormattingEnabled = True
        Me.cboMedidaProducto.Location = New System.Drawing.Point(206, 154)
        Me.cboMedidaProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMedidaProducto.Name = "cboMedidaProducto"
        Me.cboMedidaProducto.Size = New System.Drawing.Size(170, 29)
        Me.cboMedidaProducto.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Medida"
        '
        'cboCategoriaProducto
        '
        Me.cboCategoriaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategoriaProducto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoriaProducto.FormattingEnabled = True
        Me.cboCategoriaProducto.Location = New System.Drawing.Point(206, 108)
        Me.cboCategoriaProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCategoriaProducto.Name = "cboCategoriaProducto"
        Me.cboCategoriaProducto.Size = New System.Drawing.Size(170, 29)
        Me.cboCategoriaProducto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Categoria"
        '
        'txtPrecioBaseProducto
        '
        Me.txtPrecioBaseProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioBaseProducto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioBaseProducto.Location = New System.Drawing.Point(206, 66)
        Me.txtPrecioBaseProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioBaseProducto.Name = "txtPrecioBaseProducto"
        Me.txtPrecioBaseProducto.Size = New System.Drawing.Size(172, 23)
        Me.txtPrecioBaseProducto.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio Base"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreProducto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(206, 17)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(172, 23)
        Me.txtNombreProducto.TabIndex = 1
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(437, 43)
        Me.txtDescripcionProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcionProducto.Multiline = True
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(406, 46)
        Me.txtDescripcionProducto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Información del Producto"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(929, 252)
        Me.btnAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(144, 49)
        Me.btnAñadir.TabIndex = 6
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(929, 191)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(142, 48)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtQNombreProducto
        '
        Me.txtQNombreProducto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNombreProducto.Location = New System.Drawing.Point(197, 336)
        Me.txtQNombreProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQNombreProducto.Name = "txtQNombreProducto"
        Me.txtQNombreProducto.Size = New System.Drawing.Size(357, 30)
        Me.txtQNombreProducto.TabIndex = 14
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(549, 562)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(142, 48)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 340)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Buscar Producto"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(367, 562)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(142, 48)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmMant_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1130, 628)
        Me.Controls.Add(Me.txtQNombreProducto)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResp)
        Me.Controls.Add(Me.PanInfoProducto)
        Me.Controls.Add(Me.DGVProductos)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMant_Productos"
        Me.Text = "Mantenedor de Productos"
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanInfoProducto.ResumeLayout(False)
        Me.PanInfoProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblResp As Label
    Friend WithEvents PanInfoProducto As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtQNombreProducto As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtPrecioBaseProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCategoriaProducto As ComboBox
    Friend WithEvents cboMedidaProducto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCantidadReposicionKardex As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStockMinRepoKardex As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVProductos As DataGridView
End Class
