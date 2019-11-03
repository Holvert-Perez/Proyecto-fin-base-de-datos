Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports comun
Public Class Form1
#Region "jester"
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Login.ActiveForm.Visible = False

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

        'abrir imagen en picture desde almacenamiento
        'ptbusuario.Image = Image.FromFile("C:\Users\Holvert Pérez\Desktop\Proyecto fin base de datos\menu\Imagenes_usuario\usuario1.jpg")

        'poner datos del usuario
        If usuarioactivo.iduser = Nothing OrElse usuarioactivo.iduser = 0 Then
            MessageBox.Show("No se ha iniciado sesión." + vbNewLine + "Por favor intente de nuevo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()

        End If
        'privilegios de usuario
        If usuarioactivo.cargo = "Vendedor" Then
            btnclientes.Visible = False
            btncompras.Visible = False
            btnImprimir.Visible = False
            btnproveedores.Visible = False
            btnproductos.Visible = False
            btnventas.Visible = False
            p1.Visible = False
            p2.Visible = False
            p3.Visible = False
            p4.Visible = False
            p5.Visible = False
            p6.Visible = False
            AbrirFormInPanel(Of RVentas)()
            lblnombre.Text = usuarioactivo.nombre & " " & usuarioactivo.apellido
            lblcargo.Text = usuarioactivo.cargo
        ElseIf usuarioactivo.cargo = "Administrador" Then
            btnclientes.Visible = True
            btncompras.Visible = True
            btnImprimir.Visible = True
            btnproveedores.Visible = True
            btnproductos.Visible = True
            btnventas.Visible = True
            p1.Visible = True
            p2.Visible = True
            p3.Visible = True
            p4.Visible = True
            p5.Visible = True
            p6.Visible = True
            lblnombre.Text = usuarioactivo.nombre & " " & usuarioactivo.apellido
            lblcargo.Text = usuarioactivo.cargo
        End If

    End Sub
    Private mover As Boolean
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        If mover Then
            If e.Button = MouseButtons Then
                Me.Location = Cursor.Position
            End If

        End If

    End Sub

    Private Sub iconce_Click(sender As Object, e As EventArgs) Handles iconce.Click
        Application.Exit()

    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        If SplitContainer1.SplitterDistance = 50 Then
            'SplitContainer1.Panel1Collapsed = False
            SplitContainer1.SplitterDistance = 280
            'panelmenu.Width = 50
            Labelfecha.Visible = False
            'Labelhora.Visible = False
            ToolTip1.Active = True

        Else
            'SplitContainer1.Panel1Collapsed = True
            'panelmenu.Width = 250
            SplitContainer1.SplitterDistance = 50
            Labelfecha.Visible = True
            ToolTip1.Active = False
            'Labelhora.Visible = True
        End If
    End Sub

    Private Sub iconmini_Click(sender As Object, e As EventArgs) Handles iconmini.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Me.Labelhora.Text = Format(Now, "hh:mm tt")
        Labelfecha.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        mover = True
    End Sub

    Private Sub PanelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseUp
        mover = False
    End Sub

#End Region
    Private Sub AbrirFormInPanel(Of miform As {Form, New})()
        Dim fh As Form
        fh = panelcontenedor.Controls.OfType(Of miform)().FirstOrDefault

        If fh Is Nothing Then

            fh = New miform
            fh.TopLevel = False

            'dar formato al formulario
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            fh.BackColor = Color.White

            panelcontenedor.Controls.Add(fh)
            panelcontenedor.Tag = fh
            AddHandler fh.FormClosed, AddressOf Me.cerrarform
            fh.Show()
            fh.BringToFront()

        Else
            fh.BringToFront()
        End If
    End Sub



    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        AbrirFormInPanel(Of Productos)()
        btnproductos.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        AbrirFormInPanel(Of Clientes)()
        btnclientes.BackColor = Color.FromArgb(12, 61, 92)

    End Sub

    Private Sub cerrarform(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("Productos") Is Nothing) Then
            btnproductos.BackColor = Color.FromArgb(0, 122, 204)
        End If
        If (Application.OpenForms("Clientes") Is Nothing) Then
            btnclientes.BackColor = Color.FromArgb(0, 122, 204)
        End If
        If (Application.OpenForms("Proveedores") Is Nothing) Then
            btnproveedores.BackColor = Color.FromArgb(0, 122, 204)
        End If
        If (Application.OpenForms("Ventas") Is Nothing) Then
            btnventas.BackColor = Color.FromArgb(0, 122, 204)
        End If
        If (Application.OpenForms("Compras") Is Nothing) Then
            btncompras.BackColor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Private Sub btnproveedores_Click(sender As Object, e As EventArgs) Handles btnproveedores.Click
        AbrirFormInPanel(Of Proveedores)()
        btnproveedores.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click
        AbrirFormInPanel(Of RVentas)()
        btnventas.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btncompras_Click(sender As Object, e As EventArgs) Handles btncompras.Click
        AbrirFormInPanel(Of RCompras)()
        btncompras.BackColor = Color.FromArgb(12, 61, 92)

    End Sub


    Private Sub iconce_MouseEnter(sender As Object, e As EventArgs) Handles iconce.MouseEnter
        If iconce.Width = 18 And iconce.Height = 18 Then

            iconce.Height = 20
            iconce.Width = 20

        End If

    End Sub

    Private Sub iconce_MouseLeave(sender As Object, e As EventArgs) Handles iconce.MouseLeave
        If iconce.Width = 20 And iconce.Height = 20 Then

            iconce.Height = 18
            iconce.Width = 18

        End If
    End Sub

    Private Sub iconmini_MouseEnter(sender As Object, e As EventArgs) Handles iconmini.MouseEnter
        If iconmini.Width = 18 And iconmini.Height = 18 Then

            iconmini.Height = 20
            iconmini.Width = 20

        End If
    End Sub

    Private Sub iconmini_MouseLeave(sender As Object, e As EventArgs) Handles iconmini.MouseLeave
        If iconmini.Width = 20 And iconmini.Height = 20 Then

            iconmini.Height = 18
            iconmini.Width = 18

        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim x As Reportes
        AbrirFormInPanel(Of Reportes)()
        btnImprimir.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnsalir_Click_1(sender As Object, e As EventArgs) Handles btnsalir.Click
        usuarioactivo.cargo = ""
        usuarioactivo.apellido = ""
        usuarioactivo.iduser = ""
        usuarioactivo.nombre = ""
        Me.Close()
    End Sub

End Class
