Imports MySql.Data.MySqlClient
Imports comun
Public Class clsusuario
    Dim conex As New Class1

    Public Function recoverPassword(requestingUser As String) As String
        Return requestUserPassword(requestingUser)
    End Function

    Public Function requestUserPassword(ByVal requestingUser As String) As String
        Dim cm As New MySqlCommand
        conex.conexion.Open()



        cm.Connection = conex.conexion
        cm.CommandText = "select *from Usuario where Nombre_Usuario=@user or email=@mail"
        cm.Parameters.AddWithValue("@user", requestingUser)
        cm.Parameters.AddWithValue("@mail", requestingUser)
        cm.CommandType = CommandType.Text
        Dim reader As MySqlDataReader = cm.ExecuteReader()

        If reader.Read() = True Then
                    Dim userName As String = reader.GetString(3) & ", " + reader.GetString(4)
            Dim userMail As String = reader.GetString(5)
            Dim accountPassword As String = reader.GetString(2)

            Dim systemSupport = New SoporteSistema()
            systemSupport.sendMail(
          subject:="SISTEMA: Solicitud de recuperación de contraseña",
          body:="Hola " & userName & vbLf & "solicitó recuperar su contraseña." & vbLf &
          "Su contraseña actual es: " & accountPassword & vbLf &
          "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.",
          receiverMail:=New List(Of String) From {userMail}
          )

            Return "Hola " & userName & vbLf & "solicitó recuperar su contraseña." & vbLf &
          "Por favor verifique su correo: " & userMail & vbLf &
          "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema."

        Else
                    Return "Sorry, you do not have an account with that email or username."
                End If


    End Function

    Public Function agregar_usuario(ByVal nombreuser As String, ByVal clave As String, ByVal nombre As String, ByVal apellido As String, ByVal correo As String, ByVal cargo As String)
        Dim cm As New MySqlCommand


        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "Agregar_Usuario"

        cm.Parameters.AddWithValue("?pNombre_Usuario", nombreuser)
        cm.Parameters("?pNombre_Usuario").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pClave", clave)
        cm.Parameters("?pClave").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pnombre", nombre)
        cm.Parameters("?pnombre").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?papellido", apellido)
        cm.Parameters("?papellido").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcargo", cargo)
        cm.Parameters("?pcargo").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pemail", correo)
        cm.Parameters("?pemail").Direction = ParameterDirection.Input
        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try

    End Function


    Public Function Obtener_usuario(ByVal nUsuario As String, ByVal Clave As String) As Integer
        Dim cm As New MySqlCommand
        Dim res, nombre, apellido, cargo, correo As MySqlParameter
        Dim ID As Integer
        Dim pnombre As String
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "obtener_Usuario"

        cm.Parameters.AddWithValue("?pUsuario", nUsuario)
        cm.Parameters("?pUsuario").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pClave", Clave)
        cm.Parameters("?pClave").Direction = ParameterDirection.Input

        res = cm.Parameters.AddWithValue("?pRes", "")
        cm.Parameters("?pRes").Direction = ParameterDirection.Output

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            ID = res.Value.ToString
            'usuarioactivo.nombre = nombre.Value.ToString
            Return ID
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try



    End Function


    Public Function verificar_existe(ByVal clave As String, ByVal user As String)

        Dim Cm As New MySqlCommand("select * from usuario WHERE " & "'" & clave & "'=usuario.clave and usuario.Nombre_Usuario=" & "'" & user & "'", conex.conexion)
        Dim DR As MySqlDataReader

        Try
            conex.conexion.Open()
            DR = Cm.ExecuteReader
            While DR.Read
                usuarioactivo.iduser = DR.GetInt32(0)
                usuarioactivo.nombre = DR.GetString(3)
                usuarioactivo.apellido = DR.GetString(4)
                usuarioactivo.cargo = DR.GetString(6)
                usuarioactivo.correo = DR.GetString(5)
            End While
            DR.Dispose()

        Catch ex As Exception


        Finally
            conex.conexion.Close()

        End Try

    End Function
    Public Function Verificar_NUser(ByVal nUsuario As String) As String
        Dim cm As New MySqlCommand
        Dim res As MySqlParameter
        Dim resultado As String

        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "Verificar_ExisteNUser"

        cm.Parameters.AddWithValue("?pnuser", nUsuario)
        cm.Parameters("?pnuser").Direction = ParameterDirection.Input

        res = cm.Parameters.AddWithValue("?pexiste", "")
        cm.Parameters("?pexiste").Direction = ParameterDirection.Output

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            resultado = res.Value.ToString
            Return resultado
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try



    End Function
End Class
