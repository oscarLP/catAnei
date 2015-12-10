Public Class frmCiudad
    Private Fun_Ciudad As New Gestor_Ciudad

    Private TablaCiudades As New BindingSource
    Private RegistroSeleccionado As New BindingSource

    Private Sub frmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        AntesDelFocus_txtBuscar() 'Evento que se genera en el control 'txtBuscar'
        LimpiarCampos()
        CargarGrilla() 'Carga en la tabla todos los registros
        Total_Registrados() 'Muestra 'Total' el numero de registros
        Des_Campos() 'Desabilita los campos si no se ha registrado ningun registro
        Desabilitar_Modificar_Eliminar()
        dgListaCiudad.ClearSelection() 'Cancelo la seleccion de la tabla
    End Sub

    'BOTON GUARDAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnNuevoCiudadYGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoCiudadYGuardar.Click
        Dim i As Boolean
        Dim Codigo_Ciudad As String

        If btnNuevoCiudadYGuardar.Text = "Nueva ciudad" Then
            Hab_Campos() 'Habilita los campos
            Desabilitar_Modificar_Eliminar()
            Mod_Nueva_Ciudad()
            LimpiarCampos()
            txtCiudad.Focus() 'Da foco de entrada al campo 'Ciudad'
        ElseIf btnNuevoCiudadYGuardar.Text = "Guardar" Then
            If txtCiudad.TextLength = 0 Then
                MsgBox("Por favor, escriva el nombre de la canción.", vbExclamation, "Seguridad")
            Else
                Codigo_Ciudad = Fun_Ciudad.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
                If i = Fun_Ciudad.Guardar_Ciudad(Codigo_Ciudad, txtCiudad.Text, Fun_Ciudad.Codigo_Pais("Colombia")) = False Then
                    'Modificar boton Guardar
                    btnNuevoCiudadYGuardar.Text = "Nueva ciudad"
                    btnNuevoCiudadYGuardar.Image = My.Resources.Ciudad_32x32 'Coloca una imagen el boton 'Guardar'

                    Des_Campos()
                    LimpiarCampos()
                    CargarGrilla()
                    Total_Registrados()
                    Contar_Registros()
                    Actualizar_Lista_Ciudades()
                Else
                    MsgBox("No se pudo guardar.", vbExclamation, "Seguridad")
                    txtCiudad.Focus()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub Antes_Modificar()
        Hab_Campos()
        btnNuevoCiudadYGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Text = "Aceptar"
        Me.AcceptButton = btnModificar
        txtCiudad.Focus()
    End Sub

    Sub Despues_Modificar()
        Des_Campos()
        btnNuevoCiudadYGuardar.Enabled = True
        btnEliminar.Enabled = True
        btnModificar.Text = "Modificar"
        Me.AcceptButton = btnNuevoCiudadYGuardar
        txtBuscar.Focus()
    End Sub

    'BOTON MODIFICAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            Antes_Modificar()
        ElseIf btnModificar.Text = "Aceptar" Then
            Dim varCod_Ciudad As String
            Dim varCod_Pais As String
            Dim i As Boolean

            If MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

                varCod_Ciudad = RegistroSeleccionado.Item(0)("cod_ciudad")
                varCod_Pais = RegistroSeleccionado.Item(0)("cod_pais")

                If i = Fun_Ciudad.Modificar_Ciudad(varCod_Ciudad, txtCiudad.Text, varCod_Pais) = False Then
                    MessageBox.Show("Modificado correctamente")
                    Despues_Modificar()
                    CargarGrilla()
                    Total_Registrados()
                    Contar_Registros()
                    Actualizar_Lista_Ciudades()
                Else
                    MsgBox("Error al Modificar. Vuelva a intentarlo", vbCritical, "Seguridad")
                    txtCiudad.Clear()
                    txtCiudad.Focus()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    'BOTON ELIMINAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim varCod_Ciudad As String
        varCod_Ciudad = RegistroSeleccionado(0)("cod_ciudad")
        If MsgBox("¿Esta seguro de eliminar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            If Fun_Ciudad.Eliminar_Ciudad(varCod_Ciudad) Then
                MessageBox.Show("Eliminado Correctamente")
                CargarGrilla()
                Total_Registrados()
                Contar_Registros()
                Actualizar_Lista_Ciudades()
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
            TablaCiudades.RemoveFilter()
            Contar_Registros()
            Exit Sub
        End If
        TablaCiudades.Filter = "nombre like '" & txtBuscar.Text & "%'"
        Contar_Registros() 'Cuenta los registros que resultan de la filtracion de la tabla
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub LimpiarCampos()
        txtCiudad.Clear()
        txtCiudad.Focus()
    End Sub

    Sub Desabilitar_Modificar_Eliminar()
        'Desabilitar los botones 'Modificar' y 'Eliminar'
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub Des_Campos() 'Desabitar campos y botones
        'Desabitar campos
        txtCiudad.Enabled = False
    End Sub

    Sub Mod_Nueva_Ciudad() 'Modifica el boton 'btnNuevoYGudar' si esta en en 'Nueva ciudad'
        'Modificar boton Nuevo Catador
        btnNuevoCiudadYGuardar.Text = "Guardar"
        btnNuevoCiudadYGuardar.Image = My.Resources.Guardar_32x32 'Coloca una imagen el boton 'Guardar'
    End Sub

    Sub Hab_Campos() 'Habilitar campos y botones
        'Desabitar campos
        txtCiudad.Enabled = True
    End Sub

    Sub Mostrar_Ciudad()
        Dim varNombre As String
        Dim row As DataGridViewRow = dgListaCiudad.CurrentRow
        varNombre = CStr(row.Cells("Nombre").Value) 'Obtiene el dato que contiene la columna 'Nombre' de la celda seleccionada

        RegistroSeleccionado.DataSource = Fun_Ciudad.Buscar_Ciudad() 'Obtiene la tabla de todos los catadores registrados

        RegistroSeleccionado.Filter = "nombre = '" & varNombre & "'"
        txtCiudad.Text = RegistroSeleccionado.Item(0)("nombre")
    End Sub

    'Evento de la grilla para mostrar el registro (fila) en la parte 'Gestion de catador'
    Private Sub dgListaCiudad_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaCiudad.CellEnter
        If dgListaCiudad.ContainsFocus = True Then
            If btnNuevoCiudadYGuardar.Text = "Guardar" Then 'Esto quiere decir que se esta llevando el registro de una nueva ciudad
                If MsgBox("Se está llevando a cabo el registro de una nueva ciudad. ¿Desea cancelar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                    Mostrar_Ciudad()

                    btnNuevoCiudadYGuardar.Text = "Nueva ciudad"
                    Des_Campos()
                    Desabilitar_Modificar_Eliminar()
                    btnNuevoCiudadYGuardar.Image = My.Resources.Ciudad_32x32
                Else
                    btnModificar.Enabled = False
                    btnEliminar.Enabled = False
                    txtCiudad.Focus()
                End If
            ElseIf btnModificar.Text = "Aceptar" Then 'Esto quiere decir que se esta llevando a cabo la modificacion de una ciudad
                If MsgBox("Se está llevando a cabo la modificación de una ciudad. ¿Desea cancelar la modicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                    Mostrar_Ciudad()
                    Despues_Modificar()
                End If
            Else
                btnModificar.Enabled = True
                btnEliminar.Enabled = True
                Mostrar_Ciudad()
            End If
        End If
    End Sub

    Sub Total_Registrados() 'Muestra el total de las ciudades registradas
        lbTotal.Text = Fun_Ciudad.Total_Registrados()
    End Sub

    Sub CargarGrilla() 'Carga los registros de las ciudades en la tabla
        TablaCiudades.DataSource = Fun_Ciudad.Tabla_Ciudades()
        dgListaCiudad.DataSource = TablaCiudades
    End Sub

    Sub Contar_Registros() 'Cuenta los registros filtrados en la tabla
        lbSeleccionados.Text = dgListaCiudad.RowCount
    End Sub

    'Actualiza el numero de registros reflejados en la tabla
    Private Sub dgListaCiudad_BindingContextChanged(sender As Object, e As EventArgs) Handles dgListaCiudad.BindingContextChanged
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
    Private Sub txtCiudad_TextChanged(sender As Object, e As EventArgs) Handles txtCiudad.TextChanged
        erValidarError.SetError(txtCiudad, Nothing)
        txtCiudad.BackColor = SystemColors.Window
    End Sub

    'validating
    Private Sub txtCiudad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCiudad.Validating
        If txtCiudad.TextLength = 0 Then
            erValidarError.SetError(txtCiudad, "Este campo es obligatorio")
            txtCiudad.BackColor = Color.MistyRose
        Else
            txtCiudad.BackColor = SystemColors.Window
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Sub Actualizar_Lista_Ciudades()
        frmProveedores.Cargar_Ciudades()
        frmProductores.Cargar_Ciudades()
        frmNuevaSesionCatacion.Cargar_Ciudades()
        frmMuestra.Cargar_Ciudades()
    End Sub
End Class