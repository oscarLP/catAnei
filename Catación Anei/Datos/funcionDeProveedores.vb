Imports System.Data.SqlClient
Public Class funcionDeProveedores
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Proveedores(ByVal proveedor As Proveedor) As String
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO PROVEEDOR VALUES('" & proveedor.codigo & "','" & proveedor.vereda & "','" & proveedor.finca & "','" & proveedor.fk_codigo_ciudad & "','" & proveedor.fk_codigo_persona & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("codigo") = True Then
                Return MsgBox("No se pudo guardar el registro, por favor intente de nuevo.", vbExclamation, "Seguridad - Proveedores")
            Else
                Return MsgBox(ex.Message, vbCritical, "Seguridad - Proveedores")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return "True"
        Else
            Return "False"
        End If
    End Function
End Class
