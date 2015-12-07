Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Conexion_BD

    Protected configuracion As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("cn")
    Dim cn As New SqlConnection(configuracion.ConnectionString)

    Public ReadOnly Property CadenaConexion As String
        Get
            Return cn.ConnectionString
        End Get
    End Property

    Public ReadOnly Property Conexion As SqlConnection
        Get
            Return cn
        End Get
    End Property
End Class
