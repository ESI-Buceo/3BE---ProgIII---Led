<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Iniciar_Chat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Iniciar_Chat))
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblIniciarChat = New System.Windows.Forms.Label()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.LblDescripcionVentana = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.PctPrioridad = New System.Windows.Forms.PictureBox()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(28, 28)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(0, 13)
        Me.LblId.TabIndex = 21
        '
        'TxtEnfermedad
        '
        Me.TxtEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEnfermedad.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtEnfermedad.Enabled = False
        Me.TxtEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedad.Location = New System.Drawing.Point(65, 144)
        Me.TxtEnfermedad.Multiline = True
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(233, 34)
        Me.TxtEnfermedad.TabIndex = 18
        Me.TxtEnfermedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.TxtDescripcion.Location = New System.Drawing.Point(65, 213)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(233, 106)
        Me.TxtDescripcion.TabIndex = 16
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.LblDescripcion.Location = New System.Drawing.Point(62, 192)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(87, 18)
        Me.LblDescripcion.TabIndex = 15
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.LblPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridad.ForeColor = System.Drawing.Color.Black
        Me.LblPrioridad.Location = New System.Drawing.Point(479, 160)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(71, 18)
        Me.LblPrioridad.TabIndex = 14
        Me.LblPrioridad.Text = "Prioridad:"
        '
        'LblIniciarChat
        '
        Me.LblIniciarChat.AutoSize = True
        Me.LblIniciarChat.BackColor = System.Drawing.Color.Transparent
        Me.LblIniciarChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIniciarChat.ForeColor = System.Drawing.Color.Black
        Me.LblIniciarChat.Location = New System.Drawing.Point(116, 397)
        Me.LblIniciarChat.Name = "LblIniciarChat"
        Me.LblIniciarChat.Size = New System.Drawing.Size(420, 18)
        Me.LblIniciarChat.TabIndex = 12
        Me.LblIniciarChat.Text = "Si desea conversar con un profesional, haga click aqui"
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BtnIniciarChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIniciarChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIniciarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciarChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarChat.ForeColor = System.Drawing.Color.White
        Me.BtnIniciarChat.Location = New System.Drawing.Point(242, 444)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(187, 64)
        Me.BtnIniciarChat.TabIndex = 11
        Me.BtnIniciarChat.Text = "Iniciar Chat"
        Me.BtnIniciarChat.UseVisualStyleBackColor = False
        '
        'LblDescripcionVentana
        '
        Me.LblDescripcionVentana.AutoSize = True
        Me.LblDescripcionVentana.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcionVentana.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcionVentana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcionVentana.Location = New System.Drawing.Point(177, 13)
        Me.LblDescripcionVentana.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcionVentana.Name = "LblDescripcionVentana"
        Me.LblDescripcionVentana.Size = New System.Drawing.Size(330, 31)
        Me.LblDescripcionVentana.TabIndex = 32
        Me.LblDescripcionVentana.Text = "Resultado del Diagnostico"
        Me.LblDescripcionVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(62, 123)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 18)
        Me.LblNombre.TabIndex = 33
        Me.LblNombre.Text = "Nombre"
        '
        'PctSalir
        '
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaDePresentacion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(610, 12)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(53, 50)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 34
        Me.PctSalir.TabStop = False
        '
        'PctPrioridad
        '
        Me.PctPrioridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PctPrioridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctPrioridad.Location = New System.Drawing.Point(454, 192)
        Me.PctPrioridad.Name = "PctPrioridad"
        Me.PctPrioridad.Size = New System.Drawing.Size(124, 112)
        Me.PctPrioridad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctPrioridad.TabIndex = 35
        Me.PctPrioridad.TabStop = False
        '
        'Frm_Iniciar_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BackgroundImage = Global.CapaDePresentacion.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(675, 559)
        Me.Controls.Add(Me.PctPrioridad)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblDescripcionVentana)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtEnfermedad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.LblIniciarChat)
        Me.Controls.Add(Me.BtnIniciarChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Iniciar_Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Chat"
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents TxtEnfermedad As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblIniciarChat As Label
    Friend WithEvents BtnIniciarChat As Button
    Friend WithEvents LblDescripcionVentana As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents PctPrioridad As PictureBox
End Class
