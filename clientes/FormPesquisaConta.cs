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
using Microsoft.VisualBasic;

namespace clientes
{
    public partial class FormPesquisaConta : Form
    {
        private List<Conta> contas;
        private Conta conta;
        private Service1Client sv;

        //CONSTRUTOR PADRAO
        public FormPesquisaConta()
        {
            InitializeComponent();
            conta = new Conta();
            sv = new Service1Client();
        }
        //
        //FUNÇOES DOS BOTOES
        //
        private void btnPesquisarTodasContas_Click(object sender, EventArgs e)
        {
            carregaGridConta();    
        }
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNumeroConta.Text.Equals("") || !Information.IsNumeric(txtNumeroConta.Text))
                MessageBox.Show("Dados invalidos");
            else
            {
                conta.NumeroConta = Int32.Parse(txtNumeroConta.Text);
                try 
	            {
                    CarregaGridPorNumerConta(conta.NumeroConta);                 
	            }
	            catch (Exception ex)
	            {
                    MessageBox.Show(ex.Message);
	            }                         
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
            dgvContas.Rows.Clear();
            contas.ForEach(c => dgvContas.Rows.Add(c.NumeroConta, c.Saldo, c.Cliente.Nome, c.Cliente.Cpf));

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
            //dgvContas.AutoGenerateColumns = false;
            dgvContas.Rows.Clear();
            //dgvContas.DataSource = contas;
            contas.ForEach(c => dgvContas.Rows.Add(c.NumeroConta, c.Saldo, c.Cliente.Nome, c.Cliente.Cpf));
        }
    }
}
