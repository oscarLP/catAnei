Public Class Sesion_catado
    Public codigo As String
    Public fecha_inicio As String
    Public hora_inicio As String
    Public descripcion As String
    Public fk_codigo_ciudad As String
    Public estructura_identificador As String
    Public protocolo As String
    Public numero_muestras As String
    Public fk_codigo_usuario As String
    Public estado As String

    Sub New(ByVal _codigo As String, ByVal _fecha_inicio As String, ByVal _hora_inicio As String, ByVal _descripcion As String, ByVal _fk_codigo_ciudad As String, _
            ByVal _estructura_identificador As String, ByVal _protocolo As String, ByVal _numero_muestras As String, ByVal _fk_codigo_usuario As String, ByVal _estado As String)
        codigo = _codigo
        fecha_inicio = _fecha_inicio
        hora_inicio = _hora_inicio
        descripcion = _descripcion
        fk_codigo_ciudad = _fk_codigo_ciudad
        estructura_identificador = _estructura_identificador
        protocolo = _protocolo
        numero_muestras = _numero_muestras
        fk_codigo_usuario = _fk_codigo_usuario
        estado = _estado
    End Sub

    Sub New()

    End Sub
End Class
