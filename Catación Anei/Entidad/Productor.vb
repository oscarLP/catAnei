Public Class Productor
    Public codigo
    Public vereda
    Public finca
    Public fk_codigo_ciudad
    Public fk_codigo_persona

    Sub New(ByVal _codigo As String, ByVal _vereda As String, ByVal _finca As String, ByVal _fk_codigo_ciudad As String, ByVal _fk_codigo_persona As String)
        codigo = _codigo
        vereda = _vereda
        finca = _finca
        fk_codigo_ciudad = _fk_codigo_ciudad
        fk_codigo_persona = _fk_codigo_persona
    End Sub

    Sub New()

    End Sub

End Class
