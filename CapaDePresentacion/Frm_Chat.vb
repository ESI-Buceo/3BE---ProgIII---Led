Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Chat

    Dim CiMedico As String
    Dim IdDiagnostico As String

    Private Sub Frm_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarMensaje("<p> Un médico se pondrá en contacto con usted en la brevedad </p>", 0)
        IdDiagnostico = ControladorDiagnostico.ObtenerID()
        TmrMensajesNuevos.Start()
        RtbMensaje.Enabled = False

    End Sub

    Private Sub TmrMensajesNuevos_Tick(sender As Object, e As EventArgs) Handles TmrMensajesNuevos.Tick
        BusquedaDeMensajes()

    End Sub

    Private Sub BusquedaDeMensajes()
        Dim MensajeNuevo As New DataTable
        Try
            MensajeNuevo = ControladorChat.BuscarMensajesNuevos(IdDiagnostico)
            If MensajeNuevo.Rows.Count > 0 Then
                AgregarChat(MensajeNuevo)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub AgregarChat(mensaje As DataTable)
        ControladorChat.MarcarComoLeido(IdDiagnostico)

        For Each fila As DataRow In mensaje.Rows
            If fila(5).ToString = "Finalizado" Then
                MsgBox("El doctor a finalizado el chat", MsgBoxStyle.OkOnly, "Confirmación...")
                TerminarChat()
                Me.Close()
                Frm_Menu.Show()
            Else
                AgregarMensaje("<p align = 'left' > " + fila(4).ToString + " : " + fila(2).ToString + "</p>", 1)
                CiMedico = fila(0).ToString
                RtbMensaje.Enabled = True

            End If

        Next

    End Sub

    Private Sub RtbMensaje_TextChanged(sender As Object, e As EventArgs) Handles RtbMensaje.TextChanged
        If RtbMensaje.Text <> "" Then
            PctEnviar.Enabled = True
            PctEnviar.Image = My.Resources.EnviarFondoClaro

        Else
            PctEnviar.Enabled = False
            PctEnviar.Image = My.Resources.EnviarBloqueadoFondoClaro
        End If

    End Sub

    Private Sub PctEnviar_Click(sender As Object, e As EventArgs) Handles PctEnviar.Click
        Try
            ControladorChat.EnviarMensajePaciente(IdDiagnostico, RtbMensaje.Text, CiMedico)
            AgregarMensaje("<p align = 'right'>" + RtbMensaje.Text + "</p>", 0)
            BtnEnviar.Enabled = False
        Catch ex As Exception
            MsgBox("No se pudo enviar el mensaje", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

        End Try

    End Sub

    Private Sub AgregarMensaje(Mensaje As String, Emisor As Integer)
        WbbConversacion.DocumentText += Mensaje
        If Emisor = 0 Then
            RtbMensaje.Text = ""
        End If

    End Sub

    Private Sub FinalizarConMedico()
        Try
            ControladorChat.FinalizarChatConMedico(IdDiagnostico, CiMedico)
            MarcarChatComoFinalizado()

        Catch ex As Exception
            MsgBox("Error finalizar chat paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub FinalizarSinMedico()
        Try
            ControladorChat.FinalizarChatSinMedico(IdDiagnostico)
            MarcarChatComoFinalizado()

        Catch ex As Exception
            MsgBox("Error intentando finalizar el chat", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub MarcarChatComoFinalizado()
        Try
            ControladorChat.MarcarComoFinalizado(IdDiagnostico)
        Catch ex As Exception
            MsgBox("Error al intentar finalizar el chat", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub TerminarChat()
        TmrMensajesNuevos.Stop()
        WbbConversacion.DocumentText = ""
        RtbMensaje.Text = ""
        BtnEnviar.Enabled = False
        RtbMensaje.Enabled = False

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Select Case MsgBox("¿Seguro quiere salir del chat?", MsgBoxStyle.YesNo, "Confirmación...")
            Case MsgBoxResult.Yes
                If CiMedico <> "" Then
                    FinalizarConMedico()
                Else
                    FinalizarSinMedico()
                End If

                TerminarChat()
                Me.Close()
                Frm_Menu.Show()
            Case MsgBoxResult.No

        End Select

    End Sub


End Class