Public Class Controlador_Linea

    Public Sub Ingresando_Linea(ByVal Nombre As String, ByVal Descuento As Double, ByVal Descripcion As String, ByVal Margen As Double)

        Dim Linea As Linea
        Dim a As Boolean
        Linea = New Linea
        a = Linea.Ingresar_Linea(Nombre, Descuento, Descripcion, Margen)
        If (a = True) Then
            MsgBox("La Línea se insertó con éxito.", MsgBoxStyle.OkOnly, "Aviso")
        Else
            MsgBox("La Línea no se pudo insertar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

End Class

