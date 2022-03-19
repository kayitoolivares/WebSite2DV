Public Class usuario
    Private nick As String
    Private contrasenia As String
    Private id_contacto As Int16
    Private estatus As String



    Public Property _nick
        Get
            Return nick
        End Get
        Set(value)
            nick = value
        End Set
    End Property

    Public Property _contrasenia
        Get
            Return contrasenia
        End Get
        Set(value)
            contrasenia = value
        End Set
    End Property

    Public Property _id_contacto
        Get
            Return id_contacto
        End Get
        Set(value)
            id_contacto = value
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
