Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloEnfermedad

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = True

    <TestMethod()> Public Sub TestInsertar()
        Dim sintomaPrueba As New List(Of String) From {
            "Diarrea",
            "Debilidad",
            "Delirio",
            "Alucinaciones",
            "Desmayo"
        }
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
            .Sintomas = sintomaPrueba,
            .Nombre = "Hartnup",
            .Descripcion = "Mala absorcion de los aminoacidos",
            .Prioridad = "ALTA"
        }

        Try
            e.Insertar()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Alergia"
        }
        Resultado = False
        Try
            e.EstaInactivo()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestActivarEnfermedad()
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Alergia"
        }
        Resultado = False

        Try
            e.ActivarEnfermedad()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListar()
        Dim e As New ModeloEnfermedad(Admin, AdmPass)
        Resultado = False

        Try
            e.Listar()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarNombreEnfermedadesActivas()
        Dim e As New ModeloEnfermedad(Admin, AdmPass)
        Resultado = False

        Try
            e.Listar()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarNombreEnfermedadesInactivas()
        Dim e As New ModeloEnfermedad(Admin, AdmPass)
        Resultado = False

        Try
            e.Listar()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestModificar()
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Bronquitis",
           .Descripcion = "Inflamacion de los conductos bronquiales, las vias respiratorias que llevan oxigeno a sus pulmones.",
           .Prioridad = "ALTA",
           .Id = "3"
        }
        Resultado = False

        Try
            e.Modificar()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarEnfermedadYSintomas()
        Dim sintomaPrueba As New List(Of String) From {
            "Diarrea",
            "Debilidad",
            "Delirio",
            "Alucinaciones",
            "Desmayo",
            "Temblores"
        }
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Hartnup",
           .Descripcion = "Mala absorcion de los aminoacidos",
           .Prioridad = "ALTA",
           .Id = "9"
        }

        Try
            e.CambiarEnfermedadYSintomas()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEliminar()
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "3"
        }

        Try
            e.Eliminar()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerId()
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Acne"
        }

        Try
            e.ObtenerId()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerPrioridad()
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "4"
        }

        Try
            e.ObtenerPrioridad()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerDescripcion()
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "5"
        }

        Try
            e.ObtenerDescripcion()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "5"
        }

        Try
            e.ObtenerTodo()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        Resultado = False

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Alergia"
        }

        Try
            e.ObtenerExistencia()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class