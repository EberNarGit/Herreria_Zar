<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.DGVPedidos = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonCatálogo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.BtmActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPdes = New System.Windows.Forms.DateTimePicker()
        Me.DTPpre = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.White
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelVentaEspe.Location = New System.Drawing.Point(134, 24)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(377, 46)
        Me.LabelVentaEspe.TabIndex = 4
        Me.LabelVentaEspe.Text = "Consulta de Pedidos"
        '
        'DGVPedidos
        '
        Me.DGVPedidos.BackgroundColor = System.Drawing.Color.White
        Me.DGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPedidos.Location = New System.Drawing.Point(179, 147)
        Me.DGVPedidos.Name = "DGVPedidos"
        Me.DGVPedidos.RowHeadersWidth = 51
        Me.DGVPedidos.Size = New System.Drawing.Size(452, 236)
        Me.DGVPedidos.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(-1, 380)
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
        Me.Button3.Location = New System.Drawing.Point(-1, 252)
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
        Me.ButtonCatálogo.Location = New System.Drawing.Point(-1, 316)
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
        Me.Button1.Location = New System.Drawing.Point(-1, 0)
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
        Me.ButtonPagos.Location = New System.Drawing.Point(-1, 190)
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
        Me.ButtonVentas.Location = New System.Drawing.Point(-1, 63)
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
        Me.ButtonUsuarios.Location = New System.Drawing.Point(-1, 127)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(104, 67)
        Me.ButtonUsuarios.TabIndex = 18
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'BtmActualizar
        '
        Me.BtmActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BtmActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtmActualizar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtmActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtmActualizar.Location = New System.Drawing.Point(520, 405)
        Me.BtmActualizar.Name = "BtmActualizar"
        Me.BtmActualizar.Size = New System.Drawing.Size(110, 31)
        Me.BtmActualizar.TabIndex = 24
        Me.BtmActualizar.Text = "Buscar"
        Me.BtmActualizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "A:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "De:"
        '
        'DTPdes
        '
        Me.DTPdes.Location = New System.Drawing.Point(435, 112)
        Me.DTPdes.Name = "DTPdes"
        Me.DTPdes.Size = New System.Drawing.Size(196, 20)
        Me.DTPdes.TabIndex = 38
        '
        'DTPpre
        '
        Me.DTPpre.Location = New System.Drawing.Point(172, 112)
        Me.DTPpre.Name = "DTPpre"
        Me.DTPpre.Size = New System.Drawing.Size(196, 20)
        Me.DTPpre.TabIndex = 37
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(662, 459)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPdes)
        Me.Controls.Add(Me.DTPpre)
        Me.Controls.Add(Me.BtmActualizar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonCatálogo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPagos)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.ButtonUsuarios)
        Me.Controls.Add(Me.DGVPedidos)
        Me.Controls.Add(Me.LabelVentaEspe)
        Me.Name = "Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        CType(Me.DGVPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents DGVPedidos As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonCatálogo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonPagos As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents BtmActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPdes As DateTimePicker
    Friend WithEvents DTPpre As DateTimePicker
End Class
