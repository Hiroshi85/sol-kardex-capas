Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmR As New frmMant_Responsables
        frmR.Visible = True

        Dim frmP As New frmMant_Proveedores
        frmP.Visible = True

        Dim frmProductos As New frmMant_Productos
        frmProductos.Visible = True
    End Sub
End Class
