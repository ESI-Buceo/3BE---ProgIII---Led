Imports CapaDeNegocio

Public Class FrmNuevaEnfermedad

    Public ListaSintomas As New List(Of String)
    Public Nombre, Prioridad, Sintomas, Reactivacion As Boolean

    Private Sub FrmNuevaEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSintomas()
    End Sub

    Private Sub CargarSintomas()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()
            CargarCmbSintomas(LectorSintomas)
        Catch ex As Exception
            MsgBox("No se pudieron cargar los sintomas", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub CargarCmbSintomas(lector As IDataReader)
        While lector.Read
            CmbSintomas.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        ListaSintomas.Add(CmbSintomas.SelectedItem.ToString)
        CmbSintomas.Items.RemoveAt(CmbSintomas.SelectedIndex())
        Prioridad = True
        CargarListado()

    End Sub

    Private Sub CargarListado()
        LstSintomasSeleccionados.Clear()
        For Each sintoma In ListaSintomas
            LstSintomasSeleccionados.Items.Add(sintoma)
        Next
        VerificarCantidad()

    End Sub

    Private Sub LstSintomasSeleccionados_DoubleClick(sender As Object, e As EventArgs) Handles LstSintomasSeleccionados.DoubleClick
        CmbSintomas.Items.Add(LstSintomasSeleccionados.Items(LstSintomasSeleccionados.SelectedIndices(0)).Text)
        LstSintomasSeleccionados.Items.RemoveAt(LstSintomasSeleccionados.SelectedIndices(0))
        ActualizarLista()

    End Sub

    Private Sub DevolverSintomasAlCmb()
        For x = 0 To LstSintomasSeleccionados.Items.Count() - 1
            CmbSintomas.Items.Add(LstSintomasSeleccionados.Items(x).Text)
        Next

    End Sub

    Private Sub ActualizarLista()
        ListaSintomas.Clear()
        For x = 0 To LstSintomasSeleccionados.Items.Count - 1
            ListaSintomas.Add(LstSintomasSeleccionados.Items(x).Text)
        Next
        VerificarCantidad()
    End Sub

    Private Sub VerificarCantidad()
        If LstSintomasSeleccionados.Items.Count() > 0 Then
            Sintomas = True
        Else
            Sintomas = False
        End If
        HabilitarCreacion(False)
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged

        HabilitarCreacion(False)
    End Sub


    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

        If ControladorEnfermedad.ObtenerExistencia(TxtNombre.Text) = 1 Then
            AveriguarInactividad()

        ElseIf TxtNombre.Text = "" Then
            LblDisponible.Text = "El nombre no puede " + vbCrLf + "estar vacio"
            Nombre = False
            Reactivacion = False

        Else
            LblDisponible.Text = "Nombre disponible"
            Nombre = True
            Reactivacion = False

        End If
        HabilitarCreacion(Reactivacion)
    End Sub

    Private Sub AveriguarInactividad()
        If ControladorEnfermedad.EstaInactivo(TxtNombre.Text) = 1 Then
            Reactivacion = True
            LblDisponible.Text = "Esta enfermedad se " + vbCrLf + "encuentra inactiva, pulse " + vbCrLf + "el botón para que" + vbCrLf + "vuela a esta activa"

        Else
            Reactivacion = False
            LblDisponible.Text = "El nombre de esta " + vbCrLf + "enfermedad ya esta " + vbCrLf + "en uso"
            BloquearCampos()
        End If

    End Sub

    Private Sub HabilitarCreacion(Reactivacion As Boolean)
        If Reactivacion Then
            PctAceptar.Enabled = Reactivacion
            PctAceptar.Image = My.Resources.Reactivar
            TxtDescripcion.Enabled = False
            CmbPrioridad.Enabled = False
            CmbSintomas.Enabled = False
            LstSintomasSeleccionados.Enabled = False

        ElseIf Nombre And Prioridad And LstSintomasSeleccionados.Items.Count() > 0 Then
            PctAceptar.Enabled = True
            PctAceptar.Image = My.Resources.Aceptar1

        Else
            PctAceptar.Image = My.Resources.Aceptar1
            PctAceptar.Enabled = False

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

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        If Reactivacion Then
            Actualizar()
        Else
            Crear()
        End If

    End Sub

    Private Sub Actualizar()
        Try
            ControladorEnfermedad.ActivarEnfermedad(TxtNombre.Text)
            MsgBox("Enfermedad reactivada con éxito!", MsgBoxStyle.Information, "Reactivación de enfermedad")
            Limpiar()
        Catch ex As Exception
            MsgBox("Error al intentar reactivar la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub Crear()
        Try
            ControladorEnfermedad.CrearEnfermedad(TxtNombre.Text,
                                                  TxtDescripcion.Text,
                                                  CmbPrioridad.SelectedItem.ToString,
                                                  ListaSintomas)
            MsgBox("Enfermedad creada con éxito!", MsgBoxStyle.Information, "Creación de enfermedad")
            Limpiar()
        Catch ex As Exception
            MsgBox("Error al intentar crear la enfermedad", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try
    End Sub

    Private Sub BloquearCampos()
        TxtDescripcion.Enabled = PctAceptar.Enabled
        CmbPrioridad.Enabled = PctAceptar.Enabled
        CmbSintomas.Enabled = PctAceptar.Enabled
        LstSintomasSeleccionados.Enabled = PctAceptar.Enabled

    End Sub

    Private Sub PctCancelar_Click(sender As Object, e As EventArgs) Handles PctCancelar.Click
        Limpiar()

    End Sub

    Private Sub PctCancelar_MouseEnter(sender As Object, e As EventArgs) Handles PctCancelar.MouseEnter
        PctCancelar.Image = My.Resources.Cancelar2

    End Sub

    Private Sub PctCancelar_MouseLeave(sender As Object, e As EventArgs) Handles PctCancelar.MouseLeave
        PctCancelar.Image = My.Resources.Cancelar1

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

    Private Sub Limpiar()
        DevolverSintomasAlCmb()
        TxtNombre.Clear()
        TxtDescripcion.Clear()
        LstSintomasSeleccionados.Clear()
        ListaSintomas.Clear()

    End Sub

End Class