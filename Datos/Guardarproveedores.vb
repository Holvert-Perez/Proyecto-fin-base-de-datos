Imports MySql.Data.MySqlClient
Public Class Guardarproveedores
    Dim conex As New Class1
    Public Function agregar_tblproveedores(ByVal pruc As String, ByVal pnombre As String, ByVal papellido As String, ByVal pdireccion As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "GuardarProveedores"

        cm.Parameters.AddWithValue("?pruc", pruc)
        cm.Parameters("?pruc").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pnombre", pnombre)
        cm.Parameters("?pnombre").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?papellido", papellido)
        cm.Parameters("?papellido").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pdireccion", pdireccion)
        cm.Parameters("?pdireccion").Direction = ParameterDirection.Input


        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Public Function agregar_tbltelefonos(ByVal ptelefono As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardartelefono"


        cm.Parameters.AddWithValue("?ptelefono", ptelefono)
        cm.Parameters("?ptelefono").Direction = ParameterDirection.Input
        Try
            conex.conexion.Open()
            cm.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Public Function agregar_tblproveedores_telefono(ByVal pruc As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "guardarproveedorestelefono"


        cm.Parameters.AddWithValue("?pruc", pruc)
        cm.Parameters("?pruc").Direction = ParameterDirection.Input
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
