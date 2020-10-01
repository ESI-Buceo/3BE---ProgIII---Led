﻿Imports CapaDeNegocio

Public Class FrmConsultas

    Private Sub FrmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TablaConsultas As New DataTable
        Try
            TablaConsultas.Load(ControladorChat.ObtenerIdFechaMisChat())
            DgvConsultas.DataSource = TablaConsultas
        Catch ex As Exception
            MsgBox("No se pudo obtener las consultas" + ex.ToString)
        End Try
    End Sub

    Private Sub DgvConsultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsultas.CellContentClick
        Dim IdDiagnostico As String = DgvConsultas.Item("Id", DgvConsultas.CurrentCell.RowIndex).Value.ToString
        ObtenerCedulaPaciente(IdDiagnostico)
    End Sub

    Private Sub ObtenerCedulaPaciente(Id As String)
        Dim CedulaPaciente As String = ControladorDiagnostico.ObtenerCedulaPaciente(Id)
        ObtenerDatosPaciente(CedulaPaciente)
        ObtenerDatosConsulta(Id)

    End Sub

    Private Sub ObtenerDatosPaciente(cedula As String)
        Dim LectorDatos As IDataReader = ControladorPaciente.ObtenerTodo(cedula)
        Dim LectorEnfermedades As IDataReader = ControladorPaciente.ObtenerEnfermedades(cedula)
        Dim LectorMedicaciones As IDataReader = ControladorPaciente.ObtenerMedicaciones(cedula)
        CargarDatosPersonales(LectorDatos, cedula)
        CargarEnfermedadesCronicas(LectorEnfermedades)
        CargarMedicaciones(LectorMedicaciones)
    End Sub

    Private Sub CargarDatosPersonales(lector As IDataReader, cedula As String)
        While lector.Read
            TxtCedula.Text = cedula
            TxtNombre.Text = lector(0).ToString + lector(1).ToString
            TxtCorreo.Text = lector(2).ToString
            If lector(3).ToString = 0 Then
                TxtSexo.Text = "Hombre"
            Else
                TxtSexo.Text = "Mujer"
            End If
            TxtEdad.Text = ObtenerEdad(lector(4).ToString)

        End While
    End Sub

    Private Function ObtenerEdad(lectorFecha As Date)
        Dim Edad As Integer = DateDiff(DateInterval.Year, lectorFecha, Date.Now)
        Return Edad
    End Function

    Private Sub CargarEnfermedadesCronicas(enfermedades As IDataReader)
        LstEnfermedades.Items.Clear()
        While enfermedades.Read
            LstEnfermedades.Items.Add(enfermedades(0).ToString)
        End While

    End Sub

    Private Sub CargarMedicaciones(medicaciones As IDataReader)
        LstMedicaciones.Items.Clear()
        While medicaciones.Read
            LstMedicaciones.Items.Add(medicaciones(0).ToString)
        End While

    End Sub

    Private Sub ObtenerDatosConsulta(id As String)
        TxtEnfermedad.Text = ControladorGenera.ObtenerNombreEnfermedad(id)
        Dim LectorSintomas As IDataReader = ControladorGenera.ObtenerNombreSintomas(id)
        Dim LectorConversacion As IDataReader = ControladorChat.ObtenerMensajesDelDiagnostico(id)
        CargarListaSintomas(LectorSintomas)
        CargarConversacion(LectorConversacion)

    End Sub

    Private Sub CargarListaSintomas(lector As IDataReader)
        LstSintomas.Items.Clear()
        While lector.Read
            LstSintomas.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CargarConversacion(lector As IDataReader)
        WbbConversacion.DocumentText = ""
        While lector.Read
            WbbConversacion.DocumentText += "<p>" + lector(1).ToString + "</p>"
        End While
    End Sub
End Class