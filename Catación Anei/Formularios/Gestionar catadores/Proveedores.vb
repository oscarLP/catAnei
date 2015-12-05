Public Class frmProveedores
    Private Fun_Persona As New Gestor_Persona
    Private Fun_Proveedor As New Gestor_Proveedores

    Private TablaProveedores As New BindingSource
    Private RegistroSeleccionado As New BindingSource
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        AntesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        LimpiarCampos()
        Cargar_Ciudades() 'Carga todas las ciudades registradas
        CargarGrilla() 'Carga en la tabla todos los registros
        Total_Registrados() 'Muestra 'Total' el numero de registros
        Des_Campos() 'Desabilita los campos si no se ha registrado ningun registro
        Desibilitar_Modificar_Eliminar()
        dgLista_Proveedores.ClearSelection()
    End Sub

    'BOTON GUARDAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnNuevoProveedorYGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedorYGuardar.Click
        Dim i As Boolean
        Dim j As Boolean
        Dim Codigo_Persona As String
        Dim Codigo_Proveedores As String

        If btnNuevoProveedorYGuardar.Text = "Nuevo proveedor" Then
            Hab_Campos() 'Habilita los campos
            Desabilitar_Modificar_Eliminar()
            Mod_Nuevo_Productor()
            LimpiarCampos()
            txtCedula.Focus() 'Da foco de entrada al campo 'Cedula'
        ElseIf btnNuevoProveedorYGuardar.Text = "Guardar" Then
            If txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellido.TextLength = 0 Or cbCiudad.Text = "" Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
            Else
                Codigo_Persona = Fun_Persona.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
                Codigo_Proveedores = Fun_Proveedor.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo

                i = Fun_Persona.Guardar_Persona(Codigo_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Proveedor")

                If i = True Then
                    j = Fun_Proveedor.Guardar_Proveedores(Codigo_Proveedores, txtVereda.Text, txtFinca.Text, Fun_Proveedor.Codigo_Ciudad(cbCiudad.Text), Codigo_Persona)
                    'Modificar boton Guardar
                    btnNuevoProveedorYGuardar.Text = "Nuevo proveedor"
                    btnNuevoProveedorYGuardar.Image = My.Resources.Nuevo_catador_32x32 'Coloca una imagen el boton 'Guardar'
                    Des_Campos()
                    LimpiarCampos()
                    CargarGrilla()
                    Total_Registrados()
                    Contar_Registros()
                Else
                    MsgBox("No se pudo guardar.", vbExclamation, "Seguridad")
                    txtCedula.Focus()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub Antes_Modificar()
        Hab_Campos()
        btnNuevoProveedorYGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Text = "Aceptar"
        Me.AcceptButton = btnModificar
        btnNuevoProveedorYGuardar.Focus()
    End Sub

    Sub Despues_Modificar()
        Des_Campos()
        btnNuevoProveedorYGuardar.Enabled = True
        btnEliminar.Enabled = True
        btnModificar.Text = "Modificar"
        Me.AcceptButton = btnNuevoProveedorYGuardar
        txtBuscar.Focus()
    End Sub

    'BOTON MODIFICAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            Antes_Modificar()
        ElseIf btnModificar.Text = "Aceptar" Then
            Dim varCod_Persona As String
            Dim varCod_Proveedor As String
            Dim varCod_Ciudad As String
            Dim i As Boolean
            Dim j As Boolean

            If txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellido.TextLength = 0 Or cbCiudad.Text = "" Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
            ElseIf MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

                varCod_Persona = RegistroSeleccionado.Item(0)("cod_persona")
                varCod_Proveedor = RegistroSeleccionado.Item(0)("cod_proveedor")
                varCod_Ciudad = RegistroSeleccionado.Item(0)("cod_ciudad")

                i = Fun_Persona.Modificar_Persona(varCod_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Proveedor")
                If i = True Then
                    j = Fun_Proveedor.Modificar_Proveedor(varCod_Proveedor, txtVereda.Text, txtFinca.Text, varCod_Ciudad, varCod_Persona)
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

    Sub Cargar_Ciudades()
        Dim Lista_Ciudades As New BindingSource
        Lista_Ciudades.DataSource = Fun_Proveedor.Lista_Ciudad()
        cbCiudad.Items.Clear()
        For i = 0 To Lista_Ciudades.Count - 1
            cbCiudad.Items.Add(Lista_Ciudades.Item(i)("nombre"))
        Next
    End Sub

    'EL CONTROL 'txtBuscar' tiene un evento para filtrar la tabla por algun atributo especifico
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.TextLength = 0 Or txtBuscar.Text = "Buscar" Then
            TablaProveedores.RemoveFilter()
            Contar_Registros()
            Exit Sub
        End If
        If txtBuscarPor.Text = "Cedula" Then
            TablaProveedores.Filter = "cedula like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Nombre" Then
            TablaProveedores.Filter = "nombre like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Apellido" Then
            TablaProveedores.Filter = "apellido like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Teléfono" Then
            TablaProveedores.Filter = "teléfono like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Correo electrónico" Then
            TablaProveedores.Filter = "Correo like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Ciudad" Then
            TablaProveedores.Filter = "ciudad like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Vereda" Then
            TablaProveedores.Filter = "vereda like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Finca" Then
            TablaProveedores.Filter = "finca like '" & txtBuscar.Text & "%'"
        End If
        Contar_Registros() 'Cuenta los registros que resultan de la filtracion de la tabla
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub LimpiarCampos()
        txtBuscarPor.Text = "Cedula"
        txtBuscar.Focus()
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtCedula.Clear()
        cbCiudad.Text = ""
        txtVereda.Clear()
        txtFinca.Clear()
        txtBuscar.Focus()
    End Sub

    Sub Desibilitar_Modificar_Eliminar()
        'Desabitar botones
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub Des_Campos() 'Desabitar campos y botones
        txtCedula.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False
        cbCiudad.Enabled = False
        txtVereda.Enabled = False
        txtFinca.Enabled = False
    End Sub

    Sub Mod_Nuevo_Productor() 'Modifica el boton 'btnNuevoYGudar' si esta en en 'Nuevo catador'
        'Modificar boton Nuevo Catador
        btnNuevoProveedorYGuardar.Text = "Guardar"
        btnNuevoProveedorYGuardar.Image = My.Resources.Guardar_32x32 'Coloca una imagen el boton 'Guardar'
    End Sub

    Sub Desabilitar_Modificar_Eliminar()
        'Desabilitar los botones 'Modificar' y 'Eliminar'
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub Hab_Campos() 'Habilitar campos y botones
        'Desabitar campos
        txtCedula.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        cbCiudad.Enabled = True
        txtVereda.Enabled = True
        txtFinca.Enabled = True
    End Sub

    'Borra el campo 'Buscar' justo antes de escoger otro atributo para filtrar la tabla
    Private Sub txtBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarPor.SelectedIndexChanged
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Sub Mostrar_Proveedor()
        Dim varCedula As String
        Dim row As DataGridViewRow = dgLista_Proveedores.CurrentRow
        varCedula = CStr(row.Cells("Cedula").Value) 'Obtiene el dato que contiene la columna 'Cedula' de la celda seleccionada

        RegistroSeleccionado.DataSource = Fun_Proveedor.Buscar_Proveedor() 'Obtiene la tabla de todos los catadores registrados

        RegistroSeleccionado.Filter = "cedula = '" & varCedula & "'"
        txtCedula.Text = RegistroSeleccionado.Item(0)("cedula")
        txtNombre.Text = RegistroSeleccionado.Item(0)("nombre")
        txtApellido.Text = RegistroSeleccionado.Item(0)("apellido")
        txtTelefono.Text = RegistroSeleccionado.Item(0)("telefono")
        txtCorreo.Text = RegistroSeleccionado.Item(0)("correo")
        cbCiudad.Text = RegistroSeleccionado.Item(0)("ciudad")
        txtVereda.Text = RegistroSeleccionado.Item(0)("vereda")
        txtFinca.Text = RegistroSeleccionado.Item(0)("finca")
    End Sub

    'Evento de la grilla para mostrar el registro (fila) en la parte 'Gestion de catador'
    Private Sub dgLista_Proveedores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista_Proveedores.CellEnter
        If dgLista_Proveedores.ContainsFocus = True Then
            If btnNuevoProveedorYGuardar.Text = "Guardar" Then 'Esto quiere decir que se esta llevando el registro de un nuevo catador
                If MsgBox("Se está llevando a cabo el registro de un nuevo proveedor. ¿Desea cancelar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                    Mostrar_Proveedor()

                    btnNuevoProveedorYGuardar.Text = "Nuevo proveedor"
                    Des_Campos()
                    Desibilitar_Modificar_Eliminar()
                    btnNuevoProveedorYGuardar.Image = My.Resources.Nuevo_catador_32x32
                Else
                    btnModificar.Enabled = False
                    btnEliminar.Enabled = False
                    txtCedula.Focus()
                End If
            ElseIf btnModificar.Text = "Aceptar" Then 'Esto quiere decir que se esta llevando a cabo la modificacion de un catador
                If MsgBox("Se está llevando a cabo la modificación de un proveedor. ¿Desea cancelar la modicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                    Mostrar_Proveedor()
                    Despues_Modificar()
                End If
            Else
                btnModificar.Enabled = True
                btnEliminar.Enabled = True
                Mostrar_Proveedor()
            End If
        End If

    End Sub

    Sub Total_Registrados() 'Muestra el total de los proveedores registrados
        lbTotal.Text = Fun_Proveedor.Total_Registrados()
    End Sub

    Sub CargarGrilla() 'Carga los registros de los proveedores en la tabla
        TablaProveedores.DataSource = Fun_Proveedor.Tabla_Proveedores()
        dgLista_Proveedores.DataSource = TablaProveedores
    End Sub

    Sub Contar_Registros() 'Cuenta los registros filtrados en la tabla
        lbSeleccionados.Text = dgLista_Proveedores.RowCount
    End Sub

    'Actualiza el numero de registros reflejados en la tabla
    Private Sub dgLista_Proveedores_BindingContextChanged(sender As Object, e As EventArgs) Handles dgLista_Proveedores.BindingContextChanged
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

    Private Sub cbCiudad_TextChanged(sender As Object, e As EventArgs) Handles cbCiudad.TextChanged
        erValidarError.SetError(cbCiudad, Nothing)
        cbCiudad.BackColor = SystemColors.Window
    End Sub

    'validating

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

    Private Sub cbCiudad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbCiudad.Validating
        If cbCiudad.Text = "" Then
            erValidarError.SetError(cbCiudad, "Este campo es obligatorio")
            cbCiudad.BackColor = Color.MistyRose
        Else
            cbCiudad.BackColor = SystemColors.Window
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        frmCiudad.ShowDialog()
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