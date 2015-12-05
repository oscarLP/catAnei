Public Class frmRealizarCataciones
    Private Fun_sesion As New Gestor_Sesion_Catado
    Private Tabla_SesionesCatacion As New BindingSource

    Private Sub frmRealizarCataciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar()
        AntesDelFocus_txtBuscar()
        LimpiarCampos()
        CargarGrilla() 'Carga en la tabla todos los registros
        Total_Registrados() 'Muestra 'Total' el numero de registros
    End Sub

    Sub LimpiarCampos()
        btnCatar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
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
    Private Sub btnNuevaSesionCatacion_Click(sender As Object, e As EventArgs) Handles btnNuevaSesionCatacion.Click
        frmNuevaSesionCatacion.Show()
        frmNuevaSesionCatacion.Focus()
    End Sub

    Private Sub btnCatar_Click(sender As Object, e As EventArgs) Handles btnCatar.Click
        'frmCatarArabica.Show()
        'frmCatarArabica.Focus()

        frmCatarRobusta.Show()
        frmCatarRobusta.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmModicarSesionCatacion.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'VERIFICAR SI LA SESIÓN PERTENECE AL USUARIO Y SINO SE ENCUENTRA CATADA PARA ENVIARLA A ELIMINAR
    End Sub

    Sub Total_Registrados() 'Muestra el total de catadores registradores
        lbTotal.Text = Fun_sesion.Total_Registros
    End Sub

    Sub CargarGrilla() 'Carga todos los registros de sesiones de catacion en la tabla
        Tabla_SesionesCatacion.DataSource = Fun_sesion.Tabla_sesiones
        dgListaSesionesCataciones.DataSource = Tabla_SesionesCatacion
    End Sub

    Sub Contar_Registros() 'Cuenta los registros filtrados en la tabla
        lbSeleccionados.Text = dgListaSesionesCataciones.RowCount
    End Sub

    'Actualiza el numero de registros reflejados en la tabla
    Private Sub dgListaSesionesCataciones_BindingContextChanged(sender As Object, e As EventArgs) Handles dgListaSesionesCataciones.BindingContextChanged
        Contar_Registros()
    End Sub

End Class