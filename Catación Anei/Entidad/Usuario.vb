Public Class Usuario
    Public codigo As String
    Public nombre_usuario As String
    Public contrasenia As String
    Public permiso As String
    Public tipo_usuario As String
    Public fk_codigo_persona As String


    Sub New(ByVal _codigo As String, ByVal _nombre_usuario As String, ByVal _contrasenia As String, _
            ByVal _permiso As String, ByVal _tipo_usuario As String, ByVal _fk_codigo_persona As String)
        codigo = _codigo
        nombre_usuario = _nombre_usuario
        contrasenia = _contrasenia
        permiso = _permiso
        tipo_usuario = _tipo_usuario
        fk_codigo_persona = _fk_codigo_persona
    End Sub

    Sub New()

    End Sub
End Class
