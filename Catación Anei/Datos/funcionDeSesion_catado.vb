Imports System.Data.SqlClient
Public Class funcionDeSesion_catado
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_SesionCatacion(ByVal sesion_catado As Sesion_catado) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO SESION_CATADO VALUES('" _
                                               & sesion_catado.codigo & "','" & sesion_catado.fecha_inicio & "','" & sesion_catado.hora_inicio & "','" & sesion_catado.descripcion & "','" & sesion_catado.fk_codigo_ciudad & "','" _
                                               & sesion_catado.estructura_identificador & "','" & sesion_catado.protocolo & "','" & sesion_catado.numero_muestras & "','" & sesion_catado.fk_codigo_usuario & "','" & sesion_catado.estado & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
