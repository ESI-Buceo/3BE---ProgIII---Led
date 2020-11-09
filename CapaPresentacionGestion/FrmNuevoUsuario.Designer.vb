<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoUsuario))
        Me.ChbPaciente = New System.Windows.Forms.CheckBox()
        Me.ChbMedico = New System.Windows.Forms.CheckBox()
        Me.ChbAdministrador = New System.Windows.Forms.CheckBox()
        Me.PctAgregarMedicacion = New System.Windows.Forms.PictureBox()
        Me.PctAgregarEnfermedad = New System.Windows.Forms.PictureBox()
        Me.PctEliminarMedicacion = New System.Windows.Forms.PictureBox()
        Me.LstMedicacion = New System.Windows.Forms.ListView()
        Me.PctEliminarEnfermedad = New System.Windows.Forms.PictureBox()
        Me.LblEnfermedadCronica = New System.Windows.Forms.Label()
        Me.LblMedicacion = New System.Windows.Forms.Label()
        Me.LstEnfermedadCronica = New System.Windows.Forms.ListView()
        Me.TxtEnfermedadCronica = New System.Windows.Forms.TextBox()
        Me.TxtMedicacion = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.RdbH = New System.Windows.Forms.RadioButton()
        Me.RdbF = New System.Windows.Forms.RadioButton()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.LblTipoDeUsuario = New System.Windows.Forms.Label()
        Me.PctRefrescar = New System.Windows.Forms.PictureBox()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PctAgregarMedicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAgregarEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarMedicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.BackColor = System.Drawing.Color.Transparent
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbPaciente.Location = New System.Drawing.Point(946, 186)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(114, 29)
        Me.ChbPaciente.TabIndex = 4
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = False
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.BackColor = System.Drawing.Color.Transparent
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbMedico.Location = New System.Drawing.Point(946, 220)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(102, 29)
        Me.ChbMedico.TabIndex = 5
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = False
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbAdministrador.Location = New System.Drawing.Point(946, 254)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(160, 29)
        Me.ChbAdministrador.TabIndex = 6
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = False
        '
        'PctAgregarMedicacion
        '
        Me.PctAgregarMedicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarMedicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarMedicacion.Enabled = False
        Me.PctAgregarMedicacion.Image = Global.CapaPresentacionGestion.My.Resources.Resources.AddCircularVerde
        Me.PctAgregarMedicacion.Location = New System.Drawing.Point(702, 566)
        Me.PctAgregarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAgregarMedicacion.Name = "PctAgregarMedicacion"
        Me.PctAgregarMedicacion.Size = New System.Drawing.Size(46, 46)
        Me.PctAgregarMedicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarMedicacion.TabIndex = 38
        Me.PctAgregarMedicacion.TabStop = False
        Me.PctAgregarMedicacion.Visible = False
        '
        'PctAgregarEnfermedad
        '
        Me.PctAgregarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarEnfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarEnfermedad.Enabled = False
        Me.PctAgregarEnfermedad.Image = Global.CapaPresentacionGestion.My.Resources.Resources.AddCircularVerde
        Me.PctAgregarEnfermedad.Location = New System.Drawing.Point(324, 566)
        Me.PctAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAgregarEnfermedad.Name = "PctAgregarEnfermedad"
        Me.PctAgregarEnfermedad.Size = New System.Drawing.Size(46, 46)
        Me.PctAgregarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarEnfermedad.TabIndex = 37
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
        Me.PctEliminarMedicacion.Location = New System.Drawing.Point(702, 622)
        Me.PctEliminarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctEliminarMedicacion.Name = "PctEliminarMedicacion"
        Me.PctEliminarMedicacion.Size = New System.Drawing.Size(46, 46)
        Me.PctEliminarMedicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarMedicacion.TabIndex = 36
        Me.PctEliminarMedicacion.TabStop = False
        Me.PctEliminarMedicacion.Visible = False
        '
        'LstMedicacion
        '
        Me.LstMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMedicacion.HideSelection = False
        Me.LstMedicacion.Location = New System.Drawing.Point(417, 620)
        Me.LstMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstMedicacion.MultiSelect = False
        Me.LstMedicacion.Name = "LstMedicacion"
        Me.LstMedicacion.Size = New System.Drawing.Size(274, 298)
        Me.LstMedicacion.TabIndex = 13
        Me.LstMedicacion.UseCompatibleStateImageBehavior = False
        Me.LstMedicacion.View = System.Windows.Forms.View.List
        Me.LstMedicacion.Visible = False
        '
        'PctEliminarEnfermedad
        '
        Me.PctEliminarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEliminarEnfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEliminarEnfermedad.Enabled = False
        Me.PctEliminarEnfermedad.Image = Global.CapaPresentacionGestion.My.Resources.Resources.DelCircularRojo
        Me.PctEliminarEnfermedad.Location = New System.Drawing.Point(324, 620)
        Me.PctEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctEliminarEnfermedad.Name = "PctEliminarEnfermedad"
        Me.PctEliminarEnfermedad.Size = New System.Drawing.Size(46, 46)
        Me.PctEliminarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarEnfermedad.TabIndex = 35
        Me.PctEliminarEnfermedad.TabStop = False
        Me.PctEliminarEnfermedad.Visible = False
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.BackColor = System.Drawing.Color.Transparent
        Me.LblEnfermedadCronica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedadCronica.ForeColor = System.Drawing.Color.Black
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(36, 528)
        Me.LblEnfermedadCronica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(222, 25)
        Me.LblEnfermedadCronica.TabIndex = 7
        Me.LblEnfermedadCronica.Text = "Enfermedades Cronicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.BackColor = System.Drawing.Color.Transparent
        Me.LblMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicacion.ForeColor = System.Drawing.Color.Black
        Me.LblMedicacion.Location = New System.Drawing.Point(412, 528)
        Me.LblMedicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(133, 25)
        Me.LblMedicacion.TabIndex = 8
        Me.LblMedicacion.Text = "Medicaciones"
        Me.LblMedicacion.Visible = False
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEnfermedadCronica.FullRowSelect = True
        Me.LstEnfermedadCronica.HideSelection = False
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(39, 620)
        Me.LstEnfermedadCronica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstEnfermedadCronica.MultiSelect = False
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(274, 298)
        Me.LstEnfermedadCronica.TabIndex = 12
        Me.LstEnfermedadCronica.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedadCronica.View = System.Windows.Forms.View.List
        Me.LstEnfermedadCronica.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(39, 557)
        Me.TxtEnfermedadCronica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Multiline = True
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(274, 58)
        Me.TxtEnfermedadCronica.TabIndex = 10
        Me.TxtEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedicacion.Location = New System.Drawing.Point(417, 557)
        Me.TxtMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Multiline = True
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(274, 58)
        Me.TxtMedicacion.TabIndex = 11
        Me.TxtMedicacion.Visible = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(34, 226)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(81, 25)
        Me.LblNombre.TabIndex = 40
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.Color.Black
        Me.LblApellido.Location = New System.Drawing.Point(36, 312)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(82, 25)
        Me.LblApellido.TabIndex = 43
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.Black
        Me.LblMail.Location = New System.Drawing.Point(34, 400)
        Me.LblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(72, 25)
        Me.LblMail.TabIndex = 44
        Me.LblMail.Text = "Correo"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSexo.ForeColor = System.Drawing.Color.Black
        Me.LblSexo.Location = New System.Drawing.Point(866, 315)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(58, 25)
        Me.LblSexo.TabIndex = 47
        Me.LblSexo.Text = "Sexo"
        Me.LblSexo.Visible = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(142, 223)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(496, 62)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNombre.WordWrap = False
        '
        'TxtApellido
        '
        Me.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(142, 312)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Multiline = True
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(496, 63)
        Me.TxtApellido.TabIndex = 2
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtApellido.WordWrap = False
        '
        'RdbH
        '
        Me.RdbH.AutoSize = True
        Me.RdbH.BackColor = System.Drawing.Color.Transparent
        Me.RdbH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbH.Location = New System.Drawing.Point(1066, 345)
        Me.RdbH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdbH.Name = "RdbH"
        Me.RdbH.Size = New System.Drawing.Size(112, 29)
        Me.RdbH.TabIndex = 8
        Me.RdbH.Text = "Hombre"
        Me.RdbH.UseVisualStyleBackColor = False
        Me.RdbH.Visible = False
        '
        'RdbF
        '
        Me.RdbF.AutoSize = True
        Me.RdbF.BackColor = System.Drawing.Color.Transparent
        Me.RdbF.Checked = True
        Me.RdbF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbF.Location = New System.Drawing.Point(934, 342)
        Me.RdbF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdbF.Name = "RdbF"
        Me.RdbF.Size = New System.Drawing.Size(91, 29)
        Me.RdbF.TabIndex = 7
        Me.RdbF.TabStop = True
        Me.RdbF.Text = "Mujer"
        Me.RdbF.UseVisualStyleBackColor = False
        Me.RdbF.Visible = False
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(928, 429)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(258, 26)
        Me.DtpFechaNacimiento.TabIndex = 9
        Me.DtpFechaNacimiento.Visible = False
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(866, 400)
        Me.LblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(199, 25)
        Me.LblFechaNacimiento.TabIndex = 49
        Me.LblFechaNacimiento.Text = "Fecha De Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(142, 400)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCorreo.MaxLength = 50
        Me.TxtCorreo.Multiline = True
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(496, 63)
        Me.TxtCorreo.TabIndex = 3
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCorreo.WordWrap = False
        '
        'TxtCedula
        '
        Me.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(142, 128)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCedula.MaxLength = 25
        Me.TxtCedula.Multiline = True
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(496, 62)
        Me.TxtCedula.TabIndex = 0
        Me.TxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Transparent
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.ForeColor = System.Drawing.Color.Black
        Me.LblCedula.Location = New System.Drawing.Point(36, 132)
        Me.LblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(75, 25)
        Me.LblCedula.TabIndex = 52
        Me.LblCedula.Text = "Cédula"
        '
        'LblTipoDeUsuario
        '
        Me.LblTipoDeUsuario.AutoSize = True
        Me.LblTipoDeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoDeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoDeUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblTipoDeUsuario.Location = New System.Drawing.Point(942, 137)
        Me.LblTipoDeUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoDeUsuario.Name = "LblTipoDeUsuario"
        Me.LblTipoDeUsuario.Size = New System.Drawing.Size(153, 25)
        Me.LblTipoDeUsuario.TabIndex = 53
        Me.LblTipoDeUsuario.Text = "Tipo De Usuario"
        '
        'PctRefrescar
        '
        Me.PctRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctRefrescar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Refrescar
        Me.PctRefrescar.Location = New System.Drawing.Point(1196, 786)
        Me.PctRefrescar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctRefrescar.Name = "PctRefrescar"
        Me.PctRefrescar.Size = New System.Drawing.Size(140, 134)
        Me.PctRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctRefrescar.TabIndex = 55
        Me.PctRefrescar.TabStop = False
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(1030, 786)
        Me.PctAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(140, 134)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 54
        Me.PctAceptar.TabStop = False
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(1270, 0)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(80, 76)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 56
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(530, 29)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(324, 47)
        Me.LblDescripcion.TabIndex = 57
        Me.LblDescripcion.Text = "Alta de Usuarios"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlBarra.Controls.Add(Me.Label1)
        Me.PnlBarra.Controls.Add(Me.PctSalir)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(1350, 76)
        Me.PnlBarra.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(453, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 47)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nuevo Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 942)
        Me.Controls.Add(Me.PnlBarra)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctRefrescar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblTipoDeUsuario)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.PctAgregarMedicacion)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.PctAgregarEnfermedad)
        Me.Controls.Add(Me.PctEliminarMedicacion)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LstMedicacion)
        Me.Controls.Add(Me.PctEliminarEnfermedad)
        Me.Controls.Add(Me.LblEnfermedadCronica)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblMedicacion)
        Me.Controls.Add(Me.LstEnfermedadCronica)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.TxtEnfermedadCronica)
        Me.Controls.Add(Me.TxtMedicacion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.RdbH)
        Me.Controls.Add(Me.RdbF)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.LblFechaNacimiento)
        Me.Controls.Add(Me.ChbAdministrador)
        Me.Controls.Add(Me.ChbMedico)
        Me.Controls.Add(Me.ChbPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Usuario"
        CType(Me.PctAgregarMedicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAgregarEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarMedicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChbPaciente As CheckBox
    Friend WithEvents ChbMedico As CheckBox
    Friend WithEvents ChbAdministrador As CheckBox
    Friend WithEvents PctAgregarMedicacion As PictureBox
    Friend WithEvents PctAgregarEnfermedad As PictureBox
    Friend WithEvents PctEliminarMedicacion As PictureBox
    Friend WithEvents LstMedicacion As ListView
    Friend WithEvents PctEliminarEnfermedad As PictureBox
    Friend WithEvents LblEnfermedadCronica As Label
    Friend WithEvents LblMedicacion As Label
    Friend WithEvents LstEnfermedadCronica As ListView
    Friend WithEvents TxtEnfermedadCronica As TextBox
    Friend WithEvents TxtMedicacion As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents RdbH As RadioButton
    Friend WithEvents RdbF As RadioButton
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblTipoDeUsuario As Label
    Friend WithEvents PctRefrescar As PictureBox
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents PnlBarra As Panel
    Friend WithEvents Label1 As Label
End Class
