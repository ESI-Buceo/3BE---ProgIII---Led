Imports CapaDeDatos

Public Module ControladorCompone

    Public Function EnfermedadesPosibles(Sintomas As List(Of String))
        Dim c As New ModeloCompone(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintomas = Sintomas
        }

        Return c.EnfermedadesPosibles()
    End Function

    Public Function EnfermedadesPorAproximacion(Sintomas As List(Of String))
        Dim c As New ModeloCompone(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintomas = Sintomas
        }

        Return c.EnfermedadesPorAproximacion()
    End Function

    Public Sub Insertar(Sintomas As List(Of String), Enfermedad As String)
        Dim c As New ModeloCompone(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintomas = Sintomas,
            .IdEnfermedad = Enfermedad
        }

        c.Insertar()
    End Sub

    Public Function ObtenerSintomasEnfermedad(enfermedad As String)
        Dim c As New ModeloCompone(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdEnfermedad = enfermedad
        }

        Return c.ObtenerSintomasEnfermedad()
    End Function
End Module
