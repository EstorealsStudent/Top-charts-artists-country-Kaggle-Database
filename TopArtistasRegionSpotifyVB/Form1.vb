Imports System.Data.SqlClient

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

        query = "select ARTISTA.Id AS [Top Artist],ARTISTA.Nombre,PAIS.Nombre AS Pais from ARTISTA 
join PAIS on pais.Id=ARTISTA.IdPais"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaises.SelectedIndexChanged
        If ComboBoxPaises.Text Is Nothing Then
            Exit Sub
        End If
        query = "select ARTISTA.Id AS [Top Artist],ARTISTA.Nombre,PAIS.Nombre AS Pais from ARTISTA 
join PAIS on pais.Id=ARTISTA.IdPais
where PAIS.Nombre='" & ComboBoxPaises.Text & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim buscarTexto As String = TextBoxBuscar.Text.Trim()
        Dim query As String = ""
        query = "select ARTISTA.Id AS [Top Artist],ARTISTA.Nombre,PAIS.Nombre AS Pais from ARTISTA
join PAIS on pais.Id=ARTISTA.IdPais 
where ARTISTA.Nombre LIKE '%" & buscarTexto & "%'"
        ' Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
        Dim dt As DataTable = Connection.SelectQuery(query)

        DataGridView1.DataSource = dt
    End Sub
End Class
