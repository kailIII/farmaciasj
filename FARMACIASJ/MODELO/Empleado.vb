Public Class Empleado
    Public Reporte As Nomina
    Public Function Existe_Empleado(ByVal Cedula As String) As Integer

        Dim Empleo As FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim Id_Empleado As Integer = 0

        Try
            Empleo = New FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
            Conextion = Empleo.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT ID_EMPLEADO FROM EMPLEADO WHERE IDENTIDAD = '" & Cedula & "'"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Id_Empleado = CInt(Reder.Item(0).ToString())
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try

        Return Id_Empleado
    End Function


    Public Function Existe_Usuario(ByVal Usuario As String) As Integer

        Dim Empleo As FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim Id_Empleado As Integer = 0

        Try
            Empleo = New FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
            Conextion = Empleo.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT ID_EMPLEADO FROM EMPLEADO WHERE USUARIO = '" & Usuario & "'"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Id_Empleado = CInt(Reder.Item(0).ToString())
                Reder.Close()

            End If
        Catch e As Data.SqlClient.SqlException
        End Try

        Return Id_Empleado
    End Function






    Public Function Buscar_Info_Empleado(ByVal Reder As Data.SqlClient.SqlDataReader, ByVal Id_Empleado As Integer, ByVal Tabla_Empleado As Boolean) As Data.SqlClient.SqlDataReader

        Dim Empleo As FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Try
            Empleo = New FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
            Conextion = Empleo.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            If Tabla_Empleado Then
                Consulta.CommandText = "SELECT NOMBRE, APELLIDO, IDENTIDAD, MAIL, TELEFONO, ID_EMPLEADO FROM EMPLEADO WHERE ID_EMPLEADO=" & Id_Empleado
            Else
                Consulta.CommandText = "SELECT EMPLEADO.NOMBRE, EMPLEADO.APELLIDO, EMPLEADO.IDENTIDAD, EMPLEADO.TELEFONO, EMPLEADO.MAIL, HISTORICO_EMPLEADO.CARGO, HISTORICO_EMPLEADO.SUELDO, HISTORICO_EMPLEADO.FECHA_INGRESO, HISTORICO_EMPLEADO.FECHA_FIN, HISTORICO_EMPLEADO.JUSTIFICACION FROM EMPLEADO INNER JOIN HISTORICO_EMPLEADO ON EMPLEADO.ID_EMPLEADO = HISTORICO_EMPLEADO.ID_EMPLEADO WHERE     (EMPLEADO.ID_EMPLEADO = " & Id_Empleado & ") AND (HISTORICO_EMPLEADO.FECHA_FIN IS NULL) ORDER BY HISTORICO_EMPLEADO.FECHA_INGRESO DESC"
            End If

            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return Reder
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
        Return Reder
    End Function


    Public Function Id_Ultimo_Cargo(ByVal Id_Empleado As Integer) As Integer

        Dim Empleo As FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim Id_Cargo As Integer = 0

        Try
            Empleo = New FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
            Conextion = Empleo.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT HISTORICO_EMPLEADO.ID_HISTORICO_EMPLEADO FROM EMPLEADO INNER JOIN HISTORICO_EMPLEADO ON EMPLEADO.ID_EMPLEADO = HISTORICO_EMPLEADO.ID_EMPLEADO WHERE     (EMPLEADO.ID_EMPLEADO = " & Id_Empleado & ") AND (HISTORICO_EMPLEADO.FECHA_FIN IS NULL) ORDER BY HISTORICO_EMPLEADO.FECHA_INGRESO DESC"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Id_Cargo = CInt(Reder.Item(0).ToString())
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try

        Return Id_Cargo
    End Function

    Public Function Despedir_Empleado_Ultimo_Cargo(ByVal Id_Historico_Cargo As Integer, ByVal Justificacion As String) As Boolean
        Dim Adaptador As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Try
            Adaptador = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter()
            Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
            Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE HISTORICO_EMPLEADO SET FECHA_FIN=GETDATE() , JUSTIFICACION='" & Justificacion & "' WHERE ID_HISTORICO_EMPLEADO=" & Id_Historico_Cargo
            Consulta.ExecuteNonQuery()
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function


    Public Function Ingresar_Empleado(ByVal Cedula As String, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, ByVal Correo As String) As Boolean
        Dim EmpleadoTableAdapter As FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
        Try
            Dim BasedeDatos As FarmaciaSJDataSet
            BasedeDatos = New FarmaciaSJDataSet
            EmpleadoTableAdapter = New FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
            EmpleadoTableAdapter.Insert(Nombre, Apellido, Cedula, Telefono, Correo)
            EmpleadoTableAdapter.Update(BasedeDatos.EMPLEADO)
            BasedeDatos.AcceptChanges()
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try
    End Function


    Public Function Modificar_Historico_Empleado(ByVal Id_Empleado As Integer, ByVal Cargo As String, ByVal Sueldo As Double, ByVal Actualizar As Boolean) As Boolean
        Dim Adaptador As FarmaciaSJDataSetTableAdapters.HISTORICO_EMPLEADOTableAdapter
        Try
            Adaptador = New FarmaciaSJDataSetTableAdapters.HISTORICO_EMPLEADOTableAdapter()
            Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.HISTORICO_EMPLEADOTableAdapter = New FarmaciaSJDataSetTableAdapters.HISTORICO_EMPLEADOTableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
            Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
            Conextion.Open()

            Consulta.Connection = Conextion
            If Actualizar Then
                Consulta.CommandText = "UPDATE HISTORICO_EMPLEADO SET FECHA_FIN=GETDATE(), JUSTIFICACION='Cambio de Salario o Cargo' WHERE FECHA_FIN IS NULL AND ID_EMPLEADO=" & Id_Empleado
                Consulta.ExecuteNonQuery()
            End If
            Consulta.CommandText = "INSERT INTO HISTORICO_EMPLEADO (ID_EMPLEADO,CARGO,SUELDO,FECHA_INGRESO,FECHA_FIN,JUSTIFICACION) VALUES (" & Id_Empleado & ", '" & Cargo & "'," & Sueldo & ", GETDATE(), NULL, '')"
            Consulta.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Generar_Reporte_Nomina() As Boolean
        Me.Reporte = New Nomina
        Dim FarmaciaSJ As New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim Connection As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection
        Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Dim Control2 As New Data.DataSet
        Dim BD As Data.SqlClient.SqlDataAdapter
        Try
            Connection = Detalle.Connection
            Command.Connection = Connection
            Command.CommandText = "SELECT     ID_Farmacia, Razon_Social, RIF, Telefono, Direccion, Logo FROM         FARMACIA WHERE     (ID_Farmacia = 1)"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "FARMACIA")
            Command.CommandText = "SELECT     EMPLEADO.* FROM         EMPLEADO"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "EMPLEADO")
            Command.CommandText = "SELECT     HISTORICO_EMPLEADO.* FROM         HISTORICO_EMPLEADO WHERE     (FECHA_FIN IS NULL)"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "HISTORICO_EMPLEADO")
            Me.Reporte.SetDataSource(FarmaciaSJ)
            Return True
        Catch E As Exception
            Return False
        End Try
    End Function
End Class