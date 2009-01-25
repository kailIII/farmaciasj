<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_compra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CRestar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DESCUENTO = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.PVP = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.FVENCE = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.CTotal = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CUnidad = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NOMBRE_PRODUCTO = New System.Windows.Forms.TextBox
        Me.CODIGO_BARRAS = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DETALLE_COMPRA = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.NOMBRE_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.RIF_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.NDETALLE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DETALLE_COMPRA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(743, 575)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 34)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CRestar)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.DESCUENTO)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.PVP)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.FVENCE)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.CTotal)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.CUnidad)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Cantidad)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 414)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(841, 153)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lote/Detalle_Compra"
        '
        'CRestar
        '
        Me.CRestar.Enabled = False
        Me.CRestar.Location = New System.Drawing.Point(152, 55)
        Me.CRestar.Margin = New System.Windows.Forms.Padding(4)
        Me.CRestar.Name = "CRestar"
        Me.CRestar.Size = New System.Drawing.Size(148, 22)
        Me.CRestar.TabIndex = 16
        Me.CRestar.Text = "0"
        Me.CRestar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cantidad a Restar"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(693, 116)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DESCUENTO
        '
        Me.DESCUENTO.Enabled = False
        Me.DESCUENTO.Location = New System.Drawing.Point(466, 114)
        Me.DESCUENTO.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCUENTO.MaxLength = 3
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Size = New System.Drawing.Size(199, 22)
        Me.DESCUENTO.TabIndex = 13
        Me.DESCUENTO.Text = "0"
        Me.DESCUENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Enabled = False
        Me.Label25.Location = New System.Drawing.Point(328, 118)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 16)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Descuento %"
        '
        'PVP
        '
        Me.PVP.Enabled = False
        Me.PVP.Location = New System.Drawing.Point(466, 82)
        Me.PVP.Margin = New System.Windows.Forms.Padding(4)
        Me.PVP.MaxLength = 10
        Me.PVP.Name = "PVP"
        Me.PVP.Size = New System.Drawing.Size(199, 22)
        Me.PVP.TabIndex = 11
        Me.PVP.Text = "0"
        Me.PVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Location = New System.Drawing.Point(332, 86)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 16)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "PVP"
        '
        'FVENCE
        '
        Me.FVENCE.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.FVENCE.Enabled = False
        Me.FVENCE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FVENCE.Location = New System.Drawing.Point(466, 50)
        Me.FVENCE.Margin = New System.Windows.Forms.Padding(4)
        Me.FVENCE.Name = "FVENCE"
        Me.FVENCE.Size = New System.Drawing.Size(199, 22)
        Me.FVENCE.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Location = New System.Drawing.Point(332, 53)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 16)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Fecha_Vence"
        '
        'CTotal
        '
        Me.CTotal.Enabled = False
        Me.CTotal.Location = New System.Drawing.Point(152, 119)
        Me.CTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.CTotal.Name = "CTotal"
        Me.CTotal.Size = New System.Drawing.Size(148, 22)
        Me.CTotal.TabIndex = 7
        Me.CTotal.Text = "0"
        Me.CTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 123)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Costo Total"
        '
        'CUnidad
        '
        Me.CUnidad.Enabled = False
        Me.CUnidad.Location = New System.Drawing.Point(152, 87)
        Me.CUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.CUnidad.Name = "CUnidad"
        Me.CUnidad.Size = New System.Drawing.Size(148, 22)
        Me.CUnidad.TabIndex = 5
        Me.CUnidad.Text = "0"
        Me.CUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 91)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 16)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Costo Unidad"
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(152, 23)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(148, 22)
        Me.Cantidad.TabIndex = 3
        Me.Cantidad.Text = "0"
        Me.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 27)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Cantidad"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.NOMBRE_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.CODIGO_BARRAS)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 341)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(841, 65)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(334, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Nombre"
        '
        'NOMBRE_PRODUCTO
        '
        Me.NOMBRE_PRODUCTO.Enabled = False
        Me.NOMBRE_PRODUCTO.Location = New System.Drawing.Point(472, 23)
        Me.NOMBRE_PRODUCTO.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO"
        Me.NOMBRE_PRODUCTO.Size = New System.Drawing.Size(337, 22)
        Me.NOMBRE_PRODUCTO.TabIndex = 12
        '
        'CODIGO_BARRAS
        '
        Me.CODIGO_BARRAS.Enabled = False
        Me.CODIGO_BARRAS.Location = New System.Drawing.Point(158, 23)
        Me.CODIGO_BARRAS.Margin = New System.Windows.Forms.Padding(4)
        Me.CODIGO_BARRAS.Name = "CODIGO_BARRAS"
        Me.CODIGO_BARRAS.Size = New System.Drawing.Size(148, 22)
        Me.CODIGO_BARRAS.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Código"
        '
        'DETALLE_COMPRA
        '
        Me.DETALLE_COMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_COMPRA.Location = New System.Drawing.Point(21, 176)
        Me.DETALLE_COMPRA.Margin = New System.Windows.Forms.Padding(4)
        Me.DETALLE_COMPRA.Name = "DETALLE_COMPRA"
        Me.DETALLE_COMPRA.Size = New System.Drawing.Size(842, 121)
        Me.DETALLE_COMPRA.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NOMBRE_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.RIF_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 94)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(845, 75)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(423, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Razón Social:"
        '
        'NOMBRE_PROVEEDOR
        '
        Me.NOMBRE_PROVEEDOR.Enabled = False
        Me.NOMBRE_PROVEEDOR.Location = New System.Drawing.Point(537, 28)
        Me.NOMBRE_PROVEEDOR.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRE_PROVEEDOR.Name = "NOMBRE_PROVEEDOR"
        Me.NOMBRE_PROVEEDOR.Size = New System.Drawing.Size(276, 22)
        Me.NOMBRE_PROVEEDOR.TabIndex = 2
        '
        'RIF_PROVEEDOR
        '
        Me.RIF_PROVEEDOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RIF_PROVEEDOR.Enabled = False
        Me.RIF_PROVEEDOR.Location = New System.Drawing.Point(98, 28)
        Me.RIF_PROVEEDOR.Margin = New System.Windows.Forms.Padding(4)
        Me.RIF_PROVEEDOR.Name = "RIF_PROVEEDOR"
        Me.RIF_PROVEEDOR.Size = New System.Drawing.Size(304, 22)
        Me.RIF_PROVEEDOR.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "R.I.F:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Numero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(845, 68)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(668, 23)
        Me.Numero.Margin = New System.Windows.Forms.Padding(4)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(148, 22)
        Me.Numero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Número"
        '
        'NDETALLE
        '
        Me.NDETALLE.Location = New System.Drawing.Point(182, 311)
        Me.NDETALLE.Margin = New System.Windows.Forms.Padding(4)
        Me.NDETALLE.MaxLength = 2
        Me.NDETALLE.Name = "NDETALLE"
        Me.NDETALLE.Size = New System.Drawing.Size(148, 22)
        Me.NDETALLE.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 315)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Número detalle"
        '
        'Modificar_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 615)
        Me.Controls.Add(Me.NDETALLE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DETALLE_COMPRA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Modificar_compra"
        Me.Text = "Modificar compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DETALLE_COMPRA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DESCUENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PVP As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents FVENCE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_PRODUCTO As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_BARRAS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DETALLE_COMPRA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents RIF_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NDETALLE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CRestar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
