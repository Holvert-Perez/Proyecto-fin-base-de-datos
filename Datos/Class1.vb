Imports MySql.Data.MySqlClient

Public Class Class1
    'conexion a la base datos
    Private server_name As String = "127.0.0.1"
    Private user As String = "root"
    Private clave As String = ""
    Private db As String = "pulperianubia"

    Public conexion As New MySqlConnection("datasource=" & server_name & ";" & "username=" & user & ";" & "password=" & clave & ";" & "database=" & db)

End Class
