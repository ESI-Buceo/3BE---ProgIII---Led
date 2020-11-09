Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorDiagnostico

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly Diagnostico As String = "1"
    Private ReadOnly Existe As String = "0"
    Dim listaTest As New List(Of String) From {
            "46"
        }
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestControladorNuevo()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorDiagnostico.Nuevo(listaTest, "8")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerID()
        Try
            Assert.AreEqual(ControladorDiagnostico.ObtenerID(), Diagnostico)
        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestTodosMisDiagnosticos()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorDiagnostico.TodosMisDiagnosticos()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub
    <TestMethod()> Public Sub TestSintomasEnfermedadDiagnosticada()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorDiagnostico.SintomasEnfermedadDiagnosticada(Diagnostico)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEnfermedadDiagnosticada()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorDiagnostico.EnfermedadDiagnosticada(Diagnostico)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestMedicoDiagnostico()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorDiagnostico.MedicoDiagnostico(Diagnostico)
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestExistenMensajes()
        ControladorSesion.Pass = Paciente
        ControladorSesion.User = PacPass

        Try
            Assert.AreEqual(ControladorDiagnostico.ExistenMensajes(Diagnostico), Existe)
        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub ObtenerCedulaPaciente()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorDiagnostico.ObtenerCedulaPaciente(Diagnostico)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class