Public Class Arabica
    Public codigo As String
    Public fk_codigo_muestra As String
    Public calificacion As Double
    Public puntaje_acidez As Double
    Public puntaje_cuerpo As Double
    Public puntaje_dulzor As Double
    Public dulzor1 As String
    Public dulzor2 As String
    Public dulzor3 As String
    Public dulzor4 As String
    Public dulzor5 As String

    Sub New(ByVal _codigo As String, ByVal _fk_codigo_muestra As String, ByVal _calificacion As Double, ByVal _puntaje_acidez As Double, ByVal _puntaje_cuerpo As Double, _
            ByVal _puntaje_dulzor As Double, ByVal _dulzor1 As String, ByVal _dulzor2 As String, ByVal _dulzor3 As String, ByVal _dulzor4 As String, ByVal _dulzor5 As String)
        codigo = _codigo
        fk_codigo_muestra = _fk_codigo_muestra
        calificacion = _calificacion
        puntaje_acidez = _puntaje_acidez
        puntaje_cuerpo = _puntaje_cuerpo
        puntaje_dulzor = _puntaje_dulzor
        dulzor1 = _dulzor1
        dulzor2 = _dulzor2
        dulzor3 = dulzor3
        dulzor4 = dulzor4
        dulzor5 = dulzor5
    End Sub

    Sub New()

    End Sub
End Class
