<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consultas))
        Me.DgvDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.PnlInformacion = New System.Windows.Forms.Panel()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.RtbChat = New System.Windows.Forms.RichTextBox()
        Me.RtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.LblPrioridadEnfermedad = New System.Windows.Forms.Label()
        Me.DgvSintomas = New System.Windows.Forms.DataGridView()
        Me.LblNombreEnfermedad = New System.Windows.Forms.Label()
        Me.LblConversacion = New System.Windows.Forms.Label()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblMedico = New System.Windows.Forms.Label()
        Me.LblIndicaciones = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlInformacion.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDiagnosticos
        '
        Me.DgvDiagnosticos.AllowUserToAddRows = False
        Me.DgvDiagnosticos.AllowUserToDeleteRows = False
        Me.DgvDiagnosticos.AllowUserToResizeColumns = False
        Me.DgvDiagnosticos.AllowUserToResizeRows = False
        Me.DgvDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDiagnosticos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDiagnosticos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvDiagnosticos.GridColor = System.Drawing.Color.Black
        Me.DgvDiagnosticos.Location = New System.Drawing.Point(4, 82)
        Me.DgvDiagnosticos.MultiSelect = False
        Me.DgvDiagnosticos.Name = "DgvDiagnosticos"
        Me.DgvDiagnosticos.ReadOnly = True
        Me.DgvDiagnosticos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvDiagnosticos.RowHeadersVisible = False
        Me.DgvDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDiagnosticos.Size = New System.Drawing.Size(238, 515)
        Me.DgvDiagnosticos.TabIndex = 0
        '
        'PnlInformacion
        '
        Me.PnlInformacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PnlInformacion.Controls.Add(Me.LblPrioridad)
        Me.PnlInformacion.Controls.Add(Me.LblNombre)
        Me.PnlInformacion.Controls.Add(Me.RtbChat)
        Me.PnlInformacion.Controls.Add(Me.RtbDescripcion)
        Me.PnlInformacion.Controls.Add(Me.LblPrioridadEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.DgvSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblNombreEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.LblConversacion)
        Me.PnlInformacion.Controls.Add(Me.LblEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.LblSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblMedico)
        Me.PnlInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlInformacion.Location = New System.Drawing.Point(248, 82)
        Me.PnlInformacion.Name = "PnlInformacion"
        Me.PnlInformacion.Size = New System.Drawing.Size(840, 515)
        Me.PnlInformacion.TabIndex = 1
        Me.PnlInformacion.Visible = False
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridad.Location = New System.Drawing.Point(266, 140)
        Me.LblPrioridad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(66, 16)
        Me.LblPrioridad.TabIndex = 11
        Me.LblPrioridad.Text = "Prioridad:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(266, 46)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(60, 16)
        Me.LblNombre.TabIndex = 10
        Me.LblNombre.Text = "Nombre:"
        '
        'RtbChat
        '
        Me.RtbChat.Location = New System.Drawing.Point(49, 268)
        Me.RtbChat.Name = "RtbChat"
        Me.RtbChat.ReadOnly = True
        Me.RtbChat.Size = New System.Drawing.Size(751, 223)
        Me.RtbChat.TabIndex = 9
        Me.RtbChat.Text = ""
        '
        'RtbDescripcion
        '
        Me.RtbDescripcion.Location = New System.Drawing.Point(466, 43)
        Me.RtbDescripcion.Name = "RtbDescripcion"
        Me.RtbDescripcion.ReadOnly = True
        Me.RtbDescripcion.Size = New System.Drawing.Size(334, 156)
        Me.RtbDescripcion.TabIndex = 8
        Me.RtbDescripcion.Text = ""
        '
        'LblPrioridadEnfermedad
        '
        Me.LblPrioridadEnfermedad.AutoSize = True
        Me.LblPrioridadEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridadEnfermedad.Location = New System.Drawing.Point(266, 167)
        Me.LblPrioridadEnfermedad.Name = "LblPrioridadEnfermedad"
        Me.LblPrioridadEnfermedad.Size = New System.Drawing.Size(0, 16)
        Me.LblPrioridadEnfermedad.TabIndex = 7
        '
        'DgvSintomas
        '
        Me.DgvSintomas.AllowUserToAddRows = False
        Me.DgvSintomas.AllowUserToDeleteRows = False
        Me.DgvSintomas.AllowUserToResizeColumns = False
        Me.DgvSintomas.AllowUserToResizeRows = False
        Me.DgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSintomas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSintomas.ColumnHeadersVisible = False
        Me.DgvSintomas.Enabled = False
        Me.DgvSintomas.GridColor = System.Drawing.SystemColors.Control
        Me.DgvSintomas.Location = New System.Drawing.Point(49, 46)
        Me.DgvSintomas.MultiSelect = False
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSintomas.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSintomas.RowHeadersVisible = False
        Me.DgvSintomas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvSintomas.RowTemplate.ReadOnly = True
        Me.DgvSintomas.ShowCellErrors = False
        Me.DgvSintomas.ShowCellToolTips = False
        Me.DgvSintomas.ShowEditingIcon = False
        Me.DgvSintomas.ShowRowErrors = False
        Me.DgvSintomas.Size = New System.Drawing.Size(180, 153)
        Me.DgvSintomas.TabIndex = 6
        '
        'LblNombreEnfermedad
        '
        Me.LblNombreEnfermedad.AutoSize = True
        Me.LblNombreEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreEnfermedad.Location = New System.Drawing.Point(266, 73)
        Me.LblNombreEnfermedad.Name = "LblNombreEnfermedad"
        Me.LblNombreEnfermedad.Size = New System.Drawing.Size(0, 16)
        Me.LblNombreEnfermedad.TabIndex = 5
        '
        'LblConversacion
        '
        Me.LblConversacion.AutoSize = True
        Me.LblConversacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConversacion.Location = New System.Drawing.Point(46, 241)
        Me.LblConversacion.Name = "LblConversacion"
        Me.LblConversacion.Size = New System.Drawing.Size(103, 16)
        Me.LblConversacion.TabIndex = 4
        Me.LblConversacion.Text = "Conversacion"
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedad.Location = New System.Drawing.Point(414, 14)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(197, 16)
        Me.LblEnfermedad.TabIndex = 2
        Me.LblEnfermedad.Text = "Enfermedad Diagnosticada"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomas.Location = New System.Drawing.Point(46, 14)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(162, 16)
        Me.LblSintomas.TabIndex = 1
        Me.LblSintomas.Text = "Sintomas Consultados"
        '
        'LblMedico
        '
        Me.LblMedico.AutoSize = True
        Me.LblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedico.Location = New System.Drawing.Point(473, 241)
        Me.LblMedico.Name = "LblMedico"
        Me.LblMedico.Size = New System.Drawing.Size(102, 16)
        Me.LblMedico.TabIndex = 0
        Me.LblMedico.Text = "Medico a cargo"
        '
        'LblIndicaciones
        '
        Me.LblIndicaciones.AutoSize = True
        Me.LblIndicaciones.BackColor = System.Drawing.Color.Transparent
        Me.LblIndicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblIndicaciones.Location = New System.Drawing.Point(10, 9)
        Me.LblIndicaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblIndicaciones.Name = "LblIndicaciones"
        Me.LblIndicaciones.Size = New System.Drawing.Size(0, 20)
        Me.LblIndicaciones.TabIndex = 2
        Me.LblIndicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaDePresentacion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(1030, 9)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(58, 55)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 4
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(416, 18)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(279, 31)
        Me.LblDescripcion.TabIndex = 5
        Me.LblDescripcion.Text = "Historial de Consultas"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.CapaDePresentacion.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(1100, 617)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.LblIndicaciones)
        Me.Controls.Add(Me.PnlInformacion)
        Me.Controls.Add(Me.DgvDiagnosticos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlInformacion.ResumeLayout(False)
        Me.PnlInformacion.PerformLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvDiagnosticos As DataGridView
    Friend WithEvents PnlInformacion As Panel
    Friend WithEvents LblPrioridadEnfermedad As Label
    Friend WithEvents DgvSintomas As DataGridView
    Friend WithEvents LblNombreEnfermedad As Label
    Friend WithEvents LblConversacion As Label
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblMedico As Label
    Friend WithEvents RtbDescripcion As RichTextBox
    Friend WithEvents RtbChat As RichTextBox
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblIndicaciones As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
End Class
