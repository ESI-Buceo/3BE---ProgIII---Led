Imports CapaDeNegocio
Imports System.Net.Mail

Public Class FrmEliminarUsuario

    Dim rol(3) As Boolean
    Dim RolesAEliminar(3) As Boolean
    Dim EliminarPersona As Boolean

    Private Sub Frm_BajaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerCedulas()

    End Sub

    Private Sub ObtenerCedulas()
        Dim LectorCedula As IDataReader
        Try
            LectorCedula = ControladorUsuario.ObtenerTodasLasCedulas()
            CargarCedulas(LectorCedula)
        Catch ex As Exception
            MsgBox("Error al intentar cargar las cedulas", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub CargarCedulas(lector As IDataReader)
        CmbCI.Items.Clear()
        While lector.Read
            CmbCI.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCI.SelectedIndexChanged
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()
        MostrarDatos()
        HabilitarEliminar()

    End Sub

    Private Sub ObtenerDatosPersona()
        Dim DatosPersona As IDataReader
        Try
            DatosPersona = ControladorUsuario.ObtenerNombreApellidoMail(CmbCI.SelectedItem.ToString())
            CargarDatos(DatosPersona)
        Catch ex As Exception
            MsgBox("Error al intentar obtener los datos", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarDatos(lector As IDataReader)
        While lector.Read
            TxtNombre.Text = lector(0).ToString
            TxtApellido.Text = lector(1).ToString
            TxtMail.Text = lector(2).ToString

        End While

    End Sub

    Private Sub EsPaciente()
        Try
            If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 1) = 1 Then
                rol(0) = True
                ChbPaciente.Checked = True
                ChbPaciente.Enabled = True
            Else
                rol(0) = False
                ChbPaciente.Checked = False
                ChbPaciente.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("No pudimos resolver si el usuario es paciente", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try


    End Sub

    Private Sub EsMedico()
        Try
            If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 2) = 1 Then
                rol(1) = True
                ChbMedico.Checked = True
                ChbMedico.Enabled = True
            Else
                rol(1) = False
                ChbMedico.Checked = False
                ChbMedico.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("No pudimos resolver si el usuario es médico", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try


    End Sub

    Private Sub EsAdministrativo()
        Try
            If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 3) = 1 Then
                rol(2) = True
                ChbAdministrador.Checked = True
                ChbAdministrador.Enabled = True
            Else
                rol(2) = False
                ChbAdministrador.Checked = False
                ChbAdministrador.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("No pudimos resolver si el usuario es administrativo", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try



    End Sub

    Private Sub MostrarDatos()
        LblIndicaciones2.Visible = True
        LblTipoDeUsuario.Visible = True
        ChbPaciente.Visible = True
        ChbMedico.Visible = True
        ChbAdministrador.Visible = True

    End Sub

    Private Sub ChbPaciente_Click(sender As Object, e As EventArgs) Handles ChbPaciente.Click
        RolesAEliminar(0) = Not ChbPaciente.Checked
        HabilitarEliminar()

    End Sub

    Private Sub ChbMedico_Click(sender As Object, e As EventArgs) Handles ChbMedico.Click
        RolesAEliminar(1) = Not ChbMedico.Checked
        HabilitarEliminar()
    End Sub

    Private Sub ChbAdministrador_Click(sender As Object, e As EventArgs) Handles ChbAdministrador.Click
        RolesAEliminar(2) = Not ChbAdministrador.Checked
        HabilitarEliminar()

    End Sub

    Private Sub HabilitarEliminar()
        If ChbAdministrador.Checked = Not rol(2) Or ChbMedico.Checked = Not rol(1) Or ChbPaciente.Checked = Not rol(0) Then
            PctAceptar.Enabled = True
            PctRefrescar.Enabled = True
        Else
            PctAceptar.Enabled = False
            PctRefrescar.Enabled = False
        End If

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        Try
            Select Case MsgBox(MensajeDeConfirmacion(), MsgBoxStyle.YesNo, "Confirmación")
                Case DialogResult.Yes
                    Try
                        ControladorUsuario.EliminarPersona(CmbCI.SelectedItem, RolesAEliminar, EliminarPersona)
                        MsgBox("Eliminación exitosa!", MsgBoxStyle.Information, "Elimincación usuario")
                        Limpiar()
                    Catch ex As Exception
                        MsgBox("Error al intentar eliminar al usuario", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
                    End Try

                Case DialogResult.No

            End Select

        Catch
        End Try
    End Sub

    Private Function MensajeDeConfirmacion()
        Dim Mensaje As String = "El usuario " + TxtNombre.Text + " será eliminado de: " + vbCrLf
        If ChbPaciente.Checked = Not rol(0) Then
            Mensaje += "Su rol como Paciente " + vbCrLf
            RolesAEliminar(0) = True
        End If

        If ChbMedico.Checked = Not rol(1) Then
            Mensaje += "Su rol como Médico " + vbCrLf
            RolesAEliminar(1) = True
        End If

        If ChbAdministrador.Checked = Not rol(2) Then
            Mensaje += "Su rol como Administrativo " + vbCrLf
            RolesAEliminar(2) = True
        End If

        Dim i As Integer = 0
        For x = 0 To 2
            If rol(x) = RolesAEliminar(x) Then
                i += 1
            End If
        Next

        If i = 3 Then
            Mensaje += "Se eliminará a la persona"
            EliminarPersona = True
        Else
            EliminarPersona = False
        End If
        Return Mensaje

    End Function

    Private Sub Limpiar()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtMail.Clear()
        ChbPaciente.Checked = False
        ChbMedico.Checked = False
        ChbAdministrador.Checked = False
        ChbPaciente.Enabled = False
        ChbMedico.Enabled = False
        ChbAdministrador.Enabled = False
        PctAceptar.Enabled = False
        PctRefrescar.Enabled = False
        'ObtenerCedulas()

    End Sub

    Private Sub PctRefrescar_Click(sender As Object, e As EventArgs) Handles PctRefrescar.Click
        PctAceptar.Enabled = False
        EsPaciente()
        EsMedico()
        EsAdministrativo()

    End Sub

    Private Sub PctSalir_Click(sender As Object, e As EventArgs) Handles PctSalir.Click
        FrmMenuGestion.Show()
        Me.Dispose()

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

    Private Sub PctRefrescar_MouseEnter(sender As Object, e As EventArgs) Handles PctRefrescar.MouseEnter
        PctRefrescar.Image = My.Resources.RefreshEnter

    End Sub

    Private Sub PctRefrescar_MouseLeave(sender As Object, e As EventArgs) Handles PctRefrescar.MouseLeave
        PctRefrescar.Image = My.Resources.Refrescar

    End Sub

End Class