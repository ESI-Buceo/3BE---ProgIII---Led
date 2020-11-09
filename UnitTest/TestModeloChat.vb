Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloChat

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Resultado = False
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .Cedula = Paciente,
            .IdDiagnostico = Diagnostico
        }

        Try
            c.EnviarSolicitud()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Resultado = False
        Dim c As New ModeloChat(Medico, MedPass)

        Try
            c.BuscarSolicitud()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        Resultado = False
        Dim c As New ModeloChat(Medico, MedPass) With {
            .Cedula = Medico,
            .CiPaciente = Paciente,
            .IdDiagnostico = Diagnostico
        }

        Try
            c.AceptarSolicitud()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)


    End Sub
    <TestMethod()> Public Sub TestEnviarMensajePaciente()
        Resultado = False
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .Cedula = Paciente,
            .CiMedico = Medico,
            .IdDiagnostico = Diagnostico,
            .CiPaciente = Paciente,
            .Mensaje = "Estoy todito tomado Doc"
        }

        Try
            c.EnviarMensajePaciente()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Resultado = False
        Try
            Dim c As New ModeloChat(Medico, MedPass) With {
            .Cedula = Medico,
            .CiMedico = Medico,
            .IdDiagnostico = Diagnostico,
            .CiPaciente = Paciente,
            .Mensaje = "Nunca estuve tan de acuerdo"
        }
            c.EnviarMensajeMedico()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarMensajesNuevos()
        Dim tablaEsperada As New DataTable
        Dim c As New ModeloChat(Medico, MedPass) With {
            .IdDiagnostico = Diagnostico,
            .Cedula = Medico
        }

        Try
            Assert.AreSame(c.BuscarMensajesNuevos.GetType(), tablaEsperada.GetType())
        Catch ex As Exception
        End Try

    End Sub

    <TestMethod()> Public Sub TestMarcarComoLeido()
        Resultado = False
        Dim c As New ModeloChat(Medico, MedPass) With {
            .IdDiagnostico = Diagnostico,
            .Cedula = Paciente
        }

        Try
            c.MarcarComoLeido()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatPaciente()
        Resultado = False
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .CiMedico = Medico,
            .Cedula = Paciente,
            .IdDiagnostico = Diagnostico
        }

        Try
            c.FinalizarChatConMedico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatConId()
        Resultado = False
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .Cedula = Paciente,
            .IdDiagnostico = Diagnostico
        }

        Try
            c.FinalizarChatSinMedico(Diagnostico)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        Resultado = False
        Dim c As New ModeloChat(Medico, MedPass) With {
           .CiPaciente = Paciente,
           .Cedula = Medico,
           .IdDiagnostico = Diagnostico
        }

        Try
            c.FinalizarChatMedico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestMarcarComoFinalizado()
        Resultado = False
        Dim c As New ModeloChat(Medico, MedPass) With {
            .IdDiagnostico = Diagnostico
        }

        Try
            c.MarcarComoFinalizado()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerIdFechaMisChat()
        Resultado = False
        Dim c As New ModeloChat(Medico, MedPass) With {
            .Cedula = Medico
        }

        Try
            c.ObtenerIdFechaMisChat()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerMensajesDelDiagnostico()
        Resultado = False
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .IdDiagnostico = Diagnostico
        }

        Try
            c.ObtenerMensajesDelDiagnostico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class