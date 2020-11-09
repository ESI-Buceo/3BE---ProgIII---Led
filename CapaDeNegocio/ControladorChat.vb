Imports CapaDeDatos

Public Module ControladorChat

    Public Sub EnviarSolicitud(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Cedula = ControladorSesion.Cedula
        }

        c.EnviarSolicitud()
    End Sub

    Public Function BuscarSolicitud()
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass)

        Return c.BuscarSolicitud
    End Function

    Public Sub AceptarSolicitud(id As String, destinatario As String, nombre As String, apellido As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .CiPaciente = destinatario,
            .MiNombre = nombre,
            .MiApellido = apellido,
            .Cedula = ControladorSesion.Cedula
        }

        c.AceptarSolicitud()
    End Sub

    Public Sub EnviarMensajePaciente(id As String, mensaje As String, medico As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje,
            .CiMedico = medico,
            .Cedula = ControladorSesion.Cedula
        }

        c.EnviarMensajePaciente()
    End Sub

    Public Sub EnviarMensajeMedico(id As String, mensaje As String, paciente As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje,
            .CiPaciente = paciente,
            .Cedula = ControladorSesion.Cedula
        }

        c.EnviarMensajeMedico()
    End Sub

    Public Function BuscarMensajesNuevos(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Cedula = ControladorSesion.Cedula
        }

        Return c.BuscarMensajesNuevos
    End Function

    Public Sub MarcarComoLeido(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Cedula = ControladorSesion.Cedula
        }

        c.MarcarComoLeido()
    End Sub

    Public Sub FinalizarChatConMedico(id As String, ci As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .CiMedico = ci,
            .Cedula = ControladorSesion.Cedula
        }

        c.FinalizarChatConMedico()
    End Sub

    Public Sub FinalizarChatSinMedico(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        c.FinalizarChatSinMedico(id)
    End Sub

    Public Sub FinalizarChatMedico(id As String, ci As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .CiPaciente = ci,
            .Cedula = ControladorSesion.Cedula
        }

        c.FinalizarChatMedico()
    End Sub

    Public Sub MarcarComoFinalizado(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }
        c.MarcarComoFinalizado()
    End Sub

    Public Function ObtenerIdFechaMisChat()
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return c.ObtenerIdFechaMisChat()
    End Function

    Public Function ObtenerMensajesDelDiagnostico(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
        .IdDiagnostico = id
           }

        Return c.ObtenerMensajesDelDiagnostico()
    End Function

End Module
