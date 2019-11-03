Imports MySql.Data.MySqlClient
Public Class FacturaContado
    Dim conex As New Class1
    Private tablaVista As String
    Private codigo As String
    Public Sub New(ByVal tablaVista As String, ByVal codigo As String)

        Me.tablaVista = tablaVista
        Me.codigo = codigo
    End Sub

    Public Function obtenerDataTable() As DataTable
        Dim Da As MySqlDataAdapter
        Dim DS As New DataSet
        Dim DT As DataTable

        Dim conexion As String
        Dim sql As String


        sql = "SELECT codigo_venta,descripcion,precio_unitario,cantidad,sub_total,fecha,tipo,descuento
From " & Me.tablaVista & " Where codigo_venta='" & codigo & "'"

        Da = New MySqlDataAdapter(sql, conex.conexion)
        Da.Fill(DS, Me.tablaVista)
        DT = DS.Tables(Me.tablaVista)

        Return DT
    End Function


    Public Sub crearXML(ByVal Archivo As String)
        Dim DT As DataTable
        DT = Me.obtenerDataTable()
        DT.WriteXmlSchema(Archivo & Me.tablaVista & ".xml")
    End Sub
End Class
