Public Class Aplicar_Linea
    Public Controlador As Controlador_Impuesto
    Public Contador As Integer
    Public Aplicar As Aplicar_Impuesto
    Public Lineassin As Integer()
    Public Lineascon As Integer()

    Public Function BuscarPosicion(ByVal ArregloLinea As Integer()) As Integer

        Return Array.IndexOf(ArregloLinea, 0)

    End Function
    Public Sub Acomodar(ByVal Posicion As Integer, ByVal Tamano As Integer, ByVal ArregloLinea As Integer())
        Dim i As Integer = Posicion
        While i < Tamano
            Try
                ArregloLinea(i) = ArregloLinea(i + 1)
            Catch ex As Exception

            End Try
            i = i + 1
        End While
    End Sub

    Private Sub der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles der.Click
        Try
            Me.Lineas2.Items.Add(Me.Lineas1.SelectedItem.ToString)
            'Problema con la siguiente linea...
            Lineascon(BuscarPosicion(Lineascon)) = Lineassin(Me.Lineas1.SelectedIndex)
            Lineassin(Me.Lineas1.SelectedIndex) = 0
            Acomodar(Me.Lineas1.SelectedIndex, Me.Lineas1.Items.Count, Lineassin)
            Me.Lineas1.Items.RemoveAt(Me.Lineas1.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub izq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles izq.Click
        Try
            Me.Lineas1.Items.Add(Me.Lineas2.SelectedItem.ToString)
            Lineassin(BuscarPosicion(Lineassin)) = Lineascon(Me.Lineas2.SelectedIndex)
            Lineascon(Me.Lineas2.SelectedIndex) = 0
            Acomodar(Me.Lineas2.SelectedIndex, Me.Lineas2.Items.Count, Lineascon)
            Me.Lineas2.Items.RemoveAt(Me.Lineas2.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BotonAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAplicar.Click
        Try
            Controlador.ProcesarImpuesto(Lineassin, Lineascon)
        Catch ex As Exception

        End Try

    End Sub

End Class