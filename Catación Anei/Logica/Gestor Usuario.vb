Imports System.Data.SqlClient
Public Class Gestor_Usuario
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Usuario(codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO USUARIO (codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                               codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("UNIQUE KEY") = True Then
                MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            Else
                MsgBox(ex.Message)
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar_Usuario(codigo, nombre_usuario, contrasenia, permiso) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "UPDATE USUARIO SET nombre_usuario = '" & nombre_usuario & "', contrasenia = '" & contrasenia & "', permiso = '" & permiso &
                                "' WHERE codigo = '" & codigo & "'"
            Comando = New SqlCommand(sql, db.Conexion)
            i = Comando.ExecuteNonQuery()
            db.Conexion.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
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

    Public Function Tipo_Usuario(NombreUsuario) As String
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT tipo_usuario FROM USUARIO WHERE nombre_usuario = '" & NombreUsuario & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        Return Datos(0)("tipo_usuario") 'Devuelve el tipo de usuario con el nombre de usuario
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

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Verificar_Administrador() As DataTable 'Devuelve el registro del administrador
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM USUARIO WHERE tipo_usuario = 'Administrador'", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function
End Class
