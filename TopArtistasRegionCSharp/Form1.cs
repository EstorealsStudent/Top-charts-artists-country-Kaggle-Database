using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TopArtistasRegionCSharp
{
    public partial class Form1 : Form
    {
        private string query;
        private bool auto;
        public Form1()
        {
            auto = true; 
            InitializeComponent();
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Add any initialization after the InitializeComponent() call.
            // Create a new instance of the Connection class
            query = "select id, nombre from PAIS";
        ComboBoxPaises.DataSource = Connection.SelectQuery(query);
        ComboBoxPaises.DisplayMember = "nombre";
            ComboBoxPaises.ValueMember = "id";
            auto = false;
            DataGridView1.ReadOnly = true;
            query = "select ARTISTA.Id AS [Top Artist],ARTISTA.Nombre,PAIS.Nombre AS Pais from ARTISTA  join PAIS on pais.Id = ARTISTA.IdPais";
            DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void ComboBoxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ComboBoxPaises.Text))
            {
                return;
            }
            query = "select ARTISTA.Id AS [Top Artist],ARTISTA.Nombre,PAIS.Nombre AS Pais from ARTISTA join PAIS on pais.Id = ARTISTA.IdPais where PAIS.Nombre = '" + ComboBoxPaises.Text + "'";
            DataGridView1.DataSource = Connection.SelectQuery(query);


        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string buscarTexto = TextBoxBuscar.Text.Trim();
            string query = "";

            query = "select ARTISTA.Id AS [Top Artist],ARTISTA.Nombre,PAIS.Nombre AS Pais from ARTISTA join PAIS on pais.Id = ARTISTA.IdPais where ARTISTA.Nombre LIKE '%" + buscarTexto + "%'" ;
        DataTable dt = Connection.SelectQuery(query);

            DataGridView1.DataSource = dt;
        }
    }
}