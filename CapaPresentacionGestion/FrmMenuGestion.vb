Imports CapaDeNegocio

Public Class FrmMenuGestion

    Private Sub MenuGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLabels()

    End Sub

    Private Sub CargarLabels()
        LblDescripcionVentana.Text = "Buenos días, " + ControladorUsuario.ObtenerNombre()
        LblAddSin.Text = "Nuevo" + vbCrLf + "Sintoma"
        LblModSin.Text = "Modificar" + vbCrLf + "Sintoma"
        LblDelSin.Text = "Eliminar" + vbCrLf + "Sintoma"
        LblAddEnf.Text = "Nueva" + vbCrLf + "Enfermedad"
        LblModEnf.Text = "Modificar" + vbCrLf + "Enfermedad"
        LblDelEnf.Text = "Eliminar" + vbCrLf + "Enfermedad"
        LblAddUsr.Text = "Nuevo" + vbCrLf + "Usuario"
        LblModUsr.Text = "Modificar" + vbCrLf + "Usuario"
        LblDelUsr.Text = "Eliminar" + vbCrLf + "Usuario"

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmNuevoUsuario.Show()

    End Sub


    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmModificarSintoma.Show()

    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmNuevoSintoma.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmEliminarSintoma.Show()

    End Sub

    Private Sub SintomaToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmSintomasCsv.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmNuevaEnfermedad.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmEliminarEnfermedad.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmModificarEnfermedad.Show()
    End Sub

    Private Sub FrmMenuGestion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        FrmLogin.Close()
    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        FrmModificarUsuario.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmModificarUsuario.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmEliminarUsuario.Show()
    End Sub

    Private Sub PctAdd_MouseEnter(sender As Object, e As EventArgs) Handles PctAdd.MouseEnter
        PctAdd.Cursor = Cursors.Hand
        While PnlAdd.Width < 194
            PnlAdd.Width += 1
        End While
    End Sub

    Private Sub PctDel_MouseEnter(sender As Object, e As EventArgs) Handles PctDel.MouseEnter
        PctDel.Cursor = Cursors.Hand
        While PnlDel.Width < 194
            PnlDel.Width += 1
        End While
    End Sub

    Private Sub PctMod_MouseEnter(sender As Object, e As EventArgs) Handles PctMod.MouseEnter
        PctMod.Cursor = Cursors.Hand
        While PnlMod.Width < 194
            PnlMod.Width += 1
        End While
    End Sub

    Private Sub PctAdd_MouseLeave(sender As Object, e As EventArgs) Handles PctAdd.MouseLeave
        PctAdd.Cursor = Cursors.Arrow
        While PnlAdd.Width > 74
            PnlAdd.Width -= 1
        End While
    End Sub

    Private Sub PctMod_MouseLeave(sender As Object, e As EventArgs) Handles PctMod.MouseLeave
        PctMod.Cursor = Cursors.Arrow
        While PnlMod.Width > 74
            PnlMod.Width -= 1
        End While
    End Sub

    Private Sub PctDel_MouseLeave(sender As Object, e As EventArgs) Handles PctDel.MouseLeave
        PctDel.Cursor = Cursors.Arrow
        While PnlDel.Width > 74
            PnlDel.Width -= 1
        End While
    End Sub

    Private Sub PctAddEnf_MouseEnter(sender As Object, e As EventArgs) Handles PctAddEnf.MouseEnter
        PctAddEnf.Cursor = Cursors.Hand
        While PnlAddEnf.Width < 194
            PnlAddEnf.Width += 1
        End While
    End Sub

    Private Sub PctDelEnf_MouseEnter(sender As Object, e As EventArgs) Handles PctDelEnf.MouseEnter
        PctDelEnf.Cursor = Cursors.Hand
        While PnlDelEnf.Width < 194
            PnlDelEnf.Width += 1
        End While
    End Sub

    Private Sub PctModEnf_MouseEnter(sender As Object, e As EventArgs) Handles PctModEnf.MouseEnter
        PctModEnf.Cursor = Cursors.Hand
        While PnlModEnf.Width < 194
            PnlModEnf.Width += 1
        End While
    End Sub

    Private Sub PctAddEnf_MouseLeave(sender As Object, e As EventArgs) Handles PctAddEnf.MouseLeave
        PctAddEnf.Cursor = Cursors.Arrow
        While PnlAddEnf.Width > 74
            PnlAddEnf.Width -= 1
        End While
    End Sub

    Private Sub PctModEnf_MouseLeave(sender As Object, e As EventArgs) Handles PctModEnf.MouseLeave
        PctModEnf.Cursor = Cursors.Arrow
        While PnlModEnf.Width > 74
            PnlModEnf.Width -= 1
        End While
    End Sub

    Private Sub PctDelEnf_MouseLeave(sender As Object, e As EventArgs) Handles PctDelEnf.MouseLeave
        PctDelEnf.Cursor = Cursors.Arrow
        While PnlDelEnf.Width > 74
            PnlDelEnf.Width -= 1
        End While
    End Sub

    Private Sub PctAddUsr_MouseEnter(sender As Object, e As EventArgs) Handles PctAddUsr.MouseEnter
        PctAddUsr.Cursor = Cursors.Hand
        While PnlAddUsr.Width < 194
            PnlAddUsr.Width += 1
        End While
    End Sub

    Private Sub PctDelUsr_MouseEnter(sender As Object, e As EventArgs) Handles PctDelUsr.MouseEnter
        PctDelUsr.Cursor = Cursors.Hand
        While PnlDelUsr.Width < 194
            PnlDelUsr.Width += 1
        End While
    End Sub

    Private Sub PctModUsr_MouseEnter(sender As Object, e As EventArgs) Handles PctModUsr.MouseEnter
        PctModUsr.Cursor = Cursors.Hand
        While PnlModUsr.Width < 194
            PnlModUsr.Width += 1
        End While
    End Sub

    Private Sub PctAddUsr_MouseLeave(sender As Object, e As EventArgs) Handles PctAddUsr.MouseLeave
        PctAddUsr.Cursor = Cursors.Arrow
        While PnlAddUsr.Width > 74
            PnlAddUsr.Width -= 1
        End While
    End Sub

    Private Sub PctModUsr_MouseLeave(sender As Object, e As EventArgs) Handles PctModUsr.MouseLeave
        PctModUsr.Cursor = Cursors.Arrow
        While PnlModUsr.Width > 74
            PnlModUsr.Width -= 1
        End While
    End Sub

    Private Sub PctDelUsr_MouseLeave(sender As Object, e As EventArgs) Handles PctDelUsr.MouseLeave
        PctDelUsr.Cursor = Cursors.Arrow
        While PnlDelUsr.Width > 74
            PnlDelUsr.Width -= 1
        End While
    End Sub

    Private Sub PctAdd_Click(sender As Object, e As EventArgs) Handles PctAdd.Click
        FrmNuevoSintoma.Show()
        Me.Hide()
    End Sub

    Private Sub PctAddEnf_Click(sender As Object, e As EventArgs) Handles PctAddEnf.Click
        FrmNuevaEnfermedad.Show()
        Me.Hide()
    End Sub

    Private Sub PctAddUser_Click(sender As Object, e As EventArgs) Handles PctAddUsr.Click
        FrmNuevoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub PctMod_Click(sender As Object, e As EventArgs) Handles PctMod.Click
        FrmModificarSintoma.Show()
        Me.Hide()
    End Sub

    Private Sub PctModEnf_Click(sender As Object, e As EventArgs) Handles PctModEnf.Click
        FrmModificarEnfermedad.Show()
        Me.Hide()
    End Sub

    Private Sub PctModUser_Click(sender As Object, e As EventArgs) Handles PctModUsr.Click
        FrmModificarUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub PctDel_Click(sender As Object, e As EventArgs) Handles PctDel.Click
        FrmEliminarSintoma.Show()
        Me.Hide()
    End Sub

    Private Sub PctDelEnf_Click(sender As Object, e As EventArgs) Handles PctDelEnf.Click
        FrmEliminarEnfermedad.Show()
        Me.Hide()
    End Sub

    Private Sub PctDelUser_Click(sender As Object, e As EventArgs) Handles PctDelUsr.Click
        FrmEliminarUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Me.Dispose()
        FrmLogin.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCSV.Click
        FrmSintomasCsv.Show()

    End Sub
End Class
