using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja
{
    public partial class Fatura : Form
    {
        string nif, valor, tipo;
        public Fatura()
        {
            InitializeComponent();
        }

        public string Nif { get => nif; set => nif = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Nif;
            label5.Text = Valor;
            label6.Text = Tipo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
