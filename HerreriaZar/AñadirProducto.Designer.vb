<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirProducto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonAñadir = New System.Windows.Forms.Button()
        Me.LabelP = New System.Windows.Forms.Label()
        Me.TextBoxImagen = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripción = New System.Windows.Forms.TextBox()
        Me.LabelImagen = New System.Windows.Forms.Label()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ButtonAñadir)
        Me.Panel1.Controls.Add(Me.LabelP)
        Me.Panel1.Controls.Add(Me.TextBoxImagen)
        Me.Panel1.Controls.Add(Me.TextBoxDescripción)
        Me.Panel1.Controls.Add(Me.LabelImagen)
        Me.Panel1.Controls.Add(Me.LabelDescripcion)
        Me.Panel1.Location = New System.Drawing.Point(157, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 323)
        Me.Panel1.TabIndex = 0
        '
        'ButtonAñadir
        '
        Me.ButtonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAñadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAñadir.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonAñadir.Location = New System.Drawing.Point(166, 217)
        Me.ButtonAñadir.Name = "ButtonAñadir"
        Me.ButtonAñadir.Size = New System.Drawing.Size(176, 40)
        Me.ButtonAñadir.TabIndex = 31
        Me.ButtonAñadir.Text = "Añadir"
        Me.ButtonAñadir.UseVisualStyleBackColor = False
        '
        'LabelP
        '
        Me.LabelP.AutoSize = True
        Me.LabelP.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelP.Location = New System.Drawing.Point(111, 31)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(284, 42)
        Me.LabelP.TabIndex = 30
        Me.LabelP.Text = "Añadir Producto"
        '
        'TextBoxImagen
        '
        Me.TextBoxImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxImagen.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxImagen.Location = New System.Drawing.Point(242, 117)
        Me.TextBoxImagen.Name = "TextBoxImagen"
        Me.TextBoxImagen.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxImagen.TabIndex = 28
        '
        'TextBoxDescripción
        '
        Me.TextBoxDescripción.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxDescripción.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDescripción.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescripción.Location = New System.Drawing.Point(242, 156)
        Me.TextBoxDescripción.Name = "TextBoxDescripción"
        Me.TextBoxDescripción.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxDescripción.TabIndex = 27
        '
        'LabelImagen
        '
        Me.LabelImagen.AutoSize = True
        Me.LabelImagen.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelImagen.Location = New System.Drawing.Point(59, 116)
        Me.LabelImagen.Name = "LabelImagen"
        Me.LabelImagen.Size = New System.Drawing.Size(149, 19)
        Me.LabelImagen.TabIndex = 2
        Me.LabelImagen.Text = "Dirección de la imagen"
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(59, 156)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(81, 19)
        Me.LabelDescripcion.TabIndex = 1
        Me.LabelDescripcion.Text = "Descripción"
        '
        'AñadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AñadirProducto"
        Me.Text = "Añadir Producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelImagen As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TextBoxImagen As TextBox
    Friend WithEvents TextBoxDescripción As TextBox
    Friend WithEvents LabelP As Label
    Friend WithEvents ButtonAñadir As Button
End Class
