Public Class frmCatarRobusta
    Private Fun_Muestra As New Gestor_Muestra

    Private Tabla_SesionesCatacion As New BindingSource
    Private Sub frmCatarRobusta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
        Iniciar_Formulario()
    End Sub

    Sub Iniciar_Formulario()
        Dim Cod_Sesion As String

        Cod_Sesion = frmRealizarCataciones.varCod_Sesion 'Obtiene el Codigo de la sesion seleccionado
        'Cargos los valor de identificador
        Tabla_SesionesCatacion.DataSource = Fun_Muestra.Lista_Valor_Identificado(Cod_Sesion)
        bgMuestras.DataSource = Tabla_SesionesCatacion
        bgMuestras.Columns("codigo").Visible = False
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
        rbSalobre.Checked = False
        rbCasiSalobre.Checked = False
        rbNeutralSaborBoca.Checked = False
        rbCasiSabroso.Checked = False
        rbSabroso.Checked = False
        txtSaborBoca.Clear()
        'Evaluación 5
        cbPuntaje_SalAcido.Text = "7.5"
        cbBajaSalinidad.Text = ""
        cbAltaAcidez.Text = ""
        txtSalAcido.Clear()
        'Evaluación 6
        cbPuntaje_AmargoDulce.Text = "7.5"
        cbBajoAmargor.Text = ""
        cbAltoDulzor.Text = ""
        'Evaluación 7
        cbPuntaje_SensacionBoca.Text = "7.5"
        rbÁspero.Checked = False
        rbCasiÁspero.Checked = False
        rbNeutrarSesacionBoca.Checked = False
        rbCasiÁspero.Checked = False
        rbTerso.Checked = False
        'Evaluación 8
        cbPuntaje_Uniformidad.Text = 10
        cbUniformidad1.Checked = True
        cbUniformidad2.Checked = True
        cbUniformidad3.Checked = True
        cbUniformidad4.Checked = True
        cbUniformidad5.Checked = True
        'Evaluación 9
        cbPuntaje_TazaLimpia.Text = 10
        cbTazaLimpia1.Checked = True
        cbTazaLimpia2.Checked = True
        cbTazaLimpia3.Checked = True
        cbTazaLimpia4.Checked = True
        cbTazaLimpia5.Checked = True
        'Evaluación 10
        cbPuntaje_Balance.Text = "7.5"
        txtBalance.Clear()
        'Evaluación 11
        cbPuntaje_General.Text = "7.5"
        'Evaluación 12
        txtDefectos.Text = "7.5"
        txtDefectos.Clear()
        'Evaluación 13
        txtNotas.Clear()
        nuDefectos.Value = 0
    End Sub

    'Botones Descriptores
    '------------------------------------------------------------
    Private Sub btnDescriptores_FraganciaAroma_Click(sender As Object, e As EventArgs) Handles btnDescriptores_FraganciaAroma.Click
        frmDescriptores_FraganciaAroma.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Sabor_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Sabor.Click
        frmDescriptores_Sabor.ShowDialog()
    End Sub

    Private Sub btnDescriptores_SaborBoca_Click(sender As Object, e As EventArgs) Handles btnDescriptores_SaborBoca.Click
        frmDescriptores_SaborBoca.ShowDialog()
    End Sub

    Private Sub btnDescriptores_SalAcido_Click(sender As Object, e As EventArgs) Handles btnDescriptores_SalAcido.Click
        frmDescriptores_SalÁcido.ShowDialog()
    End Sub

    Private Sub btnDescriptores_SensacionBoca_Click(sender As Object, e As EventArgs) Handles btnDescriptores_SensacionBoca.Click
        frmDescriptores_SensaciónBoca.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Balance_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Balance.Click
        frmDescriptores_Balance.ShowDialog()
    End Sub

    Private Sub btnDescriptores_Defectos_Click(sender As Object, e As EventArgs) Handles btnDescriptores_Defectos.Click
        frmDescriptores_Defectos.ShowDialog()
    End Sub
    '------------------------------------------------------------

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

    'Controlar el chekeo de Sabor de boca
    '---------------------------------------------------------
    Private Sub rbSalobre_CheckedChanged(sender As Object, e As EventArgs) Handles rbSalobre.CheckedChanged
        If rbSalobre.Checked = True Then
            rbCasiSalobre.Checked = False
            rbNeutralSaborBoca.Checked = False
            rbCasiSabroso.Checked = False
            rbSabroso.Checked = False
        Else
            rbSalobre.Checked = False
        End If
    End Sub

    Private Sub rbCasiSalobre_CheckedChanged(sender As Object, e As EventArgs) Handles rbCasiSalobre.CheckedChanged
        If rbCasiSalobre.Checked = True Then
            rbSalobre.Checked = False
            rbNeutralSaborBoca.Checked = False
            rbCasiSabroso.Checked = False
            rbSabroso.Checked = False
        Else
            rbCasiSalobre.Checked = False
        End If
    End Sub

    Private Sub rbNeutralSaborBoca_CheckedChanged(sender As Object, e As EventArgs) Handles rbNeutralSaborBoca.CheckedChanged
        If rbNeutralSaborBoca.Checked = True Then
            rbSalobre.Checked = False
            rbCasiSalobre.Checked = False
            rbCasiSabroso.Checked = False
            rbSabroso.Checked = False
        Else
            rbNeutralSaborBoca.Checked = False
        End If
    End Sub

    Private Sub rbCasiSabroso_CheckedChanged(sender As Object, e As EventArgs) Handles rbCasiSabroso.CheckedChanged
        If rbCasiSabroso.Checked = True Then
            rbSalobre.Checked = False
            rbCasiSalobre.Checked = False
            rbNeutralSaborBoca.Checked = False
            rbSabroso.Checked = False
        Else
            rbCasiSabroso.Checked = False
        End If
    End Sub

    Private Sub rbSabroso_CheckedChanged(sender As Object, e As EventArgs) Handles rbSabroso.CheckedChanged
        If rbSabroso.Checked = True Then
            rbSalobre.Checked = False
            rbCasiSalobre.Checked = False
            rbNeutralSaborBoca.Checked = False
            rbCasiSabroso.Checked = False
        Else
            rbSabroso.Checked = False
        End If
    End Sub
    '---------------------------------------------------------

    'Controlar el chekeo de Sensación en boca
    '---------------------------------------------------------

    Private Sub rbÁspero_CheckedChanged(sender As Object, e As EventArgs) Handles rbÁspero.CheckedChanged
        If rbÁspero.Checked = True Then
            rbCasiÁspero.Checked = False
            rbNeutrarSesacionBoca.Checked = False
            rbCasiTerso.Checked = False
            rbTerso.Checked = False
        Else
            rbÁspero.Checked = False
        End If
    End Sub

    Private Sub rbCasiÁspero_CheckedChanged(sender As Object, e As EventArgs) Handles rbCasiÁspero.CheckedChanged
        If rbCasiÁspero.Checked = True Then
            rbÁspero.Checked = False
            rbNeutrarSesacionBoca.Checked = False
            rbCasiTerso.Checked = False
            rbTerso.Checked = False
        Else
            rbCasiÁspero.Checked = False
        End If
    End Sub

    Private Sub rbNeutrarSesacionBoca_CheckedChanged(sender As Object, e As EventArgs) Handles rbNeutrarSesacionBoca.CheckedChanged
        If rbNeutrarSesacionBoca.Checked = True Then
            rbÁspero.Checked = False
            rbCasiÁspero.Checked = False
            rbCasiTerso.Checked = False
            rbTerso.Checked = False
        Else
            rbNeutrarSesacionBoca.Checked = False
        End If
    End Sub

    Private Sub rbCasiTerso_CheckedChanged(sender As Object, e As EventArgs) Handles rbCasiTerso.CheckedChanged
        If rbCasiTerso.Checked = True Then
            rbÁspero.Checked = False
            rbCasiÁspero.Checked = False
            rbNeutrarSesacionBoca.Checked = False
            rbTerso.Checked = False
        Else
            rbCasiTerso.Checked = False
        End If
    End Sub

    Private Sub rbTerso_CheckedChanged(sender As Object, e As EventArgs) Handles rbTerso.CheckedChanged
        If rbTerso.Checked = True Then
            rbÁspero.Checked = False
            rbCasiÁspero.Checked = False
            rbNeutrarSesacionBoca.Checked = False
            rbCasiTerso.Checked = False
        Else
            rbTerso.Checked = False
        End If
    End Sub
    '---------------------------------------------------------------

    Private Sub bgMuestras_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles bgMuestras.CellEnter
        Dim Fun_Robusta As New Gestor_Robusta
        Dim Catacion_Robusta As Robusta

        Dim Fun_ArabicaRobusta As New Gestor_Arabica_Robusta
        Dim Catacion_ArabicaRobusta As Arabica_Robusta

        Dim varCod_Muestra As String

        Dim row As DataGridViewRow = bgMuestras.CurrentRow
        varCod_Muestra = CStr(row.Cells("codigo").Value)

        Try
            'ROBUSTA
            '--------------------------------------------------------------
            Dim Sabor_De_Boca As String

            Catacion_Robusta = Fun_Robusta.Atributos_Robusta(varCod_Muestra)

            lbCalificacion.Text = Catacion_Robusta.calificacion
            Sabor_De_Boca = Catacion_Robusta.sabor_boca
            cbPuntaje_SalAcido.Text = Catacion_Robusta.puntaje_sal_acido
            cbBajaSalinidad.Text = Catacion_Robusta.baja_salinidad
            cbAltaAcidez.Text = Catacion_Robusta.alta_acidez
            cbPuntaje_AmargoDulce.Text = Catacion_Robusta.puntaje_amargo_dulce
            cbBajoAmargor.Text = Catacion_Robusta.bajo_amargor
            cbAltoDulzor.Text = Catacion_Robusta.alto_dulzor
            cbPuntaje_SensacionBoca.Text = Catacion_Robusta.puntaje_sensacion_boca
            txtSensacionBoca.Text = Catacion_Robusta.sensacion_boca
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class