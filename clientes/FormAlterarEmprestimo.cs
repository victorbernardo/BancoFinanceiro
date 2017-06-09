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

namespace clientes
{
    public partial class FormAlterarEmprestimo : Form
    {
        private Emprestimo emprestimo;
        private Service1Client sv;
        
        public FormAlterarEmprestimo(Emprestimo emprestimo)
        {
            
            InitializeComponent();


            CarregaCampo(emprestimo);

            for (int i = 1; i <= 36; i++)
            {
                cbQtdParcela.Items.Add(i);
            } 
        }
        

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Simulacao();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSalvarAlteracao_Click(object sender, EventArgs e)
        {
            SalvarAlteracao();
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
            decimal taxtaJuros = Decimal.Parse(txtTaxaJuro.Text) / 100;
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
        /*public void RecebeEmprestimo(Emprestimo emprestimo) 
        {
            CarregaCampo(emprestimo);
        }*/
        private void CarregaCampo(Emprestimo emprestimo)
        {
            txtNumeroConta.Text = emprestimo.NumeroConta.NumeroConta.ToString();
            txtNome.Text = emprestimo.NumeroConta.Cliente.Nome;
            txtValor.Text = emprestimo.Valor.ToString();
            cbQtdParcela.Text = emprestimo.QuantidadeParcela.ToString();
        }
        private void SalvarAlteracao()
        {
            if (txtNumeroConta.Text.Equals("") || txtNome.Text.Equals("") || txtValor.Text.Equals("") || cbQtdParcela.Text.Equals(""))
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
                emprestimo.TaxaJurosMensal = Decimal.Parse(txtTaxaJuro.Text);
                emprestimo.QuantidadeParcela = qtdParcela;
                //emprestimo.DataCriacao = DateTime.Now;
                try
                {
                    sv = new Service1Client();
                    sv.AlterarEmprestimo(emprestimo);
                    MessageBox.Show("Alteraçao realizada com sucesso");
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Alterar emprestimo" + ex.Message);
                }
            }
        }

        

       
    }
}
