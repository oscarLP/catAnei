<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescriptores_Cuerpo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescriptores_Cuerpo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsLigero = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsAguado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsComoTé = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSedoso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsResbaladizo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsJugoso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMedio = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsSuave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts2Leche = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAlmibarado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRedondo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMCremoso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsGredoso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCremoso = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsLleno = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAterciopelado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsGrande = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsVigoroso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRevestimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAceitoso = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtAgregarDescriptor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListaDescriptores = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Location = New System.Drawing.Point(153, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 501)
        Me.Panel2.TabIndex = 46
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLigero, Me.tsMedio, Me.tsCremoso})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(103, 98)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsLigero
        '
        Me.tsLigero.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAguado, Me.tsComoTé, Me.tsSedoso, Me.tsResbaladizo, Me.tsJugoso})
        Me.tsLigero.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsLigero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsLigero.Image = Global.Catación_Anei.My.Resources.Resources.ligero
        Me.tsLigero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsLigero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLigero.Name = "tsLigero"
        Me.tsLigero.Size = New System.Drawing.Size(101, 26)
        Me.tsLigero.Text = "ligero"
        Me.tsLigero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsAguado
        '
        Me.tsAguado.Image = Global.Catación_Anei.My.Resources.Resources.ligero1
        Me.tsAguado.Name = "tsAguado"
        Me.tsAguado.Size = New System.Drawing.Size(161, 26)
        Me.tsAguado.Text = "aguado"
        '
        'tsComoTé
        '
        Me.tsComoTé.Image = CType(resources.GetObject("tsComoTé.Image"), System.Drawing.Image)
        Me.tsComoTé.Name = "tsComoTé"
        Me.tsComoTé.Size = New System.Drawing.Size(161, 26)
        Me.tsComoTé.Text = "como té"
        '
        'tsSedoso
        '
        Me.tsSedoso.Image = CType(resources.GetObject("tsSedoso.Image"), System.Drawing.Image)
        Me.tsSedoso.Name = "tsSedoso"
        Me.tsSedoso.Size = New System.Drawing.Size(161, 26)
        Me.tsSedoso.Text = "sedoso"
        '
        'tsResbaladizo
        '
        Me.tsResbaladizo.Image = CType(resources.GetObject("tsResbaladizo.Image"), System.Drawing.Image)
        Me.tsResbaladizo.Name = "tsResbaladizo"
        Me.tsResbaladizo.Size = New System.Drawing.Size(161, 26)
        Me.tsResbaladizo.Text = "resbaladizo"
        '
        'tsJugoso
        '
        Me.tsJugoso.Image = CType(resources.GetObject("tsJugoso.Image"), System.Drawing.Image)
        Me.tsJugoso.Name = "tsJugoso"
        Me.tsJugoso.Size = New System.Drawing.Size(161, 26)
        Me.tsJugoso.Text = "jugoso"
        '
        'tsMedio
        '
        Me.tsMedio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSuave, Me.ts2Leche, Me.tsAlmibarado, Me.tsRedondo, Me.tsMCremoso, Me.tsGredoso})
        Me.tsMedio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMedio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMedio.Image = Global.Catación_Anei.My.Resources.Resources.medio
        Me.tsMedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsMedio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMedio.Name = "tsMedio"
        Me.tsMedio.Size = New System.Drawing.Size(101, 26)
        Me.tsMedio.Text = "medio"
        '
        'tsSuave
        '
        Me.tsSuave.Image = CType(resources.GetObject("tsSuave.Image"), System.Drawing.Image)
        Me.tsSuave.Name = "tsSuave"
        Me.tsSuave.Size = New System.Drawing.Size(159, 26)
        Me.tsSuave.Text = "suave"
        '
        'ts2Leche
        '
        Me.ts2Leche.Image = CType(resources.GetObject("ts2Leche.Image"), System.Drawing.Image)
        Me.ts2Leche.Name = "ts2Leche"
        Me.ts2Leche.Size = New System.Drawing.Size(159, 26)
        Me.ts2Leche.Text = "2% leche"
        '
        'tsAlmibarado
        '
        Me.tsAlmibarado.Image = CType(resources.GetObject("tsAlmibarado.Image"), System.Drawing.Image)
        Me.tsAlmibarado.Name = "tsAlmibarado"
        Me.tsAlmibarado.Size = New System.Drawing.Size(159, 26)
        Me.tsAlmibarado.Text = "almibarado"
        '
        'tsRedondo
        '
        Me.tsRedondo.Image = CType(resources.GetObject("tsRedondo.Image"), System.Drawing.Image)
        Me.tsRedondo.Name = "tsRedondo"
        Me.tsRedondo.Size = New System.Drawing.Size(159, 26)
        Me.tsRedondo.Text = "redondo"
        '
        'tsMCremoso
        '
        Me.tsMCremoso.Image = CType(resources.GetObject("tsMCremoso.Image"), System.Drawing.Image)
        Me.tsMCremoso.Name = "tsMCremoso"
        Me.tsMCremoso.Size = New System.Drawing.Size(159, 26)
        Me.tsMCremoso.Text = "cremoso"
        '
        'tsGredoso
        '
        Me.tsGredoso.Image = CType(resources.GetObject("tsGredoso.Image"), System.Drawing.Image)
        Me.tsGredoso.Name = "tsGredoso"
        Me.tsGredoso.Size = New System.Drawing.Size(159, 26)
        Me.tsGredoso.Text = "gredoso"
        '
        'tsCremoso
        '
        Me.tsCremoso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLleno, Me.tsAterciopelado, Me.tsGrande, Me.tsVigoroso, Me.tsRevestimiento, Me.tsAceitoso})
        Me.tsCremoso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsCremoso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsCremoso.Image = Global.Catación_Anei.My.Resources.Resources.cremoso
        Me.tsCremoso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsCremoso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCremoso.Name = "tsCremoso"
        Me.tsCremoso.Size = New System.Drawing.Size(101, 26)
        Me.tsCremoso.Text = "cremoso"
        '
        'tsLleno
        '
        Me.tsLleno.Image = CType(resources.GetObject("tsLleno.Image"), System.Drawing.Image)
        Me.tsLleno.Name = "tsLleno"
        Me.tsLleno.Size = New System.Drawing.Size(180, 26)
        Me.tsLleno.Text = "lleno"
        '
        'tsAterciopelado
        '
        Me.tsAterciopelado.Image = CType(resources.GetObject("tsAterciopelado.Image"), System.Drawing.Image)
        Me.tsAterciopelado.Name = "tsAterciopelado"
        Me.tsAterciopelado.Size = New System.Drawing.Size(180, 26)
        Me.tsAterciopelado.Text = "aterciopelado"
        '
        'tsGrande
        '
        Me.tsGrande.Image = CType(resources.GetObject("tsGrande.Image"), System.Drawing.Image)
        Me.tsGrande.Name = "tsGrande"
        Me.tsGrande.Size = New System.Drawing.Size(180, 26)
        Me.tsGrande.Text = "grande"
        '
        'tsVigoroso
        '
        Me.tsVigoroso.Image = CType(resources.GetObject("tsVigoroso.Image"), System.Drawing.Image)
        Me.tsVigoroso.Name = "tsVigoroso"
        Me.tsVigoroso.Size = New System.Drawing.Size(180, 26)
        Me.tsVigoroso.Text = "vigoroso"
        '
        'tsRevestimiento
        '
        Me.tsRevestimiento.Image = CType(resources.GetObject("tsRevestimiento.Image"), System.Drawing.Image)
        Me.tsRevestimiento.Name = "tsRevestimiento"
        Me.tsRevestimiento.Size = New System.Drawing.Size(180, 26)
        Me.tsRevestimiento.Text = "revestimiento"
        '
        'tsAceitoso
        '
        Me.tsAceitoso.Image = CType(resources.GetObject("tsAceitoso.Image"), System.Drawing.Image)
        Me.tsAceitoso.Name = "tsAceitoso"
        Me.tsAceitoso.Size = New System.Drawing.Size(180, 26)
        Me.tsAceitoso.Text = "aceitoso"
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
        Me.Label3.Size = New System.Drawing.Size(101, 35)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Cuerpo"
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
        'frmDescriptores_Cuerpo
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
        Me.Name = "frmDescriptores_Cuerpo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuerpo - Catación Anei"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsLigero As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsAguado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsComoTé As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSedoso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMedio As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsSuave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts2Leche As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAlmibarado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRedondo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMCremoso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsGredoso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsResbaladizo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsJugoso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCremoso As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsLleno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAterciopelado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsGrande As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsVigoroso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRevestimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAceitoso As System.Windows.Forms.ToolStripMenuItem
End Class
