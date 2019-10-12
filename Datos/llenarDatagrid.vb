Imports MySql.Data.MySqlClient

Public Class llenarDatagrid

    Dim conex As New Class1

    Public Function llenar_datagridview(ByVal sql As String) As DataSet

        Dim DA As New MySqlDataAdapter(sql, conex.conexion)
        Dim DS As New DataSet
        DS.Tables.Clear()
        DA.Fill(DS, "consulta")

        Return DS
    End Function


    Public Function borrar_clientes_telefono(ByVal cedula As String)
        Dim DA As MySqlDataAdapter
        Dim cm As New MySqlCommand("DELETE FROM clientes_credito_telefono 
WHERE clientes_credito_telefono.cedula='" & cedula & "'", conex.conexion)

        conex.conexion.Open()
        cm.ExecuteNonQuery()
        conex.conexion.Close()
    End Function

    Public Function borrar_telefono(ByVal codigo_telefono As String)
        Dim DA As MySqlDataAdapter
        Dim cm As New MySqlCommand("DELETE FROM telefonos 
WHERE telefonos.codigo_telefono='" & codigo_telefono & "'", conex.conexion)

        conex.conexion.Open()
        cm.ExecuteNonQuery()
        conex.conexion.Close()
    End Function

    Public Function borrar_clientescorreo(ByVal cedula As String)
        Dim DA As MySqlDataAdapter
        Dim cm As New MySqlCommand("DELETE FROM clientes_correo
WHERE codigo_correo='" & cedula & "'", conex.conexion)

        conex.conexion.Open()
        cm.ExecuteNonQuery()
        conex.conexion.Close()
    End Function

    Public Function borrar_correo(ByVal codigo_codigocorreo As String)
        Dim DA As MySqlDataAdapter
        Dim cm As New MySqlCommand("DELETE FROM clientes_correo
WHERE codigo_correo='" & codigo_codigocorreo & "'", conex.conexion)

        conex.conexion.Open()
        cm.ExecuteNonQuery()
        conex.conexion.Close()
    End Function
    Public Function borrar_cliente(ByVal cedula As String)
        Dim DA As MySqlDataAdapter
        Dim cm As New MySqlCommand("DELETE FROM clientes_credito
WHERE clientes_credito.cedula='" & cedula & "'", conex.conexion)

        conex.conexion.Open()
        cm.ExecuteNonQuery()
        conex.conexion.Close()
    End Function

End Class
