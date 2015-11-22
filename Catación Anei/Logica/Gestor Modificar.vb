Imports System.Data.SqlClient

Public Class Gestor_Modificar
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Modificar_Persona(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "UPDATE PERSONA SET cedula = '" & cedula & "', nombre = '" & nombre & "', apellido = '" & apellido & "', telefono = '" & telefono &
                                "', correo = '" & correo & "', tipo_persona = '" & tipo_persona & "' WHERE codigo = '" & codigo & "'"
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
End Class
