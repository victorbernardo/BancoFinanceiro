using Biblioteca.basica;
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
    public partial class FormPesquisaConta : Form
    {
        private List<Conta> contas = new List<Conta>();
        public FormPesquisaConta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta() {NumeroConta = 12345,Saldo = 10};
            Conta conta2 = new Conta() { NumeroConta = 22222, Saldo = 20 };

            contas.Add(conta1);
            contas.Add(conta2);
            dgvContas.AutoGenerateColumns = false;
            dgvContas.DataSource = contas;


            
        }
    }
}
