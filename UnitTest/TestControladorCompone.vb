Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorCompone

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "53590226"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestEnfermedadesPosibles()

        Resultado = False
        Dim sintomasDeTest As New List(Of String) From {
            ("Quistes"),
            ("Fiebre"),
            ("Tos"),
            ("Fiebre Alta")
        }

        Try
            ControladorCompone.EnfermedadesPosibles(sintomasDeTest)
            resultado = True

        Catch ex As Exception
        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestEnfermedadesPorAproximacion()
        Resultado = False
        Dim sintomasTest As New List(Of String) From {
            "Fiebre",
            "Dolor",
            "Malestar",
            "Dificultad Respiratoria"
        }

        Try
            ControladorCompone.EnfermedadesPorAproximacion(sintomasTest)
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerSintomasEnfermedad()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorCompone.ObtenerSintomasEnfermedad("3")
            resultado = True

        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class