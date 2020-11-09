Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloPaciente

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestObtenerNombre()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            p.ObtenerNombre()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerPersonaSexoNacimineto()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            p.ObtenerPersonaSexoNacimineto()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerPersonaSexoNaciminetoConCi()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            p.ObtenerPersonaSexoNacimineto(Paciente)
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerMedicaciones()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            p.ObtenerMedicaciones()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerMedicacionesConCI()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }

        Try
            p.ObtenerMedicaciones(Paciente)
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedades()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            p.ObtenerEnfermedades()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestTestObtenerEnfermedadesConCI()
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            p.ObtenerEnfermedades(Paciente)
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarDatos()
        Dim medicacionPrueba As New List(Of String) From {
            "Insulina"
        }
        Dim enfermedadPrueba As New List(Of String) From {
            "Diabetes"
        }
        Resultado = False

        Dim p As New ModeloPaciente(Paciente, PacPass) With {
            .Nombre = "Super",
            .Apellido = "Pruebas",
            .Mail = "atoderol@gmail.com",
            .Cedula = Paciente,
            .Sexo = "0",
            .FechaNacimiento = "1979-03-06",
            .Medicaciones = medicacionPrueba,
            .Enfermedades = enfermedadPrueba
        }

        Try
            p.CambiarDatos()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarDatosConCI()
        Dim medicacionPrueba As New List(Of String) From {
            "Insulina"
        }
        Dim enfermedadPrueba As New List(Of String) From {
            "Diabetes"
        }
        Resultado = False

        Dim p As New ModeloPaciente(Paciente, PacPass) With {
            .Nombre = "Super",
            .Apellido = "Pruebas",
            .Mail = "atoderol@gmail.com",
            .Sexo = "0",
            .FechaNacimiento = "1979-03-06",
            .Medicaciones = medicacionPrueba,
            .Enfermedades = enfermedadPrueba
        }

        Try
            p.CambiarDatos(Paciente)
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCiPaciente()
        Dim p As New ModeloPaciente(Paciente, PacPass)
        Resultado = False

        Try
            p.ObtenerCiPaciente()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class