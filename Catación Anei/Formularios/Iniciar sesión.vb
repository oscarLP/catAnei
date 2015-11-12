Public Class frmIniciarSecion
    Private Sub frmIniciarSecion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtUsuario()
        AntesDelFocus_txtUsuario()
        DespuesDelFocus_txtContraseña()
        AntesDelFocus_txContraseña()
        HabDes_BotonIngresar()
    End Sub

    Sub Ingresar_MenuPrincipal() 'Condiciones para entrar al formulario Menu principal
        Me.Visible = False
        If frmMenuPrincipal.Visible = False Then
            frmMenuPrincipal.Visible = True
        Else
            frmMenuPrincipal.ShowDialog()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "1" Then
            MsgBox("La contraseña y/o usuario no se encuentran registrados.", vbExclamation, "Seguridad")
        End If
        Ingresar_MenuPrincipal()
    End Sub

    'Evento: Al iniciar el formulario los campos tiene el efecto Placeholder
    '-------------------------------------------------------------------------------------------------------------
    Sub DespuesDelFocus_txtUsuario()
        If txtUsuario.Text = "Usuario" Then
            txtUsuario.ForeColor = Color.DimGray
            txtUsuario.Clear()
        End If
    End Sub
    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        DespuesDelFocus_txtUsuario()
    End Sub

    Sub AntesDelFocus_txtUsuario()
        If txtUsuario.Text = Nothing Then
            txtUsuario.ForeColor = Color.Silver
            txtUsuario.Text = "Usuario"
        End If
    End Sub
    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        AntesDelFocus_txtUsuario()
    End Sub

    Sub DespuesDelFocus_txtContraseña()
        txtContraseña.PasswordChar = "*"
        If txtContraseña.Text = "Contraseña" Then
            txtContraseña.ForeColor = Color.DimGray
            txtContraseña.Clear()
        End If
    End Sub

    Private Sub txtContraseña_GotFocus(sender As Object, e As EventArgs) Handles txtContraseña.GotFocus
        DespuesDelFocus_txtContraseña()
    End Sub

    Sub AntesDelFocus_txContraseña()
        txtContraseña.PasswordChar = ""
        If txtContraseña.Text = Nothing Then
            txtContraseña.ForeColor = Color.Silver
            txtContraseña.Text = "Contraseña"
        End If
    End Sub

    Private Sub txtContraseña_LostFocus(sender As Object, e As EventArgs) Handles txtContraseña.LostFocus
        AntesDelFocus_txContraseña()
    End Sub
    '-------------------------------------------------------------------------------------------------------------

    'Habilitar el boton btnIngresar si hay texto en los campos
    '-------------------------------------------------------------------------------------------------------------
    Sub HabDes_BotonIngresar()
        If txtUsuario.TextLength > 0 And txtUsuario.Text <> "Usuario" Then
            btnIngresar.Enabled = True
        ElseIf txtUsuario.TextLength = 0 Or txtUsuario.Text = "Usuario" Then
            btnIngresar.Enabled = False
        End If

        If txtContraseña.TextLength > 0 And txtContraseña.Text <> "Contraseña" Then
            btnIngresar.Enabled = True
        ElseIf txtContraseña.TextLength = 0 Or txtContraseña.Text = "Contraseña" Then
            btnIngresar.Enabled = False
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        HabDes_BotonIngresar()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        HabDes_BotonIngresar()
    End Sub
    '-------------------------------------------------------------------------------------------------------------
End Class
