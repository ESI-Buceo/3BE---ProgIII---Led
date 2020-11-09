<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaEnfermedad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevaEnfermedad))
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.LstSintomasSeleccionados = New System.Windows.Forms.ListView()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblDisponible = New System.Windows.Forms.Label()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctCancelar = New System.Windows.Forms.PictureBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(66, 121)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(254, 38)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(66, 232)
        Me.TxtDescripcion.MaxLength = 500
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(254, 159)
        Me.TxtDescripcion.TabIndex = 1
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(66, 446)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(254, 37)
        Me.CmbPrioridad.TabIndex = 2
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(62, 90)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(81, 25)
        Me.LblNombre.TabIndex = 3
        Me.LblNombre.Text = "Nombre"
        '
        'CmbSintomas
        '
        Me.CmbSintomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSintomas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(448, 118)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(254, 37)
        Me.CmbSintomas.Sorted = True
        Me.CmbSintomas.TabIndex = 4
        '
        'LstSintomasSeleccionados
        '
        Me.LstSintomasSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSintomasSeleccionados.HideSelection = False
        Me.LstSintomasSeleccionados.Location = New System.Drawing.Point(448, 187)
        Me.LstSintomasSeleccionados.Name = "LstSintomasSeleccionados"
        Me.LstSintomasSeleccionados.Size = New System.Drawing.Size(254, 292)
        Me.LstSintomasSeleccionados.TabIndex = 5
        Me.LstSintomasSeleccionados.UseCompatibleStateImageBehavior = False
        Me.LstSintomasSeleccionados.View = System.Windows.Forms.View.Tile
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(56, 203)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(114, 25)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.LblPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridad.Location = New System.Drawing.Point(62, 418)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(89, 25)
        Me.LblPrioridad.TabIndex = 7
        Me.LblPrioridad.Text = "Prioridad"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.BackColor = System.Drawing.Color.Transparent
        Me.LblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomas.Location = New System.Drawing.Point(444, 90)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(94, 25)
        Me.LblSintomas.TabIndex = 8
        Me.LblSintomas.Text = "Sintomas"
        '
        'LblDisponible
        '
        Me.LblDisponible.AutoSize = True
        Me.LblDisponible.BackColor = System.Drawing.Color.Transparent
        Me.LblDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisponible.Location = New System.Drawing.Point(62, 569)
        Me.LblDisponible.Name = "LblDisponible"
        Me.LblDisponible.Size = New System.Drawing.Size(0, 25)
        Me.LblDisponible.TabIndex = 12
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(308, 569)
        Me.PctAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(140, 134)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 15
        Me.PctAceptar.TabStop = False
        '
        'PctCancelar
        '
        Me.PctCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctCancelar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Cancelar1
        Me.PctCancelar.Location = New System.Drawing.Point(566, 569)
        Me.PctCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctCancelar.Name = "PctCancelar"
        Me.PctCancelar.Size = New System.Drawing.Size(140, 134)
        Me.PctCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctCancelar.TabIndex = 16
        Me.PctCancelar.TabStop = False
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(696, 0)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(78, 76)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 17
        Me.PctSalir.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(205, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 47)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nueva Enfermedad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlBarra.Controls.Add(Me.Label1)
        Me.PnlBarra.Controls.Add(Me.PictureBox1)
        Me.PnlBarra.Controls.Add(Me.PctSalir)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(774, 76)
        Me.PnlBarra.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PictureBox1.Location = New System.Drawing.Point(832, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FrmNuevaEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 743)
        Me.Controls.Add(Me.PctCancelar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblDisponible)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LstSintomasSeleccionados)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbPrioridad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.PnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNuevaEnfermedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Enfermedad"
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmbPrioridad As ComboBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents LstSintomasSeleccionados As ListView
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblDisponible As Label
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctCancelar As PictureBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlBarra As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
