<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMant_Proveedores
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
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedores = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVProveedores
        '
        Me.DGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedor, Me.RUC, Me.Proveedor, Me.Descripcion, Me.Correo, Me.Direccion, Me.Telefono})
        Me.DGVProveedores.Location = New System.Drawing.Point(12, 319)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.RowHeadersWidth = 51
        Me.DGVProveedores.RowTemplate.Height = 24
        Me.DGVProveedores.Size = New System.Drawing.Size(1155, 233)
        Me.DGVProveedores.TabIndex = 0
        '
        'IdProveedor
        '
        Me.IdProveedor.DataPropertyName = "IdProveedor"
        Me.IdProveedor.FillWeight = 48.12834!
        Me.IdProveedor.HeaderText = "ID"
        Me.IdProveedor.MinimumWidth = 6
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.ReadOnly = True
        '
        'RUC
        '
        Me.RUC.DataPropertyName = "RUC"
        Me.RUC.HeaderText = "RUC"
        Me.RUC.MinimumWidth = 6
        Me.RUC.Name = "RUC"
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.FillWeight = 150.4922!
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.MaxInputLength = 30
        Me.Proveedor.MinimumWidth = 6
        Me.Proveedor.Name = "Proveedor"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.FillWeight = 118.9635!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 30
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.FillWeight = 120.4335!
        Me.Correo.HeaderText = "Correo Electrónico"
        Me.Correo.MinimumWidth = 6
        Me.Correo.Name = "Correo"
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.FillWeight = 112.7975!
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.MinimumWidth = 6
        Me.Direccion.Name = "Direccion"
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.FillWeight = 49.18496!
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.MaxInputLength = 13
        Me.Telefono.MinimumWidth = 6
        Me.Telefono.Name = "Telefono"
        '
        'Proveedores
        '
        Me.Proveedores.AutoSize = True
        Me.Proveedores.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedores.Location = New System.Drawing.Point(503, 10)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(152, 27)
        Me.Proveedores.TabIndex = 1
        Me.Proveedores.Text = "Proveedores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(618, 49)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(264, 21)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.SystemColors.Window
        Me.btnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadir.Location = New System.Drawing.Point(1056, 88)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(111, 64)
        Me.btnAñadir.TabIndex = 4
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Window
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(1056, 171)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 64)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.Window
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Location = New System.Drawing.Point(200, 568)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(113, 56)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Window
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(385, 568)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 56)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Window
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1084, 568)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(113, 56)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 271)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(248, 21)
        Me.txtBuscar.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Buscar"
        '
        'txtProveedor
        '
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(266, 49)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(316, 21)
        Me.txtProveedor.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(631, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(26, 54)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(235, 21)
        Me.txtDireccion.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(670, 54)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 21)
        Me.txtTelefono.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(665, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Teléfono"
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(363, 54)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(276, 21)
        Me.txtCorreo.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Correo Electrónico"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtRUC)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtProveedor)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Location = New System.Drawing.Point(49, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 87)
        Me.Panel1.TabIndex = 21
        '
        'txtRUC
        '
        Me.txtRUC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(28, 49)
        Me.txtRUC.MaxLength = 11
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(166, 21)
        Me.txtRUC.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "RUC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Datos del Proveedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(238, 21)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Información de Contacto"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(49, 171)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 93)
        Me.Panel2.TabIndex = 23
        '
        'frmMant_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1196, 627)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.Proveedores)
        Me.Controls.Add(Me.DGVProveedores)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMant_Proveedores"
        Me.Text = "Mantenedor Proveedores"
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVProveedores As DataGridView
    Friend WithEvents Proveedores As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents RUC As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
End Class
