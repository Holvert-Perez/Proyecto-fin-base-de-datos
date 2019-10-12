Imports MySql.Data.MySqlClient
Public Class CLSusuario
    Dim conex As New Class1

    Public Function agregar_usuario(ByVal nombre As String, ByVal clave As String)
        Dim cm As New MySqlCommand


        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "Agregar_Usuario"

        cm.Parameters.AddWithValue("?pNombre_Usuario", nombre)
        cm.Parameters("?pNombre_Usuario").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pClave", clave)
        cm.Parameters("?pClave").Direction = ParameterDirection.Input


        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try

    End Function


    Public Function Agregar(ByVal nUsuario As String, ByVal Clave As String) As Integer
        Dim cm As New MySqlCommand
        Dim res As MySqlParameter
        Dim ID As Integer

        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "Obtener_Usuario"

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
            Return ID
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Clone()
        End Try



    End Function


    Public Function verificar_existe() As Boolean
        Dim respuesta As Boolean = False

        Dim Cm As New MySqlCommand("select * from usuario", conex.conexion)
        Dim DR As MySqlDataReader
        Dim cnt As Integer = 0

        Try
            conex.conexion.Open()
            DR = Cm.ExecuteReader

            While DR.Read
                'if (DR.getstring('nombre_usuario')
                cnt += 1
            End While

            If cnt > 0 Then
                Return False
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conex.conexion.Close()

        End Try

    End Function
End Class
