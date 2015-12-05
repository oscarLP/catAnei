Imports System.Data.SqlClient
Public Class Gestor_Persona
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
            If Err.Description.Contains("UNIQUE KEY") = True Then
                MsgBox("Esta cedula ya se encuentra registrada.", vbExclamation, "Seguridad - Persona")
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Persona")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

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

    Public Function Eliminar_Persona(codigo) As Boolean
        db.Conexion.Open()
        Dim sql As String = "DELETE FROM PERSONA WHERE codigo = '" & codigo & "'"
        Comando = New SqlCommand(sql, db.Conexion)
        Dim i As Integer = Comando.ExecuteNonQuery
        db.Conexion.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function
End Class
