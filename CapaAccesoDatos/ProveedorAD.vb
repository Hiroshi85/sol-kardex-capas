Imports CapaEntidad
Imports System.Data.SqlClient

Public Class ProveedorAD
    Private ReadOnly _conexion As ConexionAD
    Public Sub New()
        _conexion = New ConexionAD()
    End Sub
    Public Function ListarProveedores() As List(Of Proveedor)
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Proveedor)
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandText = "select * from PROVEEDOR where borrado = 0"
            oComando.CommandType = CommandType.Text
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Proveedor With {
                            .IdProveedor = oLector.Item(0),
                            .Descripcion = oLector.Item(1)
                        }
                    )
                End While
            End If
            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Function

    Public Sub Insertar(x As Proveedor)
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_INSERT_PROVEEDOR"
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x.Descripcion
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Sub

    Public Sub Actualizar(x As Proveedor)
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_UPDATE_PROVEEDOR"
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x.Descripcion
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Sub

    Public Sub Eliminar(x As Integer)
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_DELETE_PROVEEDOR"
            oComando.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = x
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Sub

    Public Function Buscar(x As String) As List(Of Proveedor)
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Proveedor)
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandText = "SP_SEARCH_PROVEEDOR"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Proveedor With {
                            .IdProveedor = oLector.Item(0),
                            .Descripcion = oLector.Item(1)
                        }
                    )
                End While
            End If
            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Function
End Class
