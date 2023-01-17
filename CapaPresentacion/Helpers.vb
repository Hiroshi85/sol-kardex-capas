Public Class Helpers
    Public Function ValidarPanel(panel As Panel) As Boolean
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text Is "" Then
                    MessageError("El campo " & ctrl.Name.Substring(3) & " es obligatorio!")
                    Return False
                End If
            End If
            If TypeOf ctrl Is ComboBox Then
                Dim ctrlCb = DirectCast(ctrl, ComboBox)
                If ctrlCb.SelectedIndex = -1 Then
                    MessageError("El campo " & ctrlCb.Name.Substring(3) & " es obligatorio!")
                    Return False
                End If
            End If
            If TypeOf ctrl Is Panel Then
                ValidarPanel(ctrl)
            End If
        Next
        Return True
    End Function
    Public Sub LimpiarPanel(panel As Panel)
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                Dim ctrlCb = DirectCast(ctrl, ComboBox)
                ctrlCb.SelectedIndex = -1
            End If
            If TypeOf ctrl Is Panel Then
                LimpiarPanel(ctrl)
            End If
        Next
    End Sub
    Public Sub SeleccionarUltimaFila(DGV As DataGridView)
        DGV.Rows(DGV.Rows.Count - 1).Selected = True
        DGV.FirstDisplayedScrollingRowIndex = DGV.Rows.Count - 1
    End Sub
    Public Sub MessageInformation(mensaje As String)
        MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MessageError(mensaje As String)
        MessageBox.Show(mensaje, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Function MessageConfirm(mensaje As String) As DialogResult
        Dim confirm As DialogResult = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo)
        Return confirm
    End Function
    Public Sub SeleccionarFilaDGV(DGV As DataGridView, id As Integer)
        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells(0).Value = id Then
                row.Selected = True
                DGV.FirstDisplayedScrollingRowIndex = row.Index
                Exit For
            End If
        Next
    End Sub
End Class
