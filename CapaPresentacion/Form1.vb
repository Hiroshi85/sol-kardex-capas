﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

<<<<<<< HEAD
        'Dim frmP As New frmMant_Proveedores
        'frmP.Visible = True
        Dim frmKM As New frmKardex_Movs
        frmKM.Visible = True
        'Dim frmProductos As New FrmMant_Productos
        'frmProductos.Visible = True
=======
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim frmP As New frmMant_Proveedores
        frmP.Visible = True
    End Sub

    Private Sub btnResponsables_Click(sender As Object, e As EventArgs) Handles btnResponsables.Click
        Dim frmR As New frmMant_Responsables
        frmR.Visible = True
    End Sub

    Private Sub btnDocumentos_Click(sender As Object, e As EventArgs) Handles btnDocumentos.Click
        Dim frmDoc As New frmMant_Documento
        frmDoc.Visible = True
>>>>>>> 8f1bdad884d98e054447f01236e764948364a524
    End Sub
End Class
