Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorUsuario

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "5"
    Private ReadOnly Enfermedades As New List(Of String)
    Private ReadOnly Medicaciones As New List(Of String)
    Private ReadOnly Roles(3) As Boolean
    Private ReadOnly Contra As String = "Pas1234_"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestNuevoPaciente()
        Resultado = False
        Try
            ControladorUsuario.NuevoPaciente(Paciente, "Paciente", "Prueba", "correo", "2020-05-20", 1, Enfermedades, Medicaciones, Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoPaciente()
        Resultado = False
        Try
            ControladorUsuario.AgregarNuevoPaciente(Medico, 0, "1995-05-14", Enfermedades, Medicaciones)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoMedico()
        Resultado = False
        Try
            ControladorUsuario.NuevoMedico(Medico, "Medico", "Prueba", "correo", Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoMedico()
        Resultado = False
        Try
            ControladorUsuario.AgregarNuevoMedico(Medico)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoAdministrativo()
        Resultado = False
        Try
            ControladorUsuario.NuevoAdministrativo(Admin, "Administrativo", "Prueba", "Correo", Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub
    <TestMethod()> Public Sub TestAgregarNuevoAdministrativo()
        Resultado = False
        Try
            ControladorUsuario.AgregarNuevoAdministrativo(Admin)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteMedico()
        Resultado = False
        Try
            ControladorUsuario.NuevoPacienteMedico(Paciente,
                                                   "MedPac",
                                                   "Prueba",
                                                   "Correo",
                                                   "2020-05-10",
                                                   1,
                                                   Enfermedades,
                                                   Medicaciones,
                                                   Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteAdmin()
        Resultado = False
        Try
            ControladorUsuario.NuevoPacienteAdmin(Paciente,
                                                  "PacAdm",
                                                  "Prueba",
                                                  "Correo",
                                                  "2020-06-10",
                                                  0,
                                                  Enfermedades,
                                                  Medicaciones,
                                                  Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteMedicoAdmin()
        Resultado = False
        Try
            ControladorUsuario.NuevoPacienteMedicoAdmin("PacMedAdm",
                                                        "Prueba",
                                                        Paciente,
                                                        "Correo",
                                                        "2020-05-12",
                                                        1,
                                                        Enfermedades,
                                                        Medicaciones,
                                                        Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoMedicoAdmin()
        Resultado = False
        Try
            ControladorUsuario.NuevoMedicoAdmin(Medico, "MedAdm", "Prueba", "Correo", Contra)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCorreo()
        Resultado = False
        Try
            ControladorUsuario.ObtenerCorreo()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerNombreApellidoCedula()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False
        Try
            ControladorUsuario.ObtenerNombreApellidoCedula()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaMedico()
        Resultado = False
        Try
            ControladorUsuario.ObtenerCedulaMedico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaAdministrativo()
        Resultado = False
        Try
            ControladorUsuario.ObtenerCedulaAdministrativo()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerNombre()
        Resultado = False
        Try
            ControladorUsuario.ObtenerNombre()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    ''CP -> Con parametro
    <TestMethod()> Public Sub TestObtenerNombreCP()
        Resultado = False
        Try
            ControladorUsuario.ObtenerNombre(Paciente)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerNombreApellidoMail()
        Resultado = False
        Try
            ControladorUsuario.ObtenerNombreApellidoMail(Paciente)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerTodasLasCedulas()
        Resultado = False
        Try
            ControladorUsuario.ObtenerTodasLasCedulas()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestExisteRol()
        Resultado = False
        Try
            ControladorUsuario.ExisteRol(Paciente, 1)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestModificarPersona()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False
        Try
            ControladorUsuario.ModificarPersona("Nuevo Nombre", "Prueba", "Correo", Medico)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarPersona()
        Resultado = False
        Try
            ControladorUsuario.EliminarPersona(Paciente, Roles, 0)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class