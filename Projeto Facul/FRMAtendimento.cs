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

        private void FRMAtendimento_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);

            con.Open();
            string queryNome = "Select * from clientes";
            NpgsqlDataAdapter daNome = new NpgsqlDataAdapter(queryNome, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtNome = new DataTable();
            daNome.Fill(dtNome);
            CBoxCliente.DisplayMember = "nome_cli";
            CBoxCliente.DataSource = dtNome;
            con.Close();

            con = new NpgsqlConnection(consString);

            con.Open();
            string queryEndereco = "select tipo_logradouro_cli, " +
                "logradouro_cli, numero_residencia, bairro_cli, cidade_cli, " +
                "complemento_endereco_cli from clientes where nome_cli = '" + CBoxCliente.SelectedItem + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryNome, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            da.Fill(dt);
            CBoxTipoLogCon.DisplayMember = "tipo_logradouro_cli"; /* + "logradouro_cli" + "numero_residencia" +
                "bairro_cli" + "cidade_cli" + "complemento_endereco_cli";*/
            CBoxTipoLogCon.DataSource = dt;

            CBoxLogradouroCon.DisplayMember = "logradouro_cli";
            CBoxLogradouroCon.DataSource = dt;

            CBoxNumeroCon.DisplayMember = "numero_residencia";
            CBoxNumeroCon.DataSource = dt;

            CBoxBairroCon.DisplayMember = "bairro_cli";
            CBoxBairroCon.DataSource = dt;

            CBoxCidadeCon.DisplayMember = "cidade_cli";
            CBoxCidadeCon.DataSource = dt;

            CBoxComplementoCon.DisplayMember = "complemento_endereco_cli";
            CBoxComplementoCon.DataSource = dt;
            con.Close();

            con = new NpgsqlConnection(consString);

            con.Open();
            string queryProg = "Select * from programacoes";
            NpgsqlDataAdapter daProg = new NpgsqlDataAdapter(queryProg, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtProg = new DataTable();
            daProg.Fill(dtProg);
            CBoxProg.DisplayMember = "nome_prog";
            CBoxProg.DataSource = dtProg;
            CBoxValorProgVenda.DisplayMember = "valor_prog";
            CBoxValorProgVenda.DataSource = dtProg;
            con.Close();
        }
        
          
    }
    }
        
   
