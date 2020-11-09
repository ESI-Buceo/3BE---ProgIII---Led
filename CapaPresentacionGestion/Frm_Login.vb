Imports CapaDeNegocio

Public Class FrmLogin

    Dim Usuario As Boolean = False
    Dim Password As Boolean = False
    Dim ToolTipUser As New ToolTip()

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            If AutenticarPaciente(TxtUser.Text, TxtPass.Text) = 1 Then
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                FrmMenuGestion.Show()
            Else
                MsgBox("Usuario y/o contraseña invalidos")

            End If

        Catch ex As Exception
            MsgBox("Usuario y/o contraseña invalidos")

        End Try

    End Sub

    Private Function AutenticarPaciente(usuario As String, contra As String)
        Return ControladorLogin.Autentificar(usuario, contra, 3)

    End Function

    Private Sub SetearSesion(usuario As String, contra As String)
        Try
            ControladorSesion.User = usuario
            ControladorSesion.Pass = contra
            ControladorSesion.Cedula = TxtUser.Text

        Catch ex As Exception
            MsgBox("Usuario y/o contraseña invalidos")

        End Try

    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged
        ToolTipUser.AutoPopDelay = 3000
        ToolTipUser.InitialDelay = 1000
        ToolTipUser.ReshowDelay = 500
        ToolTipUser.ToolTipTitle = "Formato incorrecto"
        ToolTipUser.ToolTipIcon = ToolTipIcon.Warning
        ToolTipUser.IsBalloon = True

        If System.Text.RegularExpressions.Regex.IsMatch(TxtUser.Text, "^[0-9]+$") Then
            Usuario = True
            TxtUser.ForeColor = Color.Black
        Else
            Usuario = False
            TxtUser.ForeColor = Color.Red
            ToolTipUser.SetToolTip(Me.TxtUser, "La cédula debe ser escrita sin espacion, puntos, ni guiones")
        End If
        HabilitarIngresar()

    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        If TxtPass.Text <> "" Then
            Password = True
        Else
            Password = False
        End If
        HabilitarIngresar()

    End Sub

    Private Sub HabilitarIngresar()
        If Usuario And Password Then
            BtnIngresar.Enabled = True
            BtnIngresar.Cursor = Cursors.Hand
        Else
            BtnIngresar.Enabled = False
            BtnIngresar.Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub PctSalirLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles PctSalirLeft.MouseMove
        PctSalirLeft.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalirLeft_MouseLeave(sender As Object, e As EventArgs) Handles PctSalirLeft.MouseLeave
        PctSalirLeft.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalirLeft_Click(sender As Object, e As EventArgs) Handles PctSalirLeft.Click
        Me.Close()

    End Sub

    Private Sub BtnIngresar_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnIngresar.MouseMove
        If BtnIngresar.Enabled Then
            BtnIngresar.Image = My.Resources.BotonIngresar4
        End If

    End Sub

    Private Sub BtnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles BtnIngresar.MouseLeave
        If BtnIngresar.Enabled Then
            BtnIngresar.Image = My.Resources.BotonIngresar3
        End If

    End Sub

End Class
