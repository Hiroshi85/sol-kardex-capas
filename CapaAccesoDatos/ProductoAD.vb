Imports CapaEntidad
Imports System.Data.SqlClient
Public Class ProductoAD
    Private ReadOnly _conexion As ConexionAD

    Public Sub New()
        _conexion = New ConexionAD()
    End Sub

    Public Function ObtenerProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SP_LISTAR_PRODUCTOS"
            cmd.CommandType = CommandType.StoredProcedure
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If lector.HasRows Then
                While lector.Read
                    productos.Add(
                        New Producto With {
                            .CodigoProducto = lector.Item(0),
                            .NombreProducto = lector.Item(1),
                            .DescripcionProducto = lector.Item(2),
                            .PrecioBase = lector.Item(3),
                            .IdCategoria = lector.Item(4),
                            .IdMedida = lector.Item(5)
                        }
                    )
                End While
            End If
            _conexion.CerrarConexion()
        End If
        Return productos
    End Function

    Public Function ObtenerProductoPorId(codigoProducto As Integer) As Producto
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SP_LISTAR_PRODUCTOS"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = codigoProducto
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If lector.HasRows Then
                lector.Read()
                Dim producto As New Producto With {
                    .CodigoProducto = lector.Item("codigoProducto"),
                    .NombreProducto = lector.Item("nombreProducto"),
                    .DescripcionProducto = lector.Item("descripcionProducto"),
                    .PrecioBase = lector.Item("precioBase"),
                    .IdCategoria = lector.Item("idCategoria"),
                    .IdMedida = lector.Item("idMedida")
                }
                _conexion.CerrarConexion()
                Return producto
            End If
        End If
        Return New Producto
    End Function

    Public Function FiltrarProductosPorNombre(nombre As String) As List(Of Producto)
        Dim productos As New List(Of Producto)
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SP_BUSCAR_PRODUCTOS_POR_NOMBRE"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 255).Value = nombre
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            If lector.HasRows Then
                While lector.Read
                    productos.Add(
                        New Producto With {
                            .CodigoProducto = lector.Item(0),
                            .NombreProducto = lector.Item(1),
                            .DescripcionProducto = lector.Item(2),
                            .PrecioBase = lector.Item(3),
                            .IdCategoria = lector.Item(4),
                            .IdMedida = lector.Item(5)
                        }
                    )
                End While
            End If
            _conexion.CerrarConexion()
        End If
        Return productos
    End Function

    Public Sub AgregarProducto(producto As Producto, kardex As Kardex)
        Console.WriteLine("AgregarProducto")
        Console.WriteLine("Nombre Producto: " & producto.NombreProducto)
        Console.WriteLine("Descripcion Producto: " & producto.DescripcionProducto)
        Console.WriteLine("Precio Base: " & CStr(producto.PrecioBase))
        Console.WriteLine("Id Categoria: " & CStr(producto.IdCategoria))
        Console.WriteLine("Id Medida: " & CStr(producto.IdMedida))
        Console.WriteLine("StockMinRepo: " & CStr(kardex.StockMinRepo))
        Console.WriteLine("Cantidad Repo: " & CStr(kardex.CantidadReposicion))
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SP_INSERT_NEW_PRODUCTO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NombreProd", SqlDbType.VarChar, 255).Value = producto.NombreProducto
            cmd.Parameters.Add("@DescProd", SqlDbType.VarChar, 255).Value = producto.DescripcionProducto
            cmd.Parameters.Add("@PrecioB", SqlDbType.Money).Value = producto.PrecioBase
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = producto.IdCategoria
            cmd.Parameters.Add("@IdMedida", SqlDbType.Int).Value = producto.IdMedida
            cmd.Parameters.Add("@StockMin", SqlDbType.Float).Value = kardex.StockMinRepo
            cmd.Parameters.Add("@CantRepo", SqlDbType.Float).Value = kardex.CantidadReposicion
            cmd.ExecuteNonQuery()
            _conexion.CerrarConexion()
        End If
    End Sub


    Public Sub ActualizarProducto(producto As Producto)
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "INS_NEW_PRODUCTO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = producto.CodigoProducto
            cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 255).Value = producto.NombreProducto
            cmd.Parameters.Add("@DescripcionProducto", SqlDbType.VarChar, 255).Value = producto.DescripcionProducto
            cmd.Parameters.Add("@PrecioBase", SqlDbType.Money).Value = producto.PrecioBase
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = producto.IdCategoria
            cmd.Parameters.Add("@IdMedida", SqlDbType.Int).Value = producto.IdMedida
            cmd.ExecuteNonQuery()
            _conexion.CerrarConexion()
        End If
    End Sub

    Public Sub EliminarProducto(codigoProducto As Integer)
        Dim cmd As New SqlCommand
        If _conexion.AbrirConexion() Then
            cmd.Connection = _conexion.ObtenerConexion()
            cmd.CommandText = "SP_ELIMINAR_PRODUCTO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = codigoProducto
            cmd.ExecuteNonQuery()
            _conexion.CerrarConexion()
        End If
    End Sub
End Class
