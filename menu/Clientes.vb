Imports Datos
Imports MySql.Data.MySqlClient
Public Class Clientes
    Dim cedula As String
    Dim codigo As String
    Dim codigo_correo As String
    Sub llenar_datosclientes()
        Try
            Dim llenar_grid As New llenarDatagrid
            Dim sql As String = ("SELECT clientes_credito.cedula,nombre,apellido,direccion,numero_telefono,telefonos.codigo_telefono,direccion_correo, clientes_correo.codigo_correo FROM clientes_credito, clientes_credito_telefono,telefonos,correos,clientes_correo
                                WHERE clientes_credito.cedula=clientes_credito_telefono.cedula
                                AND telefonos.codigo_telefono=clientes_credito_telefono.codigo_telefono
																AND clientes_credito.cedula=clientes_correo.cedula
																AND clientes_correo.codigo_correo=correos.codigo_correo
								                ORDER BY nombre;")

            DataGridView1.DataSource = llenar_grid.llenar_datagridview(sql).Tables("consulta").DefaultView
        Catch ex As mysqlException
            MessageBox.Show("hjfgehgfehgd")
        End Try


    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As String = ""
        txtcedula.Mask = ("###-######-####>L")
        llenar_datosclientes()
        BackColor = Color.FromArgb(62, 62, 64)
        'DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 64)
        'DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        DataGridView1.BackgroundColor = Color.FromArgb(62, 62, 64)



        DataGridView1.EnableHeadersVisualStyles = False
        'DataGridView1.EnableHeadersVisualStyles = False
        'DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 201, 176)
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        DataGridView1.Columns(0).HeaderText = "Cédula"
        DataGridView1.Columns(1).HeaderText = "Nombre"
        DataGridView1.Columns(2).HeaderText = "Apellidos"
        DataGridView1.Columns(3).HeaderText = "Dirección"
        DataGridView1.Columns(4).HeaderText = "Número de teléfono"
        DataGridView1.Columns(6).HeaderText = "E-mail"
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.ClearSelection()

    End Sub


    'Private Sub btneditarclientes_Click(sender As Object, e As EventArgs)
    '    Dim ec As New Editarclientes

    '    ec.txtcedula.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    '    ec.txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
    '    ec.txtapellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
    '    ec.txtdirecion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
    '    ec.txttelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    '    ec.ShowDialog(Editarclientes)


    'End Sub

    'Private Sub btnnuevocliente_Click(sender As Object, e As EventArgs)
    '    Dim ec As New NuevoCliente
    '    ec.ShowDialog()
    'End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        '  txtcedula2.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtcedula.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtapellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtdireccion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txttelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtemail.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        codigo = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        codigo_correo = DataGridView1.CurrentRow.Cells(7).Value.ToString()

        Try
            Dim frmrventas As RVentas = CType(Owner, RVentas)
            frmrventas.txtcedulaventas.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            frmrventas.txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            frmrventas.txtapellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            frmrventas.txtdireccion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            frmrventas.txttelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            frmrventas.txtcorreo.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Dim borrar As New llenarDatagrid
        Dim cliente As New identificarClienteConDeuda
        Dim cedula As String
        cedula = cliente.cliente_deuda(DataGridView1.CurrentRow.Cells(0).Value)
        If cedula = DataGridView1.CurrentRow.Cells(0).Value Then
            txtnombre.Text = ""
            txttelefono.Text = ""
            txtdireccion.Text = ""
            txtapellido.Text = ""
            txtcedula.Text = ""
            txtemail.Text = ""
            MessageBox.Show("El cliente seleccionado posee una deuda pendiente.", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MsgBox("Desea Eliminar el cliente: " & txtnombre.Text & " " & txtapellido.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "") = MsgBoxResult.Yes Then

                borrar.borrar_clientes_telefono(DataGridView1.CurrentRow.Cells(0).Value)
                borrar.borrar_telefono(DataGridView1.CurrentRow.Cells(5).Value)
                borrar.borrar_clientescorreo(DataGridView1.CurrentRow.Cells(0).Value)
                borrar.borrar_correo(DataGridView1.CurrentRow.Cells(7).Value)
                borrar.borrar_cliente(DataGridView1.CurrentRow.Cells(0).Value)

                txtnombre.Text = ""
                txttelefono.Text = ""
                txtdireccion.Text = ""
                txtapellido.Text = ""
                txtcedula.Text = ""
                llenar_datosclientes()

            End If
        End If
    End Sub

    Private Sub btnnuevocliente_Click(sender As Object, e As EventArgs) Handles btnnuevocliente.Click
        Dim Agregartblclientes As New guardarclientes
        Dim Agregartblclientestelefono As New guardarclientes
        Dim Agregartbltelefono As New guardarclientes
        Dim Agregartblcorreo As New guardarclientes
        Dim Agregartblclientescorreo As New guardarclientes
        Dim cont As Integer = txttelefono.TextLength

        If txtapellido.Text = "" And txtcedula.Text = "" And txtdireccion.Text = "" And txtnombre.Text = "" Then
            MessageBox.Show("Por favor llenar todos los datos obligatorios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Agregartblclientes.agregar_tblclientes(txtcedula.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text) Then
                If Agregartbltelefono.agregar_tbltelefonos(txttelefono.Text) Then
                    If Agregartblclientestelefono.agregar_tblclientes_telefono(txtcedula.Text) And cont >= 8 Then
                        If Agregartblcorreo.agregar_correos(txtemail.Text) Then
                            If Agregartblclientescorreo.agregar_clientes_correo(txtcedula.Text) Then

                                txtnombre.Text = ""
                                txttelefono.Text = ""
                                txtdireccion.Text = ""
                                txtapellido.Text = ""
                                txtcedula.Text = ""
                                txtemail.Text = ""
                                llenar_datosclientes()
                                MessageBox.Show("Guardado Exitosamente")

                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editarcliente As New editar_clientes
        If txtapellido.Text = "" And txtdireccion.Text = "" And txtcedula.Text = "" And txtnombre.Text = "" And txttelefono.Text = "" Then
            MessageBox.Show("No ha selecionado ningun cliente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If editarcliente.editar_tblclientes(txtcedula.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text, codigo, txttelefono.Text, txtemail.Text, codigo_correo) Then
                MessageBox.Show("Modificacion Exitosa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnombre.Text = ""
                txttelefono.Text = ""
                txtdireccion.Text = ""
                txtapellido.Text = ""
                txtcedula.Text = ""
                txtemail.Text = ""
                llenar_datosclientes()
            End If
        End If
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

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
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

End Class