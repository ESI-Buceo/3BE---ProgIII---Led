Public Class ModeloChat
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Cedula As String
    Public CiPaciente As String
    Public CiMedico As String
    Public IdDiagnostico As String
    Public Mensaje As String
    Public MiNombre As String
    Public MiApellido As String

    Public Sub EnviarSolicitud()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_paciente, id_diagnostico, leido)
            VALUES
                (" + Me.Cedula + ", " + Me.IdDiagnostico + ", 0)
        "
        Command.ExecuteNonQuery()
        Me.Connect.Close()
    End Sub

    Public Function BuscarSolicitud()
        Command.CommandText = "
            SELECT 
                DISTINCT(a.id_diagnostico) AS id, 
                a.ci_persona_paciente AS Paciente, 
                e.prioridad 
            FROM 
                atiende a 
                JOIN 
                diagnostico d 
                    ON a.id_diagnostico = d.id 
                JOIN 
                genera g 
                    ON g.id_diagnostico = d.id 
                JOIN compone c 
                    ON c.id_enfermedad = g.id_enfermedad
                JOIN enfermedad e 
                    ON e.id = c.id_enfermedad 
            WHERE 
                leido = 0 
                AND 
                status = 'Esperando' 
            ORDER BY 
                FIELD(prioridad,'ALTA','MEDIA','BAJA'),
                a.fecha_hora asc;
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Sub AceptarSolicitud()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES(
                " + Me.Cedula + ",
                " + Me.CiPaciente + ",
                " + Me.IdDiagnostico + ",
                'Buen día, soy el doctor " + Me.MiNombre + " " + Me.MiApellido + ", como puedo ayudarle hoy? ',
                0,
                " + Me.CiPaciente + ",
                'Iniciado'
                )                            
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Sub EnviarMensajePaciente()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.CiMedico + ", " + Me.Cedula + ", " + Me.IdDiagnostico + ", '" + Me.Mensaje + "', 0, " + Me.CiMedico + ", 'Iniciado' )
            
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Sub EnviarMensajeMedico()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.Cedula + ", " + Me.CiPaciente + ", " + Me.IdDiagnostico + ", '" + Me.Mensaje + "', 0, " + Me.CiPaciente + ", 'Iniciado' )
            
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Function BuscarMensajesNuevos()
        Command.CommandText = "
            SELECT 
                a.ci_persona_medico,
                a.ci_persona_paciente,
                a.mensaje, 
                a.destinatario, 
                p.nombre,
                a.status
            FROM 
                atiende a 
                    JOIN 
                        medico m 
                            ON 
                                a.ci_persona_medico = m.ci_persona 
                    JOIN 
                        persona p 
                            ON 
                                p.ci = m.ci_persona 
            WHERE 
                id_diagnostico = " + Me.IdDiagnostico + "
                AND
                    destinatario = " + Me.Cedula + "
                AND
                    leido = 0
            LIMIT
                1
        "
        Dim Resultado As New DataTable
        Resultado.Load(Me.Command.ExecuteReader)
        Me.Connect.Close()
        Return Resultado

    End Function

    Public Sub MarcarComoLeido()
        Command.CommandText = "
            UPDATE
                atiende
            SET 
                leido = 1
            WHERE
                id_diagnostico = " + Me.IdDiagnostico + "
                AND
                    destinatario = " + Me.Cedula + "
                "
        Command.ExecuteNonQuery()

        Me.Connect.Close()
    End Sub

    Public Sub FinalizarChatConMedico()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.CiMedico + ", " + Me.Cedula + ", " + Me.IdDiagnostico + ", 'paciente desconectado', 0, " + Me.CiMedico + ", 'Finalizado' )
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub FinalizarChatSinMedico(id As String)
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_paciente, id_diagnostico, mensaje, leido, status)
            VALUES
                (" + Me.Cedula + ", " + id + ",'paciente desconectado', 0, 'Finalizado')   
        "

        Command.ExecuteNonQuery()
    End Sub

    Public Sub FinalizarChatMedico()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.Cedula + ", " + Me.CiPaciente + ", " + Me.IdDiagnostico + ", 'medico desconectado', 0, " + Me.CiPaciente + ", 'Finalizado' )
            
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Sub MarcarComoFinalizado()
        Command.CommandText = "
            UPDATE
                atiende
            SET
                status = 'Finalizado'
            WHERE
                id_diagnostico = " + Me.IdDiagnostico + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Function ObtenerIdFechaMisChat()
        Command.CommandText = "
            SELECT
                id_diagnostico AS Id,
                fecha_hora AS Fecha
            FROM
                atiende
            WHERE
                ci_persona_medico = " + Me.Cedula + "
            GROUP BY
                id_diagnostico
            "
        Reader = Command.ExecuteReader
        Return Reader
    End Function

    Public Function ObtenerMensajesDelDiagnostico()
        Command.CommandText = "
             SELECT 
                fecha_hora, 
                mensaje, 
                destinatario 
            FROM 
                atiende 
            WHERE 
                id_diagnostico = " + Me.IdDiagnostico + " 
        "

        Reader = Command.ExecuteReader()
        Return Reader
    End Function

End Class
