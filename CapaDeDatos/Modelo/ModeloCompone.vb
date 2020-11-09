Public Class ModeloCompone
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdSintomas As New List(Of String)
    Public IdEnfermedad As String

    Public Function EnfermedadesPosibles()
        Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())

        Command.CommandText = "
            SELECT 
                e.nombre, 
                e.prioridad, 
                e.descripcion
            FROM 
                enfermedad e 
                    JOIN 
                        compone c 
                            ON 
                                e.id = c.id_enfermedad
            WHERE
                e.activo = 1
            GROUP BY 
                id_enfermedad
            HAVING
                
        "

        For Each sintoma In IdSintomas
            Command.CommandText += "
                    SUM(id_sintoma = (SELECT
                                        id
                                     FROM
                                        sintoma
                                     WHERE 
                                        nombre = '" + sintoma + "'
                                        AND
                                        activo = 1)
                        ) > 0 
                    AND         
                "

        Next
        Command.CommandText += "
                    SUM(id_sintoma NOT IN(SELECT
                                            id
                                        FROM
                                            sintoma
                                        WHERE
                                            nombre IN(
                                                " + values + ")
                                        )
                        ) = 0
        "

        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function EnfermedadesPorAproximacion()
        Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())
        Dim NuevoNombre As String = "Sintomas en comun"

        Command.CommandText = "         
            SELECT
                e.nombre AS Enfermedad,
                COUNT(*) AS  '" + NuevoNombre + "'
            FROM
                compone c
                JOIN
                sintoma s ON c.id_sintoma = s.id
                JOIN
                enfermedad e ON c.id_enfermedad = e.id
            WHERE
                c.id_sintoma IN (
                    SELECT 
                        id
                    FROM
                        sintoma
                    WHERE
                        nombre IN(
                            " + values + "
                        ) AND activo = 1
                )
                    AND
                    e.activo = 1
            GROUP BY
                c.id_enfermedad
            ORDER BY
                COUNT(*) DESC,
                e.nombre
        "

        Return Command.ExecuteScalar.ToString

    End Function

    Public Sub Insertar()
        For Each Nombre In IdSintomas
            Command.CommandText = "
                    INSERT INTO
                        compone(id_sintoma, id_enfermedad)
                    VALUES
                        ((SELECT
                            id
                        FROM
                            sintoma
                        WHERE
                            nombre = '" + Nombre + "'),
                        (SELECT
                            id
                        FROM
                            enfermedad
                        WHERE
                            nombre = '" + IdEnfermedad + "'))

                "
            Command.ExecuteNonQuery()
        Next

    End Sub

    Public Function ObtenerSintomasEnfermedad()
        Command.CommandText = "
            SELECT
                s.nombre
            FROM
                compone c 
                    JOIN
                        sintoma s
                            ON
                                c.id_sintoma = s.id
            WHERE
                id_enfermedad = " + Me.IdEnfermedad + "
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

End Class