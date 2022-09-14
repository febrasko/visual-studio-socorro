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
    public partial class cadastrofuncionario : Form
    {
        public cadastrofuncionario()
        {
            InitializeComponent();
        }
        Util validacao = new Util();
        private void bntcadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtEmail.Text == "" || txtSenha.Text == "" || txtConfsenha.Text == "" || txtNome.Text == "" || txtcpf.Text == "" || txtcep.Text == "" || txtEstado.Text == "" || txtCidade.Text == "" || txtBairro.Text == "" || txtRua.Text == "" || nrTelefone.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
            }
            else if (validacao.validarNumero(txtcep.Text) == false)
            {
                MessageBox.Show("CEP deve conter apenas numeros");
            }
            else if (validacao.validarNumero(txtcep.Text) == false)
            {
                MessageBox.Show("CEP deve conter apenas numeros");
            }
            else if (validacao.validarNumero(txtcep.Text) == false)
            {
                MessageBox.Show("CEP deve conter apenas numeros");
            }
            else if (validacao.validarNumero(txtcep.Text) == false)
            {
                MessageBox.Show("CEP deve conter apenas numeros");
            }
        }
    }
}