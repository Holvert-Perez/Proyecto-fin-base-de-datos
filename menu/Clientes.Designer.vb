<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnnuevocliente = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcedula = New System.Windows.Forms.MaskedTextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcedula2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnquitar
        '
        Me.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnquitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnquitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnquitar.FlatAppearance.BorderSize = 0
        Me.btnquitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnquitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnquitar.Image = Global.menu.My.Resources.Resources.EW
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquitar.Location = New System.Drawing.Point(559, 148)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(155, 34)
        Me.btnquitar.TabIndex = 18
        Me.btnquitar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnquitar, "Eliminar cliente")
        Me.btnquitar.UseVisualStyleBackColor = False
        '
        'btnnuevocliente
        '
        Me.btnnuevocliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnnuevocliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnnuevocliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevocliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnuevocliente.FlatAppearance.BorderSize = 0
        Me.btnnuevocliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnnuevocliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnnuevocliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnuevocliente.Image = Global.menu.My.Resources.Resources.icons8_añadir_322
        Me.btnnuevocliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevocliente.Location = New System.Drawing.Point(197, 148)
        Me.btnnuevocliente.Name = "btnnuevocliente"
        Me.btnnuevocliente.Size = New System.Drawing.Size(155, 34)
        Me.btnnuevocliente.TabIndex = 17
        Me.btnnuevocliente.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.btnnuevocliente, "Agregar un nuevo cliente")
        Me.btnnuevocliente.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btneditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditar.Image = Global.menu.My.Resources.Resources.icons8_lápiz_322
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar.Location = New System.Drawing.Point(379, 148)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(155, 34)
        Me.btneditar.TabIndex = 16
        Me.btneditar.Text = "Editar"
        Me.ToolTip1.SetToolTip(Me.btneditar, "Editar datos de un cliente")
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 216)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtcedula)
        Me.GroupBox2.Controls.Add(Me.btnquitar)
        Me.GroupBox2.Controls.Add(Me.btnnuevocliente)
        Me.GroupBox2.Controls.Add(Me.btneditar)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.label3)
        Me.GroupBox2.Controls.Add(Me.label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txttelefono)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtapellido)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.txtcedula2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(901, 216)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'txtcedula
        '
        Me.txtcedula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcedula.Location = New System.Drawing.Point(139, 23)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(124, 21)
        Me.txtcedula.TabIndex = 19
        '
        'txtemail
        '
        Me.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtemail.Location = New System.Drawing.Point(687, 52)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(156, 21)
        Me.txtemail.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(595, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "E-mail:"
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(307, 56)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(92, 15)
        Me.label5.TabIndex = 9
        Me.label5.Text = "N° de Telefono:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Direccion:"
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(595, 26)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 15)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Apellido:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(342, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 15)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cedula:"
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttelefono.Location = New System.Drawing.Point(411, 51)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(155, 21)
        Me.txttelefono.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtdireccion.Location = New System.Drawing.Point(139, 51)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(156, 21)
        Me.txtdireccion.TabIndex = 3
        '
        'txtapellido
        '
        Me.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtapellido.Location = New System.Drawing.Point(687, 21)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(156, 21)
        Me.txtapellido.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtnombre.Location = New System.Drawing.Point(410, 21)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(156, 21)
        Me.txtnombre.TabIndex = 1
        '
        'txtcedula2
        '
        Me.txtcedula2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcedula2.Location = New System.Drawing.Point(139, 87)
        Me.txtcedula2.Name = "txtcedula2"
        Me.txtcedula2.Size = New System.Drawing.Size(156, 21)
        Me.txtcedula2.TabIndex = 0
        Me.txtcedula2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 245)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 245)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(895, 225)
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.menu.My.Resources.Resources.cerrar
        Me.PictureBox1.Location = New System.Drawing.Point(880, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcedula2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnquitar As Button
    Friend WithEvents btnnuevocliente As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtcedula As MaskedTextBox
End Class
