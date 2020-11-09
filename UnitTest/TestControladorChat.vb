Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorChat

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestEnviarSolicitud()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorChat.EnviarSolicitud(Diagnostico)
            Resultado = True

        Catch ex As Exception
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim TablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorChat.BuscarSolicitud.GetType(), TablaEsperada.GetType())
        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Resultado = False
        Try
            ControladorChat.AceptarSolicitud(Diagnostico, Paciente, "Eduardo", "Fabre")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajePaciente()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Resultado = False
        Try
            ControladorChat.EnviarMensajePaciente(Diagnostico, "soy paciente", Medico)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Resultado = False

        Try
            ControladorChat.EnviarMensajeMedico(Diagnostico, "soy medico", Paciente)
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarMensajesNuevo()
        Resultado = False
        Try
            ControladorChat.BuscarMensajesNuevos(Diagnostico)
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestMarcarComoLeido()
        Resultado = False

        Try
            ControladorChat.MarcarComoLeido(Diagnostico)
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatPaciente()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorChat.FinalizarChatConMedico(Diagnostico, Medico)
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Resultado = False

        Try
            ControladorChat.FinalizarChatMedico(Diagnostico, Paciente)
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChat()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorChat.FinalizarChatSinMedico(Diagnostico)
            Resultado = True
        Catch ex As Exception


        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestMarcarComoFinalizado()
        Resultado = False
        Try
            ControladorChat.MarcarComoFinalizado("1")
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerIdFechaMisChat()
        Dim TablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorChat.ObtenerIdFechaMisChat.GetType(), TablaEsperada.GetType())

        Catch ex As Exception
        End Try

    End Sub

    <TestMethod()> Public Sub TestObtenerMensajesDelDiagnostico()
        Resultado = False

        Try
            ControladorChat.ObtenerMensajesDelDiagnostico(1)
            Resultado = True
        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class