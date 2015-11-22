Imports System.Data.SqlClient
Public Class Clase_Catacion_Arabica
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_CatacionArabica(ByVal Codigo As String, ByVal CodigoSesionCatacion As String, ByVal Identificador As String) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO Catacion_Arabica (Codigo, CodigoSesionCatacion, Identificador) VALUES('{0}','{1}','{2}')",
                                               Codigo, CodigoSesionCatacion, Identificador)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Codigo() As String 'Generar un codigo al azar para luego guardarlo
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
            Dim da As New SqlDataAdapter("SELECT Codigo FROM Usuario WHERE nombre_usuario = '" & NombreUsuario & "'", db.Conexion)
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
End Class
