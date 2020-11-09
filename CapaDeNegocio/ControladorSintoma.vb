Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarNombreSintomaActivo()
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass)

        Return s.ListarNombreSintomaActivo()

    End Function

    Public Sub CrearSintoma(nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        s.Insertar()
    End Sub

    Public Sub CambiarNombreDeSintoma(idSintoma As String, nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .idSintoma = idSintoma,
            .nombre = nombre
        }
        s.Modificar()

    End Sub

    Public Sub EliminarSintoma(id As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintoma = id
        }

        s.Eliminar()
    End Sub

    Public Function ObtenerExistencia(nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .nombre = nombre
        }

        Return s.ObtenerExistencia()
    End Function

    Public Function EstaInactivo(nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .nombre = nombre
        }

        Return s.EstaInactivo()
    End Function

    Public Function ObtenerId(nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .nombre = nombre
        }

        Return s.ObtenerId()
    End Function

    Public Sub ActivarSintoma(id As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintoma = id
        }

        s.ActivarSintoma()
    End Sub
End Module

