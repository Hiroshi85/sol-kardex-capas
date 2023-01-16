Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmR As New frmMant_Responsables
        frmR.Visible = True

        'Dim frmP As New frmMant_Proveedores
        'frmP.Visible = True
        Dim frmKM As New frmKardex_Movs
        frmKM.Visible = True
        'Dim frmProductos As New FrmMant_Productos
        'frmProductos.Visible = True
    End Sub
End Class
