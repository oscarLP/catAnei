Public Class Ciudad
    Public codigo As String
    Public nombre As String
    Public fk_codigo_pais As String

    Sub New(ByVal _codigo As String, ByVal _nombre As String, ByVal _fk_codigo_pais As String)
        codigo = _codigo
        nombre = _nombre
        fk_codigo_pais = _fk_codigo_pais
    End Sub

    Sub New()

    End Sub

End Class
