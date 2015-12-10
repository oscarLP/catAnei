Public Class frmIniciarSesion
    'Private Fun_Iniciar_Sesion As New Gestor_Iniciar_sesion
    Private Fun_Usuario As New Gestor_Usuario

    Private Sub frmIniciarSecion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtUsuario()
        AntesDelFocus_txtUsuario()
        'DespuesDelFocus_txtContraseña()
        'AntesDelFocus_txContraseña()
        HabDes_BotonIngresar()
        Bienvenido()
    End Sub

    Sub Bienvenido()
        Dim Verificar_Administrador As New BindingSource
        Verificar_Administrador.DataSource = Fun_Usuario.Verificar_Administrador()
        If Verificar_Administrador.Count = 0 Then 'Si 'Verificar_Administrador' es igual a 0 quiere decir que no hay un perfil como administrador
            Me.Visible = False
            frmBienvenido.ShowDialog()
        End If
    End Sub

    'BOTON INGRESAR
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Fun_Usuario.IniciarSesion(txtUsuario.Text, txtContraseña.Text) = True Then
            If Fun_Usuario.Permiso(txtUsuario.Text) = "Si" Then
                Ingresar_MenuPrincipal()
            ElseIf Fun_Usuario.Permiso(txtUsuario.Text) = "No" Then
                MsgBox("Este usuario no tiene permiso para entrar al sistema.", vbExclamation, "Seguridad")
            End If
        Else
            MsgBox("La contraseña y/o usuario no se encuentran registrados.", vbExclamation, "Seguridad")
            txtContraseña.Clear()
            txtUsuario.Focus()
        End If
    End Sub

    Sub Ingresar_MenuPrincipal() 'Condiciones para entrar al formulario Menu principal
        txtContraseña.Clear() 'Borra el campo 'Contraseña' antes de abrir el menu principal
        frmMenuPrincipal.tsNombreUsuario.Text = txtUsuario.Text 'Coloca el nombre del usuario en el formulario Menu principal

        If Fun_Usuario.Tipo_Usuario(txtUsuario.Text) = "Catador" Then 'Si el usuario es un catador entonces desabite el boton 'Gestionar catadores' y 'Cambiar contraseña'
            frmMenuPrincipal.btnGestionarCatadores.Enabled = False
            frmMenuPrincipal.tsCambiarContraseña.Enabled = False
            frmMenuPrincipal.tsPerfil.Enabled = False
        ElseIf Fun_Usuario.Tipo_Usuario(txtUsuario.Text) = "Administrador" Then 'Si el usuario es un administrador entonces habilite el boton 'Gestionar catadores' y 'Cambiar contraseña'
            frmMenuPrincipal.btnGestionarCatadores.Enabled = True
            frmMenuPrincipal.tsCambiarContraseña.Enabled = True
            frmMenuPrincipal.tsPerfil.Enabled = True
        Else
            MsgBox("No tiene permiso para entrar al sistema.", vbExclamation, "Seguridad") 'En este caso es porque el usuario no es un catador ni un administrador
        End If

        Me.Visible = False
        If frmMenuPrincipal.Visible = False Then
            frmMenuPrincipal.Visible = True
        Else            
            frmMenuPrincipal.ShowDialog()
        End If
    End Sub

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

    'Evento: Al iniciar el formulario los campos tiene el efecto Placeholder
    '-------------------------------------------------------------------------------------------------------------
    Sub DespuesDelFocus_txtUsuario()
        If txtUsuario.Text = "Usuario" Then
            txtUsuario.ForeColor = Color.Black
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

    'Sub DespuesDelFocus_txtContraseña()
    '    If txtContraseña.Text = "Contraseña" Then
    '        txtContraseña.ForeColor = Color.DimGray
    '        txtContraseña.Clear()
    '    End If
    'End Sub

    'Private Sub txtContraseña_GotFocus(sender As Object, e As EventArgs) Handles txtContraseña.GotFocus
    '    DespuesDelFocus_txtContraseña()
    'End Sub

    'Sub AntesDelFocus_txContraseña()
    '    If txtContraseña.Text = Nothing Then
    '        txtContraseña.ForeColor = Color.Silver
    '        txtContraseña.Text = "Contraseña"
    '    End If
    'End Sub

    'Private Sub txtContraseña_LostFocus(sender As Object, e As EventArgs) Handles txtContraseña.LostFocus
    '    AntesDelFocus_txContraseña()
    'End Sub
    '-------------------------------------------------------------------------------------------------------------
End Class
