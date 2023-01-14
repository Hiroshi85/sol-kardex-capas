<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMant_Responsables
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
        Me.DGVResponsables = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblResp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        CType(Me.DGVResponsables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVResponsables
        '
        Me.DGVResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVResponsables.Location = New System.Drawing.Point(3, 113)
        Me.DGVResponsables.Name = "DGVResponsables"
        Me.DGVResponsables.RowHeadersWidth = 51
        Me.DGVResponsables.RowTemplate.Height = 24
        Me.DGVResponsables.Size = New System.Drawing.Size(462, 150)
        Me.DGVResponsables.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblResp)
        Me.Panel1.Controls.Add(Me.DGVResponsables)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 474)
        Me.Panel1.TabIndex = 1
        '
        'lblResp
        '
        Me.lblResp.AutoSize = True
        Me.lblResp.Location = New System.Drawing.Point(40, 18)
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Size = New System.Drawing.Size(98, 17)
        Me.lblResp.TabIndex = 0
        Me.lblResp.Text = "Responsables"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGVProveedores)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(575, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 474)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedores"
        '
        'DGVProveedores
        '
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Location = New System.Drawing.Point(3, 113)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.RowHeadersWidth = 51
        Me.DGVProveedores.RowTemplate.Height = 24
        Me.DGVProveedores.Size = New System.Drawing.Size(494, 150)
        Me.DGVProveedores.TabIndex = 1
        '
        'frmMant_Responsables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMant_Responsables"
        Me.Text = "frmMant_Responsables"
        CType(Me.DGVResponsables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVResponsables As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblResp As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVProveedores As DataGridView
End Class
