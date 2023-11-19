using MySql.Data.MySqlClient;

using System.Data.SqlClient;

namespace Formulario
{
    internal class BdComun
    {
        private MySqlConnection conector;
        private string server = "localhost";
        private string database = "tutorial";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public BdComun()
        {
            cadenaConexion = $"Server={server};Database={database};User Id={user};Password={password};Convert Zero Datetime=True";
        }

        public MySqlConnection GetConexion()
        {
            if (conector == null)
            {
                conector = new MySqlConnection(cadenaConexion);
            }

            if (conector.State != System.Data.ConnectionState.Open)
            {
                conector.Open();
            }

            return conector;
        }

        public void CloseConexion()
        {
            if (conector != null && conector.State == System.Data.ConnectionState.Open)
            {
                conector.Close();
            }
        }
    }
}
