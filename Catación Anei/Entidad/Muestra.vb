Public Class Muestra
    Public codigo As String
    Public valor_identificado As String
    Public nombre As String
    Public descripcion As String
    Public especie As String
    Public anio_cosecha As String
    Public humedad As String
    Public fk_codigo_sesion As String
    Public fk_codigo_ciudad As String
    Public fk_codigo_productor As String
    Public fk_codigo_proveedor As String

    Sub New(ByVal _codigo As String, ByVal _valor_identificado As String, ByVal _nombre As String, ByVal _descripcion As String, ByVal _especie As String, ByVal _anio_cosecha As String, _
            ByVal _humedad As String, ByVal _fk_codigo_sesion As String, ByVal _fk_codigo_ciudad As String, ByVal _fk_codigo_productor As String, ByVal _fk_codigo_proveedor As String)
        codigo = _codigo
        valor_identificado = _valor_identificado
        nombre = _nombre
        descripcion = _descripcion
        especie = _especie
        anio_cosecha = _anio_cosecha
        humedad = _humedad
        fk_codigo_sesion = _fk_codigo_sesion
        fk_codigo_ciudad = _fk_codigo_ciudad
        fk_codigo_productor = _fk_codigo_productor
        fk_codigo_proveedor = _fk_codigo_proveedor
    End Sub

    Sub New()

    End Sub
End Class
