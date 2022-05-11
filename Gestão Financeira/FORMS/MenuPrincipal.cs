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
    public partial class MenuPrincipal : Form
    {
        MenuGastos menuGastos;
        Listagem visualizar;
        public MenuPrincipal()
        {
            InitializeComponent();
            menuGastos = new MenuGastos();
            visualizar = new Listagem();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

     
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }//botão sair

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            visualizar.ShowDialog();

        }//botão visualizar

        private void btnInserir_Click(object sender, EventArgs e)
        {
            menuGastos.ShowDialog();

        }//botão inserir
    }//fim da classe
}//fim do projeto
