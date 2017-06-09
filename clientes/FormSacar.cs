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
using Microsoft.VisualBasic;

namespace clientes
{
    public partial class FormSacar : Form
    {
        private Movimentacao movimentacao;
        private Service1Client sv;
        public FormSacar()
        {
            InitializeComponent();           
            movimentacao = new Movimentacao();
            sv = new Service1Client();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sacar_Click(object sender, EventArgs e)
        {            
            if (txtNumeroConta.Text.Equals("") || txtValor.Text.Equals(""))
                MessageBox.Show("Preencha os campos");
            else if (!Information.IsNumeric(txtNumeroConta.Text) || !Information.IsNumeric(txtValor.Text))
                MessageBox.Show("Voce deve informar só numeros");
            else
            {
                Conta conta = new Conta();
                conta.NumeroConta = Int32.Parse(txtNumeroConta.Text);
                conta.Saldo = decimal.Parse(txtValor.Text);
                movimentacao.Data = DateTime.Now;
                movimentacao.Tipo = "Saque";
                movimentacao.NumeroConta = conta;
                movimentacao.Valor = conta.Saldo;                
                try
                {
                    sv.SacarDinheiro(conta, movimentacao);
                    MessageBox.Show("Saque realizado com sucesso");
                    txtNumeroConta.Text = ("");
                    txtValor.Text = ("");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
    }
}
