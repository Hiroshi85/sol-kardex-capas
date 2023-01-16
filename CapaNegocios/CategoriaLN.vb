Imports CapaAccesoDatos
Imports CapaEntidad
Public Class CategoriaLN

    Private ReadOnly _categoriaAD As CategoriaAD

    Public Sub New()
        _categoriaAD = New CategoriaAD()
    End Sub

    Public Function ListarCategorias() As List(Of Categoria)
        Return _categoriaAD.ListarCategorias()
    End Function

End Class
