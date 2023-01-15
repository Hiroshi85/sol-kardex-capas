Imports CapaEntidad
Imports System.Data.SqlClient
Public Class ProveedorAD
    Public Function ListarProveedores() As List(Of Proveedor)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Proveedor)
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
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
            oConeccion.Close()
        End Try
    End Function

    Public Sub Insertar(x As Proveedor)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_INSERT_PROVEEDOR"
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x.Descripcion
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub

    Public Sub Actualizar(x As Proveedor)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_UPDATE_PROVEEDOR"
            oComando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = x.Descripcion
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub

    Public Sub Eliminar(x As Proveedor)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_DELETE_PROVEEDOR"
            oComando.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = x.IdProveedor
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub
End Class
