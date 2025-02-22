﻿using GerenciadorDeComandas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FrmControleComandas frmControleComandas = new FrmControleComandas();
            frmControleComandas.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ShowDialog();
        }

        private void comandasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmControleComandas frmControleComandas = new FrmControleComandas();
            frmControleComandas.ShowDialog();
        }
    }
}
