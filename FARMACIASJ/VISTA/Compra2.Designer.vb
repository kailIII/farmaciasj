<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Numero_Factura = New System.Windows.Forms.TextBox
        Me.RIF_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SUB_TOTAL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.IMPUESTO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DESCUENTO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Procesar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'Numero_Factura
        '
        Me.Numero_Factura.Enabled = False
        Me.Numero_Factura.Location = New System.Drawing.Point(114, 23)
        Me.Numero_Factura.Margin = New System.Windows.Forms.Padding(4)
        Me.Numero_Factura.Name = "Numero_Factura"
        Me.Numero_Factura.Size = New System.Drawing.Size(212, 22)
        Me.Numero_Factura.TabIndex = 1
        '
        'RIF_PROVEEDOR
        '
        Me.RIF_PROVEEDOR.Enabled = False
        Me.RIF_PROVEEDOR.Location = New System.Drawing.Point(114, 55)
        Me.RIF_PROVEEDOR.Margin = New System.Windows.Forms.Padding(4)
        Me.RIF_PROVEEDOR.Name = "RIF_PROVEEDOR"
        Me.RIF_PROVEEDOR.Size = New System.Drawing.Size(212, 22)
        Me.RIF_PROVEEDOR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "R.I.F:"
        '
        'SUB_TOTAL
        '
        Me.SUB_TOTAL.Enabled = False
        Me.SUB_TOTAL.Location = New System.Drawing.Point(114, 87)
        Me.SUB_TOTAL.Margin = New System.Windows.Forms.Padding(4)
        Me.SUB_TOTAL.Name = "SUB_TOTAL"
        Me.SUB_TOTAL.Size = New System.Drawing.Size(212, 22)
        Me.SUB_TOTAL.TabIndex = 5
        Me.SUB_TOTAL.Text = "0"
        Me.SUB_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sub-Total"
        '
        'IMPUESTO
        '
        Me.IMPUESTO.Location = New System.Drawing.Point(114, 119)
        Me.IMPUESTO.Margin = New System.Windows.Forms.Padding(4)
        Me.IMPUESTO.MaxLength = 10
        Me.IMPUESTO.Name = "IMPUESTO"
        Me.IMPUESTO.Size = New System.Drawing.Size(212, 22)
        Me.IMPUESTO.TabIndex = 7
        Me.IMPUESTO.Text = "0"
        Me.IMPUESTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Impuestos"
        '
        'DESCUENTO
        '
        Me.DESCUENTO.Location = New System.Drawing.Point(114, 151)
        Me.DESCUENTO.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCUENTO.MaxLength = 10
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Size = New System.Drawing.Size(212, 22)
        Me.DESCUENTO.TabIndex = 9
        Me.DESCUENTO.Text = "0"
        Me.DESCUENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descuento"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(114, 183)
        Me.Total.Margin = New System.Windows.Forms.Padding(4)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(212, 22)
        Me.Total.TabIndex = 11
        Me.Total.Text = "0"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total"
        '
        'Procesar
        '
        Me.Procesar.Location = New System.Drawing.Point(216, 215)
        Me.Procesar.Margin = New System.Windows.Forms.Padding(4)
        Me.Procesar.Name = "Procesar"
        Me.Procesar.Size = New System.Drawing.Size(112, 28)
        Me.Procesar.TabIndex = 12
        Me.Procesar.Text = "Procesar"
        Me.Procesar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SUB_TOTAL)
        Me.GroupBox1.Controls.Add(Me.Procesar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Numero_Factura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DESCUENTO)
        Me.GroupBox1.Controls.Add(Me.RIF_PROVEEDOR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.IMPUESTO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(346, 258)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra"
        '
        'Compra2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Compra2"
        Me.Text = "Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Numero_Factura As System.Windows.Forms.TextBox
    Friend WithEvents RIF_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SUB_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IMPUESTO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DESCUENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Procesar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
