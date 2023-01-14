Imports CapaEntidad
Imports CapaNegocios
Public Class frmMant_Responsables

    Private Sub frmMant_Responsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarResponsables()
        listarProveedores()
    End Sub
    Private Sub listarResponsables()
        Dim lista As List(Of Responsable)
        lista = ResponsableLN.ListarResponsables
        DGVResponsables.AllowUserToOrderColumns = True
        DGVResponsables.DataSource = lista
    End Sub

    Private Sub listarProveedores()
        Dim lista As List(Of Proveedor)
        lista = ProveedorLN.ListarProveedores
        DGVProveedores.DataSource = lista
    End Sub
End Class