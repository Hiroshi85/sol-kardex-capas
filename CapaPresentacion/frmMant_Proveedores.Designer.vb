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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVProveedores
        '
        Me.DGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedor, Me.Proveedor, Me.Descripcion, Me.Correo, Me.Direccion, Me.Telefono})
        Me.DGVProveedores.Location = New System.Drawing.Point(12, 272)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.RowHeadersWidth = 51
        Me.DGVProveedores.RowTemplate.Height = 24
        Me.DGVProveedores.Size = New System.Drawing.Size(1190, 219)
        Me.DGVProveedores.TabIndex = 0
        '
        'Proveedores
        '
        Me.Proveedores.AutoSize = True
        Me.Proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedores.Location = New System.Drawing.Point(503, 9)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(163, 29)
        Me.Proveedores.TabIndex = 1
        Me.Proveedores.Text = "Proveedores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(530, 82)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(234, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(874, 74)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(111, 60)
        Me.btnAñadir.TabIndex = 4
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(874, 148)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 60)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(192, 497)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(113, 53)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(377, 497)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 53)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(1076, 497)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(113, 53)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(121, 232)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(248, 22)
        Me.txtBuscar.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(471, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Listado de Proveedores"
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
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(134, 82)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(235, 22)
        Me.txtProveedor.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(410, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(134, 119)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(235, 22)
        Me.txtDireccion.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(134, 155)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 22)
        Me.txtTelefono.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Teléfono"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(476, 155)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(276, 22)
        Me.txtCorreo.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Correo Electrónico"
        '
        'frmMant_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 562)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Proveedores)
        Me.Controls.Add(Me.DGVProveedores)
        Me.Name = "frmMant_Proveedores"
        Me.Text = "frmMant_Proveedores"
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label7 As Label
End Class
