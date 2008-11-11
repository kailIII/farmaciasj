Public Class Ingresar_Linea

    Private Sub Ingresar_Boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ingresar_Boton.Click
        Dim Controlador_Linea As Controlador_Linea
        Controlador_Linea = New Controlador_Linea
        Controlador_Linea.Ingresando_Linea(NombreLinea.Text, DescMax.Text, DescripcionLinea.Text, MargenUtil.Text)

    End Sub

End Class
