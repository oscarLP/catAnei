Imports System.Data.SqlClient
Public Class Usuarios
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function insert(codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona) As String
        Dim i As Integer
        Dim transac As SqlTransaction

        db.Conexion.Open()
        transac = db.Conexion.BeginTransaction("TrasanctionUsuario")

        Try
            Dim _sql As String = String.Format("INSERT INTO USUARIO (codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                               codigo, nombre_usuario, contrasenia, permiso, tipo_usuario, fk_codigo_persona)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                transac.Commit()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("UNIQUE KEY") = True Then
                transac.Rollback()
                db.Conexion.Close()
                Return "Nombre de usuario ya se encuentra registrado"
                'MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            Else
                transac.Rollback()
                db.Conexion.Close()
                Return ex.Message
            End If
        End Try

        If i > 0 Then
            db.Conexion.Close()
            Return ""
        Else
            transac.Rollback()
            db.Conexion.Close()
            Return "fail"
        End If
    End Function

    Public Function update(codigo, nombre_usuario, contrasenia, permiso) As String
        Dim i As Integer
        Dim transac As SqlTransaction

        db.Conexion.Open()
        transac = db.Conexion.BeginTransaction("TrasanctionUsuario")

        Try
            Dim sql As String = "UPDATE USUARIO SET nombre_usuario = '" & nombre_usuario & "', contrasenia = '" & contrasenia & "', permiso = '" & permiso &
                                "' WHERE codigo = '" & codigo & "'"
            Comando = New SqlCommand(sql, db.Conexion)
            i = Comando.ExecuteNonQuery()
        Catch ex As Exception
            If Err.Description.Contains("UNIQUE KEY") = True Then
                transac.Rollback()
                db.Conexion.Close()
                Return "Nombre de usuario ya se encuentra registrado"
                'MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            Else
                transac.Rollback()
                db.Conexion.Close()
                Return ex.Message
            End If
        End Try

        If i > 0 Then
            db.Conexion.Close()
            Return ""
        Else
            transac.Rollback()
            db.Conexion.Close()
            Return "fail"
        End If
    End Function

    Public Function login(NombreUsuario, Contraseña) As String
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT nombre_usuario, contrasenia FROM USUARIO WHERE nombre_usuario = '" & NombreUsuario & "' AND contrasenia = '" & Contraseña & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            Return ex.Message
            db.Conexion.Close()
        End Try

        If Datos.Count = 0 Then 'Si 'Datos' es igual a 0 quiere decir que este usuario no se encuentra registrado 
            Return "no halla"
        Else
            Return ""
        End If
    End Function

    Public Function select_tipo(NombreUsuario) As String
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

    Public Function select_administrador() As DataTable
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM USUARIO WHERE tipo_usuario = 'Administrador'", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function select_permiso(NombreUsuario) As String
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
