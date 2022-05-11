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
    public partial class Listagem : Form
    {
        DAO1.Gastos daoGastos;
        public Listagem()
        {
            InitializeComponent();
            daoGastos = new DAO1.Gastos();
        }

        private void lblLista_Click(object sender, EventArgs e)
        {
            lblLista.Text = daoGastos.ConsultarTodosOsGastos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMostar_Click(object sender, EventArgs e)
        {
            lblLista.Text = daoGastos.ConsultarTodosOsGastos();
        }


    }//fim da classe
}//fim do projeto
