<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Sueldo
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Registrando = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cargo = New System.Windows.Forms.TextBox
        Me.Sueldo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Buscando = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nombres = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cedula = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Registrando)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Cargo)
        Me.GroupBox2.Controls.Add(Me.Sueldo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 107)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Laboral"
        '
        'Registrando
        '
        Me.Registrando.Enabled = False
        Me.Registrando.Location = New System.Drawing.Point(222, 71)
        Me.Registrando.Name = "Registrando"
        Me.Registrando.Size = New System.Drawing.Size(75, 23)
        Me.Registrando.TabIndex = 15
        Me.Registrando.Text = "Registrar"
        Me.Registrando.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cargo:"
        '
        'Cargo
        '
        Me.Cargo.Enabled = False
        Me.Cargo.Location = New System.Drawing.Point(112, 19)
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Size = New System.Drawing.Size(185, 20)
        Me.Cargo.TabIndex = 13
        '
        'Sueldo
        '
        Me.Sueldo.Enabled = False
        Me.Sueldo.Location = New System.Drawing.Point(112, 45)
        Me.Sueldo.Name = "Sueldo"
        Me.Sueldo.Size = New System.Drawing.Size(185, 20)
        Me.Sueldo.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sueldo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buscando)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Nombres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cedula)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 106)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de Empleado"
        '
        'Buscando
        '
        Me.Buscando.Enabled = False
        Me.Buscando.Location = New System.Drawing.Point(222, 71)
        Me.Buscando.Name = "Buscando"
        Me.Buscando.Size = New System.Drawing.Size(75, 23)
        Me.Buscando.TabIndex = 6
        Me.Buscando.Text = "Buscar"
        Me.Buscando.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre, Apellido:"
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
        Me.Cedula.Enabled = False
        Me.Cedula.Location = New System.Drawing.Point(106, 19)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(191, 20)
        Me.Cedula.TabIndex = 0
        '
        'Modificar_Sueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 248)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Modificar_Sueldo"
        Me.Text = "Modificar_Sueldo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Registrando As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cargo As System.Windows.Forms.TextBox
    Friend WithEvents Sueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Buscando As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
End Class
