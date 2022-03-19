Public Class contacto

    Private id As Int16
    Private nombre As String
    Private apellido_p As String
    Private apellido_m As String
    Private rfc As String
    Private clasificacion As String
    Private estatus As String

    Public Function Get_id() As Object
        Return id
    End Function

    Public Sub Set_id(value As Object)
        id = value
    End Sub

    Public Function Get_nombre() As Object
        Return nombre
    End Function

    Public Sub Set_nombre(value As Object)
        nombre = value
    End Sub

    Public Function Get_apellido_p() As Object
        Return apellido_p
    End Function

    Public Sub Set_apellido_p(value As Object)
        apellido_p = value
    End Sub

    Public Function Get_apellido_m() As Object
        Return apellido_m
    End Function

    Public Sub Set_apellido_m(value As Object)
        apellido_m = value
    End Sub

    Public Function Get_rfc() As Object
        Return rfc
    End Function

    Public Sub Set_rfc(value As Object)
        rfc = value
    End Sub

    Public Function Get_clasificacion() As Object
        Return clasificacion
    End Function

    Public Sub Set_clasificacion(value As Object)
        clasificacion = value
    End Sub

    Public Function Get_estatus() As Object
        Return estatus
    End Function

    Public Sub Set_estatus(value As Object)
        estatus = value
    End Sub
End Class
