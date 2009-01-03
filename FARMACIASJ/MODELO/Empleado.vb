Public Class Empleado
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


    Public Function Buscar_Info_Empleado(ByVal Reder As Data.SqlClient.SqlDataReader, ByVal Id_Empleado As Integer) As Data.SqlClient.SqlDataReader

        Dim Empleo As FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Try
            Empleo = New FarmaciaSJDataSetTableAdapters.EMPLEADOTableAdapter
            Conextion = Empleo.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     EMPLEADO.NOMBRE, EMPLEADO.APELLIDO, EMPLEADO.IDENTIDAD, EMPLEADO.TELEFONO, EMPLEADO.MAIL, HISTORICO_EMPLEADO.CARGO, HISTORICO_EMPLEADO.SUELDO, HISTORICO_EMPLEADO.FECHA_INGRESO, HISTORICO_EMPLEADO.FECHA_FIN, HISTORICO_EMPLEADO.JUSTIFICACION FROM EMPLEADO INNER JOIN HISTORICO_EMPLEADO ON EMPLEADO.ID_EMPLEADO = HISTORICO_EMPLEADO.ID_EMPLEADO WHERE     (EMPLEADO.ID_EMPLEADO = " & Id_Empleado & ") AND (HISTORICO_EMPLEADO.FECHA_FIN IS NULL) ORDER BY HISTORICO_EMPLEADO.FECHA_INGRESO DESC"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return Reder
            End If
        Catch e As Data.SqlClient.SqlException
        End Try

        Return Reder
    End Function




End Class
