Public Class frmBienvenido
    Private Fun_Administrador As New Gestor_Administrador
    Private Registro_Administrador As New BindingSource 'Obtiene la el registro del administrador si ya ha sido registrado

    Private Sub frmBienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar_Sesion()
    End Sub

    Sub Iniciar_Sesion()
        Registro_Administrador.DataSource = Fun_Administrador.Datos_Administrador()

        If Registro_Administrador.Count > 0 Then
            btnIniciarSesion.Enabled = True
        Else
            btnIniciarSesion.Enabled = False
        End If
    End Sub

    Private Sub btnCrearPerfil_Click(sender As Object, e As EventArgs) Handles btnCrearPerfil.Click
        frmPerfil.ShowDialog()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Me.Visible = False
        frmIniciarSesion.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmIniciarSesion.Close()
    End Sub
End Class