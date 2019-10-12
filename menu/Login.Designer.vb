<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtcon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.acceder = New System.Windows.Forms.Button()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Link = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(250, 330)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.menu.My.Resources.Resources.boss_man_125
        Me.PictureBox5.Location = New System.Drawing.Point(37, 75)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(152, 160)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.DimGray
        Me.txtuser.Location = New System.Drawing.Point(324, 75)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(394, 20)
        Me.txtuser.TabIndex = 1
        Me.txtuser.Text = "USUARIO"
        '
        'txtcon
        '
        Me.txtcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtcon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcon.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcon.ForeColor = System.Drawing.Color.DimGray
        Me.txtcon.Location = New System.Drawing.Point(324, 137)
        Me.txtcon.Name = "txtcon"
        Me.txtcon.Size = New System.Drawing.Size(394, 20)
        Me.txtcon.TabIndex = 2
        Me.txtcon.Text = "CONTRASEÑA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(510, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOGIN"
        '
        'acceder
        '
        Me.acceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.acceder.FlatAppearance.BorderSize = 0
        Me.acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.acceder.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.acceder.Location = New System.Drawing.Point(324, 247)
        Me.acceder.Name = "acceder"
        Me.acceder.Size = New System.Drawing.Size(394, 40)
        Me.acceder.TabIndex = 3
        Me.acceder.Text = "ACCEDER"
        Me.acceder.UseVisualStyleBackColor = False
        '
        'btnmini
        '
        Me.btnmini.Image = Global.menu.My.Resources.Resources.icon_minimizar
        Me.btnmini.Location = New System.Drawing.Point(742, 0)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(15, 15)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 8
        Me.btnmini.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Image = Global.menu.My.Resources.Resources.icon_cerrar2
        Me.btncerrar.Location = New System.Drawing.Point(763, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(15, 15)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 7
        Me.btncerrar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.menu.My.Resources.Resources.linea
        Me.PictureBox2.Location = New System.Drawing.Point(324, 156)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(394, 12)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.menu.My.Resources.Resources.linea
        Me.PictureBox1.Location = New System.Drawing.Point(324, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 12)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Link
        '
        Me.Link.AutoSize = True
        Me.Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link.Location = New System.Drawing.Point(476, 290)
        Me.Link.Name = "Link"
        Me.Link.Size = New System.Drawing.Size(91, 20)
        Me.Link.TabIndex = 9
        Me.Link.TabStop = True
        Me.Link.Text = "Registrarse"
        Me.Link.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(256, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(521, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Formato de la contraseña = 1 letra Mayuscula, minuscula, caracter, Numero y mas d" &
    "e 8 digitos"
        Me.Label2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Location = New System.Drawing.Point(324, 167)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Mostrar Contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 330)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Link)
        Me.Controls.Add(Me.btnmini)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.acceder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcon)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtcon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents acceder As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents btnmini As PictureBox
    Friend WithEvents Link As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
