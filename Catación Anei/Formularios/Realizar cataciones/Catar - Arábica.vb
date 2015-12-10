Public Class frmCatarArabica
    Private Fun_Arabica_Muestra As New Gestor_Muestra

    Private Tabla_SesionesCatacion_Arabica As New BindingSource
    Private RegistroSeleccionado As New BindingSource
    Private Sub frmCatarArabica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
        Iniciar_Formulario()
    End Sub

    Sub Iniciar_Formulario()
        Dim Cod_Sesion As String

        Cod_Sesion = frmRealizarCataciones.varCod_Sesion 'Obtiene el Codigo de la sesion seleccionado
        'Cargos los valor de identificador
        Tabla_SesionesCatacion_Arabica.DataSource = Fun_Arabica_Muestra.Lista_Valor_Identificado(Cod_Sesion)
        bgMuestras.DataSource = Tabla_SesionesCatacion_Arabica
        bgMuestras.Columns("codigo").Visible = False
    End Sub

    Private Sub btnDescriptores_FraganciaAroma_Click(sender As Object, e As EventArgs) Handles btnDescriptores_FraganciaAroma.Click
        frmDescriptores_FraganciaAroma.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Sabor_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Sabor.Click
        frmDescriptores_Sabor.ShowDialog()
    End Sub

    Private Sub btnDescriptores_SaborBoca_Click(sender As Object, e As EventArgs) Handles btnDescriptores_SaborBoca.Click
        frmDescriptores_SaborBoca.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Acidez_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Acidez.Click
        frmDescriptores_Acidez.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Cuerpo_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Cuerpo.Click
        frmDescriptores_Cuerpo.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Balance_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Balance.Click
        frmDescriptores_Balance.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Defectos_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Defectos.Click
        frmDescriptores_Defectos.ShowDialog()
    End Sub

    Sub LimpiarCampos()
        'Evaluación 1
        rbNivelTueste3.Checked = True
        'Evaluación 2
        cbPuntaje_FraganciaAroma.Text = "7.5"
        txtFraganciaAroma.Clear()
        'Evaluación 3
        cbPuntaje_Sabor.Text = "7.5"
        txtSabor.Clear()
        'Evaluación 4
        cbPuntaje_SaborBoca.Text = "7.5"
        txtSaborBoca.Clear()
        'Evaluación 5
        cbPuntaje_Acidez.Text = "7.5"
        txtAcidez.Clear()
        'Evaluación 6
        cbPuntaje_Cuerpo.Text = "7.5"
        txtCuerpo.Clear()
        'Evaluación 7
        cbPuntaje_Balance.Text = "7.5"
        txtDefectos.Clear()
        'Evaluación 8
        cbPuntaje_General.Text = "7.5"
        'Evaluación 9
        cbPuntaje_Uniformidad.Text = 10
        cbUniformidad1.Checked = True
        cbUniformidad2.Checked = True
        cbUniformidad3.Checked = True
        cbUniformidad4.Checked = True
        cbUniformidad5.Checked = True
        'Evaluación 10
        cbPuntaje_TazaLimpia.Text = 10
        cbTazaLimpia1.Checked = True
        cbTazaLimpia2.Checked = True
        cbTazaLimpia3.Checked = True
        cbTazaLimpia4.Checked = True
        cbTazaLimpia5.Checked = True
        'Evaluación 11
        cbPuntaje_Dulzor.Text = 10
        cbDulzor1.Checked = True
        cbDulzor2.Checked = True
        cbDulzor3.Checked = True
        cbDulzor4.Checked = True
        cbDulzor5.Checked = True
        'Evaluación 12
        nuDefectos.Value = 0
        txtDefectos.Clear()
        'Evaluación 13
        txtNotas.Clear()
    End Sub

    'Establecer puntaje de la Evaluacion de Uniformidad
    '-----------------------------------------------------------
    Private Sub cbUniformidad1_CheckedChanged(sender As Object, e As EventArgs) Handles cbUniformidad1.CheckedChanged
        If cbUniformidad1.Checked = False Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text - 2
            imgUniformidad1.Image = My.Resources.Taza_no_ok
        ElseIf cbUniformidad1.Checked = True Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text + 2
            imgUniformidad1.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbUniformidad2_CheckedChanged(sender As Object, e As EventArgs) Handles cbUniformidad2.CheckedChanged
        If cbUniformidad2.Checked = False Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text - 2
            imgUniformidad2.Image = My.Resources.Taza_no_ok
        ElseIf cbUniformidad2.Checked = True Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text + 2
            imgUniformidad2.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbUniformidad3_CheckedChanged(sender As Object, e As EventArgs) Handles cbUniformidad3.CheckedChanged
        If cbUniformidad3.Checked = False Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text - 2
            imgUniformidad3.Image = My.Resources.Taza_no_ok
        ElseIf cbUniformidad3.Checked = True Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text + 2
            imgUniformidad3.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbUniformidad4_CheckedChanged(sender As Object, e As EventArgs) Handles cbUniformidad4.CheckedChanged
        If cbUniformidad4.Checked = False Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text - 2
            imgUniformidad4.Image = My.Resources.Taza_no_ok
        ElseIf cbUniformidad4.Checked = True Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text + 2
            imgUniformidad4.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbUniformidad5_CheckedChanged(sender As Object, e As EventArgs) Handles cbUniformidad5.CheckedChanged
        If cbUniformidad5.Checked = False Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text - 2
            imgUniformidad5.Image = My.Resources.Taza_no_ok
        ElseIf cbUniformidad5.Checked = True Then
            cbPuntaje_Uniformidad.Text = cbPuntaje_Uniformidad.Text + 2
            imgUniformidad5.Image = My.Resources.Uniformidad_ok
        End If
    End Sub
    '-----------------------------------------------------------

    'Establecer puntaje de la Evaluacion de TazaLimpia
    '-----------------------------------------------------------
    Private Sub cbTazaLimpia1_CheckedChanged(sender As Object, e As EventArgs) Handles cbTazaLimpia1.CheckedChanged
        If cbTazaLimpia1.Checked = False Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text - 2
            imgTazaLimpia1.Image = My.Resources.Taza_no_ok
        ElseIf cbTazaLimpia1.Checked = True Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text + 2
            imgTazaLimpia1.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbTazaLimpia2_CheckedChanged(sender As Object, e As EventArgs) Handles cbTazaLimpia2.CheckedChanged
        If cbTazaLimpia2.Checked = False Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text - 2
            imgTazaLimpia2.Image = My.Resources.Taza_no_ok
        ElseIf cbTazaLimpia2.Checked = True Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text + 2
            imgTazaLimpia2.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbTazaLimpia3_CheckedChanged(sender As Object, e As EventArgs) Handles cbTazaLimpia3.CheckedChanged
        If cbTazaLimpia3.Checked = False Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text - 2
            imgTazaLimpia3.Image = My.Resources.Taza_no_ok
        ElseIf cbTazaLimpia3.Checked = True Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text + 2
            imgTazaLimpia3.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbTazaLimpia4_CheckedChanged(sender As Object, e As EventArgs) Handles cbTazaLimpia4.CheckedChanged
        If cbTazaLimpia4.Checked = False Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text - 2
            imgTazaLimpia4.Image = My.Resources.Taza_no_ok
        ElseIf cbTazaLimpia4.Checked = True Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text + 2
            imgTazaLimpia4.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbTazaLimpia5_CheckedChanged(sender As Object, e As EventArgs) Handles cbTazaLimpia5.CheckedChanged
        If cbTazaLimpia5.Checked = False Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text - 2
            imgTazaLimpia5.Image = My.Resources.Taza_no_ok
        ElseIf cbTazaLimpia5.Checked = True Then
            cbPuntaje_TazaLimpia.Text = cbPuntaje_TazaLimpia.Text + 2
            imgTazaLimpia5.Image = My.Resources.Uniformidad_ok
        End If
    End Sub
    '-----------------------------------------------------------
    'Establecer puntaje de la Evaluacion de Dulzor
    '-----------------------------------------------------------
    Private Sub cbDulzor1_CheckedChanged(sender As Object, e As EventArgs) Handles cbDulzor1.CheckedChanged
        If cbDulzor1.Checked = False Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text - 2
            imgDulzor1.Image = My.Resources.Taza_no_ok
        ElseIf cbDulzor1.Checked = True Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text + 2
            imgDulzor1.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbDulzor2_CheckedChanged(sender As Object, e As EventArgs) Handles cbDulzor2.CheckedChanged
        If cbDulzor2.Checked = False Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text - 2
            imgDulzor2.Image = My.Resources.Taza_no_ok
        ElseIf cbDulzor2.Checked = True Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text + 2
            imgDulzor2.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbDulzor3_CheckedChanged(sender As Object, e As EventArgs) Handles cbDulzor3.CheckedChanged
        If cbDulzor3.Checked = False Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text - 2
            imgDulzor3.Image = My.Resources.Taza_no_ok
        ElseIf cbDulzor3.Checked = True Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text + 2
            imgDulzor3.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbDulzor4_CheckedChanged(sender As Object, e As EventArgs) Handles cbDulzor4.CheckedChanged
        If cbDulzor4.Checked = False Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text - 2
            imgDulzor4.Image = My.Resources.Taza_no_ok
        ElseIf cbDulzor4.Checked = True Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text + 2
            imgDulzor4.Image = My.Resources.Uniformidad_ok
        End If
    End Sub

    Private Sub cbDulzor5_CheckedChanged(sender As Object, e As EventArgs) Handles cbDulzor5.CheckedChanged
        If cbDulzor5.Checked = False Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text - 2
            imgDulzor5.Image = My.Resources.Taza_no_ok
        ElseIf cbDulzor5.Checked = True Then
            cbPuntaje_Dulzor.Text = cbPuntaje_Dulzor.Text + 2
            imgDulzor5.Image = My.Resources.Uniformidad_ok
        End If
    End Sub
    '-----------------------------------------------------------

    Private Sub bgMuestras_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles bgMuestras.CellEnter
        Dim Fun_Arabica As New Gestor_Arabica
        Dim Catacion_Arabica As Arabica

        Dim Fun_ArabicaRobusta As New Gestor_Arabica_Robusta
        Dim Catacion_ArabicaRobusta As Arabica_Robusta

        Dim varCod_Muestra As String

        Dim row As DataGridViewRow = bgMuestras.CurrentRow
        varCod_Muestra = CStr(row.Cells("codigo").Value)

        Try
            'ARABICA
            '--------------------------------------------------------------
            Dim dulzor1 As String
            Dim dulzor2 As String
            Dim dulzor3 As String
            Dim dulzor4 As String
            Dim dulzor5 As String

            Catacion_Arabica = Fun_Arabica.Atributos_Arabica(varCod_Muestra)
            lbCalificacion.Text = Catacion_Arabica.calificacion
            cbPuntaje_Acidez.Text = Catacion_Arabica.puntaje_acidez
            cbPuntaje_Cuerpo.Text = Catacion_Arabica.puntaje_cuerpo
            cbPuntaje_Dulzor.Text = Catacion_Arabica.puntaje_dulzor
            dulzor1 = Catacion_Arabica.dulzor1
            dulzor2 = Catacion_Arabica.dulzor2
            dulzor3 = Catacion_Arabica.dulzor3
            dulzor4 = Catacion_Arabica.dulzor4
            dulzor5 = Catacion_Arabica.dulzor5

            If dulzor1 = "Verdadero" Then
                cbDulzor1.Checked = True
            ElseIf dulzor1 = "Falso" Then
                cbDulzor1.Checked = False
            End If

            If dulzor2 = "Verdadero" Then
                cbDulzor2.Checked = True
            ElseIf dulzor2 = "Falso" Then
                cbDulzor2.Checked = False
            End If

            If dulzor3 = "Verdadero" Then
                cbDulzor3.Checked = True
            ElseIf dulzor3 = "Falso" Then
                cbDulzor3.Checked = False
            End If

            If dulzor4 = "Verdadero" Then
                cbDulzor4.Checked = True
            ElseIf dulzor4 = "Falso" Then
                cbDulzor4.Checked = False
            End If

            If dulzor5 = "Verdadero" Then
                cbDulzor5.Checked = True
            ElseIf dulzor5 = "Falso" Then
                cbDulzor5.Checked = False
            End If
            '--------------------------------------------------------------

            'ARABICA_ROBUSTA
            '--------------------------------------------------------------
            Dim Nivel_Tueste As String
            Dim uniformidad1 As String
            Dim uniformidad2 As String
            Dim uniformidad3 As String
            Dim uniformidad4 As String
            Dim uniformidad5 As String
            Dim tazaLimpia1 As String
            Dim tazaLimpia2 As String
            Dim tazaLimpia3 As String
            Dim tazaLimpia4 As String
            Dim tazaLimpia5 As String

            Catacion_ArabicaRobusta = Fun_ArabicaRobusta.Atributos_Arabica_Robusta(varCod_Muestra)
            Nivel_Tueste = Catacion_ArabicaRobusta.nivel_tueste
            cbPuntaje_FraganciaAroma.Text = Catacion_ArabicaRobusta.puntaje_fragancia_aroma
            cbPuntaje_Sabor.Text = Catacion_ArabicaRobusta.puntuaje_sabor
            cbPuntaje_SaborBoca.Text = Catacion_ArabicaRobusta.puntuaje_sabor_boca
            cbPuntaje_Balance.Text = Catacion_ArabicaRobusta.puntuaje_balance
            cbPuntaje_Uniformidad.Text = Catacion_ArabicaRobusta.puntuaje_uniformidad
            uniformidad1 = Catacion_ArabicaRobusta.uniformidad1
            uniformidad2 = Catacion_ArabicaRobusta.uniformidad2
            uniformidad3 = Catacion_ArabicaRobusta.uniformidad3
            uniformidad4 = Catacion_ArabicaRobusta.uniformidad4
            uniformidad5 = Catacion_ArabicaRobusta.uniformidad5
            cbPuntaje_TazaLimpia.Text = Catacion_ArabicaRobusta.puntuaje_taza_limpia
            tazaLimpia1 = Catacion_ArabicaRobusta.taza_limpia1
            tazaLimpia2 = Catacion_ArabicaRobusta.taza_limpia2
            tazaLimpia3 = Catacion_ArabicaRobusta.taza_limpia3
            tazaLimpia4 = Catacion_ArabicaRobusta.taza_limpia4
            tazaLimpia5 = Catacion_ArabicaRobusta.taza_limpia5
            nuDefectos.Value = Catacion_ArabicaRobusta.numero_defectos
            txtNotas.Text = Catacion_ArabicaRobusta.nota

            If Nivel_Tueste = "1" Then
                rbNivelTueste1.Checked = True
            ElseIf Nivel_Tueste = "2" Then
                rbNivelTueste2.Checked = True
            ElseIf Nivel_Tueste = "3" Then
                rbNivelTueste3.Checked = True
            ElseIf Nivel_Tueste = "4" Then
                rbNivelTueste4.Checked = True
            ElseIf Nivel_Tueste = "5" Then
                rbNivelTueste5.Checked = True
            End If

            If uniformidad1 = "Verdadero" Then
                cbUniformidad1.Checked = True
            ElseIf uniformidad1 = "Falso" Then
                cbUniformidad1.Checked = False
            End If

            If uniformidad2 = "Verdadero" Then
                cbUniformidad2.Checked = True
            ElseIf uniformidad2 = "Falso" Then
                cbUniformidad1.Checked = False
            End If

            If uniformidad3 = "Verdadero" Then
                cbUniformidad3.Checked = True
            ElseIf uniformidad3 = "Falso" Then
                cbUniformidad3.Checked = False
            End If

            If uniformidad4 = "Verdadero" Then
                cbUniformidad4.Checked = True
            ElseIf uniformidad4 = "Falso" Then
                cbUniformidad4.Checked = False
            End If

            If uniformidad5 = "Verdadero" Then
                cbUniformidad5.Checked = True
            ElseIf uniformidad5 = "Falso" Then
                cbUniformidad5.Checked = False
            End If

            'TAZA LIMPIA
            If tazaLimpia1 = "Verdadero" Then
                cbTazaLimpia1.Checked = True
            ElseIf tazaLimpia1 = "Falso" Then
                cbTazaLimpia1.Checked = False
            End If

            If tazaLimpia2 = "Verdadero" Then
                cbTazaLimpia2.Checked = True
            ElseIf tazaLimpia2 = "Falso" Then
                cbTazaLimpia2.Checked = False
            End If

            If tazaLimpia3 = "Verdadero" Then
                cbTazaLimpia3.Checked = True
            ElseIf tazaLimpia3 = "Falso" Then
                cbTazaLimpia3.Checked = False
            End If

            If tazaLimpia4 = "Verdadero" Then
                cbTazaLimpia4.Checked = True
            ElseIf tazaLimpia4 = "Falso" Then
                cbTazaLimpia4.Checked = False
            End If

            If tazaLimpia5 = "Verdadero" Then
                cbTazaLimpia5.Checked = True
            ElseIf tazaLimpia5 = "Falso" Then
                cbTazaLimpia5.Checked = False
            End If
            '--------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class