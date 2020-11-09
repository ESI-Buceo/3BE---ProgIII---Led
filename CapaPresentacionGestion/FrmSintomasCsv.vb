Imports CapaDeNegocio

Public Class FrmSintomasCsv

    Public Sintomas As New List(Of String)
    Public Posicion As New List(Of Integer)

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        OfdSeleccionarCsv.ShowDialog()
        TxtRuta.Text = OfdSeleccionarCsv.FileName.ToString()

    End Sub

    Private Sub TxtRuta_TextChanged(sender As Object, e As EventArgs) Handles TxtRuta.TextChanged
        If TxtRuta.Text <> "" Then
            PctAceptar.Enabled = True
        Else
            PctAceptar.Enabled = False
        End If

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        Try
            Using Archivo As New Microsoft.VisualBasic.FileIO.TextFieldParser(TxtRuta.Text)
                Archivo.TextFieldType = FileIO.FieldType.Delimited
                Archivo.SetDelimiters(",")

                Dim Fila As String()
                Sintomas.Clear()

                If CbxHeader.Checked = False Then
                    Using Archivo
                        While Not Archivo.EndOfData
                            Fila = Archivo.ReadFields()
                            Dim Campo As String
                            For Each Campo In Fila
                                Try
                                    ControladorSintoma.CrearSintoma(Campo)
                                Catch ex As Exception

                                End Try
                            Next

                        End While

                    End Using

                Else
                    Dim Pos As Integer = 0

                    While Not Archivo.EndOfData

                        Fila = Archivo.ReadFields()
                        Dim Campo As String
                        For Each Campo In Fila
                            If Pos = 0 Then
                                Pos = 1
                            Else
                                Try
                                    ControladorSintoma.CrearSintoma(Campo)
                                Catch ex As Exception

                                End Try
                            End If
                        Next

                    End While

                End If
                MsgBox("Fin del archivo!", MsgBoxStyle.Information, "Finalizado")
                Limpiar()
            End Using
        Catch ex As Exception
            MsgBox("No se pudo cargar el archivo", MsgBoxStyle.Critical, "Algo salió mal (✖╭╮✖)")
        End Try


    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs)
        Limpiar()
        Me.Hide()
        FrmMenuGestion.Show()

    End Sub

    Private Sub Limpiar()
        TxtRuta.Text = ""
        CbxHeader.Checked = False
    End Sub

    Private Sub FrmSintomasCsv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Limpiar()
        Me.Hide()
        FrmMenuGestion.Show()
    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

    Private Sub PctSalir_Click(sender As Object, e As EventArgs) Handles PctSalir.Click
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

End Class