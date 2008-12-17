Public Class Controlador_Linea

    Public Sub Ingresando_Linea(ByVal Nombre As String, ByVal Descuento As String, ByVal Descripcion As String, ByVal Margen As String)

        Dim Linea As Linea = New Linea
        Dim Validacion As Validaciones_Generales = New Validaciones_Generales
        If Linea.BuscarLinea(Nombre) Then
            MsgBox("L�nea repetida. La L�nea no se puede insertar", MsgBoxStyle.OkOnly, "Error")
        Else
            If (Validacion.Tamano_Aceptable_Cadena(Descuento, 2, "Porcentaje de Descuento inv�lido") And Validacion.Tamano_Aceptable_Cadena(Margen, 2, "Porcentaje de margen �til inv�lido")) Then
                If Linea.Ingresar_Linea(Nombre, CInt(Descuento), Descripcion, CInt(Margen)) Then
                    MsgBox("La L�nea se insert� con �xito.", MsgBoxStyle.OkOnly, "Aviso")
                Else
                    MsgBox("La L�nea no se pudo insertar", MsgBoxStyle.OkOnly, "Error")
                End If
            End If
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
                Compra.DescMax = Double.Parse(Reder.Item(3).ToString)
                Compra.MUtil = Double.Parse(Reder.Item(4).ToString)
            End If
        Else
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

    'Jesus
    Public Sub buscar_linea(ByVal Nombre As String, ByVal MLinea As Modificar_Linea)
        Dim Linea As Linea
        Dim Reder As Data.SqlClient.SqlDataReader
        Linea = New Linea
        Try
            Reder = Linea.BuscarLinea2(Nombre)
            If (Reder.Read = True) Then
                MLinea.id_linea = Integer.Parse(Reder.Item(0).ToString)
                MLinea.NombreLinea.Text = Reder.Item(1).ToString
                MLinea.DescripcionLinea.Text = Reder.Item(2).ToString
                MLinea.DescMax.Text = Reder.Item(3).ToString
                MLinea.MargenUtil.Text = Reder.Item(4).ToString
                MLinea.NombreLinea.Enabled = False
                MLinea.DescripcionLinea.Enabled = True
                MLinea.DescMax.Enabled = True
                MLinea.MargenUtil.Enabled = True
                MLinea.Modificar_Boton.Enabled = True
            Else
                MsgBox("La Linea: " & Nombre & " no existe", MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("La Linea: " & Nombre & " no existe", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Public Sub Modificar_Linea(ByVal id_linea As Integer, ByVal DescripcionLinea As String, ByVal DescMax As String, ByVal MargenU As String, ByVal mLinea As Modificar_Linea)
        Dim Linea As New Linea
        Dim a As Boolean
        a = Linea.Modificar_Linea(id_linea, DescripcionLinea, DescMax, MargenU)
        If (a = True) Then
            MsgBox("La modificaci�n se realiz� con �xito", MsgBoxStyle.OkOnly, "Informaci�n")
            mLinea.Close()
        Else
            MsgBox("La modificaci�n tiene errores, verifique e intente nuevamente", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Public Sub Abrir_VentaM(ByVal Padre As Windows.Forms.Form)
        Dim ILinea As Modificar_Linea
        ILinea = New Modificar_Linea
        ILinea.MdiParent = Padre
        ILinea.Show()
    End Sub

End Class

