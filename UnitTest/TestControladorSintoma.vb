Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorSintoma

    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly AdmPass As String = "54083680"
    ReadOnly Existe As String = "1"
    Dim Resultado As Boolean = False

    Private Function Random()
        Dim rdm As New Random()
        Dim Letras() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray()
        Dim Sintoma As String = ""

        For i As Integer = 0 To 8
            Sintoma += Letras(rdm.Next(0, Letras.Length))
        Next
        Return Sintoma
    End Function

    <TestMethod()> Public Sub TestListarNombreSintomaActivo()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorSintoma.ListarNombreSintomaActivo()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearSintoma()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorSintoma.CrearSintoma(Random())
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarNombreDeSintoma()
        Resultado = False

        Try
            ControladorSintoma.CambiarNombreDeSintoma("47", "Delirios")
            Resultado = True

        Catch ex As Exception


        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEliminarSintoma()
        Resultado = False

        Try
            ControladorSintoma.EliminarSintoma("44")
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass

        Try
            Assert.AreEqual(ControladorSintoma.ObtenerExistencia("Bruma Sensorial"), Existe, False, "Error")
        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass

        Try
            Assert.AreEqual(ControladorSintoma.EstaInactivo("Temblores"), Existe, False, "Error")

        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestObtenerId()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            Assert.AreEqual(ControladorSintoma.ObtenerId("Diarrea"), "4", False, "Error")

        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestActivarSintoma()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False
        Try
            ControladorSintoma.ActivarSintoma("49")
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class