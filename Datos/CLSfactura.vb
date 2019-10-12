Imports MySql.Data.MySqlClient
Public Class CLSfactura
    Dim conex As New Class1
    Private tablaVista As String
    Private codigo_venta As String
    Public Sub New(ByVal tablaVista As String, ByVal codigo_venta As String)

        Me.tablaVista = tablaVista
        Me.codigo_venta = codigo_venta
    End Sub

    Public Function obtenerDataTable() As DataTable
        Dim Da As MySqlDataAdapter
        Dim DS As New DataSet
        Dim DT As DataTable

        Dim conexion As String
        Dim sql As String


        sql = "SELECT descripcion, precio_unitario,cantidad,sub_total,fecha,cedula,nombre,apellido,direccion,codigo_venta,tipo
FROM " & Me.tablaVista & " WHERE codigo_venta='" & Me.codigo_venta & "'"

        Da = New MySqlDataAdapter(sql, conex.conexion)
        Da.Fill(DS, Me.tablaVista)
        DT = DS.Tables(Me.tablaVista)

        Return DT
    End Function

    Public Sub crearXML(ByVal Archivo As String)
        Dim DT As DataTable
        DT = Me.obtenerDataTable
        DT.WriteXmlSchema(Archivo & Me.tablaVista & ".xml")
    End Sub



End Class
