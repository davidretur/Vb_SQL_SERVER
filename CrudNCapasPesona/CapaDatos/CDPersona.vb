Imports System.Data.SqlClient
Imports CapaEntidades

Public Class CDPersona
    Dim objConexion As New CDConexion
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection
    ' implementamos el Store procedure de la BD
    Function listarPersonas() As DataSet
        Try
            cn = objConexion.Conectar
            da = New SqlDataAdapter("SP_ListarPersonas", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Personas")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            da.Dispose()
        End Try
    End Function

    Public Function ObtenerPersonaPorID(ByVal id As Integer) As CEPersona
        Dim persona As New CEPersona()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            cn = objConexion.Conectar()
            cn.Open()
            cmd = New SqlCommand("SP_ConsultarUnaPersona", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdPersona", SqlDbType.Int).Value = id

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                persona.idPersona = Convert.ToInt32(dr("IdPersona"))
                persona.nombre = dr("Nombre").ToString()
                persona.pais = dr("Pais").ToString()
                persona.correo = dr("Correo").ToString()
            End If

            dr.Close()
        Catch ex As Exception
            ' Manejo de errores
            Throw ex
        Finally
            If cn IsNot Nothing Then
                cn.Close()
                cn.Dispose()
            End If
            If cmd IsNot Nothing Then
                cmd.Dispose()
            End If
        End Try

        Return persona
    End Function
    ' creamos el procedimeinto para agregar personas
    Sub registroPersona(ByVal obj As CEPersona)
        ' manejo de errores
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("SP_nuevaPersona", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Nombre", SqlDbType.VarChar).Value = obj.Nombre
                .Add("@Pais", SqlDbType.VarChar).Value = obj.Pais
                .Add("@Correo", SqlDbType.VarChar).Value = obj.Correo
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro Exitoso!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub


    ' creamos el procedimeinto para actualizar personas
    Sub ActualizarPersona(ByVal obj As CEPersona)
        ' manejo de errores
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("SP_ModificarPersona", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdPersona", SqlDbType.VarChar).Value = obj.idPersona
                .Add("@Nombre", SqlDbType.VarChar).Value = obj.nombre
                .Add("@Pais", SqlDbType.VarChar).Value = obj.pais
                .Add("@Correo", SqlDbType.VarChar).Value = obj.correo
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Actualizacion Exitoso!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

    ' creamos el procedimeinto para actualizar personas
    Sub EliminarPersona(ByVal obj As CEPersona)
        ' manejo de errores
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("SP_EliminarPersona", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdPersona", SqlDbType.VarChar).Value = obj.idPersona
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Eliminacion Exitoso!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

End Class
