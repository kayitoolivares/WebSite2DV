
Imports System.Data
Imports System.Data.SqlClient



Public Class CContacto
    Inherits conexion

    Public Function validarContacto(ByVal dts As contacto) As DataTable
        conectado()
        cmd = New SqlCommand("sp_vista_contacto")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.AddWithValue("@id", dts.Get_id())

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    'da.Fill(dt)
                    Return dt
                End Using
            End Using

        Else
            Return Nothing
        End If

    End Function


    Public Function sp_alta_contacto(ByVal dts As contacto) As DataTable
        conectado()
        cmd = New SqlCommand("sp_alta_contacto")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.AddWithValue("@nombre", dts.Get_nombre())
        cmd.Parameters.AddWithValue("@apellido_p", dts.Get_apellido_p())
        cmd.Parameters.AddWithValue("@apellido_m", dts.Get_apellido_m())
        cmd.Parameters.AddWithValue("@rfc", dts.Get_rfc())
        cmd.Parameters.AddWithValue("@clasificacion", dts.Get_clasificacion())
        cmd.Parameters.AddWithValue("@estatus", dts.Get_estatus())

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using


        Else

            Return Nothing
        End If

    End Function


    Public Function sp_actualiza_contacto(ByVal dts As contacto) As DataTable
        conectado()
        cmd = New SqlCommand("sp_actualiza_contacto")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.AddWithValue("@id", dts.Get_id())
        cmd.Parameters.AddWithValue("@nombre", dts.Get_nombre())
        cmd.Parameters.AddWithValue("@apellido_p", dts.Get_apellido_p())
        cmd.Parameters.AddWithValue("@apellido_m", dts.Get_apellido_m())
        cmd.Parameters.AddWithValue("@rfc", dts.Get_rfc())
        cmd.Parameters.AddWithValue("@clasificacion", dts.Get_clasificacion())
        cmd.Parameters.AddWithValue("@estatus", dts.Get_estatus())

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using


        Else

            Return Nothing
        End If

    End Function


    Public Function sp_elimina_contacto(ByVal id As Int16) As DataTable
        conectado()
        cmd = New SqlCommand("sp_elimina_contacto")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.AddWithValue("@id", id)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using


        Else

            Return Nothing
        End If

    End Function

End Class
