Imports System.Data.SqlClient
Public Class Gestor_Guardar
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Persona(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO PERSONA (codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                               codigo, cedula, nombre, apellido, telefono, correo, tipo_persona)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("cedula") = True Then
                MsgBox("Esta cedula ya se encuentra registrada.", vbExclamation, "Seguridad")
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Guardar_Usuario(codigo, nombre_usuario, contrasenia, permiso, fk_codigo_persona) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO USUARIO (codigo, nombre_usuario, contrasenia, permiso, fk_codigo_persona) VALUES('{0}','{1}','{2}','{3}','{4}')",
                                               codigo, nombre_usuario, contrasenia, permiso, fk_codigo_persona)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("nombre_usuario") = True Then
                MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
