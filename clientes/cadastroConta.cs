using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.basica;
using clientes;

namespace cliente
{
    public partial class cadastroConta : Form
    {
        private Cliente cliente;
        private Agencia agencia;
      
        public cadastroConta()
        {
            InitializeComponent();
    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente fPesquisaCliente = new FormPesquisaCliente();
            fPesquisaCliente.ShowDialog();

            cliente = fPesquisaCliente.RetornaClienteSelecionado();

            MessageBox.Show(cliente !=null ? cliente.Email:"Nulo");
     
           

        }

        private void btnBuscarAgencia_Click(object sender, EventArgs e)
        {
            FormPesquisaAgencia fPesquisaAgencia = new FormPesquisaAgencia();
            fPesquisaAgencia.ShowDialog();


            agencia = fPesquisaAgencia.RetornaAgenciaSelecionado();

            MessageBox.Show(agencia != null ? agencia.Nome : "Nulo");

        }

        private void btnBuscarConta_Click(object sender, EventArgs e)
        {
            FormPesquisaConta fPesquisaConta = new FormPesquisaConta();
            fPesquisaConta.Show();

        }
    }
}
