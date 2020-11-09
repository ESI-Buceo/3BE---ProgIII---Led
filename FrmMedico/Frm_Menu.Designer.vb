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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.DgvEnEspera = New System.Windows.Forms.DataGridView()
        Me.TmrBuscarMensajesNuevos = New System.Windows.Forms.Timer(Me.components)
        Me.LblNombrePaciente = New System.Windows.Forms.Label()
        Me.LblSexoPaciente = New System.Windows.Forms.Label()
        Me.LblEdadPaciente = New System.Windows.Forms.Label()
        Me.LstEnfermedades = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.TmrBuscarChats = New System.Windows.Forms.Timer(Me.components)
        Me.WbbConversacion = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlIniciarChat = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.PctSalirLeft = New System.Windows.Forms.PictureBox()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.PctHistorial = New System.Windows.Forms.PictureBox()
        Me.LblHistorial = New System.Windows.Forms.Label()
        Me.LblRecomendaciones = New System.Windows.Forms.Label()
        Me.PctRecomendaciones = New System.Windows.Forms.PictureBox()
        Me.PnlConversacion = New System.Windows.Forms.Panel()
        Me.PnlCerrarConversacion = New System.Windows.Forms.Panel()
        Me.PctFinalizarChat = New System.Windows.Forms.PictureBox()
        Me.LblDescripcionVentana = New System.Windows.Forms.Label()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DgvEnEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlIniciarChat.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalirLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        CType(Me.PctHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctRecomendaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlConversacion.SuspendLayout()
        Me.PnlCerrarConversacion.SuspendLayout()
        CType(Me.PctFinalizarChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Enabled = False
        Me.RtbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbMensaje.Location = New System.Drawing.Point(300, 391)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(341, 47)
        Me.RtbMensaje.TabIndex = 3
        Me.RtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.ForeColor = System.Drawing.Color.White
        Me.BtnEnviar.Location = New System.Drawing.Point(673, 391)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(88, 47)
        Me.BtnEnviar.TabIndex = 4
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'DgvEnEspera
        '
        Me.DgvEnEspera.AllowUserToAddRows = False
        Me.DgvEnEspera.AllowUserToDeleteRows = False
        Me.DgvEnEspera.AllowUserToOrderColumns = True
        Me.DgvEnEspera.AllowUserToResizeColumns = False
        Me.DgvEnEspera.AllowUserToResizeRows = False
        Me.DgvEnEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEnEspera.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvEnEspera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEnEspera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvEnEspera.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DgvEnEspera.Location = New System.Drawing.Point(830, 114)
        Me.DgvEnEspera.MultiSelect = False
        Me.DgvEnEspera.Name = "DgvEnEspera"
        Me.DgvEnEspera.ReadOnly = True
        Me.DgvEnEspera.RowHeadersVisible = False
        Me.DgvEnEspera.RowTemplate.Height = 24
        Me.DgvEnEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEnEspera.Size = New System.Drawing.Size(241, 457)
        Me.DgvEnEspera.TabIndex = 9
        '
        'TmrBuscarMensajesNuevos
        '
        '
        'LblNombrePaciente
        '
        Me.LblNombrePaciente.AutoSize = True
        Me.LblNombrePaciente.Font = New System.Drawing.Font("Libre Franklin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombrePaciente.ForeColor = System.Drawing.Color.White
        Me.LblNombrePaciente.Location = New System.Drawing.Point(27, 13)
        Me.LblNombrePaciente.Name = "LblNombrePaciente"
        Me.LblNombrePaciente.Size = New System.Drawing.Size(0, 23)
        Me.LblNombrePaciente.TabIndex = 10
        Me.LblNombrePaciente.Visible = False
        '
        'LblSexoPaciente
        '
        Me.LblSexoPaciente.AutoSize = True
        Me.LblSexoPaciente.Font = New System.Drawing.Font("Libre Franklin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSexoPaciente.ForeColor = System.Drawing.Color.White
        Me.LblSexoPaciente.Location = New System.Drawing.Point(27, 39)
        Me.LblSexoPaciente.Name = "LblSexoPaciente"
        Me.LblSexoPaciente.Size = New System.Drawing.Size(0, 23)
        Me.LblSexoPaciente.TabIndex = 11
        Me.LblSexoPaciente.Visible = False
        '
        'LblEdadPaciente
        '
        Me.LblEdadPaciente.AutoSize = True
        Me.LblEdadPaciente.Font = New System.Drawing.Font("Libre Franklin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdadPaciente.ForeColor = System.Drawing.Color.White
        Me.LblEdadPaciente.Location = New System.Drawing.Point(27, 64)
        Me.LblEdadPaciente.Name = "LblEdadPaciente"
        Me.LblEdadPaciente.Size = New System.Drawing.Size(0, 23)
        Me.LblEdadPaciente.TabIndex = 12
        Me.LblEdadPaciente.Visible = False
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.AllowColumnReorder = True
        Me.LstEnfermedades.AllowDrop = True
        Me.LstEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEnfermedades.ForeColor = System.Drawing.Color.Black
        Me.LstEnfermedades.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(28, 347)
        Me.LstEnfermedades.MultiSelect = False
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(210, 91)
        Me.LstEnfermedades.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstEnfermedades.TabIndex = 13
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedades.View = System.Windows.Forms.View.List
        Me.LstEnfermedades.Visible = False
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.AllowColumnReorder = True
        Me.LstMedicaciones.AllowDrop = True
        Me.LstMedicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstMedicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMedicaciones.ForeColor = System.Drawing.Color.Black
        Me.LstMedicaciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(28, 235)
        Me.LstMedicaciones.MultiSelect = False
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(210, 91)
        Me.LstMedicaciones.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstMedicaciones.TabIndex = 14
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        Me.LstMedicaciones.Visible = False
        '
        'TmrBuscarChats
        '
        Me.TmrBuscarChats.Interval = 10000
        '
        'WbbConversacion
        '
        Me.WbbConversacion.Location = New System.Drawing.Point(300, 14)
        Me.WbbConversacion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbbConversacion.Name = "WbbConversacion"
        Me.WbbConversacion.Size = New System.Drawing.Size(461, 348)
        Me.WbbConversacion.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(864, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Seleccione una consulta"
        '
        'PnlIniciarChat
        '
        Me.PnlIniciarChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PnlIniciarChat.Controls.Add(Me.BtnIniciarChat)
        Me.PnlIniciarChat.Controls.Add(Me.PictureBox1)
        Me.PnlIniciarChat.Location = New System.Drawing.Point(772, 128)
        Me.PnlIniciarChat.Name = "PnlIniciarChat"
        Me.PnlIniciarChat.Size = New System.Drawing.Size(170, 54)
        Me.PnlIniciarChat.TabIndex = 19
        Me.PnlIniciarChat.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.FrmMedico.My.Resources.Resources.DesplegarChat
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BtnIniciarChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIniciarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciarChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarChat.ForeColor = System.Drawing.Color.White
        Me.BtnIniciarChat.Location = New System.Drawing.Point(58, 4)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(109, 47)
        Me.BtnIniciarChat.TabIndex = 1
        Me.BtnIniciarChat.Text = "Iniciar Chat"
        Me.BtnIniciarChat.UseVisualStyleBackColor = False
        '
        'PctSalirLeft
        '
        Me.PctSalirLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalirLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalirLeft.Image = CType(resources.GetObject("PctSalirLeft.Image"), System.Drawing.Image)
        Me.PctSalirLeft.Location = New System.Drawing.Point(1028, 6)
        Me.PctSalirLeft.Name = "PctSalirLeft"
        Me.PctSalirLeft.Size = New System.Drawing.Size(52, 52)
        Me.PctSalirLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalirLeft.TabIndex = 20
        Me.PctSalirLeft.TabStop = False
        '
        'PctMenu
        '
        Me.PctMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctMenu.Image = Global.FrmMedico.My.Resources.Resources.MenuHamb1
        Me.PctMenu.Location = New System.Drawing.Point(107, 6)
        Me.PctMenu.Name = "PctMenu"
        Me.PctMenu.Size = New System.Drawing.Size(59, 58)
        Me.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctMenu.TabIndex = 30
        Me.PctMenu.TabStop = False
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.PctHistorial)
        Me.PnlMenu.Controls.Add(Me.LblHistorial)
        Me.PnlMenu.Controls.Add(Me.LblRecomendaciones)
        Me.PnlMenu.Controls.Add(Me.PctRecomendaciones)
        Me.PnlMenu.Location = New System.Drawing.Point(52, 70)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(180, 10)
        Me.PnlMenu.TabIndex = 29
        '
        'PctHistorial
        '
        Me.PctHistorial.Image = Global.FrmMedico.My.Resources.Resources.Historial
        Me.PctHistorial.Location = New System.Drawing.Point(38, 220)
        Me.PctHistorial.Name = "PctHistorial"
        Me.PctHistorial.Size = New System.Drawing.Size(100, 99)
        Me.PctHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctHistorial.TabIndex = 4
        Me.PctHistorial.TabStop = False
        Me.PctHistorial.Visible = False
        '
        'LblHistorial
        '
        Me.LblHistorial.AutoSize = True
        Me.LblHistorial.BackColor = System.Drawing.Color.Transparent
        Me.LblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHistorial.ForeColor = System.Drawing.Color.White
        Me.LblHistorial.Location = New System.Drawing.Point(53, 322)
        Me.LblHistorial.Name = "LblHistorial"
        Me.LblHistorial.Size = New System.Drawing.Size(66, 16)
        Me.LblHistorial.TabIndex = 3
        Me.LblHistorial.Text = "Historial"
        Me.LblHistorial.Visible = False
        '
        'LblRecomendaciones
        '
        Me.LblRecomendaciones.AutoSize = True
        Me.LblRecomendaciones.BackColor = System.Drawing.Color.Transparent
        Me.LblRecomendaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecomendaciones.ForeColor = System.Drawing.Color.White
        Me.LblRecomendaciones.Location = New System.Drawing.Point(26, 147)
        Me.LblRecomendaciones.Name = "LblRecomendaciones"
        Me.LblRecomendaciones.Size = New System.Drawing.Size(138, 16)
        Me.LblRecomendaciones.TabIndex = 2
        Me.LblRecomendaciones.Text = "Recomendaciones"
        Me.LblRecomendaciones.Visible = False
        '
        'PctRecomendaciones
        '
        Me.PctRecomendaciones.BackColor = System.Drawing.Color.Transparent
        Me.PctRecomendaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctRecomendaciones.Image = Global.FrmMedico.My.Resources.Resources.RecomendacionWomen1
        Me.PctRecomendaciones.Location = New System.Drawing.Point(38, 44)
        Me.PctRecomendaciones.Name = "PctRecomendaciones"
        Me.PctRecomendaciones.Size = New System.Drawing.Size(100, 100)
        Me.PctRecomendaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctRecomendaciones.TabIndex = 0
        Me.PctRecomendaciones.TabStop = False
        Me.PctRecomendaciones.Visible = False
        '
        'PnlConversacion
        '
        Me.PnlConversacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PnlConversacion.Controls.Add(Me.Label4)
        Me.PnlConversacion.Controls.Add(Me.Label3)
        Me.PnlConversacion.Controls.Add(Me.Label2)
        Me.PnlConversacion.Controls.Add(Me.LstSintomas)
        Me.PnlConversacion.Controls.Add(Me.WbbConversacion)
        Me.PnlConversacion.Controls.Add(Me.RtbMensaje)
        Me.PnlConversacion.Controls.Add(Me.BtnEnviar)
        Me.PnlConversacion.Controls.Add(Me.LstEnfermedades)
        Me.PnlConversacion.Controls.Add(Me.LblNombrePaciente)
        Me.PnlConversacion.Controls.Add(Me.LblSexoPaciente)
        Me.PnlConversacion.Controls.Add(Me.LstMedicaciones)
        Me.PnlConversacion.Controls.Add(Me.LblEdadPaciente)
        Me.PnlConversacion.Location = New System.Drawing.Point(62, 114)
        Me.PnlConversacion.Name = "PnlConversacion"
        Me.PnlConversacion.Size = New System.Drawing.Size(10, 457)
        Me.PnlConversacion.TabIndex = 31
        '
        'PnlCerrarConversacion
        '
        Me.PnlCerrarConversacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PnlCerrarConversacion.Controls.Add(Me.PctFinalizarChat)
        Me.PnlCerrarConversacion.Location = New System.Drawing.Point(12, 128)
        Me.PnlCerrarConversacion.Name = "PnlCerrarConversacion"
        Me.PnlCerrarConversacion.Size = New System.Drawing.Size(50, 50)
        Me.PnlCerrarConversacion.TabIndex = 32
        Me.PnlCerrarConversacion.Visible = False
        '
        'PctFinalizarChat
        '
        Me.PctFinalizarChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctFinalizarChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctFinalizarChat.Image = Global.FrmMedico.My.Resources.Resources.FinalizarChat
        Me.PctFinalizarChat.Location = New System.Drawing.Point(0, 0)
        Me.PctFinalizarChat.Name = "PctFinalizarChat"
        Me.PctFinalizarChat.Size = New System.Drawing.Size(52, 50)
        Me.PctFinalizarChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctFinalizarChat.TabIndex = 0
        Me.PctFinalizarChat.TabStop = False
        '
        'LblDescripcionVentana
        '
        Me.LblDescripcionVentana.AutoSize = True
        Me.LblDescripcionVentana.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcionVentana.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcionVentana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcionVentana.Location = New System.Drawing.Point(523, 9)
        Me.LblDescripcionVentana.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcionVentana.Name = "LblDescripcionVentana"
        Me.LblDescripcionVentana.Size = New System.Drawing.Size(0, 31)
        Me.LblDescripcionVentana.TabIndex = 33
        Me.LblDescripcionVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstSintomas
        '
        Me.LstSintomas.AllowColumnReorder = True
        Me.LstSintomas.AllowDrop = True
        Me.LstSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSintomas.ForeColor = System.Drawing.Color.Black
        Me.LstSintomas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(28, 122)
        Me.LstSintomas.MultiSelect = False
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(210, 91)
        Me.LstSintomas.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstSintomas.TabIndex = 16
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        Me.LstSintomas.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Libre Franklin", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sintomas ingresados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Libre Franklin", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Enfermedades cronicas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Libre Franklin", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Medicaciones"
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.FrmMedico.My.Resources.Resources.MenuHistoria
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1102, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgvEnEspera)
        Me.Controls.Add(Me.LblDescripcionVentana)
        Me.Controls.Add(Me.PctMenu)
        Me.Controls.Add(Me.PnlCerrarConversacion)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.PctSalirLeft)
        Me.Controls.Add(Me.PnlIniciarChat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlConversacion)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Menu"
        Me.Text = "Menu principal"
        CType(Me.DgvEnEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlIniciarChat.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalirLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        CType(Me.PctHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctRecomendaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlConversacion.ResumeLayout(False)
        Me.PnlConversacion.PerformLayout()
        Me.PnlCerrarConversacion.ResumeLayout(False)
        CType(Me.PctFinalizarChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents DgvEnEspera As DataGridView
    Friend WithEvents TmrBuscarMensajesNuevos As Timer
    Friend WithEvents LblNombrePaciente As Label
    Friend WithEvents LblSexoPaciente As Label
    Friend WithEvents LblEdadPaciente As Label
    Friend WithEvents LstEnfermedades As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents TmrBuscarChats As Timer
    Friend WithEvents WbbConversacion As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlIniciarChat As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnIniciarChat As Button
    Friend WithEvents PctSalirLeft As PictureBox
    Friend WithEvents PctMenu As PictureBox
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents LblHistorial As Label
    Friend WithEvents LblRecomendaciones As Label
    Friend WithEvents PctRecomendaciones As PictureBox
    Friend WithEvents PctHistorial As PictureBox
    Friend WithEvents PnlConversacion As Panel
    Friend WithEvents PnlCerrarConversacion As Panel
    Friend WithEvents PctFinalizarChat As PictureBox
    Friend WithEvents LblDescripcionVentana As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LstSintomas As ListView
End Class
