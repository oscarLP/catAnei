Public Class Robusta
    Public codigo As String
    Public fk_codigo_muestra As String
    Public calificacion As String
    Public sabor_boca As String
    Public puntaje_sal_acido As String
    Public baja_salinidad As String
    Public alta_acidez As String
    Public puntaje_amargo_dulce As String
    Public bajo_amargor As String
    Public puntaje_sensacion_boca As String
    Public sensacion_boca As String

    Sub New(ByVal _codigo As String, ByVal _fk_codigo_muestra As String, ByVal _calificacion As String, ByVal _sabor_boca As String, _
            ByVal _puntaje_sal_acido As String, ByVal _baja_salinidad As String, ByVal _alta_acidez As String, ByVal _puntaje_amargo_dulce As String, _
            ByVal _bajo_amargor As String, ByVal _puntaje_sensacion_boca As String, ByVal _sensacion_boca As String)
        codigo = _codigo
        fk_codigo_muestra = _fk_codigo_muestra
        calificacion = _calificacion
        sabor_boca = _sabor_boca
        puntaje_sal_acido = _puntaje_sal_acido
        baja_salinidad = _baja_salinidad
        alta_acidez = _alta_acidez
        puntaje_amargo_dulce = _puntaje_amargo_dulce
        bajo_amargor = _bajo_amargor
        puntaje_sensacion_boca = _puntaje_sensacion_boca
        sensacion_boca = _sensacion_boca 
    End Sub
    Sub New()

    End Sub
End Class
