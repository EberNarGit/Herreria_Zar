<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirProducto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSelect_img = New System.Windows.Forms.Button()
        Me.ButtonAñadir = New System.Windows.Forms.Button()
        Me.LabelP = New System.Windows.Forms.Label()
        Me.TextBoxDescripción = New System.Windows.Forms.TextBox()
        Me.LabelCategoria = New System.Windows.Forms.Label()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TextBoxid = New System.Windows.Forms.TextBox()
        Me.ejemplo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ComboBoxCategoria)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonSelect_img)
        Me.Panel1.Controls.Add(Me.ButtonAñadir)
        Me.Panel1.Controls.Add(Me.LabelP)
        Me.Panel1.Controls.Add(Me.TextBoxDescripción)
        Me.Panel1.Controls.Add(Me.LabelCategoria)
        Me.Panel1.Controls.Add(Me.LabelDescripcion)
        Me.Panel1.Controls.Add(Me.TextBoxid)
        Me.Panel1.Controls.Add(Me.ejemplo)
        Me.Panel1.Location = New System.Drawing.Point(40, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 429)
        Me.Panel1.TabIndex = 0
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(181, 98)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(391, 21)
        Me.ComboBoxCategoria.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(637, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'ButtonSelect_img
        '
        Me.ButtonSelect_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonSelect_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelect_img.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelect_img.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSelect_img.Location = New System.Drawing.Point(657, 334)
        Me.ButtonSelect_img.Name = "ButtonSelect_img"
        Me.ButtonSelect_img.Size = New System.Drawing.Size(176, 54)
        Me.ButtonSelect_img.TabIndex = 32
        Me.ButtonSelect_img.Text = "Seleccionar Imagen"
        Me.ButtonSelect_img.UseVisualStyleBackColor = False
        '
        'ButtonAñadir
        '
        Me.ButtonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAñadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAñadir.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonAñadir.Location = New System.Drawing.Point(436, 334)
        Me.ButtonAñadir.Name = "ButtonAñadir"
        Me.ButtonAñadir.Size = New System.Drawing.Size(176, 54)
        Me.ButtonAñadir.TabIndex = 31
        Me.ButtonAñadir.Text = "Añadir"
        Me.ButtonAñadir.UseVisualStyleBackColor = False
        '
        'LabelP
        '
        Me.LabelP.AutoSize = True
        Me.LabelP.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelP.Location = New System.Drawing.Point(19, 23)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(284, 42)
        Me.LabelP.TabIndex = 30
        Me.LabelP.Text = "Añadir Producto"
        '
        'TextBoxDescripción
        '
        Me.TextBoxDescripción.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxDescripción.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDescripción.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescripción.Location = New System.Drawing.Point(181, 134)
        Me.TextBoxDescripción.Multiline = True
        Me.TextBoxDescripción.Name = "TextBoxDescripción"
        Me.TextBoxDescripción.Size = New System.Drawing.Size(391, 134)
        Me.TextBoxDescripción.TabIndex = 27
        '
        'LabelCategoria
        '
        Me.LabelCategoria.AutoSize = True
        Me.LabelCategoria.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria.Location = New System.Drawing.Point(22, 98)
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(68, 19)
        Me.LabelCategoria.TabIndex = 2
        Me.LabelCategoria.Text = "Categoria"
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(22, 133)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(81, 19)
        Me.LabelDescripcion.TabIndex = 1
        Me.LabelDescripcion.Text = "Descripción"
        '
        'TextBoxid
        '
        Me.TextBoxid.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxid.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxid.Location = New System.Drawing.Point(418, 221)
        Me.TextBoxid.Name = "TextBoxid"
        Me.TextBoxid.Size = New System.Drawing.Size(73, 21)
        Me.TextBoxid.TabIndex = 42
        '
        'ejemplo
        '
        Me.ejemplo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ejemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ejemplo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ejemplo.Location = New System.Drawing.Point(309, 221)
        Me.ejemplo.Name = "ejemplo"
        Me.ejemplo.Size = New System.Drawing.Size(73, 21)
        Me.ejemplo.TabIndex = 43
        '
        'AñadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AñadirProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelCategoria As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TextBoxDescripción As TextBox
    Friend WithEvents LabelP As Label
    Friend WithEvents ButtonAñadir As Button
    Friend WithEvents ButtonSelect_img As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents TextBoxid As TextBox
    Friend WithEvents ejemplo As TextBox
End Class
