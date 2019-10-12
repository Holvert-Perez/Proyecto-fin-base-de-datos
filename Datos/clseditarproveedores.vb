Imports MySql.Data.MySqlClient
Public Class clseditarproveedores
    Dim conex As New Class1
    Public Function editar_tblproveedores(ByVal pruc As String, ByVal pnombreproveedor As String, ByVal papellido As String, ByVal pdireccion As String, ByVal pcodigotelefono As String, ByVal ptelefono As String, ByVal pcorreos As String, ByVal pcodigo_correo As String) As Boolean
        Dim cm As New MySqlCommand
        cm.Connection = conex.conexion
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "editarproveedores"

        cm.Parameters.AddWithValue("?pruc", pruc)
        cm.Parameters("?pruc").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pnombreproveedor", pnombreproveedor)
        cm.Parameters("?pnombreproveedor").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?papellido", papellido)
        cm.Parameters("?papellido").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pdireccion", pdireccion)
        cm.Parameters("?pdireccion").Direction = ParameterDirection.Input


        cm.Parameters.AddWithValue("?pcodigotelefono", pcodigotelefono)
        cm.Parameters("?pcodigotelefono").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?ptelefono", ptelefono)
        cm.Parameters("?ptelefono").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcorreos", pcorreos)
        cm.Parameters("?pcorreos").Direction = ParameterDirection.Input

        cm.Parameters.AddWithValue("?pcodigo_correo", pcodigo_correo)
        cm.Parameters("?pcodigo_correo").Direction = ParameterDirection.Input

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
