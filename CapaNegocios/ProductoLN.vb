Imports CapaAccesoDatos
Imports CapaEntidad

Public Class ProductoLN
    Private ReadOnly _productoAD As ProductoAD

    Public Sub New()
        _productoAD = New ProductoAD()
    End Sub

    Public Function ObtenerProductos() As List(Of Producto)
        Return _productoAD.ObtenerProductos()
    End Function

    Public Function FiltrarProductosPorNombre(nombre As String) As List(Of Producto)
        Return _productoAD.FiltrarProductosPorNombre(nombre)
    End Function

    Public Function ObtenerProductoPorId(id As Integer) As Producto
        Return _productoAD.ObtenerProductoPorId(id)
    End Function

    Public Sub AgregarProducto(producto As Producto, kardex As Kardex)
        'Validaciones de negocio para agregar un producto
        _productoAD.AgregarProducto(producto, kardex)
    End Sub

    Public Sub ActualizarProducto(producto As Producto)
        'Validaciones de negocio para actualizar un producto
        _productoAD.ActualizarProducto(producto)
    End Sub

    Public Sub EliminarProducto(id As Integer)
        'Validaciones de negocio para eliminar un producto
        _productoAD.EliminarProducto(id)
    End Sub
End Class
