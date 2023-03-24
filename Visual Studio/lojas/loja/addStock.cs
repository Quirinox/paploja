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
    public partial class addStock : Form
    {
        ClassLigaBD bd = new ClassLigaBD();
        MySqlDataReader stock;
        string query, update1, update2, update3, update4, update5, update6;
        int quantidade;
        int error = 0;
        public addStock()
        {
            InitializeComponent();
            bd.LigarBDloja();
        }

        private void adicionaStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new addStock();
            myForm.Show();
        }

        private void webUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new WebUsers();
            myForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new VerStock();
            myForm.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            var myForm = new Venda();
            myForm.Show();
        }

        private void levantamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void sairDaAPlicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt1.Text != null)

            {

                query = "Select quantidade from produto where idproduto = 1";
                stock = bd.ExecutaSelect(query);
                if (stock.HasRows)
                {
                    while (stock.Read())
                    {
                        quantidade = stock.GetInt32(0) + Int32.Parse(txt1.Text);

                    }
                    stock.Close();
                }

                query = " UPDATE produto SET quantidade = " + quantidade + " WHERE idproduto = 1";
                update1 = bd.ExecuteOperacao(query) + "[Galo]";

                if (update1.Contains("erro"))
                {
                    MessageBox.Show("Impossivel fazer o Insert na tabela Galo");
                }
                else
                {
                    error = error + 1;
                }

                quantidade = 0;

            }
            
            if (txt2.Text != null)
            {
                query = "Select quantidade from produto where idproduto = 2";
                stock = bd.ExecutaSelect(query);
                if (stock.HasRows)
                {
                    while (stock.Read())
                    {
                        quantidade = stock.GetInt32(0) + Int32.Parse(txt2.Text);

                    }
                    stock.Close();
                }

                query = " UPDATE produto SET quantidade = " + quantidade + " WHERE idproduto = 2";
                update2 = bd.ExecuteOperacao(query) + "[Vinho]";

                if (update2.Contains("erro"))
                    {
                    MessageBox.Show("Impossivel fazer o Insert na tabela Vinho");
                }
                  else
                {
                    error = error + 1;


                }
                quantidade = 0;
            }
           
            if (txt3.Text != null)
            {
                query = "Select quantidade from produto where idproduto = 3";
                stock = bd.ExecutaSelect(query);
                if (stock.HasRows)
                {
                    while (stock.Read())
                    {
                        quantidade = stock.GetInt32(0) + Int32.Parse(txt3.Text);

                    }
                    stock.Close();
                }

                query = " UPDATE produto SET quantidade = " + quantidade + " WHERE idproduto = 3";
                update3 = bd.ExecuteOperacao(query) + "[Adulfo]";

                if (update3.Contains("erro"))
                {
                    MessageBox.Show("Impossivel fazer o Insert na tabela Adulfo");
                }
                else
                {
                    error = error + 1;
                }

                quantidade = 0;

            }
            
            if (txt4.Text != null)
            {
                query = "Select quantidade from produto where idproduto = 4";
                stock = bd.ExecutaSelect(query);
                if (stock.HasRows)
                {
                    while (stock.Read())
                    {
                        quantidade = stock.GetInt32(0) + Int32.Parse(txt4.Text);

                    }
                    stock.Close();
                }

                query = " UPDATE produto SET quantidade = " + quantidade + " WHERE idproduto = 4";
                update4 = bd.ExecuteOperacao(query) + "[Licor]";
                if (update4.Contains("erro"))
                {
                    MessageBox.Show("Impossivel fazer o Insert na tabela Licor");
                }
                else
                {
                    error = error + 1;
                }

                quantidade = 0;
            }
           
            if (txt5.Text != null)
            {
                query = "Select quantidade from produto where idproduto = 5";
                stock = bd.ExecutaSelect(query);
                if (stock.HasRows)
                {
                    while (stock.Read())
                    {
                        quantidade = stock.GetInt32(0) + Int32.Parse(txt5.Text);

                    }
                    stock.Close();
                }

                query = " UPDATE produto SET quantidade = " + quantidade + " WHERE idproduto = 5";
                update5 = bd.ExecuteOperacao(query) + "[Cascol]";
                if (update5.Contains("erro"))
                {
                    MessageBox.Show("Impossivel fazer o Insert na tabela Cascol");
                }
                else
                {
                    error = error + 1;
                }

                quantidade = 0;

            }
           
            if (txt6.Text != null)
            {
                query = "Select quantidade from produto where idproduto = 6";
                stock = bd.ExecutaSelect(query);
                if (stock.HasRows)
                    //{
                    while (stock.Read())
                    {
                        quantidade = stock.GetInt32(0) + Int32.Parse(txt6.Text);

                    }
                stock.Close();

            }

            query = " UPDATE produto SET quantidade = " + quantidade + " WHERE idproduto = 6";
            update6 = bd.ExecuteOperacao(query) + "[queijo]";
            if (update6.Contains("erro"))
            {
                MessageBox.Show("Impossivel fazer o Insert na tabela Queijo");
            }
            else
            {
                error = error + 1;
            }

            quantidade = 0;

            if (error != 0)
            {
                MessageBox.Show("Todos os dados inseridos com sucesso!!");

            }
        }
     


        private void addStock_Load(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txt4.Text = "0";
            txt5.Text = "0";
            txt6.Text = "0";
        }
    }
        }
    

