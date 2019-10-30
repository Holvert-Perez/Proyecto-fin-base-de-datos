Public Class SoporteSistema
    Inherits EmailMaster

    Public Sub New()
        EmailEnvio = "soporte.pulperia@gmail.com"
        password = "Soporte2020"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        iniciarSMTPcliente()
    End Sub

End Class
