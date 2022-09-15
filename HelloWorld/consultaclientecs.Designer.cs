
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
            this.btnconsulta = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(12, 384);
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
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 62);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowTemplate.Height = 25;
            this.dgvConsulta.Size = new System.Drawing.Size(733, 316);
            this.dgvConsulta.TabIndex = 3;
            // 
            // consultaclientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 439);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnconsulta);
            this.Name = "consultaclientecs";
            this.Text = "consultaclientecs";
            this.Load += new System.EventHandler(this.consultaclientecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}