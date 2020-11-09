Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorPaciente

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly Sexo As String = "0"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestObtenerNombre()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorPaciente.ObtenerNombre()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCi()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorPaciente.ObtenerCi()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        ControladorSesion.Cedula = Paciente
        Resultado = False

        Try
            ControladorPaciente.ObtenerTodo()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerTodoConCI()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorPaciente.ObtenerTodo(Paciente)

            Resultado = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(Resultado)
    End Sub


    <TestMethod()> Public Sub TestObtenerMedicaciones()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorPaciente.ObtenerMedicaciones()

            Resultado = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerMedicacionesConCI()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorPaciente.ObtenerMedicaciones(Paciente)
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedadesConCI()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorPaciente.ObtenerEnfermedades(Paciente)

            Resultado = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarDatos()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Dim enfermedadTest As New List(Of String) From {
            "diabetes"
        }
        Dim medicacionesTest As New List(Of String) From {
            "insulina"
        }

        Try
            ControladorPaciente.CambiarDatos("super",
                                             "pruebas",
                                             "atoderol@gmail.com",
                                             "0",
                                             "1979-03-06",
                                             enfermedadTest,
                                             medicacionesTest)
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarDatosConCI()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Dim enfermedadTest As New List(Of String) From {
            "diabetes"
        }
        Dim medicacionesTest As New List(Of String) From {
            "insulina"
        }

        Try
            ControladorPaciente.CambiarDatos("super",
                                             "pruebas",
                                             "atoderol@gmail.com",
                                             "0",
                                             "1979-03-06",
                                             enfermedadTest,
                                             medicacionesTest,
                                             Paciente)
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedades()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorPaciente.ObtenerEnfermedades()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerSexo()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        ControladorSesion.Cedula = Paciente

        Try
            Assert.AreEqual(ControladorPaciente.ObtenerSexo(), Sexo)

        Catch ex As Exception

        End Try

    End Sub

End Class