Imports System.Data.SqlClient
Public Class Clase_Cambiar_contraseña
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function ValidadContraseña(Contraseña) As Boolean
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT Contraseña FROM Usuario WHERE TipoUsuario = 'Administrador' AND Contraseña ='" & Contraseña & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        If Datos.Count = 0 Then 'Si 'Datos' es igual a 0 quiere decir que la contraseña es incorrecta
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Modificar_Contraseña(NuevaContraseña) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "UPDATE Usuario SET Contraseña = '" & NuevaContraseña & "' WHERE TipoUsuario = 'Administrador'"
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
