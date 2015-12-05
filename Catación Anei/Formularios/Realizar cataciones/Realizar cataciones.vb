Public Class frmRealizarCataciones
    Private Fun_SesionCatacion As New Gestor_Sesion_de_catacion
    Private Fun_Muestra As New Gestor_Muestra
    Public varSesion As String
    Public varCod_Sesion As String

    Private Tabla_SesionesCatacion As New BindingSource
    Private SesionCatado_Seleccionada As New BindingSource
    Private Sub frmRealizarCataciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar()
        AntesDelFocus_txtBuscar()
        CargarGrilla() 'Carga en la tabla todos los registros
        Total_Registrados() 'Muestra 'Total' el numero de registros
        LimpiarCampos()
        dgListaSesionesCataciones.ClearSelection()
    End Sub

    'EL CONTROL 'txtBuscar' tiene un evento para filtrar la tabla por algun atributo especifico
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.TextLength = 0 Or txtBuscar.Text = "Buscar" Then
            Tabla_SesionesCatacion.RemoveFilter()
            Contar_Registros()
            Exit Sub
        End If
        If txtBuscarPor.Text = "Fecha" Then
            Tabla_SesionesCatacion.Filter = "Fecha like '%" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Hora" Then
            Tabla_SesionesCatacion.Filter = "Hora like '%" & txtBuscar.Text & "%'"
            'ElseIf txtBuscarPor.Text = "Descripción" Then
            '    Tabla_SesionesCatacion.Filter = "Descripción like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Lugar" Then
            Tabla_SesionesCatacion.Filter = "Lugar like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Identificador" Then
            Tabla_SesionesCatacion.Filter = "Identificador like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Protocolo" Then
            Tabla_SesionesCatacion.Filter = "Protocolo like '" & txtBuscar.Text & "%'"
        ElseIf txtBuscarPor.Text = "Muestras" Then
            Tabla_SesionesCatacion.Filter = "Muestras like '" & txtBuscar.Text & "%'"
        End If
        Contar_Registros() 'Cuenta los registros que resultan de la filtracion de la tabla
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub LimpiarCampos()
        txtBuscarPor.Text = "Fecha"
        txtBuscar.Focus()
    End Sub

    Sub Habilitar_Botones()
        btnCatar.Enabled = True
        btnMuestra.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub Desabilitar_Botones()
        btnCatar.Enabled = False
        btnMuestra.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    'Este evento de la grilla captura el registro seleccionado para luego hacer actualizaciones con esta
    Private Sub dgListaSesionesCataciones_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaSesionesCataciones.CellEnter
        Registro_Seleccionado()
    End Sub

    Sub Registro_Seleccionado()
        If dgListaSesionesCataciones.ContainsFocus = True Then
            Dim row As DataGridViewRow = dgListaSesionesCataciones.CurrentRow
            varSesion = CStr(row.Cells("#").Value) 'Le asigna a la variable 'varSesion' el num de sesion
            varCod_Sesion = CStr(row.Cells("cod_sesion").Value)

            SesionCatado_Seleccionada.DataSource = Fun_SesionCatacion.Tabla_SesionCatado()
            SesionCatado_Seleccionada.Filter = "cod_sesion = '" & varCod_Sesion & "'"

            Habilitar_Botones()
        Else
            dgListaSesionesCataciones.ClearSelection()
            Desabilitar_Botones()
        End If
    End Sub

    'Evento: Al iniciar el formulario los campos tiene el efecto Placeholder
    '-------------------------------------------------------------------------------------------------------------
    Sub DespuesDelFocus_txtBuscar()
        If txtBuscar.Text = "Buscar" Then
            txtBuscar.ForeColor = Color.DimGray
            txtBuscar.Clear()
        End If
    End Sub

    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        DespuesDelFocus_txtBuscar()
    End Sub

    Sub AntesDelFocus_txtBuscar()
        If txtBuscar.Text = Nothing Then
            txtBuscar.ForeColor = Color.Silver
            txtBuscar.Text = "Buscar"
        End If
    End Sub

    Private Sub txtBuscar_LostFocus(sender As Object, e As EventArgs) Handles txtBuscar.LostFocus
        AntesDelFocus_txtBuscar()
    End Sub
    '-------------------------------------------------------------------------------------------------------------

    Private Sub btnNuevaSesionCatacion_Click(sender As Object, e As EventArgs) Handles btnNuevaSesionCatacion.Click
        frmNuevaSesionCatacion.ShowDialog()
    End Sub

    Private Sub btnCatar_Click(sender As Object, e As EventArgs) Handles btnCatar.Click
        Dim Protocolo_Catacion As String
        Protocolo_Catacion = Fun_Muestra.Protocolo_Catacion(varCod_Sesion)

        If Protocolo_Catacion = "Arabica" Then
            frmCatarArabica.ShowDialog()
        Else
            frmCatarRobusta.ShowDialog()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmModicarSesionCatacion.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim varCod_Sesion As String
        varCod_Sesion = SesionCatado_Seleccionada(0)("cod_sesion")
        If MsgBox("¿Esta seguro de eliminar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            If Fun_SesionCatacion.Eliminar_SesionCatacion(varCod_Sesion) Then
                MessageBox.Show("Eliminado Correctamente")
                CargarGrilla()
                Total_Registrados()
                Contar_Registros()
            Else
                MsgBox("Error al Eliminar. Vuelva a intentarlo", vbCritical, "Seguridad")
            End If
        End If
    End Sub

    Private Sub btnMuestra_Click(sender As Object, e As EventArgs) Handles btnMuestra.Click
        frmMuestra.ShowDialog()
    End Sub

    Sub Total_Registrados() 'Muestra el total de catadores registradores
        lbTotal.Text = Fun_SesionCatacion.Total_Registros()
    End Sub

    Sub CargarGrilla() 'Carga todos los registros de sesiones de catacion en la tabla
        Tabla_SesionesCatacion.DataSource = Fun_SesionCatacion.Tabla_SesionCatado()
        dgListaSesionesCataciones.DataSource = Tabla_SesionesCatacion
        dgListaSesionesCataciones.Columns("cod_sesion").Visible = False
    End Sub

    Sub Contar_Registros() 'Cuenta los registros filtrados en la tabla
        lbSeleccionados.Text = dgListaSesionesCataciones.RowCount
        If lbSeleccionados.Text = 0 Then
            Desabilitar_Botones()
        End If
    End Sub

    'Actualiza el numero de registros reflejados en la tabla
    Private Sub dgListaSesionesCataciones_BindingContextChanged(sender As Object, e As EventArgs) Handles dgListaSesionesCataciones.BindingContextChanged
        Contar_Registros()
    End Sub
End Class