namespace clientes
{
    partial class FormPesquisaEmprestimo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.NumeroConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuatidadeParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btListarTodosEmprestimos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero da Conta:";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(12, 30);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(134, 20);
            this.txtNumeroConta.TabIndex = 1;
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(156, 27);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btPesquisa.TabIndex = 2;
            this.btPesquisa.Text = "Pesquisar...";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroConta,
            this.ValorEmprestimo,
            this.QuatidadeParcela,
            this.Cliente,
            this.Cpf});
            this.dgvEmprestimo.Location = new System.Drawing.Point(12, 56);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.Size = new System.Drawing.Size(584, 248);
            this.dgvEmprestimo.TabIndex = 3;
            // 
            // NumeroConta
            // 
            this.NumeroConta.HeaderText = "NumeroConta";
            this.NumeroConta.Name = "NumeroConta";
            this.NumeroConta.Width = 110;
            // 
            // ValorEmprestimo
            // 
            this.ValorEmprestimo.HeaderText = "Valor do Emprestimo";
            this.ValorEmprestimo.Name = "ValorEmprestimo";
            this.ValorEmprestimo.Width = 130;
            // 
            // QuatidadeParcela
            // 
            this.QuatidadeParcela.HeaderText = "QuatidadeParcela";
            this.QuatidadeParcela.Name = "QuatidadeParcela";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(440, 310);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(521, 310);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btListarTodosEmprestimos
            // 
            this.btListarTodosEmprestimos.Location = new System.Drawing.Point(237, 27);
            this.btListarTodosEmprestimos.Name = "btListarTodosEmprestimos";
            this.btListarTodosEmprestimos.Size = new System.Drawing.Size(133, 23);
            this.btListarTodosEmprestimos.TabIndex = 6;
            this.btListarTodosEmprestimos.Text = "Listar todos emprestimos";
            this.btListarTodosEmprestimos.UseVisualStyleBackColor = true;
            this.btListarTodosEmprestimos.Click += new System.EventHandler(this.btListarTodosEmprestimos_Click);
            // 
            // FormPesquisaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 341);
            this.Controls.Add(this.btListarTodosEmprestimos);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgvEmprestimo);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.label1);
            this.Name = "FormPesquisaEmprestimo";
            this.Text = "FormPesquisaEmprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btListarTodosEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuatidadeParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
    }
}