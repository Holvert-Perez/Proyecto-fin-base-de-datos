﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.logo2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
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
        Me.iconrest = New System.Windows.Forms.PictureBox()
        Me.iconmaxi = New System.Windows.Forms.PictureBox()
        Me.iconce = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcontenedor.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconrest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelmenu.Controls.Add(Me.logo2)
        Me.panelmenu.Controls.Add(Me.Panel6)
        Me.panelmenu.Controls.Add(Me.btnImprimir)
        Me.panelmenu.Controls.Add(Me.btnsalir)
        Me.panelmenu.Controls.Add(Me.PictureBox1)
        Me.panelmenu.Controls.Add(Me.Panel5)
        Me.panelmenu.Controls.Add(Me.Panel3)
        Me.panelmenu.Controls.Add(Me.Panel2)
        Me.panelmenu.Controls.Add(Me.Panel4)
        Me.panelmenu.Controls.Add(Me.Panel7)
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
        'logo2
        '
        Me.logo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logo2.Location = New System.Drawing.Point(201, 4)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(55, 93)
        Me.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo2.TabIndex = 13
        Me.logo2.TabStop = False
        Me.logo2.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 431)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 50)
        Me.Panel6.TabIndex = 11
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
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnsalir.Location = New System.Drawing.Point(73, 105)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(122, 36)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Cerrar Sesión"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.menu.My.Resources.Resources.boss_man_128
        Me.PictureBox1.Location = New System.Drawing.Point(73, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 375)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 50)
        Me.Panel5.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 319)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 50)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 50)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 263)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 50)
        Me.Panel4.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 151)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 50)
        Me.Panel7.TabIndex = 0
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
        Me.PanelTitulo.Controls.Add(Me.iconrest)
        Me.PanelTitulo.Controls.Add(Me.iconmaxi)
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
        Me.menu.Image = Global.menu.My.Resources.Resources.Mobile_Menu_Icon
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
        Me.iconmini.Image = Global.menu.My.Resources.Resources.icon_minimizar
        Me.iconmini.Location = New System.Drawing.Point(709, 7)
        Me.iconmini.Name = "iconmini"
        Me.iconmini.Size = New System.Drawing.Size(18, 18)
        Me.iconmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconmini.TabIndex = 3
        Me.iconmini.TabStop = False
        '
        'iconrest
        '
        Me.iconrest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconrest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconrest.Location = New System.Drawing.Point(652, 4)
        Me.iconrest.Name = "iconrest"
        Me.iconrest.Size = New System.Drawing.Size(18, 18)
        Me.iconrest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconrest.TabIndex = 2
        Me.iconrest.TabStop = False
        Me.iconrest.Visible = False
        '
        'iconmaxi
        '
        Me.iconmaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconmaxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconmaxi.Location = New System.Drawing.Point(628, 4)
        Me.iconmaxi.Name = "iconmaxi"
        Me.iconmaxi.Size = New System.Drawing.Size(18, 18)
        Me.iconmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconmaxi.TabIndex = 1
        Me.iconmaxi.TabStop = False
        '
        'iconce
        '
        Me.iconce.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iconce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconce.Image = Global.menu.My.Resources.Resources.icon_cerrar2
        Me.iconce.Location = New System.Drawing.Point(736, 1)
        Me.iconce.Name = "iconce"
        Me.iconce.Size = New System.Drawing.Size(18, 18)
        Me.iconce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcontenedor.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconrest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconmaxi, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents iconrest As PictureBox
    Friend WithEvents iconmaxi As PictureBox
    Friend WithEvents iconce As PictureBox
    Friend WithEvents panelmenu As Panel
    Friend WithEvents logo2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Labelfecha As Label
    Friend WithEvents btncompras As Button
    Friend WithEvents btnproveedores As Button
    Friend WithEvents btnclientes As Button
    Friend WithEvents btnventas As Button
    Friend WithEvents btnproductos As Button
    Friend WithEvents menu As PictureBox
End Class
