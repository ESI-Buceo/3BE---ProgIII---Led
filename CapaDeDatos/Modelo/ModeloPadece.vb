Public Class ModeloPadece

    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Cedula As String
    Public ListadoSintomas As List(Of String)

    Public Sub GuardarPadecimientos()
        For Each sintoma In ListadoSintomas
            Command.CommandText = "
            INSERT INTO
                padece(ci_persona_paciente, id_sintoma)
            VALUES(" + Me.Cedula + ", 
                (SELECT id FROM sintoma WHERE nombre = '" + sintoma + "')
                    )
        "
            Command.ExecuteNonQuery()
        Next

    End Sub

End Class
