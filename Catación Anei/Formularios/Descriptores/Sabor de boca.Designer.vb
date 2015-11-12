<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescriptores_SaborBoca
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescriptores_SaborBoca))
        Me.txtAgregarDescriptor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListaDescriptores = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.tsApagado = New System.Windows.Forms.ToolStripButton()
        Me.tsBalanceado = New System.Windows.Forms.ToolStripButton()
        Me.tsDelicado = New System.Windows.Forms.ToolStripButton()
        Me.tsLimpio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.tsSucio = New System.Windows.Forms.ToolStripButton()
        Me.tsEstructurado = New System.Windows.Forms.ToolStripButton()
        Me.tsDébil = New System.Windows.Forms.ToolStripButton()
        Me.tsRápido = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsProlongado = New System.Windows.Forms.ToolStripButton()
        Me.tsLeve = New System.Windows.Forms.ToolStripButton()
        Me.tsBlando = New System.Windows.Forms.ToolStripButton()
        Me.tsAstringente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsJugoso = New System.Windows.Forms.ToolStripButton()
        Me.tsdeslucido = New System.Windows.Forms.ToolStripButton()
        Me.tsRedondeado = New System.Windows.Forms.ToolStripButton()
        Me.tsSeco = New System.Windows.Forms.ToolStripButton()
        Me.tsAspero = New System.Windows.Forms.ToolStripButton()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAgregarDescriptor
        '
        Me.txtAgregarDescriptor.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgregarDescriptor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAgregarDescriptor.Location = New System.Drawing.Point(153, 99)
        Me.txtAgregarDescriptor.Name = "txtAgregarDescriptor"
        Me.txtAgregarDescriptor.Size = New System.Drawing.Size(234, 26)
        Me.txtAgregarDescriptor.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(146, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 35)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sabor de boca"
        '
        'ListaDescriptores
        '
        Me.ListaDescriptores.BackColor = System.Drawing.Color.Peru
        Me.ListaDescriptores.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaDescriptores.ForeColor = System.Drawing.Color.White
        Me.ListaDescriptores.FormattingEnabled = True
        Me.ListaDescriptores.ItemHeight = 22
        Me.ListaDescriptores.Items.AddRange(New Object() {"Descriptor 1", "Descriptor 2", "Descriptor 3", "Descriptor 4", "Descriptor 5", "Descriptor 6", "Descriptor 7"})
        Me.ListaDescriptores.Location = New System.Drawing.Point(12, 132)
        Me.ListaDescriptores.Name = "ListaDescriptores"
        Me.ListaDescriptores.Size = New System.Drawing.Size(130, 488)
        Me.ListaDescriptores.TabIndex = 41
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(12, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 44)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Descriptores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seleccionados"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 54)
        Me.Panel1.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Catación_Anei.My.Resources.Resources.Descriptores_48x48
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Tag = ""
        Me.Label1.Text = "Descriptores"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip4)
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(153, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 501)
        Me.Panel2.TabIndex = 45
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsApagado, Me.tsBalanceado, Me.tsDelicado, Me.tsLimpio})
        Me.ToolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip4.Location = New System.Drawing.Point(530, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(111, 127)
        Me.ToolStrip4.TabIndex = 1
        Me.ToolStrip4.Text = "ToolStrip2"
        '
        'tsApagado
        '
        Me.tsApagado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsApagado.Image = Global.Catación_Anei.My.Resources.Resources.apagado
        Me.tsApagado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsApagado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsApagado.Name = "tsApagado"
        Me.tsApagado.Size = New System.Drawing.Size(109, 26)
        Me.tsApagado.Text = "apagago"
        '
        'tsBalanceado
        '
        Me.tsBalanceado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBalanceado.Image = Global.Catación_Anei.My.Resources.Resources.balanceado
        Me.tsBalanceado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsBalanceado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBalanceado.Name = "tsBalanceado"
        Me.tsBalanceado.Size = New System.Drawing.Size(109, 26)
        Me.tsBalanceado.Text = "balanceado"
        '
        'tsDelicado
        '
        Me.tsDelicado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelicado.Image = Global.Catación_Anei.My.Resources.Resources.débil
        Me.tsDelicado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsDelicado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelicado.Name = "tsDelicado"
        Me.tsDelicado.Size = New System.Drawing.Size(109, 26)
        Me.tsDelicado.Text = "delicado"
        '
        'tsLimpio
        '
        Me.tsLimpio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsLimpio.Image = Global.Catación_Anei.My.Resources.Resources.limpio
        Me.tsLimpio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsLimpio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLimpio.Name = "tsLimpio"
        Me.tsLimpio.Size = New System.Drawing.Size(109, 26)
        Me.tsLimpio.Text = "limpio"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSucio, Me.tsEstructurado, Me.tsDébil, Me.tsRápido})
        Me.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip3.Location = New System.Drawing.Point(346, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(120, 127)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip2"
        '
        'tsSucio
        '
        Me.tsSucio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSucio.Image = CType(resources.GetObject("tsSucio.Image"), System.Drawing.Image)
        Me.tsSucio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsSucio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSucio.Name = "tsSucio"
        Me.tsSucio.Size = New System.Drawing.Size(118, 26)
        Me.tsSucio.Text = "sucio"
        '
        'tsEstructurado
        '
        Me.tsEstructurado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsEstructurado.Image = Global.Catación_Anei.My.Resources.Resources.estructuado
        Me.tsEstructurado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsEstructurado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEstructurado.Name = "tsEstructurado"
        Me.tsEstructurado.Size = New System.Drawing.Size(118, 26)
        Me.tsEstructurado.Text = "estructurado"
        '
        'tsDébil
        '
        Me.tsDébil.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDébil.Image = Global.Catación_Anei.My.Resources.Resources.débil
        Me.tsDébil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsDébil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDébil.Name = "tsDébil"
        Me.tsDébil.Size = New System.Drawing.Size(118, 26)
        Me.tsDébil.Text = "débil"
        '
        'tsRápido
        '
        Me.tsRápido.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsRápido.Image = Global.Catación_Anei.My.Resources.Resources.rápido
        Me.tsRápido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsRápido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRápido.Name = "tsRápido"
        Me.tsRápido.Size = New System.Drawing.Size(118, 26)
        Me.tsRápido.Text = "rápido"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsProlongado, Me.tsLeve, Me.tsBlando, Me.tsAstringente})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(175, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(110, 127)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'tsProlongado
        '
        Me.tsProlongado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsProlongado.Image = Global.Catación_Anei.My.Resources.Resources.prolongado
        Me.tsProlongado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsProlongado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsProlongado.Name = "tsProlongado"
        Me.tsProlongado.Size = New System.Drawing.Size(108, 26)
        Me.tsProlongado.Text = "prolongado"
        '
        'tsLeve
        '
        Me.tsLeve.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsLeve.Image = Global.Catación_Anei.My.Resources.Resources.leve
        Me.tsLeve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsLeve.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLeve.Name = "tsLeve"
        Me.tsLeve.Size = New System.Drawing.Size(108, 26)
        Me.tsLeve.Text = "leve"
        '
        'tsBlando
        '
        Me.tsBlando.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBlando.Image = Global.Catación_Anei.My.Resources.Resources.blando
        Me.tsBlando.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsBlando.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBlando.Name = "tsBlando"
        Me.tsBlando.Size = New System.Drawing.Size(108, 26)
        Me.tsBlando.Text = "blando"
        '
        'tsAstringente
        '
        Me.tsAstringente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsAstringente.Image = Global.Catación_Anei.My.Resources.Resources.astringente
        Me.tsAstringente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsAstringente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAstringente.Name = "tsAstringente"
        Me.tsAstringente.Size = New System.Drawing.Size(108, 26)
        Me.tsAstringente.Text = "astringente"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsJugoso, Me.tsdeslucido, Me.tsRedondeado, Me.tsSeco, Me.tsAspero})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(116, 156)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsJugoso
        '
        Me.tsJugoso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsJugoso.Image = Global.Catación_Anei.My.Resources.Resources.jugoso
        Me.tsJugoso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsJugoso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsJugoso.Name = "tsJugoso"
        Me.tsJugoso.Size = New System.Drawing.Size(114, 26)
        Me.tsJugoso.Text = "jugoso"
        '
        'tsdeslucido
        '
        Me.tsdeslucido.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsdeslucido.Image = Global.Catación_Anei.My.Resources.Resources.deslucido
        Me.tsdeslucido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsdeslucido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdeslucido.Name = "tsdeslucido"
        Me.tsdeslucido.Size = New System.Drawing.Size(114, 26)
        Me.tsdeslucido.Text = "deslucido"
        '
        'tsRedondeado
        '
        Me.tsRedondeado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsRedondeado.Image = Global.Catación_Anei.My.Resources.Resources.redondeado
        Me.tsRedondeado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsRedondeado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRedondeado.Name = "tsRedondeado"
        Me.tsRedondeado.Size = New System.Drawing.Size(114, 26)
        Me.tsRedondeado.Text = "redondeado"
        '
        'tsSeco
        '
        Me.tsSeco.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSeco.Image = Global.Catación_Anei.My.Resources.Resources.seco
        Me.tsSeco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsSeco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSeco.Name = "tsSeco"
        Me.tsSeco.Size = New System.Drawing.Size(114, 26)
        Me.tsSeco.Text = "seco"
        '
        'tsAspero
        '
        Me.tsAspero.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsAspero.Image = CType(resources.GetObject("tsAspero.Image"), System.Drawing.Image)
        Me.tsAspero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsAspero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAspero.Name = "tsAspero"
        Me.tsAspero.Size = New System.Drawing.Size(114, 26)
        Me.tsAspero.Text = "aspero"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Teal
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(393, 95)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmDescriptores_SaborBoca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 641)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtAgregarDescriptor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListaDescriptores)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1008, 680)
        Me.Name = "frmDescriptores_SaborBoca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sabor de boca - Catación Anei"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtAgregarDescriptor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListaDescriptores As System.Windows.Forms.ListBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsApagado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBalanceado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelicado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsLimpio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSucio As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEstructurado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDébil As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRápido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsProlongado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsLeve As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBlando As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsAstringente As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsJugoso As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsdeslucido As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRedondeado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSeco As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsAspero As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
End Class
