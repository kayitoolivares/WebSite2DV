Public Class empleado
	Private id_contacto As Int16
	Private curp As String
    Private fecha_nacimiento As String
    Private puesto As String
    Private estatus As String


    Public Property _id_contacto
        Get
            Return id_contacto
        End Get
        Set(value)
            id_contacto = value
        End Set
    End Property
    Public Property _curp
        Get
            Return curp
        End Get
        Set(value)
            curp = value
        End Set
    End Property
    Public Property _fecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
        End Set
    End Property
    Public Property _puesto
        Get
            Return puesto
        End Get
        Set(value)
            puesto = value
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
