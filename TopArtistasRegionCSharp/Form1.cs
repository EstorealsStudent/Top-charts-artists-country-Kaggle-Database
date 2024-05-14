using System;
using System.Windows.Forms;

namespace TopArtistasRegionSpotify
{

    public partial class Form1
    {
        private string query;
        private bool auto;
        // Create a constructor
        public Form1()
        {
            auto = true;

            // This call is required by the designer.
            InitializeComponent();
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Add any initialization after the InitializeComponent() call.
            // Create a new instance of the Connection class
            Connection.Disconect();
            query = "select id, nombre from PAIS";
            ComboBoxPaises.DataSource = Connection.SelectQuery(query);
            ComboBoxPaises.DisplayMember = "nombre";
            ComboBoxPaises.ValueMember = "id";
            auto = false;
            DataGridView1.ReadOnly = true;

            query = "select [Top Artist],Nombre,Pais from VW_Top_Artistas where Estatus=1";
            DataGridView1.DataSource = Connection.SelectQuery(query);
        }



        private void ComboBoxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPaises.Text is null)
            {
                return;
            }
            query = @"select [Top Artist],Nombre,Pais from VW_Top_Artistas
where Pais='" + ComboBoxPaises.Text + "' and Estatus=1";
            DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string buscarTexto = TextBoxBuscar.Text.Trim();
            string query = "";
            query = @"select [Top Artist],Nombre,Pais from VW_Top_Artistas
where Nombre LIKE '%" + buscarTexto + "%' and Estatus=1";
            // Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
            var dt = Connection.SelectQuery(query);

            DataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida y no en los encabezados de columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la primera celda de la fila en la que se hizo clic
                string valorCelda = DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                var form2 = new ShowArtist(valorCelda);
                form2.Show();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Login.Visible = true;

        }
    }
}