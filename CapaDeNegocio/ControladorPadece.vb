Imports CapaDeDatos

Public Module ControladorPadece

    Public Sub GuardarSintomasPadecidos(ListaSintoma As List(Of String))
        Dim pa As New ModeloPadece(ControladorSesion.User, ControladorSesion.Pass) With {
            .ListadoSintomas = ListaSintoma,
            .Cedula = ControladorSesion.Cedula
        }

        pa.GuardarPadecimientos()
    End Sub
End Module
