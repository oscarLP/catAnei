Public Class frmMenuPrincipal

    'Al cerrar el formulario
    Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmIniciarSecion.Close()
    End Sub

    Private Sub btnGestionarCatadores_Click(sender As Object, e As EventArgs) Handles btnGestionarCatadores.Click
        frmGestionarCatadores.Show()
        frmGestionarCatadores.Focus()
        frmGestionarCatadores.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnRealizarCataciones_Click(sender As Object, e As EventArgs) Handles btnRealizarCataciones.Click
        frmRealizarCataciones.Show()
        frmRealizarCataciones.Focus()
    End Sub

    Private Sub tsCambiarContraseña_Click(sender As Object, e As EventArgs) Handles tsCambiarContraseña.Click
        frmCambiarContraseña.ShowDialog()
    End Sub

    Sub CerrarSesion() 'Condiciones para abrir el formulario Iniciar sesión
        If frmGestionarCatadores.Visible = True Or frmRealizarCataciones.Visible = True Or frmNuevaSesionCatacion.Visible = True Or
            frmCatarArabica.Visible = True Or frmCatarRobusta.Visible = True Then

            frmGestionarCatadores.Close()
            frmRealizarCataciones.Close()
            frmNuevaSesionCatacion.Close()
            frmCatarArabica.Close()
            frmCatarRobusta.Close()
        End If

        Me.Visible = False
        If frmIniciarSecion.Visible = False Then
            frmIniciarSecion.Visible = True
        Else
            frmIniciarSecion.ShowDialog()
        End If
    End Sub

    Private Sub tsCerrarSesión_Click(sender As Object, e As EventArgs) Handles tsCerrarSesión.Click
        CerrarSesion()
    End Sub

    'EVENTO ANIMACION CON LOS BOTONES
    '-------------------------------------------------------------------------------
    'Boton btnGestionarCatadores
    Private Sub btnGestionarCatadores_MouseLeave(sender As Object, e As EventArgs) Handles btnGestionarCatadores.MouseLeave
        btnGestionarCatadores.Width = 188
        btnGestionarCatadores.Height = 220
    End Sub

    Private Sub btnGestionarCatadores_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGestionarCatadores.MouseMove
        btnGestionarCatadores.Width = 194
        btnGestionarCatadores.Height = 230
        btnGestionarCatadores.BackgroundImageLayout = ImageLayout.Center
    End Sub

    'Boton btnRealizarCataciones
    Private Sub btnRealizarCataciones_MouseLeave(sender As Object, e As EventArgs) Handles btnRealizarCataciones.MouseLeave
        btnRealizarCataciones.Width = 188
        btnRealizarCataciones.Height = 220
    End Sub

    Private Sub btnRealizarCataciones_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRealizarCataciones.MouseMove
        btnRealizarCataciones.Width = 194
        btnRealizarCataciones.Height = 230
        btnRealizarCataciones.BackgroundImageLayout = ImageLayout.Center
    End Sub

    'Boton btnConsultasYEstadisticas
    Private Sub btnConsultasYEstadisticas_MouseLeave(sender As Object, e As EventArgs) Handles btnConsultasYEstadisticas.MouseLeave
        btnConsultasYEstadisticas.Width = 188
        btnConsultasYEstadisticas.Height = 220
    End Sub

    Private Sub btnConsultasYEstadisticas_MouseMove(sender As Object, e As MouseEventArgs) Handles btnConsultasYEstadisticas.MouseMove
        btnConsultasYEstadisticas.Width = 194
        btnConsultasYEstadisticas.Height = 230
        btnConsultasYEstadisticas.BackgroundImageLayout = ImageLayout.Center
    End Sub
End Class