Imports System.Data.SqlClient
Public Class Funciones_de_Usuario
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Usuario(ByVal Codigo As String, ByVal NombreUsuario As String, ByVal Contraseña As String,
                                    ByVal Cedula As String, ByVal Nombre As String, ByVal Apellidos As String, ByVal Telefono As String,
                                    ByVal CorreoElectronico As String, ByVal Direccion As String, ByVal TipoUsuario As String) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO Usuario (Codigo, NombreUsuario, Contraseña, Cedula, Nombre, Apellidos, Telefono," +
                                               "CorreoElectronico, Direccion, TipoUsuario) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                               Codigo, NombreUsuario, Contraseña, Cedula, Nombre, Apellidos, Telefono, CorreoElectronico, Direccion, TipoUsuario)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
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

    Public Function Lista_Catadores() As DataTable
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT NombreUsuario 'Usuario', Cedula, Nombre, Apellidos, Telefono 'Teléfono', " +
                                     "CorreoElectronico 'Correo', Direccion FROM Usuario ORDER BY NombreUsuario", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Buscar_Catadores() As DataTable
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT * FROM Usuario", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Consulta_CatadoresPorCodigo(Cod) As DataTable
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT Codigo FROM Usuario WHERE Codigo = '" & Cod & "'", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Consulta_CatadoresPorNombreUsuario(Usuario) As DataTable
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT NombreUsuario FROM Usuario WHERE NombreUsuario = '" & Usuario & "'", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Consulta_CatadoresPorCedula(Ced) As DataTable
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT Cedula FROM Usuario WHERE Cedula = '" & Ced & "'", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Modificar_Catador(ByVal Codigo As String, ByVal NombreUsuario As String, ByVal Contraseña As String, ByVal Cedula As String, ByVal Nombre As String,
                                      ByVal Apellidos As String, ByVal Telefono As String, ByVal CorreoElectronico As String, ByVal Direccion As String) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "Update Usuario Set NombreUsuario = '" & NombreUsuario & "', Cedula = '" & Cedula & "', Nombre = '" & Nombre & "', Apellidos = '" & Apellidos &
                "', Telefono = '" & Telefono & "', CorreoElectronico = '" & CorreoElectronico & "' Where Codigo = '" & Codigo & "'"
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

    Public Function Eliminar_Catador(ByVal Codigo As String) As Boolean
        db.Conexion.Open()
        Dim sql As String = "Delete From Usuario Where Codigo = '" & Codigo & "'"
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
