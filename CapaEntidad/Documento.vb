Public Class Documento
    Private m_numDocumento As Integer
    Private m_fecha As Date
    Private m_idTipoDoc As Integer
    Private m_idProveedor As Integer
    Private m_codigoResponsable As String
    Private m_detalles As List(Of Movimiento)

    Public Property Detalles() As List(Of Movimiento)
        Get
            Return m_detalles
        End Get
        Set(ByVal value As List(Of Movimiento))
            m_detalles = value
        End Set
    End Property
    Public Property CodigoResponsable() As String
        Get
            Return m_codigoResponsable
        End Get
        Set(ByVal value As String)
            m_codigoResponsable = value
        End Set
    End Property
    Public Property IdProveedor() As Integer
        Get
            Return m_idProveedor
        End Get
        Set(ByVal value As Integer)
            m_idProveedor = value
        End Set
    End Property
    Public Property IdTipoDoc() As Integer
        Get
            Return m_idTipoDoc
        End Get
        Set(ByVal value As Integer)
            m_idTipoDoc = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return m_fecha
        End Get
        Set(ByVal value As Date)
            m_fecha = value
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
End Class
