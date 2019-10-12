Imports MySql.Data.MySqlClient
Public Class clseditarventa
    Dim conex As New Class1
    Public Function editar_tblventas(ByVal pcodigoproducto As String, ByVal pdescripcion As String, ByVal pcantidad As String, ByVal ppreciounitario As String, ByVal psubtotal As String, ByVal pfecha As String, ByVal ptipoventa As String, ByVal pcodigoventa As String, ByVal pcodigodetalles As String, ByVal ptotaldeuda As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion

        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "ediatardetallesdeventa"

        cm.Parameters.AddWithValue("?pcodigoproducto", pcodigoproducto)
        cm.Parameters("?pcodigoproducto").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pdescripcion", pdescripcion)
        cm.Parameters("?pdescripcion").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcantidad", pcantidad)
        cm.Parameters("?pcantidad").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?ppreciounitario", ppreciounitario)
        cm.Parameters("?ppreciounitario").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?psubtotal", psubtotal)
        cm.Parameters("?psubtotal").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pfecha", pfecha)
        cm.Parameters("?pfecha").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?ptipoventa", ptipoventa)
        cm.Parameters("?ptipoventa").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigoventa", pcodigoventa)
        cm.Parameters("?pcodigoventa").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigodetalles", pcodigodetalles)
        cm.Parameters("?pcodigodetalles").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?ppreciototal", ptotaldeuda)
        cm.Parameters("?ppreciototal").Direction = ParameterDirection.Input


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
