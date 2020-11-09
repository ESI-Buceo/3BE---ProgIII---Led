<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Cambiar_Datos_Propios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cambiar_Datos_Propios))
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.LblEnfermedadesCronicas = New System.Windows.Forms.Label()
        Me.LblMedicaciones = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LstEnfermedadesCronicas = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.TxtAgregarEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtAgregarMedicacion = New System.Windows.Forms.TextBox()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.RdbMujer = New System.Windows.Forms.RadioButton()
        Me.DttFecha = New System.Windows.Forms.DateTimePicker()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctCancelar = New System.Windows.Forms.PictureBox()
        Me.PctEliminarEnfermedad = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PctAgregarMedicacion = New System.Windows.Forms.PictureBox()
        Me.PctAgregarEnfermedad = New System.Windows.Forms.PictureBox()
        Me.PctEliminarMedicacion = New System.Windows.Forms.PictureBox()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PctAgregarMedicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAgregarEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarMedicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(18, 31)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 16)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblApellido.Location = New System.Drawing.Point(18, 98)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 16)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblCorreo.Location = New System.Drawing.Point(18, 167)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(49, 16)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "Correo"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblSexo.Location = New System.Drawing.Point(18, 223)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(39, 16)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaDeNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaDeNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(16, 280)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(138, 16)
        Me.LblFechaDeNacimiento.TabIndex = 6
        Me.LblFechaDeNacimiento.Text = "Fecha De Nacimiento"
        '
        'LblEnfermedadesCronicas
        '
        Me.LblEnfermedadesCronicas.AutoSize = True
        Me.LblEnfermedadesCronicas.BackColor = System.Drawing.Color.Transparent
        Me.LblEnfermedadesCronicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedadesCronicas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.LblEnfermedadesCronicas.Location = New System.Drawing.Point(536, 23)
        Me.LblEnfermedadesCronicas.Name = "LblEnfermedadesCronicas"
        Me.LblEnfermedadesCronicas.Size = New System.Drawing.Size(153, 16)
        Me.LblEnfermedadesCronicas.TabIndex = 7
        Me.LblEnfermedadesCronicas.Text = "Enfermedades Cronicas"
        '
        'LblMedicaciones
        '
        Me.LblMedicaciones.AutoSize = True
        Me.LblMedicaciones.BackColor = System.Drawing.Color.Transparent
        Me.LblMedicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.LblMedicaciones.Location = New System.Drawing.Point(859, 24)
        Me.LblMedicaciones.Name = "LblMedicaciones"
        Me.LblMedicaciones.Size = New System.Drawing.Size(93, 16)
        Me.LblMedicaciones.TabIndex = 8
        Me.LblMedicaciones.Text = "Medicaciones"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(136, 18)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(331, 40)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNombre.WordWrap = False
        '
        'TxtApellido
        '
        Me.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(136, 84)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Multiline = True
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(331, 41)
        Me.TxtApellido.TabIndex = 1
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtApellido.WordWrap = False
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(136, 154)
        Me.TxtCorreo.MaxLength = 100
        Me.TxtCorreo.Multiline = True
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(331, 41)
        Me.TxtCorreo.TabIndex = 2
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCorreo.WordWrap = False
        '
        'LstEnfermedadesCronicas
        '
        Me.LstEnfermedadesCronicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEnfermedadesCronicas.FullRowSelect = True
        Me.LstEnfermedadesCronicas.HideSelection = False
        Me.LstEnfermedadesCronicas.Location = New System.Drawing.Point(523, 84)
        Me.LstEnfermedadesCronicas.MultiSelect = False
        Me.LstEnfermedadesCronicas.Name = "LstEnfermedadesCronicas"
        Me.LstEnfermedadesCronicas.Size = New System.Drawing.Size(184, 195)
        Me.LstEnfermedadesCronicas.TabIndex = 8
        Me.LstEnfermedadesCronicas.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedadesCronicas.View = System.Windows.Forms.View.List
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(811, 84)
        Me.LstMedicaciones.MultiSelect = False
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(184, 195)
        Me.LstMedicaciones.TabIndex = 10
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        '
        'TxtAgregarEnfermedad
        '
        Me.TxtAgregarEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgregarEnfermedad.Location = New System.Drawing.Point(523, 42)
        Me.TxtAgregarEnfermedad.MaxLength = 40
        Me.TxtAgregarEnfermedad.Multiline = True
        Me.TxtAgregarEnfermedad.Name = "TxtAgregarEnfermedad"
        Me.TxtAgregarEnfermedad.Size = New System.Drawing.Size(184, 39)
        Me.TxtAgregarEnfermedad.TabIndex = 6
        '
        'TxtAgregarMedicacion
        '
        Me.TxtAgregarMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgregarMedicacion.Location = New System.Drawing.Point(811, 43)
        Me.TxtAgregarMedicacion.MaxLength = 40
        Me.TxtAgregarMedicacion.Multiline = True
        Me.TxtAgregarMedicacion.Name = "TxtAgregarMedicacion"
        Me.TxtAgregarMedicacion.Size = New System.Drawing.Size(184, 39)
        Me.TxtAgregarMedicacion.TabIndex = 9
        '
        'RdbMasculino
        '
        Me.RdbMasculino.AutoSize = True
        Me.RdbMasculino.BackColor = System.Drawing.Color.Transparent
        Me.RdbMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMasculino.Location = New System.Drawing.Point(133, 223)
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.Size = New System.Drawing.Size(96, 20)
        Me.RdbMasculino.TabIndex = 3
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.Text = "Masculino"
        Me.RdbMasculino.UseVisualStyleBackColor = False
        '
        'RdbMujer
        '
        Me.RdbMujer.AutoSize = True
        Me.RdbMujer.BackColor = System.Drawing.Color.Transparent
        Me.RdbMujer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMujer.Location = New System.Drawing.Point(268, 223)
        Me.RdbMujer.Name = "RdbMujer"
        Me.RdbMujer.Size = New System.Drawing.Size(94, 20)
        Me.RdbMujer.TabIndex = 4
        Me.RdbMujer.TabStop = True
        Me.RdbMujer.Text = "Femenino"
        Me.RdbMujer.UseVisualStyleBackColor = False
        '
        'DttFecha
        '
        Me.DttFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DttFecha.Location = New System.Drawing.Point(193, 280)
        Me.DttFecha.Name = "DttFecha"
        Me.DttFecha.Size = New System.Drawing.Size(122, 20)
        Me.DttFecha.TabIndex = 5
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaDePresentacion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(1014, 12)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(58, 55)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 30
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(438, 19)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(244, 31)
        Me.LblDescripcion.TabIndex = 31
        Me.LblDescripcion.Text = "Cambiar mis Datos"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Transparent
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblCedula.Location = New System.Drawing.Point(11, 27)
        Me.LblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(0, 24)
        Me.LblCedula.TabIndex = 32
        Me.LblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaDePresentacion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(487, 446)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(91, 79)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 33
        Me.PctAceptar.TabStop = False
        '
        'PctCancelar
        '
        Me.PctCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctCancelar.Image = Global.CapaDePresentacion.My.Resources.Resources.Cancelar1
        Me.PctCancelar.Location = New System.Drawing.Point(983, 446)
        Me.PctCancelar.Name = "PctCancelar"
        Me.PctCancelar.Size = New System.Drawing.Size(89, 79)
        Me.PctCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctCancelar.TabIndex = 34
        Me.PctCancelar.TabStop = False
        '
        'PctEliminarEnfermedad
        '
        Me.PctEliminarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEliminarEnfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEliminarEnfermedad.Enabled = False
        Me.PctEliminarEnfermedad.Image = Global.CapaDePresentacion.My.Resources.Resources.DelCircularRojoOscuro
        Me.PctEliminarEnfermedad.Location = New System.Drawing.Point(713, 84)
        Me.PctEliminarEnfermedad.Name = "PctEliminarEnfermedad"
        Me.PctEliminarEnfermedad.Size = New System.Drawing.Size(31, 30)
        Me.PctEliminarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarEnfermedad.TabIndex = 35
        Me.PctEliminarEnfermedad.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PctAgregarMedicacion)
        Me.Panel1.Controls.Add(Me.PctAgregarEnfermedad)
        Me.Panel1.Controls.Add(Me.PctEliminarMedicacion)
        Me.Panel1.Controls.Add(Me.LstMedicaciones)
        Me.Panel1.Controls.Add(Me.TxtCorreo)
        Me.Panel1.Controls.Add(Me.LblNombre)
        Me.Panel1.Controls.Add(Me.PctEliminarEnfermedad)
        Me.Panel1.Controls.Add(Me.LblApellido)
        Me.Panel1.Controls.Add(Me.LblCorreo)
        Me.Panel1.Controls.Add(Me.LblSexo)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.TxtApellido)
        Me.Panel1.Controls.Add(Me.RdbMasculino)
        Me.Panel1.Controls.Add(Me.RdbMujer)
        Me.Panel1.Controls.Add(Me.LblEnfermedadesCronicas)
        Me.Panel1.Controls.Add(Me.DttFecha)
        Me.Panel1.Controls.Add(Me.LblMedicaciones)
        Me.Panel1.Controls.Add(Me.LstEnfermedadesCronicas)
        Me.Panel1.Controls.Add(Me.LblFechaDeNacimiento)
        Me.Panel1.Controls.Add(Me.TxtAgregarEnfermedad)
        Me.Panel1.Controls.Add(Me.TxtAgregarMedicacion)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Location = New System.Drawing.Point(12, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 314)
        Me.Panel1.TabIndex = 39
        '
        'PctAgregarMedicacion
        '
        Me.PctAgregarMedicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarMedicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarMedicacion.Enabled = False
        Me.PctAgregarMedicacion.Image = Global.CapaDePresentacion.My.Resources.Resources.AddCircularVerdeOscuro
        Me.PctAgregarMedicacion.Location = New System.Drawing.Point(1001, 43)
        Me.PctAgregarMedicacion.Name = "PctAgregarMedicacion"
        Me.PctAgregarMedicacion.Size = New System.Drawing.Size(31, 30)
        Me.PctAgregarMedicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarMedicacion.TabIndex = 38
        Me.PctAgregarMedicacion.TabStop = False
        '
        'PctAgregarEnfermedad
        '
        Me.PctAgregarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarEnfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarEnfermedad.Enabled = False
        Me.PctAgregarEnfermedad.Image = Global.CapaDePresentacion.My.Resources.Resources.AddCircularVerdeOscuro
        Me.PctAgregarEnfermedad.Location = New System.Drawing.Point(713, 42)
        Me.PctAgregarEnfermedad.Name = "PctAgregarEnfermedad"
        Me.PctAgregarEnfermedad.Size = New System.Drawing.Size(31, 31)
        Me.PctAgregarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarEnfermedad.TabIndex = 37
        Me.PctAgregarEnfermedad.TabStop = False
        Me.PctAgregarEnfermedad.Tag = "7"
        '
        'PctEliminarMedicacion
        '
        Me.PctEliminarMedicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEliminarMedicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEliminarMedicacion.Enabled = False
        Me.PctEliminarMedicacion.Image = Global.CapaDePresentacion.My.Resources.Resources.DelCircularRojoOscuro
        Me.PctEliminarMedicacion.Location = New System.Drawing.Point(1001, 84)
        Me.PctEliminarMedicacion.Name = "PctEliminarMedicacion"
        Me.PctEliminarMedicacion.Size = New System.Drawing.Size(31, 30)
        Me.PctEliminarMedicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarMedicacion.TabIndex = 36
        Me.PctEliminarMedicacion.TabStop = False
        '
        'Frm_Cambiar_Datos_Propios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CapaDePresentacion.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(1084, 537)
        Me.Controls.Add(Me.PctCancelar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cambiar_Datos_Propios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de datos propios"
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PctAgregarMedicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAgregarEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarMedicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblFechaDeNacimiento As Label
    Friend WithEvents LblEnfermedadesCronicas As Label
    Friend WithEvents LblMedicaciones As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LstEnfermedadesCronicas As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents TxtAgregarEnfermedad As TextBox
    Friend WithEvents TxtAgregarMedicacion As TextBox
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents RdbMujer As RadioButton
    Friend WithEvents DttFecha As DateTimePicker
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctCancelar As PictureBox
    Friend WithEvents PctEliminarEnfermedad As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PctAgregarMedicacion As PictureBox
    Friend WithEvents PctAgregarEnfermedad As PictureBox
    Friend WithEvents PctEliminarMedicacion As PictureBox
End Class
