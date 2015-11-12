Public Class frmRealizarCataciones
    Private Sub frmRealizarCataciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtBuscar()
        AntesDelFocus_txtBuscar()
        LimpiarCampos()
    End Sub

    Sub LimpiarCampos()
        'btnCatar.Enabled = False
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
    '-------------------------------------------------------------------------------------------------------------

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
        frmEliminarSesionCatacion.ShowDialog()
    End Sub
End Class