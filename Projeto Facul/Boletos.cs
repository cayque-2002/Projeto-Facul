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
            Program.cmd.Parameters.AddWithValue("idcli", (Convert.ToInt32(CboxIDCtBol.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("idct", (Convert.ToInt32(CboxIDCtBol.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("idprog_bol", (Convert.ToInt32(CBoxIDProgBol.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("valor_documento", CboxValorBol.Text.Trim());
            Program.cmd.Parameters.AddWithValue("banco", CBoxBanco.Text.Trim());
            Program.cmd.Parameters.AddWithValue("agencia", CBoxAgencia.Text.Trim());
            Program.cmd.Parameters.AddWithValue("conta_credito", CBoxContaCredito.Text.Trim());
            Program.cmd.Parameters.AddWithValue("num_parcela", CBoxParcela.Text.Trim());
            Program.cmd.Parameters.AddWithValue("data_emissao", CBoxParcela.Text.Trim());
            Program.cmd.Parameters.AddWithValue("data_vencimento", CBoxParcela.Text.Trim());






        }

        private void Boletos_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);

            con.Open();
            string queryBoleto = "Select * from contratos " +
                "left join clientes on idcli = idcliente " +
                "left join programacoes on idprog = idprogramacao" +
                "where idcontrato = ";
            NpgsqlDataAdapter daBoleto = new NpgsqlDataAdapter(queryBoleto, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtBoleto = new DataTable();
            daBoleto.Fill(dtBoleto);
            //carregar os contratos de pertencentes ao cliente where id cliente =  talvez fazer o nome virar fk na tabela
            CBoxClienteBol.DisplayMember = "nome_cli";
            CBoxClienteBol.DataSource = dtBoleto;

            CboxIDCtBol.DisplayMember = "idcontrato";
            CboxIDCtBol.DataSource = dtBoleto;

            CBoxProgBol.DisplayMember = "nome_programacao";
            CBoxProgBol.DataSource = dtBoleto;

            CBoxIDProgBol.DisplayMember = "idprog";
            CBoxIDProgBol.DataSource = dtBoleto;
            con.Close();

            loadData("");
        }
    }
}
  


