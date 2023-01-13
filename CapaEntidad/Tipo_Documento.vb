Public Class Tipo_Documento
    Private m_idTipoDoc As Integer
    Private m_descripcion As String
    Public Property Descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
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
End Class
