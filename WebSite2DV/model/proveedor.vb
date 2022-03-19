Public Class proveedor

    Private id_contacto As Int16
    Private dias As String
    Private estatus As String


    Public Property _id_contacto
        Get
            Return id_contacto
        End Get
        Set(value)
            id_contacto = value
        End Set
    End Property

    Public Property _dias
        Get
            Return dias
        End Get
        Set(value)
            dias = value
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
