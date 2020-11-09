Imports CapaDeNegocio

Public Class FrmModificarEnfermedad

    Public IdEnfermedad As String
    Dim ToolTipNombre As New ToolTip()

    Private Sub FrmModificarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerEnfermedades()
    End Sub

    Private Sub ObtenerEnfermedades()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorEnfermedad.ListarNombreEnfermedadesActivas()
            CargarEnfermedades(LectorEnfermedades)
        Catch ex As Exception
            MsgBox("No se pudieron obtener las enfermedades", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub CargarEnfermedades(lector)
        CmbEnfermedades.Items.Clear()
        While lector.Read
            CmbEnfermedades.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedades.SelectedIndexChanged
        TxtNombre.Text = CmbEnfermedades.Text
        Try
            IdEnfermedad = ControladorEnfermedad.ObtenerId(CmbEnfermedades.SelectedItem.ToString)
            ObtenerDatos()
            PctAceptar.Enabled = True
            PctCancelar.Enabled = True
        Catch ex As Exception
            MsgBox("No pudimos identificar la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub ObtenerDatos()
        Try
            TxtNombre.Text = CmbEnfermedades.Text
            TxtDescripcion.Text = ControladorEnfermedad.ObtenerDescripcion(IdEnfermedad)
            CmbPrioridad.Text = ControladorEnfermedad.ObtenerPrioridad(IdEnfermedad)
            HabilitarCampos()
            PctEliminarSintoma.Enabled = False
            If ChbModificarSintomas.Checked Then
                TraerSintomas(True)
            End If
            PctAceptar.Enabled = True
        Catch ex As Exception
            MsgBox("No pudimos cargar los datos de la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub HabilitarCampos()
        TxtNombre.Enabled = True
        TxtDescripcion.Enabled = True
        CmbPrioridad.Enabled = True
        ChbModificarSintomas.Enabled = True

    End Sub

    Private Sub CbxModificarSintomas_CheckedChanged(sender As Object, e As EventArgs) Handles ChbModificarSintomas.CheckedChanged
        HabilitarSintomas(ChbModificarSintomas.Checked)
        TraerSintomas(ChbModificarSintomas.Checked)
        CargarSintomas()

    End Sub

    Private Sub HabilitarSintomas(estado As Boolean)
        CmbSintomas.Enabled = estado
        LstSintomas.Enabled = estado

    End Sub

    Private Sub TraerSintomas(estado As Boolean)
        If estado Then
            LstSintomas.Clear()
            Try
                Dim LectorSintomas As IDataReader = ControladorCompone.ObtenerSintomasEnfermedad(IdEnfermedad)
                While LectorSintomas.Read
                    LstSintomas.Items.Add(LectorSintomas(0).ToString)
                End While
            Catch ex As Exception
                MsgBox("No se pudieron traer los síntomas de la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End Try
        Else
            LstSintomas.Clear()
        End If

    End Sub

    Private Sub CargarSintomas()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()
            CargarCmbSintomas(LectorSintomas)
        Catch ex As Exception
            MsgBox("No se pudieron cargar los síntomas para la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarCmbSintomas(lector)
        Dim i As Integer = 0
        CmbSintomas.Items.Clear()
        While lector.Read
            i = 0
            For x = 0 To LstSintomas.Items.Count() - 1
                If lector(0).ToString = LstSintomas.Items(x).Text Then
                    i = 1
                End If
            Next
            If i = 0 Then
                CmbSintomas.Items.Add(lector(0).ToString)
            End If

        End While

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        PctAgregarSintoma.Enabled = True

    End Sub

    Private Sub LstSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstSintomas.SelectedIndexChanged
        PctEliminarSintoma.Enabled = True

    End Sub

    Private Sub ValidarEnfermedadYSintoma()
        If TxtNombre.Text = "" Then
            ToolTipNombre.AutoPopDelay = 2000
            ToolTipNombre.InitialDelay = 500
            ToolTipNombre.ReshowDelay = 500
            ToolTipNombre.ToolTipTitle = "Formato incorrecto"
            ToolTipNombre.ToolTipIcon = ToolTipIcon.Warning
            ToolTipNombre.SetToolTip(Me.TxtNombre, "El nombre de la enfermedad no puede estar vacio")

        ElseIf LstSintomas.Items.Count() <= 0 Then
            MsgBox("Debe existir por lo menos un síntoma")
        Else
            Dim Sintomas As New List(Of String)
            For x = 0 To LstSintomas.Items.Count() - 1
                Sintomas.Add(LstSintomas.Items(x).Text)
            Next
            CambiarEnfermedadYSintomas(Sintomas)
        End If

    End Sub

    Private Sub CambiarEnfermedadYSintomas(sintomas As List(Of String))
        Try
            ControladorEnfermedad.CambiarEnfermedadYSintomas(IdEnfermedad,
                                                             TxtNombre.Text,
                                                             TxtDescripcion.Text,
                                                             CmbPrioridad.SelectedItem.ToString,
                                                             sintomas)
            MsgBox("Se modificó la enfermedad y su composicion con éxito!", MsgBoxStyle.Information, "Modificación de Enfermedad")
            Limpiar()
        Catch ex As Exception
            MsgBox("Error al intentar actualizar la enfermedad y sus síntomas", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub ValidarEnfermedad()
        If TxtNombre.Text = "" Then
            ToolTipNombre.AutoPopDelay = 2000
            ToolTipNombre.InitialDelay = 500
            ToolTipNombre.ReshowDelay = 500
            ToolTipNombre.ToolTipTitle = "Formato incorrecto"
            ToolTipNombre.ToolTipIcon = ToolTipIcon.Warning
            ToolTipNombre.SetToolTip(Me.TxtNombre, "El nombre de la enfermedad no puede estar vacio")
        Else
            CambiarEnfermedad()
        End If

    End Sub

    Private Sub CambiarEnfermedad()
        Try
            ControladorEnfermedad.CambiarEnfermedad(IdEnfermedad,
                                                    TxtNombre.Text,
                                                    TxtDescripcion.Text,
                                                    CmbPrioridad.SelectedItem.ToString)
            MsgBox("Enfermedad modificada con éxito!", MsgBoxStyle.Information, "Modifcación de Enfermedad")
            Limpiar()
        Catch ex As Exception
            MsgBox("Error al intentar modificar la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub Limpiar()
        If ChbModificarSintomas.Checked Then
            LimpiarEnfermedad()
            LimpiarSintomas()
        Else
            LimpiarEnfermedad()
        End If
        CmbPrioridad.Text = ""
        PctCancelar.Enabled = False
        TxtDescripcion.Enabled = False
        TxtNombre.Enabled = False
        CmbPrioridad.Enabled = False
        PctAceptar.Enabled = False

    End Sub

    Private Sub LimpiarEnfermedad()
        CmbPrioridad.Text = ""
        TxtDescripcion.Text = ""
        TxtNombre.Text = ""
        CmbEnfermedades.SelectedItem = -1
        ObtenerEnfermedades()

    End Sub

    Private Sub LimpiarSintomas()
        LstSintomas.Clear()
        CmbSintomas.Items.Clear()
        CmbSintomas.SelectedItem = -1
        ChbModificarSintomas.Checked = False

    End Sub

    Private Sub PctCancelar_Click(sender As Object, e As EventArgs) Handles PctCancelar.Click
        ObtenerDatos()

    End Sub

    Private Sub PctCancelar_MouseEnter(sender As Object, e As EventArgs) Handles PctCancelar.MouseEnter
        PctCancelar.Image = My.Resources.Cancelar2

    End Sub

    Private Sub PctCancelar_MouseLeave(sender As Object, e As EventArgs) Handles PctCancelar.MouseLeave
        PctCancelar.Image = My.Resources.Cancelar1

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        If ChbModificarSintomas.Checked Then
            ValidarEnfermedadYSintoma()
        Else
            ValidarEnfermedad()
        End If

    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub


    Private Sub PctSalir_Click(sender As Object, e As EventArgs) Handles PctSalir.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub PctEliminarSintoma_Click(sender As Object, e As EventArgs) Handles PctEliminarSintoma.Click
        CmbSintomas.Items.Add(LstSintomas.Items(LstSintomas.SelectedIndices(0)).Text)
        LstSintomas.Items.RemoveAt(LstSintomas.SelectedIndices(0))
        PctEliminarSintoma.Enabled = False

    End Sub

    Private Sub PctAgregarSintoma_Click(sender As Object, e As EventArgs) Handles PctAgregarSintoma.Click
        Dim index As Integer = CmbSintomas.SelectedIndex
        LstSintomas.Items.Add(CmbSintomas.Items(index))
        CmbSintomas.Items.RemoveAt(index)
        PctAgregarSintoma.Enabled = False

    End Sub

End Class