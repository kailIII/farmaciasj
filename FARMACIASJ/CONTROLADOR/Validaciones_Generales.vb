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

    Public Function Tamano_Aceptable_Cadena(ByVal Cadena As String, ByVal Tamano_Permitido As Integer, ByVal Mensaje_Error As String) As Boolean
        If Cadena.Length() > Tamano_Permitido Then
            MsgBox(Mensaje_Error, MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        Return True
    End Function

    Public Function Validar_Codigo_Barras(ByVal codigo As String) As Boolean
        Dim producto As Producto = New Producto
        If (producto.BuscarCodigoBarras(codigo) = True) Then
            MsgBox("Error. No se puede ingresar un producto que ya existe.", MsgBoxStyle.OkOnly, "Error")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Validar_Nombre_Producto(ByVal codigo As String) As Boolean
        Dim producto As Producto = New Producto
        If (producto.BuscarNombreProducto(codigo) = True) Then
            MsgBox("Error. Este nombre ya esta asignado a un producto.", MsgBoxStyle.OkOnly, "Error")
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Validar_Ingresar_Producto(ByVal codigo_barras As String, ByVal codigo As String, ByVal nombre_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As Integer, ByVal proveedor As String, ByVal linea As String)

    End Sub
End Class
