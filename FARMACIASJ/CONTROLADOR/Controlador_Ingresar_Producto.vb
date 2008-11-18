Public Class Controlador_Ingresar_Producto

    Public Sub ActivarCampos(ByVal pantalla As Ingresar_Producto, ByVal respuesta As Boolean)
        If respuesta = False Then
            pantalla.Nom_Producto.Enabled = True
            pantalla.Unidades_Producto.Enabled = True
            pantalla.GE_Producto.Enabled = True
            pantalla.Desc_Producto.Enabled = True
            pantalla.Cod_Producto.Enabled = True
            pantalla.Ingresar.Enabled = True
            pantalla.Riff.Enabled = True
            pantalla.Linea.Enabled = True
            pantalla.Cod_Barras.Enabled = False
        End If
    End Sub




End Class