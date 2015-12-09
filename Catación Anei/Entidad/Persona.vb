Public Class Persona
    Public codigo As String
    Public cedula As String
    Public nombre As String
    Public apellido As String
    Public telefono As String
    Public correo As String
    Public tipo_persona As String

    Sub New(ByVal _codigo As String, ByVal _cedula As String, ByVal _nombre As String, ByVal _apellido As String, _
            ByVal _telefono As String, ByVal _correo As String, ByVal _tipo_persona As String)
        codigo = _codigo
        cedula = _cedula
        nombre = _nombre
        apellido = _apellido
        telefono = _telefono
        correo = _correo
        tipo_persona = _tipo_persona
    End Sub

    Sub New()

    End Sub
End Class
