<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Despedir_Empleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Buscando = New System.Windows.Forms.Button
        Me.Cargo_Actual = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nombres = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cedula = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Eliminando = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Justificacion = New System.Windows.Forms.RichTextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buscando)
        Me.GroupBox1.Controls.Add(Me.Cargo_Actual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Nombres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cedula)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de Empleado"
        '
        'Buscando
        '
        Me.Buscando.Location = New System.Drawing.Point(222, 97)
        Me.Buscando.Name = "Buscando"
        Me.Buscando.Size = New System.Drawing.Size(75, 23)
        Me.Buscando.TabIndex = 6
        Me.Buscando.Text = "Buscar"
        Me.Buscando.UseVisualStyleBackColor = True
        '
        'Cargo_Actual
        '
        Me.Cargo_Actual.Enabled = False
        Me.Cargo_Actual.Location = New System.Drawing.Point(106, 71)
        Me.Cargo_Actual.Name = "Cargo_Actual"
        Me.Cargo_Actual.Size = New System.Drawing.Size(191, 20)
        Me.Cargo_Actual.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cargo Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido, Nombre:"
        '
        'Nombres
        '
        Me.Nombres.Enabled = False
        Me.Nombres.Location = New System.Drawing.Point(106, 45)
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(191, 20)
        Me.Nombres.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cédula:"
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(106, 19)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(191, 20)
        Me.Cedula.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Eliminando)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Justificacion)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Despedir Empleado"
        '
        'Eliminando
        '
        Me.Eliminando.Enabled = False
        Me.Eliminando.Location = New System.Drawing.Point(222, 120)
        Me.Eliminando.Name = "Eliminando"
        Me.Eliminando.Size = New System.Drawing.Size(75, 23)
        Me.Eliminando.TabIndex = 7
        Me.Eliminando.Text = "Despedir"
        Me.Eliminando.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Justificación de despido:"
        '
        'Justificacion
        '
        Me.Justificacion.Enabled = False
        Me.Justificacion.Location = New System.Drawing.Point(9, 36)
        Me.Justificacion.Name = "Justificacion"
        Me.Justificacion.Size = New System.Drawing.Size(288, 78)
        Me.Justificacion.TabIndex = 12
        Me.Justificacion.Text = ""
        '
        'Despedir_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 318)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Despedir_Empleado"
        Me.Text = "Despedir Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Cargo_Actual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Buscando As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Eliminando As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Justificacion As System.Windows.Forms.RichTextBox
End Class
