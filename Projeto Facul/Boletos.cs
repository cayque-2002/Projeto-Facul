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
    public partial class Boletos : Form
    {

        private string id = "";

        public string consString = String.Format("Host={0};Port={1};" +
                   "Database={2};Username={3};Password={4};",
                                   "localhost", 5432, "AGGE",
                                        "postgres", "abc123");
        public NpgsqlConnection con;

        public Boletos()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;


            CBoxClienteBol.Text = "";
            CboxIDCtBol.Text = "";
            CBoxProgBol.Text = "";
            CBoxIDProgBol.Text = "";
            CboxValorBol.Text = "";
            CBoxBanco.Text = "";
            CBoxAgencia.Text = "";
            CBoxContaCredito.Text = "";
            CBoxParcela.Text = "";
            CboxNumDoc.Text = "";
            CBoxDataVenc.Text = "";

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
            Program.cmd.Parameters.AddWithValue("idcli_bol", (Convert.ToInt32(CBoxIDCli.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("idct", (Convert.ToInt32(CboxIDCtBol.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("idprog_bol", (Convert.ToInt32(CBoxIDProgBol.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("valor_documento", (Convert.ToDouble(CboxValorBol.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("banco", CBoxBanco.Text.Trim());
            Program.cmd.Parameters.AddWithValue("agencia", CBoxAgencia.Text.Trim());
            Program.cmd.Parameters.AddWithValue("conta_credito", CBoxContaCredito.Text.Trim());
            Program.cmd.Parameters.AddWithValue("num_parcela", (Convert.ToInt32(CBoxParcela.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("num_documento",CboxNumDoc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("data_vencimento", (Convert.ToDateTime(CBoxDataVenc.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("situacao_bol", CBoxSituacaoBol.Text.Trim());

        }

        private void Boletos_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);

            con.Open();
            string queryBol = "Select * from clientes";
            NpgsqlDataAdapter daBol = new NpgsqlDataAdapter(queryBol, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtBol = new DataTable();
            daBol.Fill(dtBol);

            CBoxIDCli.DisplayMember = "idcli";
            CBoxIDCli.DataSource = dtBol;

            CBoxClienteBol.DisplayMember = "nome_cli";
            CBoxClienteBol.DataSource = dtBol;

        }

        private void btnRegistrarBoleto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CboxIDCtBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Contrato", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxIDCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Cliente", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxIDProgBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CboxValorBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Valor", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxBanco.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Banco", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxAgencia.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Agência", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxContaCredito.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Conta Crédito", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CboxNumDoc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o número da Parcela", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else if (string.IsNullOrEmpty(CBoxParcela.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o número da Parcela", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else if (string.IsNullOrEmpty(CBoxDataVenc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Data de Vencimento", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxSituacaoBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Situação para o Boleto", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }






            Program.sql = "insert into boletos(agencia, banco, conta_credito, data_vencimento, " +
                "idcli_bol, idct, idprog_bol, num_documento, num_parcela, valor_documento, situacao_bol) " +
                "Values(@agencia, @banco, @conta_credito, @data_vencimento, " +
                "@idcli_bol, @idct, @idprog_bol, @num_documento, @num_parcela, @valor_documento, @situacao_bol)";

            executa(Program.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

        }

        private void BtnPesqConBol_Click(object sender, EventArgs e)
        {

            con = new NpgsqlConnection(consString);

            con.Open();
            string queryBoleto = "Select * from contratos " +
                "left join clientes on idcli = idcliente " +
                "left join programacoes on idprog = idprogramacao " +
                "left join boletos on idcli_bol = idcliente and idprog_bol = idprogramacao " +
                "where idcli::Text = '" + CBoxIDCli.Text + "'";
            NpgsqlDataAdapter daBoleto = new NpgsqlDataAdapter(queryBoleto, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtBoleto = new DataTable();
            daBoleto.Fill(dtBoleto);
            

            CboxIDCtBol.DisplayMember = "idcontrato";
            CboxIDCtBol.DataSource = dtBoleto;

            CBoxProgBol.DisplayMember = "nome_prog";
            CBoxProgBol.DataSource = dtBoleto;

            CBoxIDProgBol.DisplayMember = "idprog";
            CBoxIDProgBol.DataSource = dtBoleto;

            CboxValorBol.DisplayMember = "valor_prog";
            CboxValorBol.DataSource = dtBoleto;

            CBoxParcela.DisplayMember = "num_parcela";
            CBoxParcela.DataSource = dtBoleto;

            CBoxDataVenc.DisplayMember = "data_vencimento";
            CBoxDataVenc.DataSource = dtBoleto;
            con.Close();

            loadData("");

        }

        private void BtnBaixarFatura_Click(object sender, EventArgs e) //f
        {
            if (string.IsNullOrEmpty(CboxIDCtBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Contrato", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxIDCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Cliente", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxIDProgBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CboxValorBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Valor", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            else if (string.IsNullOrEmpty(CBoxParcela.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o número da Parcela", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else if (string.IsNullOrEmpty(CBoxDataVenc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Data de Vencimento", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxSituacaoBol.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Situação para o Boleto", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

                Program.sql = "update boletos set  data_vencimento = @data_vencimento, " +
               "valor_documento = @valor_documento, situacao_bol = @situacao_bol " +
               "where num_parcela::Text = '" + CBoxParcela.Text + "'";
                

                executa(Program.sql, "Update");

                MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                loadData("");

                resetMe();

            }

        private void BtnPesqFatura_Click(object sender, EventArgs e)
        {

            con = new NpgsqlConnection(consString);

            con.Open();
            string queryBoletoPesq = "Select cli.idcli, cli.nome_cli, ct.idcontrato, pr.nome_prog, ct.tipo_logradouro_ct, " +
                "ct.logradouro_ct, ct.numero_residencia_ct, ct.bairro_cli_ct, ct.cidade_ct, bol.idboleto, bol.num_documento, " +
                "bol.banco, bol.conta_credito, bol.agencia, bol.valor_documento, bol.data_emissao, bol.data_vencimento, bol.situacao_bol " +
                "from contratos ct " +
                "left join clientes cli on cli.idcli = ct.idcliente " +
                "left join programacoes pr on pr.idprog = ct.idprogramacao " +
                "left join boletos bol on bol.idcli_bol = ct.idcliente and bol.idprog_bol = ct.idprogramacao " +
                "where idcli::Text = '" + CBoxIDCli.Text + "' and idcontrato::Text = '" + CboxIDCtBol.Text + "' and bol.idboleto is not null";
            NpgsqlDataAdapter daBoletoPesq = new NpgsqlDataAdapter(queryBoletoPesq, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtBoletoPesq = new DataTable();
            
            daBoletoPesq.Fill(dtBoletoPesq);

            dataGVBoletos.DataSource = dtBoletoPesq;

            con.Close();

        }
    }
    }


 


  


