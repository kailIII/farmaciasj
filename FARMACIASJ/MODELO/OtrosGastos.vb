Public Class OtrosGastos
    Private ID As Decimal
    Private Monto As Double
    Private Fecha As Date
    Private Descripcion As String
    Private Reporte As Otros_Gastos

    Public Sub New(ByVal Monto As Double, ByVal Fecha As Date, ByVal Descripcion As String)
        MyBase.New()
        Me.Monto = Monto
        Me.Fecha = Fecha
        Me.Descripcion = Descripcion
        Me.ID = 0
    End Sub
    Public Sub New(ByVal Fecha As Date)
        MyBase.New()
        Me.Monto = 0
        Me.Fecha = Fecha
        Me.ID = 0
    End Sub
    Public Sub New()
        MyBase.New()
    End Sub
    Public Function get_monto() As Double
        Return Me.Monto
    End Function
    Public Function get_fecha() As Date
        Return Me.Fecha
    End Function
    Public Function get_Descripcion() As String
        Return Me.Descripcion
    End Function

    Public Sub set_monto(ByVal monto As Double)
        Me.Monto = monto
    End Sub

    Public Sub set_fecha(ByVal fecha As Date)
        Me.Fecha = fecha
    End Sub

    Public Sub set_descripcion(ByVal descripcion As String)
        Me.Descripcion = descripcion
    End Sub

    Public Function Insertar_Otro_Gasto() As Boolean
        Dim OtrosGastosTableAdapter As FarmaciaSJDataSetTableAdapters.OTROS_GASTOSTableAdapter
        Dim BasedeDatos As FarmaciaSJDataSet
        Try
            BasedeDatos = New FarmaciaSJDataSet
            OtrosGastosTableAdapter = New FarmaciaSJDataSetTableAdapters.OTROS_GASTOSTableAdapter
            OtrosGastosTableAdapter.Insert(Monto, Fecha, Descripcion)
            OtrosGastosTableAdapter.Update(BasedeDatos.OTROS_GASTOS)
            BasedeDatos.AcceptChanges()
            Return True
        Catch err As Exception
            Return False
        End Try
    End Function

    Public Function Generar_Reporte_OtrosGastos(ByVal Hasta As Date) As Boolean
        Me.Reporte = New Otros_Gastos
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
            Command.CommandText = "SELECT     OTROS_GASTOS.* FROM         OTROS_GASTOS WHERE     (FECHA >= CONVERT(DATETIME, '" & Me.Fecha.Year & "-" & Me.Fecha.Month & "-" & Me.Fecha.Day & "', 102)) AND (FECHA <= CONVERT(DATETIME, '" & Hasta.Year & "-" & Hasta.Month & "-" & Hasta.Day & "', 102))"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "OTROS_GASTOS")
            Me.Reporte.SetDataSource(FarmaciaSJ)
            Return True
        Catch E As Exception
            Return False
        End Try
    End Function

    Public Function get_reporte() As Otros_Gastos
        Return Me.Reporte
    End Function

    Public Sub set_reporte(ByVal reporte As Otros_Gastos)
        Me.Reporte = reporte
    End Sub

End Class
