Public Class Controlador_Venta

    Public Function Ingresar_Factura(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal ID_Cliente As String) As Integer
        Dim Venta As Venta
        Dim ID As Integer
        Venta = New Venta
        ID = Venta.Ingresar_Venta(Numero, Fecha, Vence, ID_Cliente)
        If (ID <> -1) Then
            Return ID
        Else
            MsgBox("Se pudo Ingresar la Factura Revise e Intente de nuevo", MsgBoxStyle.OkOnly, "Alert")
            Return -1
        End If
    End Function

    Public Sub Ingresar_Detalle()

    End Sub

End Class
