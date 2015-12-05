Public Class frmPerfil
    Private Fun_Persona As New Gestor_Persona
    Private Fun_Usuario As New Gestor_Usuario
    Private Fun_Administrador As New Gestor_Administrador

    Private Registro_Administrador As New BindingSource 'Obtiene la el registro del administrador si ya ha sido registrado

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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim i As Boolean 'Variable utilizada para obtener respuesta si el registro fue guardado correctamente en la tabla 'PERSONA'
        Dim j As Boolean 'Variable utilizada para obtener respuesta si el registro fue guardado correctamente en la tabla 'USUARIO'
        Dim Codigo_Persona As String
        Dim Codigo_Usuario As String
        Registro_Administrador.DataSource = Fun_Administrador.Datos_Administrador()

        'GUARDAR
        '---------------------------------------------------------------------------------------------------------
        If Registro_Administrador.Count = 0 Then 'Si 'Registro_Administrador' es igual a cero quiere decir que el perfil del administrador no esta registrado
            If txtNombreUsuario.TextLength = 0 Or txtContrasenia.TextLength = 0 Or txtContrasenia.TextLength = 0 Or txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellido.TextLength = 0 Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
            ElseIf txtContrasenia.Text <> txtRContrasenia.Text Then
                MsgBox("La confirmacion de la contraseña no coinciden.", vbExclamation, "Seguridad")
                txtRContrasenia.Clear()
                txtRContrasenia.Focus()
            ElseIf txtContrasenia.TextLength < 6 Then
                MsgBox("La contraseña debe tener almenos 6 caracteres alfanuméricos.", vbExclamation, "Seguridad")
                txtContrasenia.Focus()
            Else
                Codigo_Persona = Fun_Persona.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
                Codigo_Usuario = Fun_Usuario.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo

                i = Fun_Persona.Guardar_Persona(Codigo_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Usuario")
                If i = True Then 'Si 'i' es igual a true quiere decir que el registro de esta persona se guarda correctamente
                    j = Fun_Usuario.Guardar_Usuario(Codigo_Usuario, txtNombreUsuario.Text, txtContrasenia.Text, "Si", "Administrador", Codigo_Persona)
                End If

                If i = True And j = True Then
                    MsgBox("Perfil del administrador: Creado correctamente.", MsgBoxStyle.Information, "Seguridad")
                    frmBienvenido.Iniciar_Sesion() 'Ejecuta el subproceso 'Iniciar_Sesion' del formulario 'Bienvenido' para que se active el boton 'Iniciar Sesion'
                    Mostrar_Administrador()
                    Me.Close()
                Else
                    Fun_Persona.Eliminar_Persona(Codigo_Persona)
                    MsgBox("No se pudo guardar.", vbExclamation, "Seguridad")
                End If
            End If
            '---------------------------------------------------------------------------------------------------------

            'MODIFICAR
            '---------------------------------------------------------------------------------------------------------
        ElseIf Registro_Administrador.Count > 0 Then 'Si 'Registro_Administrador' es mayor a cero quiere decir que el perfil del administrador ya esta registrado y se va a modificar
            If txtContrasenia.Text <> txtRContrasenia.Text Then
                MsgBox("La contraseña de confirmación no coinciden.", vbCritical, "Seguridad")
                txtRContrasenia.Clear()
                txtRContrasenia.Focus()
            ElseIf MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

                Codigo_Persona = Registro_Administrador.Item(0)("cod_persona")
                Codigo_Usuario = Registro_Administrador.Item(0)("cod_usuario")

                i = Fun_Persona.Modificar_Persona(Codigo_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Usuario")

                If i = True Then
                    j = Fun_Usuario.Modificar_Usuario(Codigo_Usuario, txtNombreUsuario.Text, txtContrasenia.Text, "Si")
                End If

                If i = True And j = True Then
                    MessageBox.Show("Modificado correctamente")
                    Me.Close()
                Else
                    MsgBox("Error al Modificar. Vuelva a intentarlo", vbCritical, "Seguridad")
                    txtCedula.Clear()
                    txtCedula.Focus()
                End If
            End If
            '---------------------------------------------------------------------------------------------------------
        End If
    End Sub

    'VALIDAD ERRORES
    '-------------------------------------------------------------------------------------------------------------
    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged
        erValidarError.SetError(txtNombreUsuario, Nothing)
        txtNombreUsuario.BackColor = SystemColors.Window
    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged
        erValidarError.SetError(txtContrasenia, Nothing)
        txtContrasenia.BackColor = SystemColors.Window
    End Sub

    Private Sub txtRContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtRContrasenia.TextChanged
        erValidarError.SetError(txtRContrasenia, Nothing)
        txtRContrasenia.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        erValidarError.SetError(txtCedula, Nothing)
        txtCedula.BackColor = SystemColors.Window
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        erValidarError.SetError(txtNombre, Nothing)
        txtNombre.BackColor = SystemColors.Window
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        erValidarError.SetError(txtApellido, Nothing)
        txtApellido.BackColor = SystemColors.Window
    End Sub

    'validating
    Private Sub txtNombreUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreUsuario.Validating
        If txtNombreUsuario.TextLength = 0 Then
            erValidarError.SetError(txtNombreUsuario, "Este campo es obligatorio")
            txtNombreUsuario.BackColor = Color.MistyRose
        Else
            txtNombreUsuario.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtContrasenia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContrasenia.Validating
        If txtContrasenia.TextLength = 0 Then
            erValidarError.SetError(txtContrasenia, "Este campo es obligatorio")
            txtContrasenia.BackColor = Color.MistyRose
        ElseIf txtContrasenia.TextLength < 6 Then
            erValidarError.SetError(txtContrasenia, "La contraseña debe contener al menos 6 caracteres.")
            txtContrasenia.BackColor = Color.MistyRose
        Else
            txtContrasenia.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtRContrasenia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRContrasenia.Validating
        If txtRContrasenia.TextLength = 0 Then
            erValidarError.SetError(txtRContrasenia, "Este campo es obligatorio")
            txtRContrasenia.BackColor = Color.MistyRose
        Else
            txtRContrasenia.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtCedula_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCedula.Validating
        If txtCedula.TextLength = 0 Then
            erValidarError.SetError(txtCedula, "Este campo es obligatorio")
            txtCedula.BackColor = Color.MistyRose
        Else
            txtCedula.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.TextLength = 0 Then
            erValidarError.SetError(txtNombre, "Este campo es obligatorio")
            txtNombre.BackColor = Color.MistyRose
        Else
            txtNombre.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellido.Validating
        If txtApellido.TextLength = 0 Then
            erValidarError.SetError(txtApellido, "Este campo es obligatorio")
            txtApellido.BackColor = Color.MistyRose
        Else
            txtApellido.BackColor = SystemColors.Window
        End If
    End Sub

    Sub Ingresar_SoloNumeros(ByRef e As KeyPressEventArgs)
        'Solo permite ingresar numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        Ingresar_SoloNumeros(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Ingresar_SoloNumeros(e)
    End Sub
End Class
