Imports System.Data.SqlClient
Public Class Catador
    Private db As New Conexion_BD
    Private Comando As SqlCommand
    Public Function select_catadores() As DataTable
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT U.codigo 'cod_usuario', P.codigo 'cod_persona', U.nombre_usuario 'nombre_usuario', U.contrasenia 'contraseña', U.permiso 'permiso', P.cedula 'cedula', P.nombre 'nombre', P.apellido 'apellido', P.telefono 'telefono', " +
                                         "P.correo 'correo', U.permiso 'permiso' FROM USUARIO U, PERSONA P WHERE P.codigo = U.fk_codigo_persona ORDER BY nombre_usuario", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function select_total_registros() As Integer
        Dim varTotal As Integer
        Dim Datos As New BindingSource
        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT count(*) 'Total_Registrados' FROM USUARIO WHERE tipo_usuario = 'Catador'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        varTotal = Datos.Item(0)("Total_Registrados")
        Return varTotal
    End Function

    Public Function select_tabla_catadores() As DataTable
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT U.nombre_usuario 'Usuario', P.cedula 'Cedula', P.nombre 'Nombre', P.apellido 'Apellido', P.telefono 'Teléfono', " +
                                         "P.correo 'Correo', U.permiso 'Permiso' FROM USUARIO U, PERSONA P WHERE P.codigo = U.fk_codigo_persona AND U.tipo_usuario = 'Catador' ORDER BY nombre_usuario", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

End Class
