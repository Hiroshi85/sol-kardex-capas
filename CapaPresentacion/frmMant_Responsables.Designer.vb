<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMant_Responsables
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
        Me.DGVResponsables = New System.Windows.Forms.DataGridView()
        Me.CodigoResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBuscarCodigoResp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblResp = New System.Windows.Forms.Label()
        CType(Me.DGVResponsables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVResponsables
        '
        Me.DGVResponsables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVResponsables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoResponsable, Me.NumDNI, Me.Nombre, Me.FechaNacimiento})
        Me.DGVResponsables.Location = New System.Drawing.Point(24, 200)
        Me.DGVResponsables.MultiSelect = False
        Me.DGVResponsables.Name = "DGVResponsables"
        Me.DGVResponsables.RowHeadersWidth = 51
        Me.DGVResponsables.RowTemplate.Height = 24
        Me.DGVResponsables.Size = New System.Drawing.Size(1049, 263)
        Me.DGVResponsables.TabIndex = 0
        '
        'CodigoResponsable
        '
        Me.CodigoResponsable.DataPropertyName = "CodigoResponsable"
        Me.CodigoResponsable.HeaderText = "Código"
        Me.CodigoResponsable.MinimumWidth = 6
        Me.CodigoResponsable.Name = "CodigoResponsable"
        '
        'NumDNI
        '
        Me.NumDNI.DataPropertyName = "NumDNI"
        Me.NumDNI.HeaderText = "DNI"
        Me.NumDNI.MinimumWidth = 6
        Me.NumDNI.Name = "NumDNI"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimiento.HeaderText = "Fecha de Nacimiento"
        Me.FechaNacimiento.MinimumWidth = 6
        Me.FechaNacimiento.Name = "FechaNacimiento"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBuscarCodigoResp)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Controls.Add(Me.btnAñadir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblResp)
        Me.Panel1.Controls.Add(Me.DGVResponsables)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 473)
        Me.Panel1.TabIndex = 1
        '
        'txtBuscarCodigoResp
        '
        Me.txtBuscarCodigoResp.Location = New System.Drawing.Point(812, 166)
        Me.txtBuscarCodigoResp.Name = "txtBuscarCodigoResp"
        Me.txtBuscarCodigoResp.Size = New System.Drawing.Size(261, 22)
        Me.txtBuscarCodigoResp.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(616, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Buscar Responsable"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(970, 78)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 66)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1082, 290)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(103, 55)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1082, 215)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(103, 55)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(843, 80)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(105, 64)
        Me.btnAñadir.TabIndex = 6
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DATOS DEL RESPONSABLE"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtDNI)
        Me.Panel2.Controls.Add(Me.dtpFechaNacimiento)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Location = New System.Drawing.Point(24, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 87)
        Me.Panel2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(63, 11)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(125, 22)
        Me.txtDNI.TabIndex = 1
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(210, 47)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(273, 22)
        Me.dtpFechaNacimiento.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(419, 11)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(328, 22)
        Me.txtNombre.TabIndex = 2
        '
        'lblResp
        '
        Me.lblResp.AutoSize = True
        Me.lblResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResp.Location = New System.Drawing.Point(551, 0)
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Size = New System.Drawing.Size(148, 25)
        Me.lblResp.TabIndex = 0
        Me.lblResp.Text = "Responsables"
        '
        'frmMant_Responsables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMant_Responsables"
        Me.Text = "frmMant_Responsables"
        CType(Me.DGVResponsables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVResponsables As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblResp As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents txtBuscarCodigoResp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents CodigoResponsable As DataGridViewTextBoxColumn
    Friend WithEvents NumDNI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
End Class
