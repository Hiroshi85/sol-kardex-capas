Imports CapaEntidad
Imports System.Data.SqlClient
Public Class CategoriaAD
    Private ReadOnly _conexion As ConexionAD
    Public Sub New()
        _conexion = New ConexionAD()
    End Sub
    Public Function ListarCategorias() As List(Of Categoria)
        Dim cmd As New SqlCommand
        Dim lista As New List(Of Categoria)
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SELECT * FROM CATEGORIA"
            cmd.CommandType = CommandType.Text
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If (lector.HasRows) Then
                While (lector.Read)
                    lista.Add(
                        New Categoria With {
                        .IdCategoria = lector.Item(0),
                        .Descripcion = lector.Item(1)
                    }
                    )
                End While
            End If
            _conexion.CerrarConexion()
        End If
        Return lista
    End Function

    Public Function GetCategoria(Id As Integer) As Categoria
        Dim cmd As New SqlCommand
        Dim Cate As New Categoria
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SELECT * FROM CATEGORIA WHERE IdCategoria = @Id"
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
            cmd.CommandType = CommandType.Text
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If (lector.Read) Then

                Cate = New Categoria With {
                        .IdCategoria = lector.Item(0),
                        .Descripcion = lector.Item(1)
                    }

            End If

            _conexion.CerrarConexion()
        End If
        Return Cate
    End Function
End Class
