
namespace HelloWorld
{
    partial class Admin
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
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.btnConCliente = new System.Windows.Forms.Button();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Location = new System.Drawing.Point(22, 31);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(157, 23);
            this.btnCadFornecedor.TabIndex = 0;
            this.btnCadFornecedor.Text = "Cadastrar Fornecedor";
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // btnConCliente
            // 
            this.btnConCliente.Location = new System.Drawing.Point(22, 92);
            this.btnConCliente.Name = "btnConCliente";
            this.btnConCliente.Size = new System.Drawing.Size(157, 23);
            this.btnConCliente.TabIndex = 1;
            this.btnConCliente.Text = "Consultar Clientes";
            this.btnConCliente.UseVisualStyleBackColor = true;
            this.btnConCliente.Click += new System.EventHandler(this.btnConCliente_Click);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Location = new System.Drawing.Point(22, 161);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(157, 23);
            this.btnCadFuncionario.TabIndex = 2;
            this.btnCadFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 338);
            this.Controls.Add(this.btnCadFuncionario);
            this.Controls.Add(this.btnConCliente);
            this.Controls.Add(this.btnCadFornecedor);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.Button btnConCliente;
        private System.Windows.Forms.Button btnCadFuncionario;
    }
}