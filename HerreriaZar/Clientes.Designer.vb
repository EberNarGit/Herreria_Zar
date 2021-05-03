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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelMaterno = New System.Windows.Forms.Label()
        Me.LabelPaterno = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxMaterno = New System.Windows.Forms.TextBox()
        Me.TextBoxPaterno = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.BotonAñadir = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DGVClientes)
        Me.Panel1.Controls.Add(Me.LabelVentaEspe)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 453)
        Me.Panel1.TabIndex = 0
        '
        'DGVClientes
        '
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(40, 108)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.Size = New System.Drawing.Size(543, 268)
        Me.DGVClientes.TabIndex = 0
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelVentaEspe.Location = New System.Drawing.Point(81, 30)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(320, 39)
        Me.LabelVentaEspe.TabIndex = 3
        Me.LabelVentaEspe.Text = "Cátalogo de Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.Location = New System.Drawing.Point(672, 254)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(62, 19)
        Me.LabelTelefono.TabIndex = 5
        Me.LabelTelefono.Text = "Teléfono"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.Location = New System.Drawing.Point(672, 220)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(51, 19)
        Me.LabelCorreo.TabIndex = 6
        Me.LabelCorreo.Text = "Correo"
        '
        'LabelMaterno
        '
        Me.LabelMaterno.AutoSize = True
        Me.LabelMaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaterno.Location = New System.Drawing.Point(672, 186)
        Me.LabelMaterno.Name = "LabelMaterno"
        Me.LabelMaterno.Size = New System.Drawing.Size(62, 19)
        Me.LabelMaterno.TabIndex = 7
        Me.LabelMaterno.Text = "Materno"
        '
        'LabelPaterno
        '
        Me.LabelPaterno.AutoSize = True
        Me.LabelPaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaterno.Location = New System.Drawing.Point(672, 155)
        Me.LabelPaterno.Name = "LabelPaterno"
        Me.LabelPaterno.Size = New System.Drawing.Size(57, 19)
        Me.LabelPaterno.TabIndex = 8
        Me.LabelPaterno.Text = "Paterno"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(672, 123)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(60, 19)
        Me.LabelNombre.TabIndex = 9
        Me.LabelNombre.Text = "Nombre"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(779, 255)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxTelefono.TabIndex = 13
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreo.Location = New System.Drawing.Point(779, 221)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxCorreo.TabIndex = 14
        '
        'TextBoxMaterno
        '
        Me.TextBoxMaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMaterno.Location = New System.Drawing.Point(779, 187)
        Me.TextBoxMaterno.Name = "TextBoxMaterno"
        Me.TextBoxMaterno.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxMaterno.TabIndex = 15
        '
        'TextBoxPaterno
        '
        Me.TextBoxPaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaterno.Location = New System.Drawing.Point(779, 156)
        Me.TextBoxPaterno.Name = "TextBoxPaterno"
        Me.TextBoxPaterno.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxPaterno.TabIndex = 16
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(779, 124)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxNombre.TabIndex = 17
        '
        'BotonAñadir
        '
        Me.BotonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAñadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAñadir.ForeColor = System.Drawing.SystemColors.Control
        Me.BotonAñadir.Location = New System.Drawing.Point(676, 339)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(112, 37)
        Me.BotonAñadir.TabIndex = 18
        Me.BotonAñadir.Text = "Añadir"
        Me.BotonAñadir.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonEliminar.Location = New System.Drawing.Point(882, 339)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(112, 37)
        Me.ButtonEliminar.TabIndex = 19
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 450)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.BotonAñadir)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxPaterno)
        Me.Controls.Add(Me.TextBoxMaterno)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelPaterno)
        Me.Controls.Add(Me.LabelMaterno)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelMaterno As Label
    Friend WithEvents LabelPaterno As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxMaterno As TextBox
    Friend WithEvents TextBoxPaterno As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents ButtonEliminar As Button
End Class
