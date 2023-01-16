Imports CapaEntidad
Imports System.Data.SqlClient
Public Class MedidaAD
    Private ReadOnly _conexion As ConexionAD
    Public Sub New()
        _conexion = New ConexionAD()
    End Sub
    Public Function ListarMedidas() As List(Of Medida)
        Dim cmd As New SqlCommand
        Dim lista As New List(Of Medida)
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SELECT * FROM MEDIDA"
            cmd.CommandType = CommandType.Text
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If (lector.HasRows) Then
                While (lector.Read)
                    lista.Add(
                        New Medida With {
                        .IdMedida = lector.Item(0),
                        .Unidad = lector.Item(1)
                    }
                    )
                End While
            End If
            _conexion.CerrarConexion()
        End If
        Return lista
    End Function

    Public Function GetMedida(IdMedida As Integer) As Medida
        Dim cmd As New SqlCommand
        Dim MedidaN As New Medida
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SELECT * FROM MEDIDA WHERE IdMedida = @IdMedida"
            cmd.Parameters.Add("@IdMedida", SqlDbType.Int).Value = IdMedida
            cmd.CommandType = CommandType.Text
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If (lector.Read) Then

                MedidaN = New Medida With {
                        .IdMedida = lector.Item(0),
                        .Unidad = lector.Item(1)
                    }

            End If

            _conexion.CerrarConexion()
        End If
        Return MedidaN
    End Function
End Class
