namespace clientes
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEnorestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarContaToolStripMenuItem,
            this.cadastrarEnorestimoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarContaToolStripMenuItem
            // 
            this.cadastrarContaToolStripMenuItem.Name = "cadastrarContaToolStripMenuItem";
            this.cadastrarContaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarContaToolStripMenuItem.Text = "Cadastrar Conta";
            this.cadastrarContaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarContaToolStripMenuItem_Click);
            // 
            // cadastrarEnorestimoToolStripMenuItem
            // 
            this.cadastrarEnorestimoToolStripMenuItem.Name = "cadastrarEnorestimoToolStripMenuItem";
            this.cadastrarEnorestimoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarEnorestimoToolStripMenuItem.Text = "Cadastrar Emprestimo";
            this.cadastrarEnorestimoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEnorestimoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarContaToolStripMenuItem,
            this.consultarEmprestimoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultarContaToolStripMenuItem
            // 
            this.consultarContaToolStripMenuItem.Name = "consultarContaToolStripMenuItem";
            this.consultarContaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultarContaToolStripMenuItem.Text = "Consultar Conta";
            this.consultarContaToolStripMenuItem.Click += new System.EventHandler(this.consultarContaToolStripMenuItem_Click);
            // 
            // consultarEmprestimoToolStripMenuItem
            // 
            this.consultarEmprestimoToolStripMenuItem.Name = "consultarEmprestimoToolStripMenuItem";
            this.consultarEmprestimoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultarEmprestimoToolStripMenuItem.Text = "Consultar Emprestimo";
            this.consultarEmprestimoToolStripMenuItem.Click += new System.EventHandler(this.consultarEmprestimoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 504);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEnorestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmprestimoToolStripMenuItem;
    }
}