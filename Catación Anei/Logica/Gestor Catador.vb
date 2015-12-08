Imports System.Data.SqlClient
Public Class Gestor_Catador
    Private db As New Conexion_BD
    Private Comando As SqlCommand
    Private catador As Catador

    Public Function Tabla_Catadores() As DataTable 'Devuelve una tabla con todos los registros de los catadores para agregarlo a la tabla
        Return catador.select_tabla_catadores
    End Function

    Public Function Buscar_Catador() As DataTable 'Devuelve una tabla con todos los registros de los catadores para agregarlo a la tabla
        Return catador.select_catadores
    End Function

    Public Function Total_Registrados() As Integer
        Return catador.select_total_registros
    End Function
End Class
