<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescriptores_Balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescriptores_Balance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.tsMordaz = New System.Windows.Forms.ToolStripButton()
        Me.tsJugoso = New System.Windows.Forms.ToolStripButton()
        Me.tsFresco = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.tsPenetrante = New System.Windows.Forms.ToolStripButton()
        Me.tsComplejo = New System.Windows.Forms.ToolStripButton()
        Me.tsRedondeado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsDesbalanceado = New System.Windows.Forms.ToolStripButton()
        Me.tsEspeso = New System.Windows.Forms.ToolStripButton()
        Me.tsBalanceado = New System.Windows.Forms.ToolStripButton()
        Me.tsAcentuado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsSilvestre = New System.Windows.Forms.ToolStripButton()
        Me.tsDense = New System.Windows.Forms.ToolStripButton()
        Me.tsEstructurado = New System.Windows.Forms.ToolStripButton()
        Me.tsInconsistente = New System.Windows.Forms.ToolStripButton()
        Me.txtAgregarDescriptor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListaDescriptores = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 54)
        Me.Panel1.TabIndex = 40
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
        Me.Panel2.Location = New System.Drawing.Point(153, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 501)
        Me.Panel2.TabIndex = 46
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMordaz, Me.tsJugoso, Me.tsFresco})
        Me.ToolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip4.Location = New System.Drawing.Point(530, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(84, 98)
        Me.ToolStrip4.TabIndex = 2
        Me.ToolStrip4.Text = "ToolStrip2"
        '
        'tsMordaz
        '
        Me.tsMordaz.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMordaz.Image = Global.Catación_Anei.My.Resources.Resources.silvestre
        Me.tsMordaz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsMordaz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMordaz.Name = "tsMordaz"
        Me.tsMordaz.Size = New System.Drawing.Size(82, 26)
        Me.tsMordaz.Text = "mordaz"
        '
        'tsJugoso
        '
        Me.tsJugoso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsJugoso.Image = Global.Catación_Anei.My.Resources.Resources.estructuado
        Me.tsJugoso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsJugoso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsJugoso.Name = "tsJugoso"
        Me.tsJugoso.Size = New System.Drawing.Size(82, 26)
        Me.tsJugoso.Text = "jugoso"
        '
        'tsFresco
        '
        Me.tsFresco.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsFresco.Image = Global.Catación_Anei.My.Resources.Resources.silvestre
        Me.tsFresco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsFresco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFresco.Name = "tsFresco"
        Me.tsFresco.Size = New System.Drawing.Size(82, 26)
        Me.tsFresco.Text = "fresco"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPenetrante, Me.tsComplejo, Me.tsRedondeado})
        Me.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip3.Location = New System.Drawing.Point(346, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(116, 98)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip2"
        '
        'tsPenetrante
        '
        Me.tsPenetrante.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPenetrante.Image = Global.Catación_Anei.My.Resources.Resources.silvestre
        Me.tsPenetrante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsPenetrante.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPenetrante.Name = "tsPenetrante"
        Me.tsPenetrante.Size = New System.Drawing.Size(114, 26)
        Me.tsPenetrante.Text = "penetrante"
        '
        'tsComplejo
        '
        Me.tsComplejo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsComplejo.Image = Global.Catación_Anei.My.Resources.Resources.dense
        Me.tsComplejo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsComplejo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsComplejo.Name = "tsComplejo"
        Me.tsComplejo.Size = New System.Drawing.Size(114, 26)
        Me.tsComplejo.Text = "complejo"
        '
        'tsRedondeado
        '
        Me.tsRedondeado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsRedondeado.Image = Global.Catación_Anei.My.Resources.Resources.estructuado
        Me.tsRedondeado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsRedondeado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRedondeado.Name = "tsRedondeado"
        Me.tsRedondeado.Size = New System.Drawing.Size(114, 26)
        Me.tsRedondeado.Text = "redondeado"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDesbalanceado, Me.tsEspeso, Me.tsBalanceado, Me.tsAcentuado})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(175, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(135, 127)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'tsDesbalanceado
        '
        Me.tsDesbalanceado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDesbalanceado.Image = Global.Catación_Anei.My.Resources.Resources.desbalanceado
        Me.tsDesbalanceado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsDesbalanceado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDesbalanceado.Name = "tsDesbalanceado"
        Me.tsDesbalanceado.Size = New System.Drawing.Size(133, 26)
        Me.tsDesbalanceado.Text = "desbalanceado"
        '
        'tsEspeso
        '
        Me.tsEspeso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsEspeso.Image = Global.Catación_Anei.My.Resources.Resources.dense1
        Me.tsEspeso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsEspeso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEspeso.Name = "tsEspeso"
        Me.tsEspeso.Size = New System.Drawing.Size(133, 26)
        Me.tsEspeso.Text = "espeso"
        '
        'tsBalanceado
        '
        Me.tsBalanceado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBalanceado.Image = Global.Catación_Anei.My.Resources.Resources.estructuado
        Me.tsBalanceado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsBalanceado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBalanceado.Name = "tsBalanceado"
        Me.tsBalanceado.Size = New System.Drawing.Size(133, 26)
        Me.tsBalanceado.Text = "balanceado"
        '
        'tsAcentuado
        '
        Me.tsAcentuado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsAcentuado.Image = Global.Catación_Anei.My.Resources.Resources.dense
        Me.tsAcentuado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsAcentuado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAcentuado.Name = "tsAcentuado"
        Me.tsAcentuado.Size = New System.Drawing.Size(133, 26)
        Me.tsAcentuado.Text = "acentuado"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSilvestre, Me.tsDense, Me.tsEstructurado, Me.tsInconsistente})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(124, 127)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsSilvestre
        '
        Me.tsSilvestre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSilvestre.Image = Global.Catación_Anei.My.Resources.Resources.silvestre
        Me.tsSilvestre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsSilvestre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSilvestre.Name = "tsSilvestre"
        Me.tsSilvestre.Size = New System.Drawing.Size(122, 26)
        Me.tsSilvestre.Text = "silvestre"
        '
        'tsDense
        '
        Me.tsDense.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDense.Image = Global.Catación_Anei.My.Resources.Resources.dense
        Me.tsDense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsDense.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDense.Name = "tsDense"
        Me.tsDense.Size = New System.Drawing.Size(122, 26)
        Me.tsDense.Text = "dense"
        '
        'tsEstructurado
        '
        Me.tsEstructurado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsEstructurado.Image = Global.Catación_Anei.My.Resources.Resources.estructuado
        Me.tsEstructurado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsEstructurado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEstructurado.Name = "tsEstructurado"
        Me.tsEstructurado.Size = New System.Drawing.Size(122, 26)
        Me.tsEstructurado.Text = "estructurado"
        '
        'tsInconsistente
        '
        Me.tsInconsistente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsInconsistente.Image = Global.Catación_Anei.My.Resources.Resources.inconsistente
        Me.tsInconsistente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsInconsistente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsInconsistente.Name = "tsInconsistente"
        Me.tsInconsistente.Size = New System.Drawing.Size(122, 26)
        Me.tsInconsistente.Text = "inconsistente"
        '
        'txtAgregarDescriptor
        '
        Me.txtAgregarDescriptor.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgregarDescriptor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAgregarDescriptor.Location = New System.Drawing.Point(153, 99)
        Me.txtAgregarDescriptor.Name = "txtAgregarDescriptor"
        Me.txtAgregarDescriptor.Size = New System.Drawing.Size(234, 26)
        Me.txtAgregarDescriptor.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(146, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 35)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Balance"
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
        Me.ListaDescriptores.TabIndex = 42
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
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Descriptores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seleccionados"
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
        Me.btnAgregar.TabIndex = 45
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmDescriptores_Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAgregarDescriptor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListaDescriptores)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1008, 680)
        Me.Name = "frmDescriptores_Balance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance - Catación Anei"
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtAgregarDescriptor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListaDescriptores As System.Windows.Forms.ListBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsMordaz As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsJugoso As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsFresco As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsPenetrante As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsComplejo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRedondeado As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsDesbalanceado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEspeso As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBalanceado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsAcentuado As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSilvestre As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDense As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEstructurado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsInconsistente As System.Windows.Forms.ToolStripButton
End Class
