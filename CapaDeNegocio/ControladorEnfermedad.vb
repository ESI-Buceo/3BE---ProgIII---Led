Imports CapaDeDatos

Public Module ControladorEnfermedad

    Public Function ListarEnfermedad()
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass)

        Return e.Listar()
    End Function

    Public Function ListarNombreEnfermedadesInactivas()
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass)

        Return e.ListarNombreEnfermedadesInactivas()
    End Function

    Public Function ListarNombreEnfermedadesActivas()
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass)

        Return e.ListarNombreEnfermedadesActivas()
    End Function

    Public Sub CrearEnfermedad(nombre As String,
                               descripcion As String,
                               prioridad As String,
                               sintomas As List(Of String))
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre,
            .Descripcion = descripcion,
            .Prioridad = prioridad,
            .Sintomas = sintomas
        }

        e.Insertar()
    End Sub

    Public Sub ActivarEnfermedad(nombre As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        e.ActivarEnfermedad()
    End Sub

    Public Function EstaInactivo(nombre As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        Return e.EstaInactivo()
    End Function

    Public Sub CambiarEnfermedad(idEnfermedad As String,
                                 nombre As String,
                                 descripcion As String,
                                 prioridad As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = idEnfermedad,
            .Nombre = nombre,
            .Descripcion = descripcion,
            .Prioridad = prioridad
        }

        e.Modificar()
    End Sub

    Public Sub CambiarEnfermedadYSintomas(idEnfermedad As String,
                                          nombre As String,
                                          descripcion As String,
                                          prioridad As String,
                                          sintomas As List(Of String))
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = idEnfermedad,
            .Nombre = nombre,
            .Descripcion = descripcion,
            .Prioridad = prioridad,
            .Sintomas = sintomas
        }
        e.CambiarEnfermedadYSintomas()

    End Sub

    Public Sub EliminarEnfermedad(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        e.Eliminar()
    End Sub



    Public Function ObtenerId(nombre As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        Return e.ObtenerId()
    End Function

    Public Function ObtenerPrioridad(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return e.ObtenerPrioridad()

    End Function

    Public Function ObtenerDescripcion(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return e.ObtenerDescripcion()

    End Function

    Public Function ObtenerTodo(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return e.ObtenerTodo()
    End Function

    Public Function ObtenerExistencia(nombre As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }
        Return e.ObtenerExistencia()

    End Function

    Public Sub ReactivarEnfermedad(nombre As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        e.ReactivarEnfermedad()

    End Sub

End Module
