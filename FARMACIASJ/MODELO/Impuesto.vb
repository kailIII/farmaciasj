Public Class Impuesto
    Private id As Integer
    Private Nombre As String
    Private Descripcion As String
    Private Valor As Double
    Private Justificacion As String
    Private Lineas() As Integer

    Public Sub New(ByVal Nombre As String, ByVal Descripcion As String, ByVal valor As Double, ByVal Justificacion As String, ByVal Lineas As Integer())
        MyBase.New()
        Me.id = 0
        Me.Nombre = Nombre
        Me.Descripcion = Descripcion
        Me.Valor = valor
        Me.Lineas = Lineas
    End Sub
    Public Sub New(ByVal Nombre As String)
        MyBase.New()
        Me.id = -1
        Me.Nombre = Nombre
        Me.Descripcion = ""
        Me.Valor = 0
    End Sub
    Public Sub New()
        MyBase.New()
        Me.id = -1
        Me.Nombre = ""
        Me.Descripcion = ""
        Me.Valor = 0
    End Sub

    Public Function get_id() As Integer
        Return Me.id
    End Function
    Public Function get_nombre() As String
        Return Me.Nombre
    End Function

    Public Function get_Descripcion() As String
        Return Me.Descripcion
    End Function
    Public Function get_valor() As Double
        Return Me.Valor
    End Function
    Public Function get_Justificacion() As String
        Return Me.Justificacion
    End Function

    Public Function get_Lineas() As Integer()
        Return Me.Lineas
    End Function

    Public Sub Set_Nombre(ByVal Nombre As String)
        Me.Nombre = Nombre
    End Sub
    Public Sub set_Descripcion(ByVal Descripcion As String)
        Me.Descripcion = Descripcion
    End Sub
    Public Sub set_valor(ByVal valor As Double)
        Me.Valor = valor
    End Sub
    Public Sub set_Justificacion(ByVal Justificacion As String)
        Me.Justificacion = Justificacion
    End Sub
    Public Sub set_Lineas(ByVal Lineas As Integer())
        Me.Lineas = Lineas
    End Sub
    Public Function Existe_Impuesto() As Boolean
        Dim Producto_x As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Producto_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     ID_IMPUESTO, Nombre, Descripcion FROM         IMPUESTO WHERE     (Nombre = '" & Me.Nombre & "')"
            Reder = Consulta.ExecuteReader
            If (Reder.Read = True) Then
                Me.id = Integer.Parse(Reder.Item(0).ToString)
                Me.Descripcion = Reder.Item(2).ToString
                Reder.Close()
                Consulta.CommandText = "SELECT     VALOR, DESCRIPCION FROM         HISTORICO_IMPUESTO WHERE     (FECHA_FIN IS NULL) AND (ID_IMPUESTO = " & Me.id & ")"
                Reder = Consulta.ExecuteReader
                If (Reder.Read = True) Then
                    Me.Valor = Double.Parse(Reder.Item(0).ToString)
                    Me.Justificacion = Reder.Item(1).ToString
                End If
                Reder.Close()
                Consulta.CommandText = "Select count(Id_Linea)as Lineas from(SELECT     ID_LINEA FROM         Linea_Impuesto WHERE     (ID_IMPUESTO = " & Me.id & "))as L"
                Reder = Consulta.ExecuteReader
                Dim iLineas As Integer
                If (Reder.Read = True) Then
                    iLineas = Integer.Parse(Reder.Item(0).ToString)
                End If
                Reder.Close()
                Consulta.CommandText = "SELECT     ID_LINEA FROM         Linea_Impuesto WHERE     (ID_IMPUESTO = " & Me.id & ")"
                Reder = Consulta.ExecuteReader
                Dim i As Integer = 0
                Dim Lineas(iLineas) As Integer
                While (Reder.Read = True)
                    Lineas(i) = Integer.Parse(Reder.Item(0).ToString)
                    i = i + 1
                End While
                Me.Lineas = Lineas
                Return True
            Else
                Return False

            End If
        Catch E As Exception
            Return False
        End Try
    End Function

    Public Function Traer_Lineas(ByVal Ventana As Aplicar_Linea) As Boolean
        Dim Producto_x As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Producto_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim i As Integer
        Dim L As Integer
        Dim J As Integer
        Dim b As Boolean
        Dim g As Integer
        Dim h As Integer
        Try
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "select count(ID_LINEA)from (SELECT     ID_LINEA, NOMBRE FROM         LINEA)L"
            Reder = Consulta.ExecuteReader
            If (Reder.Read = True) Then
                L = Integer.Parse(Reder.Item(0).ToString)
            End If
            Reder.Close()
            Consulta.CommandText = "SELECT     ID_LINEA, NOMBRE FROM         LINEA order by Id_Linea"
            Reder = Consulta.ExecuteReader
            Dim lineassin(L) As Integer
            Dim lineascon(L) As Integer
            i = 0
            While (i < L)
                lineassin(i) = 0
                lineascon(i) = 0
                i = i + 1
            End While
            i = 0
            g = 0
            h = 0
            While (Reder.Read = True)
                i = Integer.Parse(Reder.Item(0).ToString)
                J = 0
                b = False
                If (Me.id > 0) Then
                    While (J < Me.Lineas.Length)
                        If (i = Me.Lineas(J)) Then
                            b = True
                        End If
                        J = J + 1
                    End While
                End If
                If (b = True) Then
                    Ventana.Lineas2.Items.Insert(g, Reder.Item(1).ToString)
                    lineascon(g) = i
                    g = g + 1
                Else
                    Ventana.Lineas1.Items.Insert(h, Reder.Item(1).ToString)
                    lineassin(h) = i
                    h = h + 1
                End If
            End While
            Ventana.Lineassin = lineassin
            Ventana.Lineascon = lineascon
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RemoverImpuestoLinea(ByVal Lineasin As Integer()) As Boolean
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter = New FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Try
            Dim i As Integer = 0
            While i < Lineasin.Length
                Conextion.Open()
                Consulta.Connection = Conextion
                Consulta.CommandText = "DELETE FROM Linea_Impuesto WHERE ID_LINEA=" & Lineasin(i) & " AND ID_IMPUESTO=" & Me.id
                Try
                    Consulta.ExecuteNonQuery()
                Catch ex As Exception
                End Try
                Conextion.Close()
                i = i + 1
            End While
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function AsignarImpuesto(ByVal Lineacon As Integer()) As Boolean
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter = New FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Try
            Dim i As Integer = 0
            While i < Lineacon.Length
                Conextion.Open()
                Consulta.Connection = Conextion
                Consulta.CommandText = "INSERT INTO Linea_Impuesto ([ID_LINEA],[ID_IMPUESTO]) VALUES(" & Lineacon(i) & ", " & Me.id & ")"
                Try
                    Consulta.ExecuteNonQuery()
                Catch ex As Exception
                End Try
                Conextion.Close()
                i = i + 1
            End While
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function


    Function NuevoImpuesto() As Boolean
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter = New FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Try
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "INSERT INTO [IMPUESTO]([Nombre]  ,[Descripcion]) VALUES('" & Me.Nombre & "','" & Me.Descripcion & "')"
            Consulta.ExecuteNonQuery()
            Conextion.Close()
            Me.id = Me.Buscar_Id_Impuesto(Me.Nombre)
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "INSERT INTO [HISTORICO_IMPUESTO]([ID_IMPUESTO],[FECHA_INICIO],[FECHA_FIN],[VALOR],[DESCRIPCION])  VALUES(" & Me.id & ",GETDATE(),NULL," & Me.Valor & ", '" & Me.Justificacion & "')"
            Consulta.ExecuteNonQuery()
            Conextion.Close()
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function Buscar_Id_Impuesto(ByVal Nombre As String) As Integer

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
            Consulta.CommandText = "SELECT [ID_IMPUESTO], [Nombre], [Descripcion]  FROM [IMPUESTO] where NOMBRE='" & Nombre & "'"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Id_Empleado = CInt(Reder.Item(0).ToString())
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try

        Return Id_Empleado
    End Function


    Function ModificarImpuesto() As Boolean
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter = New FarmaciaSJDataSetTableAdapters.Linea_ImpuestoTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Try
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE [HISTORICO_IMPUESTO]   SET [FECHA_FIN] = GETDATE() WHERE ID_IMPUESTO=" & Me.id & " AND FECHA_FIN IS NULL"
            Consulta.ExecuteNonQuery()
            Conextion.Close()

            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "INSERT INTO [HISTORICO_IMPUESTO]([ID_IMPUESTO],[FECHA_INICIO],[FECHA_FIN] ,[VALOR] ,[DESCRIPCION])  VALUES(" & Me.id & ",GETDATE(),NULL, " & Me.Valor & ", '" & Me.Justificacion & "')"
            Consulta.ExecuteNonQuery()
            Conextion.Close()
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function


End Class
