﻿using System;
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
    public partial class FRMFuncionario : Form
    {
        public FRMFuncionario()
        {
            InitializeComponent();
        }


        private void btnIncluirFunc_Click_1(object sender, EventArgs e)
        {
            CadastrarFuncionario _f7;
            _f7 = new CadastrarFuncionario();
            _f7.ShowDialog();
            //Hide();
        }
    }
}
