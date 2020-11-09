Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Cambiar_Datos_Propios

    Dim Nombre As Boolean
    Dim Apellido As Boolean
    Dim Correo As Boolean
    Dim Sexo As String
    Dim FechaNacimiento As String
    Dim Enfermedades As New List(Of String)
    Dim Medicaciones As New List(Of String)
    Dim ToolTipNombre As New ToolTip()
    Dim ToolTipApellido As New ToolTip()
    Dim ToolTipCorreo As New ToolTip()

    Private Sub Frm_Cambiar_Datos_Propios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatosPersona()
        ObtenerMedicacionesPaciente()
        ObtenerEnfermedadesCronicas()
        DttFecha.MaxDate = Today


    End Sub

    Public Sub ObtenerDatosPersona()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerTodo()
            CargarTextBoxes(Lector)
        Catch ex As Exception
            MsgBox("Error al intentar obtener sus datos", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Public Sub CargarTextBoxes(Lector As IDataReader)
        While Lector.Read
            LblCedula.Text = "Cedula: " + Lector(0).ToString
            TxtNombre.Text = Lector(1).ToString
            TxtApellido.Text = Lector(2).ToString
            TxtCorreo.Text = Lector(3).ToString
            If Lector(4).ToString = 0 Then
                RdbMasculino.Checked = True
            Else
                RdbMujer.Checked = True
            End If
            AdaptarFecha(Lector(5).ToString)

        End While

    End Sub

    Public Sub AdaptarFecha(fecha As Date)
        DttFecha.Value = fecha.Date

    End Sub

    Public Sub ObtenerMedicacionesPaciente()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerMedicaciones()
            CargarListaMedicaciones(Lector)
        Catch ex As Exception
            MsgBox("Error al intentar obtener sus medicaciónes", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Public Sub CargarListaMedicaciones(Lector As IDataReader)
        LstMedicaciones.Clear()
        While Lector.Read
            LstMedicaciones.Items.Add(Lector(0).ToString)
        End While

    End Sub

    Public Sub ObtenerEnfermedadesCronicas()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerEnfermedades()
            CargarListaEnfermedades(Lector)
        Catch ex As Exception
            MsgBox("Error al intentar obtener sus enfermedades", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Public Sub CargarListaEnfermedades(Lector As IDataReader)
        LstEnfermedadesCronicas.Clear()
        While Lector.Read
            LstEnfermedadesCronicas.Items.Add(Lector(0).ToString)
        End While

    End Sub

    Private Sub TxtAgregarEnfermedad_TextChanged(sender As Object, e As EventArgs) Handles TxtAgregarEnfermedad.TextChanged
        If TxtAgregarEnfermedad.Text <> "" Then
            PctAgregarEnfermedad.Enabled = True
        Else
            PctAgregarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub PctAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.Click
        LstEnfermedadesCronicas.Items.Add(TxtAgregarEnfermedad.Text)
        TxtAgregarEnfermedad.Text = ""

    End Sub

    Private Sub TxtAgregarMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtAgregarMedicacion.TextChanged
        If TxtAgregarMedicacion.Text <> "" Then
            PctAgregarMedicacion.Enabled = True
        Else
            PctAgregarMedicacion.Enabled = False

        End If

    End Sub

    Private Sub PctAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.Click
        LstMedicaciones.Items.Add(TxtAgregarMedicacion.Text)
        TxtAgregarMedicacion.Text = ""

    End Sub

    Public Sub DeterminarSexo()
        If RdbMasculino.Checked = True Then
            Sexo = 0
        Else
            Sexo = 1
        End If

    End Sub

    Public Sub AsignarListas()
        Enfermedades.Clear()
        Medicaciones.Clear()
        For x = 0 To LstEnfermedadesCronicas.Items.Count() - 1
            Enfermedades.Add(LstEnfermedadesCronicas.Items(x).Text)

        Next

        For x = 0 To LstMedicaciones.Items.Count() - 1
            Medicaciones.Add(LstMedicaciones.Items(x).Text)

        Next
    End Sub

    Public Sub DeterminarFecha()
        FechaNacimiento = DttFecha.Value.Year.ToString + "/" + DttFecha.Value.Month.ToString + "/" + DttFecha.Value.Day.ToString

    End Sub

    Private Sub LstEnfermedadesCronicas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedadesCronicas.SelectedIndexChanged
        If LstEnfermedadesCronicas.SelectedItems.Count > 0 Then
            PctEliminarEnfermedad.Enabled = True
        Else
            PctEliminarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub PctEliminarEnfermedad_Click(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.Click
        LstEnfermedadesCronicas.Items.Remove(LstEnfermedadesCronicas.SelectedItems(0))
        AsignarListas()

    End Sub

    Private Sub LstMedicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicaciones.SelectedIndexChanged
        If LstMedicaciones.SelectedItems.Count > 0 Then
            PctEliminarMedicacion.Enabled = True
        Else
            PctEliminarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub PctEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.Click
        LstMedicaciones.Items.Remove(LstMedicaciones.SelectedItems(0))
        AsignarListas()

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        ToolTipNombre.AutoPopDelay = 3000
        ToolTipNombre.InitialDelay = 500
        ToolTipNombre.ReshowDelay = 500
        ToolTipNombre.ToolTipTitle = "Formato incorrecto"
        ToolTipNombre.ToolTipIcon = ToolTipIcon.Warning
        If System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
            TxtNombre.ForeColor = Color.Black
            Nombre = True
        Else
            TxtNombre.ForeColor = Color.Red
            Nombre = False
            ToolTipNombre.SetToolTip(Me.TxtNombre, "Este campo no acepta números, espacios o caractéres especiales")
        End If

        HabilitarAceptar()

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        ToolTipApellido.AutoPopDelay = 3000
        ToolTipApellido.InitialDelay = 500
        ToolTipApellido.ReshowDelay = 500
        ToolTipApellido.ToolTipTitle = "Formato incorrecto"
        ToolTipApellido.ToolTipIcon = ToolTipIcon.Warning

        If System.Text.RegularExpressions.Regex.IsMatch(TxtApellido.Text, "^[a-zA-Z]+$") Then
            TxtApellido.ForeColor = Color.Black
            Apellido = True
        Else
            TxtApellido.ForeColor = Color.Red
            Apellido = False
            ToolTipApellido.SetToolTip(Me.TxtApellido, "Este campo no acepta números o caractéres especiales")
        End If
        HabilitarAceptar()

    End Sub

    Private Sub TxtCorreo_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreo.TextChanged
        ToolTipApellido.AutoPopDelay = 3000
        ToolTipApellido.InitialDelay = 500
        ToolTipApellido.ReshowDelay = 500
        ToolTipApellido.ToolTipTitle = "Formato incorrecto"
        ToolTipApellido.ToolTipIcon = ToolTipIcon.Warning
        If System.Text.RegularExpressions.Regex.IsMatch(TxtCorreo.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            TxtCorreo.ForeColor = Color.Black
            Correo = True
        Else
            TxtCorreo.ForeColor = Color.Red
            Correo = False
            ToolTipCorreo.SetToolTip(Me.TxtCorreo, "El formato esperado es <nombre de usuario>@<organización>.<tipo>")
        End If

        HabilitarAceptar()

    End Sub

    Public Sub HabilitarAceptar()
        If Nombre And Apellido And Correo Then
            PctAceptar.Enabled = True
        Else
            PctAceptar.Enabled = False
        End If

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        DeterminarSexo()
        AsignarListas()
        DeterminarFecha()
        GuardarValores()

    End Sub

    Public Sub GuardarValores()
        Try
            ControladorPaciente.CambiarDatos(TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtCorreo.Text,
                                             Sexo,
                                             FechaNacimiento,
                                             Enfermedades,
                                             Medicaciones)
            MsgBox("Cambios realizados con exito!", MsgBoxStyle.Information, "Cambio de usuario")
        Catch ex As Exception
            MsgBox("Error al intentar actualizar sus datos", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Frm_Menu.Show()
        Me.Dispose()

    End Sub

    Private Sub PctCancelar_Click(sender As Object, e As EventArgs) Handles PctCancelar.Click
        ObtenerDatosPersona()
        ObtenerMedicacionesPaciente()
        ObtenerEnfermedadesCronicas()
        TxtAgregarEnfermedad.Text = ""
        TxtAgregarMedicacion.Text = ""


    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

    Private Sub PctCancelar_MouseEnter(sender As Object, e As EventArgs) Handles PctCancelar.MouseEnter
        PctCancelar.Image = My.Resources.Cancelar2

    End Sub

    Private Sub PctCancelar_MouseLeave(sender As Object, e As EventArgs) Handles PctCancelar.MouseLeave
        PctCancelar.Image = My.Resources.Cancelar1

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Me.Dispose()
        Frm_Menu.Show()

    End Sub

    Private Sub PctAgregarEnfermedad_MouseEnter(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.MouseEnter
        PctAgregarEnfermedad.Image = My.Resources.AddCircularVerdeEnterOscuro

    End Sub

    Private Sub PctAgregarMedicacion_MouseEnter(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.MouseEnter
        PctAgregarMedicacion.Image = My.Resources.AddCircularVerdeEnterOscuro

    End Sub

    Private Sub PctEliminarEnfermedad_MouseEnter(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.MouseEnter
        PctEliminarEnfermedad.Image = My.Resources.DelCircularRojoEnterOscuro

    End Sub

    Private Sub PctEliminarMedicacion_MouseEnter(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.MouseEnter
        PctEliminarMedicacion.Image = My.Resources.DelCircularRojoEnterOscuro

    End Sub

    Private Sub PctEliminarMedicacion_MouseLeave(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.MouseLeave
        PctEliminarMedicacion.Image = My.Resources.DelCircularRojoOscuro

    End Sub

    Private Sub PctEliminarEnfermedad_MouseLeave(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.MouseLeave
        PctEliminarEnfermedad.Image = My.Resources.DelCircularRojoOscuro

    End Sub

    Private Sub PctAgregarEnfermedad_MouseLeave(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.MouseLeave
        PctAgregarEnfermedad.Image = My.Resources.AddCircularVerdeOscuro

    End Sub

    Private Sub PctAgregarMedicacion_MouseLeave(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.MouseLeave
        PctAgregarMedicacion.Image = My.Resources.AddCircularVerdeOscuro

    End Sub

End Class