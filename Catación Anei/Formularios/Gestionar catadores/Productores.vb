Public Class frmProductores
    Private Fun_Persona As New Gestor_Persona
    Private Fun_Productor As New Gestor_Productores

    Private TablaProductores As New BindingSource
    Private RegistroSeleccionado As New BindingSource

    Private Sub frmProductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        AntesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        LimpiarCampos()
        Cargar_Ciudades() 'Carga todas las ciudades registradas
        CargarGrilla() 'Carga en la tabla todos los registros
        Total_Registrados() 'Muestra 'Total' el numero de registros
        Des_Campos() 'Desabilita los campos si no se ha registrado ningun registro
    End Sub

    'BOTON GUARDAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnNuevoProductorYGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoProductorYGuardar.Click
        Dim i As Boolean
        Dim j As Boolean
        Dim Codigo_Persona As String
        Dim Codigo_Productor As String

        If btnNuevoProductorYGuardar.Text = "Nuevo productor" Then
            Hab_Campos() 'Habilita los campos
            LimpiarCampos()
            txtCedula.Focus() 'Da foco de entrada al campo 'Cedula'
        ElseIf btnNuevoProductorYGuardar.Text = "Guardar" Then
            If txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellido.TextLength = 0 Or cbCiudad.Text = "" Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
            Else
                Codigo_Persona = Fun_Persona.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
                Codigo_Productor = Fun_Productor.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo

                i = Fun_Persona.Guardar_Persona(Codigo_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Productor")

                If i = True Then
                    j = Fun_Productor.Guardar_Productores(Codigo_Productor, txtVereda.Text, txtFinca.Text, Fun_Productor.Codigo_Ciudad(cbCiudad.Text), Codigo_Persona)

                    LimpiarCampos()
                    CargarGrilla()
                    Total_Registrados()
                    Contar_Registros()
                Else
                    MsgBox("No se pudo guardar.", vbExclamation, "Seguridad")
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    'BOTON MODIFICAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim varCod_Persona As String
        Dim varCod_Productor As String
        Dim i As Boolean
        Dim j As Boolean

        If txtCedula.TextLength = 0 Or txtNombre.TextLength = 0 Or txtApellido.TextLength = 0 Or cbCiudad.Text = "" Then
            MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
        ElseIf MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

            varCod_Persona = RegistroSeleccionado.Item(0)("cod_persona")
            varCod_Productor = RegistroSeleccionado.Item(0)("cod_productor")
            'varCod_Ciudad = RegistroSeleccionado.Item(0)("cod_ciudad")

            i = Fun_Persona.Modificar_Persona(varCod_Persona, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, "Productor")
            j = Fun_Productor.Modificar_Productor(varCod_Productor, txtVereda.Text, txtFinca.Text, Fun_Productor.Codigo_Ciudad(cbCiudad.Text), varCod_Persona)

            If i = True And j = True Then
                MessageBox.Show("Modificado correctamente")
                CargarGrilla()
                Total_Registrados()
                Contar_Registros()

            Else
                MsgBox("Error al Modificar. Vuelva a intentarlo", vbCritical, "Seguridad")
                txtCedula.Clear()
                txtCedula.Focus()
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
        Lista_Ciudades.DataSource = Fun_Productor.Lista_Ciudad()
        For i = 0 To Lista_Ciudades.Count - 1
            cbCiudad.Items.Add(Lista_Ciudades.Item(i)("nombre"))
        Next
    End Sub

    'EL CONTROL 'txtBuscar' tiene un evento para filtrar la tabla por algun atributo especifico
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.TextLength = 0 Or txtBuscar.Text = "Buscar" Then
            TablaProductores.RemoveFilter()
            Contar_Registros()
            Exit Sub
        End If
        If txtBuscarPor.Text = "Cedula" Then
            TablaProductores.Filter = "cedula like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Nombre" Then
            TablaProductores.Filter = "nombre like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Apellido" Then
            TablaProductores.Filter = "apellido like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Teléfono" Then
            TablaProductores.Filter = "teléfono like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Correo electrónico" Then
            TablaProductores.Filter = "Correo like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Ciudad" Then
            TablaProductores.Filter = "ciudad like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Vereda" Then
            TablaProductores.Filter = "vereda like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Finca" Then
            TablaProductores.Filter = "finca like '" & txtBuscar.Text & "%'"
        End If
        Contar_Registros() 'Cuenta los registros que resultan de la filtracion de la tabla
        '---------------------------------------------------------------------------------------------------------------------------
    End Sub

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
    End Sub

    Sub Des_Campos() 'Desabitar campos y botones
        If dgLista_Productores.RowCount = 0 Then
            'Desabitar campos
            txtCedula.Enabled = False
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtTelefono.Enabled = False
            txtCorreo.Enabled = False
            cbCiudad.Enabled = False
            txtVereda.Enabled = False
            txtFinca.Enabled = False

            'Desabitar botones
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
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

        'Modificar boton Nuevo productor
        btnNuevoProductorYGuardar.Text = "Guardar"
        btnNuevoProductorYGuardar.Image = My.Resources.Guardar_32x32 'Coloca una imagen el boton 'Guardar'

        'Desabilitar los botones 'Modificar' y 'Eliminar'
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub HabCampos_ModEli() 'Habilita los campos para poder modificar o eliminar
        txtCedula.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        cbCiudad.Enabled = True
        txtVereda.Enabled = True
        txtFinca.Enabled = True

        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        If btnNuevoProductorYGuardar.Text = "Guardar" Then
            btnNuevoProductorYGuardar.Text = "Nuevo productor"
            btnNuevoProductorYGuardar.Image = My.Resources.Nuevo_catador_32x32
        End If
    End Sub

    'Borra el campo 'Buscar' justo antes de escoger otro atributo para filtrar la tabla
    Private Sub txtBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarPor.SelectedIndexChanged
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    'Evento de la grilla para mostrar el registro (fila) en la parte 'Gestion de catador'
    Private Sub dgLista_Productores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista_Productores.CellEnter
        Dim varCedula As String
        Dim row As DataGridViewRow = dgLista_Productores.CurrentRow
        varCedula = CStr(row.Cells("Cedula").Value) 'Obtiene el dato que contiene la columna 'Cedula' de la celda seleccionada

        RegistroSeleccionado.DataSource = Fun_Productor.Buscar_Productor() 'Obtiene la tabla de todos los catadores registrados

        RegistroSeleccionado.Filter = "cedula = '" & varCedula & "'"
        HabCampos_ModEli()
        txtCedula.Text = RegistroSeleccionado.Item(0)("cedula")
        txtNombre.Text = RegistroSeleccionado.Item(0)("nombre")
        txtApellido.Text = RegistroSeleccionado.Item(0)("apellido")
        txtTelefono.Text = RegistroSeleccionado.Item(0)("telefono")
        txtCorreo.Text = RegistroSeleccionado.Item(0)("correo")
        cbCiudad.Text = RegistroSeleccionado.Item(0)("ciudad")
        txtVereda.Text = RegistroSeleccionado.Item(0)("vereda")
        txtFinca.Text = RegistroSeleccionado.Item(0)("finca")
    End Sub

    Sub Total_Registrados() 'Muestra el total de los productores registrados
        lbTotal.Text = Fun_Productor.Total_Registrados()
    End Sub

    Sub CargarGrilla() 'Carga los registros de los productores en la tabla
        TablaProductores.DataSource = Fun_Productor.Tabla_Productores()
        dgLista_Productores.DataSource = TablaProductores
    End Sub

    Sub Contar_Registros() 'Cuenta los registros filtrados en la tabla
        lbSeleccionados.Text = dgLista_Productores.RowCount
    End Sub

    'Actualiza el numero de registros reflejados en la tabla

    Private Sub dgLista_Productores_BindingContextChanged(sender As Object, e As EventArgs) Handles dgLista_Productores.BindingContextChanged
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
        txtCedula.BackColor = Color.White
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        erValidarError.SetError(txtNombre, Nothing)
        txtNombre.BackColor = Color.White
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        erValidarError.SetError(txtApellido, Nothing)
        txtApellido.BackColor = Color.White
    End Sub

    Private Sub cbCiudad_TextChanged(sender As Object, e As EventArgs) Handles cbCiudad.TextChanged
        erValidarError.SetError(cbCiudad, Nothing)
        cbCiudad.BackColor = Color.White
    End Sub

    'validating
    Private Sub txtCedula_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCedula.Validating
        If txtCedula.TextLength = 0 Then
            erValidarError.SetError(txtCedula, "Este campo es obligatorio")
            txtCedula.BackColor = Color.MistyRose
        Else
            txtCedula.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.TextLength = 0 Then
            erValidarError.SetError(txtNombre, "Este campo es obligatorio")
            txtNombre.BackColor = Color.MistyRose
        Else
            txtNombre.BackColor = Color.White
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellido.Validating
        If txtApellido.TextLength = 0 Then
            erValidarError.SetError(txtApellido, "Este campo es obligatorio")
            txtApellido.BackColor = Color.MistyRose
        Else
            txtApellido.BackColor = Color.White
        End If
    End Sub

    Private Sub cbCiudad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbCiudad.Validating
        If cbCiudad.Text = "" Then
            erValidarError.SetError(cbCiudad, "Este campo es obligatorio")
            cbCiudad.BackColor = Color.MistyRose
        Else
            cbCiudad.BackColor = Color.White
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        frmCiudad.ShowDialog()
    End Sub
End Class