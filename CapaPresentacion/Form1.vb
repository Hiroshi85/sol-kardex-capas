Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmR As New frmMant_Responsables
        frmR.Visible = True

        Dim frmP As New frmMant_Proveedores
        frmP.Visible = True

<<<<<<< HEAD
        Dim frmKM As New frmKardex_Movs
        frmKM.Visible = True
=======
        Dim frmProductos As New frmMant_Productos
        frmProductos.Visible = True
>>>>>>> 16aba4609c846e6ffc997e41364345e5c000e2d4
    End Sub
End Class
