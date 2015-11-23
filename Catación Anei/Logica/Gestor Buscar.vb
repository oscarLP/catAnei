Imports System.Data.SqlClient
Public Class Gestor_Buscar
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Tabla_Catadores() As DataTable 'Devuelve una tabla con todos los registros de los catadores para agregarlo a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT U.nombre_usuario 'Usuario', P.cedula 'Cedula', P.nombre 'Nombre', P.apellido 'Apellido', P.telefono 'Teléfono', " +
                                         "P.correo 'Correo', U.permiso 'Permiso' FROM USUARIO U, PERSONA P WHERE P.codigo = U.fk_codigo_persona ORDER BY nombre_usuario", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Buscar_Catador() As DataTable 'Devuelve una tabla con todos los registros de los catadores para agregarlo a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT U.codigo 'cod_usuario', P.codigo 'cod_permiso', U.nombre_usuario 'nombre_usuario', U.contrasenia 'contraseña', U.permiso 'permiso', P.cedula 'cedula', P.nombre 'nombre', P.apellido 'apellido', P.telefono 'telefono', " +
                                         "P.correo 'correo', U.permiso 'permiso' FROM USUARIO U, PERSONA P WHERE P.codigo = U.fk_codigo_persona ORDER BY nombre_usuario", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Total_Registrados() As Integer
        Dim varTotal As Integer
        Dim Datos As New BindingSource
        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT count(*) 'Total_Registrados' FROM Usuario", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        varTotal = Datos.Item(0)("Total_Registrados")
        Return varTotal
    End Function

    Public Function IniciarSesion(NombreUsuario, Contraseña) As Boolean
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT nombre_usuario, contrasenia FROM USUARIO WHERE nombre_usuario = '" & NombreUsuario & "' AND contrasenia = '" & Contraseña & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        If Datos.Count = 0 Then 'Si 'Datos' es igual a 0 quiere decir que no este usuario no se encuentra registrado 
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Usuario(NombreUsuario) As String
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT tipo_persona FROM PERSONA WHERE codigo = (SELECT fk_codigo_persona FROM USUARIO WHERE nombre_usuario = '" & NombreUsuario & "')", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try
        Return Datos.Item(0)("tipo_persona")
    End Function

    Public Function Permiso(NombreUsuario) As String 'Esta funcion verifica si el usuario tiene permiso para entrar al sistema
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT permiso FROM USUARIO WHERE nombre_usuario = '" & NombreUsuario & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try
        Return Datos.Item(0)("permiso")

    End Function
End Class
