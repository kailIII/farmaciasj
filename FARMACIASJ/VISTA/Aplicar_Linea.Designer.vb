<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicar_Linea
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
        Me.Lineas1 = New System.Windows.Forms.ListBox
        Me.der = New System.Windows.Forms.Button
        Me.izq = New System.Windows.Forms.Button
        Me.Lineas2 = New System.Windows.Forms.ListBox
        Me.BotonAplicar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Impuesto = New System.Windows.Forms.TextBox
        Me.Valor = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Lineas1
        '
        Me.Lineas1.FormattingEnabled = True
        Me.Lineas1.ItemHeight = 16
        Me.Lineas1.Location = New System.Drawing.Point(36, 86)
        Me.Lineas1.Margin = New System.Windows.Forms.Padding(4)
        Me.Lineas1.Name = "Lineas1"
        Me.Lineas1.Size = New System.Drawing.Size(290, 228)
        Me.Lineas1.TabIndex = 0
        '
        'der
        '
        Me.der.Location = New System.Drawing.Point(338, 122)
        Me.der.Margin = New System.Windows.Forms.Padding(4)
        Me.der.Name = "der"
        Me.der.Size = New System.Drawing.Size(68, 44)
        Me.der.TabIndex = 1
        Me.der.Text = ">"
        Me.der.UseVisualStyleBackColor = True
        '
        'izq
        '
        Me.izq.Location = New System.Drawing.Point(338, 223)
        Me.izq.Margin = New System.Windows.Forms.Padding(4)
        Me.izq.Name = "izq"
        Me.izq.Size = New System.Drawing.Size(68, 44)
        Me.izq.TabIndex = 2
        Me.izq.Text = "<"
        Me.izq.UseVisualStyleBackColor = True
        '
        'Lineas2
        '
        Me.Lineas2.FormattingEnabled = True
        Me.Lineas2.ItemHeight = 16
        Me.Lineas2.Location = New System.Drawing.Point(414, 86)
        Me.Lineas2.Margin = New System.Windows.Forms.Padding(4)
        Me.Lineas2.Name = "Lineas2"
        Me.Lineas2.Size = New System.Drawing.Size(290, 228)
        Me.Lineas2.TabIndex = 3
        '
        'BotonAplicar
        '
        Me.BotonAplicar.Location = New System.Drawing.Point(594, 322)
        Me.BotonAplicar.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonAplicar.Name = "BotonAplicar"
        Me.BotonAplicar.Size = New System.Drawing.Size(112, 28)
        Me.BotonAplicar.TabIndex = 4
        Me.BotonAplicar.Text = "Aplicar"
        Me.BotonAplicar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "L�neas sin Impuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "L�neas con Impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Impuesto"
        '
        'Impuesto
        '
        Me.Impuesto.Enabled = False
        Me.Impuesto.Location = New System.Drawing.Point(116, 26)
        Me.Impuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Size = New System.Drawing.Size(211, 22)
        Me.Impuesto.TabIndex = 8
        '
        'Valor
        '
        Me.Valor.Enabled = False
        Me.Valor.Location = New System.Drawing.Point(464, 26)
        Me.Valor.Margin = New System.Windows.Forms.Padding(4)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(241, 22)
        Me.Valor.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor"
        '
        'Aplicar_Linea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 364)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Impuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BotonAplicar)
        Me.Controls.Add(Me.Lineas2)
        Me.Controls.Add(Me.izq)
        Me.Controls.Add(Me.der)
        Me.Controls.Add(Me.Lineas1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Aplicar_Linea"
        Me.Text = "Aplicar_Linea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lineas1 As System.Windows.Forms.ListBox
    Friend WithEvents der As System.Windows.Forms.Button
    Friend WithEvents izq As System.Windows.Forms.Button
    Friend WithEvents Lineas2 As System.Windows.Forms.ListBox
    Friend WithEvents BotonAplicar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Impuesto As System.Windows.Forms.TextBox
    Friend WithEvents Valor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
