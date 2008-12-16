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
        Dim LIdentidad As System.Windows.Forms.Label
        Dim LNOMBRE As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Me.RIF = New System.Windows.Forms.TextBox
        Me.NOMBRE = New System.Windows.Forms.TextBox
        Me.APELLIDO = New System.Windows.Forms.TextBox
        Me.TELEFONO = New System.Windows.Forms.TextBox
        Me.DIRECCION = New System.Windows.Forms.TextBox
        LIdentidad = New System.Windows.Forms.Label
        LNOMBRE = New System.Windows.Forms.Label
        APELLIDOLabel = New System.Windows.Forms.Label
        TELEFONOLabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LIdentidad
        '
        LIdentidad.AutoSize = True
        LIdentidad.Location = New System.Drawing.Point(43, 87)
        LIdentidad.Name = "LIdentidad"
        LIdentidad.Size = New System.Drawing.Size(27, 13)
        LIdentidad.TabIndex = 1
        LIdentidad.Text = "RIF:"
        '
        'RIF
        '
        Me.RIF.Location = New System.Drawing.Point(118, 84)
        Me.RIF.Name = "RIF"
        Me.RIF.Size = New System.Drawing.Size(141, 20)
        Me.RIF.TabIndex = 2
        '
        'LNOMBRE
        '
        LNOMBRE.AutoSize = True
        LNOMBRE.Location = New System.Drawing.Point(43, 113)
        LNOMBRE.Name = "LNOMBRE"
        LNOMBRE.Size = New System.Drawing.Size(57, 13)
        LNOMBRE.TabIndex = 3
        LNOMBRE.Text = "NOMBRE:"
        '
        'NOMBRE
        '
        Me.NOMBRE.Location = New System.Drawing.Point(118, 110)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(141, 20)
        Me.NOMBRE.TabIndex = 4
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.Location = New System.Drawing.Point(43, 139)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(62, 13)
        APELLIDOLabel.TabIndex = 5
        APELLIDOLabel.Text = "APELLIDO:"
        '
        'APELLIDO
        '
        Me.APELLIDO.Location = New System.Drawing.Point(118, 136)
        Me.APELLIDO.Name = "APELLIDO"
        Me.APELLIDO.Size = New System.Drawing.Size(141, 20)
        Me.APELLIDO.TabIndex = 6
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(43, 165)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(67, 13)
        TELEFONOLabel.TabIndex = 7
        TELEFONOLabel.Text = "TELEFONO:"
        '
        'TELEFONO
        '
        Me.TELEFONO.Location = New System.Drawing.Point(118, 162)
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Size = New System.Drawing.Size(141, 20)
        Me.TELEFONO.TabIndex = 8
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(43, 196)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(69, 13)
        DIRECCIONLabel.TabIndex = 9
        DIRECCIONLabel.Text = "DIRECCION:"
        '
        'DIRECCION
        '
        Me.DIRECCION.Location = New System.Drawing.Point(118, 193)
        Me.DIRECCION.Multiline = True
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.Size = New System.Drawing.Size(141, 71)
        Me.DIRECCION.TabIndex = 10
        '
        'IngresarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 316)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.DIRECCION)
        Me.Controls.Add(TELEFONOLabel)
        Me.Controls.Add(Me.TELEFONO)
        Me.Controls.Add(APELLIDOLabel)
        Me.Controls.Add(Me.APELLIDO)
        Me.Controls.Add(LNOMBRE)
        Me.Controls.Add(Me.NOMBRE)
        Me.Controls.Add(LIdentidad)
        Me.Controls.Add(Me.RIF)
        Me.Name = "IngresarCliente"
        Me.Text = "IngresarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RIF As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCION As System.Windows.Forms.TextBox
End Class
