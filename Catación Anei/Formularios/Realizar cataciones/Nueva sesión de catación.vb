﻿Public Class frmNuevaSesionCatacion
    Private Fun_sesion As New Gestor_Sesion_Catado
    Private Fun_ciudad As New Gestor_Ciudad
    Private Clase_CatacionArabiba As New Clase_Catacion_Arabica

    Private Sub frmNuevaSesionCatacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmFecha.Start()
        LimpiarCampos()
        cargarLugares()
    End Sub

    'BOTON GUARDAR
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim CodigoSesionCatacion As String = Fun_sesion.Codigo()
        Dim lugar_save As String

        'valor del comboBox
        lugar_save = ComboLugar.SelectedValue.ToString

        Dim i As Boolean = Fun_sesion.Guardar_SesionCatacion(CodigoSesionCatacion, lbFechaInicio.Text, lbHoraInicio.Text, txtDescripcion.Text, lugar_save,
                                                                       IdentificadorMuestra(), ProtocoloCatacion(), nuNumeroMuestras.Value, Fun_sesion.Buscar_CodigoUsuario)

        If i = True Then
            LimpiarCampos()
            frmRealizarCataciones.CargarGrilla()
            frmRealizarCataciones.Total_Registrados()
            If ProtocoloCatacion() = "Arábica" Then
                For j = 1 To nuNumeroMuestras.Value
                    Clase_CatacionArabiba.Guardar_CatacionArabica(Clase_CatacionArabiba.Codigo(), CodigoSesionCatacion, "A")
                Next
            End If
            Me.Close()
        End If
    End Sub

    Sub LimpiarCampos()
        txtDescripcion.Clear()
        rbLetras.Checked = True
        rbArabica.Checked = True
        txtDescripcion.Focus()
    End Sub

    'Carga las ciudades registradas en la BD
    Sub cargarLugares()
        ComboLugar.DataSource = Fun_ciudad.Ciudades
        ComboLugar.DisplayMember = "nombre"
        ComboLugar.ValueMember = "codigo"
    End Sub

    'Obtiene la fecha y hora actual del sistema
    Private Sub tmFecha_Tick(sender As Object, e As EventArgs) Handles tmFecha.Tick
        lbHoraInicio.Text = Now.ToLongTimeString
        lbFechaInicio.Text = Now.ToLongDateString
    End Sub
    'Obtiene y envia el Identificador de la muestra seleccionada
    Function IdentificadorMuestra() As String
        Dim IDMuestra As String = "Letra"
        If rbLetras.Checked = True Then
            IDMuestra = "Letra"
        ElseIf rbDigitos.Checked = True Then
            IDMuestra = "Digito"
        End If
        Return IDMuestra
    End Function

    'Obtiene y envia el Protocolo de catacion de la muestra seleccionada
    Function ProtocoloCatacion() As String
        Dim ProtCatacion As String = "Arábica"
        If rbLetras.Checked = True Then
            ProtCatacion = "Arábica"
        ElseIf rbDigitos.Checked = True Then
            ProtCatacion = "Robusta"
        End If
        Return ProtCatacion
    End Function
    'AL CAMBIAR INDICE SELECCIONADO

End Class