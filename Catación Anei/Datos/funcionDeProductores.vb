Imports System.Data.SqlClient
Public Class funcionDeProductores
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Productores(ByVal productor As Productor) As String
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO PRODUCTOR VALUES('" & productor.codigo & "','" & productor.vereda & "','" & productor.finca & "','" & productor.fk_codigo_ciudad & "','" & productor.fk_codigo_persona & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("codigo") = True Then
                Return MsgBox("No se pudo guardar el registro, por favor intente de nuevo.", vbExclamation, "Seguridad - Productores")
            Else
                Return MsgBox(ex.Message, vbCritical, "Seguridad - Productores")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return "True"
        Else
            Return "True"
        End If
    End Function
End Class
