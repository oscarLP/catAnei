Imports System.Data.SqlClient
Public Class funcionDePersona
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Persona(ByVal persona As Persona) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO PERSONA VALUES('" & persona.codigo & "','" & persona.cedula & "','" & persona.nombre & "','" & persona.apellido & "','" & persona.telefono & "','" & persona.correo & "','" & persona.tipo_persona & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("UNIQUE KEY") = True Then
                MsgBox("Esta cedula ya se encuentra registrada.", vbExclamation, "Seguridad - Persona")
                db.Conexion.Close()
                Return False
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Persona")
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
