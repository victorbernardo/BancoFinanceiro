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
using clientes.ServiceReference1;

namespace clientes
{
    public partial class FormPesquisaConta : Form
    {
        private List<Conta> contas;
        private Conta conta;

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
            if(txtNumeroConta.Text.Equals(""))
                carregaGridConta();
            else
            {
                int numeroConta = Int32.Parse(txtNumeroConta.Text);
                this.CarregaGridPorNumerConta(numeroConta);
            }
                 
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
            Service1Client sv = new Service1Client();
            contas = sv.PesquisaConta().ToList();
            dgvContas.AutoGenerateColumns = false;
            dgvContas.DataSource = contas;
           
        }      
        public Conta RetornaContaSelecionado()
        {
            Conta conta = dgvContas.CurrentRow != null ? contas.Find(c => c.NumeroConta.Equals(dgvContas.CurrentRow.Cells[0].Value)) : null;
            return conta;
        }
        private void CarregaGridPorNumerConta(int numeroConta)
        {
            contas = new List<Conta>();
            Service1Client sv = new Service1Client();
            contas.Add(sv.PesquisaContaPorNumeroConta(numeroConta));    
            dgvContas.AutoGenerateColumns = false;
            dgvContas.DataSource = contas;
        }
    }
}
