Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Iniciar_Chat

    Public Sub Frm_Iniciar_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idEnfermedad As String
        Try
            idEnfermedad = ControladorGenera.ObtenerIdEnfermedadGenerada()
            ObtenerDiagnostico()
            CargarTextBoxes(idEnfermedad)
        Catch ex As Exception
            MsgBox("No pudimos guardar el identificador de la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub ObtenerDiagnostico()
        Try
            LblId.Text = "ID del diagnóstico " + ControladorDiagnostico.ObtenerID()
        Catch ex As Exception
            MsgBox("No se pudo obtener un identificador para este diagnóstico", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            BtnIniciarChat.Enabled = False
        End Try

    End Sub

    Public Sub CargarTextBoxes(idEnfermedad As String)
        Dim Lector As IDataReader
        Try
            Lector = ControladorEnfermedad.ObtenerTodo(idEnfermedad)
            While Lector.Read
                TxtEnfermedad.Text = Lector(0)
                TxtDescripcion.Text = Lector(2)
                DecidirImagenSegunPrioridad(Lector(1))
            End While
        Catch ex As Exception
            MsgBox("Error al intentar cargar los campos", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            TxtDescripcion.Text = "No se pudieron cargar los datos"
        End Try

    End Sub

    Private Sub DecidirImagenSegunPrioridad(prioridad As String)
        If prioridad = "ALTA" Then
            PctPrioridad.Image = My.Resources.ErrorFondoClaro
        ElseIf prioridad = "MEDIA" Then
            PctPrioridad.Image = My.Resources.InfoFondoClaro
        Else
            PctPrioridad.Image = My.Resources.CorrectoFondoClaro
        End If
    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        Try
            ControladorChat.EnviarSolicitud(ControladorDiagnostico.ObtenerID())
            Me.Hide()
            Frm_Chat.Show()

        Catch ex As Exception
            MsgBox("No pudimos ponerlo en cola de espera", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

        End Try

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        Frm_Menu.Show()
    End Sub

    Private Sub Frm_Iniciar_Chat_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ObtenerDiagnostico()
    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Select Case MsgBox("Seguro desea salir, siempre le recomendamos resolver su diagnóstico con un médico", MsgBoxStyle.YesNo, "Confirmación...")
            Case DialogResult.Yes
                Me.Dispose()
                Frm_Menu.Show()

            Case DialogResult.No

        End Select

    End Sub
End Class