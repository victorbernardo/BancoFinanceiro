using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clientes.ServiceReference1;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace clientes
{
    public partial class FormCadastroEmprestimo : Form
    {
        private Emprestimo emprestimo;
        private Conta conta;
        private Service1Client sv;
        private string caminho = AppDomain.CurrentDomain.BaseDirectory.ToString()+"\\Emprestimo.xml";
        public FormCadastroEmprestimo()
        {
            InitializeComponent();
            for (int i = 1; i <= 36; i++)
            {
                cbQtdParcela.Items.Add(i);
            }
            this.CriarArquivo();
            this.CarregaArquivoXml();
                   
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }

        private void btPesquisaConta_Click(object sender, EventArgs e)
        {
            this.PesquisaConta(); 
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            this.Simulacao();
            this.NovaLinha();
        }


        //
        //FUNÇOES INTERNAS
        //
        private void CarregaCampoConta(Conta conta)
        {
            txtNumeroConta.Text = conta.NumeroConta.ToString();
            txtNome.Text = conta.Cliente.Nome;
        }
        private void PesquisaConta()
        {
            FormPesquisaConta fPesquisaConta = new FormPesquisaConta();
            fPesquisaConta.ShowDialog();

            if (fPesquisaConta.RetornaContaSelecionado() == null)
                MessageBox.Show("Voce nao selecionou nenhuma conta ou nao existe conta cadastrada");
            else
            {
                conta = fPesquisaConta.RetornaContaSelecionado();
                CarregaCampoConta(conta);
            }
        }
        private void Salvar()
        {
            if(txtNumeroConta.Text.Equals("") || txtNome.Text.Equals("") || txtValor.Text.Equals("") || cbQtdParcela.Text.Equals(""))
            {
                MessageBox.Show("Voce deve preencher todos os campos");
            }
            else
            {           
                int qtdParcela = 0;
                foreach (int item in cbQtdParcela.Items)
                {
                    if (item.Equals(cbQtdParcela.SelectedItem))
                    {
                        qtdParcela = item;
                    }
                }
                emprestimo = new Emprestimo();
                conta = new Conta();
                conta.NumeroConta = Int32.Parse(txtNumeroConta.Text);
                emprestimo.NumeroConta = conta;                
                emprestimo.Valor = Decimal.Parse(txtValor.Text);
                emprestimo.TaxaJurosMensal = Decimal.Parse(txtTaxaJuro.Text);
                emprestimo.QuantidadeParcela = qtdParcela;
                emprestimo.DataCriacao = DateTime.Now;

                decimal valordaParcela = (emprestimo.Valor / emprestimo.QuantidadeParcela) * emprestimo.TaxaJurosMensal * 2;

                valordaParcela = valordaParcela + (emprestimo.Valor / emprestimo.QuantidadeParcela);

 


                try
                {
                    sv = new Service1Client();
                    sv.SalvarEmprestimo(emprestimo);
                    MessageBox.Show("Empresto realizado com sucesso");
                }
                catch (Exception ex)
                {                    
                    throw new Exception("Erro ao cadastrar emprestimo" + ex.Message);
                }                               
            }            
        }
        private void Simulacao()
        {
            int qtdParcela = 0;
            foreach (int item in cbQtdParcela.Items)
            {
                if (item.Equals(cbQtdParcela.SelectedItem))
                {
                    qtdParcela = item;
                }
            }

            decimal valorEmprestimo = Decimal.Parse(txtValor.Text);
            decimal taxtaJuros = Decimal.Parse(txtTaxaJuro.Text)/100;           
            int parcela = qtdParcela;
            decimal resul = 0;
            resul = (valorEmprestimo / qtdParcela) * taxtaJuros * 2;

            resul = resul + (valorEmprestimo / qtdParcela);


            
            lbValorEmprestimo.Text = txtValor.Text;
            lbTaxaJuros.Text = txtTaxaJuro.Text;          
            lbQtdParcela.Text = qtdParcela.ToString();
            lbValorParcela.Text = String.Format("{0:n2}", resul);
            /*
            txtNome.Text = ("");
            txtNumeroConta.Text = ("");
            txtValor.Text = ("");
            cbQtdParcela.SelectedIndex = -1;
            */
        }
        private void CriarArquivo()
        {
            try
            {
                if (File.Exists(caminho) == false)
                {
                    XmlDocument doc = new XmlDocument();
                    XmlNode raiz = doc.CreateElement("Banco_Financeiro_Emprestimo");
                    doc.AppendChild(raiz);
                    doc.Save(caminho);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NovaLinha()
        {
            try
            {
               
                XmlDocument doc = new XmlDocument();
                doc.Load(caminho);
                
                XmlNode linha = doc.CreateElement("emprestimo");
                XmlNode Nome = doc.CreateElement("nome");
                XmlNode NumeroConta = doc.CreateElement("numeroConta");
                XmlNode Valor = doc.CreateElement("valor");
                XmlNode TaxaJuros = doc.CreateElement("taxaJuros");
                XmlNode QtdParcela = doc.CreateElement("quantidade_parcela");

                int qtdParcela = 0;
                foreach (int item in cbQtdParcela.Items)
                {
                    if (item.Equals(cbQtdParcela.SelectedItem))
                    {
                        qtdParcela = item;
                    }
                }
                
                Nome.InnerText = txtNome.Text;
                NumeroConta.InnerText = txtNumeroConta.Text;
                Valor.InnerText = txtValor.Text;
                TaxaJuros.InnerText = txtTaxaJuro.Text;                
                QtdParcela.InnerText = qtdParcela.ToString();
               
               
                linha.AppendChild(Nome);
                linha.AppendChild(NumeroConta);
                linha.AppendChild(Valor);
                linha.AppendChild(TaxaJuros);
                linha.AppendChild(QtdParcela);
                
                doc.SelectSingleNode("/Banco_Financeiro_Emprestimo").AppendChild(linha);
                doc.Save(caminho);                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CarregaArquivoXml()
        {
            bool retorno = false;
            string nome = "";
            string numeroConta = "";
            string valor = "";
            string qtdParcela = "";

                XmlDocument doc = new XmlDocument();
                if (File.Exists(caminho))
                {
                    doc.Load(caminho);
                    foreach (XmlNode no in doc.DocumentElement.ChildNodes)
                    {
                        if (no.ChildNodes != null)
                        {
                            nome = no.ChildNodes.Item(0).InnerText;
                            numeroConta = no.ChildNodes.Item(1).InnerText;
                            valor = no.ChildNodes.Item(2).InnerText;
                            qtdParcela = no.ChildNodes.Item(4).InnerText;
                            retorno = true;
                        }
                    }
                    if (retorno)
                    {
                        if (MessageBox.Show("Voce tem arquivo pré-carregado, Voce deseja carregar ? ", "Atençao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtNome.Text = nome;
                            txtNumeroConta.Text = numeroConta;
                            txtValor.Text = valor;
                            cbQtdParcela.SelectedIndex = Convert.ToInt32(qtdParcela) - 1;
                        


                    }
                    }
                }
               
                return retorno;                 
        }
        
    }
}
