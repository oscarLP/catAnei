Public Class frmCatarArabica

    Private Sub frmCatarArabica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
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
End Class