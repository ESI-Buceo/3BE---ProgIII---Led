Imports CapaDeNegocio

Public Class FrmModificarUsuario

    Dim rol(3) As Boolean
    Public Enfermedades As New List(Of String)
    Public Medicaciones As New List(Of String)
    Public Nombre, Apellido, Mail As Boolean

    Private Sub FrmModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFechaNacimiento.MaxDate = Today()
        ObtenerCedulas()

    End Sub

    Private Sub ObtenerCedulas()
        Dim LectorCedula As IDataReader
        Try
            LectorCedula = ControladorUsuario.ObtenerTodasLasCedulas()
            CargarCedulas(LectorCedula)
        Catch ex As Exception
            MsgBox("No se pudieron obtener los usuarios", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarCedulas(lector As IDataReader)
        CmbCi.Items.Clear()
        While lector.Read
            CmbCi.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbCi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCi.SelectedIndexChanged
        Limpiar()
        PctRefrescar.Enabled = True
        HabilitarPersona(True)
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()
        HabilitarModificacion()

    End Sub

    Private Sub HabilitarPersona(estado As Boolean)
        TxtNombre.Enabled = estado
        TxtApellido.Enabled = estado
        TxtCorreo.Enabled = estado
        ChbPaciente.Enabled = estado
        ChbMedico.Enabled = estado
        ChbAdministrador.Enabled = estado
        LblNombre.Enabled = estado
        LblApellido.Enabled = estado
        LblMail.Enabled = estado
        LblSexo.Enabled = estado

    End Sub

    Private Sub ObtenerDatosPersona()
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorUsuario.ObtenerNombreApellidoMail(CmbCi.SelectedItem.ToString())
            CargarDatos(LectorDatos)
        Catch ex As Exception
            MsgBox("No se pudieron obtener los datos de la persona", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarDatos(lector As IDataReader)
        While lector.Read
            TxtNombre.Text = lector(0).ToString
            TxtApellido.Text = lector(1).ToString
            TxtCorreo.Text = lector(2).ToString

        End While
    End Sub

    Private Sub EsPaciente()
        Try
            If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString(), 1) = 1 Then
                rol(0) = True
                ChbPaciente.Checked = True
                ChbPaciente.Enabled = False
                ObtenerDatosPaciente()
                ObtenerEnfermedadesCronicas()
                ObtenerMedicacion()
            Else
                rol(0) = False
                ChbPaciente.Enabled = True
                ChbPaciente.Checked = False

            End If
        Catch ex As Exception
            MsgBox("No conseguimos saber si el usuario es paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub ObtenerDatosPaciente()
        Dim LectorPaciente As IDataReader
        Try
            LectorPaciente = ControladorPaciente.ObtenerTodo(CmbCi.SelectedItem.ToString)
            CargarDatosPaciente(LectorPaciente)
        Catch ex As Exception
            MsgBox("No pudimos obtener los datos del paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarDatosPaciente(lector As IDataReader)
        While lector.Read
            AdaptarFecha(lector(4).ToString)
            If lector(3).ToString = 0 Then
                RdbH.Checked = True
            Else
                RdbM.Checked = True
            End If

        End While

    End Sub

    Private Sub AdaptarFecha(fecha As Date)
        DtpFechaNacimiento.Value = fecha.Date

    End Sub

    Private Sub ObtenerEnfermedadesCronicas()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorPaciente.ObtenerEnfermedades(CmbCi.SelectedItem)
            CargarEnfermedades(LectorEnfermedades)
        Catch ex As Exception
            MsgBox("No pudimos obtener las enfemredad del paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarEnfermedades(lector As IDataReader)
        LstEnfermedades.Clear()
        While lector.Read
            LstEnfermedades.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub ObtenerMedicacion()
        Dim LectorMedicaciones As IDataReader
        Try
            LectorMedicaciones = ControladorPaciente.ObtenerMedicaciones(CmbCi.SelectedItem)
            CargarMedicaciones(LectorMedicaciones)
        Catch ex As Exception
            MsgBox("Error al intentar cargar las medicacion", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarMedicaciones(lector As IDataReader)
        LstMedicaciones.Clear()
        While lector.Read
            LstMedicaciones.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub EsMedico()
        If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString, 2) = 1 Then
            rol(1) = True
            ChbMedico.Checked = True
            ChbMedico.Enabled = False
        Else
            rol(1) = False
            ChbMedico.Checked = False
            ChbMedico.Enabled = True
        End If

    End Sub

    Private Sub EsAdministrativo()
        If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString, 3) = 1 Then
            rol(2) = True
            ChbAdministrador.Checked = True
            ChbAdministrador.Enabled = False
        Else
            rol(2) = False
            ChbAdministrador.Checked = False
            ChbAdministrador.Enabled = True
        End If

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged
        HabilitarDatosPaciente(ChbPaciente.Checked)
        MostrarDatosPaciente(ChbPaciente.Checked)
        HabilitarModificacion()

    End Sub

    Private Sub HabilitarDatosPaciente(estado As Boolean)
        LblFechaNacimiento.Enabled = estado
        DtpFechaNacimiento.Enabled = estado
        RdbH.Enabled = estado
        RdbM.Enabled = estado
        LblEnfermedadCronica.Enabled = estado
        TxtEnfermedadCronica.Enabled = estado
        LstEnfermedades.Enabled = estado
        LblMedicacion.Enabled = estado
        TxtMedicacion.Enabled = estado
        LstMedicaciones.Enabled = estado

    End Sub

    Private Sub MostrarDatosPaciente(estado As Boolean)
        LblFechaNacimiento.Visible = estado
        DtpFechaNacimiento.Visible = estado
        RdbH.Visible = estado
        RdbM.Visible = estado
        LblEnfermedadCronica.Visible = estado
        TxtEnfermedadCronica.Visible = estado
        PctAgregarEnfermedad.Visible = estado
        LstEnfermedades.Visible = estado
        LblMedicacion.Visible = estado
        TxtMedicacion.Visible = estado
        PctAgregarMedicacion.Visible = estado
        LstMedicaciones.Visible = estado
        PctEliminarEnfermedad.Visible = estado
        PctEliminarMedicacion.Visible = estado

    End Sub

    Private Sub TxtEnfermedadCronica_TextChanged(sender As Object, e As EventArgs) Handles TxtEnfermedadCronica.TextChanged

        If TxtEnfermedadCronica.Text <> "" Then
            PctAgregarEnfermedad.Enabled = True
        Else
            PctAgregarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.Click
        LstEnfermedades.Items.Add(TxtEnfermedadCronica.Text)
        TxtEnfermedadCronica.Text = ""
    End Sub

    Private Sub LstEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedades.SelectedIndexChanged
        If LstEnfermedades.SelectedItems.Count() > 0 Then
            PctEliminarEnfermedad.Enabled = True
        Else
            PctEliminarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.Click
        LstEnfermedades.Items.Remove(LstEnfermedades.SelectedItems(0))
        PctEliminarEnfermedad.Enabled = False

    End Sub

    Private Sub TxtMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicacion.TextChanged
        If TxtMedicacion.Text <> "" Then
            PctAgregarMedicacion.Enabled = True
        Else
            PctAgregarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.Click
        LstMedicaciones.Items.Add(TxtMedicacion.Text)
        TxtMedicacion.Text = ""

    End Sub

    Private Sub LstMedicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicaciones.SelectedIndexChanged
        If LstMedicaciones.SelectedItems.Count() > 0 Then
            PctEliminarMedicacion.Enabled = True
        Else
            PctEliminarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.Click
        LstMedicaciones.Items.Remove(LstMedicaciones.SelectedItems(0))
        PctEliminarMedicacion.Enabled = False

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
            TxtNombre.ForeColor = Color.Black
            Nombre = True
        Else
            TxtNombre.ForeColor = Color.Red
            Nombre = False
        End If
        HabilitarModificacion()

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtApellido.Text, "^[a-zA-Z\s]+$") Then
            TxtApellido.ForeColor = Color.Black
            Apellido = True
        Else
            TxtApellido.ForeColor = Color.Red
            Apellido = False
        End If
        HabilitarModificacion()

    End Sub

    Private Sub TxtMail_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreo.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtCorreo.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            TxtCorreo.ForeColor = Color.Black
            Mail = True
        Else
            TxtCorreo.ForeColor = Color.Red
            Mail = False
        End If
        HabilitarModificacion()

    End Sub

    Private Sub HabilitarModificacion()
        If ChbPaciente.Checked = False And ChbMedico.Checked = False And ChbAdministrador.Checked = False Then
            PctAceptar.Enabled = False
        Else
            If Nombre And Apellido And Mail Then
                PctAceptar.Enabled = True
            Else
                PctAceptar.Enabled = False
            End If

        End If

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        If ChbPaciente.Checked And rol(0) = True Then
            ModificarPersonaYPaciente()
        ElseIf ChbPaciente.Checked And rol(0) = False Then
            AgregarAPaciente()
        End If

        If ChbMedico.Checked And rol(1) = True Then
            ModificarPersona(2)
        ElseIf ChbMedico.Checked And rol(1) = False Then
            AgregarAMedico()
        End If

        If ChbAdministrador.Checked And rol(2) = True Then
            ModificarPersona(3)
        ElseIf ChbAdministrador.Checked And rol(2) = False Then
            AgregarAAdministrador()

        End If
        Limpiar()

    End Sub

    Private Sub ModificarPersonaYPaciente()
        Try
            ControladorPaciente.CambiarDatos(TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtCorreo.Text,
                                             ObtenerSexo(),
                                             ObtenerFecha(),
                                             CargarListaEnfermedades(),
                                             CargarListaMedicinas(),
                                             CmbCi.SelectedItem())
            MsgBox("Paciente modificado con éxito!", MsgBoxStyle.Information, "Modificación paciente")
        Catch ex As Exception
            MsgBox("Error al intentar modificar al paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub AgregarAPaciente()
        Try
            ControladorUsuario.AgregarNuevoPaciente(CmbCi.SelectedItem(),
                                                    ObtenerSexo(),
                                                    ObtenerFecha(),
                                                    CargarListaEnfermedades(),
                                                    CargarListaMedicinas())
            MsgBox("El usuario " + TxtNombre.Text + " es ahora paciente", MsgBoxStyle.Information, "Nuevo rol")
        Catch ex As Exception
            MsgBox("Error al intentar añadir el rol", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub AgregarAMedico()
        Try
            ControladorUsuario.AgregarNuevoMedico(CmbCi.SelectedItem)
            MsgBox("El usuario " + TxtNombre.Text + " es ahora médico", MsgBoxStyle.Information, "Nuevo rol")
        Catch ex As Exception
            MsgBox("Error al intentar añadir el rol", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub AgregarAAdministrador()
        Try
            ControladorUsuario.AgregarNuevoAdministrativo(CmbCi.SelectedItem)
            MsgBox("El usuario " + TxtNombre.Text + " es ahora administrador", MsgBoxStyle.Information, "Nuevo rol")
        Catch ex As Exception
            MsgBox("Error al intentar añadir el rol", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub ModificarPersona(Usuario As Integer)
        Try
            ControladorUsuario.ModificarPersona(TxtNombre.Text,
                                                TxtApellido.Text,
                                                TxtCorreo.Text,
                                                CmbCi.SelectedItem)
            If Usuario = 2 Then
                MsgBox("Médico actualizado con éxito!", MsgBoxStyle.Information, "Modificación médico")
            Else
                MsgBox("Administrador actualizado con éxito!", MsgBoxStyle.Information, "Modificación administrador")
            End If

        Catch ex As Exception
            If Usuario = 2 Then
                MsgBox("Error al intentar acutalizar al médico", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            Else
                MsgBox("Error al intentar acutalizar al adminsitrador", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End If

        End Try

    End Sub

    Private Function ObtenerSexo()
        If RdbH.Checked Then
            Return 0
        Else
            Return 1
        End If

    End Function

    Private Function ObtenerFecha()
        Return DtpFechaNacimiento.Value.Year.ToString + "-" +
            DtpFechaNacimiento.Value.Month.ToString + "-" +
            DtpFechaNacimiento.Value.Day.ToString

    End Function

    Private Function CargarListaEnfermedades()
        Enfermedades.Clear()
        For x = 0 To LstEnfermedades.Items.Count() - 1
            Enfermedades.Add(LstEnfermedades.Items(x).Text)
        Next
        Return Enfermedades

    End Function

    Private Function CargarListaMedicinas()
        Medicaciones.Clear()
        For x = 0 To LstMedicaciones.Items.Count() - 1
            Medicaciones.Add(LstMedicaciones.Items(x).Text)
        Next
        Return Medicaciones

    End Function

    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtCorreo.Text = ""
        ChbPaciente.Checked = False
        ChbMedico.Checked = False
        ChbAdministrador.Checked = False
        ChbPaciente.Enabled = False
        ChbMedico.Enabled = False
        ChbAdministrador.Enabled = False
        TxtEnfermedadCronica.Text = ""
        TxtMedicacion.Text = ""
        LstEnfermedades.Items.Clear()
        LstMedicaciones.Items.Clear()
        MostrarDatosPaciente(False)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles PctRefrescar.Click
        HabilitarPersona(True)
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()
        HabilitarModificacion()
        PctRefrescar.Enabled = False

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles PctSalir.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub PctRefrescar_MouseEnter(sender As Object, e As EventArgs) Handles PctRefrescar.MouseEnter
        PctRefrescar.Image = My.Resources.RefreshEnter

    End Sub

    Private Sub PctRefrescar_MoseLeave(sender As Object, e As EventArgs) Handles PctRefrescar.MouseLeave
        PctRefrescar.Image = My.Resources.Refrescar

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

End Class