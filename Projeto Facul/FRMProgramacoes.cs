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
    
    public partial class FRMProgramacoes : Form
    {
        public string consString = String.Format("Host={0};Port={1};" +
                    "Database={2};Username={3};Password={4};",
                                    "localhost", 5432, "AGGE",
                                         "postgres", "abc123");
        public NpgsqlConnection con;

        private string id = "";
#pragma warning disable CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado
        private int intRow = 0;
#pragma warning restore CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado

        public FRMProgramacoes()
        {
            InitializeComponent();
        }


        private void resetMe()
        {
            this.id = string.Empty;


            TBoxNomeProg.Text = "";
            TBoxTipoTecnologia.Text = "";
            TBoxVelProg.Text = "";
            TBoxValorProg.Text = "";


        }

           

        private void Programacoes_Load(object sender, EventArgs e)
        {

         
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
            Program.cmd.Parameters.AddWithValue("nome_prog", TBoxNomeProg.Text.Trim());
            Program.cmd.Parameters.AddWithValue("tipo_tecnologia", TBoxTipoTecnologia.Text.Trim());
            Program.cmd.Parameters.AddWithValue("velocidade_prog", TBoxVelProg.Text.Trim());
            Program.cmd.Parameters.AddWithValue("valor_prog", (Convert.ToDouble(TBoxValorProg.Text.Trim())));


        }

        private void btnCadProg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBoxNomeProg.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um nome para a Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxTipoTecnologia.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Tipo de Tecnologia", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxVelProg.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a Velocidade da Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          

           
            else if (string.IsNullOrEmpty(TBoxValorProg.Text.Trim()))
            {
            
                MessageBox.Show("Por favor insira o Valor da Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Program.sql = "insert into programacoes(nome_prog, tipo_tecnologia, velocidade_prog, valor_prog) VALUES(@nome_prog, @tipo_tecnologia, @velocidade_prog, @valor_prog)";


            //CRUD.sql = "inserir_func(@nome, @rg, @login, @senha, @CPF, @Celular, @email, @sexo, @perfil)";

            executa(Program.sql, "inserir_prog");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            resetMe();
        }



      
        private void btnPesquisarProg_Click(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);

            con.Open();
            string query = "Select * from programacoes where nome_prog ilike '%" +TBoxNomeProg.Text+"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            {
                da.Fill(dt);

                dataGVprog.DataSource = dt;
            }

            con.Close();

        }
    }
}
