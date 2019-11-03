<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio_de_sesion
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
        Me.ptitulo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Link = New System.Windows.Forms.LinkLabel()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ttmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.ptbnomotrar = New System.Windows.Forms.PictureBox()
        Me.ptbmostrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnmin = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.ptitulo.SuspendLayout()
        CType(Me.ptbnomotrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbmostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptitulo
        '
        Me.ptitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ptitulo.Controls.Add(Me.btnmin)
        Me.ptitulo.Controls.Add(Me.btncerrar)
        Me.ptitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptitulo.Location = New System.Drawing.Point(0, 0)
        Me.ptitulo.Name = "ptitulo"
        Me.ptitulo.Size = New System.Drawing.Size(430, 30)
        Me.ptitulo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 665)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 15)
        Me.Panel1.TabIndex = 1
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.White
        Me.txtuser.Location = New System.Drawing.Point(80, 298)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(317, 30)
        Me.txtuser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(70, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(70, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.White
        Me.txtpass.Location = New System.Drawing.Point(80, 360)
        Me.txtpass.MaxLength = 12
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(301, 30)
        Me.txtpass.TabIndex = 4
        Me.txtpass.WordWrap = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(44, 454)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(353, 49)
        Me.btnlogin.TabIndex = 7
        Me.btnlogin.Text = "Iniciar Sesión"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(44, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 1)
        Me.Label3.TabIndex = 8
        '
        'Link
        '
        Me.Link.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Link.AutoSize = True
        Me.Link.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link.ForeColor = System.Drawing.Color.Silver
        Me.Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Link.LinkColor = System.Drawing.Color.Silver
        Me.Link.Location = New System.Drawing.Point(120, 597)
        Me.Link.Name = "Link"
        Me.Link.Size = New System.Drawing.Size(205, 20)
        Me.Link.TabIndex = 9
        Me.Link.TabStop = True
        Me.Link.Text = "¿Olvidaste tu Contraseña?"
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.Location = New System.Drawing.Point(44, 509)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(353, 49)
        Me.btnagregar.TabIndex = 10
        Me.btnagregar.Text = "Registrarse"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(80, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 1)
        Me.Label4.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(80, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 1)
        Me.Label5.TabIndex = 17
        '
        'ptbnomotrar
        '
        Me.ptbnomotrar.Image = Global.menu.My.Resources.Resources.invisible
        Me.ptbnomotrar.Location = New System.Drawing.Point(377, 367)
        Me.ptbnomotrar.Name = "ptbnomotrar"
        Me.ptbnomotrar.Size = New System.Drawing.Size(20, 20)
        Me.ptbnomotrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbnomotrar.TabIndex = 19
        Me.ptbnomotrar.TabStop = False
        '
        'ptbmostrar
        '
        Me.ptbmostrar.Image = Global.menu.My.Resources.Resources.eye
        Me.ptbmostrar.Location = New System.Drawing.Point(377, 367)
        Me.ptbmostrar.Name = "ptbmostrar"
        Me.ptbmostrar.Size = New System.Drawing.Size(20, 20)
        Me.ptbmostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbmostrar.TabIndex = 18
        Me.ptbmostrar.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PictureBox4.Image = Global.menu.My.Resources.Resources.man_user
        Me.PictureBox4.Location = New System.Drawing.Point(44, 298)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PictureBox3.Image = Global.menu.My.Resources.Resources.lock
        Me.PictureBox3.Location = New System.Drawing.Point(44, 360)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.menu.My.Resources.Resources.Sin_título_1_Mesa_de_trabajo_1
        Me.PictureBox1.Location = New System.Drawing.Point(96, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnmin
        '
        Me.btnmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmin.Image = Global.menu.My.Resources.Resources._003_minus
        Me.btnmin.Location = New System.Drawing.Point(381, 8)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(16, 16)
        Me.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnmin.TabIndex = 1
        Me.btnmin.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.menu.My.Resources.Resources.close_cross
        Me.btncerrar.Location = New System.Drawing.Point(403, 4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(16, 16)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.TabStop = False
        '
        'Inicio_de_sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 680)
        Me.Controls.Add(Me.ptbnomotrar)
        Me.Controls.Add(Me.ptbmostrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Link)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ptitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inicio_de_sesion"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio_de_sesion"
        Me.ptitulo.ResumeLayout(False)
        Me.ptitulo.PerformLayout()
        CType(Me.ptbnomotrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbmostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptitulo As Panel
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnmin As PictureBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Link As LinkLabel
    Friend WithEvents btnagregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ptbmostrar As PictureBox
    Friend WithEvents ptbnomotrar As PictureBox
    Friend WithEvents ttmensaje As ToolTip
End Class
