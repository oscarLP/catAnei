Public Class frmCambiarContraseña
    Private Fun_Administrador As New Gestor_Administrador

    Private Sub frmCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiasCampos()
    End Sub

    Sub LimpiasCampos()
        txtContraseña.Clear()
        txtNuevaContraseña.Clear()
        txtRNuevaContraseña.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Fun_Administrador.ValidadContraseña(txtContraseña.Text) = True Then 'Si es igual a true quiere decir que la contraseña es correcta
            If txtNuevaContraseña.TextLength = 0 Or txtRNuevaContraseña.TextLength = 0 Then
                MsgBox("Por favor, asegúrese de llenar todos los campos obligatorios.", vbExclamation, "Seguridad")
                txtNuevaContraseña.Focus()
            ElseIf txtNuevaContraseña.Text <> txtRNuevaContraseña.Text Then
                MsgBox("La confirmación de la contraseña no coinciden.", vbExclamation, "Seguridad")
                txtNuevaContraseña.Focus()
            Else
                If Fun_Administrador.Modificar_Contraseña(txtNuevaContraseña.Text) = True Then 'Si es true quiere decir que se guardo correctamente la contraseña
                    MsgBox("Contraseña modificada correctamente.", vbExclamation, "Seguridad")
                    Me.Close()
                Else
                    MsgBox("La contraseña no se pudo modificada.", vbExclamation, "Seguridad")
                End If
            End If
        Else
            txtContraseña.Focus()
            txtContraseña.BackColor = Color.MistyRose
            erValidarError.SetError(txtContraseña, "La contraseña es incorrecta.")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'VALIDAD ERRORES
    '-----------------------------------------------------------------------------------------------------
    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        erValidarError.SetError(txtContraseña, Nothing)
        txtContraseña.BackColor = Color.White
    End Sub

    Private Sub txtNuevaContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtNuevaContraseña.TextChanged
        erValidarError.SetError(txtNuevaContraseña, Nothing)
        txtRNuevaContraseña.BackColor = Color.White
    End Sub

    Private Sub txtRNuevaContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtRNuevaContraseña.TextChanged
        erValidarError.SetError(txtRNuevaContraseña, Nothing)
        txtNuevaContraseña.BackColor = Color.White
    End Sub

    'validating
    Private Sub txtContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        If txtContraseña.TextLength = 0 Then
            erValidarError.SetError(txtContraseña, "Por favor escriba su contraseña")
            txtContraseña.BackColor = Color.MistyRose
        Else
            txtContraseña.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNuevaContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNuevaContraseña.Validating
        If txtNuevaContraseña.TextLength = 0 Then
            erValidarError.SetError(txtNuevaContraseña, "Por favor escriba la nueva contraseña")
            txtNuevaContraseña.BackColor = Color.MistyRose
        ElseIf txtNuevaContraseña.TextLength < 6 Then
            txtNuevaContraseña.Focus()
            erValidarError.SetError(txtNuevaContraseña, "La contraseña debe contener al menos 6 caracteres.")
            txtNuevaContraseña.BackColor = Color.MistyRose
        Else
            txtNuevaContraseña.BackColor = Color.White
        End If
    End Sub

    Private Sub txtRNuevaContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRNuevaContraseña.Validating
        If txtRNuevaContraseña.TextLength = 0 Then
            erValidarError.SetError(txtRNuevaContraseña, "Por favor escriba la confirmación de la contraseña")
            txtRNuevaContraseña.BackColor = Color.MistyRose
        Else
            txtRNuevaContraseña.BackColor = Color.White
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------
End Class