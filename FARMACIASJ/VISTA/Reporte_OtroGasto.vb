Public Class Reporte_OtroGasto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Gasto As Controlador_OtrosGastos

        Gasto = New Controlador_OtrosGastos(Desde.Value.Date, Me)

        Gasto.generar_reporte(Hasta.Value.Date)
    End Sub
End Class