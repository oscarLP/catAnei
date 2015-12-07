Public Class frmCatarRobusta

    Private Sub frmCatarRobusta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
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
End Class