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
                            .RUC = oLector.Item(1),
                            .Proveedor = oLector.Item(2),
                            .Descripcion = oLector.Item(3),
                            .Direccion = oLector.Item(4),
                            .Telefono = oLector.Item(5),
                            .Correo = oLector.Item(6)
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
            oComando.Parameters.Add("@RUC", SqlDbType.Char, 11).Value = x.RUC
            oComando.Parameters.Add("@Proveedor", SqlDbType.VarChar, 30).Value = x.Proveedor
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x.Descripcion
            oComando.Parameters.Add("@Direccion", SqlDbType.VarChar, 30).Value = x.Direccion
            oComando.Parameters.Add("@Telefono", SqlDbType.VarChar, 13).Value = x.Telefono
            oComando.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = x.Correo
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
            oComando.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = x.IdProveedor
            oComando.Parameters.Add("@RUC", SqlDbType.Char, 11).Value = x.RUC
            oComando.Parameters.Add("@Proveedor", SqlDbType.VarChar, 30).Value = x.Proveedor
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x.Descripcion
            oComando.Parameters.Add("@Direccion", SqlDbType.VarChar, 30).Value = x.Direccion
            oComando.Parameters.Add("@Telefono", SqlDbType.VarChar, 13).Value = x.Telefono
            oComando.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = x.Correo
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
            oComando.Parameters.Add("@Proveedor", SqlDbType.VarChar, 30).Value = x
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Proveedor With {
                            .IdProveedor = oLector.Item(0),
                            .RUC = oLector.Item(1),
                            .Proveedor = oLector.Item(2),
                            .Descripcion = oLector.Item(3),
                            .Direccion = oLector.Item(4),
                            .Telefono = oLector.Item(5),
                            .Correo = oLector.Item(6)
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

    Public Function BuscarID(x As Integer) As Proveedor
        Dim oComando As New SqlCommand
        Dim proveedor As New Proveedor
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandText = "SP_SEARCH_PROVEEDORxID"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = x
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    proveedor = New Proveedor With {
                        .IdProveedor = oLector.Item(0),
                        .RUC = oLector.Item(1),
                        .Proveedor = oLector.Item(2),
                        .Descripcion = oLector.Item(3),
                        .Direccion = oLector.Item(4),
                        .Telefono = oLector.Item(5),
                        .Correo = oLector.Item(6)
                    }
                End While
            End If
            Return proveedor
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Function
End Class
