using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loja
{
    public partial class VerStock : Form
    {
        ClassLigaBD bd = new ClassLigaBD();
        string query;
        int galo, vinho, licor, adulfo, cascol,queijo;
        MySqlDataReader dadosCliente, dadoscp, dadoscp2;


        private void adicionaStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new addStock();
            myForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new WebUsers();
            myForm.Show();
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new VerStock();
            myForm.Show();
        }

        public VerStock()
        {
           bd = new ClassLigaBD();
            InitializeComponent();
            bd.LigarBDloja();
        }

        private void sairDaAPlicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerStock_Load(object sender, EventArgs e)
        {


                query = "select quantidade from produto where idproduto=1";
            dadoscp = bd.ExecutaSelect(query);
            while (dadoscp.Read())
                label7.Text = dadoscp.GetInt32("quantidade").ToString();

           

            dadoscp.Close();
            query = "select quantidade from produto where idproduto=2";
            dadoscp = bd.ExecutaSelect(query);

            while (dadoscp.Read())
                label8.Text = dadoscp.GetInt32("quantidade").ToString();
                 
          

            dadoscp.Close();
            query = "select quantidade from produto where idproduto=3";
            dadoscp = bd.ExecutaSelect(query);
            while (dadoscp.Read())
                label9.Text = dadoscp.GetInt32("quantidade").ToString();

          
            dadoscp.Close();
            query = "select quantidade from produto where idproduto=4";
            dadoscp = bd.ExecutaSelect(query);
            while (dadoscp.Read())
                label10.Text = dadoscp.GetInt32("quantidade").ToString();

          
            dadoscp.Close();
            query = "select quantidade from produto where idproduto=5";
            dadoscp = bd.ExecutaSelect(query);
            while (dadoscp.Read())
                label11.Text = dadoscp.GetInt32("quantidade").ToString();

           
            dadoscp.Close();
            query = "select quantidade from produto where idproduto=6";
            dadoscp = bd.ExecutaSelect(query);
            while (dadoscp.Read())
                label12.Text = dadoscp.GetInt32("quantidade").ToString();

           
            dadoscp.Close();
             bar1.Value = Int32.Parse(label7.Text);
             bar2.Value = Int32.Parse(label8.Text);
             bar3.Value = Int32.Parse(label9.Text);
             bar4.Value = Int32.Parse(label10.Text);
             bar5.Value = Int32.Parse(label11.Text);
             bar6.Value = Int32.Parse(label12.Text);

            bar1.Enabled = false;
            bar2.Enabled = false;
            bar3.Enabled = false;
            bar4.Enabled = false;
            bar5.Enabled = false;
            bar6.Enabled = false;



        }


    }
}
