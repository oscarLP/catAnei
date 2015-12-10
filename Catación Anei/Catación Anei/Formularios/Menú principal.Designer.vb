<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNombreUsuario = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsPerfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCambiarContraseña = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCerrarSesión = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTutoriales = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsProveedores = New System.Windows.Forms.ToolStripButton()
        Me.tsProductores = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsultasYEstadisticas = New System.Windows.Forms.Button()
        Me.btnRealizarCataciones = New System.Windows.Forms.Button()
        Me.btnGestionarCatadores = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tsCiudades = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 77)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(117, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 40)
        Me.Label3.TabIndex = 5
        Me.Label3.Tag = ""
        Me.Label3.Text = "Catación Anei"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Location = New System.Drawing.Point(93, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 50)
        Me.Panel2.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNombreUsuario, Me.tsTutoriales, Me.tsProveedores, Me.tsProductores, Me.tsCiudades})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(763, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNombreUsuario
        '
        Me.tsNombreUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsNombreUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPerfil, Me.tsCambiarContraseña, Me.tsCerrarSesión})
        Me.tsNombreUsuario.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsNombreUsuario.ForeColor = System.Drawing.Color.Teal
        Me.tsNombreUsuario.Image = Global.Catación_Anei.My.Resources.Resources.Usuario_32x32
        Me.tsNombreUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNombreUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNombreUsuario.Name = "tsNombreUsuario"
        Me.tsNombreUsuario.Size = New System.Drawing.Size(107, 36)
        Me.tsNombreUsuario.Text = "Usuario"
        '
        'tsPerfil
        '
        Me.tsPerfil.Image = Global.Catación_Anei.My.Resources.Resources.Administrador_16x16
        Me.tsPerfil.Name = "tsPerfil"
        Me.tsPerfil.Size = New System.Drawing.Size(220, 26)
        Me.tsPerfil.Text = "Perfil"
        '
        'tsCambiarContraseña
        '
        Me.tsCambiarContraseña.Image = Global.Catación_Anei.My.Resources.Resources.Contraseña_16x16
        Me.tsCambiarContraseña.Name = "tsCambiarContraseña"
        Me.tsCambiarContraseña.Size = New System.Drawing.Size(220, 26)
        Me.tsCambiarContraseña.Text = "Cambiar contraseña"
        '
        'tsCerrarSesión
        '
        Me.tsCerrarSesión.Image = Global.Catación_Anei.My.Resources.Resources.Cerrar_sesion
        Me.tsCerrarSesión.Name = "tsCerrarSesión"
        Me.tsCerrarSesión.Size = New System.Drawing.Size(220, 26)
        Me.tsCerrarSesión.Text = "Cerrar sesión"
        '
        'tsTutoriales
        '
        Me.tsTutoriales.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsTutoriales.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsTutoriales.Image = Global.Catación_Anei.My.Resources.Resources.Tutoriales_24x24
        Me.tsTutoriales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsTutoriales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTutoriales.Name = "tsTutoriales"
        Me.tsTutoriales.Size = New System.Drawing.Size(118, 36)
        Me.tsTutoriales.Text = "Tutoriales"
        '
        'tsProveedores
        '
        Me.tsProveedores.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsProveedores.Image = Global.Catación_Anei.My.Resources.Resources.Proveedor
        Me.tsProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsProveedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsProveedores.Name = "tsProveedores"
        Me.tsProveedores.Size = New System.Drawing.Size(127, 36)
        Me.tsProveedores.Text = "Proveedores"
        '
        'tsProductores
        '
        Me.tsProductores.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsProductores.Image = Global.Catación_Anei.My.Resources.Resources.Productor
        Me.tsProductores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsProductores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsProductores.Name = "tsProductores"
        Me.tsProductores.Size = New System.Drawing.Size(122, 36)
        Me.tsProductores.Text = "Productores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnConsultasYEstadisticas)
        Me.GroupBox1.Controls.Add(Me.btnRealizarCataciones)
        Me.GroupBox1.Controls.Add(Me.btnGestionarCatadores)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 275)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿Qué desea hacer?"
        '
        'btnConsultasYEstadisticas
        '
        Me.btnConsultasYEstadisticas.BackColor = System.Drawing.Color.Transparent
        Me.btnConsultasYEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultasYEstadisticas.FlatAppearance.BorderSize = 0
        Me.btnConsultasYEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConsultasYEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConsultasYEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultasYEstadisticas.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultasYEstadisticas.Image = Global.Catación_Anei.My.Resources.Resources.Consultas_y_estadisticas_128x128
        Me.btnConsultasYEstadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultasYEstadisticas.Location = New System.Drawing.Point(506, 30)
        Me.btnConsultasYEstadisticas.Name = "btnConsultasYEstadisticas"
        Me.btnConsultasYEstadisticas.Size = New System.Drawing.Size(188, 220)
        Me.btnConsultasYEstadisticas.TabIndex = 3
        Me.btnConsultasYEstadisticas.Text = "CONSULTAS Y ESTADÍSTICAS"
        Me.btnConsultasYEstadisticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultasYEstadisticas.UseVisualStyleBackColor = False
        '
        'btnRealizarCataciones
        '
        Me.btnRealizarCataciones.BackColor = System.Drawing.Color.Transparent
        Me.btnRealizarCataciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRealizarCataciones.FlatAppearance.BorderSize = 0
        Me.btnRealizarCataciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRealizarCataciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRealizarCataciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarCataciones.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarCataciones.Image = Global.Catación_Anei.My.Resources.Resources.Realizar_cataciones_128x128
        Me.btnRealizarCataciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRealizarCataciones.Location = New System.Drawing.Point(260, 30)
        Me.btnRealizarCataciones.Name = "btnRealizarCataciones"
        Me.btnRealizarCataciones.Size = New System.Drawing.Size(188, 220)
        Me.btnRealizarCataciones.TabIndex = 2
        Me.btnRealizarCataciones.Text = "REALIZAR CATACIONES"
        Me.btnRealizarCataciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRealizarCataciones.UseVisualStyleBackColor = False
        '
        'btnGestionarCatadores
        '
        Me.btnGestionarCatadores.BackColor = System.Drawing.Color.Transparent
        Me.btnGestionarCatadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionarCatadores.FlatAppearance.BorderSize = 0
        Me.btnGestionarCatadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGestionarCatadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGestionarCatadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionarCatadores.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionarCatadores.Image = Global.Catación_Anei.My.Resources.Resources.Gestionar_catadores_128x128
        Me.btnGestionarCatadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGestionarCatadores.Location = New System.Drawing.Point(11, 30)
        Me.btnGestionarCatadores.Name = "btnGestionarCatadores"
        Me.btnGestionarCatadores.Size = New System.Drawing.Size(188, 220)
        Me.btnGestionarCatadores.TabIndex = 1
        Me.btnGestionarCatadores.Text = "GESTIONAR CATADORES"
        Me.btnGestionarCatadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGestionarCatadores.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Catación_Anei.My.Resources.Resources.Logotipo_98x63
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 63)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'tsCiudades
        '
        Me.tsCiudades.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsCiudades.Image = Global.Catación_Anei.My.Resources.Resources.Ciudad_24x24
        Me.tsCiudades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCiudades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCiudades.Name = "tsCiudades"
        Me.tsCiudades.Size = New System.Drawing.Size(102, 36)
        Me.tsCiudades.Text = "Ciudades"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Catación_Anei.My.Resources.Resources.Fondo___Menú_principal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 641)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1008, 680)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal - Catación Anei"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsTutoriales As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsNombreUsuario As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsCerrarSesión As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGestionarCatadores As System.Windows.Forms.Button
    Friend WithEvents btnConsultasYEstadisticas As System.Windows.Forms.Button
    Friend WithEvents btnRealizarCataciones As System.Windows.Forms.Button
    Friend WithEvents tsCambiarContraseña As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsProveedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsProductores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPerfil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCiudades As System.Windows.Forms.ToolStripButton
End Class
