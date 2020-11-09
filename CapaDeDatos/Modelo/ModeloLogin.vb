Public Class ModeloLogin
    Inherits ModeloBaseDeDatos

    Public Sub New(usuario As String, contra As String)
        MyBase.New(usuario, contra)
    End Sub

    Public NombreUsuario As String
    Public ContraUsuario As String
    Public Cedula As String

    Public Function ObtenerRol(rol As String)
        Command.CommandText = "
            SELECT
                COUNT(ci_persona)
            FROM
                roles
            WHERE
                ci_persona = " + Me.Cedula + "
                AND
                    rol = " + rol + " > 0
        "
        Return Command.ExecuteScalar.ToString
    End Function

End Class