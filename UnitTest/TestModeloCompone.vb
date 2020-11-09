Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloCompone

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestEnfermedadesPosibles()
        Dim sintomaPrueba As New List(Of String) From {
        ("Quistes"),
        ("Fiebre"),
        ("Tos"),
        ("Fiebre Alta")
        }
        Dim c As New ModeloCompone(Paciente, PacPass) With {
            .IdSintomas = sintomaPrueba}
        Resultado = False

        Try
            c.EnfermedadesPosibles()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestEnfermedadesPorAproximacion()
        Dim sintomaPrueba As New List(Of String) From {
            ("Sintoma de prueba"),
            ("Diarrea"),
            ("Ronchas")
        }
        Dim C As New ModeloCompone(Paciente, PacPass) With {
            .IdSintomas = sintomaPrueba}
        Resultado = False

        Try
            C.EnfermedadesPorAproximacion()
            Resultado = True

        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerSintomasEnfermedad()
        Dim c As New ModeloCompone(Admin, AdmPass) With {
            .IdEnfermedad = "5"
        }
        Resultado = False

        Try
            c.ObtenerSintomasEnfermedad()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class