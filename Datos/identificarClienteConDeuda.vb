
Imports MySql.Data.MySqlClient
Public Class identificarClienteConDeuda
    Dim conex As New Class1
    Public Function cliente_deuda(ByVal cedula As String) As String

        Dim cm As New MySqlCommand
        Dim respuesta As MySqlParameter
        Dim cliente As String
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "obtener_cliente_con_deuda"

        cm.Parameters.AddWithValue("?pcedula", cedula)
        cm.Parameters("?pcedula").Direction = ParameterDirection.Input

        respuesta = cm.Parameters.AddWithValue("?prespuesta", "")
        cm.Parameters("?prespuesta").Direction = ParameterDirection.Output

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
