Public Class frmGestionarCatadores
    Private Fun_Usuario As New Funciones_de_Usuario
    Dim Codigo As String
    Private Sub frmGestionarCatadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar()
        AntesDelFocus_txtBuscar()
        LimpiarCampos()
        CargarGrilla()
        Total_Lista()
        Des_Campos()
    End Sub
    Sub Total_Lista()
        BinTodos.DataSource = Fun_Usuario.Lista_Catadores()
        lbTotal.Text = BinTodos.Count
    End Sub
    Sub CargarGrilla()
        BinGrilla.DataSource = Fun_Usuario.Lista_Catadores()
        dgListaCatadores.DataSource = BinGrilla
    End Sub

    Sub Contar_Registros()
        lbSeleccionados.Text = dgListaCatadores.RowCount
    End Sub

    Private Sub dgListaCatadores_BindingContextChanged(sender As Object, e As EventArgs) Handles dgListaCatadores.BindingContextChanged
        Contar_Registros()
    End Sub

    'BOTON GUARDAR
    '------------------------------------------------------------------------------------------------------------------
    Sub Generar_Codigo()
        Randomize()
        Codigo = CStr(Int((9999999 * Rnd() + 1)))

        BinConsultarCodigo.DataSource = Fun_Usuario.Consulta_CatadoresPorCodigo(Codigo)
        BinConsultarCodigo.Filter = "Codigo = '" & Codigo & "'"
        Do
            Codigo = CStr(Int((9999999 * Rnd() + 1)))
        Loop While BinConsultarCodigo.Count > 0
    End Sub

    'VALIDAD EL NOMBRE DE USUARIO
    Function Validad_Usuario(NombreUsuario) As Boolean
        BinConsultarUsuario.DataSource = Fun_Usuario.Consulta_CatadoresPorNombreUsuario(NombreUsuario)
        BinConsultarUsuario.Filter = "NombreUsuario = '" & NombreUsuario & "'"

        If BinConsultarUsuario.Count = 1 Then
            MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            Return True
        Else
            Return False
        End If
    End Function

    'VALIDAD LA CEDULA
    Function Validad_Cedula(Cedula) As Boolean
        BinConsultarCedula.DataSource = Fun_Usuario.Consulta_CatadoresPorCedula(Cedula)
        BinConsultarCedula.Filter = "Cedula = '" & Cedula & "'"

        If BinConsultarCedula.Count = 1 Then
            MsgBox("Este cedula ya se encuentra registrada.", vbExclamation, "Seguridad")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnNuevoCatadorYGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoCatadorYGuardar.Click
        Dim varConfirmar_ValidadNombreUsuario As Boolean
        Dim varConfirmar_ValidadCedula As Boolean
        Generar_Codigo()
        If btnNuevoCatadorYGuardar.Text = "Nuevo catador" Then
            Hab_Campos()
            LimpiarCampos()
            txtNombreUsuario.Focus()
        ElseIf btnNuevoCatadorYGuardar.Text = "Guardar" Then
            If txtNombreUsuario.TextLength = 0 Or txtContraseña.TextLength = 0 Or txtConfirmarContraseña.TextLength = 0 Or txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellidos.TextLength = 0 Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
            ElseIf txtContraseña.Text <> txtConfirmarContraseña.Text Then
                MsgBox("La confirmacion de la contraseña no coinciden.", vbExclamation, "Seguridad")
                txtConfirmarContraseña.Clear()
                txtConfirmarContraseña.Focus()
            Else
                varConfirmar_ValidadNombreUsuario = Validad_Usuario(txtNombreUsuario.Text)

                If varConfirmar_ValidadNombreUsuario = True Then 'Si es true quiere decir que el 'NombreUsurio' ya esta registrado
                    txtNombreUsuario.Focus()
                    Exit Sub
                End If

                varConfirmar_ValidadCedula = Validad_Cedula(txtCedula.Text)
                If varConfirmar_ValidadCedula = True Then 'Si es true quiere decir que la 'Cedula' ya esta registrado
                    txtCedula.Focus()
                    Exit Sub
                End If

                Dim i As Boolean = Fun_Usuario.Guardar_Usuario(Codigo, txtNombreUsuario.Text, txtContraseña.Text, txtCedula.Text, txtNombre.Text, txtApellidos.Text,
                                        txtTelefono.Text, txtCorreoElectronico.Text, txtDireccion.Text, "Catador")
                If i = True Then
                    MsgBox("Guardado correctamente")
                    LimpiarCampos()
                    CargarGrilla()
                    Total_Lista()
                    Contar_Registros()
                Else
                    MsgBox("No se pudo guardar")
                End If
                'If txtNombreUsuario.Text = "1" Then
                '    MsgBox("Este usuario ya se encuentra registrado", vbExclamation, "Seguridad")
                'End If
            End If
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------

    'Evento: Al iniciar el formulario los campos tiene el efecto Placeholder
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

    Sub LimpiarCampos()
        txtBuscarPor.Text = "Cedula"
        txtNombreUsuario.Clear()
        txtContraseña.Clear()
        txtConfirmarContraseña.Clear()
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()
        txtCorreoElectronico.Clear()
        txtDireccion.Clear()
        txtBuscar.Focus()
    End Sub

    Sub Des_Campos() 'Desabitar campos y botones
        If dgListaCatadores.RowCount = 0 Then
            'Desabitar campos
            txtNombreUsuario.Enabled = False
            txtContraseña.Enabled = False
            cbVerContraseña.Enabled = False
            txtConfirmarContraseña.Enabled = False
            txtCedula.Enabled = False
            txtNombre.Enabled = False
            txtApellidos.Enabled = False
            txtTelefono.Enabled = False
            txtCorreoElectronico.Enabled = False
            txtDireccion.Enabled = False

            'Desabitar botones
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If        
    End Sub

    Sub Hab_Campos() 'Habilitar campos y botones
        'Desabitar campos
        txtNombreUsuario.Enabled = True
        txtContraseña.Enabled = True
        cbVerContraseña.Enabled = True
        txtConfirmarContraseña.Enabled = True
        txtCedula.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtTelefono.Enabled = True
        txtCorreoElectronico.Enabled = True
        txtDireccion.Enabled = True

        'Modificar boton Nuevo Catador
        btnNuevoCatadorYGuardar.Text = "Guardar"
        btnNuevoCatadorYGuardar.Image = My.Resources.Guardar_32x32

        'Desabilitar los botones 'Modificar' y 'Eliminar'
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    'CONTROL VER CONTRASEÑA
    Private Sub cbVerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerContraseña.CheckedChanged
        If cbVerContraseña.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.TextLength = 0 Or txtBuscar.Text = "Buscar" Then
            BinGrilla.RemoveFilter()
            Contar_Registros()
            Exit Sub
        End If
        If txtBuscarPor.Text = "Cedula" Then
            BinGrilla.Filter = "Cedula like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Usuario" Then
            BinGrilla.Filter = "Usuario like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Nombre" Then
            BinGrilla.Filter = "Nombre like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Apellidos" Then
            BinGrilla.Filter = "Apellidos like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Correo electrónico" Then
            BinGrilla.Filter = "Correo like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Teléfono" Then
            BinGrilla.Filter = "Teléfono like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Dirección" Then
            BinGrilla.Filter = "Direccion like '" & txtBuscar.Text & "%'"
        End If
        Contar_Registros()
    End Sub

    Private Sub txtBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarPor.SelectedIndexChanged
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Sub HabCampos_ModEli() 'Habilita los campos para poder modificar o eliminar
        txtNombreUsuario.Enabled = True
        txtContraseña.Enabled = True
        txtConfirmarContraseña.Enabled = True
        txtCedula.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtTelefono.Enabled = True
        txtCorreoElectronico.Enabled = True
        txtDireccion.Enabled = True

        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        If btnNuevoCatadorYGuardar.Text = "Guardar" Then
            btnNuevoCatadorYGuardar.Text = "Nuevo catador"
            btnNuevoCatadorYGuardar.Image = My.Resources.Nuevo_catador_32x32
        End If
    End Sub

    Private Sub dgListaCatadores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaCatadores.CellEnter
        Dim varCedula As String
        Dim row As DataGridViewRow = dgListaCatadores.CurrentRow
        varCedula = CStr(row.Cells("Cedula").Value)
        BinBuscar.DataSource = Fun_Usuario.Buscar_Catadores
        BinBuscar.Filter = "Cedula = '" & varCedula & "'"
        HabCampos_ModEli()
        txtNombreUsuario.Text = BinBuscar(0)("NombreUsuario")
        txtContraseña.Text = BinBuscar(0)("Contraseña")
        txtConfirmarContraseña.Text = BinBuscar(0)("Contraseña")
        txtCedula.Text = BinBuscar(0)("Cedula")
        txtNombre.Text = BinBuscar(0)("Nombre")
        txtApellidos.Text = BinBuscar(0)("Apellidos")
        txtTelefono.Text = BinBuscar(0)("Telefono")
        txtCorreoElectronico.Text = BinBuscar(0)("CorreoElectronico")
        txtDireccion.Text = BinBuscar(0)("Direccion")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim varCodigo As String
        varCodigo = BinBuscar(0)("Codigo")
        If txtContraseña.Text <> txtConfirmarContraseña.Text Then
            MsgBox("La contraseña de confirmación de coincien.", vbCritical, "Seguridad")
            txtConfirmarContraseña.Clear()
            txtConfirmarContraseña.Focus()
        ElseIf MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            If Fun_Usuario.Modificar_Catador(varCodigo, txtNombreUsuario.Text, txtContraseña.Text, txtCedula.Text, txtNombre.Text,
                                             txtApellidos.Text, txtTelefono.Text, txtCorreoElectronico.Text, txtDireccion.Text) Then
                MessageBox.Show("Modificado correctamente")
                CargarGrilla()
                Total_Lista()
                Contar_Registros()
            Else
                MsgBox("Error al Modificar. Vuelva a intentarlo", vbCritical, "Seguridad")
                txtCedula.Clear()
                txtCedula.Focus()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim varCodigo As String
        varCodigo = BinBuscar(0)("Codigo")
        If MsgBox("¿Esta seguro de eliminar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            If Fun_Usuario.Eliminar_Catador(varCodigo) Then
                MessageBox.Show("Eliminado Correctamente")
                CargarGrilla()
                Total_Lista()
                Contar_Registros()
            Else
                MsgBox("Error al Eliminar. Vuelva a intentarlo", vbCritical, "Seguridad")
            End If
        End If
    End Sub
End Class