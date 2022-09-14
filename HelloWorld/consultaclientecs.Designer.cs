
namespace HelloWorld
{
    partial class consultaclientecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cdcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsendereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nmusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdcliente,
            this.nrtelefone,
            this.cpfcliente,
            this.emailcliente,
            this.nmcliente,
            this.dsendereco,
            this.nmusuario});
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(748, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cdcliente
            // 
            this.cdcliente.HeaderText = "codigocliente";
            this.cdcliente.Name = "cdcliente";
            // 
            // nrtelefone
            // 
            this.nrtelefone.HeaderText = "telefone";
            this.nrtelefone.Name = "nrtelefone";
            // 
            // cpfcliente
            // 
            this.cpfcliente.HeaderText = "cpf";
            this.cpfcliente.Name = "cpfcliente";
            // 
            // emailcliente
            // 
            this.emailcliente.HeaderText = "email";
            this.emailcliente.Name = "emailcliente";
            // 
            // nmcliente
            // 
            this.nmcliente.HeaderText = "nome do cliente";
            this.nmcliente.Name = "nmcliente";
            // 
            // dsendereco
            // 
            this.dsendereco.HeaderText = "endereço";
            this.dsendereco.Name = "dsendereco";
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(12, 280);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(69, 23);
            this.btnconsulta.TabIndex = 1;
            this.btnconsulta.Text = "Voltar";
            this.btnconsulta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(12, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "codigo cliente";
            // 
            // nmusuario
            // 
            this.nmusuario.HeaderText = "nome de usuario";
            this.nmusuario.Name = "nmusuario";
            // 
            // consultaclientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 439);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnconsulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consultaclientecs";
            this.Text = "consultaclientecs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsendereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmusuario;
    }
}