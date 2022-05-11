using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Financeira.FORMS
{
    public partial class MenuGastos : Form
    {
        DAO1.Gastos daogastos;
        public MenuGastos()
        {
            InitializeComponent();

            daogastos = new DAO1.Gastos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }// Botão Sair

        private void Salvar_Click(object sender, EventArgs e)
        {

            string produto = txtProduto.Text;
            double valor = Convert.ToDouble(txtValor.Text);
            string categoria = txtCategoria.Text;

            daogastos.InserirGastos(produto, valor, categoria);
        }//Botão Salvar

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuGastos_Load(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do progeto
