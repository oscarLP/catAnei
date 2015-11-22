Imports System.Data.SqlClient
Public Class Clase_Sesion_de_catacion
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_SesionCatacion(ByVal Codigo As String, ByVal FechaInicio As String, ByVal HoraInicio As String,
                                    ByVal Descripcion As String, ByVal Lugar As String, ByVal IdentificadorMuestra As String,
                                    ByVal ProtocoloCatacion As String, ByVal NumeroMuestras As Integer, ByVal CodigoUsuario As String) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO Sesion_catacion (Codigo, FechaInicio, HoraInicio, Descripcion, Lugar, IdentificadorMuestra," +
                                               "ProtocoloCatacion, NumeroMuestras, CodigoUsuario) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                               Codigo, FechaInicio, HoraInicio, Descripcion, Lugar, IdentificadorMuestra, ProtocoloCatacion, NumeroMuestras, CodigoUsuario)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            'If Err.Description.Contains("NombreUsuario") = True Then
            '    MsgBox("Este nombre de usuario ya se encuentra registrado.", vbExclamation, "Seguridad")
            'ElseIf Err.Description.Contains("Cedula") = True Then
            '    MsgBox("Esta cedula ya se encuentra registrada.", vbExclamation, "Seguridad")
            'End If
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar_SesionCatacion(ByVal Codigo As String, ByVal FechaInicio As String, ByVal HoraInicio As String,
                                    ByVal Descripcion As String, ByVal Lugar As String, ByVal IdentificadorMuestra As String,
                                    ByVal ProtocoloCatacion As String) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "Update Sesion_catacion Set FechaInicio = '" & FechaInicio & "', HoraInicio = '" & HoraInicio & "', Descripcion = '" & Descripcion &
                "', Lugar = '" & Lugar & "', IdentificadorMuestra = '" & IdentificadorMuestra & "', ProtocoloCatacion = '" & ProtocoloCatacion & "' Where Codigo = '" & Codigo & "'"
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

    Public Function Codigo() As String 'Generar un codigo al azar para luego guardarlo en guardar
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Buscar_CodigoUsuario() As String 'Devuelve el codigo del usuario del catador que inicio sesion
        Dim Codigo As String
        Dim NombreUsuario As String
        Dim Datos As New BindingSource
        NombreUsuario = frmMenuPrincipal.tsNombreUsuario.Text 'Se le asigna el nombre del usuario que inicia sesion a 'NombreUsuario' para buscar su nombre
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT Codigo FROM Usuario WHERE NombreUsuario = '" & NombreUsuario & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            Codigo = Datos.Item(0)("Codigo")
            db.Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try

        If Datos.Count > 0 Then
            Return Codigo
        Else
            Return MsgBox("No se pudo encontrar el Nombre del Usuario.", vbExclamation, "Seguridad")
        End If
    End Function

    Public Function Lista_SesionCatacion() As DataTable 'Devuelve una tabla con todos los registros de las sesiones de catacion para agregarlo a la tabla
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT S.FechaInicio 'Fecha de inicio', S.HoraInicio 'Hora de inicio', S.Descripcion 'Descripción', S.Lugar, " +
                                         "S.IdentificadorMuestra 'Identificador de la muestra', S.ProtocoloCatacion 'Protocolo de catación', " +
                                         "S.NumeroMuestras 'Numero de muestras', U.NombreUsuario 'Creador de la sesión' FROM Sesion_catacion S, Usuario U WHERE S.CodigoUsuario = U.Codigo", db.Conexion)
            da.Fill(Tabla)

            db.Conexion.Close()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try

    End Function

    Public Function Total_Registros() As Integer 'Generar un codigo al azar para luego guardarlo en guardar
        Dim varTotal As Integer
        Dim Datos As New BindingSource
        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT count(*) 'codigo' FROM SESION_CATADO", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        varTotal = Datos.Item(0)("codigo")
        Return varTotal
    End Function
End Class
