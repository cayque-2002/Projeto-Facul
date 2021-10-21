using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Facul.Resources
{
    public partial class FRMAtendimento : Form
    {
        public FRMAtendimento()
        {
            InitializeComponent();
        }

        private void btnRegistrarCli_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente _f9;
            _f9 = new Cadastrar_Cliente();
            _f9.ShowDialog();
            //Hide();
        }
    }
        }
   
