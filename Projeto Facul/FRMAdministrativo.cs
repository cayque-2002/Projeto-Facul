using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Facul
{
    public partial class FRMAdministrativo : Form
    {
        public FRMAdministrativo()
        {
            InitializeComponent();
        }

        private void FRMAdministrativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Funcionario _f6;
            _f6 = new Funcionario();
            _f6.ShowDialog();
            //Hide();
        }

        private void FRMAdministrativo_Load(object sender, EventArgs e)
        {
            var gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
        }

        private void bunifuFBtnFunc_Click(object sender, EventArgs e)
        {
            Funcionario _f6;
            _f6 = new Funcionario();
            _f6.ShowDialog();
            //Hide();
        }
    }
}
