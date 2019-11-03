Imports MySql.Data.MySqlClient
Public Class clseditarproducto
    Dim conex As New Class1
    Public Function editar_tblproductos(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pprecio As Integer) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "editarproducto"

        cm.Parameters.AddWithValue("?pcodigo", pcodigo)
        cm.Parameters("?pcodigo").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pdescripcion", pdescripcion)
        cm.Parameters("?pdescripcion").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pprecio", pprecio)
        cm.Parameters("?pprecio").Direction = ParameterDirection.Input

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        Finally
            conex.conexion.Close()
        End Try
    End Function

    Public Function Agregar_existencias(ByVal pexistencia As String, ByVal pnombreproducto As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "existencias"

        cm.Parameters.AddWithValue("?pexistencia", pexistencia)
        cm.Parameters("?pexistencia").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pnombreproducto", pnombreproducto)
        cm.Parameters("?pnombreproducto").Direction = ParameterDirection.Input

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        Finally
            conex.conexion.Close()
        End Try

    End Function

    Public Function obtener_existencia(ByVal pcodigo As String) As String
        Dim cm As New MySqlCommand
        Dim respues As MySqlParameter
        Dim existencia As String
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "obtener_existencia"

        cm.Parameters.AddWithValue("?pcodigo", pcodigo)
        cm.Parameters("?pcodigo").Direction = ParameterDirection.Input

        respues = cm.Parameters.AddWithValue("?prespuesta", "")
        cm.Parameters("?prespuesta").Direction = ParameterDirection.Output

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            existencia = respues.Value.ToString
            Return existencia
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try
    End Function

    Public Function verificar_existencias(ByVal pnombreproducto As String, ByVal pprecio As String) As String
        Dim cm As New MySqlCommand
        Dim respuesta As MySqlParameter
        Dim existe As String
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "validar_producto"

        cm.Parameters.AddWithValue("?pnombreproducto", pnombreproducto)
        cm.Parameters("?pnombreproducto").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pprecio", pprecio)
        cm.Parameters("?pprecio").Direction = ParameterDirection.Input

        respuesta = cm.Parameters.AddWithValue("?prespuesta", "")
        cm.Parameters("?prespuesta").Direction = ParameterDirection.Output
        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            existe = respuesta.Value.ToString
            Return existe
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try
    End Function

End Class
