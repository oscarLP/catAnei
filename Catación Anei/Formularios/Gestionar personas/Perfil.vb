Public Class frmPerfil
    Private Fun_Persona As New Gestor_Persona
    Private Fun_Administrador As New Gestor_Administrador

    Private Registro_Administrador As New BindingSource
    Private Sub frmPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Administrador()
    End Sub

    Sub Hab_Campos()
        'Habilita los campos
        txtNombreUsuario.Enabled = True
        txtContrasenia.Enabled = True
        txtRContrasenia.Enabled = True
        txtCedula.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True

        'Habilita botones
        btnAceptar.Enabled = True

        'Desabilita botones
        btnModificar.Enabled = False
    End Sub

    Sub Des_Campos()
        'Desabilita los campos
        txtNombreUsuario.Enabled = False
        txtContrasenia.Enabled = False
        txtRContrasenia.Enabled = False
        txtCedula.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False

        'Desabilita botones
        btnAceptar.Enabled = False

        'Habiltar botones
        btnModificar.Enabled = True
    End Sub
    Sub Mostrar_Administrador()
        Registro_Administrador.DataSource = Fun_Administrador.Datos_Administrador()

        If Registro_Administrador.Count > 0 Then
            Des_Campos()
            txtNombreUsuario.Text = Registro_Administrador.Item(0)("nombre_usuario")
            txtContrasenia.Text = Registro_Administrador.Item(0)("contrasenia")
            txtRContrasenia.Text = Registro_Administrador.Item(0)("contrasenia")
            txtCedula.Text = Registro_Administrador.Item(0)("cedula")
            txtNombre.Text = Registro_Administrador.Item(0)("nombre")
            txtApellido.Text = Registro_Administrador.Item(0)("apellido")
            txtTelefono.Text = Registro_Administrador.Item(0)("telefono")
            txtCorreo.Text = Registro_Administrador.Item(0)("correo")
        ElseIf Registro_Administrador.Count = 0 Then
            Hab_Campos()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Hab_Campos()
        txtNombreUsuario.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class