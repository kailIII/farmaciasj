Public Class Controlador_Linea

    Public Sub Ingresando_Linea(ByVal Nombre As String, ByVal Descuento As Double, ByVal Descripcion As String, ByVal Margen As Double)

        Dim Linea As Linea = New Linea

        If (Linea.Ingresar_Linea(Nombre, Descuento, Descripcion, Margen)) Then
            MsgBox("La Línea se insertó con éxito.", MsgBoxStyle.OkOnly, "Aviso")
        Else
            MsgBox("La Línea no se pudo insertar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Public Sub Buscar_Nombre_linea(ByVal NOMBRE As String, ByVal Compra As Registrar_Compra)
        Dim Linea As Linea
        Dim Reder As Data.SqlClient.SqlDataReader
        Linea = New Linea
        Reder = Linea.BuscarLinea2(NOMBRE)
        If (Reder.HasRows = True) Then
            If (Reder.Read = True) Then
                Compra.ID_Linea = Integer.Parse(Reder.Item(0).ToString)
                Compra.NOMBRE_LINEA.Text = Reder.Item(1).ToString
                Compra.DESCRIPCION_LINEA.Text = Reder.Item(2).ToString
                Compra.DMaximo.Text = Reder.Item(3).ToString
                Compra.MUtil.Text = Reder.Item(4).ToString
            End If
        Else
            If (MsgBox("La Linea no Existe, ¿Desea Agregarla?", MsgBoxStyle.YesNo, "Alert") = MsgBoxResult.Yes) Then
                Compra.ID_Linea = -1
                Compra.NOMBRE_LINEA.Enabled = True
                Compra.DESCRIPCION_LINEA.Enabled = True
                Compra.DMaximo.Enabled = True
                Compra.MUtil.Enabled = True
            End If
        End If
    End Sub
    Public Function BuscarIDLinea(ByVal NOMBRE_LINEA As String) As Integer
        Dim Linea As New Linea
        Dim reder As Data.SqlClient.SqlDataReader
        reder = Linea.BuscarLinea2(NOMBRE_LINEA)
        If (reder.Read = True) Then
            Return Integer.Parse(reder.Item(0).ToString)
        End If
    End Function
    Public Sub Abrir_Venta(ByVal Padre As Windows.Forms.Form)
        Dim ILinea As Ingresar_Linea
        ILinea = New Ingresar_Linea
        ILinea.MdiParent = Padre
        ILinea.Show()
    End Sub
End Class

