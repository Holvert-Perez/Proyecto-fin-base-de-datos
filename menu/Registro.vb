Imports System.Runtime.InteropServices
Imports Datos
Public Class Registro
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
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

    Private Sub Registro_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()

        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

#End Region

#Region "Validar textbox"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim agregar As New clsusuario

        'If Me.va Then
        'agregar.agregar_usuario(txtnuser.Text, txtpass.Text, txtnombre.Text, txtapellido.Text, txtemail.Text, cbbcargo.Text)
        '    MessageBox.Show("Usuario Agregado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        Try
            If Me.ValidateChildren And txtnuser.Text <> String.Empty And txtnombre.Text <> String.Empty And txtpass.Text <> String.Empty And txtemail.Text <> String.Empty And txtapellido.Text <> String.Empty And cbbcargo.Text <> String.Empty Then
                agregar.agregar_usuario(txtnuser.Text, txtpass.Text, txtnombre.Text, txtapellido.Text, txtemail.Text, cbbcargo.Text)
                MessageBox.Show("Datos ingresados correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(" Revise al gunos datos remarcados", "Datos del usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)



            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtnuser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnuser.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese los datos este campo es obligatorio")
        End If
    End Sub

    Private Sub txtpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpass.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese los datos este campo es obligatorio")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese los datos este campo es obligatorio")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese los datos este campo es obligatorio")
        End If
    End Sub

    Private Sub txtemail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtemail.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese los datos este campo es obligatorio")
        End If
    End Sub

    Private Sub cbbcargo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbbcargo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese los datos este campo es obligatorio")
        End If
    End Sub



#End Region

#Region "Tooltip"


#End Region
End Class