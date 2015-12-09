Public Class Proveedor
    Public codigo As String
    Public vereda As String
    Public finca As String
    Public fk_codigo_ciudad As String
    Public fk_codigo_persona As String

    Sub New(ByVal _codigo As String, ByVal _vereda As String, ByVal _finca As String, _
            ByVal _fk_codigo_ciudad As String, ByVal _fk_codigo_persona As String)
        codigo = _codigo
        vereda = _vereda
        finca = _finca
        fk_codigo_ciudad = _fk_codigo_ciudad
        fk_codigo_persona = _fk_codigo_persona
    End Sub

    Sub New()

    End Sub

End Class
