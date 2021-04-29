Imports MySql.Data.MySqlClient

Public Class ReporteVentas

    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto
        Dim F As String = DTPpre.Value.Date
        Dim L As String = DTPdes.Value.Date




        Dim Repo As New Reporte(F, L)




        Repo.getSetFecha = F
        Repo.getSetFechab = L


        'Invocamos al metodo para poblar con los datos al DGV
        Repo.PoblarDataGridReporte(DGVreporte)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreporte.CellContentClick
        Dim F As String = DTPpre.Value.Date
        Dim L As String = DTPdes.Value.Date
        Dim renglon As Integer
        'Al darle clic al renglón mostramos los datos en las cajas de texto

        renglon = DGVreporte.CurrentCellAddress.Y
        F = DGVreporte.Rows(renglon).Cells(0).Value
        L = DGVreporte.Rows(renglon).Cells(1).Value
    End Sub


End Class

Friend Class Reporte
    Private Fecha As String
    Private Fechab As String

    Public Sub New(f As String, l As String)
        Me.Fecha = Fecha
        Me.Fechab = Fechab
    End Sub

    Public Property getSetFecha() As String
        Get
            Return Fecha
        End Get
        Set(ByVal Value As String)
            Fecha = Value
        End Set
    End Property

    Public Property getSetFechab() As String
        Get
            Return Fechab
        End Get
        Set(ByVal Value As String)
            Fechab = Value
        End Set
    End Property

    Public Sub PoblarDataGridReporte(ByVal DGVreporte As DataGridView)
        'Método que lee todas las materias del origen de datos
        DGVreporte.DataSource = consultaTodoRepo()
        DGVreporte.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVreporte.Columns.Item(0).Width = 100
        DGVreporte.Columns.Item(1).Width = 100
        DGVreporte.Columns.Item(2).Width = 80
        DGVreporte.Columns.Item(3).Width = 180

    End Sub

    'Consulta datos de todas las carreras registradas
    Public Function consultaTodoRepo() As Object
        'Declaracion de variables necesarias'
        Dim cnx As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand


        comando.Connection = cnx

        comando.CommandText = "SELECT vg.fecha, p.fecha, COUNT(vg.id) As Num_Ventas, (SUM(anticipo) + SUM(pago)) As Ganancias FROM pagos As p JOIN venta_general As vg ON (vg.id = p.venta_general_fk) WHERE vg.fecha >='" + Fecha + "' AND p.fecha <='" + Fechab + "'"


        consultaTodoRepo = comando.CommandText
    End Function
End Class
