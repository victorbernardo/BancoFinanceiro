namespace clientes
{
    partial class FormAlterarEmprestimo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbValorParcela = new System.Windows.Forms.Label();
            this.lbQtdParcela = new System.Windows.Forms.Label();
            this.lbTaxaJuros = new System.Windows.Forms.Label();
            this.lbValorEmprestimo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSalvarAlteracao = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaxaJuro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbQtdParcela = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbValorParcela);
            this.groupBox1.Controls.Add(this.lbQtdParcela);
            this.groupBox1.Controls.Add(this.lbTaxaJuros);
            this.groupBox1.Controls.Add(this.lbValorEmprestimo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(388, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 208);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulação";
            // 
            // lbValorParcela
            // 
            this.lbValorParcela.AutoSize = true;
            this.lbValorParcela.Location = new System.Drawing.Point(162, 151);
            this.lbValorParcela.Name = "lbValorParcela";
            this.lbValorParcela.Size = new System.Drawing.Size(46, 13);
            this.lbValorParcela.TabIndex = 24;
            this.lbValorParcela.Text = "RS 0,00";
            // 
            // lbQtdParcela
            // 
            this.lbQtdParcela.AutoSize = true;
            this.lbQtdParcela.Location = new System.Drawing.Point(162, 112);
            this.lbQtdParcela.Name = "lbQtdParcela";
            this.lbQtdParcela.Size = new System.Drawing.Size(13, 13);
            this.lbQtdParcela.TabIndex = 23;
            this.lbQtdParcela.Text = "0";
            // 
            // lbTaxaJuros
            // 
            this.lbTaxaJuros.AutoSize = true;
            this.lbTaxaJuros.Location = new System.Drawing.Point(162, 69);
            this.lbTaxaJuros.Name = "lbTaxaJuros";
            this.lbTaxaJuros.Size = new System.Drawing.Size(13, 13);
            this.lbTaxaJuros.TabIndex = 22;
            this.lbTaxaJuros.Text = "0";
            // 
            // lbValorEmprestimo
            // 
            this.lbValorEmprestimo.AutoSize = true;
            this.lbValorEmprestimo.Location = new System.Drawing.Point(162, 33);
            this.lbValorEmprestimo.Name = "lbValorEmprestimo";
            this.lbValorEmprestimo.Size = new System.Drawing.Size(46, 13);
            this.lbValorEmprestimo.TabIndex = 21;
            this.lbValorEmprestimo.Text = "RS 0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Taxa de Juro %:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Valor da Parcela:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor do Emprestimo Bruto: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quantidade  de Parcela:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(14, 196);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 37;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSalvarAlteracao
            // 
            this.btSalvarAlteracao.Location = new System.Drawing.Point(288, 196);
            this.btSalvarAlteracao.Name = "btSalvarAlteracao";
            this.btSalvarAlteracao.Size = new System.Drawing.Size(94, 23);
            this.btSalvarAlteracao.TabIndex = 36;
            this.btSalvarAlteracao.Text = "Salvar Alteração";
            this.btSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btSalvarAlteracao.Click += new System.EventHandler(this.btSalvarAlteracao_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(207, 196);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 35;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(267, 80);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(96, 20);
            this.txtStatus.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Status:";
            // 
            // txtTaxaJuro
            // 
            this.txtTaxaJuro.Location = new System.Drawing.Point(182, 120);
            this.txtTaxaJuro.Name = "txtTaxaJuro";
            this.txtTaxaJuro.Size = new System.Drawing.Size(72, 20);
            this.txtTaxaJuro.TabIndex = 32;
            this.txtTaxaJuro.Text = "2,5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Taxa de Juro %:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(14, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome:";
            // 
            // cbQtdParcela
            // 
            this.cbQtdParcela.FormattingEnabled = true;
            this.cbQtdParcela.Location = new System.Drawing.Point(14, 160);
            this.cbQtdParcela.Name = "cbQtdParcela";
            this.cbQtdParcela.Size = new System.Drawing.Size(52, 21);
            this.cbQtdParcela.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantidade  de Parcela:";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Enabled = false;
            this.txtNumeroConta.Location = new System.Drawing.Point(14, 41);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(159, 20);
            this.txtNumeroConta.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Numero da Conta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Valor do Emprestimo:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(14, 120);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(159, 20);
            this.txtValor.TabIndex = 26;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(179, 39);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 39;
            this.btPesquisar.Text = "Pesquisar...";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // FormAlterarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 231);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btSalvarAlteracao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTaxaJuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbQtdParcela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Name = "FormAlterarEmprestimo";
            this.Text = "FormAlterarEmprestimo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbValorParcela;
        private System.Windows.Forms.Label lbQtdParcela;
        private System.Windows.Forms.Label lbTaxaJuros;
        private System.Windows.Forms.Label lbValorEmprestimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSalvarAlteracao;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaxaJuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbQtdParcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btPesquisar;
    }
}