Imports System.Data.SqlClient
Public Class Gestor_Sesion_de_catacion
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_SesionCatacion(codigo, fecha_inicio, hora_inicio, descripcion, fk_codigo_ciudad, estructura_identificador, protocolo, numero_muestras, fk_codigo_usuario) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO SESION_CATADO (codigo, fecha_inicio, hora_inicio, descripcion, fk_codigo_ciudad, estructura_identificador," +
                                               "protocolo, numero_muestras, fk_codigo_usuario) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                               codigo, fecha_inicio, hora_inicio, descripcion, fk_codigo_ciudad, estructura_identificador, protocolo, numero_muestras, fk_codigo_usuario)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar_SesionCatacion(codigo, fecha_inicio, hora_inicio, descripcion, fk_codigo_ciudad, estructura_identificador, protocolo) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "UPDATE SESION_CATADO SET codigo = '" & codigo & "', fecha_inicio = '" & fecha_inicio & "', hora_inicio = '" & hora_inicio & "', descripcion = '" & descripcion &
                                "', fk_codigo_ciudad = '" & fk_codigo_ciudad & "', estructura_identificador = '" & estructura_identificador & "', protocolo = '" & protocolo & "' WHERE codigo = '" & codigo & "'"
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

    Public Function Eliminar_SesionCatacion(codigo) As Boolean
        db.Conexion.Open()
        Dim sql As String = "DELETE FROM SESION_CATADO WHERE codigo = '" & codigo & "'"
        Comando = New SqlCommand(sql, db.Conexion)
        Dim i As Integer = Comando.ExecuteNonQuery
        db.Conexion.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CodigoUsuario() As String 'Devuelve el codigo del usuario del catador que inicio sesion
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
            Codigo = Datos.Item(0)("codigo")
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

    Public Function Codigo_Ciudad(Nombre_Ciudad) As String 'Devuelve el codigo de la ciudad
        Dim Codigo As String
        Dim NombreUsuario As String
        Dim Datos As New BindingSource
        NombreUsuario = frmMenuPrincipal.tsNombreUsuario.Text 'Se le asigna el nombre del usuario que inicia sesion a 'NombreUsuario' para buscar su nombre
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT codigo FROM CIUDAD WHERE nombre = '" & Nombre_Ciudad & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            Codigo = Datos.Item(0)("codigo")
            db.Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try

        If Datos.Count > 0 Then
            Return Codigo
        Else
            Return MsgBox("No se pudo encontrar codigo de la Ciudad.", vbExclamation, "Seguridad")
        End If
    End Function

    Public Function Tabla_SesionCatado() As DataTable 'Devuelve una tabla con todos los registros de las sesiones de catacion para agregarlo a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT S.codigo 'cod_sesion', ROW_NUMBER() OVER(ORDER BY S.fecha_inicio DESC) AS #, S.fecha_inicio 'Fecha', S.hora_inicio 'Hora', " +
                                         "C.nombre 'Lugar', S.estructura_identificador 'Identificador', " +
                                         "S.protocolo 'Protocolo', S.numero_muestras 'Muestras', U.nombre_usuario 'Usuario' FROM SESION_CATADO S, USUARIO U, CIUDAD C " +
                                         "WHERE S.fk_codigo_usuario = U.codigo AND S.fk_codigo_ciudad = C.codigo", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Total_Registros() As Integer
        Dim varTotal As Integer
        Dim Datos As New BindingSource
        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT count(*) 'Total_Resgistros' FROM SESION_CATADO", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        varTotal = Datos.Item(0)("Total_Resgistros")
        Return varTotal
    End Function

    Public Function Lista_Ciudad() As DataTable
        Dim Tabla As New DataTable
        Try
            db.Conexion.Open()
            Dim da As New SqlDataAdapter("SELECT nombre FROM CIUDAD", db.Conexion)
            da.Fill(Tabla)
            'Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        Return Tabla 'Devuelve el codigo con el nombre de usuario
    End Function

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function
End Class
