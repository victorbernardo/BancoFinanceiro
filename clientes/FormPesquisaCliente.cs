using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importaçao de pacotes
using clientes.localhost2;

namespace clientes
{
    public partial class FormPesquisaCliente : Form
    {
        private List<Cliente> clientes;
        //
        //CONSTRUTOR PADRAO
        //
        public FormPesquisaCliente()
        {
            InitializeComponent();
        }
        //
        //FUNÇOES DOS BOTOES
        //
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carrehaGridClientes();
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
        //
        //FUNÇOES INTERNAS
        //              
        private void carrehaGridClientes()
        {
            clientes = new List<Cliente>();
            Service1 sv = new Service1();
           
            clientes = sv.PesquisaCliente().ToList();           
            dgvClientes.AutoGenerateColumns = false;
            //dgvClientes.DataSource = clientes;

            //dgvClientes.Rows.Add();

            clientes.ForEach(c => dgvClientes.Rows.Add(c.Nome,c.Telefone,c.Cpf, c.Email,c.Endereco.Cidade + ", "+c.Endereco.Cep));



        }
        public Cliente RetornaClienteSelecionado()
        {
            Cliente cliente = dgvClientes.CurrentRow != null ? clientes.Find(c => c.Cpf.Equals(dgvClientes.CurrentRow.Cells[2].Value)) : null;
            return cliente;
        }        
    }
}
