Imports System.Windows.Forms
Imports Datos
Public Class Login

    Sub buscarusuario()
        Dim x As New Datos.CLSusuario
        Dim y As Integer

        y = x.Agregar(txtuser.Text, txtcon.Text)
        If y = 0 Then
            MessageBox.Show("Usuario Incorrecto")
            Link.Visible = True
            Label2.Visible = True
        Else
            Form1.Show()
            'Close()

        End If


    End Sub

    Sub Primer_inicio()
        'verificar si exixte almenos uno
        Dim verificar As New CLSusuario
        If verificar.verificar_existe Then
            MessageBox.Show("Existe almenos 1")
        End If


    End Sub

    Private Sub txtuser_Enter(sender As Object, e As EventArgs) Handles txtuser.Enter
        If txtuser.Text = "USUARIO" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtuser_Leave(sender As Object, e As EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "USUARIO"
            txtuser.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub txtcon_Enter(sender As Object, e As EventArgs) Handles txtcon.Enter

        If txtcon.Text = "CONTRASEÑA" Then
            txtcon.Text = ""
            txtcon.ForeColor = Color.LightGray
            txtcon.UseSystemPasswordChar = True
        End If

    End Sub
    Private Sub txtcon_Leave(sender As Object, e As EventArgs) Handles txtcon.Leave

        If txtcon.Text = "" Then
            txtcon.Text = "CONTRASEÑA"
            txtcon.ForeColor = Color.DimGray
            txtcon.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnmini_Click(sender As Object, e As EventArgs) Handles btnmini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub acceder_Click(sender As Object, e As EventArgs) Handles acceder.Click
        '  .......................................................................................
        'If txtuser.Text = "Jester" And txtcon.Text = "2018" Then
        '    MessageBox.Show("Te damos la Bienvenida: " & txtuser.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Application.EnableVisualStyles()
        '    Dim loginform As New Form1
        '    loginform.ShowDialog()
        '    Dim resul As DialogResult
        '    resul = loginform.DialogResult
        '    If resul = DialogResult.OK Then
        '        Dim loform As New Form1
        '        Application.Run(loform)
        '    End If
        'Else
        '    MessageBox.Show("No ha sido posible acceder, Intentelo de Nuevo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End If
        '..........................................................................................
        buscarusuario()
        '  agregar_nuevo_usuario()
        If txtcon.Text = "" Then
            Label2.Visible = True
        End If
    End Sub
    Sub agregar_nuevo_usuario()

        Dim agregaruser As New CLSusuario
        If validar_clave(txtcon.Text) Then
            agregaruser.agregar_usuario(txtuser.Text, txtcon.Text)
            MessageBox.Show("Agregado Correctamente")

        Else

            MessageBox.Show("Error... La clave no cumple los requisitos")
            Label2.Visible = True
        End If

    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Primer_inicio()

    End Sub

    Private Sub txtcon_TextChanged(sender As Object, e As EventArgs) Handles txtcon.TextChanged
        If txtcon.Text = "" Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    Private Sub Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link.LinkClicked
        Dim agregaruser As New CLSusuario
        If validar_clave(txtcon.Text) Then
            agregaruser.agregar_usuario(txtuser.Text, txtcon.Text)
            MessageBox.Show("Agregado Correctamente")

            Link.Visible = False
        Else

            MessageBox.Show("Error... La clave no cumple los requisitos")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtcon.UseSystemPasswordChar = False
            txtcon.Text = txtcon.Text
        Else
            txtcon.UseSystemPasswordChar = True
            'txtcon.Text = ""
        End If

    End Sub


End Class