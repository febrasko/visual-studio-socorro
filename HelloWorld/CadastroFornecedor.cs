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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        Util validacao = new Util();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEmail.Text == "" || txtCNPJ.Text == "" || txtCEP.Text == "" || nrTelefone.Text == "" || txtEndereco.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if(validacao.isCNPJ(txtCNPJ.Text) == false)
            {
                MessageBox.Show("CNPJ INVÁLIDO");
            }
            else if(validacao.validarNumero(txtCEP.Text)==false)
            {
                MessageBox.Show("CEP deve conter apenas numeros");
            }
            else if (validacao.validarNumero(nrTelefone.Text) == false)
            {
                MessageBox.Show("Telefone deve conter apenas numeros");
            }
        }   
    }
}
