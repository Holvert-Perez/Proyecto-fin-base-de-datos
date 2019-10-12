Imports MySql.Data.MySqlClient
Public Class clseditarcompras
    Dim conex As New Class1
    Public Function editar_tblcompras(ByVal pcodigocompra As String, ByVal pfecha As String, ByVal punidadmedida As String, ByVal pruc As String, ByVal ptipocompra As String, ByVal pdescripcion As String, ByVal pcantidad As String, ByVal pcosto As String, ByVal pcodigotipocompra As String, ByVal pcodigoproducto As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "editarcompras"

        cm.Parameters.AddWithValue("?pcodigocompra", pcodigocompra)
        cm.Parameters("?pcodigocompra").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pfecha", pfecha)
        cm.Parameters("?pfecha").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?punidadmedida", punidadmedida)
        cm.Parameters("?punidadmedida").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pruc", pruc)
        cm.Parameters("?pruc").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?ptipocompra", ptipocompra)
        cm.Parameters("?ptipocompra").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pdescripcion", pdescripcion)
        cm.Parameters("?pdescripcion").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcantidad", pcantidad)
        cm.Parameters("?pcantidad").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcosto", pcosto)
        cm.Parameters("?pcosto").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigotipocompra", pcodigotipocompra)
        cm.Parameters("?pcodigotipocompra").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigoproducto", pcodigoproducto)
        cm.Parameters("?pcodigoproducto").Direction = ParameterDirection.Input

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
End Class
