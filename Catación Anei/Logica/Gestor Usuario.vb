Public Class Gestor_Usuario
    Private usuario As Usuarios
    Public Function Guardar_Usuario(codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona) As Boolean
        Dim resp_guardar As String

        'para  codigo
        If (String.IsNullOrEmpty(codigo)) Then
            resp_guardar = "No se ha recibido un codigo para usuario"
            Return resp_guardar
        End If

        'Para nombre_usuario
        If (String.IsNullOrEmpty(nombre_usuario)) Then
            resp_guardar = "No se ha recibido el nombre de usuario."
            Return resp_guardar
        End If

        'Para contrasenia
        If (String.IsNullOrEmpty(contrasenia)) Then
            resp_guardar = "No se ha recibido contraseña para usuario."
            Return resp_guardar
        End If

        'Para permiso
        If (String.IsNullOrEmpty(permiso)) Then
            resp_guardar = "No se ha recibido permiso para usuario."
            Return resp_guardar
        End If

        If (permiso <> "Si" Or permiso <> "No") Then
            resp_guardar = "Permiso de usuario no es valido"
            Return resp_guardar
        End If

        'Para tipo de usuario
        If (String.IsNullOrEmpty(tipo_usuario)) Then
            resp_guardar = "No se ha recibido el tipo de usuario"
            Return resp_guardar
        End If

        If (tipo_usuario <> "Administrador" Or tipo_usuario <> "Catador") Then
            resp_guardar = "No se ha recibido el tipo de usuario"
            Return resp_guardar
        End If

        'Para  fk codigo de persona
        If (String.IsNullOrEmpty(fk_codigo_persona)) Then
            resp_guardar = "No se ha recibido un codigo de persona de referencia"
            Return resp_guardar
        End If

        'Si no ha retornado nada hasta éste punto entonces procedemos a insertar 
        resp_guardar = usuario.insert(codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona)
        Return resp_guardar

    End Function

    Public Function Modificar_Usuario(codigo, nombre_usuario, contrasenia, permiso) As String

        'para  codigo
        If (String.IsNullOrEmpty(codigo)) Then
            Return "No se ha recibido un codigo para usuario"
        End If

        'Para nombre_usuario
        If (String.IsNullOrEmpty(nombre_usuario)) Then
            Return "No se ha recibido el nombre de usuario."
        End If

        'Para contrasenia
        If (String.IsNullOrEmpty(contrasenia)) Then
            Return "No se ha recibido contraseña para usuario."
        End If

        'Para permiso
        If (String.IsNullOrEmpty(permiso)) Then
            Return "No se ha recibido permiso para usuario."
        End If

        If (permiso <> "Si" Or permiso <> "No") Then
            Return "Permiso de usuario no es valido"
        End If

        'Si ha saltado los anteriores
        Return usuario.update(codigo, nombre_usuario, contrasenia, permiso)

    End Function

    Public Function IniciarSesion(NombreUsuario, Contraseña) As String
        'Para nombre_usuario
        If (String.IsNullOrEmpty(NombreUsuario)) Then
            Return "No se ha recibido nombre de usuario en la consulta."
        End If

        'Para contrasenia
        If (String.IsNullOrEmpty(Contraseña)) Then
            Return "No se ha recibido contraseña en la consulta."
        End If

        Return usuario.login(NombreUsuario, Contraseña)

    End Function

    Public Function Tipo_Usuario(NombreUsuario) As String
        Return usuario.select_tipo(NombreUsuario)
    End Function

    Public Function Permiso(NombreUsuario) As String 'Esta funcion verifica si el usuario tiene permiso para entrar al sistema

        If (String.IsNullOrEmpty(NombreUsuario)) Then
            Return "No se ha recibido nombre de usuario para select permiso."
        End If

        Return usuario.select_permiso(NombreUsuario)
    End Function

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Verificar_Administrador() As DataTable 'Devuelve el registro del administrador
        Return usuario.select_administrador  '<==== El error está al retornar, pero el codigo está bien, sólo que parece que no admite un retorno de éste tipo
    End Function
End Class
