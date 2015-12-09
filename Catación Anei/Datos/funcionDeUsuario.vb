Imports System.Data.SqlClient
Public Class funcionDeUsuario
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Usuario(ByVal usuario As Usuario) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO USUARIO VALUES('" & usuario.codigo & "','" & usuario.nombre_usuario & "','" & usuario.contrasenia & "','" & usuario.permiso & "','" & usuario.tipo_usuario & "','" & usuario.fk_codigo_persona & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("UNIQUE KEY") = True Then
                MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
                db.Conexion.Close()
                Return False
            Else
                MsgBox(ex.Message)
                db.Conexion.Close()
                Return False
            End If
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
