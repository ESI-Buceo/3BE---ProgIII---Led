<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarUsuario))
        Me.CmbCI = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblIndicaciones2 = New System.Windows.Forms.Label()
        Me.LblIndicaciones = New System.Windows.Forms.Label()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.LblTipoDeUsuario = New System.Windows.Forms.Label()
        Me.ChbAdministrador = New System.Windows.Forms.CheckBox()
        Me.ChbMedico = New System.Windows.Forms.CheckBox()
        Me.ChbPaciente = New System.Windows.Forms.CheckBox()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctRefrescar = New System.Windows.Forms.PictureBox()
        Me.PnlBarra.SuspendLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbCI
        '
        Me.CmbCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCI.FormattingEnabled = True
        Me.CmbCI.Location = New System.Drawing.Point(110, 179)
        Me.CmbCI.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CmbCI.Name = "CmbCI"
        Me.CmbCI.Size = New System.Drawing.Size(496, 37)
        Me.CmbCI.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CI"
        '
        'LblIndicaciones2
        '
        Me.LblIndicaciones2.AutoSize = True
        Me.LblIndicaciones2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIndicaciones2.Location = New System.Drawing.Point(620, 97)
        Me.LblIndicaciones2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIndicaciones2.Name = "LblIndicaciones2"
        Me.LblIndicaciones2.Size = New System.Drawing.Size(481, 26)
        Me.LblIndicaciones2.TabIndex = 17
        Me.LblIndicaciones2.Text = "Deseleccione el rol que quiere quitarle al usuario"
        Me.LblIndicaciones2.Visible = False
        '
        'LblIndicaciones
        '
        Me.LblIndicaciones.AutoSize = True
        Me.LblIndicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIndicaciones.Location = New System.Drawing.Point(126, 102)
        Me.LblIndicaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIndicaciones.Name = "LblIndicaciones"
        Me.LblIndicaciones.Size = New System.Drawing.Size(403, 26)
        Me.LblIndicaciones.TabIndex = 18
        Me.LblIndicaciones.Text = "Seleccione cédula de usuario a eliminar:"
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlBarra.Controls.Add(Me.LblDescripcion)
        Me.PnlBarra.Controls.Add(Me.PctSalir)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(1125, 76)
        Me.PnlBarra.TabIndex = 27
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(415, 9)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(326, 47)
        Me.LblDescripcion.TabIndex = 70
        Me.LblDescripcion.Text = "Eliminar Usuario"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(1045, 0)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(80, 76)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 23
        Me.PctSalir.TabStop = False
        '
        'TxtMail
        '
        Me.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMail.Enabled = False
        Me.TxtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.Location = New System.Drawing.Point(110, 420)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMail.MaxLength = 25
        Me.TxtMail.Multiline = True
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(496, 63)
        Me.TxtMail.TabIndex = 56
        Me.TxtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtMail.WordWrap = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(2, 246)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(81, 25)
        Me.LblNombre.TabIndex = 52
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.Color.Black
        Me.LblApellido.Location = New System.Drawing.Point(4, 332)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(82, 25)
        Me.LblApellido.TabIndex = 54
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.Black
        Me.LblMail.Location = New System.Drawing.Point(2, 420)
        Me.LblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(72, 25)
        Me.LblMail.TabIndex = 55
        Me.LblMail.Text = "Correo"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(110, 243)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(496, 62)
        Me.TxtNombre.TabIndex = 51
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNombre.WordWrap = False
        '
        'TxtApellido
        '
        Me.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtApellido.Enabled = False
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(110, 332)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Multiline = True
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(496, 63)
        Me.TxtApellido.TabIndex = 53
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtApellido.WordWrap = False
        '
        'LblTipoDeUsuario
        '
        Me.LblTipoDeUsuario.AutoSize = True
        Me.LblTipoDeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoDeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoDeUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblTipoDeUsuario.Location = New System.Drawing.Point(826, 179)
        Me.LblTipoDeUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoDeUsuario.Name = "LblTipoDeUsuario"
        Me.LblTipoDeUsuario.Size = New System.Drawing.Size(153, 25)
        Me.LblTipoDeUsuario.TabIndex = 60
        Me.LblTipoDeUsuario.Text = "Tipo De Usuario"
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbAdministrador.Location = New System.Drawing.Point(830, 296)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(160, 29)
        Me.ChbAdministrador.TabIndex = 59
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = False
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.BackColor = System.Drawing.Color.Transparent
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbMedico.Location = New System.Drawing.Point(830, 262)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(102, 29)
        Me.ChbMedico.TabIndex = 58
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = False
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.BackColor = System.Drawing.Color.Transparent
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbPaciente.Location = New System.Drawing.Point(830, 228)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(114, 29)
        Me.ChbPaciente.TabIndex = 57
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = False
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(733, 349)
        Me.PctAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(140, 134)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 61
        Me.PctAceptar.TabStop = False
        '
        'PctRefrescar
        '
        Me.PctRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctRefrescar.Enabled = False
        Me.PctRefrescar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Refrescar
        Me.PctRefrescar.Location = New System.Drawing.Point(914, 349)
        Me.PctRefrescar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctRefrescar.Name = "PctRefrescar"
        Me.PctRefrescar.Size = New System.Drawing.Size(140, 134)
        Me.PctRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctRefrescar.TabIndex = 69
        Me.PctRefrescar.TabStop = False
        '
        'FrmEliminarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 614)
        Me.Controls.Add(Me.PctRefrescar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblTipoDeUsuario)
        Me.Controls.Add(Me.ChbAdministrador)
        Me.Controls.Add(Me.ChbMedico)
        Me.Controls.Add(Me.ChbPaciente)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.LblIndicaciones)
        Me.Controls.Add(Me.LblIndicaciones2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbCI)
        Me.Controls.Add(Me.PnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FrmEliminarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Eliminar Usuario"
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbCI As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblIndicaciones2 As Label
    Friend WithEvents LblIndicaciones As Label
    Friend WithEvents PnlBarra As Panel
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents LblTipoDeUsuario As Label
    Friend WithEvents ChbAdministrador As CheckBox
    Friend WithEvents ChbMedico As CheckBox
    Friend WithEvents ChbPaciente As CheckBox
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctRefrescar As PictureBox
    Friend WithEvents LblDescripcion As Label
End Class
