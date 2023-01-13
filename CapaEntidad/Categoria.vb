Public Class Categoria
    Private m_idCategoria As Integer
    Private m_descripcion As String
    Public Property Descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
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
End Class
