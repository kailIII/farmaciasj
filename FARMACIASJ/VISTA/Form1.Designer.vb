<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.Apellido = New System.Windows.Forms.TextBox
        Me.Tipo_Cliente = New System.Windows.Forms.ComboBox
        Me.Tipo_Identidad = New System.Windows.Forms.ComboBox
        Me.Numero_Identidad = New System.Windows.Forms.TextBox
        Me.Telefono = New System.Windows.Forms.TextBox
        Me.Direccion = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(183, 54)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(100, 20)
        Me.Nombre.TabIndex = 0
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(183, 80)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(100, 20)
        Me.Apellido.TabIndex = 1
        '
        'Tipo_Cliente
        '
        Me.Tipo_Cliente.FormattingEnabled = True
        Me.Tipo_Cliente.Items.AddRange(New Object() {"Nartural", "Juridico", "Gobierno"})
        Me.Tipo_Cliente.Location = New System.Drawing.Point(183, 107)
        Me.Tipo_Cliente.Name = "Tipo_Cliente"
        Me.Tipo_Cliente.Size = New System.Drawing.Size(121, 21)
        Me.Tipo_Cliente.TabIndex = 2
        '
        'Tipo_Identidad
        '
        Me.Tipo_Identidad.FormattingEnabled = True
        Me.Tipo_Identidad.Items.AddRange(New Object() {"CEDULA", "PASAPORTE", "RIF"})
        Me.Tipo_Identidad.Location = New System.Drawing.Point(183, 135)
        Me.Tipo_Identidad.Name = "Tipo_Identidad"
        Me.Tipo_Identidad.Size = New System.Drawing.Size(121, 21)
        Me.Tipo_Identidad.TabIndex = 3
        '
        'Numero_Identidad
        '
        Me.Numero_Identidad.Location = New System.Drawing.Point(183, 163)
        Me.Numero_Identidad.Name = "Numero_Identidad"
        Me.Numero_Identidad.Size = New System.Drawing.Size(100, 20)
        Me.Numero_Identidad.TabIndex = 4
        '
        'Telefono
        '
        Me.Telefono.Location = New System.Drawing.Point(183, 190)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(100, 20)
        Me.Telefono.TabIndex = 5
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(183, 217)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(100, 20)
        Me.Direccion.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(240, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tipo_Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tipo_Identidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Numero Identidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Direccion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 370)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Numero_Identidad)
        Me.Controls.Add(Me.Tipo_Identidad)
        Me.Controls.Add(Me.Tipo_Cliente)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Apellido As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Tipo_Identidad As System.Windows.Forms.ComboBox
    Friend WithEvents Numero_Identidad As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
