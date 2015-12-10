Public Class frmNuevaSesionCatacion
    Private Fun_SesionCatacion As New Gestor_Sesion_de_catacion
    Private Fun_Muestra As New Gestor_Muestra
    Private Fun_Arabica As New Gestor_Arabica
    Private Fun_Arabica_Robusta As New Gestor_Arabica_Robusta
    Private Fun_Robusta As New Gestor_Robusta
    Private Codigo_SesionCatado As String

    Private Sub frmNuevaSesionCatacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Ciudades()
        LimpiarCampos()
    End Sub

    'BOTON GUARDAR
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Ses_Cat As New Sesion_catado

        Dim Codigo_Ciudad As String
        If cbLugar.Text = "" Then
            MsgBox("Por favor, seleccione el lugar de catación", vbExclamation, "Seguridad")
            cbLugar.Focus()
        Else
            Dim i As Boolean 'Variable utilizada para obtener respuesta si el registro fue guardado correctamente en la tabla 'SESION_CATADO'

            Codigo_SesionCatado = Fun_SesionCatacion.Codigo_Azar() 'Obtiene un codigo al azar para luego guardarlo
            Codigo_Ciudad = Fun_SesionCatacion.Codigo_Ciudad(cbLugar.Text)

            '------------------------------
            Ses_Cat.codigo = Codigo_SesionCatado
            Ses_Cat.fecha_inicio = dtpFecha_Inicio.Text
            Ses_Cat.hora_inicio = dtpHora_Inicio.Text
            Ses_Cat.descripcion = txtDescripcion.Text
            Ses_Cat.fk_codigo_ciudad = Codigo_Ciudad
            Ses_Cat.estructura_identificador = IdentificadorMuestra()
            Ses_Cat.protocolo = ProtocoloCatacion()
            Ses_Cat.fk_codigo_usuario = Fun_SesionCatacion.CodigoUsuario()
            Ses_Cat.numero_muestras = nuNumeroMuestras.Value
            Ses_Cat.estado = "Incompleto"
            '------------------------------

            'i = Fun_SesionCatacion.Guardar_SesionCatacion(Codigo_SesionCatado, dtpFecha_Inicio.Text, dtpHora_Inicio.Text, txtDescripcion.Text, Codigo_Ciudad,
            '                                              IdentificadorMuestra(), ProtocoloCatacion(), nuNumeroMuestras.Value, Fun_SesionCatacion.CodigoUsuario())
            i = Fun_SesionCatacion.Guardar_SesionCatado(Ses_Cat)
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
        dtpFecha_Inicio.Text = Now.ToLongDateString
        dtpHora_Inicio.Text = Now.ToShortTimeString
        lbSesion.Text = frmRealizarCataciones.dgListaSesionesCataciones.RowCount + 1
        txtDescripcion.Focus()
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
        If rbArabica.Checked = True Then
            ProtCatacion = "Arábica"
        ElseIf rbRobusta.Checked = True Then
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
                Cod_Idenficacion = i + 1

                Fun_Muestra.Guardar_Identificadores(Cod_Muestra, Cod_Idenficacion, Codigo_SesionCatado, Especie, Año_Cosecha, Codigo_Ciudad)
                Guardar_Catacion(Cod_Muestra)
            Next
        ElseIf IdentificadorMuestra() = "Letras" Then
            For i = 0 To nuNumeroMuestras.Value - 1
                Cod_Muestra = Fun_Muestra.Codigo_Azar()
                Valor_Indice = Fun_Muestra.Generar_Letras(i)

                Fun_Muestra.Guardar_Identificadores(Cod_Muestra, Valor_Indice, Codigo_SesionCatado, Especie, Año_Cosecha, Codigo_Ciudad)
                Guardar_Catacion(Cod_Muestra)
            Next
        End If
    End Sub

    Sub Guardar_Catacion(Cod_Muestra)
        If ProtocoloCatacion() = "Arábica" Then
            Guardar_Arabica(Cod_Muestra)
            Guardar_ArabicaRobusta(Cod_Muestra)
        ElseIf ProtocoloCatacion() = "Robusta" Then
            Guardar_Robusta(Cod_Muestra)
            Guardar_ArabicaRobusta(Cod_Muestra)
        End If
    End Sub

    Sub Guardar_Arabica(Codigo_Muestra)
        Dim Ara As New Arabica

        Dim Codigo_Azar As String
        Codigo_Azar = Fun_Arabica.Codigo_Azar()

        '--------------------------------
        Ara.codigo = Codigo_Azar
        Ara.fk_codigo_muestra = Codigo_Muestra
        Ara.calificacion = 82.5
        Ara.puntaje_acidez = 7.5
        Ara.puntaje_cuerpo = 7.5
        Ara.puntaje_dulzor = 10
        Ara.dulzor1 = "Verdadero"
        Ara.dulzor2 = "Falso"
        Ara.dulzor3 = "Verdadero"
        Ara.dulzor4 = "Verdadero"
        Ara.dulzor5 = "Verdadero"
        '--------------------------------
        Fun_Arabica.Guardar_Arabica(Ara)
    End Sub

    Sub Guardar_ArabicaRobusta(Codigo_Muestra)
        Dim Ara_Rob As New Arabica_Robusta

        Dim Codigo_Azar As String
        Codigo_Azar = Fun_Arabica_Robusta.Codigo_Azar()

        '--------------------------------
        Ara_Rob.codigo = Codigo_Azar
        Ara_Rob.fk_codigo_muestra = Codigo_Muestra
        Ara_Rob.nivel_tueste = "3"
        Ara_Rob.puntaje_fragancia_aroma = 7.5
        Ara_Rob.puntuaje_sabor = 7.5
        Ara_Rob.puntuaje_sabor_boca = 7.5
        Ara_Rob.puntuaje_balance = 7.5
        Ara_Rob.puntuaje_general = 7.5
        Ara_Rob.puntuaje_uniformidad = 10
        Ara_Rob.uniformidad1 = "Verdadero"
        Ara_Rob.uniformidad2 = "Verdadero"
        Ara_Rob.uniformidad3 = "Verdadero"
        Ara_Rob.uniformidad4 = "Verdadero"
        Ara_Rob.uniformidad5 = "Verdadero"
        Ara_Rob.puntuaje_taza_limpia = 10
        Ara_Rob.taza_limpia1 = "Verdadero"
        Ara_Rob.taza_limpia2 = "Verdadero"
        Ara_Rob.taza_limpia3 = "Verdadero"
        Ara_Rob.taza_limpia4 = "Verdadero"
        Ara_Rob.taza_limpia5 = "Verdadero"
        Ara_Rob.numero_defectos = 0
        Ara_Rob.nota = ""
        '--------------------------------

        Fun_Arabica_Robusta.Guardar_Arabica_Robusta(Ara_Rob)
    End Sub

    Sub Guardar_Robusta(Codigo_Muestra)
        Dim Rob As New Robusta

        Dim Codigo_Azar As String
        Codigo_Azar = Fun_Robusta.Codigo_Azar()

        '--------------------------------
        Rob.codigo = Codigo_Azar
        Rob.fk_codigo_muestra = Codigo_Muestra
        Rob.calificacion = 82.5
        Rob.sabor_boca = 0
        Rob.puntaje_sal_acido = 7.5
        Rob.baja_salinidad = ""
        Rob.alta_acidez = ""
        Rob.puntaje_amargo_dulce = 7.5
        Rob.bajo_amargor = ""
        Rob.alto_dulzor = ""
        Rob.puntaje_sensacion_boca = 7.5
        Rob.sensacion_boca = ""
        '--------------------------------

        Fun_Robusta.Guardar_Robusta(Rob)
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