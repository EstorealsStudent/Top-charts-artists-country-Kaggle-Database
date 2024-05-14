using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TopArtistasRegionSpotify
{
    public partial class ShowArtist
    {
        private string idartista;
        private string query;

        // Constructor que acepta el valor como parámetro
        public ShowArtist(string valor)
        {
            InitializeComponent();
            // Guardar el valor recibido en la variable privada
            idartista = valor;
            InicializarInformacion();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPais.Text is null)
            {
                return;
            }
        }


        private void InicializarInformacion()
        {
            query = "select id, nombre from PAIS";
            ComboBoxPais.DataSource = Connection.SelectQuery(query);
            ComboBoxPais.DisplayMember = "nombre";
            ComboBoxPais.ValueMember = "id";
            ComboBoxPais.Refresh();

            // Ejecutar un procedimiento almacenado
            string procedureName = "SP_ObtenerArtistaPorId";
            SqlParameter[] parameters = new[] { new SqlParameter("@IdArtista", idartista) };


            // Obtener un lector de datos para el resultado del procedimiento almacenado
            var reader = Connection.ExecuteStoredProcedureReader(procedureName, parameters);

            // Verificar si hay filas devueltas por el procedimiento almacenado
            if (reader.HasRows)
            {
                // Si hay filas, leer la primera fila (suponiendo que solo hay una fila)
                if (reader.Read())
                {
                    // Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                    TextBoxAristaNombre.Text = Convert.ToString(reader["NombreArtista"]);
                    ComboBoxPais.SelectedValue = Convert.ToInt32(reader["Idpais"]);
                }
            }
            Connection.Disconect();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string procedureName = "SP_ActualizarArtista";
                SqlParameter[] parameters = new[] { new SqlParameter("@Id", idartista), new SqlParameter("@Nombre", TextBoxAristaNombre.Text), new SqlParameter("@IdPais", ComboBoxPais.SelectedValue), new SqlParameter("@idUsuarioModifica", Caché.IdUsuariopublico) };

                // Ejecutar el procedimiento almacenado
                Connection.ExecuteStoredProcedure(procedureName, parameters);
                Interaction.MsgBox("Artista Actualizado");
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Se produjo un error al actualizar el artista: " + ex.Message);
                // Puedes hacer un retorno aquí si lo deseas
                return;
            }

            query = "select [Top Artist],Nombre,Pais from VW_Top_Artistas where Estatus=1";
            My.MyProject.Forms.Form1.DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void ButtonELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                string procedureName = "SP_EliminarArtista";
                SqlParameter[] parameters = new[] { new SqlParameter("@Id", idartista), new SqlParameter("@IdUsuarioModifica", Caché.IdUsuariopublico) };

                // Ejecutar el procedimiento almacenado
                Connection.ExecuteStoredProcedure(procedureName, parameters);
                Interaction.MsgBox("Artista Eliminado");
            }

            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Se produjo un error al actualizar el artista: " + ex.Message);
                // Puedes hacer un retorno aquí si lo deseas
                return;
            }
            query = "select [Top Artist],Nombre,Pais from VW_Top_Artistas where Estatus=1";
            My.MyProject.Forms.Form1.DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}