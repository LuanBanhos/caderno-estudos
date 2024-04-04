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
    public partial class FrmLista : Form
    {
        List<int> lsnum = new List<int>();
        List<string> lsnome = new List<string>();
        string nome;
        public FrmLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int num;
            if(!int.TryParse(txtnumero.Text,out num))
            {
                MessageBox.Show("Numero Invalido!");
                return;
            }

            
            lsnum.Add(num);

            lblelementos.Text = lsnum.Count.ToString();
            lblsoma.Text = lsnum.Sum().ToString();

            int cont = 0;

            for(int i = 0; i < lsnum.Count; i++)
            {
                if ((lsnum[i] % 2) == 0)
                {
                    cont++;
                }
            }
            lblpares.Text = cont.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lsnome.Contains(nome))
            {
                MessageBox.Show("Este nome ja existe!!");
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome Invalido!!");
                return;
            }

            nome = txtNome.Text;
            lsnome.Add(nome);
            int contadorA = 0;
            int contadorJ = 0;
            int contadorM = 0;

            for(int i = 0; i < lsnome.Count; i++)
            {
                if ((lsnome[i][0] == 'a' || lsnome[i][0] == 'A') )
                {
                    contadorA++;
                    lblA.Text = contadorA.ToString();
                }
                 else if ((lsnome[i][0] == 'j' || lsnome[i][0] == 'J'))
                {
                    contadorJ++;
                    lblF.Text = contadorJ.ToString();
                }
                 else if ((lsnome[i][0] == 'm' || lsnome[i][0] == 'M'))
                {
                   contadorM++;
                   lblM.Text = contadorM.ToString();
                }
               
            }
           

            //for (int i = 0; i < lsnome.Count; i++)
            //{
            //    if ((lsnome[i][0] == 'j' || lsnome[i][0] == 'J'))
            //    {
            //        contadorJ++;
            //    }
            //    lblF.Text = contadorA.ToString();

            //}
            //for (int i = 0; i < lsnome.Count; i++)
            //{
            //    if ((lsnome[i][0] == 'm' || lsnome[i][0] == 'M'))
            //    {
            //        contadorJ++;
            //    }
            //    lblM.Text = contadorM.ToString();

        }



        
    }
}
////List<int> lstNum = new List<int>(5);
//List<int> lstNum = new List<int>();
//lstNum.Add(10);
//int x = lstNum[0];
//lstNum.Add(20);// adicionar valor a lista 
//lstNum.Add(30);


//lstNum.Count; // fala quantas posiçoes tem a sua lista 
//lstNum.RemoveAt(0); // remover um index
//MessageBox.Show(lstNum[0].ToString());
//lstNum.Remove(30); // remover um valor da lista

//if (lstNum.Contains(20)) // checar se ja tem esse valor
//{

//}

//lstNum.Insert(2, 50); // inserir elemento na posição informada 

//lstNum.Sum();// soma  o valor de todos valores da lista
//lstNum.Average(); // faz a media aritimetica
//lstNum.Max(); // maior valor
//lstNum.Min(); // menor valor
//lstNum.Clear(); // limpa a lista
//lstNum.IndexOf(30);// retorna o index desse valor
//lstNum.Sort(); // ordena a lista 
