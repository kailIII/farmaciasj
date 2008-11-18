Public Class Ingresar_Proveedor

    Public Arreglo As Array = Array.CreateInstance(GetType(Int32), 10)
    Public Contador As Integer

    Private Sub Boton_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registrar.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        ' ATENCION
        'Acá pensé ponerle la parte del boton modificar cuando lo accionamos para habilitar los campos
        'pero a la final lo coloqué en controlador
        Controlador_Proveedor.Ingresando_Proveedor(Arreglo, Me, Codigo.Text, Rif.Text, Nombre.Text, Correo.Text, Dir.Text, Ciudad.Text, Saldo.Text)
        'Registrando los productos_proveedor


    End Sub

    Private Sub Ingresar_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaSJDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOTableAdapter.Fill(Me.FarmaciaSJDataSet.PRODUCTO)
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaSJDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
        '        Me.PRODUCTOTableAdapter.Fill(Me.FarmaciaSJDataSet.PRODUCTO)

    End Sub




    Private Sub Cod_producto_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cod_producto.KeyPress
        Dim Proveedor_x As Controlador_Proveedor = New Controlador_Proveedor

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            ' Si existe el codigo de barras lo deberia insertar en el datagrid
            If (Proveedor_x.Productos_Relacionados(Me.Cod_producto.Text, Arreglo)) Then
                Proveedor_x.Actualizar_Datagrid(Me, Arreglo)
                Me.Cod_producto.Text = ""
            End If
        End If
    End Sub

End Class