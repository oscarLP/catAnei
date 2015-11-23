Imports System.Data.SqlClient
Public Class Clase_Iniciar_sesion
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function IniciarSesion(NombreUsuario, Contraseña) As Boolean
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT NombreUsuario, Contraseña FROM Usuario WHERE NombreUsuario = '" & NombreUsuario & "' AND Contraseña = '" & Contraseña & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        If Datos.Count = 0 Then 'Si 'Datos' es igual a 0 quiere decir que no este usuario no se encuentra registrado 
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Usuario(NombreUsuario) As String
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT TipoUsuario FROM Usuario WHERE NombreUsuario = '" & NombreUsuario & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        If Datos(0)("TipoUsuario") = "Administrador" Then
            Return "Administrador"
        Else
            Return "Catador"
        End If
    End Function
End Class
