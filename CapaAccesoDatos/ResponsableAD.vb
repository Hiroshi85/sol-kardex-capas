Imports CapaEntidad
Imports System.Data.SqlClient
Public Class ResponsableAD
    Public Function ListarResponsables() As List(Of Responsable)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Responsable)
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandText = "select * from RESPONSABLE"
            oComando.CommandType = CommandType.Text
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Responsable With {
                            .CodigoResponsable = oLector.Item(0),
                            .NumDNI = oLector.Item(1),
                            .FechaNacimiento = oLector.Item(2),
                            .Nombre = oLector.Item(3)
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

    Public Sub Insertar(x As Responsable)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_INSERT_RESPONSABLE"
            oComando.Parameters.Add("@NumDNI", SqlDbType.Char, 8).Value = x.NumDNI
            oComando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = x.FechaNacimiento
            oComando.Parameters.Add("@Nombre", SqlDbType.VarChar, 40).Value = x.Nombre
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub

    Public Sub Actualizar(x As Responsable)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_UPDATE_RESPONSABLE"
            oComando.Parameters.Add("@CodigoResponsable", SqlDbType.VarChar, 36).Value = x.CodigoResponsable
            oComando.Parameters.Add("@NumDNI", SqlDbType.Char, 8).Value = x.NumDNI
            oComando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = x.FechaNacimiento
            oComando.Parameters.Add("@Nombre", SqlDbType.VarChar, 40).Value = x.Nombre
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub

    Public Sub Eliminar(x As Responsable)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_DELETE_RESPONSABLE"
            oComando.Parameters.Add("@CodigoResponsable", SqlDbType.VarChar, 36).Value = x.CodigoResponsable
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub

End Class
