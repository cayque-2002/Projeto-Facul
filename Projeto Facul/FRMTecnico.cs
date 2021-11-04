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
    public partial class FRMTecnico : Form
    {

        private string id = "";

        public string consString = String.Format("Host={0};Port={1};" +
                   "Database={2};Username={3};Password={4};",
                                   "localhost", 5432, "AGGE",
                                        "postgres", "abc123");
        public NpgsqlConnection con;

        public FRMTecnico()
        {
            InitializeComponent();
            resetMe();
        }
        private void resetMe()
        {
            this.id = string.Empty;


            CBoxIDChamado.Text = "";
            CBoxSituaCh.Text = "";
            CBoxDescriCh.Text = "";
            CBoxAtendimentoTec.Text = "";

        }

        private void loadData(string keyword)
        {
            //Tudo
        }


        private void FRMTecnico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
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
            Program.cmd.Parameters.AddWithValue("idchamado", (Convert.ToInt32(CBoxIDChamado.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("atendimento_tec", CBoxAtendimentoTec.Text.Trim());

        }
            private void btnPesquisarCh_Click(object sender, EventArgs e)
        {
           
            con = new NpgsqlConnection(consString);

            con.Open();
            string queryChamado = "select chamados.idchamado, chamados.idcli_ch, chamados.idserv_ch, " +
                "chamados.situacao_ch, chamados.descricao_ch, " +
                "servicos.nome_serv, contratos.idcontrato, clientes.nome_cli " +
                "from chamados chamados " +
                "left join clientes clientes  on clientes.idcli = idcli_ch " +
                "left join servicos servicos on servicos.idserv = idserv_ch " +
                "left join contratos contratos on contratos.idcliente = clientes.idcli " +
                "where clientes.nome_cli ilike  '%"+TBoxChamadoPesq.Text+"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryChamado, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();


            da.Fill(dt);

                dataGVchamados.DataSource = dt;
            

            con.Close();

        }

        private void FRMTecnico_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);

            con.Open();
            string queryChamado = "select * from chamados ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryChamado, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CBoxIDChamado.DisplayMember = "idchamado";
            CBoxIDChamado.DataSource = dt;

            CBoxDescriCh.DisplayMember = "descricao_ch";
            CBoxDescriCh.DataSource = dt;

            con.Close();
        }

        private void btnAtenderCh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBoxIDChamado.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Id chamado", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxSituaCh.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma situação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxDescriCh.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Descrição", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxAtendimentoTec.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o atendimento realizado", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Program.sql = "update chamados set atendimento_tec = @atendimento_tec " +
                "where idchamado = @idchamado";

            executa(Program.sql, "Alterar");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

        }
    }
}

