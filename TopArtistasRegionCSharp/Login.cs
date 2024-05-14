using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using static TopArtistasRegionSpotify.Caché;

namespace TopArtistasRegionSpotify
{
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }



        private void ExecuteStoredProcedure()
        {
            // Ejecutar un procedimiento almacenado
            string procedureName = "SP_VerificarCredenciales";
            SqlParameter[] parameters = new[] { new SqlParameter("@Usuario", TextBoxUsername.Text), new SqlParameter("@Contraseña", TextBoxPassword.Text) };

            try
            {
                // Obtener un lector de datos para el resultado del procedimiento almacenado
                var reader = Connection.ExecuteStoredProcedureReader(procedureName, parameters);

                // Verificar si hay filas devueltas por el procedimiento almacenado
                if (reader.HasRows)
                {
                    // Si hay filas, leer la primera fila (suponiendo que solo hay una fila)
                    if (reader.Read())
                    {
                        // Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                        IdUsuariopublico = Conversions.ToInteger(reader["Id"]);
                        Nombrepublico = Conversions.ToString(reader["Nombre"]);
                        Usernamepublico = Conversions.ToString(reader["Username"]);

                    }
                }
                else
                {
                    // Si no hay filas, las credenciales son inválidas
                    // Puedes mostrar un mensaje de error o simplemente limpiar los campos
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                    TextBoxUsername.Text = "";
                    TextBoxPassword.Text = "";
                    // O puedes mantener al usuario en la misma página sin hacer nada
                    // Dependiendo de tu flujo de aplicación
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción aquí
                MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            My.MyProject.Forms.Form1.Show();
            Visible = false;

        }





        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxUsername.Text.Trim()) && !string.IsNullOrEmpty(TextBoxPassword.Text.Trim()))
            {
                ExecuteStoredProcedure();
            }

            else
            {
                MessageBox.Show("Por favor, complete ambos campos antes de continuar.");
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}