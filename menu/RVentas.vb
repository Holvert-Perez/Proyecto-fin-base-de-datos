Imports Datos

Public Class RVentas
    Dim cedulas As String
    Sub llenar_ventas()
        Dim llenar_grid As New llenarDatagrid
        Dim sql As String = ("SELECT * from ventas;")
        DataGridView1.DataSource = llenar_grid.llenar_datagridview(sql).Tables("consulta").DefaultView
    End Sub
    Sub ID_Ventas()
        Dim rdn As New Random(Guid.NewGuid().GetHashCode())
        txtid.Text = Convert.ToString(rdn.Next(0, 100000))

    End Sub
    Sub llenarcmb_producto()
        Dim llenar As New Datos.llenar_combo
        Dim sql As String = "SELECT codigo_producto,descripcion from producto WHERE cantidad_existente>0;"

        cbmproducto.DataSource = llenar.LlenarCmb(sql)
        cbmproducto.DisplayMember = "Descripcion"
        cbmproducto.ValueMember = "codigo_producto"
        cbmproducto.Text = ""
    End Sub

    Sub llenarcmb_tipoventa()
        Dim llenar As New Datos.llenar_combo
        Dim sql As String = "SELECT codigo_tipoventa,tipo from tipo_venta;"

        cbbtipoventa.DataSource = llenar.LlenarCmb(sql)
        cbbtipoventa.DisplayMember = "tipo"
        cbbtipoventa.ValueMember = "codigo_tipoventa"
        cbbtipoventa.Text = ""
    End Sub

    Private Sub RVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID_Ventas()
        llenarcmb_producto()
        llenarcmb_tipoventa()
        DataGridView1.Columns(0).Visible = False
        txtsubtotal.Text = 0
        txtprecio.Text = 0
        txttotalventa.Text = 0
        GroupBox3.Visible = False
        DataGridView1.Columns(5).Name = "Eliminar"

    End Sub
    'Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting

    '    If e.ColumnIndex >= 0 AndAlso Me.DataGridView1.Columns(e.ColumnIndex).Name = "Eliminar" AndAlso e.RowIndex >= 0 Then
    '        e.Paint(e.CellBounds, DataGridViewPaintParts.All)
    '        '    Dim celBoton As DataGridViewButtonCell = TryCast(Me.DataGridView1.Rows(e.RowIndex).Cells("Eliminar"), DataGridViewButtonCell)
    '        Dim icoAtomico As Icon = New Icon(Environment.CurrentDirectory & "\\Delete.ico")
    '        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left - 100, e.CellBounds.Top - 100)
    '        Me.DataGridView1.Rows(e.RowIndex).Height = icoAtomico.Height - 10
    '        Me.DataGridView1.Columns(e.ColumnIndex).Width = icoAtomico.Width - 10
    '        '    e.Handled = True
    '    End If

    'End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If Me.DataGridView1.Columns(5).Name = "Eliminar" Then

                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim totalventa As Integer
        Dim existencias As String
        Dim obtener As New clseditarproducto

        If cbbtipoventa.Text = "" Then
            MessageBox.Show("Seleccionar tipo de venta.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cbbtipoventa.Text = "Contado" Then
                If txtsubtotal.Text = 0 Then
                    MessageBox.Show("Verifique que sus datos sean correctos", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    For a As Integer = 0 To 1 - 1
                        existencias = (obtener.obtener_existencia(cbmproducto.SelectedValue))
                        If existencias < numericcantidad.Value Then
                            MessageBox.Show("Solo posee: " & existencias & " cantidades de este producto.", "Producto " & cbmproducto.Text & " insuficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            DataGridView1.Rows.Add()
                            Dim x As Integer = DataGridView1.Rows.Count
                            DataGridView1.Rows(x - 2).Cells(0).Value = cbmproducto.SelectedValue
                            DataGridView1.Rows(x - 2).Cells(1).Value = cbmproducto.Text
                            DataGridView1.Rows(x - 2).Cells(2).Value = numericcantidad.Value
                            DataGridView1.Rows(x - 2).Cells(3).Value = txtprecio.Text
                            DataGridView1.Rows(x - 2).Cells(4).Value = txtsubtotal.Text
                            DataGridView1.Rows(x - 2).Cells(5).Value = "Eliminar"
                            numericcantidad.Value = 0

                            For i As Integer = 0 To x - 2
                                totalventa = DataGridView1.Rows(i).Cells(4).Value

                            Next
                        End If
                    Next
                    txttotalventa.Text += totalventa
                End If
            Else
                If txtcedulaventas.Text = "" Then
                    MessageBox.Show("No se ha selecionado el cliente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If txtsubtotal.Text = 0 Then
                        MessageBox.Show("Verifique que sus datos sean correctos", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        For a As Integer = 0 To 1 - 1
                            existencias = (obtener.obtener_existencia(cbmproducto.SelectedValue))
                            If existencias < numericcantidad.Value Then
                                MessageBox.Show("Solo posee: " & existencias & " cantidades de este producto.", "Producto " & cbmproducto.Text & " insuficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                DataGridView1.Rows.Add()
                                Dim x As Integer = DataGridView1.Rows.Count
                                DataGridView1.Rows(x - 2).Cells(0).Value = cbmproducto.SelectedValue
                                DataGridView1.Rows(x - 2).Cells(1).Value = cbmproducto.Text
                                DataGridView1.Rows(x - 2).Cells(2).Value = numericcantidad.Value
                                DataGridView1.Rows(x - 2).Cells(3).Value = txtprecio.Text
                                DataGridView1.Rows(x - 2).Cells(4).Value = txtsubtotal.Text
                                numericcantidad.Value = 0

                                For i As Integer = 0 To x - 2
                                    totalventa = DataGridView1.Rows(i).Cells(4).Value
                                Next
                            End If
                        Next
                        txttotalventa.Text += totalventa
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnmostrarclientes_Click(sender As Object, e As EventArgs) Handles btnmostrarclientes.Click
        Dim datos As New Clientes
        AddOwnedForm(datos)
        datos.ShowDialog()


    End Sub



    Sub mostrar_precio()
        Dim mostrarprecio As New llenar_combo

        txtprecio.Text = mostrarprecio.llenarprecio(cbmproducto.SelectedValue)
    End Sub

    Private Sub cbmproducto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbmproducto.SelectionChangeCommitted
        mostrar_precio()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Dim factura As New Reportes
        Dim agregartblventas As New clsnuevaventa
        Dim agregartbltipoventa As New clsnuevaventa
        Dim agregartbldetallesventas As New clsnuevaventa
        Dim agregartblventasclientes As New clsnuevaventa
        Dim fecha_pago As Date
        Dim x As String
        Dim obtener As New clseditarproducto
        Dim existencias As String
        'fecha_pago = Date.Now.AddDays(15)
        'x = Format(fecha_pago, "yyyy-MM-dd")
        'MessageBox.Show(x & " 06:00:00")

        Dim cfilas As Integer = DataGridView1.RowCount
        If txttotalventa.Text = 0 Then
            MessageBox.Show(" Agregue al menos un producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cbbtipoventa.Text = "Credito" Then
                dtpfecha.Value = Now
                fecha_pago = dtpfecha.Value.Now.AddDays(15)
                x = Format(fecha_pago, "yyyy-MM-dd")
                If agregartblventas.agregar_tblventas(dtpfecha.Value.ToString("yyyy-MM-dd HH:mm:ss"), txttotalventa.Text, x & " 06:00:00") Then
                    If agregartblventasclientes.agregar_tblventasclientes(txtcedulaventas.Text) Then
                        If agregartbltipoventa.agregar_tbltipoventa(cbbtipoventa.SelectedValue) Then
                            For i As Integer = 0 To cfilas - 2
                                agregartbldetallesventas.agregar_tbldetallesventa(DataGridView1.Rows(i).Cells(4).Value, DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(2).Value)

                                existencias = (obtener.obtener_existencia(DataGridView1.Rows(i).Cells(0).Value))
                                'If existencias = DataGridView1.Rows(i).Cells(0).Value Then
                                '    MessageBox.Show("Solo posee: " & existencias & " cantidades de este producto.", "Producto" & DataGridView1.Rows(i).Cells(1).Value & " insuficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                '    Exit Sub
                                existencias -= DataGridView1.Rows(i).Cells(2).Value
                                    obtener.Agregar_existencias(existencias, DataGridView1.Rows(i).Cells(1).Value)
                                'End If
                            Next
                            MessageBox.Show("Guardado Exitosamente")
                            If MsgBox("Desea imprimir factura?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                                factura.ComboBox1.Visible = False
                                factura.txt.Visible = False

                                factura.ReportVentas()
                                    factura.Show()

                                End If

                                Me.Show()
                        Else
                            MessageBox.Show("Error al registrar venta")
                        End If
                    End If
                End If
            Else
                dtpfecha.Value = Now
                fecha_pago = dtpfecha.Value.Now.AddDays(15)
                x = Format(fecha_pago, "yyyy-MM-dd")
                If agregartblventas.agregar_tblventas(dtpfecha.Value.ToString("yyyy-MM-dd HH:mm:ss"), txttotalventa.Text, x & " 06:00:00") Then

                    If agregartbltipoventa.agregar_tbltipoventa(cbbtipoventa.SelectedValue) Then
                        For i As Integer = 0 To cfilas - 2
                            agregartbldetallesventas.agregar_tbldetallesventa(DataGridView1.Rows(i).Cells(4).Value, DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(2).Value)
                            existencias = (obtener.obtener_existencia(DataGridView1.Rows(i).Cells(0).Value))
                            'If existencias = DataGridView1.Rows(i).Cells(0).Value Then
                            '    MessageBox.Show("Solo posee: " & existencias & " cantidades de este producto.", "Producto" & DataGridView1.Rows(i).Cells(1).Value & " insuficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '    Exit Sub
                            'Else
                            existencias -= DataGridView1.Rows(i).Cells(2).Value
                                obtener.Agregar_existencias(existencias, DataGridView1.Rows(i).Cells(1).Value)

                            'End If

                        Next

                        MessageBox.Show("Guardado Exitosamente")
                        If MsgBox("Desea imprimir factura?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                            factura.ComboBox1.Visible = False
                            factura.txt.Visible = False
                            factura.facturacontado()
                            factura.Show()
                        End If
                        Me.Show()
                    Else
                        MessageBox.Show("Error al registrar venta")

                    End If
            End If
            End If
        End If
    End Sub

    Private Sub numericcantidad_ValueChanged(sender As Object, e As EventArgs) Handles numericcantidad.ValueChanged
        txtsubtotal.Text = (Val(txtprecio.Text) * numericcantidad.Value)
    End Sub


    Private Sub cbbtipoventa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbtipoventa.SelectedValueChanged
        If cbbtipoventa.Text = "Credito" Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbbtipoventa.Text = ""
        cbmproducto.Text = ""
        ID_Ventas()
        txttotalventa.Text = 0
        numericcantidad.Value = 0
        txtprecio.Text = 0
        txtsubtotal.Text = 0
        txtcedulaventas.Text = ""
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txtapellido.Text = ""
        txttelefono.Text = ""
        txtcorreo.Text = ""
        GroupBox3.Visible = False

    End Sub

    Private Sub numericcantidad_Click(sender As Object, e As EventArgs) Handles numericcantidad.Click
        If txtprecio.Text = 0 Then
            'txtsubtotal.Text = (Val(txtprecio.Text) * numericcantidad.Value)
            numericcantidad.Value = 0
            MessageBox.Show("Agregue el producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub cbmproducto_Click(sender As Object, e As EventArgs) Handles cbmproducto.Click
        llenarcmb_producto()
    End Sub

End Class