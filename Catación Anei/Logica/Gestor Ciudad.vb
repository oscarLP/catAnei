Imports System.Data.SqlClient
Public Class Gestor_Ciudad
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Ciudad(codigo, nombre, fk_codigo_pais) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO CIUDAD (codigo, nombre, fk_codigo_pais) VALUES('{0}','{1}','{2}')",
                                               codigo, nombre, fk_codigo_pais)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("codigo") = True Then
                MsgBox("No se pudo guardar el registro, por favor intente de nuevo.", vbExclamation, "Seguridad - Ciudad")
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Ciudad")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar_Ciudad(codigo, nombre, fk_codigo_pais) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "UPDATE CIUDAD SET nombre = '" & nombre & "', fk_codigo_pais = '" & fk_codigo_pais &
                                "' WHERE codigo = '" & codigo & "'"
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

    Public Function Eliminar_Ciudad(codigo) As Boolean
        db.Conexion.Open()
        Dim sql As String = "DELETE FROM CIUDAD WHERE codigo = '" & codigo & "'"
        Comando = New SqlCommand(sql, db.Conexion)
        Dim i As Integer = Comando.ExecuteNonQuery
        db.Conexion.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Tabla_Ciudades() As DataTable 'Devuelve una tabla con todos los registros de las ciudades para agregarlos a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT nombre 'Nombre' FROM CIUDAD", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Buscar_Ciudad() As DataTable 'Devuelve una tabla con el registro que es seleccionado en la tabla y lo visualiza en la parte derecha
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT C.codigo 'cod_ciudad', P.codigo 'cod_pais', C.nombre 'nombre' FROM CIUDAD C, PAIS P WHERE P.codigo = C.fk_codigo_pais", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Total_Registrados() As Integer
        Dim varTotal As Integer
        Dim Datos As New BindingSource
        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT count(*) 'Total_Registrados' FROM CIUDAD", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        varTotal = Datos.Item(0)("Total_Registrados")
        Return varTotal
    End Function

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Codigo_Pais(Nombre) As String
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT codigo FROM PAIS WHERE nombre = '" & Nombre & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        Return Datos(0)("codigo") 'Devuelve el codigo con el nombre de usuario
    End Function
End Class
