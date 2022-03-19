Public Class contacto

    Private id As Int16
    Private nombre As String
    Private apellido_p As String
    Private apellido_m As String
    Private rfc As String
    Private clasificacion As String
    Private estatus As String

    Public Property _id
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property _nombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property _apellido_p
        Get
            Return apellido_p
        End Get
        Set(value)
            apellido_p = value
        End Set
    End Property

    Public Property _apellido_m
        Get
            Return apellido_m
        End Get
        Set(value)
            apellido_m = value
        End Set
    End Property

    Public Property _rfc
        Get
            Return rfc
        End Get
        Set(value)
            rfc = value
        End Set
    End Property

    Public Property _clasificacion
        Get
            Return clasificacion
        End Get
        Set(value)
            clasificacion = value
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
