using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caderno_estudos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.MdiParent = this; 
            frmVendas.Show();
        }

        private void iMCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmImc frmIMC = new FrmImc();
            frmIMC.MdiParent = this;
            frmIMC.Show();
        }

        private void seguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeguro frmSeguro = new FrmSeguro();
            frmSeguro.MdiParent = this;
            frmSeguro.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void bonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bonus frmbonus = new Bonus();
            frmbonus.MdiParent = this;
            frmbonus.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLista frmlista = new FrmLista();
            frmlista.MdiParent = this;
            frmlista.Show();
        }
    }
}
