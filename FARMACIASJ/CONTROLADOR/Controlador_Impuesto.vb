Public Class Controlador_Impuesto
    Private Impuesto As Impuesto
    Private ventana As Windows.Forms.Form

    Public Sub New(ByVal Nombre As String, ByVal Descripcion As String, ByVal Valor As Double, ByVal Justificacion As String, ByVal Lineas As Integer(), ByVal Ventana As Windows.Forms.Form)
        MyBase.New()
        Impuesto = New Impuesto(Nombre, Descripcion, Valor, Justificacion, Lineas)
        Me.ventana = Ventana
    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Ventana As Windows.Forms.Form)
        MyBase.New()
        Impuesto = New Impuesto(Nombre)
        Me.ventana = Ventana
    End Sub
    Public Sub New(ByVal Ventana As Windows.Forms.Form)
        MyBase.New()
        Impuesto = New Impuesto()
        Me.ventana = Ventana
    End Sub
    Public Function get_Nombre() As String
        Return Impuesto.get_nombre
    End Function
    Public Function get_descripcion() As String
        Return Impuesto.get_Descripcion
    End Function
    Public Function get_Valor() As Double
        Return Impuesto.get_valor
    End Function
    Public Function get_justificacion() As String
        Return Impuesto.get_Justificacion
    End Function
    Public Function get_Lineas() As Integer()
        Return Impuesto.get_Lineas
    End Function
    Public Function get_ID() As Integer
        Return Impuesto.get_id
    End Function

    Public Sub set_Nombre(ByVal Nombre As String)
        Impuesto.Set_Nombre(Nombre)
    End Sub
    Public Sub set_Descripcion(ByVal Descripcion As String)
        Impuesto.set_Descripcion(Descripcion)
    End Sub

    Public Sub set_Valor(ByVal valor As Double)
        Impuesto.set_valor(valor)
    End Sub
    Public Sub set_Justificacion(ByVal Justificacion As String)
        Impuesto.set_Justificacion(Justificacion)
    End Sub
    Public Sub set_lineas(ByVal Lineas As Integer())
        Impuesto.set_Lineas(Lineas)
    End Sub

    Public Sub Existe_Impuesto()
        Dim Resultado As Boolean
        Dim Impuesto As Aplicar_Impuesto
        Resultado = Me.Impuesto.Existe_Impuesto()
        Impuesto = Me.ventana
        If (Resultado = True) Then
            Impuesto.Descripcion.Text = Me.Impuesto.get_Descripcion
            Impuesto.Valor.Text = Str(Me.Impuesto.get_valor)
            Impuesto.Valor.Enabled = False
            Impuesto.Justificacion.Text = Me.Impuesto.get_Justificacion
            Impuesto.Justificacion.Visible = True
            Impuesto.LJustificacion.Visible = True
            Impuesto.Justificacion.Enabled = False
            Impuesto.Modificar.Visible = True
            Impuesto.Contador = 0
        Else
            Impuesto.Descripcion.Enabled = True
            Impuesto.Valor.Enabled = True
            Impuesto.Modificar.Visible = False
            Impuesto.Justificacion.Visible = False
            Impuesto.LJustificacion.Visible = False
            Impuesto.Contador = 1
        End If
    End Sub
    Public Sub ir_a_Lineas()
        Dim Aplicar_Linea As Aplicar_Linea
        Dim Impuesto As Aplicar_Impuesto
        Impuesto = Me.ventana
        Aplicar_Linea = New Aplicar_Linea
        Aplicar_Linea.Controlador = Me
        Aplicar_Linea.Impuesto.Text = Impuesto.Nombre.Text
        Aplicar_Linea.Valor.Text = Impuesto.Valor.Text
        Aplicar_Linea.Contador = Impuesto.Contador
        Me.Impuesto.Traer_Lineas(Aplicar_Linea)
        Impuesto.Visible = False
        Aplicar_Linea.Aplicar = Impuesto
        Aplicar_Linea.MdiParent = Impuesto.MdiParent
        Aplicar_Linea.Show()
    End Sub
End Class
