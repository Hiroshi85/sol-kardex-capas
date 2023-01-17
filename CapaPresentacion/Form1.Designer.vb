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
        Me.panLogo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.btnKardex = New System.Windows.Forms.Button()
        Me.btnDocumentos = New System.Windows.Forms.Button()
        Me.btnResponsables = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.panTitle = New System.Windows.Forms.Panel()
        Me.lblTituloPanel = New System.Windows.Forms.Label()
        Me.panMain = New System.Windows.Forms.Panel()
        Me.panLogo.SuspendLayout()
        Me.panMenu.SuspendLayout()
        Me.panTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProveedores
        '
        Me.btnProveedores.BackgroundImage = CType(resources.GetObject("btnProveedores.BackgroundImage"), System.Drawing.Image)
        Me.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 157)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(222, 71)
        Me.btnProveedores.TabIndex = 0
        Me.btnProveedores.Text = "PROVEEDORES"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'panLogo
        '
        Me.panLogo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.panLogo.Controls.Add(Me.Button1)
        Me.panLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panLogo.Location = New System.Drawing.Point(0, 0)
        Me.panLogo.Name = "panLogo"
        Me.panLogo.Size = New System.Drawing.Size(225, 100)
        Me.panLogo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(2, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 71)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EMP. LIMPIEZA"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panMenu
        '
        Me.panMenu.BackColor = System.Drawing.Color.Honeydew
        Me.panMenu.Controls.Add(Me.btnResponsables)
        Me.panMenu.Controls.Add(Me.btnKardex)
        Me.panMenu.Controls.Add(Me.btnDocumentos)
        Me.panMenu.Controls.Add(Me.btnProductos)
        Me.panMenu.Controls.Add(Me.panLogo)
        Me.panMenu.Controls.Add(Me.btnProveedores)
        Me.panMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panMenu.Location = New System.Drawing.Point(0, 0)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(225, 700)
        Me.panMenu.TabIndex = 7
        '
        'btnKardex
        '
        Me.btnKardex.BackgroundImage = CType(resources.GetObject("btnKardex.BackgroundImage"), System.Drawing.Image)
        Me.btnKardex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKardex.FlatAppearance.BorderSize = 0
        Me.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKardex.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKardex.Location = New System.Drawing.Point(0, 548)
        Me.btnKardex.Name = "btnKardex"
        Me.btnKardex.Size = New System.Drawing.Size(222, 71)
        Me.btnKardex.TabIndex = 4
        Me.btnKardex.Text = "KARDEXS"
        Me.btnKardex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKardex.UseVisualStyleBackColor = True
        '
        'btnDocumentos
        '
        Me.btnDocumentos.BackgroundImage = CType(resources.GetObject("btnDocumentos.BackgroundImage"), System.Drawing.Image)
        Me.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDocumentos.FlatAppearance.BorderSize = 0
        Me.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocumentos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentos.Location = New System.Drawing.Point(2, 451)
        Me.btnDocumentos.Name = "btnDocumentos"
        Me.btnDocumentos.Size = New System.Drawing.Size(222, 71)
        Me.btnDocumentos.TabIndex = 3
        Me.btnDocumentos.Text = "DOCUMENTOS"
        Me.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDocumentos.UseVisualStyleBackColor = True
        '
        'btnResponsables
        '
        Me.btnResponsables.BackgroundImage = CType(resources.GetObject("btnResponsables.BackgroundImage"), System.Drawing.Image)
        Me.btnResponsables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnResponsables.FlatAppearance.BorderSize = 0
        Me.btnResponsables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResponsables.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResponsables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResponsables.Location = New System.Drawing.Point(2, 254)
        Me.btnResponsables.Name = "btnResponsables"
        Me.btnResponsables.Size = New System.Drawing.Size(222, 71)
        Me.btnResponsables.TabIndex = 2
        Me.btnResponsables.Text = "RESPONSABLES"
        Me.btnResponsables.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResponsables.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.BackgroundImage = CType(resources.GetObject("btnProductos.BackgroundImage"), System.Drawing.Image)
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.Location = New System.Drawing.Point(2, 352)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(222, 71)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'panTitle
        '
        Me.panTitle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.panTitle.Controls.Add(Me.lblTituloPanel)
        Me.panTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitle.Location = New System.Drawing.Point(225, 0)
        Me.panTitle.Name = "panTitle"
        Me.panTitle.Size = New System.Drawing.Size(1001, 100)
        Me.panTitle.TabIndex = 8
        '
        'lblTituloPanel
        '
        Me.lblTituloPanel.AutoSize = True
        Me.lblTituloPanel.Font = New System.Drawing.Font("Century Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPanel.Location = New System.Drawing.Point(384, 48)
        Me.lblTituloPanel.Name = "lblTituloPanel"
        Me.lblTituloPanel.Size = New System.Drawing.Size(191, 29)
        Me.lblTituloPanel.TabIndex = 0
        Me.lblTituloPanel.Text = "MANTENEDORES"
        '
        'panMain
        '
        Me.panMain.BackgroundImage = CType(resources.GetObject("panMain.BackgroundImage"), System.Drawing.Image)
        Me.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panMain.Location = New System.Drawing.Point(225, 100)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(1001, 600)
        Me.panMain.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1226, 700)
        Me.Controls.Add(Me.panMain)
        Me.Controls.Add(Me.panTitle)
        Me.Controls.Add(Me.panMenu)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panLogo.ResumeLayout(False)
        Me.panMenu.ResumeLayout(False)
        Me.panTitle.ResumeLayout(False)
        Me.panTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDocumentos As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents panLogo As Panel
    Friend WithEvents panMenu As Panel
    Friend WithEvents btnResponsables As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panTitle As Panel
    Friend WithEvents panMain As Panel
    Friend WithEvents lblTituloPanel As Label
    Friend WithEvents btnKardex As Button
End Class
