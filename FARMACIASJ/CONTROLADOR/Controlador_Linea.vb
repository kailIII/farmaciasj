Public Class Controlador_Linea

    Public Sub Ingresando_Linea(ByVal Nombre As String, ByVal Descuento As Double, ByVal Descripcion As String, ByVal Margen As Double)

        Dim Linea As Linea = New Linea

        If (Linea.Ingresar_Linea(Nombre, Descuento, Descripcion, Margen)) Then
            MsgBox("La L�nea se insert� con �xito.", MsgBoxStyle.OkOnly, "Aviso")
        Else
            MsgBox("La L�nea no se pudo insertar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

End Class

