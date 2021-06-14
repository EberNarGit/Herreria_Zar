<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.ButtonReporte = New System.Windows.Forms.Button()
        Me.ButtonPedidos = New System.Windows.Forms.Button()
        Me.ButtonCatálogo = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.ButtonProfile = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1215, 68)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 532)
        Me.VScrollBar1.TabIndex = 4
        '
        'ButtonReporte
        '
        Me.ButtonReporte.BackColor = System.Drawing.Color.White
        Me.ButtonReporte.FlatAppearance.BorderSize = 0
        Me.ButtonReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReporte.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonReporte.Image = CType(resources.GetObject("ButtonReporte.Image"), System.Drawing.Image)
        Me.ButtonReporte.Location = New System.Drawing.Point(705, 343)
        Me.ButtonReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonReporte.Name = "ButtonReporte"
        Me.ButtonReporte.Size = New System.Drawing.Size(163, 133)
        Me.ButtonReporte.TabIndex = 14
        Me.ButtonReporte.Text = "  Reporte "
        Me.ButtonReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonReporte.UseVisualStyleBackColor = False
        '
        'ButtonPedidos
        '
        Me.ButtonPedidos.BackColor = System.Drawing.Color.White
        Me.ButtonPedidos.FlatAppearance.BorderSize = 0
        Me.ButtonPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPedidos.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPedidos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonPedidos.Image = CType(resources.GetObject("ButtonPedidos.Image"), System.Drawing.Image)
        Me.ButtonPedidos.Location = New System.Drawing.Point(80, 343)
        Me.ButtonPedidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonPedidos.Name = "ButtonPedidos"
        Me.ButtonPedidos.Size = New System.Drawing.Size(163, 133)
        Me.ButtonPedidos.TabIndex = 16
        Me.ButtonPedidos.Text = "Pedidos"
        Me.ButtonPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonPedidos.UseVisualStyleBackColor = False
        '
        'ButtonCatálogo
        '
        Me.ButtonCatálogo.BackColor = System.Drawing.Color.White
        Me.ButtonCatálogo.FlatAppearance.BorderSize = 0
        Me.ButtonCatálogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCatálogo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCatálogo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonCatálogo.Image = CType(resources.GetObject("ButtonCatálogo.Image"), System.Drawing.Image)
        Me.ButtonCatálogo.Location = New System.Drawing.Point(388, 343)
        Me.ButtonCatálogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCatálogo.Name = "ButtonCatálogo"
        Me.ButtonCatálogo.Size = New System.Drawing.Size(163, 133)
        Me.ButtonCatálogo.TabIndex = 13
        Me.ButtonCatálogo.Text = " Catálogo"
        Me.ButtonCatálogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCatálogo.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.BackColor = System.Drawing.Color.White
        Me.ButtonPagos.FlatAppearance.BorderSize = 0
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonPagos.Image = CType(resources.GetObject("ButtonPagos.Image"), System.Drawing.Image)
        Me.ButtonPagos.Location = New System.Drawing.Point(705, 169)
        Me.ButtonPagos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(163, 133)
        Me.ButtonPagos.TabIndex = 12
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonVentas
        '
        Me.ButtonVentas.BackColor = System.Drawing.Color.White
        Me.ButtonVentas.FlatAppearance.BorderSize = 0
        Me.ButtonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVentas.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonVentas.Image = CType(resources.GetObject("ButtonVentas.Image"), System.Drawing.Image)
        Me.ButtonVentas.Location = New System.Drawing.Point(80, 169)
        Me.ButtonVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Size = New System.Drawing.Size(163, 133)
        Me.ButtonVentas.TabIndex = 10
        Me.ButtonVentas.Text = "Ventas"
        Me.ButtonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonVentas.UseVisualStyleBackColor = False
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.BackColor = System.Drawing.Color.White
        Me.ButtonUsuarios.FlatAppearance.BorderSize = 0
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuarios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonUsuarios.Image = CType(resources.GetObject("ButtonUsuarios.Image"), System.Drawing.Image)
        Me.ButtonUsuarios.Location = New System.Drawing.Point(388, 169)
        Me.ButtonUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(163, 133)
        Me.ButtonUsuarios.TabIndex = 11
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.White
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LabelVentaEspe.Location = New System.Drawing.Point(156, 63)
        Me.LabelVentaEspe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(609, 58)
        Me.LabelVentaEspe.TabIndex = 17
        Me.LabelVentaEspe.Text = "Bienvenido a Herrería Zar!"
        '
        'ButtonProfile
        '
        Me.ButtonProfile.FlatAppearance.BorderSize = 0
        Me.ButtonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonProfile.Image = CType(resources.GetObject("ButtonProfile.Image"), System.Drawing.Image)
        Me.ButtonProfile.Location = New System.Drawing.Point(887, 15)
        Me.ButtonProfile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonProfile.Name = "ButtonProfile"
        Me.ButtonProfile.Size = New System.Drawing.Size(55, 48)
        Me.ButtonProfile.TabIndex = 2
        Me.ButtonProfile.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(783, 30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 18)
        Me.TextBox1.TabIndex = 19
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 494)
        Me.Controls.Add(Me.LabelVentaEspe)
        Me.Controls.Add(Me.ButtonReporte)
        Me.Controls.Add(Me.ButtonPedidos)
        Me.Controls.Add(Me.ButtonCatálogo)
        Me.Controls.Add(Me.ButtonPagos)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.ButtonUsuarios)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.ButtonProfile)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Herreria Zar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents ButtonReporte As Button
    Friend WithEvents ButtonPedidos As Button
    Friend WithEvents ButtonCatálogo As Button
    Friend WithEvents ButtonPagos As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents ButtonProfile As Button
    Friend WithEvents TextBox1 As TextBox
End Class
