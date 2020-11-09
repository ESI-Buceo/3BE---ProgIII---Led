Imports CapaDeNegocio
Imports System.ComponentModel
Imports System.Net.Mail

Public Class Frm_Enviar_Recomendaciones

    Dim Correo As String
    Dim Nombre As String
    Dim Apellido As String
    Dim Cedula As String

    Public Property Response As Object

    Private Sub Frm_Enviar_Recomendaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Correo = ControladorUsuario.ObtenerCorreo()
        Catch ex As Exception
            MsgBox("Error al intentar obtener su correo", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CmbAcciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAcciones.SelectedIndexChanged
        CmbSobre.Enabled = True
        VerificarCmb()
    End Sub

    Private Sub CmbSobre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSobre.SelectedIndexChanged
        If CmbAcciones.Text = "Agregar" Then
            RtbMensaje.Enabled = True
        Else
            RtbMensaje.Enabled = False
        End If

    End Sub

    Private Sub VerificarCmb()
        If CmbAcciones.Text = "Modificar" Or CmbAcciones.Text = "Eliminar" Then
            CmbItem.Enabled = True
            If CmbSobre.Text = "Sintoma" Then
                CargarSintomas()
            ElseIf CmbSobre.Text = "Enfermedad" Then
                CargarEnfermedades()
            End If
        Else
            CmbItem.Enabled = False
            RtbMensaje.Enabled = False

        End If

    End Sub

    Private Sub HabilitarCmbItems()
        CmbItem.Enabled = True
        CmbItem.Visible = True

    End Sub

    Private Sub CargarSintomas()
        LimpiarCmbItems()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()

            While LectorSintomas.Read
                CmbItem.Items.Add(LectorSintomas(0))
            End While
            HabilitarCmbItems()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarEnfermedades()
        LimpiarCmbItems()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorEnfermedad.ListarNombreEnfermedadesActivas()

            While LectorEnfermedades.Read
                CmbItem.Items.Add(LectorEnfermedades(0))
            End While
            HabilitarCmbItems()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarCmbItems()
        CmbItem.Items.Clear()

    End Sub

    Private Sub PctEnviarCorreo_Click(sender As Object, e As EventArgs) Handles PctEnviarCorreo.Click
        Dim Correo As New MailMessage()
        Dim smtp As New SmtpClient()

        With smtp
            .UseDefaultCredentials = False
            .Credentials = New Net.NetworkCredential("cuidartemed@gmail.com", "MedCuidarte")
            .Port = 587
            .EnableSsl = True
            .Host = "smtp.gmail.com"
        End With

        With Correo
            .From = New MailAddress("cuidartegestor@gmail.com", "Cuidarte", System.Text.Encoding.UTF8)
            .To.Add("cuidartegestor@gmail.com")
            .Subject = ObtenerAsunto()
            .SubjectEncoding = System.Text.Encoding.UTF8
            ObtenerDatosMedico()
            .Body = ObtenerMensaje()
            .BodyEncoding = System.Text.Encoding.UTF8
            .IsBodyHtml = False
        End With

        Try
            smtp.Send(Correo)
            MsgBox("Mensaje enviado con éxito!", MsgBoxStyle.Information, "Enviado...")
        Catch ex As Exception
            If ex.HResult = "-2146233088" Then
                MsgBox("No pudimos enviar el correo", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            Else

            End If
        End Try
        LimpiarCmbItems()
        RtbMensaje.Text = ""

    End Sub

    Public Function ObtenerAsunto()
        Dim Asunto As String
        If CmbAcciones.Text = "Agregar" Then
            Asunto = CmbAcciones.Text + " " + CmbSobre.Text
        Else
            Asunto = CmbAcciones.Text + " " + CmbSobre.Text + " " + CmbItem.Text
        End If
        Return Asunto
    End Function

    Public Sub ObtenerDatosMedico()
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorUsuario.ObtenerNombreApellidoCedula()
            CargarDatosMedico(LectorDatos)

        Catch ex As Exception
            MsgBox("Error al intentar obtener sus datos", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

        End Try

    End Sub

    Public Sub CargarDatosMedico(Lector As IDataReader)
        While Lector.Read
            Nombre = Lector(0).ToString
            Apellido = Lector(1).ToString
            Cedula = Lector(2).ToString
        End While

    End Sub

    Public Function ObtenerMensaje()
        Dim Mensaje As String = "Le escribe el doctor " + Nombre + " " + Apellido + " con cedula de indentidad " + Cedula + " para realizar la siguiente recomendacón. " + RtbMensaje.Text

        Return Mensaje
    End Function

    Private Sub Frm_Enviar_Recomendaciones_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Frm_Menu.Show()

    End Sub

    Private Sub RtbMensaje_TextChanged(sender As Object, e As EventArgs) Handles RtbMensaje.TextChanged
        If RtbMensaje.Text <> "" Then
            PctEnviarCorreo.Enabled = True
            PctEnviarCorreo.Image = My.Resources.EnviarCorreoFondoClaro
            PctEnviarCorreo.Cursor = Cursors.Hand
        Else
            PctEnviarCorreo.Enabled = False
            PctEnviarCorreo.Image = My.Resources.EnviarMensajeBloqueadoFondoClaro
            PctEnviarCorreo.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.MouseClick
        Me.Dispose()
        Frm_Menu.Show()

    End Sub

    Private Sub CmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbItem.SelectedIndexChanged
        RtbMensaje.Enabled = True

    End Sub
End Class