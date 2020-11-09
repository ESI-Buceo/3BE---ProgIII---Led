Imports CapaDeNegocio

Public Class FrmNuevoSintoma

    Public Reactivacion, Nombre As Boolean

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If ControladorSintoma.ObtenerExistencia(TxtNombre.Text) = 1 Then
            AveriguarInactividad()

        ElseIf TxtNombre.Text = "" Then
            LblDisponibilidad.Text = "El nombre no puede estar vacio"
            Nombre = False
            Reactivacion = False

        Else
            LblDisponibilidad.Text = "Nombre disponible"
            Nombre = True
            Reactivacion = False

        End If
        HabilitarCreacion(Reactivacion)

    End Sub

    Private Sub AveriguarInactividad()
        If ControladorSintoma.EstaInactivo(TxtNombre.Text) = 1 Then
            Reactivacion = True
            LblDisponibilidad.Text = "Este síntoma se encuentra inactivo," + vbCrLf + "haga clic en Reacitvar para volver a activarlo"

        Else
            Reactivacion = False
            Nombre = False
            LblDisponibilidad.Text = "El nombre del síntoma ya esta en uso"

        End If

    End Sub

    Private Sub HabilitarCreacion(Reactivacion As Boolean)
        If Reactivacion Then
            PctAceptar.Image = My.Resources.Reactivar
            PctAceptar.Enabled = True

        ElseIf Nombre Then
            PctAceptar.Enabled = True
            PctAceptar.Image = My.Resources.Aceptar1

        Else
            PctAceptar.Enabled = False
            PctAceptar.Image = My.Resources.Aceptar1

        End If

    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        If Reactivacion Then
            Try
                ControladorSintoma.ActivarSintoma(ControladorSintoma.ObtenerId(TxtNombre.Text))
                MsgBox("Sintoma reactivado con éxito!", MsgBoxStyle.Information, "Activación de síntoma")
                Limpiar()
            Catch ex As Exception
                MsgBox("No se pudo reactivar el síntoma", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End Try

        Else
            Try
                ControladorSintoma.CrearSintoma(TxtNombre.Text)
                MsgBox("Sintoma creado con éxito!", MsgBoxStyle.Information, "Creación de síntoma")
                Limpiar()
            Catch ex As Exception
                MsgBox("No se pudo crear el síntoma", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
            End Try
        End If
    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        If Reactivacion Then
            PctAceptar.Image = My.Resources.ReactivarAceptar
        Else
            PctAceptar.Image = My.Resources.Aceptar2

        End If
    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        If Reactivacion Then
            PctAceptar.Image = My.Resources.Reactivar
        Else
            PctAceptar.Image = My.Resources.Aceptar1

        End If
    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

End Class