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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtEmail.Text == "" || txtSenha.Text == "" || txtConfsenha.Text == "" || txtNome.Text == "" || txtcpf.Text == "" || txtcep.Text == "" || txtEstado.Text == "" || txtCidade.Text == "" || txtBairro.Text == "" || txtRua.Text == "" || nrTelefone.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
            }
            else
            {
                LOGIN abrirtelalogin = new LOGIN();
                abrirtelalogin.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEU RUIM NA MATRIX");
        }
    }
}
