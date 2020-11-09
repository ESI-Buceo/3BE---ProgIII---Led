Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloLogin

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestObtenerRol()
        Dim l As New ModeloLogin(Admin, AdmPass) With {
          .Cedula = Admin
        }
        Resultado = False

        Try
            l.ObtenerRol(3)
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class