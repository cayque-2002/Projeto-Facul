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

namespace Projeto_Facul.Resources
{
    public partial class FRMAtendimento : Form
    {
        private string id = "";

        public string consString = String.Format("Host={0};Port={1};" +
                   "Database={2};Username={3};Password={4};",
                                   "localhost", 5432, "AGGE",
                                        "postgres", "abc123");
        public NpgsqlConnection con;

        public FRMAtendimento()
        {
            InitializeComponent();
            resetMe();
        }
        private void resetMe()
        {
            this.id = string.Empty;


            CBoxCliente.Text = "";
            CBoxTipoLogCon.Text = "";
            CBoxLogradouroCon.Text = "";
            CBoxNumeroCon.Text = "";
            CBoxBairroCon.Text = "";
            CBoxCidadeCon.Text = "";
            CBoxComplementoCon.Text = "";
            CBoxProg.Text = "";
            CBoxValorProgVenda.Text = "";
            CBoxIDCt.Text = "";
            CBoxIDProg.Text = "";
            CboxIDCli.Text = "";
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
            Program.cmd.Parameters.AddWithValue("idcli", (Convert.ToInt32(CboxIDCli.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("idprogramacao", (Convert.ToInt32(CBoxIDProg.Text.Trim())));
            Program.cmd.Parameters.AddWithValue("tipo_logradouro_ct", CBoxTipoLogCon.Text.Trim());
            Program.cmd.Parameters.AddWithValue("logradouro_ct", CBoxLogradouroCon.Text.Trim());
            Program.cmd.Parameters.AddWithValue("numero_residencia_ct", CBoxNumeroCon.Text.Trim());
            Program.cmd.Parameters.AddWithValue("bairro_cli_ct", CBoxBairroCon.Text.Trim());
            Program.cmd.Parameters.AddWithValue("cidade_ct", CBoxCidadeCon.Text.Trim());
            Program.cmd.Parameters.AddWithValue("complemento_endereco_ct", CBoxComplementoCon.Text.Trim());
     
        }


        private void btnRegistrarCli_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente _f9;
            _f9 = new Cadastrar_Cliente();
            _f9.ShowDialog();
            //Hide();
        }

        private void FRMAtendimento_Load(object sender, EventArgs e)
        {

            con = new NpgsqlConnection(consString);

            con.Open();
            string queryCliCon = "Select * from clientes";
            NpgsqlDataAdapter daCliCon = new NpgsqlDataAdapter(queryCliCon, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtCliCon = new DataTable();
            daCliCon.Fill(dtCliCon);
            //carregar os contratos de pertencentes ao cliente where id cliente =  talvez fazer o nome virar fk na tabela
            CboxIDCli.DisplayMember = "idcli";
            CboxIDCli.DataSource = dtCliCon;

            CBoxCliente.DisplayMember = "nome_cli";
            CBoxCliente.DataSource = dtCliCon;
            con.Close();

            loadData("");
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            //realizar insert em contrato

            if (string.IsNullOrEmpty(CBoxCliente.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Cliente", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxTipoLogCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Tipo de Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxLogradouroCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxNumeroCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Número de residência", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxBairroCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Bairro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxCidadeCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Cidade", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxComplementoCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Complemento de Endereço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxProg.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxValorProgVenda.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Valor de Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Program.sql = "insert into contratos(idcliente, idprogramacao, tipo_logradouro_ct," +
                "logradouro_ct, numero_residencia_ct, bairro_cli_ct, cidade_ct, complemento_endereco_ct) " +
                "Values(@idcliente, @idprogramacao, @tipo_logradouro_ct, @logradouro_ct, @numero_residencia_ct," +
                "@bairro_cli_ct, @cidade_ct, @complemento_endereco_ct)";

            executa(Program.sql, "Inserir");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();


        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            Chamados _f10;
            _f10 = new Chamados();
            _f10.ShowDialog();
            //Hide();
        }

        private void btnAtualizarCon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBoxCliente.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Cliente", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxTipoLogCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Tipo de Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxLogradouroCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxNumeroCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Número de residência", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxBairroCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Bairro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxCidadeCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Cidade", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxComplementoCon.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Complemento de Endereço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxProg.Text.Trim()))
            {
                MessageBox.Show("Por favor insira uma Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(CBoxValorProgVenda.Text.Trim()))
            {
                MessageBox.Show("Por favor insira um Valor de Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Program.sql = "update contratos set idprogramacao = @idprogramacao, tipo_logradouro_ct = @tipo_logradouro_ct, " +
                "logradouro_ct = @logradouro_ct, numero_residencia_ct = @numero_residencia_ct, bairro_cli_ct = @bairro_cli_ct, " +
                "cidade_ct = @cidade_ct, complemento_endereco_ct = @complemento_endereco_ct " +
                "where idcliente = @idcliente";

            executa(Program.sql, "Alterar");

            MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            loadData("");

            resetMe();
        }

        private void bunifuFbtnRegistrarCli_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente _f9;
            _f9 = new Cadastrar_Cliente();
            _f9.ShowDialog();
            //Hide();
        }

        private void bunifuFbtnAtualizarCon_Click(object sender, EventArgs e)
        {
          
            
                if (string.IsNullOrEmpty(CBoxCliente.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Cliente", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxTipoLogCon.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Tipo de Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxLogradouroCon.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Logradouro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxNumeroCon.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Número de residência", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxBairroCon.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Bairro", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxCidadeCon.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira uma Cidade", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxComplementoCon.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Complemento de Endereço", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxProg.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira uma Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (string.IsNullOrEmpty(CBoxValorProgVenda.Text.Trim()))
                {
                    MessageBox.Show("Por favor insira um Valor de Programação", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                Program.sql = "update contratos set idprogramacao = @idprogramacao, tipo_logradouro_ct = @tipo_logradouro_ct, " +
                    "logradouro_ct = @logradouro_ct, numero_residencia_ct = @numero_residencia_ct, bairro_cli_ct = @bairro_cli_ct, " +
                    "cidade_ct = @cidade_ct, complemento_endereco_ct = @complemento_endereco_ct " +
                    "where idcliente = @idcliente";

                executa(Program.sql, "Alterar");

                MessageBox.Show("Cadastro salvo.", "Insert Data : iBassukung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                loadData("");

                resetMe();
            }

        private void bunifuFbtnAbrirChamado_Click(object sender, EventArgs e)
        {
            Chamados _f10;
            _f10 = new Chamados();
            _f10.ShowDialog();
            //Hide();
        }

        private void BtnPesqContratos_Click(object sender, EventArgs e)
        {

            string queryCon = "Select * from contratos " +
                "left join clientes on idcli = idcliente " +
                "left join programacoes on idprog = idprogramacao" +
                " where idcli::Text = '" + CboxIDCli.Text + "'";
            NpgsqlDataAdapter daCon = new NpgsqlDataAdapter(queryCon, con);
            //NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dtCon = new DataTable();
            daCon.Fill(dtCon);

            CBoxIDCt.DisplayMember = "idcontrato";
            CBoxIDCt.DataSource = dtCon;

            CBoxTipoLogCon.DisplayMember = "tipo_logradouro_ct"; /* + "logradouro_cli" + "numero_residencia" +
                "bairro_cli" + "cidade_cli" + "complemento_endereco_cli";*/
            CBoxTipoLogCon.DataSource = dtCon;

            CBoxLogradouroCon.DisplayMember = "logradouro_ct";
            CBoxLogradouroCon.DataSource = dtCon;

            CBoxNumeroCon.DisplayMember = "numero_residencia_ct";
            CBoxNumeroCon.DataSource = dtCon;

            CBoxBairroCon.DisplayMember = "bairro_cli_ct";
            CBoxBairroCon.DataSource = dtCon;

            CBoxCidadeCon.DisplayMember = "cidade_ct";
            CBoxCidadeCon.DataSource = dtCon;

            CBoxComplementoCon.DisplayMember = "complemento_endereco_ct";
            CBoxComplementoCon.DataSource = dtCon;

            CBoxProg.DisplayMember = "nome_prog";
            CBoxProg.DataSource = dtCon;

            CBoxIDProg.DisplayMember = "idprog";
            CBoxIDProg.DataSource = dtCon;

            CBoxValorProgVenda.DisplayMember = "valor_prog";
            CBoxValorProgVenda.DataSource = dtCon;
            con.Close();
            loadData("");

        }

        private void bunifuFBtnBoleto_Click(object sender, EventArgs e)
        {
            Boletos _f15;
            _f15 = new Boletos();
            _f15.ShowDialog();
            //Hide();
        }
    }
    }
    
        
   
