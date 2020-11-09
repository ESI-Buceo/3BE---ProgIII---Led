Imports CapaDeNegocio

Public Class FrmEliminarEnfermedad

    Public Id As String

    Private Sub FrmEliminarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerDatos()

    End Sub

    Private Sub TraerDatos()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorEnfermedad.ListarNombreEnfermedadesActivas()
            CargarCmbEnfermedades(LectorEnfermedades)
        Catch ex As Exception
            MsgBox("Error al intentar cargar las enfermedades", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub CargarCmbEnfermedades(lector As IDataReader)
        CmbEnfermedades.Items.Clear()
        While lector.Read
            CmbEnfermedades.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedades.SelectedIndexChanged
        Try
            ObtenerDatos(ControladorEnfermedad.ObtenerId(CmbEnfermedades.SelectedItem.ToString))
            PctAceptar.Enabled = True
        Catch ex As Exception
            MsgBox("No se pudo identificar la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub ObtenerDatos(id As String)
        Try
            TxtDescripcion.Text = ControladorEnfermedad.ObtenerDescripcion(id)
            TxtPrioridad.Text = ControladorEnfermedad.ObtenerPrioridad(id)
            ObtenerSintomas(id)
        Catch ex As Exception
            MsgBox("No se pudieron obtener los datos", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub ObtenerSintomas(idEnfermedad)
        Id = idEnfermedad
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorCompone.ObtenerSintomasEnfermedad(idEnfermedad)
            MostrarSintomas(LectorSintomas)
        Catch ex As Exception
            MsgBox("No se pudieron obtener los sintomas de la enfermedad")
        End Try

    End Sub

    Private Sub MostrarSintomas(lector)
        LstSintomas.Clear()
        While lector.Read
            LstSintomas.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs)
        Try
            ControladorEnfermedad.EliminarEnfermedad(Id)
            Limpiar()
            TraerDatos()
        Catch ex As Exception
            MsgBox("Error al intentar de eliminar la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs)
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub Limpiar()
        TxtDescripcion.Text = ""
        TxtPrioridad.Text = ""
        LstSintomas.Clear()
        PctAceptar.Enabled = False

    End Sub

    Private Sub PctSalir_Click(sender As Object, e As EventArgs) Handles PctSalir.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        Try
            ControladorEnfermedad.EliminarEnfermedad(Id)
            MsgBox("Enfermedad eliminada con éxito!", MsgBoxStyle.Information, "Eliminación de Enfermedad")
            Limpiar()
            TraerDatos()
        Catch ex As Exception
            MsgBox("Error al intentar eliminar la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try

    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

End Class