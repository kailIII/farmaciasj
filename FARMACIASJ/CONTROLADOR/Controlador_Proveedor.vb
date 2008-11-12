Public Class Controlador_Proveedor

    Public Sub Ingresando_Proveedor(ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double)

        Dim Proveedor_x As Proveedor = New Proveedor

        If (Proveedor_x.Ingresar_Proveedor(Codigo, Rif, Nombre, Correo, Dir, Ciudad, Saldo)) Then
            MsgBox("El proveedor se registró con éxito.", MsgBoxStyle.OkOnly, "Aviso")
        Else
            MsgBox("No se pudo registrar el proveedor", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub


    Public Sub Buscando_Proveedor(ByVal Cadena As String, ByVal Codigo As Boolean)

        Dim Proveedor_x As Proveedor = New Proveedor

        If (Proveedor_x.Buscar_Proveedor(Cadena, True)) Then
            '' Acá deber{ia mandarlo para que muestre una nueva ventana con la información de la vaina.
            ''MsgBox("El proveedor se registró con éxito.", MsgBoxStyle.OkOnly, "Aviso")
        ElseIf (Proveedor_x.Buscar_Proveedor(Cadena, False)) Then
            ''MsgBox("El proveedor se registró con éxito.", MsgBoxStyle.OkOnly, "Aviso")
        Else
            MsgBox("No se pudo registrar el proveedor", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub


End Class
