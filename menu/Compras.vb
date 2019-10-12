Imports Datos
Public Class Compras
    Sub llenar_datoscompras()
        Dim llenar_grid As New llenarDatagrid
        Dim sql As String = ("SELECT fecha_compra,producto.descripcion,cantidad,costo,unidad_medida,proveedores.ruc,proveedores.nombre_proveedor,apellidos,tipo_compra.Tipo_compra,producto.codigo_compra,codigo_tipocompra,codigo_producto
from tipo_compra,proveedores,producto,compra
WHERE
compra.codigo_compra=tipo_compra.codigo_compra
AND
compra.codigo_compra=producto.codigo_compra
AND
compra.ruc=proveedores.ruc ORDER BY fecha_compra Desc;")

        DataGridView1.DataSource = llenar_grid.llenar_datagridview(sql).Tables("consulta").DefaultView

    End Sub

    Private Sub compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datoscompras()

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
        Dim cfilas As Integer = DataGridView1.RowCount
        Dim proveedor As String
        For a As Integer = 0 To cfilas - 1

            proveedor = DataGridView1.Rows(a).Cells(6).Value + " " + DataGridView1.Rows(a).Cells(7).Value
            DataGridView1.Rows(a).Cells(6).Value = proveedor
        Next


        DataGridView1.Columns(0).HeaderText = "Fecha"
        DataGridView1.Columns(1).HeaderText = "Descripción"
        DataGridView1.Columns(2).HeaderText = "Cantidad"
        DataGridView1.Columns(3).HeaderText = "Costo"
        DataGridView1.Columns(4).HeaderText = "Unidad de medida"
        DataGridView1.Columns(5).HeaderText = ""
        DataGridView1.Columns(6).HeaderText = "Proveedor"
        DataGridView1.Columns(8).HeaderText = "Tipo de Compra"
        DataGridView1.Columns(9).HeaderText = "Código"
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        dtpfecha.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtprecio.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtcodigocompra.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString

    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ex = e.X

        ey = e.Y

        Arrastre = True
    End Sub
    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub


End Class