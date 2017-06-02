using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importaçao de pacotes;
using clientes.localhost1;

namespace clientes
{
    public partial class FormPesquisaConta : Form
    {
        private List<Conta> contas;

        //CONSTRUTOR PADRAO
        public FormPesquisaConta()
        {
            InitializeComponent();
        }
        //
        //FUNÇOES DOS BOTOES
        //
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridConta();
                 
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //FUNÇOES INTERNAS
        //                 
        private void carregaGridConta()
        {
            contas = new List<Conta>();
            Service1 sv = new Service1();

            contas = sv.PesquisaConta().ToList();
            dgvContas.AutoGenerateColumns = false;
            dgvContas.DataSource = contas;
        }      
        public Conta RetornaContaSelecionado()
        {
            Conta conta = dgvContas.CurrentRow != null ? contas.Find(c => c.NumeroConta.Equals(dgvContas.CurrentRow.Cells[1].Value)) : null;
            return conta;
        }
    }
}
