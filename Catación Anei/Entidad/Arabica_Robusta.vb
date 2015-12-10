Public Class Arabica_Robusta
    Public codigo As String
    Public fk_codigo_muestra As String
    Public nivel_tueste As String
    Public puntaje_fragancia_aroma As Double
    Public puntuaje_sabor As Double
    Public puntuaje_sabor_boca As Double
    Public puntuaje_balance As Double
    Public puntuaje_general As Double
    Public puntuaje_uniformidad As Double
    Public uniformidad1 As String
    Public uniformidad2 As String
    Public uniformidad3 As String
    Public uniformidad4 As String
    Public uniformidad5 As String
    Public puntuaje_taza_limpia As Double
    Public taza_limpia1 As String
    Public taza_limpia2 As String
    Public taza_limpia3 As String
    Public taza_limpia4 As String
    Public taza_limpia5 As String
    Public numero_defectos As Double
    Public nota As String

    Sub New(ByVal _codigo As String, ByVal _fk_codigo_muestra As String, ByVal _nivel_tueste As String, ByVal _puntaje_fragancia_aroma As Double, ByVal _puntuaje_sabor As Double, _
            ByVal _puntuaje_sabor_boca As Double, ByVal _puntuaje_balance As Double, ByVal _puntuaje_general As Double, ByVal _puntuaje_uniformidad As Double, ByVal _uniformidad1 As String, _
            ByVal _uniformidad2 As String, ByVal _uniformidad3 As String, ByVal _uniformidad4 As String, ByVal _uniformidad5 As String, ByVal _puntuaje_taza_limpia As Double, _
            ByVal _taza_limpia1 As String, ByVal _taza_limpia2 As String, ByVal _taza_limpia3 As String, ByVal _taza_limpia4 As String, ByVal _taza_limpia5 As String, _
            ByVal _numero_defectos As Double, ByVal _nota As String)
        codigo = _codigo
        fk_codigo_muestra = _fk_codigo_muestra
        nivel_tueste = _nivel_tueste
        puntaje_fragancia_aroma = _puntaje_fragancia_aroma
        puntuaje_sabor = _puntuaje_sabor
        puntuaje_sabor_boca = _puntuaje_sabor_boca
        puntuaje_balance = _puntuaje_balance
        puntuaje_general = _puntuaje_general
        puntuaje_uniformidad = _puntuaje_uniformidad
        uniformidad1 = _uniformidad1
        uniformidad2 = _uniformidad2
        uniformidad3 = _uniformidad3
        uniformidad4 = _uniformidad4
        uniformidad5 = _uniformidad5
        puntuaje_taza_limpia = _puntuaje_taza_limpia
        taza_limpia1 = _taza_limpia1
        taza_limpia2 = _taza_limpia2
        taza_limpia3 = _taza_limpia3
        taza_limpia4 = _taza_limpia4
        taza_limpia5 = _taza_limpia5
        numero_defectos = _numero_defectos
        nota = _nota
    End Sub

    Sub New()

    End Sub
End Class
