Imports Datos
Public Class Ventas
    Sub llenar_datosventas()
        Dim llenar_grid As New llenarDatagrid
        Dim sql As String = ("SELECT detalles_de_venta.codigo_producto,descripcion, SUM(Cantidad) AS Total_cantidad,precio_unitario,SUM(sub_total) as Total_a_pagar,fecha,tipo,detalles_de_venta.codigo_venta,codigo_detalles
FROM detalles_de_venta,ventas,tipo_venta
WHERE detalles_de_venta.codigo_venta=ventas.codigo_venta AND detalles_de_venta.codigo_venta=ventas.codigo_venta
and tipo_venta.codigo_venta=ventas.codigo_venta
GROUP BY descripcion, detalles_de_venta.codigo_venta;")

        DataGridView1.DataSource = llenar_grid.llenar_datagridview(sql).Tables("consulta").DefaultView
        Dim Valor As String
        Dim cfilas As Integer = DataGridView1.RowCount

        For a As Integer = 0 To cfilas - 1
            If DataGridView1.Rows(a).Cells(1).Value = "total" Then
                DataGridView1.Rows(a).DefaultCellStyle.BackColor = Color.Red
            End If
        Next

    End Sub
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datosventas()
        BackColor = Color.FromArgb(62, 62, 64)
        'DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 64)
        'DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        DataGridView1.BackgroundColor = Color.FromArgb(62, 62, 64)

        DataGridView1.EnableHeadersVisualStyles = False
        'DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 201, 176)
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        DataGridView1.Columns(0).HeaderText = "Código Producto"
        DataGridView1.Columns(1).HeaderText = "Descripción"
        DataGridView1.Columns(2).HeaderText = "Cantidad"
        DataGridView1.Columns(3).HeaderText = "Precio Unitario"
        DataGridView1.Columns(4).HeaderText = "Subtotal"
        DataGridView1.Columns(5).HeaderText = "Fecha"
        DataGridView1.Columns(6).HeaderText = "Tipo de Venta"
        DataGridView1.Columns(7).HeaderText = "Código Venta"
        DataGridView1.Columns(8).Visible = False


    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtcodigo.Text = DataGridView1.CurrentRow.Cells(7).Value
        dtpfecha.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        Dim recorrido As Integer = DataGridView1.RowCount
        Dim precio As Integer
        For a As Integer = 0 To recorrido - 1

            If DataGridView1.Rows(a).Cells(7).Value = DataGridView1.CurrentRow.Cells(7).Value Then
                precio = precio + DataGridView1.Rows(a).Cells(4).Value
            End If

        Next
        txtprecio.Text = precio
    End Sub
End Class