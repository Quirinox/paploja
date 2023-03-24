using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loja
{
    class ClassLigaBD
    {

        String query;
        String dados;
        MySqlConnection con;
        MySqlDataReader registos;
        MySqlDataAdapter lerRegistos;
        MySqlCommand cmd;
        DataTable tabela;



        public void LigarBDloja()
        {
            dados = "server=localhost;port=	3302; database=loja_db; uid=root; pwd='admin'";
            con = new MySqlConnection(dados);
            try
            {
                con.Open();
            }
            catch (MySqlException erro)
            {
                switch (erro.Number)
                {
                    case 0:
                        MessageBox.Show("Não se consegue ligar á base de dados. Contacte o administrador" + erro.Message);
                        break;


                    case 1045:
                        MessageBox.Show("Utilizador/ password inválido, por favor introduza novamente");
                        break;
                    default:
                        MessageBox.Show(erro.Message);
                        break;

                }
            }
        }
        public void LigarBDUsers()
        {
            dados = "server=localhost;port=	3302; database=registos; uid=root; pwd='admin'";
            con = new MySqlConnection(dados);
            try
            {
                con.Open();
            }
            catch (MySqlException erro)
            {
                switch (erro.Number)
                {
                    case 0:
                        MessageBox.Show("Não se consegue ligar á base de dados. Contacte o administrador" + erro.Message);
                        break;


                    case 1045:
                        MessageBox.Show("Utilizador/ password inválido, por favor introduza novamente");
                        break;
                    default:
                        MessageBox.Show(erro.Message);
                        break;

                }
            }
        }
        public MySqlDataReader ExecutaSelect(String query)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                cmd = new MySqlCommand(query, con);
                registos = cmd.ExecuteReader();
            }
            return registos;
        }

        public String ExecuteOperacao(string query)
        {
            String msg = "";
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    msg = "Operação efetuada com sucesso";
                }
            }
            catch (MySqlException erro)
            {
                msg = "erro" + erro.Message;
            }
            return msg;
        }
        public Int32 ContarRegistos(String query)
        {
            Object o;
            Int32 x = 0;
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    cmd = new MySqlCommand(query, con);
                    o = cmd.ExecuteScalar();
                    x = Convert.ToInt32(o);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            return x;
        }

    }




    }
