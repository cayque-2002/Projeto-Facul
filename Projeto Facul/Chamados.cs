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

namespace Projeto_Facul
{
    public partial class Chamados : Form
    {
        private string id = "";

        public string consString = String.Format("Host={0};Port={1};" +
                   "Database={2};Username={3};Password={4};",
                                   "localhost", 5432, "AGGE",
                                        "postgres", "abc123");
        public NpgsqlConnection con;
        public Chamados()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;


            CBoxClienteCh.Text = "";
            CBoxIDCliCh.Text = "";
            CBoxServicoCh.Text = "";
            CboxIDServCh.Text = "";
            RTBoxDescriCh.Text = "";
            CboxSituaCh.Text = "";
        }

        private void loadData(string keyword)
        {
            //Tudo
        }

        private void executa(string npgsql, string param)
        {
            Program.cmd = new NpgsqlCommand(npgsql, Program.con);
            addParameters(param);
            Program.PerformCrud(Program.cmd);
        }

        private void addParameters(string param)
        {

            Program.cmd.Parameters.Clear();
            Program.cmd.Parameters.AddWithValue("idcli_ch", (Convert.ToInt32(CBoxIDCliCh.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("idserv_ch", (Convert.ToInt32(CboxIDServCh.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("situacao_ch", CboxSituaCh.Text.Trim());
            Program.cmd.Parameters.AddWithValue("descricao_ch", RTBoxDescriCh.Text.Trim());
        }


            private void Chamados_Load(object sender, EventArgs e)
            {
                con = new NpgsqlConnection(consString);

                con.Open();
                string queryNome = "Select * from clientes";
                NpgsqlDataAdapter daNome = new NpgsqlDataAdapter(queryNome, con);
                //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
                DataTable dtNome = new DataTable();
                daNome.Fill(dtNome);
                CBoxClienteCh.DisplayMember = "nome_cli";
                CBoxClienteCh.DataSource = dtNome;

                CBoxIDCliCh.DisplayMember = "idcli";
                CBoxIDCliCh.DataSource = dtNome;

                con.Close();

                con = new NpgsqlConnection(consString);

                con.Open();
                string queryServ = "select * from servicos";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryServ, con);
                //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CBoxServicoCh.DisplayMember = "nome_serv";
                CBoxServicoCh.DataSource = dt;

                CboxIDServCh.DisplayMember = "idserv";
                CboxIDServCh.DataSource = dt;
            con.Close();
        }

        private void btnRegistrarCh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBoxClienteCh.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Cliente", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxServicoCh.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Serviço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CboxSituaCh.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma situação para o Chamado", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(RTBoxDescriCh.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a descrição do chamado", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Program.sql = "insert into chamados(idcli_ch, idserv_ch, situacao_ch, descricao_ch)" +
                "Values(@idcli_ch, @idserv_ch, @situacao_ch, @descricao_ch)";

            executa(Program.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

        }
    }
    }

