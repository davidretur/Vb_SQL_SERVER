Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class CDConexion
    Dim Conexion As SqlConnection
    Public Function Conectar() As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return Conexion
    End Function
End Class
