Public Class Movimiento
    Private m_numItem As Integer
    Private m_codigoProducto As Integer
    Private m_numDocumento As Integer
    Private m_numHoja As Integer
    Private m_precioDocumento As Double
    Private m_stockAnterior As Double
    Private m_cantidadEntrada As Double
    Private m_cantidadSalida As Double
    Private m_stockActual As Double
    Private m_idTipoMov As Integer
    Public Property IdTipoMov() As Integer
        Get
            Return m_idTipoMov
        End Get
        Set(ByVal value As Integer)
            m_idTipoMov = value
        End Set
    End Property
    Public Property StockActual() As Double
        Get
            Return m_stockActual
        End Get
        Set(ByVal value As Double)
            m_stockActual = value
        End Set
    End Property
    Public Property CantidadSalida() As Double
        Get
            Return m_cantidadSalida
        End Get
        Set(ByVal value As Double)
            m_cantidadSalida = value
        End Set
    End Property
    Public Property CantidadEntrada() As Double
        Get
            Return m_cantidadEntrada
        End Get
        Set(ByVal value As Double)
            m_cantidadEntrada = value
        End Set
    End Property
    Public Property StockAnterior() As Double
        Get
            Return m_stockAnterior
        End Get
        Set(ByVal value As Double)
            m_stockAnterior = value
        End Set
    End Property
    Public Property PrecioDocumento() As Double
        Get
            Return m_precioDocumento
        End Get
        Set(ByVal value As Double)
            m_precioDocumento = value
        End Set
    End Property
    Public Property NumHoja() As Integer
        Get
            Return m_numHoja
        End Get
        Set(ByVal value As Integer)
            m_numHoja = value
        End Set
    End Property
    Public Property NumDocumento() As Integer
        Get
            Return m_numDocumento
        End Get
        Set(ByVal value As Integer)
            m_numDocumento = value
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
    Public Property NumItem() As Integer
        Get
            Return m_numItem
        End Get
        Set(ByVal value As Integer)
            m_numItem = value
        End Set
    End Property
End Class
