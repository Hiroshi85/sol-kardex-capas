Imports CapaEntidad
Imports CapaAccesoDatos
Public Class ResponsableLN
    Public Shared Function ListarResponsables() As List(Of Responsable)
        Dim objAD As New ResponsableAD
        Return objAD.ListarResponsables()
    End Function
End Class
