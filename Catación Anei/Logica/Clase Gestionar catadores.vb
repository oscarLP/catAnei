Imports System.Data.SqlClient
Public Class Clase_Gestionar_catadores
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
            If Err.Description.Contains("NombreUsuario") = True Then
                MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            ElseIf Err.Description.Contains("Cedula") = True Then
                MsgBox("Esta cedula ya se encuentra registrada.", vbExclamation, "Seguridad")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar_Catador(ByVal Codigo As String, ByVal NombreUsuario As String, ByVal Contraseña As String, ByVal Cedula As String, ByVal Nombre As String,
                                  ByVal Apellidos As String, ByVal Telefono As String, ByVal CorreoElectronico As String, ByVal Direccion As String) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "Update Usuario Set NombreUsuario = '" & NombreUsuario & "', Cedula = '" & Cedula & "', Nombre = '" & Nombre & "', Apellidos = '" & Apellidos &
                "', Telefono = '" & Telefono & "', CorreoElectronico = '" & CorreoElectronico & "', Direccion = '" & Direccion & "' Where Codigo = '" & Codigo & "'"
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

    Public Function Lista_Catadores() As DataTable 'Devuelve una tabla con todos los registros de los catadores para agregarlo a la tabla
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT NombreUsuario 'Usuario', Cedula, Nombre, Apellidos, Telefono 'Teléfono', " +
                                     "CorreoElectronico 'Correo', Direccion FROM Usuario ORDER BY NombreUsuario", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Buscar_Catadores() As DataTable 'Devuelve un registro de un catador para luego ser reflejado en la parte 'Gestion de catadores'
        Dim Tabla As New DataTable
        Dim da As New SqlDataAdapter("SELECT * FROM Usuario", db.Conexion)
        da.Fill(Tabla)
        Return Tabla
    End Function

    Public Function Codigo() As String 'Generar un codigo al azar para luego guardarlo en guardar
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Total_Registrados() As Integer 'Generar un codigo al azar para luego guardarlo en guardar
        Dim varTotal As Integer
        Dim Datos As New BindingSource
        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT count(*) 'Total_Registrados' FROM Usuario", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        varTotal = Datos.Item(0)("Total_Registrados")
        Return varTotal
    End Function
End Class
