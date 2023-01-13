Public Class Tipo_Movimiento
    Private m_idTipoMov As Integer
    Private m_descripcion As String
    Public Property Descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
        End Set
    End Property
    Public Property IdTipoMov() As Integer
        Get
            Return m_idTipoMov
        End Get
        Set(ByVal value As Integer)
            m_idTipoMov = value
        End Set
    End Property
End Class
