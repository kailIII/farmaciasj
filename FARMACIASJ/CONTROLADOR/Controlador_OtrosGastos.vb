Public Class Controlador_OtrosGastos
    Private Gasto As OtrosGastos
    Private Ventana As Windows.Forms.Form

    Public Sub New(ByVal monto As Double, ByVal fecha As Date, ByVal descripcion As String, ByVal ventana As Windows.Forms.Form)
        Me.Gasto = New OtrosGastos(monto, fecha, descripcion)
        Me.Ventana = ventana
    End Sub
    Public Sub New(ByVal fecha As Date, ByVal ventana As Windows.Forms.Form)
        Me.Gasto = New OtrosGastos(fecha)
        Me.Ventana = ventana
    End Sub
    Public Sub New(ByVal ventana As Windows.Forms.Form)
        Me.Gasto = New OtrosGastos()
        Me.Ventana = ventana
    End Sub
    Public Function get_monto() As Double
        Return Gasto.get_monto
    End Function

    Public Function get_fecha() As Date
        Return Gasto.get_fecha
    End Function

    Public Function get_descripcion() As String
        Return Gasto.get_Descripcion
    End Function

    Public Sub set_gasto(ByVal monto As Double, ByVal fecha As Date, ByVal descripcion As String)
        Gasto.set_monto(monto)
        Gasto.set_fecha(fecha)
        Gasto.set_descripcion(descripcion)
    End Sub

    Public Sub set_monto(ByVal monto As Double)
        Gasto.set_monto(monto)
    End Sub
    Public Sub set_fecha(ByVal fecha As Date)
        Gasto.set_fecha(fecha)
    End Sub
    Public Sub set_descripcion(ByVal descripcion As String)
        Gasto.set_descripcion(descripcion)
    End Sub

    Public Sub set_ventana(ByVal ventana As Windows.Forms.Form)
        Me.Ventana = ventana
    End Sub

    Public Sub Insertar_Otro_Gasto()
        Dim resultado As Boolean
        Dim Ventana As IngresarOtrosGastos
        resultado = Gasto.Insertar_Otro_Gasto()

        If (resultado = True) Then
            MsgBox("El Gasto se ingreso con exito en la Base de datos", MsgBoxStyle.OkOnly, "Aviso")
            Ventana = Me.Ventana
            Ventana.Close()
        Else
            MsgBox("El Gasto contiene errores, no se pudo ingresar, revise e intente de nuevo", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Public Sub Abrir_Ingresar_Gasto()
        Dim ventana As Administrador
        Dim ventana2 As IngresarOtrosGastos

        ventana = Me.Ventana
        ventana2 = New IngresarOtrosGastos

        ventana2.MdiParent = ventana
        ventana2.Show()
    End Sub

    Public Sub Abrir_Reporte()
        Dim ventana As Administrador
        Dim ventana2 As Reporte_OtroGasto

        ventana = Me.Ventana
        ventana2 = New Reporte_OtroGasto

        ventana2.MdiParent = ventana
        ventana2.Show()
    End Sub
    Public Sub generar_reporte(ByVal Hasta As Date)
        Dim ventana As Reporte_OtroGasto
        Dim desde As Date
        Dim reporte As Otros_Gastos
        Dim resultado As Boolean
        Dim ventana2 As Reporte
        ventana = Me.Ventana
        resultado = Gasto.Generar_Reporte_OtrosGastos(Hasta)
        If (resultado = True) Then
            reporte = Gasto.get_reporte
            desde = Gasto.get_fecha
            reporte.SetParameterValue(0, desde)
            reporte.SetParameterValue(1, Hasta)
            ventana2 = New Reporte
            ventana2.visor.ReportSource = reporte
            ventana2.MdiParent = ventana.MdiParent
            ventana.Close()
            ventana2.Show()
        Else
            MsgBox("Error, no se pudo generar el reporte verifique e intente de nuevo", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub

End Class
