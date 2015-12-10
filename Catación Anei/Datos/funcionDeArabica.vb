Imports System.Data.SqlClient
Public Class funcionDeArabica
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Arabica(ByVal Arabica As Arabica) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO ARABICA VALUES('" _
                                               & Arabica.codigo & "','" & Arabica.fk_codigo_muestra & "','" & Arabica.calificacion.ToString & "','" & Arabica.puntaje_acidez.ToString & "','" & Arabica.puntaje_cuerpo.ToString & "','" _
                                               & Arabica.puntaje_dulzor.ToString & "','" & Arabica.dulzor1 & "','" & Arabica.dulzor2 & "','" & Arabica.dulzor3 & "','" _
                                               & Arabica.dulzor4 & "','" & Arabica.dulzor5 & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("PRIMARY KEY") = True Then
                MsgBox("Error al guardar, intente de nuevo.", vbExclamation, "Seguridad - Arabica")
                db.Conexion.Close()
                Return False
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Arabica")
                db.Conexion.Close()
                Return False
            End If

        End Try
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Atributos_Arabica(ByVal Codigo_Muestra As String) As Arabica 'Devuelve una tabla el registro de la muestra seleccionada
        Dim catacion As New Arabica
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM ARABICA WHERE fk_codigo_muestra = '" & Codigo_Muestra & "'", db.Conexion)
            da.Fill(Tabla)

            catacion.codigo = Tabla.Rows.Item(0).Item(0)
            catacion.fk_codigo_muestra = Tabla.Rows.Item(0).Item(1)
            catacion.calificacion = Tabla.Rows.Item(0).Item(2)
            catacion.puntaje_acidez = Tabla.Rows.Item(0).Item(3)
            catacion.puntaje_cuerpo = Tabla.Rows.Item(0).Item(4)
            catacion.puntaje_dulzor = Tabla.Rows.Item(0).Item(5)
            catacion.dulzor1 = Tabla.Rows.Item(0).Item(6)
            catacion.dulzor2 = Tabla.Rows.Item(0).Item(7)
            catacion.dulzor3 = Tabla.Rows.Item(0).Item(8)
            catacion.dulzor4 = Tabla.Rows.Item(0).Item(9)
            catacion.dulzor5 = Tabla.Rows.Item(0).Item(10)
            Return catacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return catacion
    End Function
End Class
