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
    public partial class FrmImc : Form
    {
       

       

        public FrmImc()
        {
            InitializeComponent();
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("O Peso está num formato incorreto!");
                return;
            }
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("A Altura está num formato incorreto!");
                return;
            }
            imc = peso / Math.Pow(altura, 2);
            lblIMC.Text = imc.ToString("n2");
            if (imc <= 18.5)
            {
                lblClassificacao.Text = "Abaixo do Peso";
            }
            else if (imc <= 25)
            {
                lblClassificacao.Text = "Peso Ideal";
            }
            else if (imc <= 30)
            {
                lblClassificacao.Text = "Sobrepeso";
            }
            else if (imc <= 35)
            {
                lblClassificacao.Text = "Obesidade I";
            }
            else if (imc <= 40)
            {
                lblClassificacao.Text = "Obesidade II";
            }
            else
            {
                lblClassificacao.Text = "Obesidade III";
            }
        }
    }
}
