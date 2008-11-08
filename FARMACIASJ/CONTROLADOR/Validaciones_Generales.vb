Public Class Validaciones_Generales
    Public Function comillas(ByVal merca As String, campo as String) As Boolean
        If (merca.Contains(Char.ConvertFromUtf32(34)) = True) Then
            MsgBox("El campo " & campo & " no debe tener comillas", MsgBoxStyle.OkOnly, "Error")
            Return False
        Else
            Return True
        End If
    End Function
    Public Function espacio_blanco(ByVal merca As String, ByVal campo As String) As Boolean
        If (merca.Contains(Char.ConvertFromUtf32(256)) = True) Then
            MsgBox("El campo " & campo & " no debe tener espacios en blanco", MsgBoxStyle.OkOnly, "Error")
            Return False
        Else
            Return True
        End If
    End Function
    Public Function nulo(ByVal merca As String, ByVal campo As String) As Boolean
        If (merca.Length = 0) Then
            MsgBox("El campo " & campo & " no debe estar vacio", MsgBoxStyle.OkOnly, "Error")
            Return False
        Else
            Return True
        End If
    End Function
End Class
