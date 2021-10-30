using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projeto_Facul.Resources
{
    public partial class FRMAtendimento : Form
    {
        public string consString = String.Format("Host={0};Port={1};" +
                   "Database={2};Username={3};Password={4};",
                                   "localhost", 5432, "AGGE",
                                        "postgres", "abc123");
        public NpgsqlConnection con;

        public FRMAtendimento()
        {
            InitializeComponent();
        }

        private void btnRegistrarCli_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente _f9;
            _f9 = new Cadastrar_Cliente();
            _f9.ShowDialog();
            //Hide();
        }

        private void CBoxCliente_Enter(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);

            con.Open();
            string query = "Select * from clientes where nome_prog ilike '%" + CBoxCliente.Text + "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            
            da.Fill(dt);

            
            

            con.Close();
        }
    }
        }
   
