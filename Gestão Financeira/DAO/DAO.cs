using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//Imports para conexão do Banco de Dados
using MySql.Data.MySqlClient;//Imports para realizar comandos no Banco de Dados
using System.Windows.Forms;

namespace Gestão_Financeira
{
    class DAO
    {
        FORMS.MenuPrincipal menuPrincipal;
        MySqlConnection conexao;
        public string dados;
        public string resultado;

        public string[] nome;
        public string[] email;
        public string[] senha;
        public double[] salario;

        //vetor
        public int i;
        public int contador = 0;

        public DAO()
        {
            menuPrincipal = new FORMS.MenuPrincipal();

            conexao = new MySqlConnection("server=localhost;DataBase=controleGasto;Uid=root;Password=;");
            try
            {
                conexao.Open();
                MessageBox.Show("Sistema Online");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu Errado!\n\n" + e);
                conexao.Close();
            }

        }

        public void InserirCadastro(string email, string senha, string nome, double salario)
        {
            try
            {
                dados = "('" + email + "', '" + senha + "', '" + nome + "', '" + salario + "')";
                resultado = "Insert into cadastro(email, senha, nome, salario) values" + dados;
                MySqlCommand sql = new MySqlCommand(resultado, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + "Linha(s) Afetada(s)!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo Deu Errado!\n\n" + e);
            }

        }

        public void AcessarConta(string emai, string sen)
        {
            PreencherVetor();
            for (int i = 0; i < contador; i++)
            {
                if ((emai == email[i]) && (sen == senha[i]))
                {
                    MessageBox.Show("Bem vindo!");
                    menuPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login e senha incorretos, digite corretamente.");
                }
            }
        }


        public void PreencherVetor()
        {
            string query = "select * from cadastro";

            salario = new double[100];
            nome = new string[100];
            email = new string[100];
            senha = new string[100];

            for (i = 0; i < 100; i++)
            {
                salario[i] = 0;
                nome[i] = "";
                email[i] = "";
                senha[i] = "";
            }

            MySqlCommand coletar = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                salario[i] = (double)Convert.ToDouble(leitura["salario"]);
                nome[i] = leitura["nome"] + "";
                email[i] = leitura["email"] + "";
                senha[i] = leitura["senha"] + "";
                i++;
                contador++;
            }

            leitura.Close();
        }


    }
}
