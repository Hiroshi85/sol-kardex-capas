Imports CapaAccesoDatos
Imports CapaEntidad
Public Class MedidaLN

    Private ReadOnly _medidaAD As MedidaAD

    Public Sub New()
        _medidaAD = New MedidaAD()
    End Sub

    Public Function ListarMedidas() As List(Of Medida)
        Return _medidaAD.ListarMedidas()
    End Function

End Class
