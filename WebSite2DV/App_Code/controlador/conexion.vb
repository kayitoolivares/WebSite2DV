Imports System.Data.SqlClient

Public Class conexion
    Public con As New SqlConnection
    Public cmd As New SqlCommand

    Public Function conectado() As Boolean
        Try
            con = New SqlConnection("Data Source=LAPTOP-IHHCUML7\SQLEXPRESS;Initial Catalog=pruebaDVazquez;Persist " &
            "Security Info=True;User ID=pruebas;Password=holamundo13")
            con.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message + " Error en conectaro")
            Return False
        End Try
    End Function






End Class
