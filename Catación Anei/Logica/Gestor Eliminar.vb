Imports System.Data.SqlClient
Public Class Gestor_Eliminar
    Private db As New Conexion_BD
    Private Comando As SqlCommand

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
End Class
