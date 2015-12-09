Public Class Arabica_Robusta
    Public codigo As String
    Public fk_codigo_muestra As String
    Public nivel_tueste As String
    Public puntaje_fragancia_aroma As String
    Public puntaje_sabor As String
    Public puntaje_sabor_boca As String
    Public puntaje_balance As String
    Public puntaje_general As String
    Public puntaje_uniformidad As String
    Public uniformidad1 As String
    Public uniformidad2 As String
    Public uniformidad3 As String
    Public uniformidad4 As String
    Public uniformidad5 As String
    Public puntaje_taza_limpia As String
    Public taza_limpia1 As String
    Public taza_limpia2 As String
    Public taza_limpia3 As String
    Public taza_limpia4 As String
    Public taza_limpia5 As String
    Public numero_defectos As String
    Public nota As String


    Sub New(ByVal _codigo As String, ByVal _fk_codigo_muestra As String, ByVal _nivel_tueste As String, ByVal _puntaje_fragancia_aroma As String, _
            ByVal _puntaje_sabor As String, ByVal _puntaje_sabor_boca As String, ByVal _puntaje_balance As String, ByVal _puntaje_general As String, _
            ByVal _puntaje_uniformidad As String, ByVal _uniformidad1 As String, ByVal _uniformidad2 As String, ByVal _uniformidad3 As String, _
            ByVal _uniformidad4 As String, ByVal _uniformidad5 As String, ByVal _puntaje_taza_limpia As String, ByVal _taza_limpia1 As String, _
            ByVal _taza_limpia2 As String, ByVal _taza_limpia3 As String, ByVal _taza_limpia4 As String, ByVal _taza_limpia5 As String, _
            ByVal _numero_defectos As String, ByVal _nota As String)

        codigo = _codigo
        fk_codigo_muestra = _fk_codigo_muestra
        nivel_tueste = _nivel_tueste
        puntaje_fragancia_aroma = _puntaje_fragancia_aroma
        puntaje_sabor = _puntaje_sabor
        puntaje_sabor_boca = _puntaje_sabor_boca
        puntaje_balance = _puntaje_balance
        puntaje_general = _puntaje_general
        puntaje_uniformidad = _puntaje_uniformidad
        uniformidad1 = _uniformidad1
        uniformidad2 = _uniformidad2
        uniformidad3 = _uniformidad3
        uniformidad4 = _uniformidad4
        uniformidad5 = _uniformidad5
        puntaje_taza_limpia = _puntaje_taza_limpia
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
