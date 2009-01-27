<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicar_Impuesto
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
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.RichTextBox
        Me.Valor = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Justificacion = New System.Windows.Forms.RichTextBox
        Me.LJustificacion = New System.Windows.Forms.Label
        Me.Modificar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(122, 22)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(276, 22)
        Me.Nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'Descripcion
        '
        Me.Descripcion.Enabled = False
        Me.Descripcion.Location = New System.Drawing.Point(122, 52)
        Me.Descripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(276, 128)
        Me.Descripcion.TabIndex = 3
        Me.Descripcion.Text = ""
        '
        'Valor
        '
        Me.Valor.Enabled = False
        Me.Valor.Location = New System.Drawing.Point(122, 187)
        Me.Valor.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Valor.MaxLength = 3
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(276, 22)
        Me.Valor.TabIndex = 15
        Me.Valor.Text = "0"
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 190)
        Me.Label25.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 16)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Valor %:"
        '
        'Justificacion
        '
        Me.Justificacion.Location = New System.Drawing.Point(122, 254)
        Me.Justificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Justificacion.Name = "Justificacion"
        Me.Justificacion.Size = New System.Drawing.Size(276, 128)
        Me.Justificacion.TabIndex = 17
        Me.Justificacion.Text = ""
        Me.Justificacion.Visible = False
        '
        'LJustificacion
        '
        Me.LJustificacion.AutoSize = True
        Me.LJustificacion.Location = New System.Drawing.Point(7, 257)
        Me.LJustificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LJustificacion.Name = "LJustificacion"
        Me.LJustificacion.Size = New System.Drawing.Size(98, 16)
        Me.LJustificacion.TabIndex = 16
        Me.LJustificacion.Text = "Justificacion:"
        Me.LJustificacion.Visible = False
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(286, 218)
        Me.Modificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(112, 28)
        Me.Modificar.TabIndex = 18
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        Me.Modificar.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 390)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Justificacion)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.LJustificacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Controls.Add(Me.Valor)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 445)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impuesto"
        '
        'Aplicar_Impuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Aplicar_Impuesto"
        Me.Text = "Aplicar Impuesto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Valor As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Justificacion As System.Windows.Forms.RichTextBox
    Friend WithEvents LJustificacion As System.Windows.Forms.Label
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
