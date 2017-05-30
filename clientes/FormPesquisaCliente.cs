
using Biblioteca.basica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class FormPesquisaCliente : Form
    {
        private List<Cliente> clientes;
        public FormPesquisaCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carrehaGridClientes();
        }
        private void carrehaGridClientes()
        {
           // clientes.ServiceReference1.Service1Client sv = new clientes.ServiceReference1.Service1Client();


            clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente() {Email = "adauto@adauto",Cpf="123456789",Nome = "Teste Teste",Telefone="81999999999" };
            Cliente cliente2 = new Cliente() { Email = "adauto@adauto020202", Cpf = "11111111111", Nome = "Teste Teste", Telefone = "81999999999" };

            clientes.Add(cliente1);
            clientes.Add(cliente2);
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;

            
            
            

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            this.Close();
      
            /*Essa parte comentada fuciona mas é nécessário selecionar a linha completa
           foreach (DataGridViewRow row in dgvClientes.SelectedRows)
            {
                Cliente cli = row.DataBoundItem as Cliente;
                if (cli != null)
                {
                    MessageBox.Show(cli.Email);
                }
            }*/


            //MessageBox.Show(cliente.Email);
        }

        public Cliente RetornaClienteSelecionado()
        {
            
            Cliente cliente = dgvClientes.CurrentRow != null ? clientes.Find(c => c.Cpf.Equals(dgvClientes.CurrentRow.Cells[2].Value)):null;

            return cliente;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
