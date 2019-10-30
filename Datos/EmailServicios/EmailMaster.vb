Imports System.Net
Imports System.Net.Mail
Public MustInherit Class EmailMaster

    Private SMTPcliente As SmtpClient
    Protected EmailEnvio As String
    Protected password As String
    Protected host As String
    Protected port As Integer
    Protected ssl As Boolean

    Protected Sub iniciarSMTPcliente()
        SMTPcliente = New SmtpClient
        SMTPcliente.Credentials = New NetworkCredential(EmailEnvio, password)
        SMTPcliente.Host = host
        SMTPcliente.Port = port
        SMTPcliente.EnableSsl = ssl
    End Sub

    'Método para enviar los mensajes de correo electrónico a uno o varios destinatarios'
    Public Sub sendMail(ByVal subject As String, ByVal body As String, ByVal receiverMail As List(Of String))
        Dim mailMessage As MailMessage = New MailMessage
        Try
            mailMessage.From = New MailAddress(EmailEnvio)
            For Each mail As String In receiverMail
                mailMessage.To.Add(mail)
            Next
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.Priority = MailPriority.Normal
            SMTPcliente.Send(mailMessage)
        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            SMTPcliente.Dispose()
        End Try
    End Sub
End Class
