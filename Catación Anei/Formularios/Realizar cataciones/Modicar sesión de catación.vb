Public Class frmModicarSesionCatacion
    Private Clase_SesionCatacion As New Clase_Sesion_de_catacion

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Clase_SesionCatacion.Modificar_SesionCatacion("Codigo", dtFechaInicio.Text, dtHoraInicio.Text, txtDescripcion.Text, txtLugar.Text, IdentificadorMuestra(), ProtocoloCatacion()) Then
            MessageBox.Show("Modificado correctamente.")
        Else
            MessageBox.Show("No se pudo modificado.")
        End If
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
        ProtocoloCatacion()
    End Function
End Class