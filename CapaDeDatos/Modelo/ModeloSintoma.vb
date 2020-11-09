Public Class ModeloSintoma
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public ListadoSintomas As List(Of String)
    Public IdSintoma As String
    Public Nombre As String
    Public Activo As String

    Public Function Listar()
        Command.CommandText = "
            SELECT
                nombre
            FROM
                sintoma
            WHERE
                nombre LIKE '%" + Me.Nombre + "%'
                AND
                    activo = 1
            "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarNombreSintomaActivo()
        Command.CommandText = "
            SELECT 
                nombre AS Sintoma 
            FROM 
                sintoma
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarNombreSintomaInactivo()
        Command.CommandText = "
            SELECT 
                nombre AS Sintoma 
            FROM 
                sintoma
            WHERE
                activo = 0
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub Insertar()
        Command.CommandText = "
            INSERT INTO 
                sintoma(nombre) 
            VALUES
                ('" + Me.Nombre + "')
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()
        Command.CommandText = "
            UPDATE 
                sintoma    
            SET 
                nombre = '" + Me.Nombre + "' 
            WHERE 
                id = " + Me.IdSintoma + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Eliminar()
        Command.CommandText = "
            UPDATE 
                sintoma 
            SET 
                activo = 0 
            WHERE 
                id = " + Me.IdSintoma + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Eliminar(nombre As String)
        Command.CommandText = "
            UPDATE 
                sintoma 
            SET 
                activo = 0 
            WHERE 
                nombre = " + nombre + "
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Function ObtenerExistencia()
        Command.CommandText = "
            SELECT
                COUNT(id)
            FROM
                sintoma
            WHERE
                nombre = '" + Me.Nombre + "' > 0
        "
        Return Command.ExecuteScalar.ToString

    End Function

    Public Function EstaInactivo()
        Command.CommandText = "
            SELECT
                COUNT(id)
            FROM
                sintoma
            WHERE
                nombre = '" + Me.Nombre + "'
                AND
                    activo = 0 > 0
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerId()
        Command.CommandText = "
            SELECT
                id
            FROM
                sintoma
            WHERE
                nombre = '" + Me.Nombre + "'
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Sub ActivarSintoma()
        Command.CommandText = "
            UPDATE
                sintoma
            SET 
                activo = 1
            WHERE
                id = " + Me.IdSintoma + "
        "
        Command.ExecuteNonQuery()

    End Sub

End Class