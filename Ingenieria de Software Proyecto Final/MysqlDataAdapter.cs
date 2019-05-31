using MySql.Data.MySqlClient;

namespace Ingenieria_de_Software_Proyecto_Final
{
    internal class MysqlDataAdapter
    {
        private MySqlConnection conn;
        private string consulta;

        public MysqlDataAdapter(string consulta, MySqlConnection conn)
        {
            this.consulta = consulta;
            this.conn = conn;
        }
    }
}