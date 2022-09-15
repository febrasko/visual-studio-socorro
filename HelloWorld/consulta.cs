using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//usando o pacote MySql
using MySql.Data.MySqlClient;

namespace HelloWorld
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexao = @"Server=localhost;Database=aula1409;Uid=root;Pwd='etec'";
            MySqlConnection msConnection = new MySqlConnection(conexao);

            //abrindo o banco de dados
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "select * from teste";
            msCommand.Connection = msConnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);
            
            dgvConsulta.DataSource = dt;
        }
    }
}