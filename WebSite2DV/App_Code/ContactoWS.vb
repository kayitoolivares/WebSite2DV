Imports System.Data
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://localhost:51647/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class ContactoWS
    Inherits System.Web.Services.WebService

    Dim Cc As New CContacto
    Dim Mc As New contacto

    <WebMethod()>
    Public Function insertar(nombre As String, apellido_p As String, apellido_m As String, rfc As String, clasificacion As String, estatus As String) As String

        Mc.Set_nombre(nombre)
        Mc.Set_apellido_p(apellido_p)
        Mc.Set_apellido_m(apellido_m)
        Mc.Set_rfc(rfc)
        Mc.Set_clasificacion(clasificacion)
        Mc.Set_estatus(estatus)

        Dim dt As New DataTable
        Dim respuesta = ""

        dt = Cc.sp_alta_contacto(Mc)

        If dt.Rows.Count > 0 Then
            respuesta = "contacto Agregado con el id= " + Convert.ToString(dt.Rows(0)("id"))
        Else
            respuesta = "no agregado"
        End If

        Return respuesta
    End Function
    <WebMethod()>
    Public Function modificar(id As Integer, nombre As String, apellido_p As String, apellido_m As String, rfc As String, clasificacion As String, estatus As String) As String
        Dim dt As New DataTable
        Dim respuesta = ""

        Mc.Set_id(id)
        Mc.Set_nombre(nombre)
        Mc.Set_apellido_p(apellido_p)
        Mc.Set_apellido_m(apellido_m)
        Mc.Set_rfc(rfc)
        Mc.Set_clasificacion(clasificacion)
        Mc.Set_estatus(estatus)

        dt = Cc.sp_actualiza_contacto(Mc)

        If dt.Rows.Count > 0 Then
            respuesta = "contacto " + Convert.ToString(dt.Rows(0)("respuesta"))
        Else
            respuesta = "no actualizado"
        End If

        Return respuesta
    End Function
    <WebMethod()>
    Public Function eliminar(id As Integer) As String
        Dim dt As New DataTable
        Dim respuesta = ""

        dt = Cc.sp_elimina_contacto(id)

        If dt.Rows.Count > 0 Then
            respuesta = "contacto " + dt.Rows(0)("respuesta")
        Else
            respuesta = "no eliminado"
        End If

        Return respuesta
    End Function

End Class