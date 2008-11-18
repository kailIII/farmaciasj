<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Compra
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Vence = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LNtelefono = New System.Windows.Forms.Label
        Me.LCArea = New System.Windows.Forms.Label
        Me.CArea = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.BATelefono = New System.Windows.Forms.Button
        Me.NTelefono = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Telefonos = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CODIGO = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.MAIL = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CIUDAD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.NOMBRE_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.RIF_PROVEEDOR = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DETALLE_COMPRA = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.DESCRIPCION_PRODUCTO = New System.Windows.Forms.RichTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.UPAQUETE = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GRABADO = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NOMBRE_PRODUCTO = New System.Windows.Forms.TextBox
        Me.CODIGO_BARRAS = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DESCRIPCION_LINEA = New System.Windows.Forms.RichTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.MUtil = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.DMaximo = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.NOMBRE_LINEA = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DESCUENTO = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.PVP = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.FVENCE = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.CTotal = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CUnidad = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Subtotal = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DETALLE_COMPRA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Numero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Vence)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(445, 19)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(100, 20)
        Me.Numero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vence"
        '
        'Vence
        '
        Me.Vence.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.Vence.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Vence.Location = New System.Drawing.Point(256, 20)
        Me.Vence.Name = "Vence"
        Me.Vence.Size = New System.Drawing.Size(132, 20)
        Me.Vence.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(60, 19)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(134, 20)
        Me.Fecha.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LNtelefono)
        Me.GroupBox2.Controls.Add(Me.LCArea)
        Me.GroupBox2.Controls.Add(Me.CArea)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.BATelefono)
        Me.GroupBox2.Controls.Add(Me.NTelefono)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Telefonos)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CODIGO)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.MAIL)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Direccion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CIUDAD)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NOMBRE_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.RIF_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 157)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'LNtelefono
        '
        Me.LNtelefono.AutoSize = True
        Me.LNtelefono.Location = New System.Drawing.Point(341, 116)
        Me.LNtelefono.Name = "LNtelefono"
        Me.LNtelefono.Size = New System.Drawing.Size(44, 13)
        Me.LNtelefono.TabIndex = 21
        Me.LNtelefono.Text = "Numero"
        Me.LNtelefono.Visible = False
        '
        'LCArea
        '
        Me.LCArea.AutoSize = True
        Me.LCArea.Location = New System.Drawing.Point(251, 115)
        Me.LCArea.Name = "LCArea"
        Me.LCArea.Size = New System.Drawing.Size(51, 13)
        Me.LCArea.TabIndex = 20
        Me.LCArea.Text = "Cod-Area"
        Me.LCArea.Visible = False
        '
        'CArea
        '
        Me.CArea.Location = New System.Drawing.Point(248, 131)
        Me.CArea.Name = "CArea"
        Me.CArea.Size = New System.Drawing.Size(56, 20)
        Me.CArea.TabIndex = 19
        Me.CArea.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(310, 135)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(10, 13)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "-"
        '
        'BATelefono
        '
        Me.BATelefono.Location = New System.Drawing.Point(448, 131)
        Me.BATelefono.Name = "BATelefono"
        Me.BATelefono.Size = New System.Drawing.Size(103, 20)
        Me.BATelefono.TabIndex = 17
        Me.BATelefono.Text = "Agregar_Telefono"
        Me.BATelefono.UseVisualStyleBackColor = True
        Me.BATelefono.Visible = False
        '
        'NTelefono
        '
        Me.NTelefono.Location = New System.Drawing.Point(326, 132)
        Me.NTelefono.Name = "NTelefono"
        Me.NTelefono.Size = New System.Drawing.Size(116, 20)
        Me.NTelefono.TabIndex = 16
        Me.NTelefono.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Telefonos"
        '
        'Telefonos
        '
        Me.Telefonos.Enabled = False
        Me.Telefonos.FormattingEnabled = True
        Me.Telefonos.Location = New System.Drawing.Point(248, 81)
        Me.Telefonos.Name = "Telefonos"
        Me.Telefonos.Size = New System.Drawing.Size(301, 30)
        Me.Telefonos.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Codigo"
        '
        'CODIGO
        '
        Me.CODIGO.Enabled = False
        Me.CODIGO.Location = New System.Drawing.Point(65, 129)
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Size = New System.Drawing.Size(100, 20)
        Me.CODIGO.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Mail"
        '
        'MAIL
        '
        Me.MAIL.Enabled = False
        Me.MAIL.Location = New System.Drawing.Point(65, 103)
        Me.MAIL.Name = "MAIL"
        Me.MAIL.Size = New System.Drawing.Size(100, 20)
        Me.MAIL.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Direccion"
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(248, 23)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(303, 47)
        Me.Direccion.TabIndex = 8
        Me.Direccion.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Ciudad"
        '
        'CIUDAD
        '
        Me.CIUDAD.Enabled = False
        Me.CIUDAD.Location = New System.Drawing.Point(65, 76)
        Me.CIUDAD.Name = "CIUDAD"
        Me.CIUDAD.Size = New System.Drawing.Size(100, 20)
        Me.CIUDAD.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre"
        '
        'NOMBRE_PROVEEDOR
        '
        Me.NOMBRE_PROVEEDOR.Enabled = False
        Me.NOMBRE_PROVEEDOR.Location = New System.Drawing.Point(65, 50)
        Me.NOMBRE_PROVEEDOR.Name = "NOMBRE_PROVEEDOR"
        Me.NOMBRE_PROVEEDOR.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_PROVEEDOR.TabIndex = 2
        '
        'RIF_PROVEEDOR
        '
        Me.RIF_PROVEEDOR.Location = New System.Drawing.Point(65, 23)
        Me.RIF_PROVEEDOR.Name = "RIF_PROVEEDOR"
        Me.RIF_PROVEEDOR.Size = New System.Drawing.Size(100, 20)
        Me.RIF_PROVEEDOR.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RIF"
        '
        'DETALLE_COMPRA
        '
        Me.DETALLE_COMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_COMPRA.Location = New System.Drawing.Point(13, 239)
        Me.DETALLE_COMPRA.Name = "DETALLE_COMPRA"
        Me.DETALLE_COMPRA.Size = New System.Drawing.Size(561, 98)
        Me.DETALLE_COMPRA.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.DESCRIPCION_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.UPAQUETE)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.GRABADO)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.NOMBRE_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.CODIGO_BARRAS)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 135)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(220, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Descripcion"
        '
        'DESCRIPCION_PRODUCTO
        '
        Me.DESCRIPCION_PRODUCTO.Enabled = False
        Me.DESCRIPCION_PRODUCTO.Location = New System.Drawing.Point(285, 17)
        Me.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO"
        Me.DESCRIPCION_PRODUCTO.Size = New System.Drawing.Size(265, 96)
        Me.DESCRIPCION_PRODUCTO.TabIndex = 18
        Me.DESCRIPCION_PRODUCTO.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Unidadesx Paquete"
        '
        'UPAQUETE
        '
        Me.UPAQUETE.Enabled = False
        Me.UPAQUETE.Location = New System.Drawing.Point(114, 97)
        Me.UPAQUETE.Name = "UPAQUETE"
        Me.UPAQUETE.Size = New System.Drawing.Size(100, 20)
        Me.UPAQUETE.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Gravado/Exento"
        '
        'GRABADO
        '
        Me.GRABADO.Enabled = False
        Me.GRABADO.FormattingEnabled = True
        Me.GRABADO.Items.AddRange(New Object() {"GRAVADO", "EXENTO"})
        Me.GRABADO.Location = New System.Drawing.Point(114, 70)
        Me.GRABADO.Name = "GRABADO"
        Me.GRABADO.Size = New System.Drawing.Size(100, 21)
        Me.GRABADO.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Nombre"
        '
        'NOMBRE_PRODUCTO
        '
        Me.NOMBRE_PRODUCTO.Enabled = False
        Me.NOMBRE_PRODUCTO.Location = New System.Drawing.Point(114, 43)
        Me.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO"
        Me.NOMBRE_PRODUCTO.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_PRODUCTO.TabIndex = 12
        '
        'CODIGO_BARRAS
        '
        Me.CODIGO_BARRAS.Location = New System.Drawing.Point(114, 17)
        Me.CODIGO_BARRAS.Name = "CODIGO_BARRAS"
        Me.CODIGO_BARRAS.Size = New System.Drawing.Size(100, 20)
        Me.CODIGO_BARRAS.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Codigo"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DESCRIPCION_LINEA)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.MUtil)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.DMaximo)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.NOMBRE_LINEA)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 484)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(558, 109)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Linea"
        '
        'DESCRIPCION_LINEA
        '
        Me.DESCRIPCION_LINEA.Enabled = False
        Me.DESCRIPCION_LINEA.Location = New System.Drawing.Point(301, 13)
        Me.DESCRIPCION_LINEA.Name = "DESCRIPCION_LINEA"
        Me.DESCRIPCION_LINEA.Size = New System.Drawing.Size(247, 79)
        Me.DESCRIPCION_LINEA.TabIndex = 21
        Me.DESCRIPCION_LINEA.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(232, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Descripcion"
        '
        'MUtil
        '
        Me.MUtil.Enabled = False
        Me.MUtil.Location = New System.Drawing.Point(126, 72)
        Me.MUtil.Name = "MUtil"
        Me.MUtil.Size = New System.Drawing.Size(100, 20)
        Me.MUtil.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Margen_Util"
        '
        'DMaximo
        '
        Me.DMaximo.Enabled = False
        Me.DMaximo.Location = New System.Drawing.Point(126, 46)
        Me.DMaximo.Name = "DMaximo"
        Me.DMaximo.Size = New System.Drawing.Size(100, 20)
        Me.DMaximo.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Descuento_Maximo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Nombre"
        '
        'NOMBRE_LINEA
        '
        Me.NOMBRE_LINEA.Enabled = False
        Me.NOMBRE_LINEA.Location = New System.Drawing.Point(126, 19)
        Me.NOMBRE_LINEA.Name = "NOMBRE_LINEA"
        Me.NOMBRE_LINEA.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_LINEA.TabIndex = 14
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.DESCUENTO)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.PVP)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.FVENCE)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.CTotal)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.CUnidad)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Cantidad)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(19, 599)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(555, 101)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lote/Detalle_Compra"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DESCUENTO
        '
        Me.DESCUENTO.Location = New System.Drawing.Point(296, 70)
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Size = New System.Drawing.Size(134, 20)
        Me.DESCUENTO.TabIndex = 13
        Me.DESCUENTO.Text = "0"
        Me.DESCUENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(204, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Descuento %"
        '
        'PVP
        '
        Me.PVP.Location = New System.Drawing.Point(296, 44)
        Me.PVP.Name = "PVP"
        Me.PVP.Size = New System.Drawing.Size(134, 20)
        Me.PVP.TabIndex = 11
        Me.PVP.Text = "0"
        Me.PVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(206, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(28, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "PVP"
        '
        'FVENCE
        '
        Me.FVENCE.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.FVENCE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FVENCE.Location = New System.Drawing.Point(296, 18)
        Me.FVENCE.Name = "FVENCE"
        Me.FVENCE.Size = New System.Drawing.Size(134, 20)
        Me.FVENCE.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(206, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Fecha_Vence"
        '
        'CTotal
        '
        Me.CTotal.Enabled = False
        Me.CTotal.Location = New System.Drawing.Point(86, 74)
        Me.CTotal.Name = "CTotal"
        Me.CTotal.Size = New System.Drawing.Size(100, 20)
        Me.CTotal.TabIndex = 7
        Me.CTotal.Text = "0"
        Me.CTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Costo_Total"
        '
        'CUnidad
        '
        Me.CUnidad.Location = New System.Drawing.Point(86, 48)
        Me.CUnidad.Name = "CUnidad"
        Me.CUnidad.Size = New System.Drawing.Size(100, 20)
        Me.CUnidad.TabIndex = 5
        Me.CUnidad.Text = "0"
        Me.CUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Costo_Unidad"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(86, 19)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad.TabIndex = 3
        Me.Cantidad.Text = "0"
        Me.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Cantidad"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(408, 706)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(498, 706)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Subtotal
        '
        Me.Subtotal.Location = New System.Drawing.Point(105, 706)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(100, 20)
        Me.Subtotal.TabIndex = 9
        Me.Subtotal.Text = "0"
        Me.Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(25, 709)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Sub-Total"
        '
        'Registrar_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 746)
        Me.Controls.Add(Me.Subtotal)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DETALLE_COMPRA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar_Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DETALLE_COMPRA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CIUDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents RIF_PROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents DETALLE_COMPRA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CODIGO_BARRAS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DESCRIPCION_PRODUCTO As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents UPAQUETE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GRABADO As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_PRODUCTO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MUtil As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DMaximo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_LINEA As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCION_LINEA As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DESCUENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PVP As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents FVENCE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BATelefono As System.Windows.Forms.Button
    Friend WithEvents NTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Telefonos As System.Windows.Forms.ListBox
    Friend WithEvents LNtelefono As System.Windows.Forms.Label
    Friend WithEvents LCArea As System.Windows.Forms.Label
    Friend WithEvents CArea As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
