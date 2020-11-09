<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Chat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Chat))
        Me.TmrMensajesNuevos = New System.Windows.Forms.Timer(Me.components)
        Me.WbbConversacion = New System.Windows.Forms.WebBrowser()
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.PctEnviar = New System.Windows.Forms.PictureBox()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrMensajesNuevos
        '
        Me.TmrMensajesNuevos.Interval = 1000
        '
        'WbbConversacion
        '
        Me.WbbConversacion.Location = New System.Drawing.Point(62, 103)
        Me.WbbConversacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WbbConversacion.MinimumSize = New System.Drawing.Size(13, 13)
        Me.WbbConversacion.Name = "WbbConversacion"
        Me.WbbConversacion.Size = New System.Drawing.Size(511, 260)
        Me.WbbConversacion.TabIndex = 4
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Enabled = False
        Me.RtbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbMensaje.Location = New System.Drawing.Point(62, 381)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(422, 50)
        Me.RtbMensaje.TabIndex = 6
        Me.RtbMensaje.Text = ""
        '
        'PctSalir
        '
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaDePresentacion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(594, 12)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(53, 50)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 35
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(238, 12)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(181, 31)
        Me.LblDescripcion.TabIndex = 36
        Me.LblDescripcion.Text = "Conversación"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Location = New System.Drawing.Point(349, 386)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(77, 45)
        Me.BtnEnviar.TabIndex = 2
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'PctEnviar
        '
        Me.PctEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEnviar.Enabled = False
        Me.PctEnviar.Image = Global.CapaDePresentacion.My.Resources.Resources.EnviarBloqueadoFondoClaro
        Me.PctEnviar.Location = New System.Drawing.Point(510, 381)
        Me.PctEnviar.Name = "PctEnviar"
        Me.PctEnviar.Size = New System.Drawing.Size(63, 50)
        Me.PctEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEnviar.TabIndex = 37
        Me.PctEnviar.TabStop = False
        '
        'Frm_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BackgroundImage = Global.CapaDePresentacion.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(659, 465)
        Me.Controls.Add(Me.PctEnviar)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.WbbConversacion)
        Me.Controls.Add(Me.BtnEnviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat"
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TmrMensajesNuevos As Timer
    Friend WithEvents WbbConversacion As WebBrowser
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents PctEnviar As PictureBox
End Class
