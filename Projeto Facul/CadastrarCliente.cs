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
    public partial class Cadastrar_Cliente : Form
    {

        private string id = "";
#pragma warning disable CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado
        private int intRow = 0;
#pragma warning restore CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado

        public Cadastrar_Cliente()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;


            TBoxNomeCadCli.Text = "";
            TBoxRGCadCli.Text = "";
            MTBoxCPFCadCli.Text = "";
            MTBoxCelCadCli.Text = "";
            TBoxEmailCadCli.Text = "";
            TBoxTipoLog.Text = "";
            TBoxLogradouro.Text = "";
            TBoxNumeroCasa.Text = "";
            TBoxBairro.Text = "";
            TBoxCidade.Text = "";
            TBoxComplemento.Text = "";

#pragma warning disable CS0642 // Instrução empty possivelmente incorreta
            if (CBoxSexoCadCli.Items.Count > 0) ;
#pragma warning restore CS0642 // Instrução empty possivelmente incorreta
            {
                CBoxSexoCadCli.SelectedIndex = 0;
            }

            BtnLimparCadastroCli.Text = "Limpar";



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
            Program.cmd.Parameters.AddWithValue("nome_cli", TBoxNomeCadCli.Text.Trim());
            Program.cmd.Parameters.AddWithValue("rg_cli", TBoxRGCadCli.Text.Trim());
            Program.cmd.Parameters.AddWithValue("cpf_cli", MTBoxCPFCadCli.Text.Trim());
            Program.cmd.Parameters.AddWithValue("celular_cli", MTBoxCelCadCli.Text.Trim());
            Program.cmd.Parameters.AddWithValue("sexo", CBoxSexoCadCli.SelectedItem.ToString());
            Program.cmd.Parameters.AddWithValue("email_cli", TBoxEmailCadCli.Text.ToString());
            Program.cmd.Parameters.AddWithValue("tipo_logradouro_cli", TBoxTipoLog.Text.Trim());
            Program.cmd.Parameters.AddWithValue("logradouro_cli", TBoxLogradouro.Text.Trim());
            Program.cmd.Parameters.AddWithValue("numero_residencia", TBoxNumeroCasa.Text.Trim());
            Program.cmd.Parameters.AddWithValue("bairro_cli", TBoxBairro.Text.Trim());
            Program.cmd.Parameters.AddWithValue("cidade_cli", TBoxCidade.Text.Trim());
            Program.cmd.Parameters.AddWithValue("complemento_endereco_cli", TBoxComplemento.Text.Trim());

        }
        private void BtnCadastrarFunc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TBoxNomeCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um nome", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxRGCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um RG", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(MTBoxCPFCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Celular", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(MTBoxCelCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um CPF", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxEmailCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um E-mail", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxTipoLog.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Tipo de Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxLogradouro.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxNumeroCasa.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Numero de residencia", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxBairro.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Bairro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxCidade.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Cidade", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxComplemento.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Complemento", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            



            Program.sql = "select * from inserir_cli(@nome_cli, @rg_cli, @cpf_cli, " +
                "@celular_cli, @sexo, @email_cli, @tipo_logradouro_cli, @logradouro_cli, @numero_residencia, " +
                "@bairro_cli, @cidade_cli, @complemento_endereco_cli)";
            
            executa(Program.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

        }


        private void Cadastrar_Cliente_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TBoxNomeCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um nome", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxRGCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um RG", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(MTBoxCPFCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Celular", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(MTBoxCelCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um CPF", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxEmailCadCli.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um E-mail", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxTipoLog.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Tipo de Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxLogradouro.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxNumeroCasa.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Numero de residencia", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxBairro.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Bairro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxCidade.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Cidade", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxComplemento.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Complemento", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




            Program.sql = "update clientes set " +
                "celular_cli = @celular_cli, sexo = @sexo, email_cli = @email_cli, tipo_logradouro_cli = @tipo_logradouro_cli, " +
                "logradouro_cli = @logradouro_cli, numero_residencia = @numero_residencia, " +
                "bairro_cli = @bairro_cli, cidade_cli = @cidade_cli, complemento_endereco_cli = @complemento_endereco_cli " +
                "where nome_cli = @nome_cli";

            executa(Program.sql, "Alterar");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

        }
    }
}
