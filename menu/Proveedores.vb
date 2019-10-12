Imports Datos
Public Class Proveedores
    Dim codigo As String
    Dim correos As String
    Sub llenar_datosproveedores()
        Dim llenar_grid As New llenarDatagrid
        Dim sql As String = ("SELECT proveedores.ruc,nombre_proveedor,apellidos,direccion,numero_telefono, telefonos.codigo_telefono,direccion_correo, correos.codigo_correo from proveedores,proveedores_telefono,telefonos,correos,proveedores_correo
                                WHERE proveedores.ruc=proveedores_telefono.ruc
                                AND telefonos.codigo_telefono=proveedores_telefono.codigo_telefono
																AND proveedores.ruc=proveedores_correo.ruc
																AND proveedores_correo.codigo_correo=correos.codigo_correo
                                ORDER BY nombre_proveedor;")

        DataGridView1.DataSource = llenar_grid.llenar_datagridview(sql).Tables("consulta").DefaultView

    End Sub
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datosproveedores()
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

        DataGridView1.Columns(0).HeaderText = "Ruc"
        DataGridView1.Columns(1).HeaderText = "Nombre"
        DataGridView1.Columns(2).HeaderText = "Apellidos"
        DataGridView1.Columns(3).HeaderText = "Dirección"
        DataGridView1.Columns(4).HeaderText = "Número de teléfono"
        DataGridView1.Columns(6).HeaderText = "E-mail"
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(7).Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim Agregartblproveedores As New guardarproveedor
        Dim Agregartblproveedorestelefono As New guardarproveedor
        Dim Agregartbltelefono As New guardarproveedor

        If txtapellido.Text = "" And txtdireccion.Text = "" And txtnombre.Text = "" And txtruc.Text = "" Then
            MessageBox.Show("Por favor llenar campos obligatorios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Agregartblproveedores.agregar_tblproveedores(txtruc.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text) Then
                If Agregartbltelefono.agregar_tbltelefonos(txttelefono.Text) Then
                    If Agregartblproveedorestelefono.agregar_proveedores_telefono(txtruc.Text) Then

                        llenar_datosproveedores()
                        MessageBox.Show("Guardado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        MessageBox.Show("ha ocurrido un error al agregar Provedor", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editarproveedores As New clseditarproveedores


        If txtapellido.Text = "" And txtdireccion.Text = "" And txtruc.Text = "" And txtnombre.Text = "" And txttelefono.Text = "" Then
            MessageBox.Show("No ha selecionado ningun proveedor.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If editarproveedores.editar_tblproveedores(txtruc.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text, codigo, txttelefono.Text, txtemail.Text, correos) Then
                MessageBox.Show("Modificacion exitosa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnombre.Text = ""
                txttelefono.Text = ""
                txtdireccion.Text = ""
                txtapellido.Text = ""
                txtruc.Text = ""
                txtemail.Text = ""
                llenar_datosproveedores()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        txtruc.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtapellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtdireccion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txttelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtemail.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        codigo = DataGridView1.CurrentRow.Cells(5).Value.ToString
        correos = DataGridView1.CurrentRow.Cells(7).Value.ToString
        Try
            Dim frmrcompras As RCompras = CType(Owner, RCompras)
            frmrcompras.txtruc.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            frmrcompras.txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            frmrcompras.txtapellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            frmrcompras.txtdireccion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            frmrcompras.txttelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            frmrcompras.txtcorreo.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class