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
using clientes.ServiceReference1;

namespace clientes
{
    public partial class cadastroConta : Form
    {
        private Cliente cliente;
        private Agencia agencia;
        private Conta conta;
        //CONSTRUTOR PADRAO
        public cadastroConta()
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
                throw new Exception("Cliente nao selecionado " + ex.Message);
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
                fPesquisaConta.Show();

                conta = fPesquisaConta.RetornaContaSelecionado();
                carregaCampoConta(conta);
            }
            catch (Exception ex)
            {
                throw new Exception("Conta nao existe" + ex.Message);
            }           
        }
        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            try
            {
                conta = new Conta();              
                Agencia agen = new Agencia();
                Cliente clie = new Cliente();
                Service1Client sv = new Service1Client();
                
                conta.NumeroConta = Convert.ToInt32(txtNumeroConta.Text);
                conta.Saldo = Convert.ToDecimal(txtSaldo.Text);
                conta.DataCriacao = DateTime.Today;
                agen.NumeroAgencia = Convert.ToInt32(txtNumeroAgencia.Text);
                clie.IdCliente = cliente.IdCliente;
                conta.Numero_agencia = agen;
                conta.Cliente = clie;
                sv.SalvarConta(conta);
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        //
        //FUNÇOES INTERNAS
        //               
        private void carregaCampoCliente(Cliente cliente)
        {
            txtNomeCliente.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;
            txtEndereco.Text = cliente.Endereco.Rua;
        }
        private void carregaCampoAgencia(Agencia agencia)
        {
            txtNomeAgencia.Text = agencia.Nome;
            txtNumeroAgencia.Text = agencia.NumeroAgencia.ToString();
            txtEnderecoAgencia.Text = agencia.Endereco.Rua;        
        }
        private void carregaCampoConta(Conta conta)
        {
            txtNumeroConta.Text = conta.NumeroConta.ToString();
            txtSaldo.Text = conta.Saldo.ToString();
        }
    }
}
