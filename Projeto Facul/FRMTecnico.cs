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

        public string consString = String.Format("Host={0};Port={1};" +
                   "Database={2};Username={3};Password={4};",
                                   "localhost", 5432, "AGGE",
                                        "postgres", "abc123");
        public NpgsqlConnection con;
        public FRMTecnico()
        {
            InitializeComponent();
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
        

        private void btnPesquisarCh_Click(object sender, EventArgs e)
        {
            //corrigir select erro sintaxe
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
        }
    }
}

