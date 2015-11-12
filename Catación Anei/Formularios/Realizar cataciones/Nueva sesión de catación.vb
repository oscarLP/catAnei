Public Class frmNuevaSesionCatacion

    Private Sub frmNuevaSesionCatacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmFecha.Start()
        LimpiarCampos()
    End Sub

    Sub LimpiarCampos()
        txtDescripcion.Clear()
        txtLugar.Clear()
    End Sub

    Private Sub tmFecha_Tick(sender As Object, e As EventArgs) Handles tmFecha.Tick
        lbHoraInicio.Text = Now.ToLongTimeString
        lbFechaInicio.Text = Now.ToLongDateString
    End Sub
End Class