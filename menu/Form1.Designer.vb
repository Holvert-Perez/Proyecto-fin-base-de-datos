<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcargo = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.p3 = New System.Windows.Forms.Panel()
        Me.p5 = New System.Windows.Forms.Panel()
        Me.p4 = New System.Windows.Forms.Panel()
        Me.p6 = New System.Windows.Forms.Panel()
        Me.Labelfecha = New System.Windows.Forms.Label()
        Me.btncompras = New System.Windows.Forms.Button()
        Me.btnproveedores = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.panelcontenedor = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.iconmini = New System.Windows.Forms.PictureBox()
        Me.iconce = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcontenedor.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolTip1
        '
        Me.ToolTip1.Active = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.panelmenu)
        Me.SplitContainer1.Panel1MinSize = 10
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelcontenedor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelTitulo)
        Me.SplitContainer1.Panel2MinSize = 10
        Me.SplitContainer1.Size = New System.Drawing.Size(1035, 529)
        Me.SplitContainer1.SplitterDistance = 280
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 1
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.panelmenu.Controls.Add(Me.lblcorreo)
        Me.panelmenu.Controls.Add(Me.lblnombre)
        Me.panelmenu.Controls.Add(Me.lblcargo)
        Me.panelmenu.Controls.Add(Me.p1)
        Me.panelmenu.Controls.Add(Me.btnImprimir)
        Me.panelmenu.Controls.Add(Me.btnsalir)
        Me.panelmenu.Controls.Add(Me.PictureBox1)
        Me.panelmenu.Controls.Add(Me.p2)
        Me.panelmenu.Controls.Add(Me.p3)
        Me.panelmenu.Controls.Add(Me.p5)
        Me.panelmenu.Controls.Add(Me.p4)
        Me.panelmenu.Controls.Add(Me.p6)
        Me.panelmenu.Controls.Add(Me.Labelfecha)
        Me.panelmenu.Controls.Add(Me.btncompras)
        Me.panelmenu.Controls.Add(Me.btnproveedores)
        Me.panelmenu.Controls.Add(Me.btnclientes)
        Me.panelmenu.Controls.Add(Me.btnventas)
        Me.panelmenu.Controls.Add(Me.btnproductos)
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Margin = New System.Windows.Forms.Padding(0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(260, 820)
        Me.panelmenu.TabIndex = 2
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(146, 61)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(37, 13)
        Me.lblcorreo.TabIndex = 15
        Me.lblcorreo.Text = "correo"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(146, 38)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(42, 13)
        Me.lblnombre.TabIndex = 14
        Me.lblnombre.Text = "nombre"
        '
        'lblcargo
        '
        Me.lblcargo.AutoSize = True
        Me.lblcargo.Location = New System.Drawing.Point(146, 15)
        Me.lblcargo.Name = "lblcargo"
        Me.lblcargo.Size = New System.Drawing.Size(34, 13)
        Me.lblcargo.TabIndex = 13
        Me.lblcargo.Text = "cargo"
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p1.Location = New System.Drawing.Point(0, 431)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(10, 50)
        Me.p1.TabIndex = 11
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(9, 431)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(260, 50)
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.Text = "Imprimir Reportes"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(3, 109)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(122, 36)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Cerrar Sesión"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p2.Location = New System.Drawing.Point(0, 375)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(10, 50)
        Me.p2.TabIndex = 4
        '
        'p3
        '
        Me.p3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p3.Location = New System.Drawing.Point(0, 319)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(10, 50)
        Me.p3.TabIndex = 3
        '
        'p5
        '
        Me.p5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p5.Location = New System.Drawing.Point(0, 207)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(10, 50)
        Me.p5.TabIndex = 1
        '
        'p4
        '
        Me.p4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p4.Location = New System.Drawing.Point(0, 263)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(10, 50)
        Me.p4.TabIndex = 2
        '
        'p6
        '
        Me.p6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p6.Location = New System.Drawing.Point(0, 151)
        Me.p6.Name = "p6"
        Me.p6.Size = New System.Drawing.Size(10, 50)
        Me.p6.TabIndex = 0
        '
        'Labelfecha
        '
        Me.Labelfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labelfecha.AutoSize = True
        Me.Labelfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfecha.ForeColor = System.Drawing.SystemColors.Control
        Me.Labelfecha.Location = New System.Drawing.Point(42, 820)
        Me.Labelfecha.Name = "Labelfecha"
        Me.Labelfecha.Size = New System.Drawing.Size(171, 18)
        Me.Labelfecha.TabIndex = 5
        Me.Labelfecha.Text = "sabado, 05 octubre 2018"
        '
        'btncompras
        '
        Me.btncompras.FlatAppearance.BorderSize = 0
        Me.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompras.ForeColor = System.Drawing.SystemColors.Control
        Me.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncompras.Location = New System.Drawing.Point(0, 375)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(260, 50)
        Me.btncompras.TabIndex = 4
        Me.btncompras.Text = "Compras"
        Me.btncompras.UseVisualStyleBackColor = True
        '
        'btnproveedores
        '
        Me.btnproveedores.FlatAppearance.BorderSize = 0
        Me.btnproveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedores.ForeColor = System.Drawing.SystemColors.Control
        Me.btnproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproveedores.Location = New System.Drawing.Point(0, 319)
        Me.btnproveedores.Name = "btnproveedores"
        Me.btnproveedores.Size = New System.Drawing.Size(260, 50)
        Me.btnproveedores.TabIndex = 3
        Me.btnproveedores.Text = "Proveedores"
        Me.btnproveedores.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.FlatAppearance.BorderSize = 0
        Me.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientes.Location = New System.Drawing.Point(0, 263)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(260, 50)
        Me.btnclientes.TabIndex = 2
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.FlatAppearance.BorderSize = 0
        Me.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnventas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnventas.Location = New System.Drawing.Point(0, 207)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(260, 50)
        Me.btnventas.TabIndex = 1
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'btnproductos
        '
        Me.btnproductos.FlatAppearance.BorderSize = 0
        Me.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproductos.Location = New System.Drawing.Point(0, 151)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(260, 50)
        Me.btnproductos.TabIndex = 0
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = True
        '
        'panelcontenedor
        '
        Me.panelcontenedor.BackColor = System.Drawing.Color.White
        Me.panelcontenedor.Controls.Add(Me.PictureBox4)
        Me.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcontenedor.Location = New System.Drawing.Point(0, 22)
        Me.panelcontenedor.Name = "panelcontenedor"
        Me.panelcontenedor.Size = New System.Drawing.Size(754, 507)
        Me.panelcontenedor.TabIndex = 4
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(727, 456)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.menu)
        Me.PanelTitulo.Controls.Add(Me.iconmini)
        Me.PanelTitulo.Controls.Add(Me.iconce)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(754, 22)
        Me.PanelTitulo.TabIndex = 3
        '
        'menu
        '
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(20, 20)
        Me.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.menu.TabIndex = 0
        Me.menu.TabStop = False
        Me.menu.Visible = False
        '
        'iconmini
        '
        Me.iconmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconmini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconmini.Image = Global.menu.My.Resources.Resources._003_minus
        Me.iconmini.Location = New System.Drawing.Point(709, 7)
        Me.iconmini.Name = "iconmini"
        Me.iconmini.Size = New System.Drawing.Size(16, 16)
        Me.iconmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconmini.TabIndex = 3
        Me.iconmini.TabStop = False
        '
        'iconce
        '
        Me.iconce.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iconce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconce.Image = Global.menu.My.Resources.Resources._002_delete_1
        Me.iconce.Location = New System.Drawing.Point(736, 1)
        Me.iconce.Name = "iconce"
        Me.iconce.Size = New System.Drawing.Size(16, 16)
        Me.iconce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconce.TabIndex = 0
        Me.iconce.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 529)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.panelmenu.ResumeLayout(False)
        Me.panelmenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcontenedor.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainer1 As SplitContainer
    Public WithEvents panelcontenedor As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Public WithEvents PanelTitulo As Panel
    Friend WithEvents iconmini As PictureBox
    Friend WithEvents iconce As PictureBox
    Friend WithEvents panelmenu As Panel
    Friend WithEvents p1 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents p2 As Panel
    Friend WithEvents p3 As Panel
    Friend WithEvents p5 As Panel
    Friend WithEvents p4 As Panel
    Friend WithEvents p6 As Panel
    Friend WithEvents Labelfecha As Label
    Friend WithEvents btncompras As Button
    Friend WithEvents btnproveedores As Button
    Friend WithEvents btnclientes As Button
    Friend WithEvents btnventas As Button
    Friend WithEvents btnproductos As Button
    Friend WithEvents menu As PictureBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcargo As Label
End Class
