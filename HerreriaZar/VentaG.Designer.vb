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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaG))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVventa = New System.Windows.Forms.DataGridView()
        Me.TextBoxid = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BotonSiguiente = New System.Windows.Forms.Button()
        Me.LabelVentaG = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelAnticipo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAnticipo = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.DTPFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxAlto = New System.Windows.Forms.TextBox()
        Me.TextBoxLargo = New System.Windows.Forms.TextBox()
        Me.TextBoxAncho = New System.Windows.Forms.TextBox()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.LabelProductos = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelOtro = New System.Windows.Forms.Label()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.LabelAncho = New System.Windows.Forms.Label()
        Me.LabelLargo = New System.Windows.Forms.Label()
        Me.LabelAlto = New System.Windows.Forms.Label()
        Me.DTPFecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBCliente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBProducto = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ejemplo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
<<<<<<< HEAD
        Me.Panel1.Controls.Add(Me.DGVventa)
        Me.Panel1.Location = New System.Drawing.Point(527, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
=======
        Me.Panel1.Controls.Add(Me.TextBoxid)
        Me.Panel1.Controls.Add(Me.DGVventa)
        Me.Panel1.Location = New System.Drawing.Point(395, 0)
>>>>>>> 61815bc44924f38c6cf64bce94bb83c2f8bba230
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 578)
        Me.Panel1.TabIndex = 0
        '
        'DGVventa
        '
        Me.DGVventa.BackgroundColor = System.Drawing.Color.White
        Me.DGVventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVventa.Location = New System.Drawing.Point(0, 0)
        Me.DGVventa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGVventa.Name = "DGVventa"
        Me.DGVventa.RowHeadersWidth = 51
        Me.DGVventa.RowTemplate.Height = 24
        Me.DGVventa.Size = New System.Drawing.Size(632, 453)
        Me.DGVventa.TabIndex = 14
        '
        'TextBoxid
        '
        Me.TextBoxid.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxid.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.TextBoxid.Location = New System.Drawing.Point(402, 539)
        Me.TextBoxid.Margin = New System.Windows.Forms.Padding(4)
=======
        Me.TextBoxid.Location = New System.Drawing.Point(68, 424)
