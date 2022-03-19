Public Class cliente
    Private id_contacto As Int16
    Private credito As Double
    Private saldo As Double
    Private estatus As String


    Public Property _id_contacto
        Get
            Return id_contacto
        End Get
        Set(value)
            id_contacto = value
        End Set
    End Property

    Public Property _credito
        Get
            Return credito
        End Get
        Set(value)
            credito = value
        End Set
    End Property

    Public Property _saldo
        Get
            Return saldo
        End Get
        Set(value)
            saldo = value
        End Set
    End Property

    Public Property _estatus
        Get
            Return estatus
        End Get
        Set(value)
            estatus = value
        End Set
    End Property



End Class
