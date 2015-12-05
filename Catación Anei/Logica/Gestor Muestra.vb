Imports System.Data.SqlClient
Public Class Gestor_Muestra
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Identificadores(codigo, valor_identificado, fk_codigo_sesion, especie, anio_cosecha, fk_codigo_ciudad) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO MUESTRA (codigo, valor_identificado, fk_codigo_sesion, especie, anio_cosecha, fk_codigo_ciudad) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                               codigo, valor_identificado, fk_codigo_sesion, especie, anio_cosecha, fk_codigo_ciudad)
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("PRIMARY KEY") = True Then
                MsgBox("Error al guardar, intente de nuevo.", vbExclamation, "Seguridad - Muestra")
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Muestra")
            End If
            db.Conexion.Close()
        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'GENERAR UN CODIGO AL AZAR
    Public Function Codigo_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    'GENERAR EL CODIGO DE EXTRUTUCTURA DE IDENTIFICADOR
    Public Function Digitos_Azar() As String
        Dim varCodigo As String

        Randomize() 'Inicia el generador de numeros aleatorios
        varCodigo = CStr(Int((999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio

        Return varCodigo
    End Function

    Public Function Generar_Letras(Indice) As String
        Dim Abecedario(25) As String
        Dim Letra As Integer = 65
        Dim Indice_Letra(Indice) As String

        For i = 0 To 25
            Abecedario(i) = Chr(Letra)
            Letra = Letra + 1
        Next

        Dim Imprimir(Indice) As String
        Dim abc As Integer = 0 'Flujo del abecedario
        Dim aux1 As Integer = 0 'Optiene la letra que le antepone al flujo del abecedario despues que la cantidad de muestras sea mayor 26
        Dim aux2 As Integer = 0
        Dim resive As String 'Resive el 'aux1' seguido de la letra de flujo del abecedario

        For i = 0 To CInt(Indice)
            If abc = 26 Then
                aux1 = aux1 + 1
                If i = 702 Then
                    aux1 = 1
                End If
                abc = 0
            End If
            If i <= 25 Then
                Imprimir(i) = Abecedario(abc)
                abc = abc + 1
            ElseIf i >= 26 And i <= 701 Then
                resive = Abecedario(aux1 - 1)
                Imprimir(i) = resive + Abecedario(abc)
                abc = abc + 1
            ElseIf i >= 702 Then
                resive = Abecedario(aux1 - 1)
                Imprimir(i) = resive + resive + Abecedario(abc)
                abc = abc + 1
            End If
        Next
        Return Imprimir(Indice)
    End Function

    Public Function Lista_Valor_Identificado(Codigo_Sesion) As DataTable 'Devuelve la tabla de con todos los registros de los identificadores de la muestra
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT codigo, valor_identificado 'Muestras' " +
                                         "FROM MUESTRA WHERE fk_codigo_sesion = '" & Codigo_Sesion & "'", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Buscar_Muestra() As DataTable 'Devuelve una tabla el registro de la muestra seleccionada
        Dim Tabla As New DataTable
        Try
            'Dim da As New SqlDataAdapter("SELECT M.codigo 'cod_muestra', M.valor_identificado 'valor_identificado', M.nombre 'nombre_muestra', M.descripcion 'descripcion', " +
            '                             "M.especie 'especie', M.anio_cosecha 'anio_cosecha', M.humedad 'humedad', S.codigo 'cod_sesion', C.nombre 'ciudad', P.finca 'finca_productor', Q.finca 'finca_proveedor' " +
            '                             "FROM MUESTRA M, SESION_CATADO S, CIUDAD C, PRODUCTOR P, PROVEEDOR Q " +
            '                             "WHERE M.fk_codigo_sesion = S.codigo OR M.fk_codigo_ciudad = C.codigo OR M.fk_codigo_productor = P.codigo OR M.fk_codigo_proveedor = Q.codigo", db.Conexion)

            Dim da As New SqlDataAdapter("SELECT M.codigo 'cod_muestra', M.valor_identificado 'valor_identificado', M.nombre 'nombre_muestra', M.descripcion 'descripcion', " +
                                         "M.especie 'especie', M.anio_cosecha 'anio_cosecha', M.humedad 'humedad', S.codigo 'cod_sesion', C.nombre 'ciudad' " +
                                         "FROM MUESTRA M, SESION_CATADO S, CIUDAD C " +
                                         "WHERE M.fk_codigo_sesion = S.codigo AND M.fk_codigo_ciudad = C.codigo", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Protocolo_Catacion(Cod_Sesion) As String 'Esta funcion devuelve el protocolo de catacion para la sesion
        Dim Datos As New BindingSource
        Try
            db.Conexion.Open()
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT protocolo FROM MUESTRA WHERE codigo = '" & Cod_Sesion & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            db.Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Conexion.Close()
        End Try
        Return Datos.Item(0)("protocolo")
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

    Public Function Tabla_Productores() As DataTable 'Devuelve una tabla con todos los registros de los productores para agregarlos a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT cedula 'Cedula', nombre 'Nombre', apellido 'Apellido' FROM PERSONA WHERE tipo_persona = 'Productor' ORDER BY cedula", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    Public Function Tabla_Proveedores() As DataTable 'Devuelve una tabla con todos los registros de los proveedores para agregarlos a la tabla
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT cedula 'Cedula', nombre 'Nombre', apellido 'Apellido' FROM PERSONA WHERE tipo_persona = 'Proveedor' ORDER BY cedula", db.Conexion)
            da.Fill(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

    'Public Function Guardar_Muestra(codigo, valor_identificado, nombre, descripcion, especie, anio_cosecha, humedad, fk_codigo_sesion, fk_codigo_ciudad, fk_codigo_productor, fk_codigo_proveedor) As Boolean
    '    Dim i As Integer
    '    Try
    '        Dim _sql As String = String.Format("INSERT INTO MUESTRA (codigo, valor_identificado, nombre, descripcion, especie, anio_cosecha, humedad, fk_codigo_sesion, " +
    '                                           "fk_codigo_ciudad, fk_codigo_productor, fk_codigo_proveedor) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
    '                                           codigo, valor_identificado, nombre, descripcion, especie, anio_cosecha, humedad, fk_codigo_sesion, fk_codigo_ciudad, fk_codigo_productor, fk_codigo_proveedor)
    '        Using cmd As New SqlCommand(_sql, db.Conexion)
    '            db.Conexion.Open()
    '            i = cmd.ExecuteNonQuery
    '            db.Conexion.Close()
    '        End Using
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical, "Seguridad - Muestra")
    '        db.Conexion.Close()
    '    End Try
    '    If i > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
End Class
