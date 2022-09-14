using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "" || txtseenha.Text == "")
            {
                MessageBox.Show("SEU ANIMAL DIGITE COISAS EM TODAS AS CAIXAS");
            }
            else if(txtlogin.Text == "admin" && txtseenha.Text == "admin")
            {
                    Admin acessoAdmin = new Admin();
                    acessoAdmin.Show();
            }
            else
            {
                if (txtlogin.Text == "naice" && txtseenha.Text == "123")
                {
                    Paginainicial abrirPaginaInicial = new Paginainicial();
                    abrirPaginaInicial.Show();
                }
                else
                {
                    MessageBox.Show("DEU RUIM");
                }
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastrarCliente abrirCadastro = new CadastrarCliente();
            abrirCadastro.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ISSO É A MATRIX NADA EXISTE SUCUMBA");
        }

        private void txtLogin(object sender, EventArgs e)
        {

        }

        private void txtSenha(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
