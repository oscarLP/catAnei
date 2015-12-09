Public Class Descriptores
    Public codigo As String
    Public fk_codigo_muestra As String
    Public evaluacion As String
    Public nombre_descriptor As String


    Sub New(ByVal _codigo As String, ByVal _fk_codigo_muestra As String, ByVal _evaluacion As String, ByVal _nombre_descriptor As String)
        codigo = _codigo
        fk_codigo_muestra = _fk_codigo_muestra
        evaluacion = _evaluacion
        nombre_descriptor = _nombre_descriptor

    End Sub

    Sub New()

    End Sub

End Class
