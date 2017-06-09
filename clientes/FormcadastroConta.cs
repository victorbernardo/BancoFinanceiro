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
using Microsoft.VisualBasic;

namespace clientes
{
    public partial class FormcadastroConta : Form
    {
        private Cliente cliente;
        private Agencia agencia;
        private Conta conta;
        private Service1Client sv;
        //CONSTRUTOR PADRAO
        public FormcadastroConta()
        {
            InitializeComponent();
            cliente = new Cliente();
            agencia = new Agencia();
            conta = new Conta();
            sv = new Service1Client();
        }
           
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesquisaCliente fPesquisaCliente = new FormPesquisaCliente();
                fPesquisaCliente.ShowDialog();
                if(fPesquisaCliente.RetornaClienteSelecionado() == null)
                    MessageBox.Show("Voce nao selecionou nenhum cliente ou nao existe cliente cadastrado");
                else
                {
                    cliente = fPesquisaCliente.RetornaClienteSelecionado();
                    carregaCampoCliente(cliente);
                }
                               
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
                if (fPesquisaAgencia.RetornaAgenciaSelecionado() == null)
                    MessageBox.Show("Voce nao selecionou nenhuma agencia ou nao existe agencia cadastrada");
                else
                {
                    agencia = fPesquisaAgencia.RetornaAgenciaSelecionado();
                    carregaCampoAgencia(agencia);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBuscarConta_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesquisaConta fPesquisaConta = new FormPesquisaConta();
                fPesquisaConta.ShowDialog();
                if (fPesquisaConta.RetornaContaSelecionado() == null)
                    MessageBox.Show("Voce nao selecionou nenhuma conta ou nao existe conta cadastrada");
                else
                {
                    conta = fPesquisaConta.RetornaContaSelecionado();
                    carregaCampoConta(conta);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text.Equals("") || txtEmail.Text.Equals("") || txtCpf.Text.Equals("") || txtEndereco.Text.Equals("") || txtNumeroAgencia.Text.Equals("") || txtNomeAgencia.Text.Equals("") || txtEnderecoAgencia.Text.Equals(""))
                MessageBox.Show("Voce nao pode criar um conta com Cliente e Agencia vazios");
            else if (txtNumeroConta.Text.Equals("") || txtSaldo.Text.Equals(""))
                MessageBox.Show("Voce deve preencher todos os campos");
            else if (!Information.IsNumeric(txtNumeroConta.Text) || !Information.IsNumeric(txtSaldo.Text))
                MessageBox.Show("Voce só deve informar numeros");
            else if (Convert.ToDecimal(txtSaldo.Text) <= 0)
                MessageBox.Show("Voce nao pode criar uma conta com saldo R$ 0,00");
            else if(Information.IsNumeric(txtNumeroConta.Text))            
                if(txtNumeroConta.Text.Length < 6 || txtNumeroConta.Text.Length > 6)
                    MessageBox.Show("Sua conta tem que ter 6 digitos");            
            else
            {
                Agencia agen = new Agencia();
                Cliente clie = new Cliente();
                conta.NumeroConta = Convert.ToInt32(txtNumeroConta.Text.Trim());
                conta.Saldo = Convert.ToDecimal(txtSaldo.Text.Trim());
                conta.DataCriacao = DateTime.Today;
                agen.NumeroAgencia = Convert.ToInt32(txtNumeroAgencia.Text.Trim());
                clie.IdCliente = cliente.IdCliente;
                conta.Agencia = agen;
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
        private void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                sv.RemoverConta(conta);
                MessageBox.Show("Removida com sucesso");
                this.LimparCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      
        private void btAlterar_Click(object sender, EventArgs e)
        {
            conta.Saldo = Convert.ToDecimal(txtSaldo.Text);
            sv.AlterarConta(conta);
            MessageBox.Show("Alterado com sucesso");
            this.LimparCampo();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }              
        //
        //FUNÇOES INTERNAS
        //               
        private void carregaCampoCliente(Cliente cliente)
        {
            txtNomeCliente.Text = cliente.Nome;
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
            txtNumeroConta.Enabled = false;
            txtSaldo.Text = Convert.ToString(conta.Saldo);
            carregaCampoAgencia(conta.Agencia);
            carregaCampoCliente(conta.Cliente);

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
            txtNumeroConta.Enabled = true;

        }  
    }
}
