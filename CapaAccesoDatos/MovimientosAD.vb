Imports CapaEntidad
Imports System.Data.SqlClient
Public Class MovimientosAD
    Public Function ListarMovimientos(obj As Integer) As List(Of Movimiento)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Movimiento)
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandText = "select * from MOVIMIENTO where NumDocumento=" + Convert.ToString(obj)
            oComando.CommandType = CommandType.Text
            Dim oLector As SqlDataReader
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    lista.Add(
                        New Movimiento With {
                            .NumItem = oLector.Item(0),
                            .IdTipoMov = oLector.Item(9),
                            .CodigoProducto = oLector.Item(1),
                            .NumDocumento = oLector.Item(2),
                            .NumHoja = oLector.Item(3),
                            .PrecioDocumento = oLector.Item(4),
                            .StockAnterior = oLector.Item(5),
                            .CantidadEntrada = If(oLector.Item(6) Is DBNull.Value, Nothing, Convert.ToInt16(oLector.Item(6))),
                            .CantidadSalida = If(oLector.Item(7) Is DBNull.Value, Nothing, Convert.ToInt16(oLector.Item(7))),
                            .StockActual = oLector.Item(8)
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

    Public Sub InsertarMovEntrada(x As Movimiento)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_INSERT_MOV_ENTRADA"
            oComando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = x.CodigoProducto
            oComando.Parameters.Add("@NumDocumento", SqlDbType.Int).Value = x.NumDocumento
            oComando.Parameters.Add("@PrecioDocumento", SqlDbType.Money).Value = x.PrecioDocumento
            oComando.Parameters.Add("@CantidadEntrada", SqlDbType.Float).Value = x.CantidadEntrada
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub

    Public Sub InsertarMovSalida(x As Movimiento)
        Dim oConeccion As New SqlConnection("server=.; Integrated Security = true; DataBase = EMPRESA_LIMPIEZA")
        Dim oComando As New SqlCommand
        Try
            oConeccion.Open()
            oComando.Connection = oConeccion
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_INSERT_MOV_SALIDA"
            oComando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = x.CodigoProducto
            oComando.Parameters.Add("@NumDocumento", SqlDbType.Int).Value = x.NumDocumento
            oComando.Parameters.Add("@PrecioDocumento", SqlDbType.Money).Value = x.PrecioDocumento
            oComando.Parameters.Add("@CantidadSalida", SqlDbType.Float).Value = x.CantidadSalida
            oComando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            oConeccion.Close()
        End Try
    End Sub
End Class
