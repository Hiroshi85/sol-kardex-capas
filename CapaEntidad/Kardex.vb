Public Class Kardex
    Private m_cantidadReposicion As Double
    Private m_stockMinRepo As Double
    Private m_CodigoProducto As Integer
    Private m_fechaApertura As Date
    Public Property FechaApertura() As Date
        Get
            Return m_fechaApertura
        End Get
        Set(ByVal value As Date)
            m_fechaApertura = value
        End Set
    End Property
    Public Property CantidadReposicion() As Double
        Get
            Return m_cantidadReposicion
        End Get
        Set(ByVal value As Double)
            m_cantidadReposicion = value
        End Set
    End Property

    Public Property StockMinRepo() As Double
        Get
            Return m_stockMinRepo
        End Get
        Set(ByVal value As Double)
            m_stockMinRepo = value
        End Set
    End Property

    Public Property CodigoProducto() As Integer
        Get
            Return m_CodigoProducto
        End Get
        Set(ByVal value As Integer)
            m_CodigoProducto = value
        End Set
    End Property
End Class
