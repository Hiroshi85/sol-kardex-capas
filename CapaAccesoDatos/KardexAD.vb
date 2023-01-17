Imports CapaEntidad
Imports System.Data.SqlClient
Public Class KardexAD
    Private ReadOnly _conexion As ConexionAD

    Public Sub New()
        _conexion = New ConexionAD()
    End Sub

    Public Function ListarMovimientosKardex(CodProd As Integer, NHoja As Integer) As List(Of Movimiento)
        Dim oComando As New SqlCommand
        Dim lista As New List(Of Movimiento)
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_MOVS_KARDEX_PAG"
            oComando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = CodProd
            oComando.Parameters.Add("@NumHoja", SqlDbType.Int).Value = NHoja
            Dim lector As SqlDataReader
            Dim Aux_Entrada As Double
            Dim Aux_Salida As Double
            lector = oComando.ExecuteReader()
            If lector.HasRows = True Then
                While lector.Read
                    If (IsDBNull(lector.Item("CantidadEntrada"))) Then
                        Aux_Entrada = -1
                    Else
                        Aux_Entrada = lector.Item("CantidadEntrada")
                    End If
                    If (IsDBNull(lector.Item("CantidadSalida"))) Then
                        Aux_Salida = -1
                    Else
                        Aux_Salida = lector.Item("CantidadSalida")
                    End If
                    lista.Add(
                        New Movimiento With {
                            .NumItem = lector.Item(0),
                            .CodigoProducto = lector.Item(1),
                            .NumDocumento = lector.Item(2),
                            .NumHoja = lector.Item(3),
                            .PrecioDocumento = lector.Item(4),
                            .StockAnterior = lector.Item(5),
                            .CantidadEntrada = Aux_Entrada,
                            .CantidadSalida = Aux_Salida,
                            .StockActual = lector.Item(8),
                            .IdTipoMov = lector.Item(9)
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

    Public Function GetUltimaHojaKardex(CodProd As Integer) As Integer
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_ULTIMA_HOJA_KARDEX"
            oComando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = CodProd
            Dim lector As SqlDataReader
            Dim ultima As Integer
            lector = oComando.ExecuteReader()

            If lector.Read Then
                If (Not IsDBNull(lector.Item("Ultima Hoja"))) Then
                    ultima = lector.Item("Ultima Hoja")
                Else
                    ultima = 1
                End If
            End If
            Return ultima
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Function
    Public Function GetKardex(CodProd As Integer) As Kardex
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_GET_KARDEX"
            oComando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = CodProd
            Dim lector As SqlDataReader
            lector = oComando.ExecuteReader()
            Dim NewKardex As Kardex
            If lector.Read Then
                NewKardex = New Kardex With {
                            .CodigoProducto = lector.Item(0),
                            .StockMinRepo = lector.Item(1),
                            .FechaApertura = lector.Item(2),
                            .CantidadReposicion = lector.Item(3)
                         }
            End If
            Return NewKardex
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Function

    Public Function GetStockActual(CodProd As Integer) As Double
        Dim oComando As New SqlCommand
        Try
            _conexion.AbrirConexion()
            oComando.Connection = _conexion.ObtenerConexion()
            oComando.CommandType = CommandType.StoredProcedure
            oComando.CommandText = "SP_StockProducto"
            oComando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = CodProd
            Dim lector As SqlDataReader
            lector = oComando.ExecuteReader()
            Dim Stock As Integer
            Stock = 0
            If lector.Read Then
                Stock = lector.Item("Stock de Producto")
            End If
            Return Stock
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            _conexion.CerrarConexion()
        End Try
    End Function

    Public Sub ActualizarKardex(Kard As Kardex)
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SP_ACTUALIZAR_KARD"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = Kard.CodigoProducto
            cmd.Parameters.Add("@StockMin", SqlDbType.Decimal).Value = Kard.StockMinRepo
            cmd.Parameters.Add("@CantRepo", SqlDbType.Decimal).Value = Kard.CantidadReposicion
            cmd.ExecuteNonQuery()
            _conexion.CerrarConexion()
        End If
    End Sub
End Class
