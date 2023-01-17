Public Class Form1
    Private myActiveForm As Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        If myActiveForm IsNot Nothing Then myActiveForm.Close()
        Try
            myActiveForm = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            panMain.Controls.Add(childForm)
            panMain.Tag = childForm
            childForm.BringToFront()
            childForm.Show()

            lblTituloPanel.Text = childForm.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        OpenChildForm(New frmMant_Proveedores, sender)
    End Sub

    Private Sub btnResponsables_Click(sender As Object, e As EventArgs) Handles btnResponsables.Click
        OpenChildForm(New frmMant_Responsables, sender)
    End Sub

    Private Sub btnDocumentos_Click(sender As Object, e As EventArgs) Handles btnDocumentos.Click
        OpenChildForm(New frmMant_Documento, sender)
    End Sub


    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        OpenChildForm(New FrmMant_Productos(), sender)
    End Sub

    Private Sub btnKardex_Click(sender As Object, e As EventArgs) Handles btnKardex.Click
        OpenChildForm(New frmKardex_Movs(), sender)
    End Sub
End Class
