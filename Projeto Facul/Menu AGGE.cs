using Projeto_Facul.Resources;
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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

      

        private void FRM_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btnModuloTec_Click(object sender, EventArgs e)
        {
            FRMTecnico _f3;
            _f3 = new FRMTecnico();
            _f3.ShowDialog();
            //Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMAtendimento _f4;
            _f4 = new FRMAtendimento();
            _f4.ShowDialog();
            //Hide();
        }

        private void btnModuloAdm_Click(object sender, EventArgs e)
        {
            
            
                FRMAdministrativo _f5;
                _f5 = new FRMAdministrativo();
                _f5.ShowDialog();
                //Hide();
         }

        private void FRM_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}