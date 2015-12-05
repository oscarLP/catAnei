Public Class frmModicarSesionCatacion
    Private Fun_SesionCatado As New Gestor_Sesion_de_catacion

    Private SesionCatado_Seleccionada As New BindingSource
    Private Sub frmModicarSesionCatacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
        Mostrar_SesionCatado_Seleccionada()
        Cargar_Ciudades()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If cbLugar.Text = "" Then
            MsgBox("Por favor, seleccione el lugar de catación", vbExclamation, "Seguridad")
        Else
            Dim varCod_Sesion As String
            Dim Codigo_Ciudad As String
            Dim i As Boolean

            If MsgBox("¿Esta seguro de modificar el registro?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                varCod_Sesion = SesionCatado_Seleccionada.Item(0)("cod_sesion") 'La variable 'varCod_Sesion' obtiene el codigo del registro seleccionado a modificar
                Codigo_Ciudad = Fun_SesionCatado.Codigo_Ciudad(cbLugar.Text)
                i = Fun_SesionCatado.Modificar_SesionCatacion(varCod_Sesion, dtFechaInicio.Text, dtHoraInicio.Text, txtDescripcion.Text, Codigo_Ciudad, IdentificadorMuestra(), ProtocoloCatacion())

                If i = True Then
                    Actualizar_Tabla()
                    Me.Close()
                Else
                    MsgBox("Error al Modificar. Vuelva a intentarlo", vbCritical, "Seguridad")
                    Mostrar_SesionCatado_Seleccionada()
                    txtDescripcion.Focus()
                End If
            End If
        End If
    End Sub

    Sub LimpiarCampos()
        txtDescripcion.Clear()
        cbLugar.Text = ""
        rbLetras.Checked = True
        rbArabica.Checked = True
        txtDescripcion.Focus()
        lbSesion.Text = frmRealizarCataciones.varSesion
    End Sub

    Sub Mostrar_SesionCatado_Seleccionada()
        Dim varEstructura_Identificador As String
        Dim varProtocolo As String
        Dim varCod_Sesion As String

        varCod_Sesion = frmRealizarCataciones.varCod_Sesion
        SesionCatado_Seleccionada.DataSource = Fun_SesionCatado.Tabla_SesionCatado()

        SesionCatado_Seleccionada.Filter = "cod_sesion = '" & varCod_Sesion & "'"

        dtFechaInicio.Text = SesionCatado_Seleccionada.Item(0)("Fecha")
        dtHoraInicio.Text = SesionCatado_Seleccionada.Item(0)("Hora")
        txtDescripcion.Text = SesionCatado_Seleccionada.Item(0)("Descripción")

        cbLugar.Text = SesionCatado_Seleccionada.Item(0)("Lugar")

        varEstructura_Identificador = SesionCatado_Seleccionada.Item(0)("Identificador")
        varProtocolo = SesionCatado_Seleccionada.Item(0)("Protocolo")

        If varEstructura_Identificador = "Letras" Then
            rbLetras.Checked = True
            rbDigitos.Checked = False
        Else
            rbLetras.Checked = False
            rbDigitos.Checked = True
        End If
    End Sub

    Sub Cargar_Ciudades()
        Dim Lista_Ciudades As New BindingSource
        Lista_Ciudades.DataSource = Fun_SesionCatado.Lista_Ciudad()
        cbLugar.Items.Clear()
        For i = 0 To Lista_Ciudades.Count - 1
            cbLugar.Items.Add(Lista_Ciudades.Item(i)("nombre"))
        Next
    End Sub

    'Obtiene y envia el Identificador de la muestra seleccionada
    Function IdentificadorMuestra() As String
        Dim IDMuestra As String = "Letras"
        If rbLetras.Checked = True Then
            IDMuestra = "Letras"
        ElseIf rbDigitos.Checked = True Then
            IDMuestra = "Digitos"
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
        ProtocoloCatacion()
    End Function

    Sub Actualizar_Tabla()
        frmRealizarCataciones.CargarGrilla()
        frmRealizarCataciones.Total_Registrados()
        frmRealizarCataciones.dgListaSesionesCataciones.ClearSelection()
        frmRealizarCataciones.txtBuscar.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        frmCiudad.ShowDialog()
    End Sub

    Private Sub cbLugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLugar.SelectedIndexChanged
        erValidarError.SetError(cbLugar, Nothing)
        cbLugar.BackColor = SystemColors.Window
    End Sub

    Private Sub cbLugar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbLugar.Validating
        If cbLugar.Text = "" Then
            erValidarError.SetError(cbLugar, "Este campo es obligatorio")
            cbLugar.BackColor = Color.MistyRose
        Else
            cbLugar.BackColor = SystemColors.Window
        End If
    End Sub
End Class