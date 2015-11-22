Public Class frmNuevaSesionCatacion
    Private Clase_SesionCatacion As New Clase_Sesion_de_catacion
    Private Clase_CatacionArabiba As New Clase_Catacion_Arabica
    Private Sub frmNuevaSesionCatacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmFecha.Start()
        LimpiarCampos()
    End Sub

    'BOTON GUARDAR
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim CodigoSesionCatacion As String = Clase_SesionCatacion.Codigo()

        Dim i As Boolean = Clase_SesionCatacion.Guardar_SesionCatacion(CodigoSesionCatacion, lbFechaInicio.Text, lbHoraInicio.Text, txtDescripcion.Text, txtLugar.Text,
                                                                       IdentificadorMuestra(), ProtocoloCatacion(), nuNumeroMuestras.Value, Clase_SesionCatacion.Buscar_CodigoUsuario)

        If i = True Then
            LimpiarCampos()
            frmRealizarCataciones.CargarGrilla()
            frmRealizarCataciones.Total_Registrados()
            If ProtocoloCatacion() = "Arábica" Then
                For j = 1 To nuNumeroMuestras.Value
                    Clase_CatacionArabiba.Guardar_CatacionArabica(Clase_CatacionArabiba.Codigo(), CodigoSesionCatacion, "A")
                Next
            End If
            Me.Close()
        End If
    End Sub

    Sub LimpiarCampos()
        txtDescripcion.Clear()
        txtLugar.Clear()
        rbLetras.Checked = True
        rbArabica.Checked = True
        txtDescripcion.Focus()
    End Sub

    'Obtiene la fecha y hora actual del sistema
    Private Sub tmFecha_Tick(sender As Object, e As EventArgs) Handles tmFecha.Tick
        lbHoraInicio.Text = Now.ToLongTimeString
        lbFechaInicio.Text = Now.ToLongDateString
    End Sub
    'Obtiene y envia el Identificador de la muestra seleccionada
    Function IdentificadorMuestra() As String
        Dim IDMuestra As String = "Letras"
        If rbLetras.Checked = True Then
            IDMuestra = "Letras"
        ElseIf rbDigitos.Checked = True Then
            IDMuestra = "Digitos"
        End If
        Return IDMuestra
    End Function

    'Obtiene y envia el Protocolo de catacion de la muestra seleccionada
    Function ProtocoloCatacion() As String
        Dim ProtCatacion As String = "Arábica"
        If rbLetras.Checked = True Then
            ProtCatacion = "Arábica"
        ElseIf rbDigitos.Checked = True Then
            ProtCatacion = "Robusta"
        End If
        Return ProtCatacion
    End Function
End Class