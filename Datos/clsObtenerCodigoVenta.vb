Imports MySql.Data.MySqlClient
Public Class clsObtenerCodigoVenta
    Dim conex As New Class1
    Public Function codigo_venta() As String

        Dim cm As New MySqlCommand
        Dim respuesta As MySqlParameter
        Dim cliente As String
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "codigo"
        respuesta = cm.Parameters.AddWithValue("?pres", "")
        cm.Parameters("?pres").Direction = ParameterDirection.Output

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            cliente = respuesta.Value.ToString
            Return cliente
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try
    End Function

    Public Function codigo_ventacont() As String

        Dim cm As New MySqlCommand
        Dim respuesta As MySqlParameter
        Dim cliente As String
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "codigoContado"
        respuesta = cm.Parameters.AddWithValue("?pres", "")
        cm.Parameters("?pres").Direction = ParameterDirection.Output

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            cliente = respuesta.Value.ToString
            Return cliente
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try
    End Function

End Class
