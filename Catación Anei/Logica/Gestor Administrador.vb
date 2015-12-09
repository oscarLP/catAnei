Imports System.Data.SqlClient
Public Class Gestor_Administrador
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function ValidadContraseña(Contrasenia) As Boolean
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT contrasenia FROM USUARIO WHERE tipo_usuario = 'Administrador' AND Contrasenia ='" & Contrasenia & "'", db.Conexion)
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
            Dim sql As String = "UPDATE USUARIO SET contrasenia = '" & NuevaContraseña & "' WHERE tipo_usuario = 'Administrador'"
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

    Public Function Datos_Administrador() As DataTable 'Devuelve el registro del administrador
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT P.codigo 'cod_persona', U.codigo 'cod_usuario', U.nombre_usuario 'nombre_usuario', U.contrasenia 'contrasenia', P.cedula 'cedula', P.nombre 'nombre', " +
                                         "P.apellido 'apellido', P.telefono 'telefono', P.correo 'correo' FROM USUARIO U, PERSONA P " +
                                         "WHERE P.codigo = U.fk_codigo_persona AND U.tipo_usuario = 'Administrador'", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function
End Class
