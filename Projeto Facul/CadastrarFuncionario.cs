﻿using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
//terminar
namespace Projeto_Facul
{
    public partial class CadastrarFuncionario : Form
    {

        private string id = "";
        private int intRow = 0;


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
            TBoxCNHCadFunc.Text = "";
            TBoxSenhaCadFunc.Text = "";
            TBoxLoginCadFunc.Text = "";
            MTBoxCelCadFunc.Text = "";
            CBoxPerfil.Text = "";

            if (CBoxSexoCadFunc.Items.Count > 0 );
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
            CRUD.cmd = new NpgsqlCommand(npgsql, CRUD.con);
            addParameters(param);
            CRUD.PerformCrud(CRUD.cmd);
        }

        private void addParameters(string param)
        {

            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("Nome", TBoxNomeCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("RG", TBoxRGCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("CPF", MTBoxCPFCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Email", TBoxEmailCadFunc.Text.ToString());
            CRUD.cmd.Parameters.AddWithValue("CNH", TBoxCNHCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Login", TBoxLoginCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Senha", TBoxSenhaCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Perfil", CBoxPerfil.SelectedIndex);
            CRUD.cmd.Parameters.AddWithValue("Celular", MTBoxCelCadFunc.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Sexo", CBoxSexoCadFunc.SelectedItem.ToString());

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
          else if (string.IsNullOrEmpty(TBoxCNHCadFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um CNH", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            CRUD.sql = "Insert Into funcionarios2(nome, rg, login, senha, CPF, Celular, email, sexo, perfil) " +
                "VALUES(@nome, @rg, @login, @senha, @CPF, @Celular, @email, @sexo, @perfil)";

            //CRUD.sql = "inserir_func(@nome, @rg, @login, @senha, @CPF, @Celular, @email, @sexo, @perfil)";

            executa(CRUD.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBoxNomeCadFunc.Text = "CAYQUE GUILHERME";
            TBoxRGCadFunc.Text = "38.706.356-0";
            MTBoxCPFCadFunc.Text = "454.222.668-97 ";
            TBoxEmailCadFunc.Text = "cayque.142@gmail.com";
            TBoxCNHCadFunc.Text = "123123123";
            TBoxSenhaCadFunc.Text = "123123";
            TBoxLoginCadFunc.Text = "CAYQUEADM";
            MTBoxCelCadFunc.Text = "(14)99763-7868";
            CBoxPerfil.Text = "Administrador";
        }
    }
}
