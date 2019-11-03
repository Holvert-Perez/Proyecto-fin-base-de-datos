Imports Datos
Public Class Productos
    Sub llenar_datosproductos()
        Dim llenar_grid As New llenarDatagrid
        Dim sql As String = ("SELECT codigo_producto, descripcion, precio_unitario from producto ORDER BY descripcion;")

        DataGridView1.DataSource = llenar_grid.llenar_datagridview(sql).Tables("consulta").DefaultView

    End Sub
    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datosproductos()
        BackColor = Color.FromArgb(62, 62, 64)
        ' DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 64)
        'DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        DataGridView1.BackgroundColor = Color.FromArgb(62, 62, 64)



        DataGridView1.EnableHeadersVisualStyles = False
        'DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 201, 176)
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).HeaderText = "Descripción"
        DataGridView1.Columns(2).HeaderText = "Precio Unitario"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs)
        Dim editarproducto As New clseditarproducto
        Dim codigo As String = DataGridView1.CurrentRow.Cells(0).Value.ToString

        If txtcodigo.Text = "" And txtdescripcion.Text = "" Then
            MessageBox.Show("No ha selecionado ningun producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If editarproducto.editar_tblproductos(txtcodigo.Text, txtdescripcion.Text, txtprecio.Text) Then
                MessageBox.Show("Modificacion exitosa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                llenar_datosproductos()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtcodigo.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtdescripcion.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtprecio.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim existe As New clseditarproducto
        If txtdescripcion.Text = "" Then
            Label4.Visible = True
        Else
            If txtprecio.Text = "" Then
                Label5.Visible = True
            Else
                If existe.verificar_existencias(txtdescripcion.Text, txtprecio.Text) = "si" Then
                    MessageBox.Show("Ya existe un producto con este nombre.")
                Else
                    llenar_datosproductos()
                    MessageBox.Show("Producto agregado.")

                End If
            End If
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        If txtdescripcion.Text = "" Then
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If

    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If txtprecio.Text = "" Then
            Label5.Visible = True
        Else
            Label5.Visible = False
        End If
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Isdigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btneditar_Click_1(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editar As New clseditarproducto
        editar.editar_tblproductos(txtcodigo.Text, txtdescripcion.Text, txtprecio.Text)
        MessageBox.Show("Producto editado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        llenar_datosproductos()
    End Sub
End Class