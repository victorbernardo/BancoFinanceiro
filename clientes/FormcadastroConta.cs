using clientes.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importaçaco de pacotes

namespace clientes
{
    public partial class FormcadastroConta : Form
    {
        private Cliente cliente;
        private Agencia agencia;
        private Conta conta;
        //CONSTRUTOR PADRAO
        public FormcadastroConta()
        {
            InitializeComponent();
            cliente = new Cliente();
            agencia = new Agencia();
            conta = new Conta();
        }
        //
        //FUNÇOES DOS BOTÕES
        //         
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesquisaCliente fPesquisaCliente = new FormPesquisaCliente();
                fPesquisaCliente.ShowDialog();

                cliente = fPesquisaCliente.RetornaClienteSelecionado();                
                carregaCampoCliente(cliente);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        private void btnBuscarAgencia_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesquisaAgencia fPesquisaAgencia = new FormPesquisaAgencia();
                fPesquisaAgencia.ShowDialog();

                agencia = fPesquisaAgencia.RetornaAgenciaSelecionado();
                carregaCampoAgencia(agencia);
            }
            catch (Exception ex)
            {
                throw new Exception("Agencia nao selecionada " + ex.Message);
            }
        }
        private void btnBuscarConta_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesquisaConta fPesquisaConta = new FormPesquisaConta();
                fPesquisaConta.ShowDialog();

                conta = fPesquisaConta.RetornaContaSelecionado();
                carregaCampoConta(conta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            Agencia agen = new Agencia();
            Cliente clie = new Cliente();
            Service1Client sv = new Service1Client();
            if (txtNumeroConta.Text == " ")
                MessageBox.Show("Voce deve informar o numero da conta");
            if (conta.Saldo < 0)
                MessageBox.Show("Voce nao pode criar uma conta com saldo R$ 0,00");
            else
            {
                conta.NumeroConta = Convert.ToInt32(txtNumeroConta.Text.Trim());
                conta.Saldo = Convert.ToDecimal(txtSaldo.Text.Trim());
                conta.DataCriacao = DateTime.Today;
                agen.NumeroAgencia = Convert.ToInt32(txtNumeroAgencia.Text.Trim());
                clie.IdCliente = cliente.IdCliente;
                conta.Numero_agencia = agen;
                conta.Cliente = clie;
                try
                {
                    sv.SalvarConta(conta);
                    MessageBox.Show("Cadastrado com sucesso");
                    this.LimparCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }
        //
        //FUNÇOES INTERNAS
        //               
        private void carregaCampoCliente(Cliente cliente)
        {
            txtNomeCliente.Text =cliente.Nome;
            txtEmail.Text = cliente.Email ?? "";
            txtCpf.Text = cliente.Cpf ?? "";
            txtEndereco.Text = cliente.Endereco.Rua ?? "";
        }
        private void carregaCampoAgencia(Agencia agencia)
        {
            txtNomeAgencia.Text = agencia.Nome??"";
            txtNumeroAgencia.Text = Convert.ToString(agencia.NumeroAgencia);
            txtEnderecoAgencia.Text = agencia.Endereco.Rua ?? "";        
        }
        private void carregaCampoConta(Conta conta)
        {
            txtNumeroConta.Text = conta.NumeroConta.ToString();
            txtSaldo.Text = Convert.ToString(conta.Saldo);
            //carregaCampoAgencia(conta.Numero_agencia);
            //carregaCampoCliente(conta.Cliente);
        }
        private void LimparCampo()
        {
            txtNomeCliente.Text = ("");
            txtEmail.Text = ("");
            txtCpf.Text = ("");
            txtEndereco.Text = ("");
            txtNomeAgencia.Text = ("");
            txtNumeroAgencia.Text = ("");
            txtEnderecoAgencia.Text = ("");
            txtNumeroConta.Text = ("");
            txtSaldo.Text = ("");
        }
    }
}
