<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Numero_ID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Stotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Impuestos = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.LVuelto = New System.Windows.Forms.Label
        Me.Vuelto = New System.Windows.Forms.TextBox
        Me.LNCT = New System.Windows.Forms.Label
        Me.NCT = New System.Windows.Forms.TextBox
        Me.LMonto = New System.Windows.Forms.Label
        Me.Monto = New System.Windows.Forms.TextBox
        Me.Vencimiento = New System.Windows.Forms.DateTimePicker
        Me.LFVencimiento = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero"
        '
        'Numero_Factura
        '
        Me.Numero_Factura.Enabled = False
        Me.Numero_Factura.Location = New System.Drawing.Point(148, 9)
        Me.Numero_Factura.Name = "Numero_Factura"
        Me.Numero_Factura.Size = New System.Drawing.Size(100, 20)
        Me.Numero_Factura.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero ID Cliente"
        '
        'Numero_ID
        '
        Me.Numero_ID.Enabled = False
        Me.Numero_ID.Location = New System.Drawing.Point(148, 35)
        Me.Numero_ID.Name = "Numero_ID"
        Me.Numero_ID.Size = New System.Drawing.Size(100, 20)
        Me.Numero_ID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sub-Total"
        '
        'Stotal
        '
        Me.Stotal.Enabled = False
        Me.Stotal.Location = New System.Drawing.Point(148, 61)
        Me.Stotal.Name = "Stotal"
        Me.Stotal.Size = New System.Drawing.Size(100, 20)
        Me.Stotal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Impuestos"
        '
        'Impuestos
        '
        Me.Impuestos.Enabled = False
        Me.Impuestos.Location = New System.Drawing.Point(148, 87)
        Me.Impuestos.Name = "Impuestos"
        Me.Impuestos.Size = New System.Drawing.Size(100, 20)
        Me.Impuestos.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(148, 113)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Forma De Pago"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"EFECTIVO", "CHEKE", "TARJETA_DEBITO", "TARJETA_CREDITO"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 140)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'LVuelto
        '
        Me.LVuelto.AutoSize = True
        Me.LVuelto.Location = New System.Drawing.Point(19, 196)
        Me.LVuelto.Name = "LVuelto"
        Me.LVuelto.Size = New System.Drawing.Size(37, 13)
        Me.LVuelto.TabIndex = 19
        Me.LVuelto.Text = "Vuelto"
        Me.LVuelto.Visible = False
        '
        'Vuelto
        '
        Me.Vuelto.Location = New System.Drawing.Point(148, 193)
        Me.Vuelto.Name = "Vuelto"
        Me.Vuelto.Size = New System.Drawing.Size(100, 20)
        Me.Vuelto.TabIndex = 18
        Me.Vuelto.Visible = False
        '
        'LNCT
        '
        Me.LNCT.AutoSize = True
        Me.LNCT.Location = New System.Drawing.Point(19, 171)
        Me.LNCT.Name = "LNCT"
        Me.LNCT.Size = New System.Drawing.Size(125, 13)
        Me.LNCT.TabIndex = 17
        Me.LNCT.Text = "Numero_Cheque/Tarjeta"
        Me.LNCT.Visible = False
        '
        'NCT
        '
        Me.NCT.Location = New System.Drawing.Point(148, 168)
        Me.NCT.Name = "NCT"
        Me.NCT.Size = New System.Drawing.Size(100, 20)
        Me.NCT.TabIndex = 16
        Me.NCT.Visible = False
        '
        'LMonto
        '
        Me.LMonto.AutoSize = True
        Me.LMonto.Location = New System.Drawing.Point(19, 171)
        Me.LMonto.Name = "LMonto"
        Me.LMonto.Size = New System.Drawing.Size(31, 13)
        Me.LMonto.TabIndex = 15
        Me.LMonto.Text = "Moto"
        Me.LMonto.Visible = False
        '
        'Monto
        '
        Me.Monto.Location = New System.Drawing.Point(148, 168)
        Me.Monto.Name = "Monto"
        Me.Monto.Size = New System.Drawing.Size(100, 20)
        Me.Monto.TabIndex = 14
        Me.Monto.Visible = False
        '
        'Vencimiento
        '
        Me.Vencimiento.CustomFormat = "dd/MM/yyyy"
        Me.Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Vencimiento.Location = New System.Drawing.Point(148, 193)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Size = New System.Drawing.Size(100, 20)
        Me.Vencimiento.TabIndex = 20
        Me.Vencimiento.Visible = False
        '
        'LFVencimiento
        '
        Me.LFVencimiento.AutoSize = True
        Me.LFVencimiento.Location = New System.Drawing.Point(19, 197)
        Me.LFVencimiento.Name = "LFVencimiento"
        Me.LFVencimiento.Size = New System.Drawing.Size(98, 13)
        Me.LFVencimiento.TabIndex = 21
        Me.LFVencimiento.Text = "Fecha Vencimiento"
        Me.LFVencimiento.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 255)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LFVencimiento)
        Me.Controls.Add(Me.Vencimiento)
        Me.Controls.Add(Me.LVuelto)
        Me.Controls.Add(Me.Vuelto)
        Me.Controls.Add(Me.LNCT)
        Me.Controls.Add(Me.NCT)
        Me.Controls.Add(Me.LMonto)
        Me.Controls.Add(Me.Monto)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Impuestos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Stotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Numero_ID)
        Me.Controls.Add(Me.Numero_Factura)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Numero_Factura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Numero_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Stotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Impuestos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LVuelto As System.Windows.Forms.Label
    Friend WithEvents Vuelto As System.Windows.Forms.TextBox
    Friend WithEvents LNCT As System.Windows.Forms.Label
    Friend WithEvents NCT As System.Windows.Forms.TextBox
    Friend WithEvents LMonto As System.Windows.Forms.Label
    Friend WithEvents Monto As System.Windows.Forms.TextBox
    Friend WithEvents Vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LFVencimiento As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