>>>>>>> 61815bc44924f38c6cf64bce94bb83c2f8bba230
        Me.TextBoxid.Name = "TextBoxid"
        Me.TextBoxid.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxid.TabIndex = 39
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.White
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BtnAgregar.Location = New System.Drawing.Point(129, 256)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(92, 31)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BotonSiguiente
        '
        Me.BotonSiguiente.BackColor = System.Drawing.Color.White
        Me.BotonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonSiguiente.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSiguiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonSiguiente.Location = New System.Drawing.Point(145, 470)
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
        Me.LabelVentaG.Location = New System.Drawing.Point(10, 7)
        Me.LabelVentaG.Name = "LabelVentaG"
        Me.LabelVentaG.Size = New System.Drawing.Size(291, 39)
        Me.LabelVentaG.TabIndex = 1
        Me.LabelVentaG.Text = "Venta de Producto"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(14, 301)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(45, 19)
        Me.LabelFecha.TabIndex = 3
        Me.LabelFecha.Text = "Fecha"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(14, 330)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(39, 19)
        Me.LabelTotal.TabIndex = 4
        Me.LabelTotal.Text = "Total"
        '
        'LabelAnticipo
        '
        Me.LabelAnticipo.AutoSize = True
        Me.LabelAnticipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnticipo.Location = New System.Drawing.Point(14, 357)
        Me.LabelAnticipo.Name = "LabelAnticipo"
        Me.LabelAnticipo.Size = New System.Drawing.Size(60, 19)
        Me.LabelAnticipo.TabIndex = 5
        Me.LabelAnticipo.Text = "Anticipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 383)
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
        Me.TextBoxAnticipo.Location = New System.Drawing.Point(129, 355)
        Me.TextBoxAnticipo.Name = "TextBoxAnticipo"
        Me.TextBoxAnticipo.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAnticipo.TabIndex = 8
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(129, 328)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxTotal.TabIndex = 9
        '
        'DTPFechaVenta
        '
        Me.DTPFechaVenta.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaVenta.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaVenta.Location = New System.Drawing.Point(130, 301)
        Me.DTPFechaVenta.Name = "DTPFechaVenta"
        Me.DTPFechaVenta.Size = New System.Drawing.Size(215, 21)
        Me.DTPFechaVenta.TabIndex = 11
        '
        'TextBoxAlto
        '
        Me.TextBoxAlto.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAlto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAlto.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlto.Location = New System.Drawing.Point(130, 122)
        Me.TextBoxAlto.Name = "TextBoxAlto"
        Me.TextBoxAlto.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAlto.TabIndex = 33
        '
        'TextBoxLargo
        '
        Me.TextBoxLargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLargo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLargo.Location = New System.Drawing.Point(130, 149)
        Me.TextBoxLargo.Name = "TextBoxLargo"
        Me.TextBoxLargo.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxLargo.TabIndex = 32
        '
        'TextBoxAncho
        '
        Me.TextBoxAncho.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxAncho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAncho.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAncho.Location = New System.Drawing.Point(130, 176)
        Me.TextBoxAncho.Name = "TextBoxAncho"
        Me.TextBoxAncho.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxAncho.TabIndex = 31
        '
        'TextBoxColor
        '
        Me.TextBoxColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxColor.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxColor.Location = New System.Drawing.Point(130, 202)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxColor.TabIndex = 30
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCantidad.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantidad.Location = New System.Drawing.Point(130, 229)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(215, 21)
        Me.TextBoxCantidad.TabIndex = 28
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecio.Location = New System.Drawing.Point(130, 95)
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
        Me.LabelProductos.Location = New System.Drawing.Point(14, 69)
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
        Me.LabelPrecio.Location = New System.Drawing.Point(14, 95)
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
        Me.LabelOtro.Location = New System.Drawing.Point(14, 231)
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
        Me.LabelColor.Location = New System.Drawing.Point(14, 204)
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
        Me.LabelAncho.Location = New System.Drawing.Point(14, 177)
        Me.LabelAncho.Name = "LabelAncho"
        Me.LabelAncho.Size = New System.Drawing.Size(72, 19)
        Me.LabelAncho.TabIndex = 22
        Me.LabelAncho.Text = "Ancho cm"
        '
        'LabelLargo
        '
        Me.LabelLargo.AutoSize = True
        Me.LabelLargo.BackColor = System.Drawing.Color.White
        Me.LabelLargo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLargo.ForeColor = System.Drawing.Color.Black
        Me.LabelLargo.Location = New System.Drawing.Point(14, 150)
        Me.LabelLargo.Name = "LabelLargo"
        Me.LabelLargo.Size = New System.Drawing.Size(71, 19)
        Me.LabelLargo.TabIndex = 21
        Me.LabelLargo.Text = "Largo  cm"
        '
        'LabelAlto
        '
        Me.LabelAlto.AutoSize = True
        Me.LabelAlto.BackColor = System.Drawing.Color.White
        Me.LabelAlto.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlto.ForeColor = System.Drawing.Color.Black
        Me.LabelAlto.Location = New System.Drawing.Point(14, 124)
        Me.LabelAlto.Name = "LabelAlto"
        Me.LabelAlto.Size = New System.Drawing.Size(73, 19)
        Me.LabelAlto.TabIndex = 20
        Me.LabelAlto.Text = "Alto     cm"
        '
        'DTPFecha_Entrega
        '
        Me.DTPFecha_Entrega.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFecha_Entrega.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFecha_Entrega.Location = New System.Drawing.Point(130, 411)
        Me.DTPFecha_Entrega.Name = "DTPFecha_Entrega"
        Me.DTPFecha_Entrega.Size = New System.Drawing.Size(215, 21)
        Me.DTPFecha_Entrega.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Fecha de Entrega"
        '
        'CBCliente
        '
        Me.CBCliente.FormattingEnabled = True
        Me.CBCliente.Location = New System.Drawing.Point(129, 382)
        Me.CBCliente.Name = "CBCliente"
        Me.CBCliente.Size = New System.Drawing.Size(215, 21)
        Me.CBCliente.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(284, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'CBProducto
        '
        Me.CBProducto.FormattingEnabled = True
        Me.CBProducto.Location = New System.Drawing.Point(130, 68)
        Me.CBProducto.Name = "CBProducto"
        Me.CBProducto.Size = New System.Drawing.Size(215, 21)
        Me.CBProducto.TabIndex = 37
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.White
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BtnEliminar.Location = New System.Drawing.Point(252, 256)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(92, 31)
        Me.BtnEliminar.TabIndex = 38
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'ejemplo
        '
        Me.ejemplo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ejemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ejemplo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ejemplo.Location = New System.Drawing.Point(481, 264)
        Me.ejemplo.Name = "ejemplo"
        Me.ejemplo.Size = New System.Drawing.Size(78, 21)
        Me.ejemplo.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(481, 237)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 21)
        Me.TextBox1.TabIndex = 45
        '
        'VentaG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1385, 643)
        Me.Controls.Add(Me.TextBoxid)
=======
        Me.ClientSize = New System.Drawing.Size(1028, 522)
>>>>>>> 61815bc44924f38c6cf64bce94bb83c2f8bba230
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BotonSiguiente)
        Me.Controls.Add(Me.CBProducto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBCliente)
        Me.Controls.Add(Me.DTPFecha_Entrega)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAlto)
        Me.Controls.Add(Me.DTPFechaVenta)
        Me.Controls.Add(Me.TextBoxLargo)
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
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ejemplo)
        Me.Controls.Add(Me.TextBox1)
<<<<<<< HEAD
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
=======
>>>>>>> 61815bc44924f38c6cf64bce94bb83c2f8bba230
        Me.Name = "VentaG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaG"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVventa, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DTPFechaVenta As DateTimePicker
    Friend WithEvents BotonSiguiente As Button
    Friend WithEvents TextBoxAlto As TextBox
    Friend WithEvents TextBoxLargo As TextBox
    Friend WithEvents TextBoxAncho As TextBox
    Friend WithEvents TextBoxColor As TextBox
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents LabelProductos As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelOtro As Label
    Friend WithEvents LabelColor As Label
    Friend WithEvents LabelAncho As Label
    Friend WithEvents LabelLargo As Label
    Friend WithEvents LabelAlto As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents DTPFecha_Entrega As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CBCliente As ComboBox
    Friend WithEvents DGVventa As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents CBProducto As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TextBoxid As TextBox
    Friend WithEvents ejemplo As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
