Imports MySql.Data.MySqlClient
Public Class llenar_combo
    Private conex As New Class1

    Public Function LlenarCmb(ByVal sql As String) As DataTable
        Dim DA As New MySqlDataAdapter(sql, conex.conexion)
        Dim DT As New DataTable
        DA.Fill(DT)

        Return DT
    End Function

    Public Function llenarprecio(ByVal codigo_producto As String) As String
        ' mostrar precio en txt


        Dim sql As String = ("SELECT codigo_producto, precio_unitario FROM producto
                                WHERE codigo_producto='" & codigo_producto & "';")

        Dim CM As New MySqlCommand(sql, conex.conexion)
        Dim DR As MySqlDataReader
        Dim precio_unitario As String

        Try
            conex.conexion.Open()
            DR = CM.ExecuteReader

            While DR.Read
                If codigo_producto = DR.GetString("codigo_producto") Then
                    precio_unitario = DR.GetString("precio_unitario")
                End If
            End While

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conex.conexion.Close()
        End Try

        Return precio_unitario


    End Function
    '    Public Function llenardatoscliente(ByVal cedula As String, ByVal codigotelefono As String) As String
    '        Dim sql As String = ("SELECT clientes_credito.cedula, nombre, apellido, direccion, numero_telefono, telefonos.codigo_telefono FROM clientes_credito, telefonos
    'WHERE clientes_credito.cedula='" & cedula & "'
    'And telefonos.codigo_telefono='" & codigotelefono & "'
    'ORDER BY nombre;")

    '        Dim CM As New MySqlCommand(sql, conex.conexion)
    '        Dim DR As MySqlDataReader
    '        Dim cliente, nombre, apellido, direccion, telefono As String

    '        Try
    '            conex.conexion.Open()
    '            DR = CM.ExecuteReader

    '            While DR.Read
    '                If cedula = DR.GetString("clientes_credito.cedula") And codigotelefono = DR.GetString("telefonos.codigo_telefono") Then
    '                    nombre = DR.GetString("nombre")
    '                    apellido = DR.GetString("apellido")
    '                    direccion = DR.GetString("direccion")
    '                    telefono = DR.GetString("numero_telefono")
    '                End If
    '            End While
    '            cliente = cedula & "+" & nombre & "+" & apellido & "+" & direccion & "+" & telefono
    '        Catch ex As MySqlException
    '            MsgBox(ex.ToString)
    '        Finally
    '            conex.conexion.Close()
    '        End Try

    '        Return cliente


    '    End Function
End Class


