<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.PctSalirLeft = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PctSalirLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Libre Franklin", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(457, 352)
        Me.TxtPass.MaxLength = 9
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(288, 30)
        Me.TxtPass.TabIndex = 1
        Me.TxtPass.Text = " "
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Libre Franklin", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(457, 208)
        Me.TxtUser.MaxLength = 8
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(288, 30)
        Me.TxtUser.TabIndex = 0
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackgroundImage = Global.FrmMedico.My.Resources.Resources.BotonIngresar3
        Me.BtnIngresar.Enabled = False
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Image = Global.FrmMedico.My.Resources.Resources.BotonIngresar3
        Me.BtnIngresar.Location = New System.Drawing.Point(442, 492)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(318, 51)
        Me.BtnIngresar.TabIndex = 2
        Me.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'PctSalirLeft
        '
        Me.PctSalirLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalirLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalirLeft.Image = CType(resources.GetObject("PctSalirLeft.Image"), System.Drawing.Image)
        Me.PctSalirLeft.Location = New System.Drawing.Point(705, 12)
        Me.PctSalirLeft.Name = "PctSalirLeft"
        Me.PctSalirLeft.Size = New System.Drawing.Size(70, 70)
        Me.PctSalirLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalirLeft.TabIndex = 7
        Me.PctSalirLeft.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FrmMedico.My.Resources.Resources.LoginMedico
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 591)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 591)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.PctSalirLeft)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso al sistema"
        CType(Me.PctSalirLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents PctSalirLeft As PictureBox
    Friend WithEvents BtnIngresar As Button
End Class
