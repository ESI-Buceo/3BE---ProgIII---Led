Imports CapaDeNegocio
Imports System.Net.Mail
Public Class FrmNuevoUsuario

    Dim TipoUsuario(3) As Boolean
    Dim FechaNacimiento As String
    Dim EnfermedadesCronicas As New List(Of String)
    Dim Medicamentos As New List(Of String)
    Dim Sexo As String
    Dim Contra As String
    Public Ci, Nombre, Apellido, Mail, FoM, Fecha As Boolean
    Dim ToolTipCedula As New ToolTip()
    Dim ToolTipNombre As New ToolTip()
    Dim ToolTipApellido As New ToolTip()
    Dim ToolTipCorreo As New ToolTip()
    Dim ToolTipAgregarEnfermedad As New ToolTip()

    Private Sub FrmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFechaNacimiento.MaxDate = Today()
        TxtCedula.TextAlign = HorizontalAlignment.Center
        TxtNombre.TextAlign = HorizontalAlignment.Center
        TxtApellido.TextAlign = HorizontalAlignment.Center
        TxtCorreo.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged
        ToolTipCedula.AutoPopDelay = 2000
        ToolTipCedula.InitialDelay = 500
        ToolTipCedula.ReshowDelay = 500
        ToolTipCedula.ToolTipTitle = "Formato incorrecto"
        ToolTipCedula.ToolTipIcon = ToolTipIcon.Warning
        If System.Text.RegularExpressions.Regex.IsMatch(TxtCedula.Text, "^[0-9]+$") Then
            TxtCedula.ForeColor = Color.Black
            Ci = True
        Else
            TxtCedula.ForeColor = Color.Red
            Ci = False
            ToolTipCedula.SetToolTip(Me.TxtCedula, "La cédula debe escribirse sin puntos, espacios ni guiones")
        End If

        HabilitarTipoUsuario()

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        ToolTipNombre.AutoPopDelay = 2000
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

        HabilitarTipoUsuario()

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        ToolTipApellido.AutoPopDelay = 2000
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

        HabilitarTipoUsuario()

    End Sub

    Private Sub TxtCorreo_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreo.TextChanged
        ToolTipApellido.AutoPopDelay = 2000
        ToolTipApellido.InitialDelay = 500
        ToolTipApellido.ReshowDelay = 500
        ToolTipApellido.ToolTipTitle = "Formato incorrecto"
        ToolTipApellido.ToolTipIcon = ToolTipIcon.Warning
        If System.Text.RegularExpressions.Regex.IsMatch(TxtCorreo.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            TxtCorreo.ForeColor = Color.Black
            Mail = True
        Else
            TxtCorreo.ForeColor = Color.Red
            Mail = False
            ToolTipCorreo.SetToolTip(Me.TxtCorreo, "El formato esperado es <nombre de usuario>@<organización>.<tipo>")
        End If

        HabilitarTipoUsuario()

    End Sub

    Private Sub HabilitarTipoUsuario()
        If Ci And Nombre And Apellido And Mail Then
            ChbPaciente.Enabled = True
            ChbMedico.Enabled = True
            ChbAdministrador.Enabled = True
        Else
            ChbPaciente.Enabled = False
            ChbMedico.Enabled = False
            ChbAdministrador.Enabled = False
            ChbPaciente.Checked = False
            ChbMedico.Checked = False
            ChbAdministrador.Checked = False
        End If

    End Sub

    Private Sub ChbAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles ChbAdministrador.CheckedChanged
        If ChbAdministrador.Enabled Then
            HabilitarAceptar()
        Else
            PctAceptar.Enabled = False
        End If

    End Sub

    Private Sub ChbMedico_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMedico.CheckedChanged
        If ChbMedico.Enabled Then
            HabilitarAceptar()
        Else
            PctAceptar.Enabled = False
        End If

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged
        If ChbPaciente.Checked Then
            CamposPaciente(True)
        Else
            CamposPaciente(False)
            HabilitarAceptar()
        End If

        If ChbPaciente.Enabled Then
            HabilitarAceptar()
        Else
            PctAceptar.Enabled = False

        End If

    End Sub

    Private Sub CamposPaciente(estado As Boolean)
        TxtEnfermedadCronica.Visible = estado
        TxtMedicacion.Visible = estado
        LstEnfermedadCronica.Visible = estado
        LstMedicacion.Visible = estado
        RdbF.Visible = estado
        RdbF.Checked = estado
        RdbH.Visible = estado
        DtpFechaNacimiento.Visible = estado
        LblFechaNacimiento.Visible = estado
        LblEnfermedadCronica.Visible = estado
        LblMedicacion.Visible = estado
        LblSexo.Visible = estado
        PctAgregarEnfermedad.Visible = estado
        PctAgregarMedicacion.Visible = estado
        PctEliminarEnfermedad.Visible = estado
        PctEliminarMedicacion.Visible = estado
    End Sub

    Private Sub HabilitarAceptar()
        If Ci And Nombre And Apellido And Mail And ChbPaciente.Enabled And (ChbAdministrador.Checked Or ChbMedico.Checked Or ChbPaciente.Checked) Then
            PctAceptar.Enabled = True
        Else
            PctAceptar.Enabled = False
        End If

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        ObtenerTipoUsuario()

    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

    Private Sub ObtenerTipoUsuario()
        If ChbAdministrador.Checked And Not ChbMedico.Checked And Not ChbPaciente.Checked Then
            CrearPersona(3)

        ElseIf ChbMedico.Checked And Not ChbPaciente.Checked And Not ChbAdministrador.Checked Then
            CrearPersona(2)

        ElseIf ChbPaciente.Checked And Not ChbMedico.Checked And Not ChbAdministrador.Checked Then
            CargarPaciente()
            CrearPersona(1)

        ElseIf ChbAdministrador.Checked And ChbMedico.Checked And Not ChbPaciente.Checked Then
            CrearPersona(23)

        ElseIf ChbAdministrador.Checked And ChbPaciente.Checked And Not ChbMedico.Checked Then
            CargarPaciente()
            CrearPersona(13)

        ElseIf ChbMedico.Checked And ChbPaciente.Checked And Not ChbAdministrador.Checked Then
            CargarPaciente()
            CrearPersona(12)

        ElseIf ChbMedico.Checked And ChbPaciente.Checked And ChbAdministrador.Checked Then
            CargarPaciente()
            CrearPersona(123)

        End If

    End Sub

    Private Sub CargarPaciente()
        TipoUsuario(0) = True

        FechaNacimiento = DtpFechaNacimiento.Value.Year.ToString() + "-" + DtpFechaNacimiento.Value.Month.ToString() + "-" + DtpFechaNacimiento.Value.Day.ToString()
        For x = 0 To LstEnfermedadCronica.Items.Count - 1
            EnfermedadesCronicas.Add(LstEnfermedadCronica.Items(x).ToString)
        Next

        For y = 0 To LstMedicacion.Items.Count - 1
            Medicamentos.Add(LstMedicacion.Items(y).ToString)
        Next

        If RdbF.Checked() Then
            Sexo = "1"
        Else
            Sexo = "0"
        End If

    End Sub

    Private Sub TxtEnfermedadCronica_TextChanged(sender As Object, e As EventArgs) Handles TxtEnfermedadCronica.TextChanged
        If TxtEnfermedadCronica.Text <> "" Then
            PctAgregarEnfermedad.Enabled = True
        Else
            PctAgregarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub PctAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.Click
        LstEnfermedadCronica.Items.Add(TxtEnfermedadCronica.Text)
        TxtEnfermedadCronica.Clear()

    End Sub

    Private Sub LstEnfermedadCronica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedadCronica.SelectedIndexChanged
        If LstEnfermedadCronica.SelectedIndices.Count() > 0 Then
            PctEliminarEnfermedad.Enabled = True
        Else
            PctEliminarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.Click
        LstEnfermedadCronica.Items.Remove(LstEnfermedadCronica.SelectedItems(0))

    End Sub

    Private Sub TxtMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicacion.TextChanged
        If TxtMedicacion.Text <> "" Then
            PctAgregarMedicacion.Enabled = True
        Else
            PctAgregarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub PctAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.Click
        LstMedicacion.Items.Add(TxtMedicacion.Text)
        TxtMedicacion.Clear()

    End Sub

    Private Sub LstMedicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicacion.SelectedIndexChanged
        If LstMedicacion.SelectedIndices.Count() > 0 Then
            PctEliminarMedicacion.Enabled = True
        Else
            PctEliminarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub PctEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.Click
        LstMedicacion.Items.Remove(LstMedicacion.SelectedItems(0))

    End Sub

    Private Sub CrearPersona(Tipo As Integer)
        CrearContra()
        If Tipo = 1 Then
            CrearPaciente()
        ElseIf Tipo = 2 Then
            CrearMedico()
        ElseIf Tipo = 3 Then
            CrearAdministrativo()
        ElseIf Tipo = 12 Then
            CrearPacienteMedico()
        ElseIf Tipo = 13 Then
            CrearPacienteAdmin()
        ElseIf Tipo = 23 Then
            CrearMedicoAdmin()
        ElseIf Tipo = 123 Then
            CrearPacienteMedicoAdmin()
        End If

    End Sub

    Private Sub CrearPaciente()
        Try
            ControladorUsuario.NuevoPaciente(TxtCedula.Text,
                                             TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtCorreo.Text,
                                             FechaNacimiento,
                                             Sexo,
                                             EnfermedadesCronicas,
                                             Medicamentos,
                                             Contra)
            MsgBox("Paciente creado con éxito!", MsgBoxStyle.Information, "Nuevo Paciente")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub CrearMedico()
        Try
            ControladorUsuario.NuevoMedico(TxtCedula.Text,
                                            TxtNombre.Text,
                                            TxtApellido.Text,
                                            TxtCorreo.Text,
                                            Contra)
            MsgBox("Médico creado con éxito!", MsgBoxStyle.Information, "Nuevo Médico")
            EnviarMail()

        Catch ex As Exception
            MsgBox("Error al crear al medico", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CrearAdministrativo()
        Try
            ControladorUsuario.NuevoAdministrativo(TxtCedula.Text,
                                                   TxtNombre.Text,
                                                   TxtApellido.Text,
                                                   TxtCorreo.Text,
                                                   Contra)
            MsgBox("Administrativo creado con éxito!", MsgBoxStyle.Information, "Nuevo Administrativo")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al administrativo", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

        End Try
    End Sub

    Private Sub CrearPacienteMedico()
        Try
            ControladorUsuario.NuevoPacienteMedico(TxtCedula.Text,
                                             TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtCorreo.Text,
                                             FechaNacimiento,
                                             Sexo,
                                             EnfermedadesCronicas,
                                             Medicamentos,
                                             Contra)
            MsgBox("Paciente medico creado con éxito", MsgBoxStyle.Information, "Nuevo paciente y médico")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error creando al usuario " + TxtNombre.Text, MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub CrearPacienteAdmin()
        Try
            ControladorUsuario.NuevoPacienteAdmin(TxtCedula.Text,
                                             TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtCorreo.Text,
                                             FechaNacimiento,
                                             Sexo,
                                             EnfermedadesCronicas,
                                             Medicamentos,
                                             Contra)
            MsgBox("El usuario se creó como paciente y administrativo", MsgBoxStyle.Information, "Nuevo paciente y administrador")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al usuario ", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CrearMedicoAdmin()
        Try
            ControladorUsuario.NuevoMedicoAdmin(TxtCedula.Text,
                                                TxtNombre.Text,
                                                TxtApellido.Text,
                                                TxtCorreo.Text,
                                                Contra)
            MsgBox("El usuario " + TxtNombre.Text + " fue creado con éxito!", MsgBoxStyle.Information, "Nuevo médico y administrador")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al administrativo, médico", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")

        End Try
    End Sub

    Private Sub CrearPacienteMedicoAdmin()
        Try
            ControladorUsuario.NuevoPacienteMedicoAdmin(TxtNombre.Text.Trim,
                                            TxtApellido.Text.Trim,
                                            TxtCedula.Text.Trim,
                                            TxtCorreo.Text.Trim,
                                            FechaNacimiento,
                                            Sexo,
                                            EnfermedadesCronicas,
                                            Medicamentos,
                                            Contra)
            MsgBox("Persona creada con éxito", MsgBoxStyle.Information, "Nuevo paciente, médico y administrativo")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear usuario", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub CrearContra()
        Dim rdm As New Random()
        Dim Mayus() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ".ToCharArray()
        Dim Numeros() As Char = "0123456789".ToCharArray()
        Dim Especiales() As Char = "*_/".ToCharArray()
        Dim Caracteres() As Char = "abcdefghijklmnopqrstuvwxyz".ToCharArray()
        Contra = ""
        For i As Integer = 0 To 8
            If i < 6 Then
                Contra += Caracteres(rdm.Next(0, Caracteres.Length))
            ElseIf i = 6 Then
                Contra += Especiales(rdm.Next(0, Especiales.Length))
            ElseIf i = 7 Then
                Contra += Numeros(rdm.Next(0, Numeros.Length))
            Else
                Contra += Mayus(rdm.Next(0, Mayus.Length))
            End If
        Next

    End Sub

    Private Sub EnviarMail()
        Dim smtp As New SmtpClient()
        Dim Correo As New MailMessage()
        CargarSmtp(smtp)
        CargarDatos(Correo)
        EnviarMensaje(smtp, Correo)

    End Sub

    Private Sub CargarSmtp(smtp)
        With smtp
            .UseDefaultCredentials = False
            .Credentials = New Net.NetworkCredential("cuidartegestor@gmail.com", "GesCuidarte")
            .Port = 587
            .EnableSsl = True
            .Host = "smtp.gmail.com"
        End With

    End Sub

    Private Sub CargarDatos(Correo)
        With Correo
            .From = New MailAddress("cuidartegestor@gmail.com", "Cuidarte", System.Text.Encoding.UTF8)
            Try
                .To.Add(TxtCorreo.Text)
            Catch ex As Exception
                MsgBox("No existe una dirección de correo", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End Try

            .Subject = "Credenciales De Cuidarte"
            .SubjectEncoding = System.Text.Encoding.UTF8
            If Sexo = 0 Then
                .Body = "Estimado usuario, gracias por utilizar Cuidarte. su usuario es: " + TxtCedula.Text + " y su password es: " + Contra
            Else
                .Body = "Estimada usuaria, Gracias por utilizar Cuidarte. su usuario es: " + TxtCedula.Text + " y su password es: " + Contra
            End If

            .BodyEncoding = System.Text.Encoding.UTF8
            .IsBodyHtml = False
        End With

    End Sub

    Private Sub EnviarMensaje(smtp, correo)
        Try
            smtp.Send(correo)
            MsgBox("Mensaje enviado con éxito!", MsgBoxStyle.Information, "Mensaje enviado")
        Catch ex As Exception
            If ex.HResult = "-2146233088" Then
                MsgBox("No se pudó enviar el mensaje", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            Else
                MsgBox("No se pudó enviar el mensaje", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End If
        End Try
        Limpiar()

    End Sub

    Private Sub PctRefrescar_Click(sender As Object, e As EventArgs) Handles PctRefrescar.Click
        Limpiar()

    End Sub

    Private Sub PctRefrescar_MouseEnter(sender As Object, e As EventArgs) Handles PctRefrescar.MouseEnter
        PctRefrescar.Image = My.Resources.RefreshEnter

    End Sub

    Private Sub PctRefrescar_MouseLeave(sender As Object, e As EventArgs) Handles PctRefrescar.MouseLeave
        PctRefrescar.Image = My.Resources.Refrescar

    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtCedula.Text = ""
        TxtCorreo.Text = ""
        TxtEnfermedadCronica.Text = ""
        TxtMedicacion.Text = ""
        DtpFechaNacimiento.Checked = False
        LstEnfermedadCronica.Items.Clear()
        LstMedicacion.Items.Clear()
        RdbF.Checked = False
        RdbH.Checked = False
        ChbAdministrador.Checked = False
        ChbMedico.Checked = False
        ChbPaciente.Checked = False

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub PctAgregarEnfermedad_MouseEnter(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.MouseEnter
        PctAgregarEnfermedad.Image = My.Resources.AddCircularVerdeEnter

    End Sub

    Private Sub PctAgregarEnfermedad_MouseLeave(sender As Object, e As EventArgs) Handles PctAgregarEnfermedad.MouseLeave
        PctAgregarEnfermedad.Image = My.Resources.AddCircularVerde

    End Sub

    Private Sub PctAgregarMedicacion_MouseEnter(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.MouseEnter
        PctAgregarMedicacion.Image = My.Resources.AddCircularVerdeEnter

    End Sub

    Private Sub PctAgregarMedicacion_MouseLeave(sender As Object, e As EventArgs) Handles PctAgregarMedicacion.MouseLeave
        PctAgregarMedicacion.Image = My.Resources.AddCircularVerde

    End Sub

    Private Sub PctEliminarEnfermedad_MouseEnter(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.MouseEnter
        PctEliminarEnfermedad.Image = My.Resources.DelCircularRojoEnter

    End Sub

    Private Sub PctEliminarEnfermedad_MouseLeave(sender As Object, e As EventArgs) Handles PctEliminarEnfermedad.MouseLeave
        PctEliminarEnfermedad.Image = My.Resources.DelCircularRojo

    End Sub

    Private Sub PctEliminarMedicacion_MouseEnter(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.MouseEnter
        PctEliminarMedicacion.Image = My.Resources.DelCircularRojoEnter

    End Sub

    Private Sub PctEliminarMedicacion_MouseLeave(sender As Object, e As EventArgs) Handles PctEliminarMedicacion.MouseLeave
        PctEliminarMedicacion.Image = My.Resources.DelCircularRojo

    End Sub

End Class