Imports System.Data.SqlClient
Public Class funcionDeRobusta
    Private db As New Conexion_BD
    Private Comando As SqlCommand

    Public Function Guardar_Robusta(ByVal Robusta As Robusta) As Boolean
        Dim i As Integer
        Try
            Dim _sql As String = String.Format("INSERT INTO ROBUSTA VALUES('" _
                                               & Robusta.codigo & "','" & Robusta.fk_codigo_muestra & "','" & Robusta.calificacion & "','" & Robusta.sabor_boca & "','" & Robusta.puntaje_sal_acido & "','" _
                                               & Robusta.baja_salinidad & "','" & Robusta.alta_acidez & "','" & Robusta.puntaje_amargo_dulce & "','" & Robusta.bajo_amargor & "','" & Robusta.alto_dulzor & "','" _
                                               & Robusta.puntaje_sensacion_boca & "','" & Robusta.sensacion_boca & "')")
            Using cmd As New SqlCommand(_sql, db.Conexion)
                db.Conexion.Open()
                i = cmd.ExecuteNonQuery
                db.Conexion.Close()
            End Using
        Catch ex As Exception
            If Err.Description.Contains("PRIMARY KEY") = True Then
                MsgBox("Error al guardar, intente de nuevo.", vbExclamation, "Seguridad - Robusta")
                db.Conexion.Close()
                Return False
            Else
                MsgBox(ex.Message, vbCritical, "Seguridad - Robusta")
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

    Public Function Atributos_Robusta(ByVal Codigo_Muestra As String) As Robusta
        Dim catacion As New Robusta
        Dim Tabla As New DataTable
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM ROBUSTA WHERE fk_codigo_muestra = '" & Codigo_Muestra & "'", db.Conexion)
            da.Fill(Tabla)

            catacion.codigo = Tabla.Rows.Item(0).Item(0)
            catacion.fk_codigo_muestra = Tabla.Rows.Item(0).Item(1)
            catacion.calificacion = Tabla.Rows.Item(0).Item(2)
            catacion.sabor_boca = Tabla.Rows.Item(0).Item(3)
            catacion.puntaje_sal_acido = Tabla.Rows.Item(0).Item(4)
            catacion.baja_salinidad = Tabla.Rows.Item(0).Item(5)
            catacion.alta_acidez = Tabla.Rows.Item(0).Item(6)
            catacion.puntaje_amargo_dulce = Tabla.Rows.Item(0).Item(7)
            catacion.bajo_amargor = Tabla.Rows.Item(0).Item(8)
            catacion.alto_dulzor = Tabla.Rows.Item(0).Item(9)
            catacion.puntaje_sensacion_boca = Tabla.Rows.Item(0).Item(10)
            catacion.sensacion_boca = Tabla.Rows.Item(0).Item(11)
            Return catacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return catacion
    End Function
End Class
