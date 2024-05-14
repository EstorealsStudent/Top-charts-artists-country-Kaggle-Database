using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace TopArtistasRegionSpotify
{

    public class Connection
    {
        private static SqlConnection cnx = new SqlConnection();
        private static void Connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=localhost; Initial Catalog=TopArtistasRegion;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        public static void Disconect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
        // Create a method to excecute a Selection query
        public static DataTable SelectQuery(string query)
        {
            var dt = new DataTable();
            try
            {
                Connect();
                var cmd = new SqlCommand(query, cnx);
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dt;
        }

        public static SqlDataReader ExecuteStoredProcedureReader(string procedureName, SqlParameter[] parameters)
        {
            SqlDataReader reader = null;
            try
            {
                Connect();
                var cmd = new SqlCommand(procedureName, cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros si los hay
                if (parameters is not null)
                {
                    foreach (SqlParameter @param in parameters)
                        cmd.Parameters.Add(@param);
                }

                reader = cmd.ExecuteReader();

                // Verificar si hay filas antes de cerrar la conexión
                if (!reader.HasRows)
                {
                    // Si no hay filas, cerrar el lector y la conexión
                    reader.Close();
                    Disconect();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar el stored procedure: " + ex.Message);
                throw;
            }
            return reader;
        }

        public static DataTable ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters)
        {
            var dt = new DataTable();
            try
            {
                Connect();
                var cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedureName;

                if (parameters is not null && parameters.Length > 0)
                {
                    foreach (SqlParameter @param in parameters)
                        cmd.Parameters.Add(@param);
                }

                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar el stored procedure: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dt;
        }



    }
}