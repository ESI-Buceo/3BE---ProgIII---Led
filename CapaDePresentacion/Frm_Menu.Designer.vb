<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.Sintomas = New System.Windows.Forms.Label()
        Me.BtnDiagnostico = New System.Windows.Forms.Button()
        Me.LvSintomas = New System.Windows.Forms.ListView()
        Me.LblAdvertencia = New System.Windows.Forms.Label()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.LblHistorial = New System.Windows.Forms.Label()
        Me.LblMisDatos = New System.Windows.Forms.Label()
        Me.PctConsultas = New System.Windows.Forms.PictureBox()
        Me.PctDatosPropios = New System.Windows.Forms.PictureBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.PnlMenu.SuspendLayout()
        CType(Me.PctConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctDatosPropios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.BackColor = System.Drawing.Color.Transparent
        Me.LblSaludo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaludo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.LblSaludo.Location = New System.Drawing.Point(408, 26)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(0, 29)
        Me.LblSaludo.TabIndex = 2
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.BackColor = System.Drawing.Color.Transparent
        Me.LblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.LblSintomas.Location = New System.Drawing.Point(404, 136)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(277, 29)
        Me.LblSintomas.TabIndex = 4
        Me.LblSintomas.Text = "Cuentenos, ¿que siente?"
        '
        'CmbSintomas
        '
        Me.CmbSintomas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbSintomas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSintomas.BackColor = System.Drawing.Color.White
        Me.CmbSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(371, 195)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(343, 21)
        Me.CmbSintomas.TabIndex = 15
        '
        'Sintomas
        '
        Me.Sintomas.AutoSize = True
        Me.Sintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Sintomas.ForeColor = System.Drawing.Color.White
        Me.Sintomas.Location = New System.Drawing.Point(202, 327)
        Me.Sintomas.Name = "Sintomas"
        Me.Sintomas.Size = New System.Drawing.Size(0, 22)
        Me.Sintomas.TabIndex = 16
        '
        'BtnDiagnostico
        '
        Me.BtnDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BtnDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDiagnostico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDiagnostico.Enabled = False
        Me.BtnDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiagnostico.ForeColor = System.Drawing.Color.White
        Me.BtnDiagnostico.Location = New System.Drawing.Point(663, 437)
        Me.BtnDiagnostico.Name = "BtnDiagnostico"
        Me.BtnDiagnostico.Size = New System.Drawing.Size(177, 56)
        Me.BtnDiagnostico.TabIndex = 18
        Me.BtnDiagnostico.Text = "Realizar Diagnostico"
        Me.BtnDiagnostico.UseVisualStyleBackColor = False
        '
        'LvSintomas
        '
        Me.LvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LvSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvSintomas.HideSelection = False
        Me.LvSintomas.Location = New System.Drawing.Point(245, 238)
        Me.LvSintomas.Name = "LvSintomas"
        Me.LvSintomas.Size = New System.Drawing.Size(595, 166)
        Me.LvSintomas.TabIndex = 20
        Me.LvSintomas.UseCompatibleStateImageBehavior = False
        Me.LvSintomas.View = System.Windows.Forms.View.Tile
        '
        'LblAdvertencia
        '
        Me.LblAdvertencia.AutoSize = True
        Me.LblAdvertencia.BackColor = System.Drawing.Color.Transparent
        Me.LblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdvertencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.LblAdvertencia.Location = New System.Drawing.Point(242, 439)
        Me.LblAdvertencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAdvertencia.Name = "LblAdvertencia"
        Me.LblAdvertencia.Size = New System.Drawing.Size(0, 18)
        Me.LblAdvertencia.TabIndex = 24
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.LblHistorial)
        Me.PnlMenu.Controls.Add(Me.LblMisDatos)
        Me.PnlMenu.Controls.Add(Me.PctConsultas)
        Me.PnlMenu.Controls.Add(Me.PctDatosPropios)
        Me.PnlMenu.Location = New System.Drawing.Point(22, 85)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(180, 372)
        Me.PnlMenu.TabIndex = 25
        '
        'LblHistorial
        '
        Me.LblHistorial.AutoSize = True
        Me.LblHistorial.BackColor = System.Drawing.Color.Transparent
        Me.LblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHistorial.ForeColor = System.Drawing.Color.White
        Me.LblHistorial.Location = New System.Drawing.Point(61, 322)
        Me.LblHistorial.Name = "LblHistorial"
        Me.LblHistorial.Size = New System.Drawing.Size(66, 16)
        Me.LblHistorial.TabIndex = 3
        Me.LblHistorial.Text = "Historial"
        Me.LblHistorial.Visible = False
        '
        'LblMisDatos
        '
        Me.LblMisDatos.AutoSize = True
        Me.LblMisDatos.BackColor = System.Drawing.Color.Transparent
        Me.LblMisDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMisDatos.ForeColor = System.Drawing.Color.White
        Me.LblMisDatos.Location = New System.Drawing.Point(52, 153)
        Me.LblMisDatos.Name = "LblMisDatos"
        Me.LblMisDatos.Size = New System.Drawing.Size(77, 16)
        Me.LblMisDatos.TabIndex = 2
        Me.LblMisDatos.Text = "Mis Datos"
        Me.LblMisDatos.Visible = False
        '
        'PctConsultas
        '
        Me.PctConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctConsultas.Image = Global.CapaDePresentacion.My.Resources.Resources.Historial
        Me.PctConsultas.Location = New System.Drawing.Point(38, 219)
        Me.PctConsultas.Name = "PctConsultas"
        Me.PctConsultas.Size = New System.Drawing.Size(100, 100)
        Me.PctConsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctConsultas.TabIndex = 1
        Me.PctConsultas.TabStop = False
        Me.PctConsultas.Visible = False
        '
        'PctDatosPropios
        '
        Me.PctDatosPropios.BackColor = System.Drawing.Color.Transparent
        Me.PctDatosPropios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctDatosPropios.Image = Global.CapaDePresentacion.My.Resources.Resources.Men1
        Me.PctDatosPropios.Location = New System.Drawing.Point(38, 50)
        Me.PctDatosPropios.Name = "PctDatosPropios"
        Me.PctDatosPropios.Size = New System.Drawing.Size(100, 100)
        Me.PctDatosPropios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctDatosPropios.TabIndex = 0
        Me.PctDatosPropios.TabStop = False
        Me.PctDatosPropios.Visible = False
        '
        'PctSalir
        '
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaDePresentacion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(939, 12)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(59, 58)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 27
        Me.PctSalir.TabStop = False
        '
        'PctMenu
        '
        Me.PctMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctMenu.Image = Global.CapaDePresentacion.My.Resources.Resources.MenuHamb1
        Me.PctMenu.Location = New System.Drawing.Point(86, 12)
        Me.PctMenu.Name = "PctMenu"
        Me.PctMenu.Size = New System.Drawing.Size(59, 58)
        Me.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctMenu.TabIndex = 28
        Me.PctMenu.TabStop = False
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1010, 528)
        Me.Controls.Add(Me.PctMenu)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.LblAdvertencia)
        Me.Controls.Add(Me.LvSintomas)
        Me.Controls.Add(Me.BtnDiagnostico)
        Me.Controls.Add(Me.Sintomas)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        CType(Me.PctConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctDatosPropios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSaludo As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents Sintomas As Label
    Friend WithEvents BtnDiagnostico As Button
    Friend WithEvents LvSintomas As ListView
    Friend WithEvents LblAdvertencia As Label
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents PctMenu As PictureBox
    Friend WithEvents PctConsultas As PictureBox
    Friend WithEvents PctDatosPropios As PictureBox
    Friend WithEvents LblMisDatos As Label
    Friend WithEvents LblHistorial As Label
End Class
