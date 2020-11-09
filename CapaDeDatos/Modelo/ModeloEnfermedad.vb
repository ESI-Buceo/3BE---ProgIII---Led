Public Class ModeloEnfermedad
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Id As String
    Public Nombre As String
    Public Descripcion As String
    Public Prioridad As String
    Public Sintomas As New List(Of String)


    Public Sub Insertar()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()


            Command.CommandText = "
            INSERT INTO 
                enfermedad(nombre,descripcion,prioridad) 
            VALUES
                ('" + Me.Nombre + "','" + Me.Descripcion + "','" + Me.Prioridad + "')
            "
            Command.ExecuteNonQuery()

            For Each sintoma In Sintomas
                Command.CommandText = "
                    INSERT INTO
                        compone(id_sintoma, id_enfermedad)
                    VALUES
                        ((SELECT
                            id
                        FROM
                            sintoma
                        WHERE
                            nombre = '" + sintoma + "'),
                        (SELECT
                            id
                        FROM
                            enfermedad
                        WHERE
                            nombre = '" + Nombre + "'))

                "
                Command.ExecuteNonQuery()

            Next

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
        End Try

    End Sub

    Public Sub ActivarEnfermedad()
        Command.CommandText = "
            UPDATE 
                enfermedad
            SET 
                activo = 1
            WHERE
                nombre = '" + Me.Nombre + "'
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Function EstaInactivo()
        Command.CommandText = "
            SELECT
                COUNT(id)
            FROM
                enfermedad
            WHERE
                nombre = '" + Me.Nombre + "'
                AND
                    activo = 0 > 0
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function Listar()
        Command.CommandText = "
            SELECT
                id AS ID, 
                nombre AS Nombre,
                descripcion AS Descripcion,
                prioridad AS Prioridad
            FROM
                enfermedad
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarNombreEnfermedadesActivas()
        Command.CommandText = "
            SELECT
                nombre 
            FROM
                enfermedad
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarNombreEnfermedadesInactivas()
        Command.CommandText = "
            SELECT 
                nombre
            FROM 
                enfermedad
            WHERE
                activo = 0
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarTodo()
        Command.CommandText = "
            SELECT
                id AS ID, 
                nombre AS Nombre,
                descripcion AS Descripcion,
                prioridad AS Prioridad
            FROM
                enfermedad
        "
        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Sub Modificar()
        Command.CommandText = "
            UPDATE 
                enfermedad 
            SET 
                nombre = '" + Me.Nombre + "',
                descripcion = '" + Me.Descripcion + "',
                prioridad ='" + Me.Prioridad + "' 
            WHERE 
                id = " + Me.Id + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub CambiarEnfermedadYSintomas()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                UPDATE
                    enfermedad
                SET 
                    nombre = '" + Me.Nombre + "',
                    descripcion = '" + Me.Descripcion + "',
                    prioridad ='" + Me.Prioridad + "' 
                WHERE 
                    id = " + Me.Id + "
            "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                DELETE FROM
                    compone
                WHERE
                    id_enfermedad = " + Me.Id + "
            "
            Command.ExecuteNonQuery()

            For Each sintoma In Sintomas
                Command.CommandText = "
                    INSERT INTO
                        compone(id_sintoma, id_enfermedad)
                    VALUES
                        ((SELECT
                            id
                          FROM
                            sintoma
                          WHERE
                            nombre = '" + sintoma + "'),
                        " + Me.Id + "
                            )
                "
                Command.ExecuteNonQuery()

            Next

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()

        End Try

    End Sub

    Public Sub Eliminar()
        Command.CommandText = "
                UPDATE
                    enfermedad
                SET
                    activo = 0
                WHERE
                    id = '" + Me.Id + "'
            "
        Command.ExecuteReader()

    End Sub

    Public Function ObtenerId()
        Command.CommandText = "
            SELECT
                id
            FROM
                enfermedad
            WHERE
                nombre = '" + Me.Nombre + "'
        "

        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerPrioridad()
        Command.CommandText = "
            SELECT
                prioridad
            FROM
                enfermedad
            WHERE
                id = " + Me.Id + "
        "

        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerDescripcion()
        Command.CommandText = "
            SELECT
                descripcion
            FROM
                enfermedad
            WHERE
                id = " + Me.Id + "
        "

        Return Command.ExecuteScalar.ToString()

    End Function


    Public Function ObtenerTodo()
        Command.CommandText = "
            SELECT
                nombre,
                prioridad,
                descripcion
            FROM
                enfermedad
            WHERE
                id = " + Me.Id + "
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerExistencia()
        Command.CommandText = "
            SELECT
                COUNT(id)
            FROM
                enfermedad
            WHERE 
                nombre = '" + Me.Nombre + "' > 0
        "
        Return Command.ExecuteScalar.ToString()
    End Function

    Public Sub ReactivarEnfermedad()
        Command.CommandText = "
            UPDATE
                enfermedad
            SET 
                activo = 1
            WHERE 
                nombre = '" + Me.Nombre + "'
        "
        Command.ExecuteNonQuery()
    End Sub
End Class

