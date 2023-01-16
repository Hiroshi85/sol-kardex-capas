<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnResponsables = New System.Windows.Forms.Button()
        Me.btnDocumentos = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProveedores
        '
        Me.btnProveedores.Location = New System.Drawing.Point(20, 95)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(172, 132)
        Me.btnProveedores.TabIndex = 0
        Me.btnProveedores.Text = "PROVEEDORES"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnResponsables
        '
        Me.btnResponsables.Location = New System.Drawing.Point(240, 95)
        Me.btnResponsables.Name = "btnResponsables"
        Me.btnResponsables.Size = New System.Drawing.Size(162, 132)
        Me.btnResponsables.TabIndex = 1
        Me.btnResponsables.Text = "RESPONSABLES"
        Me.btnResponsables.UseVisualStyleBackColor = True
        '
        'btnDocumentos
        '
        Me.btnDocumentos.Location = New System.Drawing.Point(441, 95)
        Me.btnDocumentos.Name = "btnDocumentos"
        Me.btnDocumentos.Size = New System.Drawing.Size(157, 132)
        Me.btnDocumentos.TabIndex = 2
        Me.btnDocumentos.Text = "DOCUMENTOS"
        Me.btnDocumentos.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(20, 269)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 128)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(240, 269)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 128)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(441, 269)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(156, 128)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LOGO - NOMBRE EMPRESA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDocumentos)
        Me.Controls.Add(Me.btnResponsables)
        Me.Controls.Add(Me.btnProveedores)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnResponsables As Button
    Friend WithEvents btnDocumentos As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
End Class
