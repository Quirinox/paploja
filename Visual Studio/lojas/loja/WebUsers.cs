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
    public partial class WebUsers : Form
    {
        ClassLigaBD bd = new ClassLigaBD();
        string query;
        MySqlDataReader Ident;
        int[] qt;
        public WebUsers()
        {
            InitializeComponent();
            bd.LigarBDUsers();
            qt = new int[5];
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void webUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adicionaStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new addStock();
            myForm.Show();
        }

        private void WebUsers_Load(object sender, EventArgs e)
        {
            query = "  Select nome from users ORDER BY id DESC";
            
            Ident = bd.ExecutaSelect(query);
            int i = 0;
          
                while (Ident.Read())
                {

                i++;
                
                    n1.Text += Ident.GetString("nome")+"\n";
                
                    if (i == 5)
                        break;

                }
            Ident.Close();

            query = "  Select email from users ORDER BY id DESC";

            Ident = bd.ExecutaSelect(query);
            int x = 0;

            while (Ident.Read())
            {

                x++;

                e1.Text += "\n" + Ident.GetString("email");

                if (x == 5)
                    break;

            }

        }
    }
}
