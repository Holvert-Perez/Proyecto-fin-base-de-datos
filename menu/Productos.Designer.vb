<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(800, 141)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(642, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Precio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnquitar)
        Me.GroupBox2.Controls.Add(Me.btneditar)
        Me.GroupBox2.Controls.Add(Me.btnagregar)
        Me.GroupBox2.Controls.Add(Me.txtprecio)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 174)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(693, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "*obligatorio"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(511, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "*obligatorio"
        Me.Label4.Visible = False
        '
        'btnquitar
        '
        Me.btnquitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnquitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquitar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnquitar.FlatAppearance.BorderSize = 0
        Me.btnquitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnquitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnquitar.Image = Global.menu.My.Resources.Resources.EW
        Me.btnquitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquitar.Location = New System.Drawing.Point(500, 119)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(155, 34)
        Me.btnquitar.TabIndex = 26
        Me.btnquitar.Text = "Quitar"
        Me.btnquitar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditar.Image = Global.menu.My.Resources.Resources.icons8_lápiz_322
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar.Location = New System.Drawing.Point(319, 119)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(155, 34)
        Me.btneditar.TabIndex = 25
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnagregar.Image = Global.menu.My.Resources.Resources.icons8_añadir_322
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.Location = New System.Drawing.Point(134, 119)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(155, 34)
        Me.btnagregar.TabIndex = 24
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(696, 39)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(67, 21)
        Me.txtprecio.TabIndex = 23
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(438, 39)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(189, 21)
        Me.txtdescripcion.TabIndex = 22
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(129, 39)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(189, 21)
        Me.txtcodigo.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.menu.My.Resources.Resources.cerrar
        Me.PictureBox1.Location = New System.Drawing.Point(811, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 402)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btnquitar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
