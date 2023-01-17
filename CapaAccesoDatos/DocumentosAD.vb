Imports CapaEntidad
Imports System.Data.SqlClient
Public Class DocumentosAD

    Private ReadOnly _conexion As ConexionAD
    Public Sub New()
        _conexion = New ConexionAD()
    End Sub
    Public Function listarDocumentos() As List(Of Documento)
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Documento)
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandText = "select * from DOCUMENTO"
            oComando.CommandType = CommandType.Text
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Documento With {
                            .NumDocumento = oLector.Item(0),
                            .Fecha = oLector.Item(1),
                            .IdTipoDoc = oLector.Item(2),
                            .IdProveedor = If(oLector.Item(3) Is DBNull.Value, Nothing, Convert.ToInt16(oLector.Item(3))),
                            .CodigoResponsable = If(oLector.Item(4) Is DBNull.Value, "-", Convert.ToString(oLector.Item(4)))
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

    Public Sub Insertar(x As Documento)
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_INSERTAR_DOCUMENTO"
            oComando.Parameters.Add("@Fecha", SqlDbType.Date).Value = x.Fecha
            oComando.Parameters.Add("@IdTipoDoc", SqlDbType.Int).Value = x.IdTipoDoc
            oComando.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = x.IdProveedor
            oComando.Parameters.Add("@CodigoResponsable", SqlDbType.Char, 36).Value = x.CodigoResponsable
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Sub

    Public Function listarDocumentosSalida() As List(Of Documento)
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Documento)
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandText = "select * from DOCUMENTO where IdTipoDoc=1 or IdTipoDoc=2"
            oComando.CommandType = CommandType.Text
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Documento With {
                            .NumDocumento = oLector.Item(0),
                            .Fecha = oLector.Item(1),
                            .IdTipoDoc = oLector.Item(2),
                            .IdProveedor = If(oLector.Item(3) Is DBNull.Value, Nothing, Convert.ToInt16(oLector.Item(3))),
                            .CodigoResponsable = If(oLector.Item(4) Is DBNull.Value, "-", Convert.ToString(oLector.Item(4)))
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

    Public Function listarDocumentosEntrada() As List(Of Documento)
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Documento)
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandText = "select * from DOCUMENTO where IdTipoDoc=3"
            oComando.CommandType = CommandType.Text
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Documento With {
                            .NumDocumento = oLector.Item(0),
                            .Fecha = oLector.Item(1),
                            .IdTipoDoc = oLector.Item(2),
                            .IdProveedor = If(oLector.Item(3) Is DBNull.Value, Nothing, Convert.ToInt16(oLector.Item(3))),
                            .CodigoResponsable = If(oLector.Item(4) Is DBNull.Value, "-", Convert.ToString(oLector.Item(4)))
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
