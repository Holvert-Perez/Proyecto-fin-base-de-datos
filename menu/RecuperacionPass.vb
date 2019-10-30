Imports Datos
Public Class RecuperacionPass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userModel As New clsusuario
        Dim inicio As New Inicio_de_sesion
        Dim result = userModel.recoverPassword(txtrecuperacion.Text)
        Me.Hide()

        If MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            inicio.Show()
            Me.Close()
        End If
    End Sub
End Class