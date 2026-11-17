using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    internal class Conexion
    {
        private string cadenaConexion =
           "Server=localhost;" +
           "Port=3306;" +
           "Database=pizzeria_db;" +
           "Uid=root;" +
           "Pwd=eliselenoir;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                return false;
            }
        }
    }
}
