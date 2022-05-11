using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//Imports para conexão do Banco de Dados
using MySql.Data.MySqlClient;//Imports para realizar comandos no Banco de Dados
using System.Windows.Forms;


namespace Gestão_Financeira.DAO1
{
    class Gastos

    {
        MySqlConnection conexao;
        public string resultado;
        public int[] codigo;
        public string[] produto;
        public double[] valor;
        public string[] categoria;
        public string dados;
        public string[] salvar;


        public int i;
        public string msg;
        public int contador = 0;

        public Gastos()
        {

            conexao = new MySqlConnection("server=localhost;DataBase=controleGasto;Uid=root;Password=;");
            try
            {
                conexao.Open();
                Console.WriteLine("Sistema de Compras Online");
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu Errado em Compras!\n\n" + e);
                conexao.Close();
            }

        }


        public void InserirGastos(string produto, double valor, string categoria)
        {
            try
            {
                dados = "('" + produto + "', '" + valor + "', '" + categoria + "')";
                resultado = "Insert into Gastos(produto, valor, categoria) values" + dados;
                MySqlCommand sql = new MySqlCommand(resultado, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + "Linha(s) Afetada(s)!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo Deu Errado!\n\n" + e);
            }

        }

        public void PreencherVetorGastos()
        {
            string query = "select * from gastos";

            codigo = new int[100];
            valor = new double[100];
            produto = new string[100];
            categoria = new string[100];

            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;    
                valor[i] = 0;
                produto[i] = "";
                categoria[i] = "";

            }


            MySqlCommand coletar = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                codigo[i] = (int)Convert.ToInt64(leitura["codigo"]);
                categoria[i] = leitura["categoria"] + "";
                produto[i] = leitura["produto"] + "";
                valor[i] = Convert.ToDouble(leitura["valor"]);
                i++;
                contador++;
            }
            leitura.Close();
        }

        public string ConsultarTodosOsGastos()
        {

            PreencherVetorGastos();
            msg = "";
            for (int i = 0; i < contador; i++)
            {
                msg += "\n\nCódigo: " + codigo[i]
                    + " Produto: " + produto[i]
                    + " Categoria: " + categoria[i]
                    + " Valor: " + valor[i] + " R$";
            }
            return msg;
        }
    }//fim da classe
}//fim do projeto
