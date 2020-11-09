<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarUsuario))
        Me.TxtCI = New System.Windows.Forms.TextBox()
        Me.LblCI = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.CmbCi = New System.Windows.Forms.ComboBox()
        Me.BtnEliminarEnfermedad = New System.Windows.Forms.Button()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.PctRefrescar = New System.Windows.Forms.PictureBox()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctAgregarMedicacion = New System.Windows.Forms.PictureBox()
        Me.PctAgregarEnfermedad = New System.Windows.Forms.PictureBox()
        Me.PctEliminarMedicacion = New System.Windows.Forms.PictureBox()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.PctEliminarEnfermedad = New System.Windows.Forms.PictureBox()
        Me.LblEnfermedadCronica = New System.Windows.Forms.Label()
        Me.LblMedicacion = New System.Windows.Forms.Label()
        Me.LstEnfermedades = New System.Windows.Forms.ListView()
        Me.TxtEnfermedadCronica = New System.Windows.Forms.TextBox()
        Me.TxtMedicacion = New System.Windows.Forms.TextBox()
        Me.LblTipoDeUsuario = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.RdbH = New System.Windows.Forms.RadioButton()
        Me.RdbM = New System.Windows.Forms.RadioButton()
        Me.ChbAdministrador = New System.Windows.Forms.CheckBox()
        Me.ChbMedico = New System.Windows.Forms.CheckBox()
        Me.ChbPaciente = New System.Windows.Forms.CheckBox()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.PnlBarra.SuspendLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAgregarMedicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAgregarEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarMedicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCI
        '
        Me.TxtCI.AccessibleDescription = "Ingrese su cedula sin puntos ni guiones"
        Me.TxtCI.Location = New System.Drawing.Point(64, -32)
        Me.TxtCI.MaxLength = 9
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(205, 26)
        Me.TxtCI.TabIndex = 26
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(112, -72)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(25, 20)
        Me.LblCI.TabIndex = 29
        Me.LblCI.Text = "CI"
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Cornsilk
        Me.LblCedula.Location = New System.Drawing.Point(80, 9)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(169, 20)
        Me.LblCedula.TabIndex = 49
        Me.LblCedula.Text = "Seleccione una cedula"
        '
        'CmbCi
        '
        Me.CmbCi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCi.Font = New System.Drawing.Font("Agency FB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCi.FormattingEnabled = True
        Me.CmbCi.Location = New System.Drawing.Point(130, 117)
        Me.CmbCi.Name = "CmbCi"
        Me.CmbCi.Size = New System.Drawing.Size(496, 34)
        Me.CmbCi.TabIndex = 50
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Enabled = False
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(559, 512)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(84, 29)
        Me.BtnEliminarEnfermedad.TabIndex = 55
        Me.BtnEliminarEnfermedad.Text = "Eliminar"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnEliminarEnfermedad.Visible = False
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlBarra.Controls.Add(Me.Label1)
        Me.PnlBarra.Controls.Add(Me.PctSalir)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(1265, 76)
        Me.PnlBarra.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(337, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 47)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Modificar Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(1185, 0)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(80, 76)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 26
        Me.PctSalir.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Cédula"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(130, 317)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCorreo.MaxLength = 25
        Me.TxtCorreo.Multiline = True
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(496, 63)
        Me.TxtCorreo.TabIndex = 64
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCorreo.WordWrap = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(23, 191)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(81, 25)
        Me.LblNombre.TabIndex = 60
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.Color.Black
        Me.LblApellido.Location = New System.Drawing.Point(23, 262)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(82, 25)
        Me.LblApellido.TabIndex = 62
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.Black
        Me.LblMail.Location = New System.Drawing.Point(24, 333)
        Me.LblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(72, 25)
        Me.LblMail.TabIndex = 63
        Me.LblMail.Text = "Correo"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(130, 172)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(496, 62)
        Me.TxtNombre.TabIndex = 59
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNombre.WordWrap = False
        '
        'TxtApellido
        '
        Me.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(130, 244)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Multiline = True
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(496, 63)
        Me.TxtApellido.TabIndex = 61
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtApellido.WordWrap = False
        '
        'PctRefrescar
        '
        Me.PctRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctRefrescar.Enabled = False
        Me.PctRefrescar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Refrescar
        Me.PctRefrescar.Location = New System.Drawing.Point(977, 596)
        Me.PctRefrescar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctRefrescar.Name = "PctRefrescar"
        Me.PctRefrescar.Size = New System.Drawing.Size(140, 134)
        Me.PctRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctRefrescar.TabIndex = 68
        Me.PctRefrescar.TabStop = False
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(819, 596)
        Me.PctAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(140, 134)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 67
        Me.PctAceptar.TabStop = False
        '
        'PctAgregarMedicacion
        '
        Me.PctAgregarMedicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarMedicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarMedicacion.Enabled = False
        Me.PctAgregarMedicacion.Image = Global.CapaPresentacionGestion.My.Resources.Resources.AddCircularVerde
        Me.PctAgregarMedicacion.Location = New System.Drawing.Point(692, 446)
        Me.PctAgregarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAgregarMedicacion.Name = "PctAgregarMedicacion"
        Me.PctAgregarMedicacion.Size = New System.Drawing.Size(46, 46)
        Me.PctAgregarMedicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarMedicacion.TabIndex = 78
        Me.PctAgregarMedicacion.TabStop = False
        Me.PctAgregarMedicacion.Visible = False
        '
        'PctAgregarEnfermedad
        '
        Me.PctAgregarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarEnfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarEnfermedad.Enabled = False
        Me.PctAgregarEnfermedad.Image = Global.CapaPresentacionGestion.My.Resources.Resources.AddCircularVerde
        Me.PctAgregarEnfermedad.Location = New System.Drawing.Point(314, 446)
        Me.PctAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAgregarEnfermedad.Name = "PctAgregarEnfermedad"
        Me.PctAgregarEnfermedad.Size = New System.Drawing.Size(46, 46)
        Me.PctAgregarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarEnfermedad.TabIndex = 77
        Me.PctAgregarEnfermedad.TabStop = False
        Me.PctAgregarEnfermedad.Tag = "7"
        Me.PctAgregarEnfermedad.Visible = False
        '
        'PctEliminarMedicacion
        '
        Me.PctEliminarMedicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEliminarMedicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEliminarMedicacion.Enabled = False
        Me.PctEliminarMedicacion.Image = Global.CapaPresentacionGestion.My.Resources.Resources.DelCircularRojo
        Me.PctEliminarMedicacion.Location = New System.Drawing.Point(692, 502)
        Me.PctEliminarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctEliminarMedicacion.Name = "PctEliminarMedicacion"
        Me.PctEliminarMedicacion.Size = New System.Drawing.Size(46, 46)
        Me.PctEliminarMedicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarMedicacion.TabIndex = 76
        Me.PctEliminarMedicacion.TabStop = False
        Me.PctEliminarMedicacion.Visible = False
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(407, 500)
        Me.LstMedicaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstMedicaciones.MultiSelect = False
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(274, 230)
        Me.LstMedicaciones.TabIndex = 74
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        Me.LstMedicaciones.Visible = False
        '
        'PctEliminarEnfermedad
        '
        Me.PctEliminarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEliminarEnfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEliminarEnfermedad.Enabled = False
        Me.PctEliminarEnfermedad.Image = Global.CapaPresentacionGestion.My.Resources.Resources.DelCircularRojo
        Me.PctEliminarEnfermedad.Location = New System.Drawing.Point(314, 500)
        Me.PctEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctEliminarEnfermedad.Name = "PctEliminarEnfermedad"
        Me.PctEliminarEnfermedad.Size = New System.Drawing.Size(46, 46)
        Me.PctEliminarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarEnfermedad.TabIndex = 75
        Me.PctEliminarEnfermedad.TabStop = False
        Me.PctEliminarEnfermedad.Visible = False
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.BackColor = System.Drawing.Color.Transparent
        Me.LblEnfermedadCronica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedadCronica.ForeColor = System.Drawing.Color.Black
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(26, 408)
        Me.LblEnfermedadCronica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(222, 25)
        Me.LblEnfermedadCronica.TabIndex = 70
        Me.LblEnfermedadCronica.Text = "Enfermedades Cronicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.BackColor = System.Drawing.Color.Transparent
        Me.LblMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicacion.ForeColor = System.Drawing.Color.Black
        Me.LblMedicacion.Location = New System.Drawing.Point(402, 408)
        Me.LblMedicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(133, 25)
        Me.LblMedicacion.TabIndex = 71
        Me.LblMedicacion.Text = "Medicaciones"
        Me.LblMedicacion.Visible = False
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEnfermedades.FullRowSelect = True
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(29, 500)
        Me.LstEnfermedades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstEnfermedades.MultiSelect = False
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(274, 230)
        Me.LstEnfermedades.TabIndex = 72
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedades.View = System.Windows.Forms.View.List
        Me.LstEnfermedades.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(29, 437)
        Me.TxtEnfermedadCronica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Multiline = True
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(274, 58)
        Me.TxtEnfermedadCronica.TabIndex = 69
        Me.TxtEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedicacion.Location = New System.Drawing.Point(407, 437)
        Me.TxtMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Multiline = True
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(274, 58)
        Me.TxtMedicacion.TabIndex = 73
        Me.TxtMedicacion.Visible = False
        '
        'LblTipoDeUsuario
        '
        Me.LblTipoDeUsuario.AutoSize = True
        Me.LblTipoDeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoDeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoDeUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblTipoDeUsuario.Location = New System.Drawing.Point(853, 120)
        Me.LblTipoDeUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoDeUsuario.Name = "LblTipoDeUsuario"
        Me.LblTipoDeUsuario.Size = New System.Drawing.Size(153, 25)
        Me.LblTipoDeUsuario.TabIndex = 85
        Me.LblTipoDeUsuario.Text = "Tipo De Usuario"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSexo.ForeColor = System.Drawing.Color.Black
        Me.LblSexo.Location = New System.Drawing.Point(777, 298)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(58, 25)
        Me.LblSexo.TabIndex = 84
        Me.LblSexo.Text = "Sexo"
        Me.LblSexo.Visible = False
        '
        'RdbH
        '
        Me.RdbH.AutoSize = True
        Me.RdbH.BackColor = System.Drawing.Color.Transparent
        Me.RdbH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbH.Location = New System.Drawing.Point(977, 328)
        Me.RdbH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdbH.Name = "RdbH"
        Me.RdbH.Size = New System.Drawing.Size(112, 29)
        Me.RdbH.TabIndex = 82
        Me.RdbH.Text = "Hombre"
        Me.RdbH.UseVisualStyleBackColor = False
        Me.RdbH.Visible = False
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.BackColor = System.Drawing.Color.Transparent
        Me.RdbM.Checked = True
        Me.RdbM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbM.Location = New System.Drawing.Point(845, 325)
        Me.RdbM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(91, 29)
        Me.RdbM.TabIndex = 83
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "Mujer"
        Me.RdbM.UseVisualStyleBackColor = False
        Me.RdbM.Visible = False
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbAdministrador.Location = New System.Drawing.Point(857, 237)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(160, 29)
        Me.ChbAdministrador.TabIndex = 81
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = False
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.BackColor = System.Drawing.Color.Transparent
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbMedico.Location = New System.Drawing.Point(857, 203)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(102, 29)
        Me.ChbMedico.TabIndex = 80
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = False
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.BackColor = System.Drawing.Color.Transparent
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbPaciente.Location = New System.Drawing.Point(857, 169)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(114, 29)
        Me.ChbPaciente.TabIndex = 79
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = False
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(814, 408)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(258, 26)
        Me.DtpFechaNacimiento.TabIndex = 86
        Me.DtpFechaNacimiento.Visible = False
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(760, 378)
        Me.LblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(199, 25)
        Me.LblFechaNacimiento.TabIndex = 87
        Me.LblFechaNacimiento.Text = "Fecha De Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'FrmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1265, 753)
        Me.Controls.Add(Me.LblFechaNacimiento)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.LblTipoDeUsuario)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.RdbH)
        Me.Controls.Add(Me.RdbM)
        Me.Controls.Add(Me.ChbAdministrador)
        Me.Controls.Add(Me.ChbMedico)
        Me.Controls.Add(Me.ChbPaciente)
        Me.Controls.Add(Me.PctAgregarMedicacion)
        Me.Controls.Add(Me.PctAgregarEnfermedad)
        Me.Controls.Add(Me.PctEliminarMedicacion)
        Me.Controls.Add(Me.LstMedicaciones)
        Me.Controls.Add(Me.PctEliminarEnfermedad)
        Me.Controls.Add(Me.LblEnfermedadCronica)
        Me.Controls.Add(Me.LblMedicacion)
        Me.Controls.Add(Me.LstEnfermedades)
        Me.Controls.Add(Me.TxtEnfermedadCronica)
        Me.Controls.Add(Me.TxtMedicacion)
        Me.Controls.Add(Me.PctRefrescar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.PnlBarra)
        Me.Controls.Add(Me.BtnEliminarEnfermedad)
        Me.Controls.Add(Me.CmbCi)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.TxtCI)
        Me.Controls.Add(Me.LblCI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModificarUsuario"
        Me.Text = "Modificar Usuario"
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAgregarMedicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAgregarEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarMedicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCI As TextBox
    Friend WithEvents LblCI As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents CmbCi As ComboBox
    Friend WithEvents BtnEliminarEnfermedad As Button
    Friend WithEvents PnlBarra As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents PctRefrescar As PictureBox
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctAgregarMedicacion As PictureBox
    Friend WithEvents PctAgregarEnfermedad As PictureBox
    Friend WithEvents PctEliminarMedicacion As PictureBox
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents PctEliminarEnfermedad As PictureBox
    Friend WithEvents LblEnfermedadCronica As Label
    Friend WithEvents LblMedicacion As Label
    Friend WithEvents LstEnfermedades As ListView
    Friend WithEvents TxtEnfermedadCronica As TextBox
    Friend WithEvents TxtMedicacion As TextBox
    Friend WithEvents LblTipoDeUsuario As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents RdbH As RadioButton
    Friend WithEvents RdbM As RadioButton
    Friend WithEvents ChbAdministrador As CheckBox
    Friend WithEvents ChbMedico As CheckBox
    Friend WithEvents ChbPaciente As CheckBox
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents LblFechaNacimiento As Label
End Class
