using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projeto_Facul
{
    public partial class FRMFuncionario : Form
    {
        public string consString = String.Format("Host={0};Port={1};" +
     "Database={2};Username={3};Password={4};",
     "localhost", 5432, "AGGE",
      "postgres", "abc123");

        public NpgsqlConnection con;


        public FRMFuncionario()
        {
            InitializeComponent();
        }


        private void btnIncluirFunc_Click_1(object sender, EventArgs e)
        {
            CadastrarFuncionario _f7;
            _f7 = new CadastrarFuncionario();
            _f7.ShowDialog();
            //Hide();
        }

        private void btnPesquisarFunc_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "Select nome, rg, login, email, sexo, perfil, celular from funcionarios where nome ilike '%" + TBoxPesquisarFunc.Text +"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            {
                da.Fill(dt);

                dataGVFunc.DataSource = dt;
            }

            con.Close();

        }

        private void FRMFuncionario_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);
        }
    }
}
