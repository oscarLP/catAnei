Public Class frmGestionarCatadores
    Private Fun_Persona As New Gestor_Persona
    Private Fun_Usuario As New Gestor_Usuario
    Private Fun_Catador As New Gestor_Catador

    Private TablaCatadores As New BindingSource
    Private RegistroSeleccionado As New BindingSource
    Private Sub frmGestionarCatadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        AntesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        LimpiarCampos()
        CargarGrilla() 'Carga en la tabla todos los registros
        Total_Registrados() 'Muestra 'Total' el numero de registros
        Des_Campos() 'Desabilita los campos si no se ha registrado ningun registro
        Desabilitar_Modificar_Eliminar()
        dgListaCatadores.ClearSelection() 'Cancelo la seleccion de la tabla
    End Sub

    'BOTON GUARDAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnNuevoCatadorYGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoCatadorYGuardar.Click
        Dim i As Boolean 'Variable utilizada para obtener respuesta si el registro fue guardado correctamente en la tabla 'PERSONA'
        Dim j As Boolean 'Variable utilizada para obtener respuesta si el registro fue guardado correctamente en la tabla 'USUARIO'
        Dim Codigo_Persona As String
        Dim Codigo_Usuario As String

        If btnNuevoCatadorYGuardar.Text = "Nuevo catador" Then
            Hab_Campos() 'Habilita los campos
            Desabilitar_Modificar_Eliminar()
            Mod_Nuevo_Catador()
            LimpiarCampos()
            txtNombreUsuario.Focus() 'Da foco de entrada al campo 'Usuario'
        ElseIf btnNuevoCatadorYGuardar.Text = "Guardar" Then
            If txtNombreUsuario.TextLength = 0 Or txtContraseña.TextLength = 0 Or txtConfirmarContraseña.TextLength = 0 Or txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellido.TextLength = 0 Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
            ElseIf txtContraseña.Text <> txtConfirmarContraseña.Text Then
                MsgBox("La confirmacion de la contraseña no coinciden.", vbExclamation, "Seguridad")
                txtConfirmarContraseña.Clear()
                txtConfirmarContraseña.Focus()
            ElseIf txtContraseña.TextLength < 6 Then
                MsgBox("La contraseña debe tener almenos 6 caracteres alfanuméricos.", vbExclamation, "Seguridad")
                txtContraseña.Focus()
            Else
                Codigo_Persona = Fun_Persona.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
                Codigo_Usuario = Fun_Usuario.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo

                i = Fun_Persona.Guardar_Persona(Codigo_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Usuario")
                If i = True Then 'Si 'i' es igual a true quiere decir que el registro de esta persona se guarda correctamente
                    j = Fun_Usuario.Guardar_Usuario(Codigo_Usuario, txtNombreUsuario.Text, txtContraseña.Text, cbPermiso.Text, "Catador", Codigo_Persona)
                End If

                If i = True And j = True Then 'Si 'i' y 'j' son iguales a true quiere decir que se guardo el registro correctamente
                    'Modificar boton Guardar
                    btnNuevoCatadorYGuardar.Text = "Nuevo catador"
                    btnNuevoCatadorYGuardar.Image = My.Resources.Nuevo_catador_32x32 'Coloca una imagen el boton 'Guardar'

                    Des_Campos()
                    LimpiarCampos()
                    CargarGrilla()
                    Total_Registrados()
                    Contar_Registros()
                Else
                    Fun_Persona.Eliminar_Persona(Codigo_Persona) 'Elimina el registro de la persona abado de registrar si no se pudo guardar el registro del Usuario
                    txtCedula.Focus()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub Antes_Modificar()
        Hab_Campos()
        btnNuevoCatadorYGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Text = "Aceptar"
        Me.AcceptButton = btnModificar
        txtNombreUsuario.Focus()
    End Sub

    Sub Despues_Modificar()
        Des_Campos()
        btnNuevoCatadorYGuardar.Enabled = True
        btnEliminar.Enabled = True
        btnModificar.Text = "Modificar"
        Me.AcceptButton = btnNuevoCatadorYGuardar
        txtBuscar.Focus()
    End Sub

    'BOTON MODIFICAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            Antes_Modificar()
        ElseIf btnModificar.Text = "Aceptar" Then
            Dim varCod_Persona As String
            Dim varCod_Usuario As String
            Dim i As Boolean
            Dim j As Boolean

            If txtContraseña.Text <> txtConfirmarContraseña.Text Then
                MsgBox("La contraseña de confirmación de coincien.", vbCritical, "Seguridad")
                txtConfirmarContraseña.Clear()
                txtConfirmarContraseña.Focus()
            ElseIf MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

                varCod_Persona = RegistroSeleccionado.Item(0)("cod_persona")
                varCod_Usuario = RegistroSeleccionado.Item(0)("cod_usuario")

                i = Fun_Persona.Modificar_Persona(varCod_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Usuario")

                If i = True Then
                    j = Fun_Usuario.Modificar_Usuario(varCod_Usuario, txtNombreUsuario.Text, txtContraseña.Text, cbPermiso.Text)
                End If

                If i = True And j = True Then
                    MessageBox.Show("Modificado correctamente")
                    Despues_Modificar()
                    CargarGrilla()
                    Total_Registrados()
                    Contar_Registros()
                Else
                    MsgBox("Error al Modificar. Vuelva a intentarlo", vbCritical, "Seguridad")
                    txtCedula.Clear()
                    txtCedula.Focus()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    'BOTON ELIMINAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim varCod_Persona As String
        varCod_Persona = RegistroSeleccionado(0)("cod_persona")
        If MsgBox("¿Esta seguro de eliminar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            If Fun_Persona.Eliminar_Persona(varCod_Persona) Then
                MessageBox.Show("Eliminado Correctamente")
                CargarGrilla()
                Total_Registrados()
                Contar_Registros()
            Else
                MsgBox("Error al Eliminar. Vuelva a intentarlo", vbCritical, "Seguridad")
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    'EL CONTROL 'txtBuscar' tiene un evento para filtrar la tabla por algun atributo especifico
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.TextLength = 0 Or txtBuscar.Text = "Buscar" Then
            TablaCatadores.RemoveFilter()
            Contar_Registros()
            Exit Sub
        End If
        If txtBuscarPor.Text = "Cedula" Then
            TablaCatadores.Filter = "Cedula like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Usuario" Then
            TablaCatadores.Filter = "Usuario like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Nombre" Then
            TablaCatadores.Filter = "Nombre like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Apellido" Then
            TablaCatadores.Filter = "Apellido like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Correo electrónico" Then
            TablaCatadores.Filter = "Correo like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Teléfono" Then
            TablaCatadores.Filter = "Teléfono like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Permiso" Then
            TablaCatadores.Filter = "Permiso like '" & txtBuscar.Text & "%'"
        End If
        Contar_Registros() 'Cuenta los registros que resultan de la filtracion de la tabla
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub LimpiarCampos()
        txtBuscarPor.Text = "Cedula"
        txtNombreUsuario.Clear()
        txtContraseña.Clear()
        txtConfirmarContraseña.Clear()
        cbPermiso.Text = "Si"
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtBuscar.Focus()
    End Sub

    'Visualiza la contraseña si el control 'cbVerContraseña' esta activado
    Private Sub cbVerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerContraseña.CheckedChanged
        If cbVerContraseña.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Sub Des_Campos() 'Desabitar campos y botones
        'Desabitar campos
        txtNombreUsuario.Enabled = False
        txtContraseña.Enabled = False
        cbVerContraseña.Enabled = False
        txtConfirmarContraseña.Enabled = False
        cbPermiso.Enabled = False
        txtCedula.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False
    End Sub

    Sub Mod_Nuevo_Catador() 'Modifica el boton 'btnNuevoYGudar' si esta en en 'Nuevo catador'
        'Modificar boton Nuevo Catador
        btnNuevoCatadorYGuardar.Text = "Guardar"
        btnNuevoCatadorYGuardar.Image = My.Resources.Guardar_32x32 'Coloca una imagen el boton 'Guardar'
    End Sub

    Sub Desabilitar_Modificar_Eliminar()
        'Desabilitar los botones 'Modificar' y 'Eliminar'
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub Hab_Campos() 'Habilitar campos y botones
        'Desabitar campos
        txtNombreUsuario.Enabled = True
        txtContraseña.Enabled = True
        cbVerContraseña.Enabled = True
        txtConfirmarContraseña.Enabled = True
        cbPermiso.Enabled = True
        txtCedula.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
    End Sub

    'Borra el campo 'Buscar' justo antes de escoger otro atributo para filtrar la tabla
    Private Sub txtBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarPor.SelectedIndexChanged
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    'Subprograma quue muestra el registro del catador seleccionado
    Sub Mostrar_Catador()
        Dim varCedula As String
        Dim row As DataGridViewRow = dgListaCatadores.CurrentRow
        varCedula = CStr(row.Cells("Cedula").Value)

        RegistroSeleccionado.DataSource = Fun_Catador.Buscar_Catador() 'Obtiene la tabla de todos los catadores registrados

        RegistroSeleccionado.Filter = "cedula = '" & varCedula & "'"

        txtNombreUsuario.Text = RegistroSeleccionado.Item(0)("nombre_usuario")
        txtContraseña.Text = RegistroSeleccionado.Item(0)("contraseña")
        txtConfirmarContraseña.Text = RegistroSeleccionado.Item(0)("contraseña")
        cbPermiso.Text = RegistroSeleccionado.Item(0)("permiso")
        txtCedula.Text = RegistroSeleccionado.Item(0)("cedula")
        txtNombre.Text = RegistroSeleccionado.Item(0)("nombre")
        txtApellido.Text = RegistroSeleccionado.Item(0)("apellido")
        txtTelefono.Text = RegistroSeleccionado.Item(0)("telefono")
        txtCorreo.Text = RegistroSeleccionado.Item(0)("correo")
    End Sub

    'Evento de la grilla para mostrar el registro (fila) en la parte 'Gestion de catador'
    Private Sub dgListaCatadores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaCatadores.CellEnter
        If dgListaCatadores.ContainsFocus = True Then
            If btnNuevoCatadorYGuardar.Text = "Guardar" Then 'Esto quiere decir que se esta llevando el registro de un nuevo catador
                If MsgBox("Se está llevando a cabo el registro de un nuevo catador. ¿Desea cancelar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                    Mostrar_Catador()

                    btnNuevoCatadorYGuardar.Text = "Nuevo catador"
                    Des_Campos()
                    Desabilitar_Modificar_Eliminar()
                    btnNuevoCatadorYGuardar.Image = My.Resources.Nuevo_catador_32x32
                Else
                    btnModificar.Enabled = False
                    btnEliminar.Enabled = False
                    txtNombreUsuario.Focus()
                End If
            ElseIf btnModificar.Text = "Aceptar" Then 'Esto quiere decir que se esta llevando a cabo la modificacion de un catador
                If MsgBox("Se está llevando a cabo la modificación de un catador. ¿Desea cancelar la modicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                    Mostrar_Catador()
                    Despues_Modificar()
                End If
            Else
                btnModificar.Enabled = True
                btnEliminar.Enabled = True
                Mostrar_Catador()
            End If
        End If
    End Sub

    Sub Total_Registrados() 'Muestra el total de catadores registradores
        lbTotal.Text = Fun_Catador.Total_Registrados()
    End Sub
    Sub CargarGrilla() 'Carga los registros de los catadores en la tabla
        TablaCatadores.DataSource = Fun_Catador.Tabla_Catadores()
        dgListaCatadores.DataSource = TablaCatadores
    End Sub

    Sub Contar_Registros() 'Cuenta los registros filtrados en la tabla
        lbSeleccionados.Text = dgListaCatadores.RowCount
    End Sub

    'Actualiza el numero de registros reflejados en la tabla
    Private Sub dgListaCatadores_BindingContextChanged(sender As Object, e As EventArgs) Handles dgListaCatadores.BindingContextChanged
        Contar_Registros()
    End Sub

    'Evento: Al iniciar el formulario el campo 'Buscar' tiene el efecto Placeholder
    '-------------------------------------------------------------------------------------------------------------
    Sub DespuesDelFocus_txtBuscar()
        If txtBuscar.Text = "Buscar" Then
            txtBuscar.ForeColor = Color.Black
            txtBuscar.Clear()
        End If
    End Sub

    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        DespuesDelFocus_txtBuscar()
    End Sub

    Sub AntesDelFocus_txtBuscar()
        If txtBuscar.Text = Nothing Then
            txtBuscar.ForeColor = Color.Black
            txtBuscar.Text = "Buscar"
        End If
    End Sub

    Private Sub txtBuscar_LostFocus(sender As Object, e As EventArgs) Handles txtBuscar.LostFocus
        AntesDelFocus_txtBuscar()
    End Sub
    '-------------------------------------------------------------------------------------------------------------

    'VALIDAD ERRORES
    '-------------------------------------------------------------------------------------------------------------
    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged
        erValidarError.SetError(txtNombreUsuario, Nothing)
        txtNombreUsuario.BackColor = SystemColors.Window
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        erValidarError.SetError(txtContraseña, Nothing)
        txtContraseña.BackColor = SystemColors.Window
    End Sub

    Private Sub txtConfirmarContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmarContraseña.TextChanged
        erValidarError.SetError(txtConfirmarContraseña, Nothing)
        txtConfirmarContraseña.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        erValidarError.SetError(txtCedula, Nothing)
        txtCedula.BackColor = SystemColors.Window
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        erValidarError.SetError(txtNombre, Nothing)
        txtNombre.BackColor = SystemColors.Window
    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
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

    Private Sub txtContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        If txtContraseña.TextLength = 0 Then
            erValidarError.SetError(txtContraseña, "Este campo es obligatorio")
            txtContraseña.BackColor = Color.MistyRose
        ElseIf txtContraseña.TextLength < 6 Then
            erValidarError.SetError(txtContraseña, "La contraseña debe contener al menos 6 caracteres.")
            txtContraseña.BackColor = Color.MistyRose
        Else
            txtContraseña.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtConfirmarContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtConfirmarContraseña.Validating
        If txtConfirmarContraseña.TextLength = 0 Then
            erValidarError.SetError(txtConfirmarContraseña, "Este campo es obligatorio")
            txtConfirmarContraseña.BackColor = Color.MistyRose
        Else
            txtConfirmarContraseña.BackColor = SystemColors.Window
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

    Private Sub txtApellidos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellido.Validating
        If txtApellido.TextLength = 0 Then
            erValidarError.SetError(txtApellido, "Este campo es obligatorio")
            txtApellido.BackColor = Color.MistyRose
        Else
            txtApellido.BackColor = SystemColors.Window
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------

    'Cambia el icono de la izquierda del campo 'Permiso'
    Private Sub cbPermiso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPermiso.SelectedIndexChanged
        If cbPermiso.Text = "Si" Then
            pxPermiso.Image = My.Resources.Si_26x26
        ElseIf cbPermiso.Text = "No" Then
            pxPermiso.Image = My.Resources.No_26x26
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
        ''Solo permite solo ingresar letras
        'If Char.IsLetter(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
    End Sub
End Class