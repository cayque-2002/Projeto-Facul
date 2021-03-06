using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Projeto_Facul
{
    class CRUD
    {

        private static string getConnectionString()
        {
            string host = "Host=localhost;";
            string port = "Port=5432;";
            string db = "Database=AGGE;";
            string user = "Username=postgres;";
            string pass = "Password=abc123";

            string consString = String.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);

            return consString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCrud(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
               MessageBox.Show("Ocorreu um erro: " + ex.Message, "Performance CRUD falhou: IBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dt = null;
            }

            return dt;

        }
    }
}
