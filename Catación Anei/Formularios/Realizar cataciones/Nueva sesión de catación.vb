Public Class frmNuevaSesionCatacion
    Private Fun_SesionCatacion As New Gestor_Sesion_de_catacion
    Private Fun_Muestra As New Gestor_Muestra
    Private Codigo_SesionCatado As String

    Private Sub frmNuevaSesionCatacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmFecha.Start()
        LimpiarCampos()
        Cargar_Ciudades()
    End Sub

    'BOTON GUARDAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Codigo_Ciudad As String
        If cbLugar.Text = "" Then
            MsgBox("Por favor, seleccione el lugar de catación", vbExclamation, "Seguridad")
            cbLugar.Focus()
        Else
            Dim i As Boolean 'Variable utilizada para obtener respuesta si el registro fue guardado correctamente en la tabla 'SESION_CATADO'

            Codigo_SesionCatado = Fun_SesionCatacion.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
            Codigo_Ciudad = Fun_SesionCatacion.Codigo_Ciudad(cbLugar.Text)
            i = Fun_SesionCatacion.Guardar_SesionCatacion(Codigo_SesionCatado, lbFechaInicio.Text, lbHoraInicio.Text, txtDescripcion.Text, Codigo_Ciudad,
                                                          IdentificadorMuestra(), ProtocoloCatacion(), nuNumeroMuestras.Value, Fun_SesionCatacion.CodigoUsuario())
            If i = True Then 'Si 'i' es igual a true quiere decir que el registro de esta sesion de catacion se guardo correctamente
                Guardar_Identificador_Muestras()
                LimpiarCampos()
                Actualizar_Tabla()
                Me.Close()
            Else
                Fun_SesionCatacion.Eliminar_SesionCatacion(Codigo_SesionCatado) 'Elimina el registro de la sesion de catacion si no se pudo guardar el codigo del usuario
                txtDescripcion.Focus()
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------

    Sub Cargar_Ciudades()
        Dim Lista_Ciudades As New BindingSource
        Lista_Ciudades.DataSource = Fun_Muestra.Lista_Ciudad()
        cbLugar.Items.Clear()
        For i = 0 To Lista_Ciudades.Count - 1
            cbLugar.Items.Add(Lista_Ciudades.Item(i)("nombre"))
        Next
    End Sub

    Sub LimpiarCampos()
        txtDescripcion.Clear()
        cbLugar.Text = ""
        nuNumeroMuestras.Value = 1
        rbLetras.Checked = True
        rbArabica.Checked = True
        lbSesion.Text = frmRealizarCataciones.dgListaSesionesCataciones.RowCount + 1
        txtDescripcion.Focus()
    End Sub

    'Obtiene la fecha y hora actual del sistema
    Private Sub tmFecha_Tick(sender As Object, e As EventArgs) Handles tmFecha.Tick
        lbHoraInicio.Text = Now.ToLongTimeString
        lbFechaInicio.Text = Now.ToLongDateString
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
    End Function

    Sub Actualizar_Tabla()
        frmRealizarCataciones.CargarGrilla()
        frmRealizarCataciones.Total_Registrados()
        frmRealizarCataciones.dgListaSesionesCataciones.ClearSelection()
        frmRealizarCataciones.txtBuscar.Focus()
    End Sub

    Sub Guardar_Identificador_Muestras()
        Dim Cod_Muestra As String
        Dim Cod_Idenficacion As String
        Dim Valor_Indice As String
        Dim Especie As String
        Dim Año_Cosecha As String
        Dim Codigo_Ciudad As String

        Codigo_Ciudad = Fun_SesionCatacion.Codigo_Ciudad(cbLugar.Text)
        Especie = ProtocoloCatacion()
        Año_Cosecha = Now.Year

        If IdentificadorMuestra() = "Digitos" Then
            For i = 0 To nuNumeroMuestras.Value - 1
                Cod_Muestra = Fun_Muestra.Codigo_Azar()
                Cod_Idenficacion = Fun_Muestra.Digitos_Azar()

                Fun_Muestra.Guardar_Identificadores(Cod_Muestra, Cod_Idenficacion, Codigo_SesionCatado, Especie, Año_Cosecha, Codigo_Ciudad)
            Next
        ElseIf IdentificadorMuestra() = "Letras" Then
            For i = 0 To nuNumeroMuestras.Value - 1
                Cod_Muestra = Fun_Muestra.Codigo_Azar()
                Valor_Indice = Fun_Muestra.Generar_Letras(i)

                Fun_Muestra.Guardar_Identificadores(Cod_Muestra, Valor_Indice, Codigo_SesionCatado, Especie, Año_Cosecha, Codigo_Ciudad)
            Next
        End If
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        frmCiudad.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
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