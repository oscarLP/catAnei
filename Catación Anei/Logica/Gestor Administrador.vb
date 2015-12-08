
Public Class Gestor_Administrador
    Private Administrador As Administrador
    Public Function ValidadContraseña(Contrasenia) As Boolean
        'Para apellido
        If (String.IsNullOrEmpty(Contrasenia)) Then
            Return False
        End If

        Return Administrador.validad_contraseña(Contrasenia)
    End Function

    Public Function Modificar_Contraseña(Contrasenia) As Boolean
        'Para apellido
        If (String.IsNullOrEmpty(Contrasenia)) Then
            Return False
        End If

        Return Administrador.update_Contraseña(Contrasenia)
    End Function

    Public Function Datos_Administrador() As DataTable 'Devuelve el registro del administrador
        Return Administrador.select_administrador
    End Function
End Class
