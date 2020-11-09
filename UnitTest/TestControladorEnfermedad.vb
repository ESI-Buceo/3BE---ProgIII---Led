Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorEnfermedad

    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "53590226"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestListarNombreEnfermedadesActivas()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ListarNombreEnfermedadesActivas()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Dim listaSintomaPrueba As New List(Of String) From {
            "4",
            "43",
            "47",
            "48",
            "49",
            "50"
        }

        Try
            ControladorEnfermedad.CrearEnfermedad("Hartnup", "Mala absorción de los aminoácidos", "ALTA", listaSintomaPrueba)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.EstaInactivo("Acne")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestActivarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ActivarEnfermedad("Acne")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.CambiarEnfermedad("3", "Bronquitis", "Inflamacion de los conductos bronquiales, las vias respiratorias que llevan oxigeno a sus pulmones.", "ALTA")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarEnfermedadYSintomas()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Dim listaSintomaPrueba As New List(Of String) From {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "41"
        }
        Try
            ControladorEnfermedad.CambiarEnfermedadYSintomas("1", "Apendicitis", "Afeccion en la cual el apendice se inflama", "ALTA", listaSintomaPrueba)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEliminarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.EliminarEnfermedad("3")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerId()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ObtenerId("Aftas Bucales")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerPrioridad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ObtenerPrioridad("7")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerDescripcion()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ObtenerDescripcion("8")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ObtenerTodo("1")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False

        Try
            ControladorEnfermedad.ObtenerExistencia("Parkinson")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestReactivarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Resultado = False
        Try
            ControladorEnfermedad.ReactivarEnfermedad("Alergia")
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class