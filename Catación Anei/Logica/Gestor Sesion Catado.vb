Imports System.Data.SqlClient
Public Class Gestor_Sesion_Catado
    Private fun_muestra As New Gestor_Muestras

    Private db As New Conexion_BD
    Private Comando As SqlCommand


    'Devuelve una tabla con todos los registros de las sesiones de catacion para agregarlo a la tabla
    Public Function Tabla_sesiones() As DataTable

        Dim Tabla As New DataTable

        Try
            Dim da As New SqlDataAdapter("SELECT S.fecha_inicio 'Fecha de inicio', S.hora_inicio 'Hora de inicio', S.descripcion 'Descripción', S.lugar, " +
                                         "S.estructura_identificador 'Identificador de muestra', S.protocolo 'Protocolo de catación', " +
                                         "S.numero_muestras 'Numero de muestras', U.nombre_usuario 'Creador de la sesión' FROM SESION_CATADO S, USUARIO U WHERE S.fk_codigo_usuario = U.codigo", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try

        Return Tabla

    End Function
    Public Function Guardar_SesionCatacion(ByVal Codigo As String, ByVal FechaInicio As String, ByVal HoraInicio As String,
                                    ByVal Descripcion As String, ByVal Lugar As String, ByVal EstructuraIdentificador As String,
                                    ByVal ProtocoloCatacion As String, ByVal NumeroMuestras As Integer, ByVal CodigoUsuario As String) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO SESION_CATADO (codigo, fecha_inicio, hora_inicio, descripcion, lugar, estructura_identificador," +
                                               "protocolo, numero_muestras, fk_codigo_Usuario) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                               Codigo, FechaInicio, HoraInicio, Descripcion, Lugar, EstructuraIdentificador, ProtocoloCatacion, NumeroMuestras, CodigoUsuario)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            'DEBEMOS AGREGAR LA EXCEPCION DE ROLLBACK
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try

        'SI DEVUELVE MAYOR A 0 ENTONCES HA SIDO INSERTADA LA SESION

        If i > 0 Then
            'PROCEDEMOS A INSERT CADA MUESTRA QUE CORRESPONDE A LA SESION
            Dim guardado_muestra As Boolean

            guardado_muestra = fun_muestra.guardar_muestra(NumeroMuestras, EstructuraIdentificador, Codigo, Lugar)

            'SI TANTO SESION COMO MUESTRAS HAN SIDO REGISTRADAS DEVOLVEMOS TRUE
            If guardado_muestra = True Then
                Return True
            Else
                Return False
            End If

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
            Dim da As New SqlDataAdapter("SELECT codigo FROM USUARIO WHERE nombre_usuario = '" & NombreUsuario & "'", db.Conexion)
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
