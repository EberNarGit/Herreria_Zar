<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaEspecifica
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
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.LabelAlto = New System.Windows.Forms.Label()
        Me.LabelLargo = New System.Windows.Forms.Label()
        Me.LabelAncho = New System.Windows.Forms.Label()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.LabelOtro = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelProductos = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxOtro = New System.Windows.Forms.TextBox()
        Me.TextBoxProductos = New System.Windows.Forms.TextBox()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.TextBoxAncho = New System.Windows.Forms.TextBox()
        Me.TextBoxLargo = New System.Windows.Forms.TextBox()
        Me.TextBoxAlto = New System.Windows.Forms.TextBox()
        Me.BotonSiguiente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LabelVentaEspe.Location = New System.Drawing.Point(33, 23)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(256, 39)
        Me.LabelVentaEspe.TabIndex = 2
        Me.LabelVentaEspe.Text = "Venta Específica"
        '
        'LabelAlto
        '
        Me.LabelAlto.AutoSize = True
        Me.LabelAlto.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlto.Location = New System.Drawing.Point(36, 135)
        Me.LabelAlto.Name = "LabelAlto"
        Me.LabelAlto.Size = New System.Drawing.Size(34, 19)
        Me.LabelAlto.TabIndex = 4
        Me.LabelAlto.Text = "Alto"
        '
        'LabelLargo
        '
        Me.LabelLargo.AutoSize = True
        Me.LabelLargo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLargo.Location = New System.Drawing.Point(36, 170)
        Me.LabelLargo.Name = "LabelLargo"
        Me.LabelLargo.Size = New System.Drawing.Size(44, 19)
        Me.LabelLargo.TabIndex = 5
        Me.LabelLargo.Text = "Largo"
        '
        'LabelAncho
        '
        Me.LabelAncho.AutoSize = True
        Me.LabelAncho.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAncho.Location = New System.Drawing.Point(36, 202)
        Me.LabelAncho.Name = "LabelAncho"
        Me.LabelAncho.Size = New System.Drawing.Size(49, 19)
        Me.LabelAncho.TabIndex = 6
        Me.LabelAncho.Text = "Ancho"
        '
        'LabelColor
        '
        Me.LabelColor.AutoSize = True
        Me.LabelColor.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelColor.Location = New System.Drawing.Point(36, 235)
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(42, 19)
        Me.LabelColor.TabIndex = 7
        Me.LabelColor.Text = "Color"
        '
        'LabelOtro
        '
        Me.LabelOtro.AutoSize = True
        Me.LabelOtro.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOtro.Location = New System.Drawing.Point(36, 267)
        Me.LabelOtro.Name = "LabelOtro"
        Me.LabelOtro.Size = New System.Drawing.Size(38, 19)
        Me.LabelOtro.TabIndex = 8
        Me.LabelOtro.Text = "Otro"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecio.Location = New System.Drawing.Point(36, 299)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(47, 19)
        Me.LabelPrecio.TabIndex = 9
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelProductos
        '
        Me.LabelProductos.AutoSize = True
        Me.LabelProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductos.Location = New System.Drawing.Point(36, 330)
        Me.LabelProductos.Name = "LabelProductos"
        Me.LabelProductos.Size = New System.Drawing.Size(72, 19)
        Me.LabelProductos.TabIndex = 10
        Me.LabelProductos.Text = "Productos"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecio.Location = New System.Drawing.Point(133, 300)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxPrecio.TabIndex = 13
        '
        'TextBoxOtro
        '
        Me.TextBoxOtro.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxOtro.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOtro.Location = New System.Drawing.Point(133, 268)
        Me.TextBoxOtro.Name = "TextBoxOtro"
        Me.TextBoxOtro.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxOtro.TabIndex = 14
        '
        'TextBoxProductos
        '
        Me.TextBoxProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductos.Location = New System.Drawing.Point(133, 331)
        Me.TextBoxProductos.Name = "TextBoxProductos"
        Me.TextBoxProductos.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxProductos.TabIndex = 15
        '
        'TextBoxColor
        '
        Me.TextBoxColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxColor.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxColor.Location = New System.Drawing.Point(133, 233)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxColor.TabIndex = 16
        '
        'TextBoxAncho
        '
        Me.TextBoxAncho.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAncho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAncho.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAncho.Location = New System.Drawing.Point(133, 203)
        Me.TextBoxAncho.Name = "TextBoxAncho"
        Me.TextBoxAncho.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAncho.TabIndex = 17
        '
        'TextBoxLargo
        '
        Me.TextBoxLargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLargo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLargo.Location = New System.Drawing.Point(133, 171)
        Me.TextBoxLargo.Name = "TextBoxLargo"
        Me.TextBoxLargo.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxLargo.TabIndex = 18
        '
        'TextBoxAlto
        '
        Me.TextBoxAlto.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAlto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAlto.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlto.Location = New System.Drawing.Point(133, 136)
        Me.TextBoxAlto.Name = "TextBoxAlto"
        Me.TextBoxAlto.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAlto.TabIndex = 19
        '
        'BotonSiguiente
        '
        Me.BotonSiguiente.BackColor = System.Drawing.Color.White
        Me.BotonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonSiguiente.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSiguiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonSiguiente.Location = New System.Drawing.Point(176, 380)
        Me.BotonSiguiente.Name = "BotonSiguiente"
        Me.BotonSiguiente.Size = New System.Drawing.Size(185, 45)
        Me.BotonSiguiente.TabIndex = 20
        Me.BotonSiguiente.Text = "Finalizar Compra"
        Me.BotonSiguiente.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BotonSiguiente)
        Me.Panel1.Location = New System.Drawing.Point(418, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 452)
        Me.Panel1.TabIndex = 21
        '
        'VentaEspecifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxAlto)
        Me.Controls.Add(Me.TextBoxLargo)
        Me.Controls.Add(Me.TextBoxAncho)
        Me.Controls.Add(Me.TextBoxColor)
        Me.Controls.Add(Me.TextBoxProductos)
        Me.Controls.Add(Me.TextBoxOtro)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.LabelProductos)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.LabelOtro)
        Me.Controls.Add(Me.LabelColor)
        Me.Controls.Add(Me.LabelAncho)
        Me.Controls.Add(Me.LabelLargo)
        Me.Controls.Add(Me.LabelAlto)
        Me.Controls.Add(Me.LabelVentaEspe)
        Me.Name = "VentaEspecifica"
        Me.Text = "VentaEspecifica"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents LabelAlto As Label
    Friend WithEvents LabelLargo As Label
    Friend WithEvents LabelAncho As Label
    Friend WithEvents LabelColor As Label
    Friend WithEvents LabelOtro As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelProductos As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxOtro As TextBox
    Friend WithEvents TextBoxProductos As TextBox
    Friend WithEvents TextBoxColor As TextBox
    Friend WithEvents TextBoxAncho As TextBox
    Friend WithEvents TextBoxLargo As TextBox
    Friend WithEvents TextBoxAlto As TextBox
    Friend WithEvents BotonSiguiente As Button
    Friend WithEvents Panel1 As Panel
End Class
