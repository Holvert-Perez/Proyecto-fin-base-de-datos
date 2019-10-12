Imports MySql.Data.MySqlClient
Public Class clsnuevaventa
    Dim conex As New Class1
    Public Function agregar_tblventas(ByVal pfecha As DateTime, ByVal ppreciototal As String, ByVal pfecha_pago As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "nuevaventa"

        cm.Parameters.AddWithValue("?pfecha", pfecha)
        cm.Parameters("?pfecha").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?ppreciototal", ppreciototal)
        cm.Parameters("?ppreciototal").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pfecha_pago", pfecha_pago)
        cm.Parameters("?pfecha_pago").Direction = ParameterDirection.Input
        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Public Function agregar_tbltipoventa(ByVal ptipoventa As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardartipoventa"

        cm.Parameters.AddWithValue("?ptipoventa", ptipoventa)
        cm.Parameters("?ptipoventa").Direction = ParameterDirection.Input

        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Public Function agregar_tbldetallesventa(ByVal psubtotal As String, ByVal pcodigoproducto As String, ByVal pcantidad As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardardetallesventa"

        cm.Parameters.AddWithValue("?psubtotal", psubtotal)
        cm.Parameters("?psubtotal").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigoproducto", pcodigoproducto)
        cm.Parameters("?pcodigoproducto").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcantidad", pcantidad)
        cm.Parameters("?pcantidad").Direction = ParameterDirection.Input


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

    Public Function agregar_tblventasclientes(ByVal pcedula As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardarventasclientes"

        cm.Parameters.AddWithValue("?pcedula", pcedula)
        cm.Parameters("?pcedula").Direction = ParameterDirection.Input



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
