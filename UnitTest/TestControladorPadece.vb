Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorPadece
    Dim sintomasPadecidosTest As New List(Of String) From {
        "Dolor"
    }
    Dim Resultado As Boolean = False


    <TestMethod()> Public Sub TestGuardarSintomasPadecidos()
        Try
            ControladorPadece.GuardarSintomasPadecidos(sintomasPadecidosTest)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class