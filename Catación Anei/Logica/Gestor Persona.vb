Public Class Gestor_Persona
    Private persona As Personas

    Public Function Guardar_Persona(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) As String
        Dim resp_guardar As String

        'para  codigo
        If (String.IsNullOrEmpty(codigo)) Then
            resp_guardar = "No se ha recibido un codigo de persona."
            Return resp_guardar
        End If

        'Para cedula
        If (String.IsNullOrEmpty(cedula)) Then
            resp_guardar = "No se ha recibido una cedula de persona."
            Return resp_guardar
        End If

        'Para nombre
        If (String.IsNullOrEmpty(nombre)) Then
            resp_guardar = "No se ha recibido un nombre de persona."
            Return resp_guardar
        End If

        'Para apellido
        If (String.IsNullOrEmpty(apellido)) Then
            resp_guardar = "No se ha recibido un apellido de persona."
            Return resp_guardar
        End If

        'Para tipo de persona
        If (String.IsNullOrEmpty(tipo_persona)) Then
            resp_guardar = "No se ha recibido un tipo de persona."
            Return resp_guardar
        End If

        If (tipo_persona <> "Usuario" Or tipo_persona <> "Productor" Or tipo_persona <> "Proveedor") Then
            resp_guardar = "El tipo de persona a registrar no es válido."
            Return resp_guardar
        End If

        'Si no ha retornado nada hasta éste punto entonces procedemos a insertar 
        resp_guardar = persona.insert(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona)
        Return resp_guardar

    End Function

    Public Function Modificar_Persona(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) As String
        Dim resp_guardar As String

        'para  codigo
        If (String.IsNullOrEmpty(codigo)) Then
            resp_guardar = "No se ha recibido un codigo de persona."
            Return resp_guardar
        End If

        'Para cedula
        If (String.IsNullOrEmpty(cedula)) Then
            resp_guardar = "No se ha recibido una cedula de persona."
            Return resp_guardar
        End If

        'Para nombre
        If (String.IsNullOrEmpty(nombre)) Then
            resp_guardar = "No se ha recibido un nombre de persona."
            Return resp_guardar
        End If

        'Para apellido
        If (String.IsNullOrEmpty(apellido)) Then
            resp_guardar = "No se ha recibido un apellido de persona."
            Return resp_guardar
        End If

        'Para tipo de persona
        If (String.IsNullOrEmpty(tipo_persona)) Then
            resp_guardar = "No se ha recibido un tipo de persona."
            Return resp_guardar
        End If

        If (tipo_persona <> "Usuario" Or tipo_persona <> "Productor" Or tipo_persona <> "Proveedor") Then
            resp_guardar = "El tipo de persona a modificar no es válido."
            Return resp_guardar
        End If

        'Si no ha retornado nada hasta éste punto entonces procedemos a actualizar
        resp_guardar = persona.update(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona)
        Return resp_guardar

    End Function

    Public Function Eliminar_Persona(codigo) As String

        If (String.IsNullOrEmpty(codigo)) Then
            Return "No se ha recibido codigo de persona a eliminar"
        End If

        Return persona.delete(codigo)
    End Function

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function
End Class
