Imports System.Data.SqlClient
Public Class Gestor_Muestras
    Private db As New Conexion_BD
    Private Comando As SqlCommand


    'INSERTA UNA MUESTRA EN LA BASE DE DATOS
    Public Function guardar_muestra(ByVal NumeroMuestras As String, ByVal EstructuraIdentificador As String, ByVal CodigoSesion As String,
                                    ByVal CodigoCiudad As String) As Boolean

        Dim i As Integer
        Dim indexValores As Integer
        Dim codigos As New ArrayList
        Dim valores As New ArrayList
        Dim ValorIdentificado As String

        'GENERAMOS UN ARRAYLIST QUE CONTENGA LOS CODIGOS PARA LAS MUESTRAS
        codigos = generar_codigos(NumeroMuestras)
        'GENERAMOS UN ARRAYLIST DE VALORES PARA CADA MUESTRA
        valores = Valor(NumeroMuestras, EstructuraIdentificador)

        indexValores = 0


        For Each Codigo As String In codigos
            'Para obtener un item del arraylist
            ValorIdentificado = valores(indexValores)

            Try
                Dim _sql As String = String.Format("INSERT INTO MUESTRA (fk_codigo_sesion, codigo, valor_identificado, fk_codigo_ciudad) VALUES('{0}','{1}','{2}','{3}')",
                                                  CodigoSesion, Codigo, ValorIdentificado, CodigoCiudad)

                Using cmd As New SqlCommand(_sql, db.Conexion)
                    db.Conexion.Open()
                    i = cmd.ExecuteNonQuery
                    db.Conexion.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                db.Conexion.Close()
                Return False
                Exit For
            End Try

            'AUMENTAMOS EL INDICE PARA LOS VALORES, EL INDICE DE LOS CODIGOS VA IMPLICITO EL EL FOR EACH
            indexValores += 1
        Next


        Return True
    End Function

    'GENERA LA LISTA DE CODIGOS DE LAS MUESTRAS
    Public Function generar_codigos(ByVal cantidad As String) As ArrayList
        Dim lista As New ArrayList
        Dim generado As String

        For index As Integer = 1 To cantidad Step +1
            Randomize() 'Inicia el generador de numeros aleatorios
            generado = CStr(Int((9999999 * Rnd() + 1))) 'La variable 'varCodigo' obtiene un numero aleatorio
            lista.Add(generado)
        Next

        Return lista
    End Function

    'GENERA UN VALOR PARA IDENTIFICAR A CADA MUESTRA DE LA SESION
    Public Function Valor(ByVal cantidad As String, ByVal Estructura As String) As ArrayList

        Dim lista As New ArrayList

        'DEBEMOS GENERAR VALORES DEPENDIENDO SI LA ESTRUCTURA ES LETRA O DIGITO

        If (Estructura = "Letra") Then

            Dim caracter As Integer = 65
            Dim letra As String

            For index As Integer = 1 To cantidad
                letra = Chr(caracter)
                lista.Add(UCase(letra)) 'QUEREMOS MAYUSCULAS
                caracter = caracter + 1
            Next

        ElseIf (Estructura = "Digito") Then

            'VALORES IRAN DESDE 1 HASTA LA CANTIDAD DE MUESTRAS
            For index As Integer = 1 To cantidad + 1
                lista.Add(index)
            Next

        Else
            MsgBox("No se ha recibido una Estructura de muestras válido(Letra,Digito).", vbCritical, "Error")
        End If

        Return lista

    End Function
    'BUSCA UNA COINCIDENCIA ENTRE LOS VALORES DE MUESTRAS DE UNA SESION
    Public Function buscar_codigo_valor(ByVal CodigoMuestra2 As String, ByVal Respuesta As String) As String
        Dim respuesta_cod As String
        Dim Datos As New BindingSource

        Try
            Dim Tabla As New DataTable
            Dim da As New SqlDataAdapter("SELECT codigo FROM MUESTRA WHERE codigo = '" & CodigoMuestra2 & "' AND valor_identificado= '" & Respuesta & "'", db.Conexion)
            da.Fill(Tabla)
            Datos.DataSource = Tabla
            respuesta_cod = Datos.Item(0)("codigo")
        Catch ex As Exception
            'OJO QUE AQUI DEBERIAMOS MANEJAR EL ROLLBACK
            MsgBox(ex.Message)
            db.Conexion.Close()
        End Try

        Return respuesta_cod

    End Function

End Class
