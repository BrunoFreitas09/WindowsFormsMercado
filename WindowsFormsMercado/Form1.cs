using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMercado
{
    public partial class Form1 : Form
    {

        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Entrada
            double qtde = double.Parse(txtQtd.Text);
            double Valor = double.Parse(txtVal.Text);
            //processamento
            total += qtde * Valor;
            //saida
            lblTotal.Text = total.ToString("C");

            //insere produtos na list box
            listView1.Items.Add(txtProduto.Text + " / " + txtQtd.Text + " / " + Valor.ToString("C"));
            //Limpa as caixas para inserir um produto novo
            txtProduto.Clear();
            txtQtd.Clear();
            txtVal.Clear();
            txtProduto.Focus();
  
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQtd.Clear();
            txtVal.Clear();
            listView1.Clear();
        }


    }
}
