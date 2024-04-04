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
    public partial class FrmProdutos : Form
    {
        double valorTotal, valorunic, quant, descont, valorLiq, produto;

        private void button2_Click(object sender, EventArgs e)
        {
           txtDesc.Clear();
            txtDescri.Clear();
            txtLiqu.Clear();
            txtproduto.Clear();
            txtQuant.Clear();
            txtTotal.Clear();   
            txtUni.Clear();
        }

        public FrmProdutos()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Produtos p1 = new Produtos();
            p1.id = 1;
            p1.descricao = "Tenis Allstar";
            p1.valorUni = 120;
            p1.desconto = 8;
            Produtos p2 = new Produtos();
            p2.id = 2;
            p2.descricao = "Camisa Oficial Do Corinthians";
            p2.valorUni = 120;
            p2.desconto = 8;
            Produtos p3 = new Produtos();
            p3.id = 3;
            p3.descricao = "Bola De Futebol";
            p3.valorUni = 120;
            p3.desconto = 8;

            if (!double.TryParse(txtproduto.Text, out produto) | (!double.TryParse(txtQuant.Text,out quant)))
            {
                MessageBox.Show("Valor Incorreto!!");
                return;
            }

            if (produto == 1)
            {
                txtDescri.Text =
                txtUni.Text = Convert.ToString(p1.valorUni);
                txtDesc.Text = Convert.ToString(p1.desconto);
            }
            else if (produto == 2)
            {
                txtDescri.Text = p2.descricao;
                txtUni.Text = Convert.ToString(p2.valorUni);
                txtDesc.Text = Convert.ToString(p2.desconto);
            }
            else if (produto == 3)
            {
                txtDescri.Text = p3.descricao;
                txtUni.Text = Convert.ToString(p3.valorUni);
                txtDesc.Text = Convert.ToString(p3.desconto);
            }
            else
            {
                MessageBox.Show("Id Do Produto Incorreto!!!");
                return;
            }
            calcular();
            
        }
        

        private void calcular()
        {
            valorunic = double.Parse(txtUni.Text);
            valorTotal = valorunic * quant;

            descont = double.Parse(txtDesc.Text);
            valorLiq = valorTotal * (descont / 100);
            txtLiqu.Text = Convert.ToString(valorTotal-valorLiq);
            txtTotal.Text = Convert.ToString(valorTotal);
        }
        
    }
}
