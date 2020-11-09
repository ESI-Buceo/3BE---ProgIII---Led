Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Menu

    Public Cedula As String
    Public ListaSintomas As New List(Of String)
    Dim NombreEnfermedad As String
    Dim EstadoMenu As Boolean = False
    Dim Random As New Random()
    Dim Numero As Integer = Random.Next(1, 4)

    Private Sub Frm_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If ControladorPaciente.ObtenerSexo = 0 Then
                LblSaludo.Text = "Bienvenido, " + ControladorUsuario.ObtenerNombre() + ""
            Else
                LblSaludo.Text = "Bienvenida, " + ControladorUsuario.ObtenerNombre() + ""
            End If

        Catch ex As Exception
            LblSaludo.Text = "Bienvenido!"

        End Try

        CargarSintoma()

    End Sub

    Private Sub CargarSintoma()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()

            While LectorSintomas.Read
                CmbSintomas.Items.Add(LectorSintomas(0))
            End While

        Catch ex As Exception
            MsgBox("No pudimos cargar los sintomas, intente reiniciar la aplicacion", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

        End Try

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        Dim index As Integer = CmbSintomas.SelectedIndex
        ListaSintomas.Add(CmbSintomas.Items(index))
        CmbSintomas.Items.RemoveAt(index)
        CargarListado(ListaSintomas)

    End Sub

    Private Sub CargarListado(ListaSintomas As List(Of String))
        LvSintomas.Clear()
        For Each sintoma In ListaSintomas
            LvSintomas.Items.Add(sintoma)
        Next
        HabilitarRealizarDiagnostico()

    End Sub

    Private Sub BtnDiagnostico_Click(sender As Object, e As EventArgs) Handles BtnDiagnostico.Click
        Try
            NombreEnfermedad = ControladorCompone.EnfermedadesPosibles(ListaSintomas)
        Catch ex As Exception
            MsgBox("No se encontró una enfermedad que coincida de manera exacta, se buscará la mas probable", MsgBoxStyle.Information, "Busqueda...")
            Try
                NombreEnfermedad = ControladorCompone.EnfermedadesPorAproximacion(ListaSintomas)
            Catch ex1 As Exception
                MsgBox("No pudimos encontrar ninguna enfermedad, intente con mas sintomas", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End Try

        End Try
        GuardarPadecimientos()
        ObtenerIdEnfermedadDiagnosticada()
        VolverACargarSintomas()
        LvSintomas.Clear()
        ListaSintomas.Clear()

    End Sub

    Private Sub VolverACargarSintomas()
        For x = 0 To ListaSintomas.Count() - 1
            CmbSintomas.Items.Add(ListaSintomas(x).ToString)
        Next

    End Sub

    Private Sub GuardarPadecimientos()
        Try
            ControladorPadece.GuardarSintomasPadecidos(ListaSintomas)
        Catch ex As Exception
            MsgBox("Error al intentar guardar los síntomas", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Public Sub ObtenerIdEnfermedadDiagnosticada()
        Dim IdEnfermedad As String
        If NombreEnfermedad <> "" Then
            Try
                IdEnfermedad = ControladorEnfermedad.ObtenerId(NombreEnfermedad)
                RealizarDiagnostico(IdEnfermedad)

            Catch ex As Exception
                MsgBox("No se pudo hallar el identificador de la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

            End Try
        End If

    End Sub

    Public Sub RealizarDiagnostico(idEnfermedad As String)
        Try
            ControladorDiagnostico.Nuevo(ListaSintomas, idEnfermedad)
            Frm_Iniciar_Chat.Show()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo realizar un diagnóstico", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub LvSintomas_DoubleClick(sender As Object, e As EventArgs) Handles LvSintomas.DoubleClick
        CmbSintomas.Items.Add(LvSintomas.Items(LvSintomas.SelectedIndices(0)).Text)
        LvSintomas.Items.RemoveAt(LvSintomas.SelectedIndices(0))
        ActualizarLista()

    End Sub

    Private Sub ActualizarLista()
        ListaSintomas.Clear()
        For x = 0 To LvSintomas.Items.Count - 1
            ListaSintomas.Add(LvSintomas.Items(x).Text)
        Next
        HabilitarRealizarDiagnostico()
    End Sub

    Private Sub Frm_Paciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Close()

    End Sub

    Private Sub BtnConsultaHistorial_Click(sender As Object, e As EventArgs)
        Frm_Consultas.Show()
        Me.Hide()

    End Sub

    Private Sub BtnDatosPriopios_Click(sender As Object, e As EventArgs)
        Frm_Cambiar_Datos_Propios.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Menu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmLogin.Close()
    End Sub

    Private Sub LvSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvSintomas.SelectedIndexChanged
        HabilitarRealizarDiagnostico()

    End Sub

    Private Sub HabilitarRealizarDiagnostico()
        If LvSintomas.Items.Count() > 0 Then
            BtnDiagnostico.Enabled = True
        Else
            BtnDiagnostico.Enabled = False
        End If
        ModificarAdvertencia()
    End Sub

    Private Sub ModificarAdvertencia()
        If LvSintomas.Items.Count() < 3 Then
            LblAdvertencia.Text = "La cantidad de síntomas es muy baja," + vbCrLf + "la enfermedad resultante será poco precisa"
        Else
            LblAdvertencia.Text = ""
        End If
    End Sub

    Private Sub PctMenu_Click(sender As Object, e As EventArgs) Handles PctMenu.Click
        EstadoMenu = Not EstadoMenu
        PctConsultas.Visible = True
        PctDatosPropios.Visible = True
        If EstadoMenu Then
            AbrirMenu()
        Else
            CerrarMenu()
        End If

    End Sub

    Private Sub AbrirMenu()
        RandomPickImageTrapCardActivatedOver5000()
        PnlMenu.BackColor = Color.FromArgb(53, 71, 94)
        While PnlMenu.Height < 410
            PnlMenu.Height += 1
        End While

    End Sub

    Private Sub CerrarMenu()
        PnlMenu.BackColor = Color.FromArgb(217, 223, 231)
        While PnlMenu.Height > 10
            PnlMenu.Height = 10
        End While

    End Sub

    Private Sub RandomPickImageTrapCardActivatedOver5000()

        If ControladorPaciente.ObtenerSexo() = 0 Then
            If Numero = 1 Then
                PctDatosPropios.Image = My.Resources.Men1
            ElseIf Numero = 2 Then
                PctDatosPropios.Image = My.Resources.Men2
            Else
                PctDatosPropios.Image = My.Resources.Men3n
            End If

        Else
            If Numero = 1 Then
                PctDatosPropios.Image = My.Resources.Fem1
            ElseIf Numero = 2 Then
                PctDatosPropios.Image = My.Resources.Fem2
            ElseIf Numero = 3 Then
                PctDatosPropios.Image = My.Resources.Fem3
            Else
                PctDatosPropios.Image = My.Resources.Fem4
            End If

        End If

    End Sub

    Private Sub PctMenu_MouseEnter(sender As Object, e As EventArgs) Handles PctMenu.MouseEnter
        PctMenu.Image = My.Resources.MenuHamb2

    End Sub

    Private Sub PctMenu_MouseLeave(sender As Object, e As EventArgs) Handles PctMenu.MouseLeave
        PctMenu.Image = My.Resources.MenuHamb1

    End Sub

    Private Sub PctSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles PctSalir.MouseMove
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_Click(sender As Object, e As EventArgs) Handles PctSalir.Click
        Me.Close()

    End Sub

    Private Sub PctDatosPropios_Click(sender As Object, e As EventArgs) Handles PctDatosPropios.Click
        Me.Dispose()
        Frm_Cambiar_Datos_Propios.Show()
    End Sub

    Private Sub PctDatosPropios_MouseEnter(sender As Object, e As EventArgs) Handles PctDatosPropios.MouseEnter
        LblMisDatos.Visible = True

    End Sub

    Private Sub PctDatosPropios_MouseLeave(sender As Object, e As EventArgs) Handles PctDatosPropios.MouseLeave
        LblMisDatos.Visible = False

    End Sub

    Private Sub PctConsultas_MouseEnter(sender As Object, e As EventArgs) Handles PctConsultas.MouseEnter
        LblHistorial.Visible = True

    End Sub

    Private Sub PctConsultas_MouseLeave(sender As Object, e As EventArgs) Handles PctConsultas.MouseLeave
        LblHistorial.Visible = False

    End Sub

    Private Sub PctConsultas_Click(sender As Object, e As EventArgs) Handles PctConsultas.Click
        Me.Dispose()
        Frm_Consultas.Show()
    End Sub
End Class