Imports CapaDeDatos

Public Module ControladorGenera

    Public Function ObtenerIdEnfermedadGenerada()
        Dim g As New ModeloGenera(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return g.ObtenerEnfermedadGenerada()
    End Function

    Public Function ObtenerNombreEnfermedad(id As String)
        Dim g As New ModeloGenera(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        Return g.ObtenerNombreEnfermedad()
    End Function

    Public Function ObtenerNombreSintomas(id As String)
        Dim g As New ModeloGenera(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        Return g.ObtenerNombreSintomas()
    End Function

End Module
