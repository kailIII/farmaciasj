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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(174, 38)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(276, 22)
        Me.Nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        '
        'Descripcion
        '
        Me.Descripcion.Enabled = False
        Me.Descripcion.Location = New System.Drawing.Point(174, 76)
        Me.Descripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(276, 128)
        Me.Descripcion.TabIndex = 3
        Me.Descripcion.Text = ""
        '
        'Valor
        '
        Me.Valor.Enabled = False
        Me.Valor.Location = New System.Drawing.Point(174, 215)
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
        Me.Label25.Location = New System.Drawing.Point(15, 216)
        Me.Label25.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 16)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Valor %"
        '
        'Justificacion
        '
        Me.Justificacion.Location = New System.Drawing.Point(174, 249)
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
        Me.LJustificacion.Location = New System.Drawing.Point(13, 252)
        Me.LJustificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LJustificacion.Name = "LJustificacion"
        Me.LJustificacion.Size = New System.Drawing.Size(94, 16)
        Me.LJustificacion.TabIndex = 16
        Me.LJustificacion.Text = "Justificación"
        Me.LJustificacion.Visible = False
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(464, 210)
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
        Me.Button1.Location = New System.Drawing.Point(260, 385)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Aplicar_Impuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 427)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Justificacion)
        Me.Controls.Add(Me.LJustificacion)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Aplicar_Impuesto"
        Me.Text = "Aplicar Impuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
