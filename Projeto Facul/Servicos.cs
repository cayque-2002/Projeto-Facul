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
    public partial class Servicos : Form
    {
        private string id = "";
#pragma warning disable CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado
        private int intRow = 0;
#pragma warning restore CS0414 // O campo "CadastrarFuncionario.intRow" é atribuído, mas seu valor nunca é usado


        public Servicos()
        {
            InitializeComponent();
            resetMe();
        }


        private void resetMe()
        {
            this.id = string.Empty;


            TBoxNomeCadServ.Text = "";
            TBoxFuncServ.Text = "";
            TBoxDescriFunc.Text = "";

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
            Program.cmd.Parameters.AddWithValue("nome_serv", TBoxNomeCadServ.Text.Trim());
            Program.cmd.Parameters.AddWithValue("funcao_serv", TBoxFuncServ.Text.Trim());
            Program.cmd.Parameters.AddWithValue("descricao_serv", TBoxDescriFunc.Text.Trim());

        }

        private void BtnCadServ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBoxNomeCadServ.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um nome para o Serviço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxFuncServ.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma função para o Serviço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(TBoxDescriFunc.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Descrição do serviço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Program.sql = "insert into servicos (nome_serv, funcao_serv, descricao_serv)" +
                " Values(@nome_serv, @funcao_serv, @descricao_serv)";

            executa(Program.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();

        }
    }
}
