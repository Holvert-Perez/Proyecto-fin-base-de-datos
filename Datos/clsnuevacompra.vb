Imports MySql.Data.MySqlClient
Public Class clsnuevacompra
    Dim conex As New Class1
    Public Function agregar_tblcompras(ByVal pruc As String, ByVal pfechacompra As Date, ByVal pcostototal As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "nuevacompra"

        cm.Parameters.AddWithValue("?pruc", pruc)
        cm.Parameters("?pruc").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pfechacompra", pfechacompra)
        cm.Parameters("?pfechacompra").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcostototal", pcostototal)
        cm.Parameters("?pcostototal").Direction = ParameterDirection.Input

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Public Function agregar_tbltipocompra(ByVal ptipocompra As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardartipocompra"

        cm.Parameters.AddWithValue("?ptipocompra", ptipocompra)
        cm.Parameters("?ptipocompra").Direction = ParameterDirection.Input

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Public Function agregar_tbldetallescompra(ByVal pcostounitario As String, ByVal pcantidad As String, ByVal pcodigoproducto As String, ByVal psubtotal As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardardetallescompra"

        cm.Parameters.AddWithValue("?pcostounitario", pcostounitario)
        cm.Parameters("?pcostounitario").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcantidad", pcantidad)
        cm.Parameters("?pcantidad").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigoproducto", pcodigoproducto)
        cm.Parameters("?pcodigoproducto").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?psubtotal", psubtotal)
        cm.Parameters("?psubtotal").Direction = ParameterDirection.Input
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
End Class
