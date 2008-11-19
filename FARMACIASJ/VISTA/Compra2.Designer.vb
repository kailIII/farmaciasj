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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero"
        '
        'Numero_Factura
        '
        Me.Numero_Factura.Enabled = False
        Me.Numero_Factura.Location = New System.Drawing.Point(126, 10)
        Me.Numero_Factura.Name = "Numero_Factura"
        Me.Numero_Factura.Size = New System.Drawing.Size(100, 20)
        Me.Numero_Factura.TabIndex = 1
        '
        'RIF_PROVEEDOR
        '
        Me.RIF_PROVEEDOR.Enabled = False
        Me.RIF_PROVEEDOR.Location = New System.Drawing.Point(126, 36)
        Me.RIF_PROVEEDOR.Name = "RIF_PROVEEDOR"
        Me.RIF_PROVEEDOR.Size = New System.Drawing.Size(100, 20)
        Me.RIF_PROVEEDOR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RIF_PROVEEDOR"
        '
        'SUB_TOTAL
        '
        Me.SUB_TOTAL.Enabled = False
        Me.SUB_TOTAL.Location = New System.Drawing.Point(126, 62)
        Me.SUB_TOTAL.Name = "SUB_TOTAL"
        Me.SUB_TOTAL.Size = New System.Drawing.Size(100, 20)
        Me.SUB_TOTAL.TabIndex = 5
        Me.SUB_TOTAL.Text = "0"
        Me.SUB_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sub-Total"
        '
        'IMPUESTO
        '
        Me.IMPUESTO.Location = New System.Drawing.Point(126, 88)
        Me.IMPUESTO.Name = "IMPUESTO"
        Me.IMPUESTO.Size = New System.Drawing.Size(100, 20)
        Me.IMPUESTO.TabIndex = 7
        Me.IMPUESTO.Text = "0"
        Me.IMPUESTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Impuestos"
        '
        'DESCUENTO
        '
        Me.DESCUENTO.Location = New System.Drawing.Point(126, 114)
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Size = New System.Drawing.Size(100, 20)
        Me.DESCUENTO.TabIndex = 9
        Me.DESCUENTO.Text = "0"
        Me.DESCUENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descuento"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(126, 140)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 11
        Me.Total.Text = "0"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total"
        '
        'Procesar
        '
        Me.Procesar.Location = New System.Drawing.Point(151, 166)
        Me.Procesar.Name = "Procesar"
        Me.Procesar.Size = New System.Drawing.Size(75, 23)
        Me.Procesar.TabIndex = 12
        Me.Procesar.Text = "Procesar"
        Me.Procesar.UseVisualStyleBackColor = True
        '
        'Compra2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 208)
        Me.Controls.Add(Me.Procesar)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DESCUENTO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IMPUESTO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SUB_TOTAL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RIF_PROVEEDOR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Numero_Factura)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Compra2"
        Me.Text = "Compra2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
