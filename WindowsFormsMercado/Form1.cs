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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {








            txtProduto.Clear();
            txtQtd.Clear();
            txtVal.Clear();
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
        }
    }
}
