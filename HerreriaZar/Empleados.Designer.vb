<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVusuarios = New System.Windows.Forms.DataGridView()
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BotonAñadir = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPaterno = New System.Windows.Forms.TextBox()
        Me.TextBoxMaterno = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxCon = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelPaterno = New System.Windows.Forms.Label()
        Me.LabelMaterno = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DGVusuarios)
        Me.Panel1.Controls.Add(Me.LabelVentaEspe)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 559)
        Me.Panel1.TabIndex = 1
        '
        'DGVusuarios
        '
        Me.DGVusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVusuarios.Location = New System.Drawing.Point(53, 133)
        Me.DGVusuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVusuarios.Name = "DGVusuarios"
        Me.DGVusuarios.RowHeadersWidth = 51
        Me.DGVusuarios.Size = New System.Drawing.Size(585, 330)
        Me.DGVusuarios.TabIndex = 0
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelVentaEspe.Location = New System.Drawing.Point(127, 37)
        Me.LabelVentaEspe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(225, 50)
        Me.LabelVentaEspe.TabIndex = 3
        Me.LabelVentaEspe.Text = "Empleados"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BotonAñadir
        '
        Me.BotonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAñadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAñadir.ForeColor = System.Drawing.SystemColors.Control
        Me.BotonAñadir.Location = New System.Drawing.Point(831, 417)
        Me.BotonAñadir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(111, 46)
        Me.BotonAñadir.TabIndex = 32
        Me.BotonAñadir.Text = "Añadir"
        Me.BotonAñadir.UseVisualStyleBackColor = False
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(969, 186)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(286, 25)
        Me.TextBoxNombre.TabIndex = 31
        '
        'TextBoxPaterno
        '
        Me.TextBoxPaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaterno.Location = New System.Drawing.Point(969, 226)
        Me.TextBoxPaterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxPaterno.Name = "TextBoxPaterno"
        Me.TextBoxPaterno.Size = New System.Drawing.Size(286, 25)
        Me.TextBoxPaterno.TabIndex = 30
        '
        'TextBoxMaterno
        '
        Me.TextBoxMaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMaterno.Location = New System.Drawing.Point(969, 263)
        Me.TextBoxMaterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxMaterno.Name = "TextBoxMaterno"
        Me.TextBoxMaterno.Size = New System.Drawing.Size(286, 25)
        Me.TextBoxMaterno.TabIndex = 29
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuario.Location = New System.Drawing.Point(969, 306)
        Me.TextBoxUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(286, 25)
        Me.TextBoxUsuario.TabIndex = 28
        '
        'TextBoxCon
        '
        Me.TextBoxCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCon.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCon.Location = New System.Drawing.Point(969, 348)
        Me.TextBoxCon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxCon.Name = "TextBoxCon"
        Me.TextBoxCon.Size = New System.Drawing.Size(286, 25)
        Me.TextBoxCon.TabIndex = 27
        Me.TextBoxCon.UseSystemPasswordChar = True
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(827, 185)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(78, 23)
        Me.LabelNombre.TabIndex = 25
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelPaterno
        '
        Me.LabelPaterno.AutoSize = True
        Me.LabelPaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaterno.Location = New System.Drawing.Point(827, 225)
        Me.LabelPaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPaterno.Name = "LabelPaterno"
        Me.LabelPaterno.Size = New System.Drawing.Size(72, 23)
        Me.LabelPaterno.TabIndex = 24
        Me.LabelPaterno.Text = "Paterno"
        '
        'LabelMaterno
        '
        Me.LabelMaterno.AutoSize = True
        Me.LabelMaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaterno.Location = New System.Drawing.Point(827, 263)
        Me.LabelMaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMaterno.Name = "LabelMaterno"
        Me.LabelMaterno.Size = New System.Drawing.Size(79, 23)
        Me.LabelMaterno.TabIndex = 23
        Me.LabelMaterno.Text = "Materno"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.Location = New System.Drawing.Point(827, 305)
        Me.LabelUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(72, 23)
        Me.LabelUsuario.TabIndex = 22
        Me.LabelUsuario.Text = "Usuario"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass.Location = New System.Drawing.Point(827, 346)
        Me.LabelPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(100, 23)
        Me.LabelPass.TabIndex = 21
        Me.LabelPass.Text = "Contraseña"
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonModificar.Location = New System.Drawing.Point(973, 417)
        Me.ButtonModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(143, 46)
        Me.ButtonModificar.TabIndex = 34
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonEliminar.Location = New System.Drawing.Point(1145, 417)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(119, 46)
        Me.ButtonEliminar.TabIndex = 33
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1299, 554)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.BotonAñadir)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxPaterno)
        Me.Controls.Add(Me.TextBoxMaterno)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.TextBoxCon)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelPaterno)
        Me.Controls.Add(Me.LabelMaterno)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.LabelPass)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Empleados"
        Me.Text = "Administración de Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVusuarios As DataGridView
    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPaterno As TextBox
    Friend WithEvents TextBoxMaterno As TextBox
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxCon As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelPaterno As Label
    Friend WithEvents LabelMaterno As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
End Class
