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
        Me.btnnuevocliente = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnguardar_editar = New System.Windows.Forms.Button()
        Me.btnguardar_agregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pndatos = New System.Windows.Forms.Panel()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pndatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnnuevocliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevocliente.Location = New System.Drawing.Point(23, 85)
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
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar.Location = New System.Drawing.Point(23, 129)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(155, 34)
        Me.btneditar.TabIndex = 16
        Me.btneditar.Text = "Editar"
        Me.ToolTip1.SetToolTip(Me.btneditar, "Editar datos de un cliente")
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnguardar_editar
        '
        Me.btnguardar_editar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnguardar_editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnguardar_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar_editar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnguardar_editar.FlatAppearance.BorderSize = 0
        Me.btnguardar_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnguardar_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnguardar_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardar_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar_editar.Location = New System.Drawing.Point(23, 85)
        Me.btnguardar_editar.Name = "btnguardar_editar"
        Me.btnguardar_editar.Size = New System.Drawing.Size(155, 34)
        Me.btnguardar_editar.TabIndex = 20
        Me.btnguardar_editar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnguardar_editar, "Editar datos de un cliente")
        Me.btnguardar_editar.UseVisualStyleBackColor = False
        Me.btnguardar_editar.Visible = False
        '
        'btnguardar_agregar
        '
        Me.btnguardar_agregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnguardar_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnguardar_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar_agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnguardar_agregar.FlatAppearance.BorderSize = 0
        Me.btnguardar_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnguardar_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnguardar_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardar_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar_agregar.Location = New System.Drawing.Point(23, 129)
        Me.btnguardar_agregar.Name = "btnguardar_agregar"
        Me.btnguardar_agregar.Size = New System.Drawing.Size(155, 34)
        Me.btnguardar_agregar.TabIndex = 21
        Me.btnguardar_agregar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnguardar_agregar, "Editar datos de un cliente")
        Me.btnguardar_agregar.UseVisualStyleBackColor = False
        Me.btnguardar_agregar.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(23, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 34)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Editar datos de un cliente")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 521)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 463)
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
        Me.DataGridView1.Size = New System.Drawing.Size(895, 443)
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(880, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pndatos)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 217)
        Me.Panel2.TabIndex = 4
        '
        'pndatos
        '
        Me.pndatos.Controls.Add(Me.GroupBox2)
        Me.pndatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pndatos.Location = New System.Drawing.Point(200, 0)
        Me.pndatos.Name = "pndatos"
        Me.pndatos.Size = New System.Drawing.Size(701, 217)
        Me.pndatos.TabIndex = 24
        Me.pndatos.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtcedula)
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
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 217)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'txtcedula
        '
        Me.txtcedula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcedula.Enabled = False
        Me.txtcedula.Location = New System.Drawing.Point(93, 33)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(124, 21)
        Me.txtcedula.TabIndex = 19
        '
        'txtemail
        '
        Me.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtemail.Enabled = False
        Me.txtemail.Location = New System.Drawing.Point(93, 72)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(156, 21)
        Me.txtemail.TabIndex = 15
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "E-mail:"
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(281, 75)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(92, 15)
        Me.label5.TabIndex = 9
        Me.label5.Text = "N° de Telefono:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Direccion:"
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(463, 36)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 15)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Apellido:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(233, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 15)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cedula:"
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttelefono.Enabled = False
        Me.txttelefono.Location = New System.Drawing.Point(385, 75)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(155, 21)
        Me.txttelefono.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Location = New System.Drawing.Point(92, 124)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(592, 21)
        Me.txtdireccion.TabIndex = 3
        '
        'txtapellido
        '
        Me.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtapellido.Enabled = False
        Me.txtapellido.Location = New System.Drawing.Point(528, 33)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(156, 21)
        Me.txtapellido.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(301, 33)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(156, 21)
        Me.txtnombre.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnguardar_editar)
        Me.Panel3.Controls.Add(Me.btnguardar_agregar)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnnuevocliente)
        Me.Panel3.Controls.Add(Me.btneditar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 217)
        Me.Panel3.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(3, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(295, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Nota: Dar doble clic sobre el cliente que desea editar"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pndatos.ResumeLayout(False)
        Me.pndatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcedula As MaskedTextBox
    Friend WithEvents btnnuevocliente As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnguardar_agregar As Button
    Friend WithEvents btnguardar_editar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pndatos As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
End Class
