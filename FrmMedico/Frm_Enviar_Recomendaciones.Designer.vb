<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Enviar_Recomendaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Enviar_Recomendaciones))
        Me.LblCorreo1 = New System.Windows.Forms.Label()
        Me.CmbAcciones = New System.Windows.Forms.ComboBox()
        Me.CmbSobre = New System.Windows.Forms.ComboBox()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.LblObjetivo = New System.Windows.Forms.Label()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.CmbItem = New System.Windows.Forms.ComboBox()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblCorreo2 = New System.Windows.Forms.Label()
        Me.PctEnviarCorreo = New System.Windows.Forms.PictureBox()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEnviarCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCorreo1
        '
        Me.LblCorreo1.AutoSize = True
        Me.LblCorreo1.BackColor = System.Drawing.Color.Transparent
        Me.LblCorreo1.Font = New System.Drawing.Font("Libre Franklin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo1.Location = New System.Drawing.Point(16, 100)
        Me.LblCorreo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCorreo1.Name = "LblCorreo1"
        Me.LblCorreo1.Size = New System.Drawing.Size(60, 18)
        Me.LblCorreo1.TabIndex = 0
        Me.LblCorreo1.Text = "Asunto"
        '
        'CmbAcciones
        '
        Me.CmbAcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAcciones.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAcciones.FormattingEnabled = True
        Me.CmbAcciones.Items.AddRange(New Object() {"Agregar", "Eliminar", "Modificar"})
        Me.CmbAcciones.Location = New System.Drawing.Point(127, 160)
        Me.CmbAcciones.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbAcciones.Name = "CmbAcciones"
        Me.CmbAcciones.Size = New System.Drawing.Size(160, 24)
        Me.CmbAcciones.TabIndex = 1
        '
        'CmbSobre
        '
        Me.CmbSobre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSobre.Enabled = False
        Me.CmbSobre.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSobre.FormattingEnabled = True
        Me.CmbSobre.Items.AddRange(New Object() {"Sintoma", "Enfermedad"})
        Me.CmbSobre.Location = New System.Drawing.Point(472, 160)
        Me.CmbSobre.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbSobre.Name = "CmbSobre"
        Me.CmbSobre.Size = New System.Drawing.Size(160, 24)
        Me.CmbSobre.TabIndex = 2
        '
        'LblAccion
        '
        Me.LblAccion.AutoSize = True
        Me.LblAccion.BackColor = System.Drawing.Color.Transparent
        Me.LblAccion.Font = New System.Drawing.Font("Libre Franklin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccion.Location = New System.Drawing.Point(184, 123)
        Me.LblAccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAccion.Name = "LblAccion"
        Me.LblAccion.Size = New System.Drawing.Size(57, 18)
        Me.LblAccion.TabIndex = 3
        Me.LblAccion.Text = "Acción"
        '
        'LblObjetivo
        '
        Me.LblObjetivo.AutoSize = True
        Me.LblObjetivo.BackColor = System.Drawing.Color.Transparent
        Me.LblObjetivo.Font = New System.Drawing.Font("Libre Franklin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblObjetivo.Location = New System.Drawing.Point(521, 127)
        Me.LblObjetivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblObjetivo.Name = "LblObjetivo"
        Me.LblObjetivo.Size = New System.Drawing.Size(51, 18)
        Me.LblObjetivo.TabIndex = 4
        Me.LblObjetivo.Text = "Sobre"
        '
        'LblTexto
        '
        Me.LblTexto.AutoSize = True
        Me.LblTexto.BackColor = System.Drawing.Color.Transparent
        Me.LblTexto.Font = New System.Drawing.Font("Libre Franklin Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTexto.Location = New System.Drawing.Point(337, 164)
        Me.LblTexto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(41, 15)
        Me.LblTexto.TabIndex = 5
        Me.LblTexto.Text = "El / La"
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Enabled = False
        Me.RtbMensaje.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbMensaje.Location = New System.Drawing.Point(96, 265)
        Me.RtbMensaje.Margin = New System.Windows.Forms.Padding(4)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(776, 157)
        Me.RtbMensaje.TabIndex = 6
        Me.RtbMensaje.Text = ""
        '
        'CmbItem
        '
        Me.CmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItem.Enabled = False
        Me.CmbItem.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItem.FormattingEnabled = True
        Me.CmbItem.Location = New System.Drawing.Point(712, 160)
        Me.CmbItem.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbItem.Name = "CmbItem"
        Me.CmbItem.Size = New System.Drawing.Size(160, 24)
        Me.CmbItem.TabIndex = 8
        '
        'LblItem
        '
        Me.LblItem.AutoSize = True
        Me.LblItem.BackColor = System.Drawing.Color.Transparent
        Me.LblItem.Enabled = False
        Me.LblItem.Font = New System.Drawing.Font("Libre Franklin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItem.Location = New System.Drawing.Point(769, 127)
        Me.LblItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(41, 18)
        Me.LblItem.TabIndex = 10
        Me.LblItem.Text = "Item"
        Me.LblItem.Visible = False
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = CType(resources.GetObject("PctSalir.Image"), System.Drawing.Image)
        Me.PctSalir.Location = New System.Drawing.Point(885, 2)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(69, 64)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 21
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Libre Franklin", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(339, 23)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(336, 33)
        Me.LblDescripcion.TabIndex = 22
        Me.LblDescripcion.Text = "Enviar Recomendaciones"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCorreo2
        '
        Me.LblCorreo2.AutoSize = True
        Me.LblCorreo2.BackColor = System.Drawing.Color.Transparent
        Me.LblCorreo2.Font = New System.Drawing.Font("Libre Franklin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo2.Location = New System.Drawing.Point(16, 229)
        Me.LblCorreo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCorreo2.Name = "LblCorreo2"
        Me.LblCorreo2.Size = New System.Drawing.Size(83, 18)
        Me.LblCorreo2.TabIndex = 23
        Me.LblCorreo2.Text = "Contenido"
        '
        'PctEnviarCorreo
        '
        Me.PctEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEnviarCorreo.Enabled = False
        Me.PctEnviarCorreo.Image = Global.FrmMedico.My.Resources.Resources.EnviarMensajeBloqueadoFondoClaro
        Me.PctEnviarCorreo.Location = New System.Drawing.Point(440, 452)
        Me.PctEnviarCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.PctEnviarCorreo.Name = "PctEnviarCorreo"
        Me.PctEnviarCorreo.Size = New System.Drawing.Size(100, 84)
        Me.PctEnviarCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEnviarCorreo.TabIndex = 24
        Me.PctEnviarCorreo.TabStop = False
        '
        'Frm_Enviar_Recomendaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.FrmMedico.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(958, 549)
        Me.Controls.Add(Me.PctEnviarCorreo)
        Me.Controls.Add(Me.LblCorreo2)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.CmbItem)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.LblTexto)
        Me.Controls.Add(Me.LblObjetivo)
        Me.Controls.Add(Me.LblAccion)
        Me.Controls.Add(Me.CmbSobre)
        Me.Controls.Add(Me.CmbAcciones)
        Me.Controls.Add(Me.LblCorreo1)
        Me.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Enviar_Recomendaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Enviar recomendaciones"
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEnviarCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCorreo1 As Label
    Friend WithEvents CmbAcciones As ComboBox
    Friend WithEvents CmbSobre As ComboBox
    Friend WithEvents LblAccion As Label
    Friend WithEvents LblObjetivo As Label
    Friend WithEvents LblTexto As Label
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents CmbItem As ComboBox
    Friend WithEvents LblItem As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblCorreo2 As Label
    Friend WithEvents PctEnviarCorreo As PictureBox
End Class
