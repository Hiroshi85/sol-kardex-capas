Public Class Producto
    Private m_codigoProducto As Integer
    Private m_nombreProducto As String
    Private m_descripcionProducto As String
    Private m_precioBase As Double
    Private m_idCategoria As Integer
    Private m_idMedida As Integer
    Public Property IdMedida() As Integer
        Get
            Return m_idMedida
        End Get
        Set(ByVal value As Integer)
            m_idMedida = value
        End Set
    End Property
    Public Property IdCategoria() As Integer
        Get
            Return m_idCategoria
        End Get
        Set(ByVal value As Integer)
            m_idCategoria = value
        End Set
    End Property
    Public Property PrecioBase() As Double
        Get
            Return m_precioBase
        End Get
        Set(ByVal value As Double)
            m_precioBase = value
        End Set
    End Property
    Public Property DescripcionProducto() As String
        Get
            Return m_descripcionProducto
        End Get
        Set(ByVal value As String)
            m_descripcionProducto = value
        End Set
    End Property
    Public Property NombreProducto() As String
        Get
            Return m_nombreProducto
        End Get
        Set(ByVal value As String)
            m_nombreProducto = value
        End Set
    End Property
    Public Property CodigoProducto() As Integer
        Get
            Return m_codigoProducto
        End Get
        Set(ByVal value As Integer)
            m_codigoProducto = value
        End Set
    End Property
End Class
