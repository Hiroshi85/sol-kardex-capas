<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMant_Documento
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntodos = New System.Windows.Forms.Button()
        Me.btndent = New System.Windows.Forms.Button()
        Me.btndsal = New System.Windows.Forms.Button()
        Me.DGVDocumentos = New System.Windows.Forms.DataGridView()
        Me.NumDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtIdResponsable = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarResponsable = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = ""
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btntodos)
        Me.Panel1.Controls.Add(Me.btndent)
        Me.Panel1.Controls.Add(Me.btndsal)
        Me.Panel1.Controls.Add(Me.DGVDocumentos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnAñadir)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 653)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(890, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 74)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "VER DETALLE DE DOCUMENTO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MOSTRAR DOCUMENTOS SEGUN:"
        '
        'btntodos
        '
        Me.btntodos.Location = New System.Drawing.Point(583, 256)
        Me.btntodos.Name = "btntodos"
        Me.btntodos.Size = New System.Drawing.Size(204, 46)
        Me.btntodos.TabIndex = 19
        Me.btntodos.Text = "TODOS"
        Me.btntodos.UseVisualStyleBackColor = True
        '
        'btndent
        '
        Me.btndent.Location = New System.Drawing.Point(325, 256)
        Me.btndent.Name = "btndent"
        Me.btndent.Size = New System.Drawing.Size(204, 46)
        Me.btndent.TabIndex = 18
        Me.btndent.Text = "MOSTRAR DOCS ENTRADA"
        Me.btndent.UseVisualStyleBackColor = True
        '
        'btndsal
        '
        Me.btndsal.Location = New System.Drawing.Point(62, 256)
        Me.btndsal.Name = "btndsal"
        Me.btndsal.Size = New System.Drawing.Size(204, 46)
        Me.btndsal.TabIndex = 17
        Me.btndsal.Text = "MOSTRAR DOCS SALIDA"
        Me.btndsal.UseVisualStyleBackColor = True
        '
        'DGVDocumentos
        '
        Me.DGVDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumDocumento, Me.Fecha, Me.IdTipoDoc, Me.IdProveedor, Me.CodigoResponsable})
        Me.DGVDocumentos.Location = New System.Drawing.Point(20, 323)
        Me.DGVDocumentos.Name = "DGVDocumentos"
        Me.DGVDocumentos.RowHeadersWidth = 51
        Me.DGVDocumentos.RowTemplate.Height = 24
        Me.DGVDocumentos.Size = New System.Drawing.Size(856, 310)
        Me.DGVDocumentos.TabIndex = 16
        '
        'NumDocumento
        '
        Me.NumDocumento.DataPropertyName = "NumDocumento"
        Me.NumDocumento.HeaderText = "NumDocumento"
        Me.NumDocumento.MinimumWidth = 6
        Me.NumDocumento.Name = "NumDocumento"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IdTipoDoc
        '
        Me.IdTipoDoc.DataPropertyName = "IdTipoDoc"
        Me.IdTipoDoc.HeaderText = "IdTipoDoc"
        Me.IdTipoDoc.MinimumWidth = 6
        Me.IdTipoDoc.Name = "IdTipoDoc"
        '
        'IdProveedor
        '
        Me.IdProveedor.DataPropertyName = "IdProveedor"
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.MinimumWidth = 6
        Me.IdProveedor.Name = "IdProveedor"
        '
        'CodigoResponsable
        '
        Me.CodigoResponsable.DataPropertyName = "CodigoResponsable"
        Me.CodigoResponsable.HeaderText = "CodigoResponsable"
        Me.CodigoResponsable.MinimumWidth = 6
        Me.CodigoResponsable.Name = "CodigoResponsable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 36)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "DOCUMENTOS"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(910, 147)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 29)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBuscarResponsable)
        Me.Panel2.Controls.Add(Me.txtIdResponsable)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbProveedor)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cbTipoDoc)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dtpFechaEmision)
        Me.Panel2.Location = New System.Drawing.Point(20, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 87)
        Me.Panel2.TabIndex = 10
        '
        'txtIdResponsable
        '
        Me.txtIdResponsable.Location = New System.Drawing.Point(644, 41)
        Me.txtIdResponsable.Name = "txtIdResponsable"
        Me.txtIdResponsable.Size = New System.Drawing.Size(169, 22)
        Me.txtIdResponsable.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(485, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Resonsable"
        '
        'cbProveedor
        '
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(189, 39)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(273, 24)
        Me.cbProveedor.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Proveedor"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Items.AddRange(New Object() {"Factura", "Boleta", "Guia de Remision"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(644, 11)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(169, 24)
        Me.cbTipoDoc.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(483, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de emisión:"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Location = New System.Drawing.Point(189, 9)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(273, 22)
        Me.dtpFechaEmision.TabIndex = 3
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(908, 103)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(105, 36)
        Me.btnAñadir.TabIndex = 12
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "INFORMACION DEL DOCUMENTO"
        '
        'btnBuscarResponsable
        '
        Me.btnBuscarResponsable.Location = New System.Drawing.Point(820, 39)
        Me.btnBuscarResponsable.Name = "btnBuscarResponsable"
        Me.btnBuscarResponsable.Size = New System.Drawing.Size(35, 23)
        Me.btnBuscarResponsable.TabIndex = 15
        Me.btnBuscarResponsable.Text = "..."
        Me.btnBuscarResponsable.UseVisualStyleBackColor = True
        '
        'frmMant_Documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMant_Documento"
        Me.Text = "frmMant_Documento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaEmision As DateTimePicker
    Friend WithEvents btnAñadir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTipoDoc As ComboBox
    Friend WithEvents txtIdResponsable As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVDocumentos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btntodos As Button
    Friend WithEvents btndent As Button
    Friend WithEvents btndsal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NumDocumento As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoDoc As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents CodigoResponsable As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscarResponsable As Button
End Class
