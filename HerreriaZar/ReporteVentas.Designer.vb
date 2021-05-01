<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteVentas))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonCatálogo = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.LabelVentaEspe = New System.Windows.Forms.Label()
        Me.DTPpre = New System.Windows.Forms.DateTimePicker()
        Me.BotonAñadir = New System.Windows.Forms.Button()
        Me.DTPdes = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVreporte = New System.Windows.Forms.DataGridView()
        CType(Me.DGVreporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(-1, 310)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 82)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Pedidos"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 82)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Menu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(-1, 468)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 82)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "  Reporte "
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ButtonCatálogo
        '
        Me.ButtonCatálogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonCatálogo.FlatAppearance.BorderSize = 0
        Me.ButtonCatálogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCatálogo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCatálogo.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCatálogo.Image = CType(resources.GetObject("ButtonCatálogo.Image"), System.Drawing.Image)
        Me.ButtonCatálogo.Location = New System.Drawing.Point(-1, 389)
        Me.ButtonCatálogo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCatálogo.Name = "ButtonCatálogo"
        Me.ButtonCatálogo.Size = New System.Drawing.Size(139, 82)
        Me.ButtonCatálogo.TabIndex = 6
        Me.ButtonCatálogo.Text = " Catálogo"
        Me.ButtonCatálogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCatálogo.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonPagos.FlatAppearance.BorderSize = 0
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagos.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonPagos.Image = CType(resources.GetObject("ButtonPagos.Image"), System.Drawing.Image)
        Me.ButtonPagos.Location = New System.Drawing.Point(-1, 234)
        Me.ButtonPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(139, 82)
        Me.ButtonPagos.TabIndex = 5
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonUsuarios.FlatAppearance.BorderSize = 0
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonUsuarios.Image = CType(resources.GetObject("ButtonUsuarios.Image"), System.Drawing.Image)
        Me.ButtonUsuarios.Location = New System.Drawing.Point(-1, 156)
        Me.ButtonUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(139, 82)
        Me.ButtonUsuarios.TabIndex = 4
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'ButtonVentas
        '
        Me.ButtonVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ButtonVentas.FlatAppearance.BorderSize = 0
        Me.ButtonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVentas.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVentas.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonVentas.Image = CType(resources.GetObject("ButtonVentas.Image"), System.Drawing.Image)
        Me.ButtonVentas.Location = New System.Drawing.Point(-1, 78)
        Me.ButtonVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Size = New System.Drawing.Size(139, 82)
        Me.ButtonVentas.TabIndex = 3
        Me.ButtonVentas.Text = "Ventas"
        Me.ButtonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonVentas.UseVisualStyleBackColor = False
        '
        'LabelVentaEspe
        '
        Me.LabelVentaEspe.AutoSize = True
        Me.LabelVentaEspe.BackColor = System.Drawing.Color.White
        Me.LabelVentaEspe.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentaEspe.Location = New System.Drawing.Point(307, 9)
        Me.LabelVentaEspe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVentaEspe.Name = "LabelVentaEspe"
        Me.LabelVentaEspe.Size = New System.Drawing.Size(367, 50)
        Me.LabelVentaEspe.TabIndex = 10
        Me.LabelVentaEspe.Text = "Reporte de Ventas"
        '
        'DTPpre
        '
        Me.DTPpre.Location = New System.Drawing.Point(243, 105)
        Me.DTPpre.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPpre.Name = "DTPpre"
        Me.DTPpre.Size = New System.Drawing.Size(260, 22)
        Me.DTPpre.TabIndex = 12
        '
        'BotonAñadir
        '
        Me.BotonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BotonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAñadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAñadir.ForeColor = System.Drawing.SystemColors.Control
        Me.BotonAñadir.Location = New System.Drawing.Point(729, 468)
        Me.BotonAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(125, 43)
        Me.BotonAñadir.TabIndex = 33
        Me.BotonAñadir.Text = "Generar"
        Me.BotonAñadir.UseVisualStyleBackColor = False
        '
        'DTPdes
        '
        Me.DTPdes.Location = New System.Drawing.Point(594, 105)
        Me.DTPdes.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPdes.Name = "DTPdes"
        Me.DTPdes.Size = New System.Drawing.Size(260, 22)
        Me.DTPdes.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "De:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "A:"
        '
        'DGVreporte
        '
        Me.DGVreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVreporte.Location = New System.Drawing.Point(243, 166)
        Me.DGVreporte.Name = "DGVreporte"
        Me.DGVreporte.RowHeadersWidth = 51
        Me.DGVreporte.RowTemplate.Height = 24
        Me.DGVreporte.Size = New System.Drawing.Size(611, 279)
        Me.DGVreporte.TabIndex = 38
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 552)
        Me.Controls.Add(Me.DGVreporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPdes)
        Me.Controls.Add(Me.BotonAñadir)
        Me.Controls.Add(Me.DTPpre)
        Me.Controls.Add(Me.LabelVentaEspe)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonCatálogo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPagos)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.ButtonUsuarios)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteVentas"
        CType(Me.DGVreporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ButtonCatálogo As Button
    Friend WithEvents ButtonPagos As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents LabelVentaEspe As Label
    Friend WithEvents DTPpre As DateTimePicker
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents DTPdes As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVreporte As DataGridView
End Class
