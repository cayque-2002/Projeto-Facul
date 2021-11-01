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



        private void FRMAdministrativo_Load(object sender, EventArgs e)
        {
            var gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
        }

        private void bunifuFBtnFunc_Click(object sender, EventArgs e)
        {
            FRMFuncionario _f6;
            _f6 = new FRMFuncionario();
            _f6.ShowDialog();
            //Hide();
        }

        private void bunifuFBtnProg_Click(object sender, EventArgs e)
        {
            FRMProgramacoes _f8;
            _f8 = new FRMProgramacoes();
            _f8.ShowDialog();
            //Hide();
        }

        private void bunifuFBtnOrdemServiço_Click(object sender, EventArgs e)
        {
            Servicos _f11;
            _f11 = new Servicos();
            _f11.ShowDialog();
            //Hide();
        }
    }
}
