<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos))
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonCatálogo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.DGVPagos = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelMonto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMonto = New System.Windows.Forms.TextBox()
        Me.BotonPagar = New System.Windows.Forms.Button()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DGVPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.White
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelVentaEspe.Location = New System.Drawing.Point(134, 19)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(126, 46)
        Me.LabelVentaEspe.TabIndex = 24
        Me.LabelVentaEspe.Text = "Pagos"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(0, 378)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 67)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "  Reporte "
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(0, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 67)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Pedidos"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ButtonCatálogo
        '
        Me.ButtonCatálogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonCatálogo.FlatAppearance.BorderSize = 0
        Me.ButtonCatálogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCatálogo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCatálogo.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCatálogo.Image = CType(resources.GetObject("ButtonCatálogo.Image"), System.Drawing.Image)
        Me.ButtonCatálogo.Location = New System.Drawing.Point(0, 314)
        Me.ButtonCatálogo.Name = "ButtonCatálogo"
        Me.ButtonCatálogo.Size = New System.Drawing.Size(104, 67)
        Me.ButtonCatálogo.TabIndex = 20
        Me.ButtonCatálogo.Text = " Catálogo"
        Me.ButtonCatálogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCatálogo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 67)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Menu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonPagos.FlatAppearance.BorderSize = 0
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagos.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonPagos.Image = CType(resources.GetObject("ButtonPagos.Image"), System.Drawing.Image)
        Me.ButtonPagos.Location = New System.Drawing.Point(0, 188)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(104, 67)
        Me.ButtonPagos.TabIndex = 19
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonVentas
        '
        Me.ButtonVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonVentas.FlatAppearance.BorderSize = 0
        Me.ButtonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVentas.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVentas.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonVentas.Image = CType(resources.GetObject("ButtonVentas.Image"), System.Drawing.Image)
        Me.ButtonVentas.Location = New System.Drawing.Point(0, 61)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Size = New System.Drawing.Size(104, 67)
        Me.ButtonVentas.TabIndex = 17
        Me.ButtonVentas.Text = "Ventas"
        Me.ButtonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonVentas.UseVisualStyleBackColor = False
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonUsuarios.FlatAppearance.BorderSize = 0
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonUsuarios.Image = CType(resources.GetObject("ButtonUsuarios.Image"), System.Drawing.Image)
        Me.ButtonUsuarios.Location = New System.Drawing.Point(0, 125)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(104, 67)
        Me.ButtonUsuarios.TabIndex = 18
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'DGVPagos
        '
        Me.DGVPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.Venta, Me.Monto, Me.Fecha, Me.Empleado})
        Me.DGVPagos.GridColor = System.Drawing.Color.Black
        Me.DGVPagos.Location = New System.Drawing.Point(122, 114)
        Me.DGVPagos.Name = "DGVPagos"
        Me.DGVPagos.Size = New System.Drawing.Size(542, 267)
        Me.DGVPagos.TabIndex = 26
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Venta
        '
        Me.Venta.HeaderText = "Venta"
        Me.Venta.Name = "Venta"
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "ninguno"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCliente.Location = New System.Drawing.Point(711, 207)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(51, 19)
        Me.LabelCliente.TabIndex = 27
        Me.LabelCliente.Text = "Monto"
        '
        'LabelMonto
        '
        Me.LabelMonto.AutoSize = True
        Me.LabelMonto.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonto.Location = New System.Drawing.Point(714, 253)
        Me.LabelMonto.Name = "LabelMonto"
        Me.LabelMonto.Size = New System.Drawing.Size(45, 19)
        Me.LabelMonto.TabIndex = 28
        Me.LabelMonto.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(711, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Empleado"
        '
        'TextBoxMonto
        '
        Me.TextBoxMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBoxMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMonto.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMonto.Location = New System.Drawing.Point(787, 205)
        Me.TextBoxMonto.Name = "TextBoxMonto"
        Me.TextBoxMonto.Size = New System.Drawing.Size(212, 21)
        Me.TextBoxMonto.TabIndex = 32
        '
        'BotonPagar
        '
        Me.BotonPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonPagar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonPagar.ForeColor = System.Drawing.SystemColors.Control
        Me.BotonPagar.Location = New System.Drawing.Point(889, 346)
        Me.BotonPagar.Name = "BotonPagar"
        Me.BotonPagar.Size = New System.Drawing.Size(110, 45)
        Me.BotonPagar.TabIndex = 33
        Me.BotonPagar.Text = "Pagar"
        Me.BotonPagar.UseVisualStyleBackColor = False
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(787, 251)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(212, 20)
        Me.DTP.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cliente"
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(787, 163)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxCliente.TabIndex = 36
        '
        'ComboBoxEmpleado
        '
        Me.ComboBoxEmpleado.FormattingEnabled = True
        Me.ComboBoxEmpleado.Location = New System.Drawing.Point(787, 296)
        Me.ComboBoxEmpleado.Name = "ComboBoxEmpleado"
        Me.ComboBoxEmpleado.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxEmpleado.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(715, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 45)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Buscar por Cliente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 444)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBoxEmpleado)
        Me.Controls.Add(Me.ComboBoxCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.BotonPagar)
        Me.Controls.Add(Me.TextBoxMonto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelMonto)
        Me.Controls.Add(Me.LabelCliente)
        Me.Controls.Add(Me.DGVPagos)
        Me.Controls.Add(Me.LabelVentaEspe)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonCatálogo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPagos)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.ButtonUsuarios)
        Me.Name = "Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        CType(Me.DGVPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonCatálogo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonPagos As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents DGVPagos As DataGridView
    Friend WithEvents LabelCliente As Label
    Friend WithEvents LabelMonto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMonto As TextBox
    Friend WithEvents BotonPagar As Button
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Venta As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents ComboBoxEmpleado As ComboBox
    Friend WithEvents Button2 As Button
End Class
