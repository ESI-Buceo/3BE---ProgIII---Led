Public Class ModeloGenera
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Cedula As String
    Public IdDiagnostico As String

    Public Function ObtenerEnfermedadGenerada()
        Command.CommandText = "
            SELECT 
                c.id_enfermedad
            FROM 
                genera g 
                    JOIN
                        diagnostico d 
                            ON g.id_diagnostico = d.id
                    JOIN
                         compone c
                            ON c.id_enfermedad = g.id_enfermedad
            WHERE 
                d.pertenece = " + Me.Cedula + " 
            ORDER BY 
                g.id_diagnostico DESC 
            LIMIT 1
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerNombreEnfermedad()
        Command.CommandText = "
            SELECT
                DISTINCT(e.nombre)
            FROM
                genera g 
                    JOIN
                        compone c
                            ON
                                g.id_enfermedad = c.id_enfermedad
                    JOIN
                        enfermedad e
                            ON
                                c.id_enfermedad = e.id
            WHERE
                g.id_diagnostico = " + Me.IdDiagnostico + "
        "
        Return Command.ExecuteScalar.ToString
    End Function

    Public Function ObtenerNombreSintomas()
        Command.CommandText = "
            SELECT
	            DISTINCT(s.nombre)
            FROM
	            genera g 
                    JOIN 
                        compone c 
                            ON 
                                g.id_sintoma = c.id_sintoma
                    JOIN 
                        sintoma s ON c.id_sintoma = s.id
            WHERE 
                g.id_diagnostico = " + Me.IdDiagnostico + "
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function
End Class
