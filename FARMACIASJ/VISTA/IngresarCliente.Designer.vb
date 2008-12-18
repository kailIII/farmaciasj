<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarCliente
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
        Me.LIdentidad = New System.Windows.Forms.Label
        Me.LNOMBRE = New System.Windows.Forms.Label
        Me.LApellido = New System.Windows.Forms.Label
        Me.TELEFONOLabel = New System.Windows.Forms.Label
        Me.DIRECCIONLabel = New System.Windows.Forms.Label
        Me.RIF = New System.Windows.Forms.TextBox
        Me.NOMBRE = New System.Windows.Forms.TextBox
        Me.APELLIDO = New System.Windows.Forms.TextBox
        Me.TELEFONO = New System.Windows.Forms.TextBox
        Me.DIRECCION = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LIdentidad
        '
        Me.LIdentidad.AutoSize = True
        Me.LIdentidad.Location = New System.Drawing.Point(5, 53)
        Me.LIdentidad.Name = "LIdentidad"
        Me.LIdentidad.Size = New System.Drawing.Size(27, 13)
        Me.LIdentidad.TabIndex = 1
        Me.LIdentidad.Text = "RIF:"
        '
        'LNOMBRE
        '
        Me.LNOMBRE.AutoSize = True
        Me.LNOMBRE.Location = New System.Drawing.Point(5, 79)
        Me.LNOMBRE.Name = "LNOMBRE"
        Me.LNOMBRE.Size = New System.Drawing.Size(47, 13)
        Me.LNOMBRE.TabIndex = 3
        Me.LNOMBRE.Text = "Nombre:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(5, 105)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(47, 13)
        Me.LApellido.TabIndex = 5
        Me.LApellido.Text = "Apellido:"
        Me.LApellido.Visible = False
        '
        'TELEFONOLabel
        '
        Me.TELEFONOLabel.AutoSize = True
        Me.TELEFONOLabel.Location = New System.Drawing.Point(5, 131)
        Me.TELEFONOLabel.Name = "TELEFONOLabel"
        Me.TELEFONOLabel.Size = New System.Drawing.Size(52, 13)
        Me.TELEFONOLabel.TabIndex = 7
        Me.TELEFONOLabel.Text = "Teléfono:"
        '
        'DIRECCIONLabel
        '
        Me.DIRECCIONLabel.AutoSize = True
        Me.DIRECCIONLabel.Location = New System.Drawing.Point(5, 162)
        Me.DIRECCIONLabel.Name = "DIRECCIONLabel"
        Me.DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        Me.DIRECCIONLabel.TabIndex = 9
        Me.DIRECCIONLabel.Text = "Dirección:"
        '
        'RIF
        '
        Me.RIF.Enabled = False
        Me.RIF.Location = New System.Drawing.Point(80, 50)
        Me.RIF.Name = "RIF"
        Me.RIF.Size = New System.Drawing.Size(178, 20)
        Me.RIF.TabIndex = 2
        '
        'NOMBRE
        '
        Me.NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRE.Enabled = False
        Me.NOMBRE.Location = New System.Drawing.Point(80, 76)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(178, 20)
        Me.NOMBRE.TabIndex = 4
        '
        'APELLIDO
        '
        Me.APELLIDO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APELLIDO.Location = New System.Drawing.Point(80, 102)
        Me.APELLIDO.Name = "APELLIDO"
        Me.APELLIDO.Size = New System.Drawing.Size(178, 20)
        Me.APELLIDO.TabIndex = 6
        Me.APELLIDO.Visible = False
        '
        'TELEFONO
        '
        Me.TELEFONO.Enabled = False
        Me.TELEFONO.Location = New System.Drawing.Point(80, 128)
        Me.TELEFONO.MaxLength = 12
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Size = New System.Drawing.Size(178, 20)
        Me.TELEFONO.TabIndex = 8
        '
        'DIRECCION
        '
        Me.DIRECCION.Enabled = False
        Me.DIRECCION.Location = New System.Drawing.Point(80, 159)
        Me.DIRECCION.Multiline = True
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.Size = New System.Drawing.Size(178, 71)
        Me.DIRECCION.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"JURIDICO", "NATURAL", "EXTRANJERO"})
        Me.ComboBox1.Location = New System.Drawing.Point(80, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DIRECCIONLabel)
        Me.GroupBox1.Controls.Add(Me.DIRECCION)
        Me.GroupBox1.Controls.Add(Me.TELEFONOLabel)
        Me.GroupBox1.Controls.Add(Me.TELEFONO)
        Me.GroupBox1.Controls.Add(Me.LApellido)
        Me.GroupBox1.Controls.Add(Me.APELLIDO)
        Me.GroupBox1.Controls.Add(Me.LNOMBRE)
        Me.GroupBox1.Controls.Add(Me.NOMBRE)
        Me.GroupBox1.Controls.Add(Me.LIdentidad)
        Me.GroupBox1.Controls.Add(Me.RIF)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 270)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IngresarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 290)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IngresarCliente"
        Me.Text = "IngresarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RIF As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LIdentidad As System.Windows.Forms.Label
    Friend WithEvents LNOMBRE As System.Windows.Forms.Label
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents TELEFONOLabel As System.Windows.Forms.Label
    Friend WithEvents DIRECCIONLabel As System.Windows.Forms.Label
End Class
