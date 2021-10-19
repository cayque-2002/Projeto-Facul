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
    public partial class FRMTecnico : Form
    {
        public FRMTecnico()
        {
            InitializeComponent();
        }


        private void FRMTecnico_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
