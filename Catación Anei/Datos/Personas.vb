Imports System.Data.SqlClient
Public Class Personas
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function insert(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) As String
        Dim i As Integer
        Dim transac As SqlTransaction

        db.Conexion.Open()
        transac = db.Conexion.BeginTransaction("TrasanctionPersona")
        Try
            Dim _sql As String = String.Format("INSERT INTO PERSONA (codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')",
                                               codigo, cedula, nombre, apellido, telefono, correo, tipo_persona)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                i = cmd.ExecuteNonQuery
                transac.Commit()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("UNIQUE KEY") = True Then
                transac.Rollback()
                db.Conexion.Close()
                Return "La cedula ya se encuentra registrada."
                'MsgBox("Esta cedula ya se encuentra registrada.", vbExclamation, "Seguridad - Persona")
            Else
                transac.Rollback()
                db.Conexion.Close()
                Return ex.Message
                'MsgBox(ex.Message, vbCritical, "Seguridad - Persona")
            End If
            db.Conexion.Close()
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

    Public Function delete(codigo) As String
        Dim i As Integer
        Dim transac As SqlTransaction

        db.Conexion.Open()
        transac = db.Conexion.BeginTransaction("TrasanctionPersona")
        Try
            Dim sql As String = "DELETE FROM PERSONA WHERE codigo = '" & codigo & "'"
            Comando = New SqlCommand(sql, db.Conexion)
            i = Comando.ExecuteNonQuery
        Catch ex As Exception
            If Err.Description.Contains("REFERENCE") = True Then
                transac.Rollback()
                db.Conexion.Close()
                Return "No se puede elimar este catador ya que tiene sesiones registradas."
                'MsgBox("No se puede elimar este catador ya que tiene sesiones registradas.", vbExclamation, "Seguridad - Persona")
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

    Public Function update(codigo, cedula, nombre, apellido, telefono, correo, tipo_persona) As String
        Dim i As Integer
        Dim transac As SqlTransaction

        db.Conexion.Open()
        transac = db.Conexion.BeginTransaction("TrasanctionPersona")
        Try
            Dim sql As String = "UPDATE PERSONA SET cedula = '" & cedula & "', nombre = '" & nombre & "', apellido = '" & apellido & "', telefono = '" & telefono &
                                "', correo = '" & correo & "', tipo_persona = '" & tipo_persona & "' WHERE codigo = '" & codigo & "'"
            Comando = New SqlCommand(sql, db.Conexion)
            i = Comando.ExecuteNonQuery()

        Catch ex As Exception
            transac.Rollback()
            db.Conexion.Close()
            Return ex.Message
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

End Class
