Imports Datos
Public Class RCompras
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        Dim totalcompra As Integer
        If cbbtipocompra.Text = "" Then
            MessageBox.Show("No se ha seleccionado el tipo de compra.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtruc.Text = "" Then
                MessageBox.Show("No se ha agregado ningún proveedor.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Cmbproducto.Text = "" Then
                    MessageBox.Show("No se ha seleccionado ningún producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If txtsubtotal.Text = 0 Then
                        MessageBox.Show("Verifique que sus datos sean correctos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        DataGridView1.Rows.Add()
                        Dim x As Integer = DataGridView1.Rows.Count
                        DataGridView1.Rows(x - 2).Cells(0).Value = Cmbproducto.SelectedValue
                        DataGridView1.Rows(x - 2).Cells(1).Value = Cmbproducto.Text
                        DataGridView1.Rows(x - 2).Cells(3).Value = txtprecio.Text
                        DataGridView1.Rows(x - 2).Cells(2).Value = numericcantidad.Value
                        DataGridView1.Rows(x - 2).Cells(4).Value = txtsubtotal.Text
                        DataGridView1.Rows(x - 2).Cells(5).Value = "Eliminar"
                        numericcantidad.Value = 0
                        llenarcmb_producto()
                        txtprecio.Text = ""


                        For i As Integer = 0 To x - 2
                            totalcompra += DataGridView1.Rows(i).Cells(4).Value
                        Next
                        txttotalcompra.Text = totalcompra
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnverproveedor_Click(sender As Object, e As EventArgs) Handles btnverproveedor.Click
        Dim frm As New Proveedores
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Sub ID_compras()
        Dim rdn As New Random(Guid.NewGuid().GetHashCode())
        txtid.Text = Convert.ToString(rdn.Next(0, 100000))
    End Sub

    Sub llenarcmb_producto()
        Dim llenar As New Datos.llenar_combo
        Dim sql As String = "SELECT codigo_producto,descripcion from producto;"

        Cmbproducto.DataSource = llenar.LlenarCmb(sql)
        Cmbproducto.DisplayMember = "Descripcion"
        Cmbproducto.ValueMember = "codigo_producto"
        Cmbproducto.Text = ""
    End Sub
    Sub llenarcmb_tipcompra()
        Dim llenar As New Datos.llenar_combo
        Dim sql As String = "SELECT tipo_compra,codigo_tipocompra from tipo_compra;"

        cbbtipocompra.DataSource = llenar.LlenarCmb(sql)
        cbbtipocompra.DisplayMember = "tipo_compra"
        cbbtipocompra.ValueMember = "codigo_tipocompra"
        cbbtipocompra.Text = ""
    End Sub

    Private Sub RCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID_compras()
        DataGridView1.Columns(0).Visible = False
        llenarcmb_producto()
        llenarcmb_tipcompra()
        txtsubtotal.Text = 0
        txtprecio.Text = ""
        txttotalcompra.Text = 0
        DataGridView1.Columns(5).Name = "Eliminar"
    End Sub

    Private Sub numericcantidad_ValueChanged(sender As Object, e As EventArgs) Handles numericcantidad.ValueChanged

        txtsubtotal.Text = (Val(txtprecio.Text) * numericcantidad.Value)

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim agregartblcompras As New clsnuevacompra
        Dim agregartbltipocompra As New clsnuevacompra
        Dim agregartbldetallescompras As New clsnuevacompra
        Dim obtener As New clseditarproducto
        Dim existencias As String
        Dim cfilas As Integer = DataGridView1.RowCount

        If txttotalcompra.Text = 0 Then
            MessageBox.Show("Agregue al menos un producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            dtpfecha.Value = Now
            If agregartblcompras.agregar_tblcompras(txtruc.Text, dtpfecha.Value.ToString("yyyy-MM-dd HH:mm:ss"), txttotalcompra.Text) Then
                If agregartbltipocompra.agregar_tbltipocompra(cbbtipocompra.SelectedValue) Then

                    For i As Integer = 0 To cfilas - 2
                        agregartbldetallescompras.agregar_tbldetallescompra(DataGridView1.Rows(i).Cells(3).Value, DataGridView1.Rows(i).Cells(2).Value, DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(4).Value)
                        existencias = (obtener.obtener_existencia(DataGridView1.Rows(i).Cells(0).Value))
                        existencias += DataGridView1.Rows(i).Cells(2).Value
                        obtener.Agregar_existencias(existencias, DataGridView1.Rows(i).Cells(1).Value)
                    Next
                    MessageBox.Show("Compra realizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al registrar compra")
                End If
            End If
        End If
    End Sub

    Private Sub numericcantidad_Click(sender As Object, e As EventArgs) Handles numericcantidad.Click
        Try
            If txtprecio.Text <> 0 Then

                txtsubtotal.Text = (Val(txtprecio.Text) * numericcantidad.Value)
            Else
                If txtprecio.Text = 0 Then
                    numericcantidad.Value = 0
                    MessageBox.Show("Agregue el precio del producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    numericcantidad.Value = 0
                    MessageBox.Show("Agregue el precio del producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Catch ex As Exception
            numericcantidad.Value = 0
            MessageBox.Show("Agregue el precio del producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnnuevacompra_Click(sender As Object, e As EventArgs) Handles btnnuevacompra.Click
        cbbtipocompra.Text = ""
        Cmbproducto.Text = ""
        ID_compras()
        txttotalcompra.Text = 0
        numericcantidad.Value = 0
        'txtprecio.Text = ""
        txtsubtotal.Text = 0
        txtruc.Text = ""
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txtapellido.Text = ""
        txttelefono.Text = ""
        txtcorreo.Text = ""
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If Me.DataGridView1.Columns(5).Name = "Eliminar" Then

                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class