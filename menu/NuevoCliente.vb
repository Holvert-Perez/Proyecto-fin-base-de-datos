Imports Datos
Public Class NuevoCliente
    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles Btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        Dim Agregartblclientes As New guardarclientes
        Dim Agregartblclientestelefono As New guardarclientes
        Dim Agregartbltelefono As New guardarclientes

        If Agregartblclientes.agregar_tblclientes(txtcedula.Text, txtnombre.Text, txtapellido.Text, txtdirecion.Text) Then
            If Agregartbltelefono.agregar_tbltelefonos(txttelefono.Text) Then
                If Agregartblclientestelefono.agregar_tblclientes_telefono(txtcedula.Text) Then

                    MessageBox.Show("Guardado Exitosamente")
                    Me.Close()

                Else
                    MessageBox.Show("ha ocurrido un error al agregar el Genero")

                End If
            End If
        End If


    End Sub
End Class