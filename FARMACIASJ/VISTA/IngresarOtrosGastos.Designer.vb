<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarOtrosGastos
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
        Me.Monto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.Descripcion = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto:"
        '
        'Monto
        '
        Me.Monto.Location = New System.Drawing.Point(111, 23)
        Me.Monto.Margin = New System.Windows.Forms.Padding(4)
        Me.Monto.Name = "Monto"
        Me.Monto.Size = New System.Drawing.Size(148, 22)
        Me.Monto.TabIndex = 1
        Me.Monto.Text = "0"
        Me.Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy"
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(111, 55)
        Me.Fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(190, 22)
        Me.Fecha.TabIndex = 3
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(9, 113)
        Me.Descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion.MaxLength = 214
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(292, 136)
        Me.Descripcion.TabIndex = 4
        Me.Descripcion.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 257)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Monto)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(324, 299)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar otros gastos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "BsF"
        '
        'IngresarOtrosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "IngresarOtrosGastos"
        Me.Text = "Ingresar Otros Gastos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Monto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
