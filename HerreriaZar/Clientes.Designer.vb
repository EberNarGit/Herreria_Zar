﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.ejemplo = New System.Windows.Forms.TextBox()
        Me.TextBoxid = New System.Windows.Forms.TextBox()
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
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.TextBoxRFC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelVentaEspe)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DGVClientes)
        Me.Panel1.Location = New System.Drawing.Point(-7, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 558)
        Me.Panel1.TabIndex = 0
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelVentaEspe.Location = New System.Drawing.Point(108, 37)
        Me.LabelVentaEspe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(405, 50)
        Me.LabelVentaEspe.TabIndex = 3
        Me.LabelVentaEspe.Text = "Cátalogo de Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DGVClientes
        '
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(52, 82)
        Me.DGVClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.RowHeadersWidth = 51
        Me.DGVClientes.Size = New System.Drawing.Size(724, 330)
        Me.DGVClientes.TabIndex = 0
        '
        'ejemplo
        '
        Me.ejemplo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ejemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ejemplo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ejemplo.Location = New System.Drawing.Point(879, 387)
        Me.ejemplo.Margin = New System.Windows.Forms.Padding(4)
        Me.ejemplo.Name = "ejemplo"
        Me.ejemplo.Size = New System.Drawing.Size(103, 25)
        Me.ejemplo.TabIndex = 41
        '
        'TextBoxid
        '
        Me.TextBoxid.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxid.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxid.Location = New System.Drawing.Point(879, 354)
        Me.TextBoxid.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxid.Name = "TextBoxid"
        Me.TextBoxid.Size = New System.Drawing.Size(103, 25)
        Me.TextBoxid.TabIndex = 40
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.Location = New System.Drawing.Point(884, 244)
        Me.LabelTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(83, 23)
        Me.LabelTelefono.TabIndex = 5
        Me.LabelTelefono.Text = "Teléfono"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.Location = New System.Drawing.Point(884, 202)
        Me.LabelCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(65, 23)
        Me.LabelCorreo.TabIndex = 6
        Me.LabelCorreo.Text = "Correo"
        '
        'LabelMaterno
        '
        Me.LabelMaterno.AutoSize = True
        Me.LabelMaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaterno.Location = New System.Drawing.Point(884, 160)
        Me.LabelMaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMaterno.Name = "LabelMaterno"
        Me.LabelMaterno.Size = New System.Drawing.Size(79, 23)
        Me.LabelMaterno.TabIndex = 7
        Me.LabelMaterno.Text = "Materno"
        '
        'LabelPaterno
        '
        Me.LabelPaterno.AutoSize = True
        Me.LabelPaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaterno.Location = New System.Drawing.Point(884, 122)
        Me.LabelPaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPaterno.Name = "LabelPaterno"
        Me.LabelPaterno.Size = New System.Drawing.Size(72, 23)
        Me.LabelPaterno.TabIndex = 8
        Me.LabelPaterno.Text = "Paterno"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(884, 82)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(78, 23)
        Me.LabelNombre.TabIndex = 9
        Me.LabelNombre.Text = "Nombre"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(1027, 245)
        Me.TextBoxTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(300, 25)
        Me.TextBoxTelefono.TabIndex = 13
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreo.Location = New System.Drawing.Point(1027, 203)
        Me.TextBoxCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(300, 25)
        Me.TextBoxCorreo.TabIndex = 14
        '
        'TextBoxMaterno
        '
        Me.TextBoxMaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMaterno.Location = New System.Drawing.Point(1027, 161)
        Me.TextBoxMaterno.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxMaterno.Name = "TextBoxMaterno"
        Me.TextBoxMaterno.Size = New System.Drawing.Size(300, 25)
        Me.TextBoxMaterno.TabIndex = 15
        '
        'TextBoxPaterno
        '
        Me.TextBoxPaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPaterno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaterno.Location = New System.Drawing.Point(1027, 123)
        Me.TextBoxPaterno.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPaterno.Name = "TextBoxPaterno"
        Me.TextBoxPaterno.Size = New System.Drawing.Size(300, 25)
        Me.TextBoxPaterno.TabIndex = 16
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(1027, 84)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(300, 25)
        Me.TextBoxNombre.TabIndex = 17
        '
        'BotonAñadir
        '
        Me.BotonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAñadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAñadir.ForeColor = System.Drawing.SystemColors.Control
        Me.BotonAñadir.Location = New System.Drawing.Point(1027, 359)
        Me.BotonAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(149, 46)
        Me.BotonAñadir.TabIndex = 18
        Me.BotonAñadir.Text = "Añadir"
        Me.BotonAñadir.UseVisualStyleBackColor = False
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonModificar.Location = New System.Drawing.Point(1184, 359)
        Me.ButtonModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(143, 46)
        Me.ButtonModificar.TabIndex = 35
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'TextBoxRFC
        '
        Me.TextBoxRFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRFC.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRFC.Location = New System.Drawing.Point(1027, 289)
        Me.TextBoxRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxRFC.Name = "TextBoxRFC"
        Me.TextBoxRFC.Size = New System.Drawing.Size(300, 25)
        Me.TextBoxRFC.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(884, 288)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "RFC"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1384, 453)
        Me.Controls.Add(Me.TextBoxRFC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxid)
        Me.Controls.Add(Me.ejemplo)
        Me.Controls.Add(Me.ButtonModificar)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents TextBoxRFC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxid As TextBox
    Friend WithEvents ejemplo As TextBox
End Class
