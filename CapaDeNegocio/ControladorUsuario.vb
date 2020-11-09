Imports CapaDeDatos

Public Module ControladorUsuario

    Public Sub NuevoPaciente(cedula As String,
                             nombre As String,
                             apellido As String,
                             mail As String,
                             fechaNacimineto As String,
                             sexo As String,
                             enfermedades As List(Of String),
                             medicaciones As List(Of String),
                             contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .FechaNacimiento = fechaNacimineto,
            .sexo = sexo,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones,
            .Password = contra
        }

        u.NuevoPaciente()

    End Sub

    Public Sub AgregarNuevoPaciente(cedula As String,
                                    sexo As String,
                                    fechaNacimiento As String,
                                    enfermedades As List(Of String),
                                    medicaciones As List(Of String))
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .sexo = sexo,
            .fechaNacimiento = fechaNacimiento,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones
        }
        u.AgregarNuevoPaciente()

    End Sub

    Public Sub NuevoMedico(cedula As String,
                           nombre As String,
                           apellido As String,
                           mail As String,
                           contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .Password = contra
        }

        u.NuevoMedico()

    End Sub

    Public Sub AgregarNuevoMedico(cedula As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula
        }
        u.AgregarNuevoMedico()

    End Sub

    Public Sub NuevoAdministrativo(cedula As String,
                                    nombre As String,
                                    apellido As String,
                                    mail As String,
                                    contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .Password = contra
        }

        u.NuevoAdministrativo()

    End Sub

    Public Sub AgregarNuevoAdministrativo(cedula As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula
        }
        u.AgregarNuevoAdministrativo()

    End Sub

    Public Sub NuevoPacienteMedico(cedula As String,
                             nombre As String,
                             apellido As String,
                             mail As String,
                             fechaNacimineto As String,
                             sexo As String,
                             enfermedades As List(Of String),
                             medicaciones As List(Of String),
                             contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .FechaNacimiento = fechaNacimineto,
            .sexo = sexo,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones,
            .Password = contra
        }

        u.NuevoPacienteMedico()

    End Sub

    Public Sub NuevoPacienteAdmin(cedula As String,
                             nombre As String,
                             apellido As String,
                             mail As String,
                             fechaNacimineto As String,
                             sexo As String,
                             enfermedades As List(Of String),
                             medicaciones As List(Of String),
                             contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .FechaNacimiento = fechaNacimineto,
            .sexo = sexo,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones,
            .Password = contra
        }

        u.NuevoPacienteAdmin()

    End Sub

    Public Sub NuevoPacienteMedicoAdmin(Nombre As String,
                                        Apellido As String,
                                        CI As String,
                                        Mail As String,
                                        FechaNacimiento As String,
                                        Sexo As String,
                                        EnfermedadesCronicas As List(Of String),
                                        Medicamentos As List(Of String),
                                        Contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail,
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicamentos,
            .EnfermedadCronica = EnfermedadesCronicas,
            .Password = Contra
        }
        u.NuevoPacienteMedicoAdmin()

    End Sub

    Public Sub NuevoMedicoAdmin(cedula As String,
                                nombre As String,
                                apellido As String,
                                mail As String,
                                contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .Password = contra
        }

        u.NuevoMedicoAdmin()

    End Sub

    Public Function ObtenerCorreo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerCorreo()

    End Function

    Public Function ObtenerNombreApellidoCedula()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerNombreApellidoCedula

    End Function

    Public Function ObtenerCedulaMedico()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCiMedico()

    End Function

    Public Function ObtenerCedulaAdministrativo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCiAdministrador()

    End Function

    Public Function ObtenerNombre()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerNombre()

    End Function

    Public Function ObtenerNombre(cedula As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerNombre(cedula)

    End Function

    Public Function ObtenerNombreApellidoMail(ci As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ci
        }
        Return u.ObtenerNombreApellidoMail()

    End Function

    Public Function ObtenerTodasLasCedulas()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        Return u.ObtenerTodasLasCedulas()
    End Function

    Public Function ExisteRol(cedula As String, rol As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .rol = rol
        }

        Return u.ExisteRol()
    End Function

    Public Sub ModificarPersona(nombre As String,
                                apellido As String,
                                mail As String,
                                ci As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .nombre = nombre,
            .apellido = apellido,
            .mail = mail,
            .ci = ci
        }

        u.ModificarPersona()

    End Sub


    Public Sub EliminarPersona(ci As String, roles() As Boolean, eliminarPersona As Boolean)
        Dim p As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ci,
            .Roles = roles,
            .EliminarPersona = eliminarPersona
        }

        p.Eliminar()
    End Sub

End Module
