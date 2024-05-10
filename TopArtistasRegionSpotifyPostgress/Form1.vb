Imports Npgsql

Public Class Form1
    Dim query As String
    Dim auto As Boolean
    'Create a constructor
    Public Sub New()
        auto = True
        ' This call is required by the designer.
        InitializeComponent()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ' Add any initialization after the InitializeComponent() call.
        'Create a new instance of the Connection class

        query = "select id, nombre from PAIS"
        ComboBoxPaises.DataSource = Connection.SelectQuery(query)
        ComboBoxPaises.DisplayMember = "nombre"
        ComboBoxPaises.ValueMember = "id"
        auto = False
        DataGridView1.ReadOnly = True

        query = "select * from VW_Top_Artistas"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaises.SelectedIndexChanged
        If ComboBoxPaises.Text Is Nothing Then
            Exit Sub
        End If
        query = "select * from VW_Top_Artistas
where Pais='" & ComboBoxPaises.Text & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim buscarTexto As String = TextBoxBuscar.Text.Trim()
        Dim query As String = ""
        query = "select * from VW_Top_Artistas
where Nombre ILIKE  '%" & buscarTexto & "%'"
        ' Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
        Dim dt As DataTable = Connection.SelectQuery(query)

        DataGridView1.DataSource = dt
    End Sub
End Class
