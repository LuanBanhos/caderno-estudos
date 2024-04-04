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
    public partial class FrmSeguro : Form
    {
        double valorInc, valorF, ValorB;
        public FrmSeguro()
        {
            InitializeComponent();
        }

        private void rdButUnic_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = rdButPessoal.Checked;
        }

        private void btt_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtValorV.Text ,out valorInc))
            {
                MessageBox.Show("Valor Incorreto!!");
            }
            calcular();
            txtValorF.Text = valorF.ToString();
        }
        private void calcular ()
        {
            ValorB = valorInc * 0.05;
            valorF = ValorB;
            
            if (rdButPessoal.Checked && rdButUni.Checked) {
                valorF -= ValorB * 0.10;
            }else if(rdButPessoal.Checked && chkBoxNao.Checked)
            {
                valorF -= ValorB * 0.15;
            }else if(rdButPessoal.Checked && rdButUni.Checked && chkBoxNao.Checked)
            {
                valorF -= ValorB * 0.20;
            }else if (rdButPessoal.Checked)
            {
                valorF -= ValorB * 0.05;
            }
            else if (chkBoxNao.Checked)
            {
                valorF -= ValorB * 0.10;
            }

        }
    }
}
