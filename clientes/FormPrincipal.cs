using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientes
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void cadastrarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormcadastroConta fcadastroConta = new FormcadastroConta();
            fcadastroConta.ShowDialog();
        }

        private void cadastrarEnorestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroEmprestimo fCadastrarEnpretimo = new FormCadastroEmprestimo();
            fCadastrarEnpretimo.ShowDialog();
        }

        private void consultarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaConta fpesquisaConta = new FormPesquisaConta();
            fpesquisaConta.ShowDialog();

        }

        private void consultarEmprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaEmprestimo fPesquisaEmprestimo = new FormPesquisaEmprestimo();
            fPesquisaEmprestimo.ShowDialog();
        }
    }
}
