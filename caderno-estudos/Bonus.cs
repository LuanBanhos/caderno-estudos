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
    public partial class Bonus : Form
    {
        double salario, dependente, valorBonus = 0;
        public Bonus()
        {
            InitializeComponent();
        }
        private void chkboxTrabalha_CheckedChanged(object sender, EventArgs e)
        {
            txtSalario.Visible = chkboxTrabalha.Checked;
            label3.Visible = chkboxTrabalha.Checked;
        }

        private void chkBoxEstuda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEstuda.Checked == true)
            {
                gpEstudos.Visible = true;
                gpTurno.Visible = true;
                gpInstituicao.Visible = true;
            }
            else
            {
                gpEstudos.Visible = false;
                gpTurno.Visible = false;
                gpInstituicao.Visible = false;
            }

        }

        private void bttCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDependente.Text, out dependente))
            {
                MessageBox.Show("Valor Informado, Incorreto!!");

            }
            if (chkboxTrabalha.Checked)
            {
                if (!double.TryParse(txtSalario.Text, out salario))
                {
                    MessageBox.Show("Valor Informado, Incorreto!!");

                }
                valorBonus = (salario * 0.10) + (dependente * 50);
            }
            if (chkBoxEstuda.Checked)
            {
                if (rdfundamental.Checked)
                {
                    valorBonus += 50;
                }
                else if (rdMedio.Checked)
                {
                    valorBonus += 100;
                }
                else if (rdSuperior.Checked)
                {
                    valorBonus += 150;
                }
                else if (rdPos.Checked)
                {
                    valorBonus += 200;
                }
                if (rdNoite.Checked)
                {
                    valorBonus += 50;
                }
                if (rdPublico.Checked)
                {
                    valorBonus += 50;
                }
                if (dependente > 0)
                {
                    valorBonus += dependente * 50;
                }
            }
            if (!chkboxTrabalha.Checked && !chkBoxEstuda.Checked)
            {
                valorBonus += 100 + dependente * 50;
            }
            txtValorBonus.Text = valorBonus.ToString();


        }
    }
}
