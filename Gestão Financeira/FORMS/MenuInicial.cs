using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Financeira
{
    public partial class Form1 : Form
    {
        MenuCadastro menuCad;
        DAO dao;

        public Form1()
        {
            InitializeComponent();

            menuCad = new MenuCadastro();
            dao = new DAO();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text;
            string senha = txtSenha.Text;

            dao.AcessarConta(email, senha);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
            menuCad.ShowDialog();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
