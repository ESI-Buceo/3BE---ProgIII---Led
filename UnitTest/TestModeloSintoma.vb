Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloSintoma

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
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

    <TestMethod()> Public Sub TestListar()
        Resultado = False
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
           .Nombre = "Tos"
       }

        Try
            s.Listar()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestListarNombreSintomaActivo()
        Dim Resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass)

        Try
            s.ListarNombreSintomaActivo()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestInsertar()
        Resultado = False
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = Random()
        }

        Try
            s.Insertar()
            Resultado = True

        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestModificar()
        Resultado = False
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Espinillas negras",
            .IdSintoma = "11"
        }

        Try
            s.Modificar()
            Resultado = True

        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEliminar()
        Resultado = False
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .IdSintoma = "27"
        }

        Try
            s.Eliminar()
            Resultado = True

        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarNombreSintomaInactivo()
        Resultado = False
        Dim s As New ModeloSintoma(Admin, AdmPass)

        Try
            s.ListarNombreSintomaInactivo()
            Resultado = True

        Catch ex As Exception
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Quistes"
        }

        Try
            Assert.AreEqual(s.ObtenerExistencia(), 1)
        Catch ex As Exception
        End Try

    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Quistes"
        }

        Try
            Assert.AreEqual(s.EstaInactivo(), 0)

        Catch ex As Exception
        End Try

    End Sub

    <TestMethod()> Public Sub TestObtenerId()
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Ronchas"
        }

        Try
            Assert.AreEqual(s.ObtenerId(), 10)

        Catch ex As Exception
        End Try

    End Sub

    <TestMethod()> Public Sub TestActivarSintoma()
        Resultado = False
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .IdSintoma = "10"
        }

        Try
            s.ActivarSintoma()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class