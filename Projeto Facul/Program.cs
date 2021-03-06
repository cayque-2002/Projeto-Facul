using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;



namespace Projeto_Facul
{

   /* class Globais
    {
        public static Boolean logado = false;
        public static string query = "Select perfil from funcionarios where perfil = 0"; 
        //public static int perfil=0; //0=ADM 1=TECNICO 2=VENDEDOR
    }*/
  
        static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_AGGE());
        }
        public static string getConnectionString()
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Performance CRUD falhou: IBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dt = null;
            }

            return dt;

        }

      /*  public class criptografar
        {

            string client = new RestClient('http://ll.conteumahistoria.com/util/encrypt?text=123');
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

        }
      */
    }
}
    
