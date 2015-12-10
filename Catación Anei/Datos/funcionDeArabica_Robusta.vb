Imports System.Data.SqlClient
Public Class funcionDeArabica_Robusta
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Arabica_Robusta(ByVal Arabica_Robusta As Arabica_Robusta) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO ARABICA_ROBUSTA VALUES('" _
                                               & Arabica_Robusta.codigo & "','" & Arabica_Robusta.fk_codigo_muestra & "','" & Arabica_Robusta.nivel_tueste & "','" & Arabica_Robusta.puntaje_fragancia_aroma.ToString & "','" & Arabica_Robusta.puntuaje_sabor.ToString & "','" _
                                               & Arabica_Robusta.puntuaje_sabor_boca.ToString & "','" & Arabica_Robusta.puntuaje_balance.ToString & "','" & Arabica_Robusta.puntuaje_general.ToString & "','" & Arabica_Robusta.puntuaje_uniformidad.ToString & "','" & Arabica_Robusta.uniformidad1 & "','" _
                                               & Arabica_Robusta.uniformidad2 & "','" & Arabica_Robusta.uniformidad3 & "','" & Arabica_Robusta.uniformidad4 & "','" & Arabica_Robusta.uniformidad5 & "','" & Arabica_Robusta.puntuaje_taza_limpia & "','" _
                                               & Arabica_Robusta.taza_limpia1 & "','" & Arabica_Robusta.taza_limpia2 & "','" & Arabica_Robusta.taza_limpia3 & "','" & Arabica_Robusta.taza_limpia4 & "','" & Arabica_Robusta.taza_limpia5 & "','" _
                                               & Arabica_Robusta.numero_defectos & "','" & Arabica_Robusta.nota & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("PRIMARY KEY") = True Then
                MsgBox("Error al guardar, intente de nuevo.", vbExclamation, "Seguridad - Arabica_Robusta")
                db.Conexion.Close()
                Return False
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Arabica_Robusta")
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

    Public Function Atributos_Arabica(ByVal Codigo_Muestra As String) As Arabica_Robusta
        Dim catacion As New Arabica_Robusta
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM ARABICA_ROBUSTA WHERE fk_codigo_muestra = '" & Codigo_Muestra & "'", db.Conexion)
            da.Fill(Tabla)

            catacion.codigo = Tabla.Rows.Item(0).Item(0)
            catacion.fk_codigo_muestra = Tabla.Rows.Item(0).Item(1)
            catacion.nivel_tueste = Tabla.Rows.Item(0).Item(2)
            catacion.puntaje_fragancia_aroma = Tabla.Rows.Item(0).Item(3)
            catacion.puntuaje_sabor = Tabla.Rows.Item(0).Item(4)
            catacion.puntuaje_sabor_boca = Tabla.Rows.Item(0).Item(5)
            catacion.puntuaje_balance = Tabla.Rows.Item(0).Item(6)
            catacion.puntuaje_general = Tabla.Rows.Item(0).Item(7)
            catacion.puntuaje_uniformidad = Tabla.Rows.Item(0).Item(8)
            catacion.uniformidad1 = Tabla.Rows.Item(0).Item(9)
            catacion.uniformidad2 = Tabla.Rows.Item(0).Item(10)
            catacion.uniformidad3 = Tabla.Rows.Item(0).Item(11)
            catacion.uniformidad4 = Tabla.Rows.Item(0).Item(12)
            catacion.uniformidad5 = Tabla.Rows.Item(0).Item(13)
            catacion.puntuaje_taza_limpia = Tabla.Rows.Item(0).Item(14)
            catacion.taza_limpia1 = Tabla.Rows.Item(0).Item(15)
            catacion.taza_limpia2 = Tabla.Rows.Item(0).Item(16)
            catacion.taza_limpia3 = Tabla.Rows.Item(0).Item(17)
            catacion.taza_limpia4 = Tabla.Rows.Item(0).Item(18)
            catacion.taza_limpia5 = Tabla.Rows.Item(0).Item(19)
            catacion.numero_defectos = Tabla.Rows.Item(0).Item(20)
            catacion.nota = Tabla.Rows.Item(0).Item(21)
            Return catacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return catacion
    End Function
End Class
