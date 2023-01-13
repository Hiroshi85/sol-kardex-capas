Public Class Proveedor
    Private m_idProveedor As Integer
    Private m_descripcion As String
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
