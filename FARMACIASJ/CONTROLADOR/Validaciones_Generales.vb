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
        Try

            If Cadena.Length() > Tamano_Permitido Then
                MsgBox(Mensaje_Error, MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
            If Not Char.IsDigit(Cadena, 0) Then
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

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

    Public Function Validar_Ingresar_Producto(ByVal codigo_barras As String, ByVal codigo As String, ByVal nombre_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As Integer, ByVal proveedor As Windows.Forms.ListBox, ByVal linea As String) As Boolean
        If ((comillas(codigo_barras, "Codigo de barras") = True) And (espacio_blanco(codigo_barras, "Codigo de barras") = True) And (nulo(codigo_barras, "Codigo_barras") = True)) Then
            If ((comillas(nombre_producto, "Nombre del producto") = True) And (espacio_blanco(nombre_producto, "Nombre del producto") = True) And (nulo(nombre_producto, "Nombre del producto") = True)) Then
                If ((comillas(desc_producto, "Descripcion del producto") = True) And (espacio_blanco(desc_producto, "Descripcion del producto") = True) And (nulo(desc_producto, "Descripcion del producto") = True)) Then
                    If ((comillas(ge_producto, "Gravado/Exento") = True) And (espacio_blanco(ge_producto, "Gravado/Exento") = True) And (nulo(ge_producto, "Gravado/Exento") = True)) Then
                        If ((comillas(linea, "Linea") = True) And (espacio_blanco(linea, "linea") = True) And (nulo(linea, "linea") = True)) Then
                            If ((comillas(u_producto.ToString, "Unidades por paquete") = True) And (espacio_blanco(u_producto.ToString, "Unidades por paquete") = True) And (nulo(u_producto.ToString, "Unidades por paquete") = True)) Then
                                If ((Validar_Codigo_Barras(codigo_barras) = False) And (Validar_Nombre_Producto(nombre_producto) = False)) Then
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Function
End Class
