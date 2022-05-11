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
    
    public partial class MenuCadastro : Form
    {
        DAO dao;

        public MenuCadastro()
        {
            
            InitializeComponent();
            dao = new DAO();
        }

        private void btnCadCadastrar_Click(object sender, EventArgs e)
        {
            string email = txtCadLogin.Text;
            string senha = txtCadSenha.Text;
            string nome = txtCadNome.Text;
            double salario = Convert.ToDouble(txtCadSalario.Text);

            
            dao.InserirCadastro(email, senha, nome, salario);

        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void txtCadLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadConfirmSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
