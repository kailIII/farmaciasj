<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Compra
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Vence = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.DETALLE_COMPRA = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NOMBRE_PRODUCTO = New System.Windows.Forms.TextBox
        Me.CODIGO_BARRAS = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Subtotal = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RIF_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.NOMBRE_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DETALLE_COMPRA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Numero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Vence)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(445, 19)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(100, 20)
        Me.Numero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vence"
        '
        'Vence
        '
        Me.Vence.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.Vence.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Vence.Location = New System.Drawing.Point(256, 20)
        Me.Vence.Name = "Vence"
        Me.Vence.Size = New System.Drawing.Size(132, 20)
        Me.Vence.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(60, 19)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(134, 20)
        Me.Fecha.TabIndex = 0
        '
        'DETALLE_COMPRA
        '
        Me.DETALLE_COMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_COMPRA.Location = New System.Drawing.Point(13, 143)
        Me.DETALLE_COMPRA.Name = "DETALLE_COMPRA"
        Me.DETALLE_COMPRA.Size = New System.Drawing.Size(561, 98)
        Me.DETALLE_COMPRA.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.NOMBRE_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.CODIGO_BARRAS)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 53)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(325, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Nombre"
        '
        'NOMBRE_PRODUCTO
        '
        Me.NOMBRE_PRODUCTO.Enabled = False
        Me.NOMBRE_PRODUCTO.Location = New System.Drawing.Point(425, 17)
        Me.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO"
        Me.NOMBRE_PRODUCTO.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_PRODUCTO.TabIndex = 12
        '
        'CODIGO_BARRAS
        '
        Me.CODIGO_BARRAS.Location = New System.Drawing.Point(114, 17)
        Me.CODIGO_BARRAS.Name = "CODIGO_BARRAS"
        Me.CODIGO_BARRAS.Size = New System.Drawing.Size(100, 20)
        Me.CODIGO_BARRAS.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Codigo"
        '
        'GroupBox5
        '
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
        Me.GroupBox5.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(555, 101)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lote/Detalle_Compra"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DESCUENTO
        '
        Me.DESCUENTO.Location = New System.Drawing.Point(296, 70)
        Me.DESCUENTO.MaxLength = 3
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Size = New System.Drawing.Size(134, 20)
        Me.DESCUENTO.TabIndex = 13
        Me.DESCUENTO.Text = "0"
        Me.DESCUENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(204, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Descuento %"
        '
        'PVP
        '
        Me.PVP.Location = New System.Drawing.Point(296, 44)
        Me.PVP.MaxLength = 10
        Me.PVP.Name = "PVP"
        Me.PVP.Size = New System.Drawing.Size(134, 20)
        Me.PVP.TabIndex = 11
        Me.PVP.Text = "0"
        Me.PVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(206, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(28, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "PVP"
        '
        'FVENCE
        '
        Me.FVENCE.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.FVENCE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FVENCE.Location = New System.Drawing.Point(296, 18)
        Me.FVENCE.Name = "FVENCE"
        Me.FVENCE.Size = New System.Drawing.Size(134, 20)
        Me.FVENCE.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(206, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Fecha_Vence"
        '
        'CTotal
        '
        Me.CTotal.Enabled = False
        Me.CTotal.Location = New System.Drawing.Point(86, 74)
        Me.CTotal.Name = "CTotal"
        Me.CTotal.Size = New System.Drawing.Size(100, 20)
        Me.CTotal.TabIndex = 7
        Me.CTotal.Text = "0"
        Me.CTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Costo_Total"
        '
        'CUnidad
        '
        Me.CUnidad.Location = New System.Drawing.Point(86, 48)
        Me.CUnidad.Name = "CUnidad"
        Me.CUnidad.Size = New System.Drawing.Size(100, 20)
        Me.CUnidad.TabIndex = 5
        Me.CUnidad.Text = "0"
        Me.CUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Costo_Unidad"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(86, 19)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad.TabIndex = 3
        Me.Cantidad.Text = "0"
        Me.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Cantidad"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(490, 416)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Subtotal
        '
        Me.Subtotal.Location = New System.Drawing.Point(98, 413)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(100, 20)
        Me.Subtotal.TabIndex = 9
        Me.Subtotal.Text = "0"
        Me.Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(18, 416)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Sub-Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RIF"
        '
        'RIF_PROVEEDOR
        '
        Me.RIF_PROVEEDOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RIF_PROVEEDOR.Location = New System.Drawing.Point(65, 23)
        Me.RIF_PROVEEDOR.Name = "RIF_PROVEEDOR"
        Me.RIF_PROVEEDOR.Size = New System.Drawing.Size(204, 20)
        Me.RIF_PROVEEDOR.TabIndex = 1
        '
        'NOMBRE_PROVEEDOR
        '
        Me.NOMBRE_PROVEEDOR.Enabled = False
        Me.NOMBRE_PROVEEDOR.Location = New System.Drawing.Point(358, 23)
        Me.NOMBRE_PROVEEDOR.Name = "NOMBRE_PROVEEDOR"
        Me.NOMBRE_PROVEEDOR.Size = New System.Drawing.Size(185, 20)
        Me.NOMBRE_PROVEEDOR.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Razon Social"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NOMBRE_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.RIF_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 61)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'Registrar_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 454)
        Me.Controls.Add(Me.Subtotal)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DETALLE_COMPRA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar_Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DETALLE_COMPRA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DETALLE_COMPRA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CODIGO_BARRAS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_PRODUCTO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DESCUENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PVP As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents FVENCE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RIF_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
