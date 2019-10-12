Imports CrystalDecisions.CrystalReports.Engine
Imports Datos

Public Class Reportes
    Sub ReportVentas()
        Dim codigo As New clsObtenerCodigoVenta
        Dim CrearR As New CLSfactura("Factura", codigo.codigo_venta)
        CrearR.crearXML("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Reportes\")

        Dim RD As ReportDocument = New RPFacturaV
        Dim DT As DataTable = CrearR.obtenerDataTable

        RD.SetDataSource(DT)

        For Each sr As ReportDocument In RD.Subreports
            If sr.Database.Tables.Count > 0 Then
                sr.SetDataSource(DT)
            End If
        Next

        Me.CrystalReportViewer1.ReportSource = RD

    End Sub
    Sub facturacontado()
        Dim codigo As New clsObtenerCodigoVenta
        Dim CrearR As New FacturaContado("factura_contado", codigo.codigo_ventacont)
        CrearR.crearXML("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Reportes\")

        Dim RD As ReportDocument = New rptfacturacontado
        Dim DT As DataTable = CrearR.obtenerDataTable()

        RD.SetDataSource(DT)

        For Each sr As ReportDocument In RD.Subreports
            If sr.Database.Tables.Count > 0 Then
                sr.SetDataSource(DT)
            End If
        Next

        Me.CrystalReportViewer1.ReportSource = RD

    End Sub

    Sub ReportCompras()
        Dim CrearR As New CLSFacturaC("Vista_Factura_C")
        CrearR.crearXML("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Reportes\")

        Dim RD As ReportDocument = New RPTFacturaC
        Dim DT As DataTable = CrearR.obtenerDataTable

        RD.SetDataSource(DT)

        For Each sr As ReportDocument In RD.Subreports
            If sr.Database.Tables.Count > 0 Then
                sr.SetDataSource(DT)
            End If
        Next

        Me.CrystalReportViewer1.ReportSource = RD

    End Sub


    Sub reportClientes()
        Dim CrearR As New CLSReportes("clientes_credito")
        CrearR.crearXML("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Reportes\")

        Dim RD As ReportDocument = New RPTClientes
        Dim DT As DataTable = CrearR.obtenerDataTable

        RD.SetDataSource(DT)

        For Each sr As ReportDocument In RD.Subreports
            If sr.Database.Tables.Count > 0 Then
                sr.SetDataSource(DT)
            End If
        Next

        Me.CrystalReportViewer1.ReportSource = RD
    End Sub
    Sub reportProveedores()
        Dim CrearR As New CLSReportes("proveedores")
        CrearR.crearXML("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Reportes\")

        Dim RD As ReportDocument = New RPTProveedores
        Dim DT As DataTable = CrearR.obtenerDataTable

        RD.SetDataSource(DT)

        For Each sr As ReportDocument In RD.Subreports
            If sr.Database.Tables.Count > 0 Then
                sr.SetDataSource(DT)
            End If
        Next

        Me.CrystalReportViewer1.ReportSource = RD

    End Sub

    Sub Seleccionar()
        txt.Visible = True
        If ComboBox1.Text = "Clientes" Then
            reportClientes()
            txt.Visible = False
        ElseIf ComboBox1.Text = "Proveedores" Then
            reportProveedores()
            txt.Visible = False
        ElseIf ComboBox1.Text = "Ventas" Then
            ReporteVentas()
            txt.Visible = False
            If ComboBox1.Text = "" Then
                txt.Visible = True
                MessageBox.Show("Seleccione un reporte a Imprimir")
            End If
        End If

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ReportVentas()
        ' ReportCompras()

    End Sub

    Sub ReporteVentas()
        Dim CrearR As New CLSReportes("ReporteVentas")
        CrearR.crearXML("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Reportes\")

        Dim RD As ReportDocument = New rptventas
        Dim DT As DataTable = CrearR.obtenerDataTable

        RD.SetDataSource(DT)

        For Each sr As ReportDocument In RD.Subreports
            If sr.Database.Tables.Count > 0 Then
                sr.SetDataSource(DT)
            End If
        Next

        Me.CrystalReportViewer1.ReportSource = RD

    End Sub
End Class