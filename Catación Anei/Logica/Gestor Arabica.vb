Imports System.Data.SqlClient
Public Class Gestor_Arabica
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Arabica(codigo, fk_codigo_muestra) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO ARABICA (codigo, fk_codigo_muestra) VALUES('{0}','{1}')",
                                               codigo, fk_codigo_muestra)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("PRIMARY KEY") = True Then
                MsgBox("Error al guardar, intente de nuevo.", vbExclamation, "Seguridad - Muestra")
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Muestra")
            End If
            db.Conexion.Close()
        End Try
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
