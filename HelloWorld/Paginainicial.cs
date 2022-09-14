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
    public partial class Paginainicial : Form
    {
        public Paginainicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Paginainicial_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LOGIN entrarLogin = new LOGIN();
            entrarLogin.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastrarCliente entrarCadastro = new CadastrarCliente();
            entrarCadastro.Show();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            LIVROS entrarcompra = new LIVROS();
            entrarcompra.Show();
        }
    }
}
