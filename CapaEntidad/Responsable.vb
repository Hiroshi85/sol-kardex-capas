Public Class Responsable
    Private m_numDNI As String
    Private m_codigoResponsable As String
    Private m_fechaNacimiento As Date
    Private m_nombre As String
    Public Property Nombre() As String
        Get
            Return m_nombre
        End Get
        Set(ByVal value As String)
            m_nombre = value
        End Set
    End Property
    Public Property FechaNacimiento() As Date
        Get
            Return m_fechaNacimiento
        End Get
        Set(ByVal value As Date)
            m_fechaNacimiento = value
        End Set
    End Property
    Public Property NumDNI() As String
        Get
            Return m_numDNI
        End Get
        Set(ByVal value As String)
            m_numDNI = value
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
End Class
