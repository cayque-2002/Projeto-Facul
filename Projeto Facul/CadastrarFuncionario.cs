using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
//terminar
namespace Projeto_Facul
{
    public partial class CadastrarFuncionario : Form
    {

        private string id = "";
#pragma warning disable CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado
        private int intRow = 0;
#pragma warning restore CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado


        public CadastrarFuncionario()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;
            
           
            TBoxNomeCadFunc.Text = "";
            TBoxRGCadFunc.Text = "";
            MTBoxCPFCadFunc.Text =  "";
            TBoxEmailCadFunc.Text = "";
            TBoxSenhaCadFunc.Text = "";
            TBoxLoginCadFunc.Text = "";
            MTBoxCelCadFunc.Text = "";
            CBoxPerfil.Text = "";

#pragma warning disable CS0642 // Instrução empty possivelmente incorreta
            if (CBoxSexoCadFunc.Items.Count > 0 );
#pragma warning restore CS0642 // Instrução empty possivelmente incorreta
            {
                CBoxSexoCadFunc.SelectedIndex = 0;
            }

            BtnLimparCadastroFunc.Text = "Limpar";

         
           
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            loadData("");
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
            Program.cmd.Parameters.AddWithValue("Nome", TBoxNomeCadFunc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("RG", TBoxRGCadFunc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("CPF", MTBoxCPFCadFunc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("Email", TBoxEmailCadFunc.Text.ToString());
            Program.cmd.Parameters.AddWithValue("Login", TBoxLoginCadFunc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("Senha", TBoxLoginCadFunc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("Perfil", CBoxPerfil.SelectedIndex);
            Program.cmd.Parameters.AddWithValue("Celular", MTBoxCelCadFunc.Text.Trim());
            Program.cmd.Parameters.AddWithValue("Sexo", CBoxSexoCadFunc.SelectedItem.ToString());

        }

        private void BtnCadastrarFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBoxNomeCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um nome", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxRGCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um RG", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           else if (string.IsNullOrEmpty(MTBoxCelCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Celular", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           else if (string.IsNullOrEmpty(MTBoxCPFCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um CPF", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           else if (string.IsNullOrEmpty(TBoxEmailCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um E-mail", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           else if (string.IsNullOrEmpty(TBoxLoginCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Login", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           else if (string.IsNullOrEmpty(TBoxSenhaCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Senha", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            {
                TBoxSenhaCadFunc.Text = string.Empty;
                for (int i = 0; i < TBoxSenhaCadFunc.Text.Length; i++) //recebe o conteudo do box e varia que recebe o ++
                {
                    int txtSenha = (int)TBoxSenhaCadFunc.Text[i]; //setou uma variavel representativa
                    int txtCifrado = txtSenha + 10;  //recebeu a variavel e recebeu o valor da chave (ler texto e ter deslocamento de 10 posições
                    TBoxSenhaCadFunc.Text += Char.ConvertFromUtf32(txtCifrado);   //saida usando a tabela ASCII
                }
            }

            Program.sql = "select * from inserir_func(@nome, @rg, @login, @senha, @cpf, @celular, @email, @sexo, @perfil)";
                //"VALUES(@nome, @rg, @login, @senha, @CPF, @Celular, @email, @sexo, @perfil)";

            //CRUD.sql = "inserir_func(@nome, @rg, @login, @senha, @CPF, @Celular, @email, @sexo, @perfil)";

            executa(Program.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBoxNomeCadFunc.Text = "CAYQUE GUILHERME DE ALVARENGA CARMO";
            TBoxRGCadFunc.Text = "38.706.356-0";
            MTBoxCPFCadFunc.Text = "454.222.668-97 ";
            TBoxEmailCadFunc.Text = "cayque.142@gmail.com";
            TBoxSenhaCadFunc.Text = "123123";
            TBoxLoginCadFunc.Text = "CAYQUEG";
            MTBoxCelCadFunc.Text = "(14)99763-7868";
            
        }
    }
}
