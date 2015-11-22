Imports System.Data.SqlClient
Public Class Gestor_Proveedores
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Proveedores(codigo, vereda, finca, fk_codigo_ciudad, fk_codigo_persona) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO PROVEEDOR (codigo, vereda, finca, fk_codigo_ciudad, fk_codigo_persona) VALUES('{0}','{1}','{2}','{3}','{4}')",
                                               codigo, vereda, finca, fk_codigo_ciudad, fk_codigo_persona)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("codigo") = True Then
                MsgBox("No se pudo guardar el registro, por favor intente de nuevo.", vbExclamation, "Seguridad - Proveedores")
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Modificar_Proveedor(codigo, vereda, finca, fk_codigo_ciudad, fk_codigo_persona) As Boolean
        Dim i As Integer
        Try
            db.Conexion.Open()
            Dim sql As String = "UPDATE PROVEEDOR SET vereda = '" & vereda & "', finca = '" & finca & "', fk_codigo_ciudad = '" & fk_codigo_ciudad & "', fk_codigo_persona = '" & fk_codigo_persona &
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

    Public Function Tabla_Proveedores() As DataTable 'Devuelve una tabla con todos los registros de los proveedores para agregarlos a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT P.cedula 'Cedula', P.nombre 'Nombre', P.apellido 'Apellido', P.telefono 'Teléfono', P.correo 'Correo', " +
                                         "C.nombre 'Ciudad', R.vereda 'Vereda', R.finca 'Finca' FROM PERSONA P, CIUDAD C, PROVEEDOR R " +
                                         "WHERE P.codigo = R.fk_codigo_persona AND C.codigo = R.fk_codigo_ciudad AND P.tipo_persona = 'Proveedor' ORDER BY P.cedula", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Buscar_Proveedor() As DataTable 'Devuelve una tabla con el registro que es seleccionado en la tabla y lo visualiza en la parte derecha
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT P.codigo 'cod_persona', C.codigo 'cod_ciudad', R.codigo 'cod_proveedor', P.cedula 'cedula', P.nombre 'nombre', " +
                                         "P.apellido 'apellido', P.telefono 'telefono', P.correo 'correo', C.nombre 'ciudad', " +
                                         "R.vereda 'vereda', R.finca 'finca' FROM PERSONA P, CIUDAD C, PROVEEDOR R " +
                                         "WHERE C.codigo = R.fk_codigo_ciudad AND P.codigo = R.fk_codigo_persona ORDER BY P.cedula", db.Conexion)
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
            Dim da As New SqlDataAdapter("SELECT count(*) 'Total_Registrados' FROM PROVEEDOR", db.Conexion)
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

    Public Function Codigo_Ciudad(Ciudad) As String
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT codigo FROM CIUDAD WHERE nombre = '" & Ciudad & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        Return Datos(0)("codigo") 'Devuelve el codigo con el nombre de usuario
    End Function

    Public Function Lista_Ciudad() As DataTable
        Dim Tabla As New DataTable
        Try
            db.Conexion.Open()
            Dim da As New SqlDataAdapter("SELECT nombre FROM CIUDAD", db.Conexion)
            da.Fill(Tabla)
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try

        Return Tabla 'Devuelve el codigo con el nombre de usuario
    End Function
End Class
