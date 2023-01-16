Imports System.Data.SqlClient

Public Class ConexionAD
    Private ReadOnly _connection As SqlConnection

    Public Sub New()
        _connection = New SqlConnection()
    End Sub

    Public Function AbrirConexion() As Boolean
        Try
            _connection.ConnectionString = "Data Source=.;Initial Catalog=EMPRESA_LIMPIEZA;Integrated Security=True"
            _connection.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerConexion() As SqlConnection
        Return _connection
    End Function

    Public Function CerrarConexion() As Boolean
        Try
            _connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class