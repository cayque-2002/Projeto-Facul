using Npgsql;
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
//corrigir exception da conexão do login com o banco
namespace Projeto_Facul
{ 

    public partial class FRM_AGGE : Form
    {
        public string consString = String.Format("Host={0};Port={1};" +
            "Database={2};Username={3};Password={4};",
            "localhost", 5432, "AGGE",
             "postgres", "abc123");
        
        public NpgsqlConnection con;



        public FRM_AGGE()
        {
            InitializeComponent();
            BoxUser.Select();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from funcionarios Where login = '"+BoxUser.Text+"'AND senha = '"+BoxPass.Text+"'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count == 1)

            {
              //ENTRE NO SISTEMA
              MessageBox.Show("Login efetuado com sucesso!");
                {
                    FRM_Menu _f2;
                    _f2 = new FRM_Menu();
                    _f2.ShowDialog();
                    //Hide();
                    
                }
              
            }
            
             else
             {
                 MessageBox.Show("Usuario ou senha não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BoxUser.Text = ""; //limpa campo
                BoxPass.Text = "";
                BoxUser.Select(); //seta o cursor no primeiro campo ou no campo selecionado
             }

            con.Close();


        }


        private void FRM_AGGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }



        private void FRM_AGGE_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRM_AGGE_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(consString);
        }
    }
}