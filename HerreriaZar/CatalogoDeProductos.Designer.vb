<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CatalogoDeProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatalogoDeProductos))
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonCatálogo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.MensajeDeBienvenida = New System.Windows.Forms.Label()
        Me.ButtonAddProduct = New System.Windows.Forms.Button()
        Me.DGVCatalogo = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DGVCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1225, 114)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(19, 545)
        Me.VScrollBar1.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(0, 466)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 82)
        Me.Button5.TabIndex = 14
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
        Me.Button3.Location = New System.Drawing.Point(0, 309)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 82)
        Me.Button3.TabIndex = 16
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
        Me.ButtonCatálogo.Location = New System.Drawing.Point(0, 388)
        Me.ButtonCatálogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCatálogo.Name = "ButtonCatálogo"
        Me.ButtonCatálogo.Size = New System.Drawing.Size(139, 82)
        Me.ButtonCatálogo.TabIndex = 13
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
        Me.Button1.Location = New System.Drawing.Point(0, -1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 82)
        Me.Button1.TabIndex = 15
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
        Me.ButtonPagos.Location = New System.Drawing.Point(0, 233)
        Me.ButtonPagos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(139, 82)
        Me.ButtonPagos.TabIndex = 12
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
        Me.ButtonVentas.Location = New System.Drawing.Point(0, 76)
        Me.ButtonVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Size = New System.Drawing.Size(139, 82)
        Me.ButtonVentas.TabIndex = 10
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
        Me.ButtonUsuarios.Location = New System.Drawing.Point(0, 155)
        Me.ButtonUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(139, 82)
        Me.ButtonUsuarios.TabIndex = 11
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'MensajeDeBienvenida
        '
        Me.MensajeDeBienvenida.BackColor = System.Drawing.Color.White
        Me.MensajeDeBienvenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajeDeBienvenida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MensajeDeBienvenida.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MensajeDeBienvenida.Location = New System.Drawing.Point(220, 31)
        Me.MensajeDeBienvenida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MensajeDeBienvenida.Name = "MensajeDeBienvenida"
        Me.MensajeDeBienvenida.Size = New System.Drawing.Size(669, 69)
        Me.MensajeDeBienvenida.TabIndex = 2
        Me.MensajeDeBienvenida.Text = "Catálogo Zar"
        '
        'ButtonAddProduct
        '
        Me.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddProduct.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddProduct.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonAddProduct.Location = New System.Drawing.Point(927, 31)
        Me.ButtonAddProduct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAddProduct.Name = "ButtonAddProduct"
        Me.ButtonAddProduct.Size = New System.Drawing.Size(247, 55)
        Me.ButtonAddProduct.TabIndex = 8
        Me.ButtonAddProduct.Text = "Añadir Producto"
        Me.ButtonAddProduct.UseVisualStyleBackColor = False
        '
        'DGVCatalogo
        '
        Me.DGVCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCatalogo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCatalogo.Location = New System.Drawing.Point(197, 128)
        Me.DGVCatalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVCatalogo.Name = "DGVCatalogo"
        Me.DGVCatalogo.RowHeadersWidth = 51
        Me.DGVCatalogo.Size = New System.Drawing.Size(969, 402)
        Me.DGVCatalogo.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(660, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 55)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CatalogoDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1251, 545)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGVCatalogo)
        Me.Controls.Add(Me.ButtonAddProduct)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.MensajeDeBienvenida)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonCatálogo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPagos)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.ButtonUsuarios)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CatalogoDeProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo De Productos"
        CType(Me.DGVCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonCatálogo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonPagos As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents MensajeDeBienvenida As Label
    Friend WithEvents ButtonAddProduct As Button
    Friend WithEvents DGVCatalogo As DataGridView
    Friend WithEvents Button2 As Button
End Class
