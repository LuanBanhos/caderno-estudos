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

    public partial class FrmVendas : Form
    {
        double v, ct, pm, cf, vcp, vlv, vi, p;

        private void button2_Click(object sender, EventArgs e)
        {
            txtV.Clear();
            txtCt.Clear();
            txtPm.Clear();
            txtVi.Clear();
            txtCf.Clear();
            txtVcp.Clear();
            txtVlv.Clear();
            txtP.Clear();
        }

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtV.Text, out v) | (!double.TryParse(txtCt.Text, out ct)) | (!double.TryParse(txtPm.Text, out pm)))
            {
                MessageBox.Show("Valor Informado,invalido!");
                return;
            }
            calcular();
            margem();
            convert();
        }
        private void calcular()
        {
            vi = v * ct / 100;
            cf = v * (pm / 30 * 0.03);
            vcp = v * 0.4;
            vlv = v - vi - ct - vcp;
            p = vlv / v * 100;
        }
        private void margem()
        {
            if (p < 40)
            {
                txtP.Text = "Margem Baixa!";
            }
            else if (p < 70)
            {
                txtP.Text = "Margem Média!";
            }
            else
            {
                txtP.Text = "Margem Alta!";
            }
        }
        private void convert()
        {
            txtVi.Text = Convert.ToString(vi);
            txtCf.Text = Convert.ToString(cf);
            txtVcp.Text = Convert.ToString(vcp);
            txtVlv.Text = Convert.ToString(vlv);
        }
    }
}
