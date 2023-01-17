Public Class Proveedor
    Private m_idProveedor As Integer
    Private m_descripcion As String
    Private m_proveedor As String
    Private m_direccion As String
    Private m_telefono As String
    Private m_correo As String
    Private m_ruc As String
    Public Property RUC() As String
        Get
            Return m_ruc
        End Get
        Set(ByVal value As String)
            m_ruc = value
        End Set
    End Property
    Public Property Correo() As String
        Get
            Return m_correo
        End Get
        Set(ByVal value As String)
            m_correo = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return m_telefono
        End Get
        Set(ByVal value As String)
            m_telefono = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return m_direccion
        End Get
        Set(ByVal value As String)
            m_direccion = value
        End Set
    End Property
    Public Property Proveedor() As String
        Get
            Return m_proveedor
        End Get
        Set(ByVal value As String)
            m_proveedor = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
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
End Class
