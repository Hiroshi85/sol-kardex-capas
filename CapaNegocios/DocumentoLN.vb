Imports CapaEntidad
Imports CapaAccesoDatos
Public Class DocumentoLN
    Public Shared Function ListarDocumentos() As List(Of Documento)
        Dim objAD As New DocumentosAD
        Return objAD.listarDocumentos()
    End Function

    Public Shared Function ListarDocumentosSalida() As List(Of Documento)
        Dim objAD As New DocumentosAD
        Return objAD.listarDocumentosSalida()
    End Function
    Public Shared Function ListarDocumentosEntrada() As List(Of Documento)
        Dim objAD As New DocumentosAD
        Return objAD.listarDocumentosEntrada()
    End Function
    Public Shared Sub AgregarDocumento(obj As Documento)
        Dim objAD As New DocumentosAD
        objAD.Insertar(obj)
    End Sub
End Class
