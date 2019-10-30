Imports System.Runtime.InteropServices
Imports Datos
Public Class Inicio_de_sesion
#Region "Botones cerrar-minimizar"
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "mover form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub ptitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles ptitulo.MouseMove
        ReleaseCapture()

        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Inicio_de_sesion_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()

        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "Apariencias"

    Private Sub CustomizeComponents()
        'txtUsername cambiar tamaño
        txtuser.AutoSize = False
        txtuser.Size = New Size(350, 30)
        'txtPassword cambiar tamaño
        txtpass.AutoSize = False
        txtpass.Size = New Size(350, 30)
        txtpass.UseSystemPasswordChar = True
    End Sub

    Private Sub Inicio_de_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
    End Sub
    'borde redondeado del boton login
    Private Sub btnlogin_Paint(sender As Object, e As PaintEventArgs) Handles btnlogin.Paint

        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnlogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnlogin.Region = New Region(buttonPath)
    End Sub
    'borde redondeado del boton registrar
    Private Sub btnagregar_Paint(sender As Object, e As PaintEventArgs) Handles btnagregar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnagregar.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnagregar.Region = New Region(buttonPath)
    End Sub

    'Mostrar pass
    Private Sub ckbmostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbmostrar.CheckedChanged
        If ckbmostrar.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Link_MouseEnter(sender As Object, e As EventArgs) Handles Link.MouseEnter
        Link.LinkColor = Color.DodgerBlue
    End Sub
    Private Sub Link_MouseLeave(sender As Object, e As EventArgs) Handles Link.MouseLeave
        Link.LinkColor = Color.Silver
    End Sub


#End Region
#Region "conexion"
    Sub buscarusuario()
        Dim x As New clsusuario
        Dim y As Integer

        y = x.Obtener_usuario(txtuser.Text, txtpass.Text)
        If y = 0 Then
            MessageBox.Show("Usuario o Contraseña incorrectos." + vbNewLine + "Por favor intente de nuevo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Hide()
            Primer_inicio()
            Dim frmbienvenida As New FormularioBienvenida

            frmbienvenida.ShowDialog()
            Dim frm As New Form1


            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.logout

        End If


    End Sub

    Sub Primer_inicio()
        'verificar si exixte almenos uno
        Dim verificar As New clsusuario
        verificar.verificar_existe(txtpass.Text, txtuser.Text)



    End Sub
    Private Sub logout(sender As Object, e As FormClosedEventArgs)
        txtuser.Clear()
        txtpass.Clear()
        Me.Show()
        txtuser.Focus()
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        buscarusuario()
    End Sub

    Private Sub Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link.LinkClicked
        Dim frmrecuperar As New RecuperacionPass
        Me.Hide()
        frmrecuperar.ShowDialog()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Registro.ShowDialog()
    End Sub





#End Region
End Class