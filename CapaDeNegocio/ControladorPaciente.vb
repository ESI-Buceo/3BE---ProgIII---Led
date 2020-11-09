Imports CapaDeDatos

Public Module ControladorPaciente

    Public Function ObtenerNombre()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return p.ObtenerNombre()
    End Function

    Public Function ObtenerCi()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerCiPaciente()

    End Function

    Public Function ObtenerTodo()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return p.ObtenerPersonaSexoNacimineto()
    End Function

    Public Function ObtenerTodo(ci As String)
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerPersonaSexoNacimineto(ci)
    End Function

    Public Function ObtenerMedicaciones()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return p.ObtenerMedicaciones()
    End Function

    Public Function ObtenerEnfermedades()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return p.ObtenerEnfermedades()
    End Function

    Public Function ObtenerMedicaciones(ci As String)
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerMedicaciones(ci)
    End Function

    Public Function ObtenerEnfermedades(ci As String)
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerEnfermedades(ci)
    End Function

    Public Sub CambiarDatos(nombre As String,
                            apellido As String,
                            correo As String,
                            sexo As String,
                            fecha As String,
                            enfermedades As List(Of String),
                            medicaciones As List(Of String))
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = correo,
            .Sexo = sexo,
            .FechaNacimiento = fecha,
            .Enfermedades = enfermedades,
            .Medicaciones = medicaciones,
            .Cedula = ControladorSesion.Cedula
        }

        p.CambiarDatos()
    End Sub

    Public Sub CambiarDatos(nombre As String,
                            apellido As String,
                            correo As String,
                            sexo As String,
                            fecha As String,
                            enfermedades As List(Of String),
                            medicaciones As List(Of String),
                            ci As String)
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = correo,
            .Sexo = sexo,
            .FechaNacimiento = fecha,
            .Enfermedades = enfermedades,
            .Medicaciones = medicaciones,
            .Cedula = ci
        }

        p.CambiarDatos(ci)
    End Sub

    Public Function ObtenerSexo()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return p.ObtenerSexo()
    End Function

End Module
