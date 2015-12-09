Public Class Arabica
    Public codigo As String
    Public fk_codigo_muestra As String
    Public calificacion As String
    Public puntaje_acidez As String
    Public puntaje_cuerpo As String
    Public puntaje_dulzor As String
    Public dulzor1 As String
    Public dulzor2 As String
    Public dulzor3 As String
    Public dulzor4 As String
    Public dulzor5 As String

    Sub New(ByVal _codigo As String, ByVal _fk_codigo_muestra As String, ByVal _calificacion As String, ByVal _puntaje_acidez As String, _
            ByVal _puntaje_cuerpo As String, ByVal _puntaje_dulzor As String, ByVal _dulzor1 As String, ByVal _dulzor2 As String, _
            ByVal _dulzor3 As String, ByVal _dulzor4 As String, ByVal _dulzor5 As String)
        codigo = _codigo
        fk_codigo_muestra = _fk_codigo_muestra
        calificacion = _calificacion
        puntaje_acidez = _puntaje_acidez
        puntaje_cuerpo = _puntaje_cuerpo
        puntaje_dulzor = _puntaje_dulzor
        dulzor1 = _dulzor1
        dulzor2 = _dulzor2
        dulzor3 = _dulzor3
        dulzor4 = _dulzor3
        dulzor5 = _dulzor5
    End Sub

    Sub New()

    End Sub

End Class
