<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentaG
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonSiguiente = New System.Windows.Forms.Button()
        Me.LabelVentaG = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelAnticipo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAnticipo = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.FechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxAlto = New System.Windows.Forms.TextBox()
        Me.TextBoxLargo = New System.Windows.Forms.TextBox()
        Me.TextBoxAncho = New System.Windows.Forms.TextBox()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.TextBoxProductos = New System.Windows.Forms.TextBox()
        Me.TextBoxOtro = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.LabelProductos = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelOtro = New System.Windows.Forms.Label()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.LabelAncho = New System.Windows.Forms.Label()
        Me.LabelLargo = New System.Windows.Forms.Label()
        Me.LabelAlto = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anticipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BotonSiguiente)
        Me.Panel1.Location = New System.Drawing.Point(395, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 578)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(126, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 45)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Agregar Producto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BotonSiguiente
        '
        Me.BotonSiguiente.BackColor = System.Drawing.Color.White
        Me.BotonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonSiguiente.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSiguiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonSiguiente.Location = New System.Drawing.Point(317, 498)
        Me.BotonSiguiente.Name = "BotonSiguiente"
        Me.BotonSiguiente.Size = New System.Drawing.Size(185, 45)
        Me.BotonSiguiente.TabIndex = 12
        Me.BotonSiguiente.Text = "Realizar Venta"
        Me.BotonSiguiente.UseVisualStyleBackColor = False
        '
        'LabelVentaG
        '
        Me.LabelVentaG.AutoSize = True
        Me.LabelVentaG.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaG.Location = New System.Drawing.Point(12, 22)
        Me.LabelVentaG.Name = "LabelVentaG"
        Me.LabelVentaG.Size = New System.Drawing.Size(291, 39)
        Me.LabelVentaG.TabIndex = 1
        Me.LabelVentaG.Text = "Venta de Producto"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(34, 334)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(45, 19)
        Me.LabelFecha.TabIndex = 3
        Me.LabelFecha.Text = "Fecha"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(34, 370)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(39, 19)
        Me.LabelTotal.TabIndex = 4
        Me.LabelTotal.Text = "Total"
        '
        'LabelAnticipo
        '
        Me.LabelAnticipo.AutoSize = True
        Me.LabelAnticipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnticipo.Location = New System.Drawing.Point(34, 406)
        Me.LabelAnticipo.Name = "LabelAnticipo"
        Me.LabelAnticipo.Size = New System.Drawing.Size(60, 19)
        Me.LabelAnticipo.TabIndex = 5
        Me.LabelAnticipo.Text = "Anticipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente"
        '
        'TextBoxAnticipo
        '
        Me.TextBoxAnticipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAnticipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAnticipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAnticipo.Location = New System.Drawing.Point(126, 404)
        Me.TextBoxAnticipo.Name = "TextBoxAnticipo"
        Me.TextBoxAnticipo.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAnticipo.TabIndex = 8
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(126, 368)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxTotal.TabIndex = 9
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCliente.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCliente.Location = New System.Drawing.Point(126, 439)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxCliente.TabIndex = 10
        '
        'FechaVenta
        '
        Me.FechaVenta.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaVenta.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaVenta.Location = New System.Drawing.Point(126, 334)
        Me.FechaVenta.Name = "FechaVenta"
        Me.FechaVenta.Size = New System.Drawing.Size(215, 21)
        Me.FechaVenta.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Empleado"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(126, 477)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 21)
        Me.TextBox1.TabIndex = 14
        '
        'TextBoxAlto
        '
        Me.TextBoxAlto.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAlto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAlto.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlto.Location = New System.Drawing.Point(126, 166)
        Me.TextBoxAlto.Name = "TextBoxAlto"
        Me.TextBoxAlto.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAlto.TabIndex = 33
        '
        'TextBoxLargo
        '
        Me.TextBoxLargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLargo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLargo.Location = New System.Drawing.Point(126, 201)
        Me.TextBoxLargo.Name = "TextBoxLargo"
        Me.TextBoxLargo.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxLargo.TabIndex = 32
        '
        'TextBoxAncho
        '
        Me.TextBoxAncho.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAncho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAncho.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAncho.Location = New System.Drawing.Point(126, 233)
        Me.TextBoxAncho.Name = "TextBoxAncho"
        Me.TextBoxAncho.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAncho.TabIndex = 31
        '
        'TextBoxColor
        '
        Me.TextBoxColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxColor.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxColor.Location = New System.Drawing.Point(126, 263)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxColor.TabIndex = 30
        '
        'TextBoxProductos
        '
        Me.TextBoxProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductos.Location = New System.Drawing.Point(126, 93)
        Me.TextBoxProductos.Name = "TextBoxProductos"
        Me.TextBoxProductos.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxProductos.TabIndex = 29
        '
        'TextBoxOtro
        '
        Me.TextBoxOtro.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxOtro.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOtro.Location = New System.Drawing.Point(126, 298)
        Me.TextBoxOtro.Name = "TextBoxOtro"
        Me.TextBoxOtro.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxOtro.TabIndex = 28
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecio.Location = New System.Drawing.Point(126, 129)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxPrecio.TabIndex = 27
        '
        'LabelProductos
        '
        Me.LabelProductos.AutoSize = True
        Me.LabelProductos.BackColor = System.Drawing.Color.White
        Me.LabelProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductos.ForeColor = System.Drawing.Color.Black
        Me.LabelProductos.Location = New System.Drawing.Point(34, 92)
        Me.LabelProductos.Name = "LabelProductos"
        Me.LabelProductos.Size = New System.Drawing.Size(72, 19)
        Me.LabelProductos.TabIndex = 26
        Me.LabelProductos.Text = "Productos"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.BackColor = System.Drawing.Color.White
        Me.LabelPrecio.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecio.ForeColor = System.Drawing.Color.Black
        Me.LabelPrecio.Location = New System.Drawing.Point(34, 128)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(47, 19)
        Me.LabelPrecio.TabIndex = 25
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelOtro
        '
        Me.LabelOtro.AutoSize = True
        Me.LabelOtro.BackColor = System.Drawing.Color.White
        Me.LabelOtro.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOtro.ForeColor = System.Drawing.Color.Black
        Me.LabelOtro.Location = New System.Drawing.Point(34, 297)
        Me.LabelOtro.Name = "LabelOtro"
        Me.LabelOtro.Size = New System.Drawing.Size(64, 19)
        Me.LabelOtro.TabIndex = 24
        Me.LabelOtro.Text = "Cantidad"
        '
        'LabelColor
        '
        Me.LabelColor.AutoSize = True
        Me.LabelColor.BackColor = System.Drawing.Color.White
        Me.LabelColor.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelColor.ForeColor = System.Drawing.Color.Black
        Me.LabelColor.Location = New System.Drawing.Point(34, 265)
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(42, 19)
        Me.LabelColor.TabIndex = 23
        Me.LabelColor.Text = "Color"
        '
        'LabelAncho
        '
        Me.LabelAncho.AutoSize = True
        Me.LabelAncho.BackColor = System.Drawing.Color.White
        Me.LabelAncho.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAncho.ForeColor = System.Drawing.Color.Black
        Me.LabelAncho.Location = New System.Drawing.Point(34, 232)
        Me.LabelAncho.Name = "LabelAncho"
        Me.LabelAncho.Size = New System.Drawing.Size(49, 19)
        Me.LabelAncho.TabIndex = 22
        Me.LabelAncho.Text = "Ancho"
        '
        'LabelLargo
        '
        Me.LabelLargo.AutoSize = True
        Me.LabelLargo.BackColor = System.Drawing.Color.White
        Me.LabelLargo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLargo.ForeColor = System.Drawing.Color.Black
        Me.LabelLargo.Location = New System.Drawing.Point(34, 200)
        Me.LabelLargo.Name = "LabelLargo"
        Me.LabelLargo.Size = New System.Drawing.Size(44, 19)
        Me.LabelLargo.TabIndex = 21
        Me.LabelLargo.Text = "Largo"
        '
        'LabelAlto
        '
        Me.LabelAlto.AutoSize = True
        Me.LabelAlto.BackColor = System.Drawing.Color.White
        Me.LabelAlto.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlto.ForeColor = System.Drawing.Color.Black
        Me.LabelAlto.Location = New System.Drawing.Point(34, 165)
        Me.LabelAlto.Name = "LabelAlto"
        Me.LabelAlto.Size = New System.Drawing.Size(34, 19)
        Me.LabelAlto.TabIndex = 20
        Me.LabelAlto.Text = "Alto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Precio, Me.Anticipo, Me.Cliente})
        Me.DataGridView1.Location = New System.Drawing.Point(40, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 416)
        Me.DataGridView1.TabIndex = 14
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Anticipo
        '
        Me.Anticipo.HeaderText = "Anticipo"
        Me.Anticipo.Name = "Anticipo"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'VentaG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1039, 570)
        Me.Controls.Add(Me.TextBoxAlto)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxProductos)
        Me.Controls.Add(Me.FechaVenta)
        Me.Controls.Add(Me.TextBoxLargo)
        Me.Controls.Add(Me.TextBoxCliente)
        Me.Controls.Add(Me.LabelAlto)
        Me.Controls.Add(Me.LabelLargo)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.LabelAncho)
        Me.Controls.Add(Me.TextBoxAnticipo)
        Me.Controls.Add(Me.TextBoxAncho)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelColor)
        Me.Controls.Add(Me.LabelAnticipo)
        Me.Controls.Add(Me.LabelOtro)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.TextBoxColor)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.LabelVentaG)
        Me.Controls.Add(Me.LabelProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxOtro)
        Me.Name = "VentaG"
        Me.Text = "VentaG"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelVentaG As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelAnticipo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxAnticipo As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents FechaVenta As DateTimePicker
    Friend WithEvents BotonSiguiente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxAlto As TextBox
    Friend WithEvents TextBoxLargo As TextBox
    Friend WithEvents TextBoxAncho As TextBox
    Friend WithEvents TextBoxColor As TextBox
    Friend WithEvents TextBoxProductos As TextBox
    Friend WithEvents TextBoxOtro As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents LabelProductos As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelOtro As Label
    Friend WithEvents LabelColor As Label
    Friend WithEvents LabelAncho As Label
    Friend WithEvents LabelLargo As Label
    Friend WithEvents LabelAlto As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Anticipo As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
End Class
