Imports CapaDatos
Imports CapaEntidades

Public Class CNPersonas
    'creamos el objeto de capaDatos
    Dim objCapaDatos As New CDPersona

    ' implementamos la funcion que retorna
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function
    ' implementamos la funcion que retorna
    Function listarUnaPersonas(id As Integer) As CEPersona
        Return objCapaDatos.ObtenerPersonaPorID(id)
    End Function
    'llamamos al registro de procedimeinto de personas
    Sub registroPersonas(ByVal obj As CEPersona)
        objCapaDatos.registroPersona(obj)
    End Sub
    'llanamos al Actualizar de procedimeinto de personas
    Sub ActualizarPersona(ByVal obj As CEPersona)
        objCapaDatos.ActualizarPersona(obj)
    End Sub
    ' implementamos la funcion que eliminara una persona
    Sub EliminarPersona(ByVal obj As CEPersona)
        objCapaDatos.EliminarPersona(obj)
    End Sub
End Class
