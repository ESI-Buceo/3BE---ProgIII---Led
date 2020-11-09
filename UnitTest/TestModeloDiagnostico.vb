Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloDiagnostico

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestNuevo()
        Dim sintomaPrueba As New List(Of String) From {
            "Dolor"
        }
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .IdSintomas = sintomaPrueba,
            .IdEnfermedad = "18"
        }
        Resultado = False

        Try
            d.Nuevo()
            Resultado = True
        Catch ex As Exception


        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub ObtenerId()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Cedula = Paciente
        }
        Resultado = False

        Try
            d.ObtenerId()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestTodosMisDiagnosticos()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Cedula = Paciente
        }
        Resultado = False
        Try
            d.TodosMisDiagnosticos()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEnfermedadDiagnosticada()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
        }
        Resultado = False
        Try
            d.EnfermedadDiagnosticada()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestSintomasEnfermedadDiagnosticada()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
        }
        Resultado = False
        Try
            d.SintomasEnfermedadDiagnosticada()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestMedicoDiagnostico()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
        }
        Resultado = False
        Try
            d.MedicoDiagnostico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestMensajesDiagnostico()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
        }
        Resultado = False
        Try
            d.MensajesDiagnostico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestExistenMensajes()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
           .Id = Diagnostico
       }
        Resultado = False
        Try
            d.ExistenMensajes()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaPertenece()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
          .Id = Diagnostico
        }
        Resultado = False

        Try
            d.ObtenerCedulaPertenece()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class