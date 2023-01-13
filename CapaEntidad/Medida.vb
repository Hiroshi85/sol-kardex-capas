Public Class Medida
    Private m_idMedida As Integer
    Private m_unidad As String
    Public Property Unidad() As String
        Get
            Return m_unidad
        End Get
        Set(ByVal value As String)
            m_unidad = value
        End Set
    End Property
    Public Property IdMedida() As Integer
        Get
            Return m_idMedida
        End Get
        Set(ByVal value As Integer)
            m_idMedida = value
        End Set
    End Property
End Class
