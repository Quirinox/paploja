using loja;
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
    public partial class Venda : Form

    {
        ClassLigaBD bd = new ClassLigaBD();
        string query,insert1,insert2,update;
        int[] qt;
        string paypal;
        int error=0;
        Int32 id_cliente;
        MySqlDataReader quant,id;
        public Venda()
        {
            InitializeComponent();
            bd.LigarBDloja();
            qt = new int[6];


        }
      



        private void btn_sub_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (txt1.Text != null || txt2.Text != null || txt3.Text != null || txt4.Text != null || txt5.Text != null || txt6.Text != null)
            {

                query = "Select quantidade from produto ";
                quant = bd.ExecutaSelect(query);
                while (quant.Read())
                {
                    qt[i] = quant.GetInt32(0);
                    i++;


                }
               
                quant.Close();
                //#1 galo
                if (qt[0] < Int32.Parse(txt1.Text))

                {
                    MessageBox.Show("Não existe stock de galos porfavor tente novamente");

                    return;
                }
                if (qt[1] < Int32.Parse(txt2.Text))

                {
                    MessageBox.Show("Não existe stock de galos porfavor tente novamente");

                    return;
                }
                if (qt[2] < Int32.Parse(txt3.Text))

                {
                    MessageBox.Show("Não existe stock de galos porfavor tente novamente");
                    return;
                }
                if (qt[3] < Int32.Parse(txt4.Text))

                {
                    MessageBox.Show("Não existe stock de galos porfavor tente novamente");
                    return;
                }
                if (qt[4] < Int32.Parse(txt5.Text))

                {
                    MessageBox.Show("Não existe stock de galos porfavor tente novamente");
                    return;
                }
                if (qt[5] < Int32.Parse(txt6.Text))

                {
                    MessageBox.Show("Não existe stock de galos porfavor tente novamente");
                    return;
                }




                if (radio1.Checked)

                {
                    paypal = radio1.Text;
                }
                else
                {
                    paypal = radio2.Text;
                }

                query = "INSERT INTO cliente (nif,tlm) VALUES (" + txt7.Text + "," + txt8.Text + ")";
                insert2 = bd.ExecuteOperacao(query);
                if (insert2.Contains("erro"))
                {
                    MessageBox.Show("" + insert2);
                }
                else
                {
                    error = error + 1;
                }

                // select para ver o ultimo auto incremento doneste caso do idcliente
                query = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'cliente'";
                id_cliente = bd.ContarRegistos(query);
               

                //Galo
                if (Int32.Parse(txt1.Text) > 0)
                {
                    query = " UPDATE produto SET quantidade = quantidade -" + Int32.Parse(txt1.Text) + "  WHERE idproduto=1";
                    update = bd.ExecuteOperacao(query);
                    if (update.Contains("erro"))
                    {
                        MessageBox.Show(" " + update);
                    }
                    else
                    {
                        error = error + 1;
                    }
                 
                    query = "INSERT INTO compra (idcliente,idproduto,idfuncionario,tipo_pagamento,valor_carrinho) VALUES ("+(id_cliente-1)+",1,"+txt9.Text+",'" + paypal + "'," + lbl3.Text + ")";
                    insert1 = bd.ExecuteOperacao(query);

                    if (insert1.Contains("erro"))
                    {
                        MessageBox.Show("Impossivel fazer o Insert do Galo tipo de pagamento e valor do carrinho"+insert1);
                    }
                    else
                    {
                        error = error + 1;
                    }


                }
                //Vinho
                if (Int32.Parse(txt2.Text) > 0)
                {
                    query = " UPDATE produto SET quantidade = quantidade -" + Int32.Parse(txt2.Text) + "  WHERE idproduto=2";
                    update = bd.ExecuteOperacao(query);
                    if (update.Contains("erro"))
                    {
                        MessageBox.Show("Impossivel fazer o Update no Vinho ");
                    }
                    else
                    {
                        error = error + 1;
                    }

                    query = "INSERT INTO compra (idcliente,idproduto,idfuncionario,tipo_pagamento,valor_carrinho) VALUES (" + (id_cliente - 1) + ",1," + txt9.Text + ",'" + paypal + "'," + lbl3.Text + ")";
                    insert1 = bd.ExecuteOperacao(query);
                    if (insert1.Contains("erro"))
                    {
                        MessageBox.Show("Impossivel fazer o Insert do Vinho tipo de pagamento e valor do carrinho");
                    }
                    else
                    {
                        error = error + 1;
                    }

                }
                //Adulfo
                if (Int32.Parse(txt3.Text) > 0)
                {

                    query = " UPDATE produto SET quantidade = quantidade -" + Int32.Parse(txt2.Text) + "  WHERE idproduto=2";
                    update = bd.ExecuteOperacao(query);
                    if (update.Contains("erro"))
                    {
                        MessageBox.Show("Impossivel fazer o Update no Adulfo ");
                    }
                    else
                    {
                        error = error + 1;
                    }
                    query = "INSERT INTO compra (idcliente,idproduto,idfuncionario,tipo_pagamento,valor_carrinho) VALUES (" + (id_cliente - 1) + ",1," + txt9.Text + ",'" + paypal + "'," + lbl3.Text + ")";
                    insert1 = bd.ExecuteOperacao(query);
                    if (insert1.Contains("erro"))
                    {
                        MessageBox.Show("Impossivel fazer o Insert do Adulfo tipo de pagamento e valor do carrinho");
                    }
                    else
                    {
                        error = error + 1;
                    }
                    //Licor
                    if (Int32.Parse(txt4.Text) > 0)
                    {




                        query = " UPDATE produto SET quantidade = quantidade -" + Int32.Parse(txt3.Text) + "  WHERE idproduto=3";
                        update = bd.ExecuteOperacao(query);
                        if (update.Contains("erro"))
                        {
                            MessageBox.Show("Impossivel fazer o Update no Licor ");
                        }
                        else
                        {
                            error = error + 1;
                        }
                        query = "INSERT INTO compra (idcliente,idproduto,idfuncionario,tipo_pagamento,valor_carrinho) VALUES (" + (id_cliente - 1) + ",1," + txt9.Text + ",'" + paypal + "'," + lbl3.Text + ")";
                        insert1 = bd.ExecuteOperacao(query);
                        if (insert1.Contains("erro"))
                        {
                            MessageBox.Show("Impossivel fazer o Insert do Licor tipo de pagamento e valor do carrinho");
                        }
                        else
                        {
                            error = error + 1;
                        }
                    }
                    //Cascol
                    if (Int32.Parse(txt5.Text) > 0)
                    {

                        query = " UPDATE produto SET quantidade = quantidade -" + Int32.Parse(txt3.Text) + "  WHERE idproduto=3";
                        update = bd.ExecuteOperacao(query);
                        if (update.Contains("erro"))
                        {
                            MessageBox.Show("Impossivel fazer o Update no Cascol ");
                        }
                        else
                        {
                            error = error + 1;
                        }
                        query = "INSERT INTO compra (idcliente,idproduto,idfuncionario,tipo_pagamento,valor_carrinho) VALUES (" + (id_cliente - 1) + ",1," + txt9.Text + ",'" + paypal + "'," + lbl3.Text + ")";
                        insert1 = bd.ExecuteOperacao(query);
                        if (insert1.Contains("erro"))
                        {
                            MessageBox.Show("Impossivel fazer o Insert do Cascol tipo de pagamento e valor do carrinho");
                        }
                        else
                        {
                            error = error + 1;
                        }
                    }


                    //Queijo
                    if (Int32.Parse(txt6.Text) > 0)
                    {


                        query = " UPDATE produto SET quantidade = quantidade -" + Int32.Parse(txt4.Text) + "  WHERE idproduto=4";
                        update = bd.ExecuteOperacao(query);
                        if (update.Contains("erro"))
                        {
                            MessageBox.Show("Impossivel fazer o Update no Queijo ");
                        }
                        else
                        {
                            error = error + 1;
                        }
                        query = "INSERT INTO compra (idcliente,idproduto,idfuncionario,tipo_pagamento,valor_carrinho) VALUES (" + (id_cliente - 1) + ",1," + txt9.Text + ",'" + paypal + "'," + lbl3.Text + ")";
                        insert1 = bd.ExecuteOperacao(query);
                        if (insert1.Contains("erro"))
                        {
                            MessageBox.Show("Impossivel fazer o Insert do  Queijo tipo de pagamento e valor do carrinho");
                        }
                        else
                        {
                            error = error + 1;
                        }
                    }
                }

                if (error != 0)
                {
                    MessageBox.Show("Todos os dados inseridos com sucesso!!");
                    var myForm = new Fatura();
                    myForm.Nif = txt7.Text;
                    myForm.Tipo = paypal;
                    myForm.Valor = lbl3.Text;


                    myForm.Show();
                }
            }
        }
    

        private void sairDaAPlicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new VerStock();
            myForm.Show();
        }

        private void webUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new WebUsers();
            myForm.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int galo_price, vinho_price, licor_price, adulfo_price, cascol_price, queijo_price, total,total1,total2,total3,total4,total5,total6;
            galo_price = 4;
            vinho_price = 5;
            licor_price = 5;
            adulfo_price = 5;
            cascol_price = 8;
            queijo_price = 5;
            total = 0;
            total1 = 0;
            total2 = 0;
            total3 = 0;
            total4 = 0;
            total5 = 0;
            total6 = 0;
          //  if (txt1.Text = null || txt2.Text = null )
           
            if (txt1.Text != null)

            {
                
              total1 = Int32.Parse(txt1.Text) * galo_price;
            }
            if (txt2.Text != null)
            {
                total2 = Int32.Parse(txt2.Text) * vinho_price;
            }
            if (txt3.Text != null)
            {
                total3 = Int32.Parse(txt3.Text) * licor_price;
            }
            if (txt4.Text != null)
            {
                total4 = Int32.Parse(txt4.Text) * adulfo_price;

                if (txt5.Text != null)
                {
                    total5 = Int32.Parse(txt5.Text) * cascol_price;
                }
                if (txt6.Text != null)
                {
                    total6 = Int32.Parse(txt6.Text) * queijo_price;
                }
                total = total1 + total2 + total3 + total4 + total5 + total6;
                lbl3.Text = total.ToString();
            }

            {
                if (lbl3.Text == "-")
                {
                    btn_sub.Enabled = false;
                }
                else
                {
                    txt7.Enabled = true;
                    txt8.Enabled = true;
                    btn_sub.Enabled = true;
                    txt9.Enabled = true;
                }
            }
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            var myForm = new Venda();
            myForm.Show();
        }

        private void adicionaStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new addStock();
            myForm.Show();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txt4.Text = "0";
            txt5.Text = "0";
            txt6.Text = "0";

            if (lbl3.Text == "-")
            {
                btn_sub.Enabled = false;
                txt7.Enabled = false;
                txt8.Enabled = false;
                txt9.Enabled = false;
            }
            else
            {
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt8.Enabled = true;
                btn_sub.Enabled = true;
            }
        }
    }
}

    


