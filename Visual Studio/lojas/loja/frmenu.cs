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
    public partial class frmenu : Form
    {
        public frmenu()
        {
            InitializeComponent();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var myForm = new Venda();
            myForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void levantamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairDaAPlicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webusersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new WebUsers();
            myForm.Show();
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new VerStock();
            myForm.Show();
        }

        private void adicionaStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new addStock();
            myForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
